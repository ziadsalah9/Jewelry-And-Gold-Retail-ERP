Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Collections.Generic

Public Class Form2

    Private connectionString As String = String.Empty
    Private databaseName As String = String.Empty
    Private Shared formCounter As Integer = 0

    Public Sub New(connString As String, dbName As String)
        InitializeComponent()
        connectionString = connString
        databaseName = dbName
        Me.Text = "بيانات قاعدة البيانات: " & dbName
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDatabaseData()
        AddHandler chkBuySelectAll.CheckedChanged, AddressOf chkBuySelectAll_CheckedChanged
        AddHandler chkSellSelectAll.CheckedChanged, AddressOf chkSellSelectAll_CheckedChanged
        AddHandler chkDiamondSelectAll.CheckedChanged, AddressOf chkDiamondSelectAll_CheckedChanged
        AddHandler chkDiamondBuySelectAll.CheckedChanged, AddressOf chkDiamondBuySelectAll_CheckedChanged
        AddHandler lstInactiveInvoices.DoubleClick, AddressOf lstInactiveInvoices_DoubleClick
        AddHandler radBuyInvoice.CheckedChanged, AddressOf radBuyInvoice_CheckedChanged
        AddHandler radSellInvoice.CheckedChanged, AddressOf radSellInvoice_CheckedChanged
        AddHandler radDiamondInvoice.CheckedChanged, AddressOf radDiamondInvoice_CheckedChanged
        AddHandler radDiamondBuyInvoice.CheckedChanged, AddressOf radDiamondBuyInvoice_CheckedChanged
    End Sub

    Private Sub lstInactiveInvoices_DoubleClick(sender As Object, e As EventArgs)
        If lstInactiveInvoices.SelectedItem IsNot Nothing Then
            txtInvoiceNo.Text = lstInactiveInvoices.SelectedItem.ToString()
            btnSearchInvoice_Click(sender, e)
        End If
    End Sub

    Private Sub chkBuySelectAll_CheckedChanged(sender As Object, e As EventArgs)
        Dim isChecked As Boolean = chkBuySelectAll.Checked
        chkBuyGold.Checked = isChecked
        chkBuyCastomerDETELS.Checked = isChecked
        chkBuyBayGoledMony.Checked = isChecked
        chkBuyCacher.Checked = isChecked
        chkBuyPayMethod.Checked = isChecked
        chkBuySettings.Checked = isChecked
        chkBuyCompInform.Checked = isChecked
    End Sub

    Private Sub chkSellSelectAll_CheckedChanged(sender As Object, e As EventArgs)
        Dim isChecked As Boolean = chkSellSelectAll.Checked
        chkSellBAY.Checked = isChecked
        chkSellInvoceDetels.Checked = isChecked
        chkSellCastomerDETELS.Checked = isChecked
        chkSellFOMin.Checked = isChecked
        chkSellCacher.Checked = isChecked
        chkSellPayMethod.Checked = isChecked
        chkSellSettings.Checked = isChecked
        chkSellCompInform.Checked = isChecked
    End Sub

    Private Sub chkDiamondSelectAll_CheckedChanged(sender As Object, e As EventArgs)
        Dim isChecked As Boolean = chkDiamondSelectAll.Checked
        chkDiamondInvce.Checked = isChecked
        chkDiamondBay.Checked = isChecked
        chkDiamondCastomerDETELS.Checked = isChecked
        chkDiamondDetels.Checked = isChecked
        chkDiamondCacher.Checked = isChecked
        chkDiamondPayMethod.Checked = isChecked
        chkDiamondSettings.Checked = isChecked
        chkDiamondCompInform.Checked = isChecked
    End Sub

    Private Sub radBuyInvoice_CheckedChanged(sender As Object, e As EventArgs)
        If radBuyInvoice.Checked Then
            tabInvoiceType.SelectedTab = tabBuy
        End If
    End Sub

    Private Sub radSellInvoice_CheckedChanged(sender As Object, e As EventArgs)
        If radSellInvoice.Checked Then
            tabInvoiceType.SelectedTab = tabSell
        End If
    End Sub

    Private Sub radDiamondInvoice_CheckedChanged(sender As Object, e As EventArgs)
        If radDiamondInvoice.Checked Then
            tabInvoiceType.SelectedTab = tabDiamond
        End If
    End Sub

    Private Sub radDiamondBuyInvoice_CheckedChanged(sender As Object, e As EventArgs)
        If radDiamondBuyInvoice.Checked Then
            tabInvoiceType.SelectedTab = tabDiamondBuy
        End If
    End Sub

    Private Sub chkDiamondBuySelectAll_CheckedChanged(sender As Object, e As EventArgs)
        Dim isChecked As Boolean = chkDiamondBuySelectAll.Checked
        chkBuyDiamond.Checked = isChecked
        chkBayDiamondMony.Checked = isChecked
        chkDiamondBuyCastomerDETELS.Checked = isChecked
        chkDiamondBuyCacher.Checked = isChecked
        chkDiamondBuyPayMethod.Checked = isChecked
        chkDiamondBuySettings.Checked = isChecked
    End Sub

    Private Sub LoadDatabaseData()
        Try
            Me.Cursor = Cursors.WaitCursor
            dgvData.DataSource = Nothing

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT TABLE_SCHEMA, TABLE_NAME, TABLE_TYPE " &
                                      "FROM INFORMATION_SCHEMA.TABLES " &
                                      "ORDER BY TABLE_SCHEMA, TABLE_NAME"

                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    dgvData.DataSource = dataTable
                End Using
            End Using

            lblStatus.Text = "تم تحميل البيانات بنجاح"
            lblStatus.ForeColor = Color.Green

        Catch ex As Exception
            lblStatus.Text = "خطأ في تحميل البيانات: " & ex.Message
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("فشل تحميل البيانات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadDatabaseData()
    End Sub

    Private Sub btnShowCashiers_Click(sender As Object, e As EventArgs) Handles btnShowCashiers.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim tableName As String = "cacher"
            Dim whereClause As String = "1=1"
            Dim paramValue As String = ""

            Dim tableDataForm As New FormTableData(tableName, connectionString, "", whereClause, paramValue)
            tableDataForm.Text = "جميع الكاشيرات - " & tableName
            PositionForm(tableDataForm)
            tableDataForm.Show()

        Catch ex As Exception
            MessageBox.Show("خطأ في عرض الكاشيرات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnSearchInvoice_Click(sender As Object, e As EventArgs) Handles btnSearchInvoice.Click
        If String.IsNullOrWhiteSpace(txtInvoiceNo.Text) Then
            MessageBox.Show("ادخل رقم الفاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim invoiceId As String = txtInvoiceNo.Text.Trim()
            Dim isBuyInvoice As Boolean = radBuyInvoice.Checked
            Dim isDiamondInvoice As Boolean = radDiamondInvoice.Checked
            Dim isDiamondBuyInvoice As Boolean = radDiamondBuyInvoice.Checked

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = String.Empty
                If isBuyInvoice Then
                    query = "SELECT * FROM ReportGoldBuyInvoice WHERE inv_id = N'" & invoiceId & "'"
                ElseIf isDiamondBuyInvoice Then
                    query = "SELECT * FROM ReportDiamondBuyInvoice WHERE inv_id = N'" & invoiceId & "' AND Active = 1"
                ElseIf isDiamondInvoice Then
                    query = "SELECT * FROM for_print_dimon_finel WHERE BAY_SARYAL = N'" & invoiceId & "' AND [Item_Actv] = 1"
                Else
                    query = "SELECT * FROM ViwGoldInvoceReport WHERE BAY_SARYAL = N'" & invoiceId & "'"
                End If

                Using cmd As New SqlCommand(query, connection)

                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
                            lblStatus.Text = "تم العثور على " & dataTable.Rows.Count & " سجل"
                            lblStatus.ForeColor = Color.Green

                            Try
                                Dim invoiceType As String = If(isBuyInvoice, "شراء", If(isDiamondBuyInvoice, "شراء الماس", If(isDiamondInvoice, "بيع الماس", "بيع")))
                                Dim form3 As New Form3(dataTable, "فاتورة " & invoiceType & " رقم: " & invoiceId)
                                PositionForm(form3)
                                form3.Show()
                            Catch ex As Exception
                                MessageBox.Show("فشل فتح نافذة البيانات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        Else
                            lblStatus.Text = "لم يتم العثور على بيانات للفاتورة رقم: " & invoiceId
                            lblStatus.ForeColor = Color.Orange
                        End If
                    End Using
                End Using

            End Using

            OpenSelectedTables(invoiceId, isBuyInvoice, isDiamondInvoice, isDiamondBuyInvoice)

        Catch ex As Exception
            lblStatus.Text = "خطأ في البحث: " & ex.Message
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("فشل البحث: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub OpenSelectedTables(invoiceId As String, isBuyInvoice As Boolean, Optional isDiamondInvoice As Boolean = False, Optional isDiamondBuyInvoice As Boolean = False)
        Dim tables As New List(Of TableInfo)()

        If isDiamondBuyInvoice Then
            If chkBuyDiamond.Checked Then
                tables.Add(New TableInfo("Buy_Diamond", "inv_id = @InvoiceId AND Active = 1", invoiceId))
            End If

            If chkBayDiamondMony.Checked Then
                tables.Add(New TableInfo("Bay_Diamond_mony", "saryal = @InvoiceId AND Active = 1", invoiceId))
            End If

            If chkDiamondBuyCastomerDETELS.Checked Then
                tables.Add(New TableInfo("CastomerDETELS", "CastomerCAIVELid IN (SELECT castomer_id FROM Buy_Diamond WHERE inv_id = @InvoiceId AND Active = 1)", invoiceId))
            End If

            If chkDiamondBuyCacher.Checked Then
                tables.Add(New TableInfo("cacher", "cacher_name IN (SELECT qult FROM Buy_Diamond WHERE inv_id = @InvoiceId AND Active = 1)", invoiceId))
            End If

            If chkDiamondBuyPayMethod.Checked Then
                tables.Add(New TableInfo("PayMethod", "ID IN (SELECT PayMethod FROM Bay_Diamond_mony WHERE saryal = @InvoiceId AND Active = 1)", invoiceId))
            End If

            If chkDiamondBuySettings.Checked Then
                tables.Add(New TableInfo("Settings", "1=1", Nothing))
            End If
        ElseIf isDiamondInvoice Then
            If chkDiamondInvce.Checked Then
                tables.Add(New TableInfo("dimon_invce", "descont = @InvoiceId AND Item_Actv = 1", invoiceId))
            End If

            If chkDiamondBay.Checked Then
                tables.Add(New TableInfo("dimon_bay", "BAY_SARYAL = @InvoiceId AND Item_Actv = 1", invoiceId))
            End If

            If chkDiamondCastomerDETELS.Checked Then
                tables.Add(New TableInfo("CastomerDETELS", "CastomerCAIVELid IN (SELECT castomr_id FROM dimon_invce WHERE descont = @InvoiceId AND Item_Actv = 1)", invoiceId))
            End If

            If chkDiamondDetels.Checked Then
                tables.Add(New TableInfo("DIMON_detels", "test_119 IN (SELECT dimo_id FROM dimon_invce WHERE descont = @InvoiceId AND Item_Actv = 1)", invoiceId))
            End If

            If chkDiamondCacher.Checked Then
                tables.Add(New TableInfo("cacher", "svil_id IN (SELECT test_118 FROM dimon_invce WHERE descont = @InvoiceId AND Item_Actv = 1)", invoiceId))
            End If

            If chkDiamondPayMethod.Checked Then
                tables.Add(New TableInfo("PayMethod", "ID IN (SELECT PayMethod FROM dimon_bay WHERE BAY_SARYAL = @InvoiceId AND Item_Actv = 1)", invoiceId))
            End If

            If chkDiamondSettings.Checked Then
                tables.Add(New TableInfo("Settings", "1=1", Nothing))
            End If

            If chkDiamondCompInform.Checked Then
                tables.Add(New TableInfo("comp_inform", "1=1", Nothing))
            End If
        ElseIf isBuyInvoice Then
            If chkBuyGold.Checked Then
                tables.Add(New TableInfo("Buy_Gold", "inv_id = @InvoiceId", invoiceId))
            End If

            If chkBuyCastomerDETELS.Checked Then
                tables.Add(New TableInfo("CastomerDETELS", "CastomerCAIVELid IN (SELECT castomer_id FROM Buy_Gold WHERE inv_id = @InvoiceId)", invoiceId))
            End If

            If chkBuyBayGoledMony.Checked Then
                tables.Add(New TableInfo("bay_goled_mony", "saryal = @InvoiceId", invoiceId))
            End If

            If chkBuyCacher.Checked Then
                tables.Add(New TableInfo("cacher", "svil_id IN (SELECT Cashier FROM bay_goled_mony WHERE saryal = @InvoiceId)", invoiceId))
            End If

            If chkBuyPayMethod.Checked Then
                tables.Add(New TableInfo("PayMethod", "ID IN (SELECT PayMethod FROM bay_goled_mony WHERE saryal = @InvoiceId)", invoiceId))
            End If

            If chkBuySettings.Checked Then
                tables.Add(New TableInfo("Settings", "1=1", Nothing))
            End If

            If chkBuyCompInform.Checked Then
                tables.Add(New TableInfo("comp_inform", "1=1", Nothing))
            End If
        Else
            If chkSellBAY.Checked Then
                tables.Add(New TableInfo("BAY", "BAY_SARYAL = @InvoiceId", invoiceId))
            End If

            If chkSellInvoceDetels.Checked Then
                tables.Add(New TableInfo("selInvoceDetels", "invoc_time = @InvoiceId", invoiceId))
            End If

            If chkSellCastomerDETELS.Checked Then
                tables.Add(New TableInfo("CastomerDETELS", "CastomerCAIVELid IN (SELECT Castomerid FROM selInvoceDetels WHERE invoc_time = @InvoiceId)", invoiceId))
            End If

            If chkSellFOMin.Checked Then
                tables.Add(New TableInfo("FO_min", "BarCode IN (SELECT itemID FROM selInvoceDetels WHERE invoc_time = @InvoiceId)", invoiceId))
            End If

            If chkSellCacher.Checked Then
                tables.Add(New TableInfo("cacher", "svil_id IN (SELECT cacher FROM selInvoceDetels WHERE invoc_time = @InvoiceId)", invoiceId))
            End If

            If chkSellPayMethod.Checked Then
                tables.Add(New TableInfo("PayMethod", "ID IN (SELECT PayMethod FROM BAY WHERE BAY_SARYAL = @InvoiceId UNION SELECT PayMethod1 FROM BAY WHERE BAY_SARYAL = @InvoiceId UNION SELECT PayMethod2 FROM BAY WHERE BAY_SARYAL = @InvoiceId UNION SELECT PayMethod3 FROM BAY WHERE BAY_SARYAL = @InvoiceId UNION SELECT PayMethod4 FROM BAY WHERE BAY_SARYAL = @InvoiceId)", invoiceId))
            End If

            If chkSellSettings.Checked Then
                tables.Add(New TableInfo("Settings", "1=1", Nothing))
            End If

            If chkSellCompInform.Checked Then
                tables.Add(New TableInfo("comp_inform", "1=1", Nothing))
            End If
        End If

        For Each tableInfo As TableInfo In tables
            Try
                Dim form As New FormTableData(tableInfo.TableName, connectionString, invoiceId, tableInfo.WhereClause, tableInfo.ParamValue)
                PositionForm(form)
                form.Show()
            Catch ex As Exception
            End Try
        Next

        If tables.Count > 0 Then
            Try
                Dim reportForm As New FormEmptyCellsReport(connectionString, invoiceId, isBuyInvoice, tables)
                PositionForm(reportForm)
                reportForm.Show()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub PositionForm(form As Form)
        formCounter += 1
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim formWidth As Integer = 1000
        Dim formHeight As Integer = 600

        Dim cols As Integer = Math.Max(1, screenWidth \ formWidth)
        Dim row As Integer = (formCounter - 1) \ cols
        Dim col As Integer = (formCounter - 1) Mod cols

        Dim x As Integer = col * formWidth + 50
        Dim y As Integer = row * formHeight + 50

        If x + formWidth > screenWidth Then
            x = 50
            formCounter = 1
            row = 0
            col = 0
        End If

        If y + formHeight > screenHeight Then
            y = 50
        End If

        form.StartPosition = FormStartPosition.Manual
        form.Location = New Point(x, y)
        form.Size = New Size(formWidth, formHeight)
    End Sub

    Private Sub btnChangeInvoiceNumber_Click(sender As Object, e As EventArgs) Handles btnChangeInvoiceNumber.Click
        Try
            Dim form As New FormChangeInvoiceNumber(connectionString)
            form.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImportCustomers_Click(sender As Object, e As EventArgs) Handles btnImportCustomers.Click
        Try
            Dim form As New FormCustomerImport(connectionString, databaseName)
            form.Show()
        Catch ex As Exception
            MessageBox.Show("خطأ في فتح نموذج الاستيراد: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Class TableInfo
        Public TableName As String
        Public WhereClause As String
        Public ParamValue As String

        Public Sub New(name As String, where As String, param As String)
            TableName = name
            WhereClause = where
            ParamValue = param
        End Sub
    End Class

    Private Sub txtInvoiceNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInvoiceNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchInvoice_Click(sender, e)
        End If
    End Sub

    Private Sub btnCheckMissingData_Click(sender As Object, e As EventArgs) Handles btnCheckMissingData.Click
        If String.IsNullOrWhiteSpace(txtInvoiceNo.Text) Then
            MessageBox.Show("ادخل رقم الفاتورة أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim invoiceId As String = txtInvoiceNo.Text.Trim()
            Dim isBuyInvoice As Boolean = radBuyInvoice.Checked
            Dim isDiamondInvoice As Boolean = radDiamondInvoice.Checked
            Dim isDiamondBuyInvoice As Boolean = radDiamondBuyInvoice.Checked
            
            Dim formMissing As New FormMissingData(connectionString, invoiceId, isBuyInvoice, isDiamondInvoice, isDiamondBuyInvoice)
            formMissing.Show()
        Catch ex As Exception
            MessageBox.Show("فشل التحقق من البيانات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCheckEditability_Click(sender As Object, e As EventArgs) Handles btnCheckEditability.Click
        If String.IsNullOrWhiteSpace(txtInvoiceNo.Text) Then
            MessageBox.Show("ادخل رقم الفاتورة أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' التحقق من إمكانية التعديل متاح فقط للذهب (شراء وبيع)
        Dim isDiamondInvoice As Boolean = radDiamondInvoice.Checked
        Dim isDiamondBuyInvoice As Boolean = radDiamondBuyInvoice.Checked

        If isDiamondInvoice OrElse isDiamondBuyInvoice Then
            MessageBox.Show("التحقق من إمكانية التعديل متاح فقط لفواتير الذهب (شراء/بيع)" & vbCrLf & "يرجى اختيار فاتورة ذهب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim invoiceId As String = txtInvoiceNo.Text.Trim()
            Dim isBuyInvoice As Boolean = radBuyInvoice.Checked
            
            Dim formEditability As New FormEditability(connectionString, invoiceId, isBuyInvoice)
            formEditability.Show()
        Catch ex As Exception
            MessageBox.Show("فشل التحقق: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShowInactiveInvoices_Click(sender As Object, e As EventArgs) Handles btnShowInactiveInvoices.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            lstInactiveInvoices.Items.Clear()
            grpInactiveInvoices.Text = "جاري التحميل..."

            Dim isBuyInvoice As Boolean = radBuyInvoice.Checked
            Dim isDiamondInvoice As Boolean = radDiamondInvoice.Checked
            Dim isDiamondBuyInvoice As Boolean = radDiamondBuyInvoice.Checked
            Dim query As String = String.Empty

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                If isBuyInvoice Then
                    query = "SELECT DISTINCT inv_id FROM Buy_Gold WHERE INV_Actv = 0 ORDER BY inv_id"
                ElseIf isDiamondBuyInvoice Then
                    query = "SELECT DISTINCT saryal FROM Bay_Diamond_mony WHERE Active = 0 ORDER BY saryal"
                ElseIf isDiamondInvoice Then
                    query = "SELECT DISTINCT BAY_SARYAL FROM dimon_bay WHERE Item_Actv = 0 ORDER BY BAY_SARYAL"
                Else
                    query = "SELECT DISTINCT BAY_SARYAL FROM BAY WHERE Active = 0 ORDER BY BAY_SARYAL"
                End If

                Using cmd As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim invoiceId As String = reader(0).ToString()
                            lstInactiveInvoices.Items.Add(invoiceId)
                        End While
                    End Using
                End Using
            End Using

            Dim invoiceType As String = If(isBuyInvoice, "شراء", If(isDiamondBuyInvoice, "شراء الماس", If(isDiamondInvoice, "بيع الماس", "بيع")))
            Dim condition As String = If(isBuyInvoice OrElse isDiamondBuyInvoice, "Active = 0", "Item_Actv = 0")
            grpInactiveInvoices.Text = "فواتير " & invoiceType & " غير النشطة (" & condition & "): " & lstInactiveInvoices.Items.Count & " فاتورة"
            lblStatus.Text = "تم تحميل " & lstInactiveInvoices.Items.Count & " فاتورة " & invoiceType & " غير نشطة"
            lblStatus.ForeColor = Color.Green

        Catch ex As Exception
            grpInactiveInvoices.Text = "خطأ في التحميل"
            lblStatus.Text = "خطأ في تحميل الفواتير: " & ex.Message
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("فشل تحميل الفواتير: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Using folderDialog As New FolderBrowserDialog()
            folderDialog.Description = "اختر مجلد لحفظ ملفات البنية"
            folderDialog.ShowNewFolderButton = True

            If folderDialog.ShowDialog() = DialogResult.OK Then
                ExportDatabaseStructure(folderDialog.SelectedPath)
            End If
        End Using
    End Sub

    Private Sub ExportDatabaseStructure(exportPath As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            btnExport.Enabled = False
            lblStatus.Text = "جاري التصدير..."
            lblStatus.ForeColor = Color.Blue
            Application.DoEvents()

            Dim tablesList As New List(Of Tuple(Of String, String))()
            Dim viewsList As New List(Of Tuple(Of String, String))()

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim tablesQuery As String = "SELECT TABLE_SCHEMA, TABLE_NAME " &
                                          "FROM INFORMATION_SCHEMA.TABLES " &
                                          "WHERE TABLE_TYPE = 'BASE TABLE' " &
                                          "ORDER BY TABLE_SCHEMA, TABLE_NAME"

                Dim viewsQuery As String = "SELECT TABLE_SCHEMA, TABLE_NAME " &
                                          "FROM INFORMATION_SCHEMA.VIEWS " &
                                          "ORDER BY TABLE_SCHEMA, TABLE_NAME"

                Using cmd As New SqlCommand(tablesQuery, connection)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim schemaName As String = reader("TABLE_SCHEMA").ToString()
                            Dim tableName As String = reader("TABLE_NAME").ToString()
                            tablesList.Add(New Tuple(Of String, String)(schemaName, tableName))
                        End While
                    End Using
                End Using

                Using cmd As New SqlCommand(viewsQuery, connection)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim schemaName As String = reader("TABLE_SCHEMA").ToString()
                            Dim viewName As String = reader("TABLE_NAME").ToString()
                            viewsList.Add(New Tuple(Of String, String)(schemaName, viewName))
                        End While
                    End Using
                End Using
            End Using

            Dim exportedCount As Integer = 0
            Dim failedCount As Integer = 0

            For Each tableInfo As Tuple(Of String, String) In tablesList
                Try
                    Dim schemaName As String = tableInfo.Item1
                    Dim tableName As String = tableInfo.Item2
                    Dim fullName As String = If(String.IsNullOrEmpty(schemaName), tableName, schemaName & "." & tableName)

                    lblStatus.Text = "جاري تصدير: " & fullName & " (" & (exportedCount + 1) & "/" & (tablesList.Count + viewsList.Count) & ")"
                    Application.DoEvents()

                    Dim script As String = GetTableScript(schemaName, tableName)
                    Dim fileName As String = Path.Combine(exportPath, "TABLE_" & fullName.Replace(".", "_") & ".sql")
                    File.WriteAllText(fileName, script, Encoding.UTF8)
                    exportedCount += 1
                Catch ex As Exception
                    failedCount += 1
                End Try
            Next

            For Each viewInfo As Tuple(Of String, String) In viewsList
                Try
                    Dim schemaName As String = viewInfo.Item1
                    Dim viewName As String = viewInfo.Item2
                    Dim fullName As String = If(String.IsNullOrEmpty(schemaName), viewName, schemaName & "." & viewName)

                    lblStatus.Text = "جاري تصدير: " & fullName & " (" & (exportedCount + 1) & "/" & (tablesList.Count + viewsList.Count) & ")"
                    Application.DoEvents()

                    Dim script As String = GetViewScript(schemaName, viewName)
                    Dim fileName As String = Path.Combine(exportPath, "VIEW_" & fullName.Replace(".", "_") & ".sql")
                    File.WriteAllText(fileName, script, Encoding.UTF8)
                    exportedCount += 1
                Catch ex As Exception
                    failedCount += 1
                End Try
            Next

            Dim message As String = "تم تصدير " & exportedCount & " ملف بنجاح"
            If failedCount > 0 Then
                message &= Environment.NewLine & "فشل تصدير " & failedCount & " ملف"
            End If
            message &= Environment.NewLine & exportPath

            lblStatus.Text = "تم التصدير: " & exportedCount & " نجح، " & failedCount & " فشل"
            lblStatus.ForeColor = If(failedCount = 0, Color.Green, Color.Orange)
            MessageBox.Show(message, If(failedCount = 0, "نجاح", "تحذير"), MessageBoxButtons.OK, If(failedCount = 0, MessageBoxIcon.Information, MessageBoxIcon.Warning))

        Catch ex As Exception
            lblStatus.Text = "خطأ في التصدير: " & ex.Message
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("فشل التصدير: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
            btnExport.Enabled = True
        End Try
    End Sub

    Private Function GetTableScript(schemaName As String, tableName As String) As String
        Dim script As New StringBuilder()
        script.AppendLine("-- =============================================")
        script.AppendLine("-- Table: " & schemaName & "." & tableName)
        script.AppendLine("-- Database: " & databaseName)
        script.AppendLine("-- =============================================")
        script.AppendLine()

        Try
            Dim columns As New List(Of String)()
            Dim pkColumns As New List(Of String)()

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, " &
                                     "NUMERIC_PRECISION, NUMERIC_SCALE, IS_NULLABLE, COLUMN_DEFAULT " &
                                     "FROM INFORMATION_SCHEMA.COLUMNS " &
                                     "WHERE TABLE_SCHEMA = @Schema AND TABLE_NAME = @Table " &
                                     "ORDER BY ORDINAL_POSITION"

                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Schema", schemaName)
                    cmd.Parameters.AddWithValue("@Table", tableName)
                    cmd.CommandTimeout = 30

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim colName As String = reader("COLUMN_NAME").ToString()
                            Dim dataType As String = reader("DATA_TYPE").ToString()
                            Dim maxLength As Object = reader("CHARACTER_MAXIMUM_LENGTH")
                            Dim precision As Object = reader("NUMERIC_PRECISION")
                            Dim scale As Object = reader("NUMERIC_SCALE")
                            Dim isNullable As String = reader("IS_NULLABLE").ToString()
                            Dim defaultValue As Object = reader("COLUMN_DEFAULT")

                            Dim colDef As New StringBuilder()
                            colDef.Append("    [" & colName & "] " & dataType)

                            If Not IsDBNull(maxLength) AndAlso maxLength <> -1 Then
                                colDef.Append("(" & maxLength & ")")
                            ElseIf Not IsDBNull(precision) Then
                                If Not IsDBNull(scale) Then
                                    colDef.Append("(" & precision & "," & scale & ")")
                                Else
                                    colDef.Append("(" & precision & ")")
                                End If
                            End If

                            If isNullable = "NO" Then
                                colDef.Append(" NOT NULL")
                            End If

                            If Not IsDBNull(defaultValue) AndAlso Not String.IsNullOrEmpty(defaultValue.ToString()) Then
                                colDef.Append(" DEFAULT " & defaultValue.ToString())
                            End If

                            columns.Add(colDef.ToString())
                        End While
                    End Using
                End Using

                Dim pkQuery As String = "SELECT COLUMN_NAME " &
                                       "FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE " &
                                       "WHERE TABLE_SCHEMA = @Schema AND TABLE_NAME = @Table " &
                                       "AND CONSTRAINT_NAME IN (SELECT CONSTRAINT_NAME " &
                                       "FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS " &
                                       "WHERE CONSTRAINT_TYPE = 'PRIMARY KEY' " &
                                       "AND TABLE_SCHEMA = @Schema AND TABLE_NAME = @Table) " &
                                       "ORDER BY ORDINAL_POSITION"

                Using cmdPk As New SqlCommand(pkQuery, connection)
                    cmdPk.Parameters.AddWithValue("@Schema", schemaName)
                    cmdPk.Parameters.AddWithValue("@Table", tableName)
                    cmdPk.CommandTimeout = 30

                    Using reader As SqlDataReader = cmdPk.ExecuteReader()
                        While reader.Read()
                            pkColumns.Add("[" & reader("COLUMN_NAME").ToString() & "]")
                        End While
                    End Using
                End Using
            End Using

            script.AppendLine("CREATE TABLE [" & schemaName & "].[" & tableName & "] (")
            script.AppendLine()

            If columns.Count > 0 Then
                script.AppendLine(String.Join("," & Environment.NewLine, columns))
            End If

            script.AppendLine()
            script.AppendLine(");")
            script.AppendLine()

            If pkColumns.Count > 0 Then
                script.AppendLine("ALTER TABLE [" & schemaName & "].[" & tableName & "]")
                script.AppendLine("ADD CONSTRAINT [PK_" & tableName & "] PRIMARY KEY (" & String.Join(", ", pkColumns) & ");")
                script.AppendLine()
            End If

        Catch ex As Exception
            script.AppendLine("-- Error generating script: " & ex.Message)
        End Try

        Return script.ToString()
    End Function

    Private Function GetViewScript(schemaName As String, viewName As String) As String
        Dim script As New StringBuilder()
        script.AppendLine("-- =============================================")
        script.AppendLine("-- View: " & schemaName & "." & viewName)
        script.AppendLine("-- Database: " & databaseName)
        script.AppendLine("-- =============================================")
        script.AppendLine()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT VIEW_DEFINITION " &
                                     "FROM INFORMATION_SCHEMA.VIEWS " &
                                     "WHERE TABLE_SCHEMA = @Schema AND TABLE_NAME = @View"

                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Schema", schemaName)
                    cmd.Parameters.AddWithValue("@View", viewName)
                    cmd.CommandTimeout = 30

                    Dim viewDefinition As Object = cmd.ExecuteScalar()
                    If Not IsDBNull(viewDefinition) AndAlso viewDefinition IsNot Nothing Then
                        script.AppendLine("CREATE VIEW [" & schemaName & "].[" & viewName & "]")
                        script.AppendLine("AS")
                        script.AppendLine(viewDefinition.ToString())
                        script.AppendLine()
                    End If
                End Using
            End Using

        Catch ex As Exception
            script.AppendLine("-- Error generating script: " & ex.Message)
        End Try

        Return script.ToString()
    End Function

End Class

