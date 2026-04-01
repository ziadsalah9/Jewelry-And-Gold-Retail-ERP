Imports System
Imports System.Windows.Forms
Imports System.Configuration
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Collections.Generic

Public Class Form1

#Region "Constants"
    Private Const SQL_CLIENT_PROVIDER As String = "system.data.sqlclient"
    Private Const DPAPI_PROVIDER As String = "DataProtectionConfigurationProvider"
    Private Const LOCAL_SQL_SERVER_NAME As String = "LocalSqlServer"
    Private Const CONNECTION_TIMEOUT As Integer = 8
    Private Const TEST_CONNECTION_TIMEOUT As Integer = 5
    Private Const SAVE_CONNECTION_TIMEOUT As Integer = 15
#End Region

#Region "Private Fields"
    Private connectionStringsCache As New Dictionary(Of String, ConnectionStringSettings)(StringComparer.OrdinalIgnoreCase)
    Private currentConfigFilePath As String = String.Empty
    Private isConfigEncrypted As Boolean = False
#End Region

#Region "Form Events"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeControls()
        AttachEventHandlers()
    End Sub
#End Region

#Region "Control Initialization"
    Private Sub InitializeControls()
        cboServers.DropDownStyle = ComboBoxStyle.DropDown
        cboConnectionNames.DropDownStyle = ComboBoxStyle.DropDownList
        txtConnectTimeout.Text = "15" ' القيمة الافتراضية
    End Sub

    Private Sub AttachEventHandlers()
        AddHandler cboServers.DropDown, AddressOf OnServersDropDown
        AddHandler cboServers.SelectedIndexChanged, AddressOf OnServerSelectionChanged
        AddHandler cboServers.KeyDown, AddressOf OnServerKeyDown
        AddHandler cboServers.LostFocus, AddressOf OnServerLostFocus
        AddHandler cboConnectionNames.SelectedIndexChanged, AddressOf OnConnectionNameSelectionChanged
    End Sub
#End Region

#Region "File Operations"
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using fileDialog As New OpenFileDialog()
            fileDialog.Filter = "Config files (*.config)|*.config|All files (*.*)|*.*"
            fileDialog.Title = "اختر ملف الكونفيج"
            
            If fileDialog.ShowDialog() = DialogResult.OK Then
                LoadConfigurationFile(fileDialog.FileName)
            End If
        End Using
    End Sub

    Private Sub LoadConfigurationFile(configFilePath As String)
        Try
            ClearAllFields()
            currentConfigFilePath = configFilePath
            txtConfigPath.Text = configFilePath

            If Not File.Exists(configFilePath) Then
                ShowErrorMessage("الملف غير موجود")
                Return
            End If

            Dim configuration As Configuration = OpenConfigurationFile(configFilePath)
            If configuration Is Nothing Then Return

            Dim connectionStringsSection As ConnectionStringsSection = configuration.ConnectionStrings
            If connectionStringsSection Is Nothing OrElse connectionStringsSection.ConnectionStrings.Count = 0 Then
                ShowWarningMessage("لا توجد connection strings في الملف")
                Return
            End If

            isConfigEncrypted = connectionStringsSection.SectionInformation.IsProtected
            If isConfigEncrypted Then
                connectionStringsSection.SectionInformation.UnprotectSection()
            End If

            Dim sqlClientConnections As List(Of ConnectionStringSettings) = LoadSqlClientConnections(connectionStringsSection)
            
            If isConfigEncrypted Then
                connectionStringsSection.SectionInformation.ProtectSection(DPAPI_PROVIDER)
            End If

            If sqlClientConnections.Count = 0 Then
                ShowWarningMessage("لا توجد connection strings من نوع SqlClient")
                Return
            End If

            Dim selectedIndex As Integer = GetPreferredConnectionIndex(sqlClientConnections)
            PopulateConnectionNamesComboBox()
            cboConnectionNames.SelectedIndex = selectedIndex
            DisplayConnectionStringDetails(sqlClientConnections(selectedIndex))

        Catch ex As Exception
            ShowErrorMessage("خطأ في قراءة الملف: " & ex.Message)
        End Try
    End Sub

    Private Function OpenConfigurationFile(configFilePath As String) As Configuration
        Try
            Dim fileMap As New ExeConfigurationFileMap()
            fileMap.ExeConfigFilename = configFilePath
            Return ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None)
        Catch ex As Exception
            ShowErrorMessage("فشل فتح ملف الكونفيج: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Function LoadSqlClientConnections(section As ConnectionStringsSection) As List(Of ConnectionStringSettings)
        Dim sqlClientConnections As New List(Of ConnectionStringSettings)()
        
        For Each connectionString As ConnectionStringSettings In section.ConnectionStrings
            If IsSqlClientProvider(connectionString.ProviderName) Then
                sqlClientConnections.Add(connectionString)
                connectionStringsCache(connectionString.Name) = connectionString
            End If
        Next

        Return sqlClientConnections
    End Function

    Private Function IsSqlClientProvider(providerName As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(providerName) AndAlso
               providerName.ToLower().Contains(SQL_CLIENT_PROVIDER)
    End Function

    Private Function GetPreferredConnectionIndex(connections As List(Of ConnectionStringSettings)) As Integer
        For i As Integer = 0 To connections.Count - 1
            If Not connections(i).Name.Equals(LOCAL_SQL_SERVER_NAME, StringComparison.OrdinalIgnoreCase) Then
                Return i
            End If
        Next
        Return 0
    End Function

    Private Sub PopulateConnectionNamesComboBox()
        cboConnectionNames.Items.Clear()
        For Each connectionName As String In connectionStringsCache.Keys
            cboConnectionNames.Items.Add(connectionName)
        Next
    End Sub
#End Region

#Region "Connection String Display"
    Private Sub OnConnectionNameSelectionChanged(sender As Object, e As EventArgs)
        If cboConnectionNames.SelectedItem Is Nothing Then Return

        Dim selectedName As String = cboConnectionNames.SelectedItem.ToString()
        If Not connectionStringsCache.ContainsKey(selectedName) Then Return

        Try
            Dim connectionString As ConnectionStringSettings = connectionStringsCache(selectedName)
            DisplayConnectionStringDetails(connectionString)
        Catch ex As Exception
            ShowErrorMessage("خطأ في قراءة connection string: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplayConnectionStringDetails(connectionString As ConnectionStringSettings)
        Try
            txtCurrentConnection.Text = FormatConnectionStringAsXml(connectionString)

            Dim connectionBuilder As New SqlConnectionStringBuilder(connectionString.ConnectionString)
            PopulateFormFields(connectionBuilder, connectionString)

            lblCurrentInfo.Text = BuildConnectionInfoText(connectionString, connectionBuilder)
            lblCurrentInfo.ForeColor = Color.DarkBlue

            If Not String.IsNullOrWhiteSpace(connectionBuilder.DataSource) Then
                LoadDatabasesFromServer(connectionBuilder.DataSource, 
                                       If(connectionBuilder.IntegratedSecurity, String.Empty, connectionBuilder.UserID),
                                       If(connectionBuilder.IntegratedSecurity, String.Empty, connectionBuilder.Password),
                                       silent:=True)
                
                SelectDatabaseInComboBox(connectionBuilder.InitialCatalog)
            End If

        Catch ex As Exception
            ShowErrorMessage("فشل تحليل connection string: " & ex.Message)
        End Try
    End Sub

    Private Function FormatConnectionStringAsXml(connectionString As ConnectionStringSettings) As String
        Dim xmlBuilder As New StringBuilder()
        xmlBuilder.AppendLine("<add name=""" & connectionString.Name & """")
        xmlBuilder.AppendLine("      connectionString=""" & connectionString.ConnectionString & """")
        
        Dim providerName As String = If(String.IsNullOrWhiteSpace(connectionString.ProviderName), 
                                       String.Empty, 
                                       connectionString.ProviderName)
        xmlBuilder.AppendLine("      providerName=""" & providerName & """ />")
        
        Return xmlBuilder.ToString()
    End Function

    Private Sub PopulateFormFields(builder As SqlConnectionStringBuilder, connectionString As ConnectionStringSettings)
        ' استخراج السيرفر والبورت من DataSource
        Dim dataSource As String = If(String.IsNullOrWhiteSpace(builder.DataSource), String.Empty, builder.DataSource)
        Dim serverName As String = String.Empty
        Dim portNumber As String = String.Empty

        If Not String.IsNullOrWhiteSpace(dataSource) Then
            ' التحقق من وجود البورت في DataSource (مثل: server,port أو server:port)
            Dim commaIndex As Integer = dataSource.LastIndexOf(","c)
            Dim colonIndex As Integer = dataSource.LastIndexOf(":"c)
            
            If commaIndex > 0 AndAlso commaIndex > colonIndex Then
                ' البورت موجود بعد فاصلة
                serverName = dataSource.Substring(0, commaIndex).Trim()
                portNumber = dataSource.Substring(commaIndex + 1).Trim()
            ElseIf colonIndex > 0 AndAlso colonIndex > commaIndex Then
                ' البورت موجود بعد نقطتين
                serverName = dataSource.Substring(0, colonIndex).Trim()
                portNumber = dataSource.Substring(colonIndex + 1).Trim()
            Else
                ' لا يوجد بورت
                serverName = dataSource
            End If
        End If

        cboServers.Text = serverName
        txtPort.Text = portNumber

        ' استخراج Connect Timeout
        Dim timeoutValue As String = If(builder.ConnectTimeout > 0, builder.ConnectTimeout.ToString(), "15")
        txtConnectTimeout.Text = timeoutValue

        cboDatabases.Items.Clear()
        If Not String.IsNullOrWhiteSpace(builder.InitialCatalog) Then
            cboDatabases.Items.Add(builder.InitialCatalog)
            cboDatabases.SelectedIndex = 0
        End If

        If builder.IntegratedSecurity Then
            txtUser.Text = String.Empty
            txtPassword.Text = String.Empty
        Else
            txtUser.Text = If(String.IsNullOrWhiteSpace(builder.UserID), String.Empty, builder.UserID)
            txtPassword.Text = If(String.IsNullOrWhiteSpace(builder.Password), String.Empty, builder.Password)
        End If
    End Sub

    Private Function BuildConnectionInfoText(connectionString As ConnectionStringSettings, 
                                           builder As SqlConnectionStringBuilder) As String
        Dim infoBuilder As New StringBuilder()
        infoBuilder.AppendLine("اسم الاتصال: " & connectionString.Name)
        infoBuilder.AppendLine("Provider: " & If(String.IsNullOrWhiteSpace(connectionString.ProviderName), 
                                                 "غير محدد", 
                                                 connectionString.ProviderName))
        infoBuilder.AppendLine("السيرفر: " & If(String.IsNullOrWhiteSpace(builder.DataSource), 
                                                "غير محدد", 
                                                builder.DataSource))
        infoBuilder.AppendLine("قاعدة البيانات: " & If(String.IsNullOrWhiteSpace(builder.InitialCatalog), 
                                                        "غير محدد", 
                                                        builder.InitialCatalog))
        infoBuilder.AppendLine("نوع المصادقة: " & If(builder.IntegratedSecurity, 
                                                    "Windows Authentication", 
                                                    "SQL Authentication"))
        infoBuilder.AppendLine("الحالة: " & If(isConfigEncrypted, "مشفر ✓", "غير مشفر"))
        
        Return infoBuilder.ToString()
    End Function
#End Region

#Region "Server Operations"
    Private Sub OnServersDropDown(sender As Object, e As EventArgs)
        Try
            Me.Cursor = Cursors.WaitCursor
            
            Dim currentText As String = If(cboServers.Text, String.Empty)
            Dim localServers As List(Of String) = GetLocalSqlServerInstances()
            
            cboServers.Items.Clear()
            For Each server As String In localServers
                cboServers.Items.Add(server)
            Next

            cboServers.Text = currentText
            If String.IsNullOrEmpty(cboServers.Text) AndAlso cboServers.Items.Count > 0 Then
                cboServers.SelectedIndex = 0
            End If

        Catch ex As Exception
            ShowErrorMessage("فشل في جلب السيرفرات: " & ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GetLocalSqlServerInstances() As List(Of String)
        Dim servers As New List(Of String)()
        Dim localMachineName As String = Environment.MachineName

        Try
            Dim dataSources As DataTable = SqlDataSourceEnumerator.Instance.GetDataSources()
            If dataSources IsNot Nothing Then
                For Each row As DataRow In dataSources.Rows
                    Dim serverName As String = Convert.ToString(row("ServerName"))
                    Dim instanceName As String = Convert.ToString(row("InstanceName"))
                    
                    If serverName.Equals(localMachineName, StringComparison.OrdinalIgnoreCase) Then
                        Dim fullName As String = If(String.IsNullOrEmpty(instanceName), 
                                                   serverName, 
                                                   serverName & "\" & instanceName)
                        If Not servers.Contains(fullName) Then
                            servers.Add(fullName)
                        End If
                    End If
                Next
            End If
        Catch
        End Try

        If Not servers.Contains(".") Then servers.Add(".")
        If Not servers.Contains("(local)") Then servers.Add("(local)")

        Return servers
    End Function

    Private Sub OnServerSelectionChanged(sender As Object, e As EventArgs)
        Dim serverName As String = GetSelectedOrTypedServerName()
        If Not String.IsNullOrWhiteSpace(serverName) Then
            LoadDatabasesFromServer(serverName, txtUser.Text, txtPassword.Text)
        End If
    End Sub

    Private Sub OnServerKeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            Dim serverName As String = cboServers.Text.Trim()
            If Not String.IsNullOrWhiteSpace(serverName) Then
                LoadDatabasesFromServer(serverName, txtUser.Text, txtPassword.Text)
            End If
        End If
    End Sub

    Private Sub OnServerLostFocus(sender As Object, e As EventArgs)
        Dim serverName As String = cboServers.Text.Trim()
        If Not String.IsNullOrWhiteSpace(serverName) Then
            LoadDatabasesFromServer(serverName, txtUser.Text, txtPassword.Text)
        End If
    End Sub

    Private Function GetSelectedOrTypedServerName() As String
        If cboServers.SelectedItem IsNot Nothing Then
            Return cboServers.SelectedItem.ToString()
        End If
        Return cboServers.Text
    End Function
#End Region

#Region "Database Operations"
    Private Sub LoadDatabasesFromServer(serverName As String, 
                                       userName As String, 
                                       password As String, 
                                       Optional silent As Boolean = False)
        Try
            Me.Cursor = Cursors.WaitCursor
            cboDatabases.Items.Clear()

            If String.IsNullOrWhiteSpace(serverName) Then
                If Not silent Then
                    ShowWarningMessage("ادخل اسم السيرفر أو عنوان الـ IP.")
                End If
                Return
            End If

            Dim normalizedServer As String = NormalizeServerName(serverName)
            ' تحديد ما إذا كان السيرفر بعيد
            Dim isRemoteServer As Boolean = CheckIfRemoteServer(normalizedServer)
            ' استخدام Connect Timeout من الحقل مع إعدادات الاتصال البعيد
            Dim connectionString As String = BuildConnectionString(normalizedServer, userName, password, "master", -1, forRemoteConnection:=isRemoteServer)

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                
                Dim query As String = "SELECT name FROM sys.databases WHERE database_id > 0 AND state = 0 ORDER BY name"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            cboDatabases.Items.Add(reader.GetString(0))
                        End While
                    End Using
                End Using
            End Using

            If cboDatabases.Items.Count > 0 Then
                cboDatabases.SelectedIndex = 0
            ElseIf Not silent Then
                ShowInfoMessage("تم الاتصال بالسيرفر ولكن لم تُسترجع قواعد بيانات (تحقق من الصلاحيات).")
            End If

        Catch ex As Exception
            If Not silent Then
                ShowErrorMessage("تعذر الاتصال بالسيرفر/جلب قواعد البيانات: " & ex.Message)
            End If
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function NormalizeServerName(serverName As String) As String
        Dim normalized As String = serverName.Trim()
        If normalized.StartsWith("tcp:", StringComparison.OrdinalIgnoreCase) Then
            normalized = normalized.Substring(4)
        End If
        Return normalized
    End Function

    Private Function BuildConnectionString(serverName As String, 
                                          userName As String, 
                                          password As String, 
                                          databaseName As String, 
                                          Optional timeout As Integer = -1,
                                          Optional forRemoteConnection As Boolean = False) As String
        Dim builder As New SqlConnectionStringBuilder()
        
        ' بناء DataSource مع البورت إذا كان موجوداً
        Dim portNumber As String = txtPort.Text.Trim()
        If Not String.IsNullOrWhiteSpace(portNumber) Then
            ' استخدام فاصلة لفصل السيرفر عن البورت (الصيغة القياسية لـ SQL Server)
            builder.DataSource = serverName & "," & portNumber
        Else
            builder.DataSource = serverName
        End If
        
        builder.InitialCatalog = databaseName
        
        ' استخدام Connect Timeout من الحقل إذا كان متاحاً، وإلا استخدام القيمة الممررة
        Dim timeoutValue As Integer
        If timeout >= 0 Then
            timeoutValue = timeout
        Else
            Dim timeoutText As String = txtConnectTimeout.Text.Trim()
            If Not String.IsNullOrWhiteSpace(timeoutText) AndAlso Integer.TryParse(timeoutText, timeoutValue) Then
                ' تم استخدام القيمة من الحقل
            Else
                timeoutValue = 15 ' القيمة الافتراضية
            End If
        End If
        builder.ConnectTimeout = timeoutValue

        ' إعدادات إضافية للاتصالات البعيدة
        If forRemoteConnection Then
            ' تعطيل التشفير للاتصالات البعيدة (إذا كان السيرفر لا يدعم SSL)
            builder.Encrypt = False
            ' السماح بشهادات غير موثوقة (للسيرفرات البعيدة)
            builder.TrustServerCertificate = True
            ' زيادة timeout للاتصالات البعيدة
            If timeoutValue < 30 Then
                builder.ConnectTimeout = 30
            End If
            ' إعدادات شبكة إضافية مشابهة لـ SSMS
            builder.PacketSize = 4096
            builder.ApplicationName = "ConfigEncryptor"
            builder.WorkstationID = Environment.MachineName
            ' تعطيل MultipleActiveResultSets لتحسين الأداء
            builder.MultipleActiveResultSets = False
            ' إعدادات إضافية للاتصالات البعيدة
            builder.PersistSecurityInfo = False
        End If

        If String.IsNullOrWhiteSpace(userName) Then
            builder.IntegratedSecurity = True
        Else
            builder.IntegratedSecurity = False
            builder.UserID = userName
            builder.Password = password
            ' إعدادات إضافية للمصادقة
            builder.PersistSecurityInfo = False
        End If

        Return builder.ConnectionString
    End Function

    Private Sub SelectDatabaseInComboBox(databaseName As String)
        If String.IsNullOrWhiteSpace(databaseName) Then Return

        For i As Integer = 0 To cboDatabases.Items.Count - 1
            If cboDatabases.Items(i).ToString().Equals(databaseName, StringComparison.OrdinalIgnoreCase) Then
                cboDatabases.SelectedIndex = i
                Return
            End If
        Next
    End Sub
#End Region

#Region "Save Operations"
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateSaveInputs() Then Return

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim serverName As String = GetServerName()
            Dim databaseName As String = GetDatabaseName()
            Dim userName As String = txtUser.Text.Trim()
            Dim password As String = txtPassword.Text

            Dim backupPath As String = CreateBackup(currentConfigFilePath)

            SaveConnectionString(serverName, databaseName, userName, password)

            ShowSuccessMessage("تم الحفظ والتشفير بنجاح." & Environment.NewLine & "Backup: " & backupPath)

            LoadConfigurationFile(currentConfigFilePath)

        Catch ex As Exception
            ShowErrorMessage("فشل الحفظ/التشفير: " & ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function ValidateSaveInputs() As Boolean
        If String.IsNullOrWhiteSpace(currentConfigFilePath) OrElse Not File.Exists(currentConfigFilePath) Then
            ShowWarningMessage("اختر ملف الكونفيج أولاً.")
            Return False
        End If

        Dim serverName As String = GetServerName()
        If String.IsNullOrWhiteSpace(serverName) Then
            ShowWarningMessage("ادخل اسم السيرفر.")
            Return False
        End If

        Dim databaseName As String = GetDatabaseName()
        If String.IsNullOrWhiteSpace(databaseName) Then
            ShowWarningMessage("ادخل اسم قاعدة البيانات.")
            Return False
        End If

        Return True
    End Function

    Private Function GetServerName() As String
        If cboServers.Text IsNot Nothing Then
            Return cboServers.Text.Trim()
        End If
        Return String.Empty
    End Function

    Private Function GetDatabaseName() As String
        If cboDatabases.SelectedItem IsNot Nothing Then
            Return cboDatabases.SelectedItem.ToString().Trim()
        ElseIf Not String.IsNullOrWhiteSpace(cboDatabases.Text) Then
            Return cboDatabases.Text.Trim()
        End If
        Return String.Empty
    End Function

    Private Function CreateBackup(configFilePath As String) As String
        Dim backupPath As String = configFilePath & ".bak"
        File.Copy(configFilePath, backupPath, overwrite:=True)
        Return backupPath
    End Function

    Private Sub SaveConnectionString(serverName As String, 
                                     databaseName As String, 
                                     userName As String, 
                                     password As String)
        Dim configuration As Configuration = OpenConfigurationFile(currentConfigFilePath)
        If configuration Is Nothing Then
            Throw New Exception("فشل فتح ملف الكونفيج")
        End If

        Dim connectionStringsSection As ConnectionStringsSection = configuration.ConnectionStrings
        If connectionStringsSection Is Nothing Then
            Throw New Exception("لا توجد connectionStrings section في الملف")
        End If

        Dim wasProtected As Boolean = connectionStringsSection.SectionInformation.IsProtected
        If wasProtected Then
            connectionStringsSection.SectionInformation.UnprotectSection()
        End If

        Dim targetConnection As ConnectionStringSettings = FindTargetConnectionString(connectionStringsSection)
        If targetConnection Is Nothing Then
            Throw New Exception("لم يتم العثور على connection string من نوع SqlClient")
        End If

        ' استخدام Connect Timeout من الحقل
        Dim newConnectionString As String = BuildConnectionString(serverName, userName, password, databaseName)
        Dim connectionName As String = If(cboConnectionNames.SelectedItem IsNot Nothing, 
                                          cboConnectionNames.SelectedItem.ToString(), 
                                          targetConnection.Name)

        connectionStringsSection.ConnectionStrings.Remove(connectionName)
        connectionStringsSection.ConnectionStrings.Add(New ConnectionStringSettings(connectionName, 
                                                                                    newConnectionString, 
                                                                                    targetConnection.ProviderName))

        configuration.Save(ConfigurationSaveMode.Minimal, forceSaveAll:=True)

        connectionStringsSection = configuration.ConnectionStrings
        If Not connectionStringsSection.SectionInformation.IsProtected Then
            connectionStringsSection.SectionInformation.ProtectSection(DPAPI_PROVIDER)
            connectionStringsSection.SectionInformation.ForceSave = True
            configuration.Save(ConfigurationSaveMode.Full, forceSaveAll:=True)
        End If
    End Sub

    Private Function FindTargetConnectionString(section As ConnectionStringsSection) As ConnectionStringSettings
        If cboConnectionNames.SelectedItem IsNot Nothing Then
            Dim selectedName As String = cboConnectionNames.SelectedItem.ToString()
            For Each connectionString As ConnectionStringSettings In section.ConnectionStrings
                If connectionString.Name.Equals(selectedName, StringComparison.OrdinalIgnoreCase) AndAlso
                   IsSqlClientProvider(connectionString.ProviderName) Then
                    Return connectionString
                End If
            Next
        End If

        For Each connectionString As ConnectionStringSettings In section.ConnectionStrings
            If IsSqlClientProvider(connectionString.ProviderName) Then
                Return connectionString
            End If
        Next

        If section.ConnectionStrings.Count > 0 Then
            Return section.ConnectionStrings(0)
        End If

        Return Nothing
    End Function
#End Region

#Region "Connection Testing"
    Private Sub btnOpenConnection_Click(sender As Object, e As EventArgs) Handles btnOpenConnection.Click
        Dim serverName As String = GetServerName()
        If String.IsNullOrWhiteSpace(serverName) Then
            ShowWarningMessage("ادخل اسم السيرفر أولاً.")
            Return
        End If

        Dim databaseName As String = GetDatabaseName()
        If String.IsNullOrWhiteSpace(databaseName) Then
            ShowWarningMessage("ادخل اسم قاعدة البيانات أولاً.")
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            btnOpenConnection.Enabled = False

            Dim normalizedServer As String = NormalizeServerName(serverName)
            Dim isRemoteServer As Boolean = CheckIfRemoteServer(normalizedServer)
            Dim connectionString As String = BuildConnectionString(normalizedServer, 
                                                                  txtUser.Text.Trim(), 
                                                                  txtPassword.Text, 
                                                                  databaseName, 
                                                                  CONNECTION_TIMEOUT,
                                                                  forRemoteConnection:=isRemoteServer)

            Using connection As New SqlConnection(connectionString)
                connection.Open()
                
                Dim form2 As New Form2(connectionString, databaseName)
                form2.Show()
            End Using

        Catch ex As Exception
            ShowErrorMessage("فشل الاتصال بالسيرفر:" & Environment.NewLine & ex.Message)
        Finally
            Me.Cursor = Cursors.Default
            btnOpenConnection.Enabled = True
        End Try
    End Sub

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        Dim serverName As String = GetServerName()
        If String.IsNullOrWhiteSpace(serverName) Then
            ShowWarningMessage("ادخل اسم السيرفر أولاً.")
            Return
        End If

        Dim databaseName As String = GetDatabaseName()
        If String.IsNullOrWhiteSpace(databaseName) Then
            ShowWarningMessage("اختر قاعدة البيانات أولاً أو أدخل اسمها.")
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            btnTestConnection.Enabled = False
            HideErrorDetails()

            Dim normalizedServer As String = NormalizeServerName(serverName)
            
            ' تحديد ما إذا كان السيرفر بعيد (IP address)
            Dim isRemoteServer As Boolean = CheckIfRemoteServer(normalizedServer)
            
            ' محاولة الاتصال مع إعدادات الاتصال البعيد
            Dim connectionString As String = BuildConnectionString(normalizedServer, 
                                                                  txtUser.Text.Trim(), 
                                                                  txtPassword.Text, 
                                                                  databaseName,
                                                                  -1,
                                                                  forRemoteConnection:=isRemoteServer)

            ' محاولة الاتصال مع إعدادات مختلفة إذا فشلت المحاولة الأولى
            Dim connectionAttempts As New List(Of String)()
            connectionAttempts.Add(connectionString)
            
            ' إضافة محاولات بديلة بإعدادات مختلفة
            If isRemoteServer Then
                ' محاولة مع Encrypt=True و TrustServerCertificate=True (للإصدارات الحديثة)
                Dim altBuilder As New SqlConnectionStringBuilder(connectionString)
                altBuilder.Encrypt = True
                altBuilder.TrustServerCertificate = True
                connectionAttempts.Add(altBuilder.ConnectionString)
                
                ' محاولة مع timeout أطول
                Dim timeoutBuilder As New SqlConnectionStringBuilder(connectionString)
                timeoutBuilder.ConnectTimeout = 60
                connectionAttempts.Add(timeoutBuilder.ConnectionString)
            End If

            Dim connectionSucceeded As Boolean = False
            Dim lastException As Exception = Nothing

            For Each connStr As String In connectionAttempts
                Try
                    Using connection As New SqlConnection(connStr)
                        connection.Open()
                        
                        Dim serverInfo As String = String.Empty
                        Try
                            Using command As New SqlCommand("SELECT @@VERSION, @@SERVERNAME, DB_NAME()", connection)
                                Using reader As SqlDataReader = command.ExecuteReader()
                                    If reader.Read() Then
                                        Dim version As String = reader.GetString(0)
                                        Dim serverNameFromDb As String = If(reader.IsDBNull(1), "غير معروف", reader.GetString(1))
                                        Dim currentDb As String = If(reader.IsDBNull(2), "غير معروف", reader.GetString(2))
                                        serverInfo = "اسم السيرفر: " & serverNameFromDb & Environment.NewLine &
                                                   "قاعدة البيانات الحالية: " & currentDb
                                    End If
                                End Using
                            End Using
                        Catch
                            ' إذا فشل جلب المعلومات، نكتفي بالاتصال الناجح
                        End Try

                        Dim successMessage As String = "تم الاتصال بنجاح!" & Environment.NewLine &
                                                     "السيرفر: " & serverName & Environment.NewLine
                        If Not String.IsNullOrEmpty(serverInfo) Then
                            successMessage &= serverInfo
                        End If
                        
                        ShowSuccessMessage(successMessage)
                        HideErrorDetails()
                        connectionSucceeded = True
                        Exit For
                    End Using
                Catch ex As Exception
                    lastException = ex
                    ' استمر في المحاولة التالية
                End Try
            Next

            If Not connectionSucceeded Then
                ' إذا فشلت جميع المحاولات، ارمي آخر خطأ
                Throw lastException
            End If

        Catch ex As SqlException
            Dim errorMessage As String = "فشل الاتصال بالسيرفر:" & Environment.NewLine
            errorMessage &= "الخطأ: " & ex.Message & Environment.NewLine
            
            Dim detailedError As New StringBuilder()
            detailedError.AppendLine("═══════════════════════════════════════════════════")
            detailedError.AppendLine("تفاصيل خطأ الاتصال بالسيرفر")
            detailedError.AppendLine("═══════════════════════════════════════════════════")
            detailedError.AppendLine()
            detailedError.AppendLine("السيرفر: " & serverName)
            detailedError.AppendLine("البورت: " & If(String.IsNullOrWhiteSpace(txtPort.Text), "1433 (افتراضي)", txtPort.Text))
            detailedError.AppendLine("قاعدة البيانات: " & databaseName)
            detailedError.AppendLine("اسم المستخدم: " & If(String.IsNullOrWhiteSpace(txtUser.Text), "غير محدد", txtUser.Text))
            detailedError.AppendLine("Timeout: " & If(String.IsNullOrWhiteSpace(txtConnectTimeout.Text), "15", txtConnectTimeout.Text) & " ثانية")
            detailedError.AppendLine()
            detailedError.AppendLine("═══════════════════════════════════════════════════")
            detailedError.AppendLine("معلومات الخطأ:")
            detailedError.AppendLine("═══════════════════════════════════════════════════")
            detailedError.AppendLine()
            detailedError.AppendLine("الخطأ: " & ex.Message)
            detailedError.AppendLine("رقم الخطأ: " & ex.Number)
            detailedError.AppendLine("Class: " & ex.Class)
            detailedError.AppendLine("State: " & ex.State)
            detailedError.AppendLine("Server: " & If(String.IsNullOrEmpty(ex.Server), "غير متاح", ex.Server))
            detailedError.AppendLine("Procedure: " & If(String.IsNullOrEmpty(ex.Procedure), "غير متاح", ex.Procedure))
            detailedError.AppendLine("Line Number: " & ex.LineNumber)
            
            If ex.InnerException IsNot Nothing Then
                detailedError.AppendLine()
                detailedError.AppendLine("Inner Exception: " & ex.InnerException.Message)
                detailedError.AppendLine("Inner Exception Type: " & ex.InnerException.GetType().Name)
            End If
            
            ' إضافة معلومات إضافية حسب نوع الخطأ
            detailedError.AppendLine()
            detailedError.AppendLine("═══════════════════════════════════════════════════")
            detailedError.AppendLine("تلميحات الحل:")
            detailedError.AppendLine("═══════════════════════════════════════════════════")
            detailedError.AppendLine()
            
            Select Case ex.Number
                Case -1
                    errorMessage &= Environment.NewLine & "تلميح: تحقق من:" & Environment.NewLine &
                                   "- اسم السيرفر أو عنوان IP صحيح" & Environment.NewLine &
                                   "- السيرفر متاح على الشبكة" & Environment.NewLine &
                                   "- البورت مفتوح (افتراضي: 1433)" & Environment.NewLine &
                                   "- اسم المستخدم وكلمة المرور صحيحة"
                    detailedError.AppendLine("نوع الخطأ: Timeout - انتهت مهلة الاتصال")
                    detailedError.AppendLine()
                    detailedError.AppendLine("الحلول المقترحة:")
                    detailedError.AppendLine("• تحقق من اسم السيرفر أو عنوان IP: " & serverName)
                    detailedError.AppendLine("• تأكد من أن السيرفر متاح على الشبكة")
                    detailedError.AppendLine("• تحقق من أن البورت " & If(String.IsNullOrWhiteSpace(txtPort.Text), "1433", txtPort.Text) & " مفتوح")
                    detailedError.AppendLine("• تأكد من صحة اسم المستخدم وكلمة المرور")
                    detailedError.AppendLine("• جرب زيادة قيمة Timeout (القيمة الحالية: " & If(String.IsNullOrWhiteSpace(txtConnectTimeout.Text), "15", txtConnectTimeout.Text) & ")")
                    detailedError.AppendLine("• تحقق من إعدادات الجدار الناري")
                    detailedError.AppendLine("• تأكد من أن SQL Server Browser يعمل")
                    detailedError.AppendLine("• تحقق من أن SQL Server مسموح به في Windows Firewall")
                Case 2
                    errorMessage &= Environment.NewLine & "تلميح: لا يمكن الوصول إلى السيرفر. تحقق من:" & Environment.NewLine &
                                   "- اتصال الشبكة" & Environment.NewLine &
                                   "- إعدادات الجدار الناري" & Environment.NewLine &
                                   "- السيرفر يعمل"
                    detailedError.AppendLine("نوع الخطأ: Network Error - لا يمكن الوصول إلى السيرفر")
                    detailedError.AppendLine()
                    detailedError.AppendLine("الحلول المقترحة:")
                    detailedError.AppendLine("• تحقق من اتصال الشبكة")
                    detailedError.AppendLine("• تأكد من أن السيرفر يعمل")
                    detailedError.AppendLine("• تحقق من إعدادات الجدار الناري")
                    detailedError.AppendLine("• تأكد من أن SQL Server مسموح به في Windows Firewall")
                    detailedError.AppendLine("• جرب ping للسيرفر: ping " & serverName)
                    detailedError.AppendLine("• تحقق من أن SQL Server يستمع على البورت الصحيح")
                Case 18456
                    errorMessage &= Environment.NewLine & "تلميح: خطأ في المصادقة. تحقق من:" & Environment.NewLine &
                                   "- اسم المستخدم صحيح" & Environment.NewLine &
                                   "- كلمة المرور صحيحة" & Environment.NewLine &
                                   "- نوع المصادقة (SQL Server Authentication)"
                    detailedError.AppendLine("نوع الخطأ: Authentication Failed - فشل المصادقة")
                    detailedError.AppendLine()
                    detailedError.AppendLine("الحلول المقترحة:")
                    detailedError.AppendLine("• تحقق من صحة اسم المستخدم: " & If(String.IsNullOrWhiteSpace(txtUser.Text), "غير محدد", txtUser.Text))
                    detailedError.AppendLine("• تحقق من صحة كلمة المرور")
                    detailedError.AppendLine("• تأكد من أن نوع المصادقة هو SQL Server Authentication")
                    detailedError.AppendLine("• تحقق من أن المستخدم لديه صلاحيات للوصول إلى السيرفر")
                    detailedError.AppendLine("• تأكد من أن SQL Server Authentication مفعل")
                Case 258
                    errorMessage &= Environment.NewLine & "تلميح: انتهت مهلة الاتصال. تحقق من:" & Environment.NewLine &
                                   "- اتصال الشبكة" & Environment.NewLine &
                                   "- البورت الصحيح (افتراضي: 1433)" & Environment.NewLine &
                                   "- إعدادات الجدار الناري" & Environment.NewLine &
                                   "- زيادة قيمة Timeout"
                    detailedError.AppendLine("نوع الخطأ: Connection Timeout - انتهت مهلة الاتصال")
                    detailedError.AppendLine()
                    detailedError.AppendLine("الحلول المقترحة:")
                    detailedError.AppendLine("• تحقق من اسم السيرفر أو عنوان IP: " & serverName)
                    detailedError.AppendLine("• تأكد من أن البورت صحيح: " & If(String.IsNullOrWhiteSpace(txtPort.Text), "1433 (افتراضي)", txtPort.Text))
                    detailedError.AppendLine("  ⚠️ ملاحظة مهمة: البورت الافتراضي لـ SQL Server هو 1433")
                    detailedError.AppendLine("  - إذا كان البورت 1443، تأكد من أن السيرفر يستمع على هذا البورت")
                    detailedError.AppendLine("  - جرب البورت 1433 إذا لم تكن متأكداً")
                    detailedError.AppendLine("• جرب زيادة قيمة Timeout (القيمة الحالية: " & If(String.IsNullOrWhiteSpace(txtConnectTimeout.Text), "15", txtConnectTimeout.Text) & " ثانية)")
                    detailedError.AppendLine("  - جرب قيم أكبر مثل 30 أو 60 ثانية للاتصالات البعيدة")
                    detailedError.AppendLine("• تحقق من اتصال الشبكة:")
                    detailedError.AppendLine("  - جرب ping للسيرفر: ping " & serverName)
                    detailedError.AppendLine("  - جرب telnet للبورت: telnet " & serverName & " " & If(String.IsNullOrWhiteSpace(txtPort.Text), "1433", txtPort.Text))
                    detailedError.AppendLine("• تحقق من إعدادات الجدار الناري:")
                    detailedError.AppendLine("  - تأكد من أن البورت " & If(String.IsNullOrWhiteSpace(txtPort.Text), "1433", txtPort.Text) & " مفتوح")
                    detailedError.AppendLine("  - تحقق من Windows Firewall على جهازك")
                    detailedError.AppendLine("  - تحقق من جدار الناري على السيرفر")
                    detailedError.AppendLine("  - تحقق من جدار الناري في الشبكة (Router/Firewall)")
                    detailedError.AppendLine("• تحقق من إعدادات SQL Server:")
                    detailedError.AppendLine("  - تأكد من أن SQL Server يعمل")
                    detailedError.AppendLine("  - تأكد من أن SQL Server Browser يعمل (إذا كان هناك instance name)")
                    detailedError.AppendLine("  - تحقق من أن SQL Server يستمع على البورت الصحيح")
                    detailedError.AppendLine("  - تحقق من أن Remote Connections مفعلة في SQL Server Configuration Manager")
                    detailedError.AppendLine("• إذا كان السيرفر بعيداً:")
                    detailedError.AppendLine("  - تحقق من أن السيرفر متاح على الإنترنت")
                    detailedError.AppendLine("  - تحقق من أن ISP لا يحجب البورت")
                    detailedError.AppendLine("  - جرب الاتصال من جهاز آخر للتأكد من المشكلة")
                    detailedError.AppendLine("  - تحقق من أن السيرفر لا يحتاج VPN للوصول")
            End Select
            
            If ex.Number <> -1 AndAlso ex.Number <> 2 AndAlso ex.Number <> 18456 AndAlso ex.Number <> 258 Then
                detailedError.AppendLine("نوع الخطأ: SQL Server Error #" & ex.Number)
                detailedError.AppendLine()
                detailedError.AppendLine("الحلول المقترحة:")
                detailedError.AppendLine("• راجع رسالة الخطأ أعلاه")
                detailedError.AppendLine("• تحقق من إعدادات الاتصال")
                detailedError.AppendLine("• تأكد من أن SQL Server يعمل بشكل صحيح")
                detailedError.AppendLine("• راجع Stack Trace لمزيد من التفاصيل")
            End If
            
            ShowErrorMessage(errorMessage, detailedError.ToString())
        Catch ex As Exception
            Dim errorMessage As String = "فشل الاتصال بالسيرفر:" & Environment.NewLine & ex.Message
            
            Dim dbName As String = GetDatabaseName()
            If String.IsNullOrWhiteSpace(dbName) Then
                dbName = "غير محدد"
            End If
            
            Dim detailedError As New StringBuilder()
            detailedError.AppendLine("═══════════════════════════════════════════════════")
            detailedError.AppendLine("تفاصيل خطأ الاتصال بالسيرفر")
            detailedError.AppendLine("═══════════════════════════════════════════════════")
            detailedError.AppendLine()
            detailedError.AppendLine("السيرفر: " & serverName)
            detailedError.AppendLine("البورت: " & If(String.IsNullOrWhiteSpace(txtPort.Text), "1433 (افتراضي)", txtPort.Text))
            detailedError.AppendLine("قاعدة البيانات: " & dbName)
            detailedError.AppendLine("اسم المستخدم: " & If(String.IsNullOrWhiteSpace(txtUser.Text), "غير محدد", txtUser.Text))
            detailedError.AppendLine("Timeout: " & If(String.IsNullOrWhiteSpace(txtConnectTimeout.Text), "15", txtConnectTimeout.Text) & " ثانية")
            detailedError.AppendLine()
            detailedError.AppendLine("═══════════════════════════════════════════════════")
            detailedError.AppendLine("معلومات الخطأ:")
            detailedError.AppendLine("═══════════════════════════════════════════════════")
            detailedError.AppendLine()
            detailedError.AppendLine("نوع الخطأ: " & ex.GetType().Name)
            detailedError.AppendLine("الرسالة: " & ex.Message)
            detailedError.AppendLine("Stack Trace: " & ex.StackTrace)
            
            If ex.InnerException IsNot Nothing Then
                errorMessage &= Environment.NewLine & "تفاصيل: " & ex.InnerException.Message
                detailedError.AppendLine()
                detailedError.AppendLine("Inner Exception:")
                detailedError.AppendLine("  Type: " & ex.InnerException.GetType().Name)
                detailedError.AppendLine("  Message: " & ex.InnerException.Message)
                detailedError.AppendLine("  Stack Trace: " & ex.InnerException.StackTrace)
            End If
            
            detailedError.AppendLine()
            detailedError.AppendLine("═══════════════════════════════════════════════════")
            detailedError.AppendLine("الحلول المقترحة:")
            detailedError.AppendLine("═══════════════════════════════════════════════════")
            detailedError.AppendLine()
            detailedError.AppendLine("• تحقق من إعدادات الاتصال")
            detailedError.AppendLine("• تأكد من أن SQL Server يعمل")
            detailedError.AppendLine("• تحقق من اتصال الشبكة")
            detailedError.AppendLine("• راجع Stack Trace أعلاه لمزيد من التفاصيل")
            
            ShowErrorMessage(errorMessage, detailedError.ToString())
        Finally
            Me.Cursor = Cursors.Default
            btnTestConnection.Enabled = True
        End Try
    End Sub
#End Region

#Region "Helper Methods"
    Private Function CheckIfRemoteServer(serverName As String) As Boolean
        If String.IsNullOrWhiteSpace(serverName) Then Return False
        
        ' التحقق إذا كان عنوان IP
        Dim parts As String() = serverName.Split("."c)
        If parts.Length = 4 Then
            Dim isIp As Boolean = True
            For Each part As String In parts
                Dim num As Integer
                If Not Integer.TryParse(part, num) OrElse num < 0 OrElse num > 255 Then
                    isIp = False
                    Exit For
                End If
            Next
            If isIp Then Return True
        End If
        
        ' التحقق إذا كان اسم سيرفر بعيد (ليس localhost أو . أو (local))
        Dim lowerServer As String = serverName.ToLower()
        If lowerServer = "localhost" OrElse lowerServer = "." OrElse lowerServer = "(local)" Then
            Return False
        End If
        
        ' إذا كان يحتوي على IP أو عنوان بعيد واضح
        Return True
    End Function
    Private Sub ClearAllFields()
        lblCurrentInfo.Text = String.Empty
        txtCurrentConnection.Text = String.Empty
        cboServers.Text = String.Empty
        txtPort.Text = String.Empty
        txtConnectTimeout.Text = "15"
        cboDatabases.Items.Clear()
        cboDatabases.Text = String.Empty
        txtUser.Text = String.Empty
        txtPassword.Text = String.Empty
        cboConnectionNames.Items.Clear()
        connectionStringsCache.Clear()
    End Sub

    Private Sub ShowErrorMessage(message As String, Optional detailedError As String = Nothing)
        lblCurrentInfo.Text = message
        lblCurrentInfo.ForeColor = Color.Red
        
        ' عرض التفاصيل في RichTextBox
        If Not String.IsNullOrEmpty(detailedError) Then
            DisplayErrorDetails(detailedError)
        Else
            DisplayErrorDetails(message)
        End If
        
        MessageBox.Show(message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    
    Private Sub DisplayErrorDetails(errorText As String)
        rtbErrorDetails.Visible = True
        rtbErrorDetails.Clear()
        
        ' تنسيق النص
        rtbErrorDetails.SelectionFont = New Font("Tahoma", 10, FontStyle.Bold)
        rtbErrorDetails.SelectionColor = Color.Red
        rtbErrorDetails.AppendText("═══════════════════════════════════════════════════" & Environment.NewLine)
        rtbErrorDetails.AppendText("تفاصيل الخطأ:" & Environment.NewLine)
        rtbErrorDetails.AppendText("═══════════════════════════════════════════════════" & Environment.NewLine & Environment.NewLine)
        
        ' تقسيم النص إلى أقسام
        Dim lines As String() = errorText.Split(New String() {Environment.NewLine, vbCrLf, vbLf}, StringSplitOptions.None)
        
        For Each line As String In lines
            If String.IsNullOrWhiteSpace(line) Then
                rtbErrorDetails.AppendText(Environment.NewLine)
                Continue For
            End If
            
            ' تحديد نوع السطر وتنسيقه
            If line.Contains("الخطأ:") OrElse line.Contains("Error:") Then
                rtbErrorDetails.SelectionFont = New Font("Tahoma", 9, FontStyle.Bold)
                rtbErrorDetails.SelectionColor = Color.Orange
                rtbErrorDetails.AppendText(line & Environment.NewLine)
            ElseIf line.Contains("تلميح:") OrElse line.Contains("Hint:") OrElse line.Contains("تحقق من:") Then
                rtbErrorDetails.SelectionFont = New Font("Tahoma", 9, FontStyle.Bold)
                rtbErrorDetails.SelectionColor = Color.Yellow
                rtbErrorDetails.AppendText(Environment.NewLine & line & Environment.NewLine)
            ElseIf line.StartsWith("-") OrElse line.StartsWith("•") Then
                rtbErrorDetails.SelectionFont = New Font("Tahoma", 9, FontStyle.Regular)
                rtbErrorDetails.SelectionColor = Color.LightGray
                rtbErrorDetails.AppendText("  " & line & Environment.NewLine)
            ElseIf line.Contains("provider:") OrElse line.Contains("error:") OrElse line.Contains("timeout") Then
                rtbErrorDetails.SelectionFont = New Font("Tahoma", 9, FontStyle.Italic)
                rtbErrorDetails.SelectionColor = Color.LightCoral
                rtbErrorDetails.AppendText(line & Environment.NewLine)
            Else
                rtbErrorDetails.SelectionFont = New Font("Tahoma", 9, FontStyle.Regular)
                rtbErrorDetails.SelectionColor = Color.White
                rtbErrorDetails.AppendText(line & Environment.NewLine)
            End If
        Next
        
        rtbErrorDetails.AppendText(Environment.NewLine)
        rtbErrorDetails.SelectionFont = New Font("Tahoma", 8, FontStyle.Italic)
        rtbErrorDetails.SelectionColor = Color.Gray
        rtbErrorDetails.AppendText("═══════════════════════════════════════════════════" & Environment.NewLine)
        rtbErrorDetails.AppendText("الوقت: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & Environment.NewLine)
        rtbErrorDetails.AppendText("═══════════════════════════════════════════════════")
        
        ' التمرير إلى الأعلى
        rtbErrorDetails.SelectionStart = 0
        rtbErrorDetails.ScrollToCaret()
    End Sub
    
    Private Sub HideErrorDetails()
        rtbErrorDetails.Visible = False
        rtbErrorDetails.Clear()
    End Sub

    Private Sub ShowWarningMessage(message As String)
        lblCurrentInfo.Text = message
        lblCurrentInfo.ForeColor = Color.Orange
        MessageBox.Show(message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub ShowInfoMessage(message As String)
        MessageBox.Show(message, "ملاحظة", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowSuccessMessage(message As String)
        MessageBox.Show(message, "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

End Class
