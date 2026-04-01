Imports System.Data.SqlClient
Imports System.Diagnostics


Public Class frmBackup
    ' استخدام الاتصال العام بدلاً من اتصال محلي
    Private ReadOnly Property database As String
        Get
            If DB_conn IsNot Nothing AndAlso Not String.IsNullOrEmpty(DB_conn.Database) Then
                Return DB_conn.Database
            Else
                Return "DT_restrant" ' قيمة افتراضية
            End If
        End Get
    End Property
    Private Sub Backup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub bacb_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        btnSave.Enabled = False
        btnRestore.Enabled = False
        SetDefaultValues()
    End Sub
    Private Sub SetDefaultValues()
        Try
            txtBackupPath.Text = If(BackupPath, "")

            ' تعيين قيمة الساعة مع التحقق من النطاق
            Dim hourValue As Decimal = 0
            If Not String.IsNullOrEmpty(BackupHour) AndAlso Decimal.TryParse(BackupHour, hourValue) Then
                ' التأكد من أن القيمة في نطاق NumericUpDown
                If hourValue >= nudBackupHour.Minimum AndAlso hourValue <= nudBackupHour.Maximum Then
                    nudBackupHour.Value = hourValue
                Else
                    nudBackupHour.Value = nudBackupHour.Minimum
                End If
            Else
                nudBackupHour.Value = nudBackupHour.Minimum
            End If

            ' تعيين قيمة الدقائق مع التحقق من النطاق
            Dim minuteValue As Decimal = 0
            If Not String.IsNullOrEmpty(BackupMinute) AndAlso Decimal.TryParse(BackupMinute, minuteValue) Then
                ' التأكد من أن القيمة في نطاق NumericUpDown
                If minuteValue >= nudBackupMinute.Minimum AndAlso minuteValue <= nudBackupMinute.Maximum Then
                    nudBackupMinute.Value = minuteValue
                Else
                    nudBackupMinute.Value = nudBackupMinute.Minimum
                End If
            Else
                nudBackupMinute.Value = nudBackupMinute.Minimum
            End If
        Catch ex As Exception
            ' في حالة أي خطأ، استخدم القيم الافتراضية
            txtBackupPath.Text = ""
            nudBackupHour.Value = nudBackupHour.Minimum
            nudBackupMinute.Value = nudBackupMinute.Minimum
        End Try
    End Sub
    Private Sub Backup()
        Try
            If String.IsNullOrEmpty(txtBackupPath.Text.Trim()) Then
                MsgBox("لم يتم تحديد مسار الحفظ" & vbCrLf & "Please enter backup file location", , AppTitle)
                Exit Sub
            End If
            
            Dim backupPath As String = txtBackupPath.Text.Trim()
            
            ' التحقق من وجود المسار وإنشائه إذا لم يكن موجوداً
            If Not IO.Directory.Exists(backupPath) Then
                Try
                    IO.Directory.CreateDirectory(backupPath)
                Catch dirEx As Exception
                    MsgBox("خطأ في إنشاء المجلد - تأكد من صحة المسار" & vbCrLf & dirEx.Message, MsgBoxStyle.Critical, AppTitle)
                    Exit Sub
                End Try
            End If
            
            ' فتح الاتصال بقاعدة البيانات
            OpenDataBase()
            
            ' اسم ملف النسخ الاحتياطي
            Dim backupFileName As String = database & "-" & Date.Now.ToString("yyyy-MM-dd--HH-mm-ss") & ".bak"
            Dim fullBackupPath As String = backupPath & "\" & backupFileName
            
            ' محاولة النسخ الاحتياطي مباشرة إلى المسار المطلوب
            Dim backupSucceeded As Boolean = False
            Dim finalBackupPath As String = fullBackupPath
            
            ' التحقق من نوع الاتصال (محلي أم بعيد)
            Dim isRemoteServer As Boolean = False
            Dim remoteServerName As String = ""
            Try
                Dim connBuilder As New SqlConnectionStringBuilder(SqlServerConnectionString)
                Dim dataSource As String = connBuilder.DataSource
                remoteServerName = dataSource
                
                ' استخراج اسم السيرفر (بدون الـ instance)
                If dataSource.Contains("\") Then
                    remoteServerName = dataSource.Split("\"c)(0)
                End If
                
                ' التحقق إذا كان السيرفر بعيد
                ' السيرفر يعتبر بعيد إذا:
                ' 1. يحتوي على IP address (أرقام ونقاط)
                ' 2. ليس localhost أو (local)
                ' 3. ليس اسم الجهاز الحالي
                Dim localMachineName As String = Environment.MachineName
                Dim isIPAddress As Boolean = System.Text.RegularExpressions.Regex.IsMatch(remoteServerName, "^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$")
                
                isRemoteServer = isIPAddress OrElse 
                                  (Not remoteServerName.Equals("localhost", StringComparison.OrdinalIgnoreCase) AndAlso 
                                   Not remoteServerName.Equals("(local)", StringComparison.OrdinalIgnoreCase) AndAlso
                                   Not remoteServerName.Equals(localMachineName, StringComparison.OrdinalIgnoreCase) AndAlso
                                   Not remoteServerName.Equals(".") AndAlso
                                   Not remoteServerName.StartsWith("."))
            Catch
            End Try
            
            ' محاولة النسخ مباشرة إلى المسار المطلوب
            ' إذا كان السيرفر بعيد، نحاول استخدام UNC path أو مسار مشترك
            Dim backupPathToUse As String = fullBackupPath
            
            ' إذا كان السيرفر بعيد، نحاول تحويل المسار المحلي إلى UNC path
            If isRemoteServer Then
                Try
                    ' محاولة الحصول على اسم الجهاز الحالي
                    Dim localMachineName As String = Environment.MachineName
                    ' تحويل المسار المحلي إلى UNC path (مثال: C:\Users\... -> \\MachineName\C$\Users\...)
                    If backupPath.StartsWith("C:\") Then
                        backupPathToUse = "\\" & localMachineName & "\C$\" & backupPath.Substring(3)
                    ElseIf backupPath.StartsWith("D:\") Then
                        backupPathToUse = "\\" & localMachineName & "\D$\" & backupPath.Substring(3)
                    ElseIf backupPath.StartsWith("E:\") Then
                        backupPathToUse = "\\" & localMachineName & "\E$\" & backupPath.Substring(3)
                    End If
                Catch
                    ' إذا فشل، استخدم المسار الأصلي
                    backupPathToUse = fullBackupPath
                End Try
            End If
            
            ' محاولة النسخ مباشرة إلى المسار المطلوب
            Try
                GlCommand.CommandTimeout = 0
                GlCommand.CommandText = "BACKUP DATABASE [" + database + "] To DISK = N'" + backupPathToUse.Replace("'", "''") + "' WITH INIT, FORMAT, STATS = 10;"
                AddHandler DB_conn.InfoMessage, AddressOf Sql_InfoMessage
                DB_conn.FireInfoMessageEventOnUserErrors = True
                GlCommand.ExecuteNonQuery()
                
                ' انتظار قليل للتأكد من اكتمال النسخ
                System.Threading.Thread.Sleep(1000)
                
                ' التحقق من وجود الملف في المسار المطلوب
                If IO.File.Exists(fullBackupPath) Then
                    backupSucceeded = True
                ElseIf backupPathToUse <> fullBackupPath AndAlso IO.File.Exists(backupPathToUse) Then
                    ' إذا كان الملف في UNC path، نحاول نسخه إلى المسار المحلي
                    Try
                        IO.File.Copy(backupPathToUse, fullBackupPath, True)
                        If IO.File.Exists(fullBackupPath) Then
                            backupSucceeded = True
                            ' حذف الملف من UNC path
                            Try
                                IO.File.Delete(backupPathToUse)
                            Catch
                            End Try
                        End If
                    Catch
                    End Try
                End If
            Catch directBackupEx As Exception
                ' إذا فشل النسخ المباشر، نستخدم الطريقة القديمة (حفظ في مجلد SQL Server ثم النسخ)
                backupSucceeded = False
            End Try

            ' إذا فشل النسخ المباشر، استخدم الطريقة القديمة
            If Not backupSucceeded Then
                ' الحصول على مسار SQL Server الافتراضي للاستخدام كمسار مؤقت
                Dim sqlServerBackupPath As String = ""
                Try
                    GlCommand.CommandText = "SELECT SERVERPROPERTY('InstanceDefaultDataPath')"
                    Dim dataPath As Object = GlCommand.ExecuteScalar()
                    If dataPath IsNot Nothing AndAlso Not IsDBNull(dataPath) Then
                        sqlServerBackupPath = dataPath.ToString().TrimEnd("\"c)
                    End If
                Catch
                End Try

                ' إذا لم نتمكن من الحصول على المسار، نحاول الحصول على اسم الـ instance
                If String.IsNullOrEmpty(sqlServerBackupPath) Then
                    Try
                        GlCommand.CommandText = "SELECT @@SERVERNAME"
                        Dim serverName As Object = GlCommand.ExecuteScalar()
                        If serverName IsNot Nothing AndAlso Not IsDBNull(serverName) Then
                            Dim serverNameStr As String = serverName.ToString()
                            ' استخراج اسم الـ instance من اسم السيرفر
                            Dim instanceName As String = ""
                            If serverNameStr.Contains("\") Then
                                instanceName = serverNameStr.Split("\"c)(1)
                            Else
                                instanceName = "MSSQLSERVER"
                            End If

                            ' محاولة العثور على مسار SQL Server بناءً على اسم الـ instance
                            Dim possiblePaths As String() = {
                                "C:\Program Files\Microsoft SQL Server\MSSQL14." & instanceName & "\MSSQL\DATA",
                                "C:\Program Files\Microsoft SQL Server\MSSQL15." & instanceName & "\MSSQL\DATA",
                                "C:\Program Files\Microsoft SQL Server\MSSQL16." & instanceName & "\MSSQL\DATA",
                                "C:\Program Files (x86)\Microsoft SQL Server\MSSQL14." & instanceName & "\MSSQL\DATA",
                                "C:\Program Files (x86)\Microsoft SQL Server\MSSQL15." & instanceName & "\MSSQL\DATA"
                            }

                            For Each path As String In possiblePaths
                                If IO.Directory.Exists(path) Then
                                    sqlServerBackupPath = path
                                    Exit For
                                End If
                            Next
                        End If
                    Catch
                    End Try
                End If

                ' إذا لم نجد مساراً، استخدم مسار افتراضي بناءً على اسم السيرفر من الاتصال
                If String.IsNullOrEmpty(sqlServerBackupPath) Then
                    ' محاولة استخراج اسم السيرفر من connection string
                    Try
                        Dim connBuilder As New SqlConnectionStringBuilder(SqlServerConnectionString)
                        Dim dataSource As String = connBuilder.DataSource
                        Dim instanceName As String = "MSSQLSERVER"

                        If dataSource.Contains("\") Then
                            instanceName = dataSource.Split("\"c)(1)
                        End If

                        Dim defaultPaths As String() = {
                            "C:\Program Files\Microsoft SQL Server\MSSQL14." & instanceName & "\MSSQL\DATA",
                            "C:\Program Files\Microsoft SQL Server\MSSQL15." & instanceName & "\MSSQL\DATA",
                            "C:\Program Files\Microsoft SQL Server\MSSQL16." & instanceName & "\MSSQL\DATA"
                        }

                        For Each path As String In defaultPaths
                            If IO.Directory.Exists(path) Then
                                sqlServerBackupPath = path
                                Exit For
                            End If
                        Next
                    Catch
                    End Try
                End If

                ' إذا لم نجد أي مسار، استخدم مسار افتراضي عام
                If String.IsNullOrEmpty(sqlServerBackupPath) Then
                    sqlServerBackupPath = "C:\Program Files\Microsoft SQL Server\MSSQL14.SABSERVER\MSSQL\DATA"
                End If

                Dim sqlServerFullPath As String = sqlServerBackupPath & "\" & backupFileName

                ' النسخ الاحتياطي في مجلد SQL Server (مضمون الصلاحيات)
                GlCommand.CommandTimeout = 0
                GlCommand.CommandText = "BACKUP DATABASE [" + database + "] To DISK = N'" + sqlServerFullPath.Replace("'", "''") + "' WITH INIT, FORMAT, STATS = 10;"
                AddHandler DB_conn.InfoMessage, AddressOf Sql_InfoMessage
                DB_conn.FireInfoMessageEventOnUserErrors = True
                GlCommand.ExecuteNonQuery()

                ' إذا كان السيرفر بعيد، استخدم Binary Download مباشرة لنقل الملف إلى الجهاز المحلي
                Dim fileMoved As Boolean = False

                If isRemoteServer Then
                    ' طريقة مباشرة: تنزيل الملف من السيرفر البعيد إلى الجهاز المحلي باستخدام Binary
                    Try
                        ' تفعيل Ad Hoc Distributed Queries
                        Try
                            GlCommand.CommandText = "EXEC sp_configure 'show advanced options', 1; RECONFIGURE;"
                            GlCommand.ExecuteNonQuery()
                            GlCommand.CommandText = "EXEC sp_configure 'Ad Hoc Distributed Queries', 1; RECONFIGURE;"
                            GlCommand.ExecuteNonQuery()
                        Catch
                        End Try

                        ' انتظار قليل للتأكد من اكتمال النسخ على السيرفر البعيد
                        System.Threading.Thread.Sleep(2000)

                        ' قراءة الملف من السيرفر البعيد كـ binary
                        Dim downloadQuery As String = String.Format(
                            "SELECT BulkColumn FROM OPENROWSET(BULK '{0}', SINGLE_BLOB) AS x",
                            sqlServerFullPath.Replace("'", "''"))

                        GlCommand.CommandTimeout = 0
                        GlCommand.CommandText = downloadQuery
                        Dim fileData As Object = GlCommand.ExecuteScalar()

                        If fileData IsNot Nothing AndAlso TypeOf fileData Is Byte() Then
                            Dim bytes As Byte() = DirectCast(fileData, Byte())

                            ' كتابة البيانات على الجهاز المحلي
                            Using fs As New IO.FileStream(fullBackupPath, IO.FileMode.Create, IO.FileAccess.Write)
                                fs.Write(bytes, 0, bytes.Length)
                                fs.Flush()
                            End Using

                            ' التحقق من نجاح الكتابة
                            If IO.File.Exists(fullBackupPath) Then
                                Dim fileInfo As New IO.FileInfo(fullBackupPath)
                                If fileInfo.Length > 0 Then
                                    fileMoved = True

                                    ' حذف الملف من السيرفر البعيد
                                    Try
                                        Dim deleteCommand As String = String.Format("EXEC xp_cmdshell 'del /F /Q ""{0}""'", sqlServerFullPath)
                                        GlCommand.CommandText = deleteCommand
                                        GlCommand.ExecuteNonQuery()
                                    Catch
                                    End Try
                                End If
                            End If
                        End If
                    Catch binaryEx As Exception
                        ' إذا فشلت طريقة Binary، جرب الطرق الأخرى
                    End Try
                End If

                ' إذا لم تنجح طريقة Binary أو كان السيرفر محلي، جرب الطرق الأخرى
                If Not fileMoved Then
                    ' محاولة 1: استخدام IO.File.Copy مباشرة (أولاً للسيرفر المحلي)
                    If Not isRemoteServer Then
                        Try
                            ' انتظار قليل للتأكد من اكتمال النسخ على السيرفر
                            System.Threading.Thread.Sleep(2000)

                            If IO.File.Exists(sqlServerFullPath) Then
                                IO.File.Copy(sqlServerFullPath, fullBackupPath, True)
                                If IO.File.Exists(fullBackupPath) Then
                                    fileMoved = True
                                    ' حذف الملف المؤقت
                                    Try
                                        IO.File.Delete(sqlServerFullPath)
                                    Catch
                                    End Try
                                End If
                            End If
                        Catch fileEx As Exception
                            ' فشل النسخ، جرب طريقة أخرى
                        End Try
                    End If

                    ' محاولة 2: استخدام xp_cmdshell (إذا لم تنجح الطريقة الأولى)
                    If Not fileMoved Then
                        Try
                            ' تفعيل xp_cmdshell مؤقتاً
                            Try
                                GlCommand.CommandText = "EXEC sp_configure 'show advanced options', 1; RECONFIGURE;"
                                GlCommand.ExecuteNonQuery()
                                GlCommand.CommandText = "EXEC sp_configure 'xp_cmdshell', 1; RECONFIGURE;"
                                GlCommand.ExecuteNonQuery()
                            Catch
                                ' قد يكون مفعل بالفعل أو لا توجد صلاحية
                            End Try

                            ' انتظار قليل للتأكد من اكتمال النسخ على السيرفر
                            System.Threading.Thread.Sleep(2000)

                            ' إذا كان السيرفر بعيد، نحاول نسخ الملف مباشرة إلى UNC path للجهاز المحلي
                            Dim copyTargetPath As String = fullBackupPath
                            If isRemoteServer Then
                                ' تحويل المسار المحلي إلى UNC path يمكن الوصول إليه من السيرفر البعيد
                                Try
                                    Dim localMachineName As String = Environment.MachineName
                                    If backupPath.StartsWith("C:\") Then
                                        copyTargetPath = "\\" & localMachineName & "\C$\" & backupPath.Substring(3) & "\" & backupFileName
                                    ElseIf backupPath.StartsWith("D:\") Then
                                        copyTargetPath = "\\" & localMachineName & "\D$\" & backupPath.Substring(3) & "\" & backupFileName
                                    ElseIf backupPath.StartsWith("E:\") Then
                                        copyTargetPath = "\\" & localMachineName & "\E$\" & backupPath.Substring(3) & "\" & backupFileName
                                    End If
                                Catch
                                    ' إذا فشل، استخدم المسار الأصلي
                                    copyTargetPath = fullBackupPath
                                End Try
                            End If

                            ' نسخ الملف باستخدام xp_cmdshell
                            Dim copyCommand As String = String.Format("EXEC xp_cmdshell 'copy /Y ""{0}"" ""{1}""'", sqlServerFullPath, copyTargetPath)
                            GlCommand.CommandText = copyCommand
                            GlCommand.ExecuteNonQuery()

                            ' انتظار قليل للنسخ
                            System.Threading.Thread.Sleep(2000)

                            ' التحقق من نجاح النسخ
                            If IO.File.Exists(fullBackupPath) Then
                                fileMoved = True
                                ' حذف الملف المؤقت
                                Try
                                    Dim deleteCommand As String = String.Format("EXEC xp_cmdshell 'del /F /Q ""{0}""'", sqlServerFullPath)
                                    GlCommand.CommandText = deleteCommand
                                    GlCommand.ExecuteNonQuery()
                                Catch
                                End Try
                            ElseIf copyTargetPath <> fullBackupPath AndAlso IO.File.Exists(copyTargetPath) Then
                                ' إذا كان الملف في UNC path، نسخه إلى المسار المحلي
                                Try
                                    IO.File.Copy(copyTargetPath, fullBackupPath, True)
                                    If IO.File.Exists(fullBackupPath) Then
                                        fileMoved = True
                                        ' حذف الملف من UNC path
                                        Try
                                            IO.File.Delete(copyTargetPath)
                                        Catch
                                        End Try
                                        ' حذف الملف المؤقت من السيرفر البعيد
                                        Try
                                            Dim deleteCommand As String = String.Format("EXEC xp_cmdshell 'del /F /Q ""{0}""'", sqlServerFullPath)
                                            GlCommand.CommandText = deleteCommand
                                            GlCommand.ExecuteNonQuery()
                                        Catch
                                        End Try
                                    End If
                                Catch
                                End Try
                            End If
                        Catch
                            ' فشل xp_cmdshell، جرب طريقة أخرى
                        End Try
                    End If
                End If

                ' محاولة 3: إذا كان السيرفر بعيد، نحاول استخدام UNC path للوصول للملف
                If Not fileMoved AndAlso isRemoteServer AndAlso Not String.IsNullOrEmpty(remoteServerName) Then
                    Try
                        ' محاولة الوصول للملف على السيرفر البعيد باستخدام UNC path
                        ' تحويل المسار المحلي إلى UNC path على السيرفر البعيد
                        ' مثال: C:\Program Files\... -> \\ServerName\C$\Program Files\...
                        Dim driveLetter As String = ""
                        Dim pathWithoutDrive As String = ""
                        If sqlServerFullPath.Length >= 3 AndAlso sqlServerFullPath(1) = ":"c AndAlso sqlServerFullPath(2) = "\"c Then
                            driveLetter = sqlServerFullPath.Substring(0, 1)
                            pathWithoutDrive = sqlServerFullPath.Substring(3)
                            Dim remoteFilePath As String = "\\" & remoteServerName & "\" & driveLetter & "$\" & pathWithoutDrive

                            ' انتظار قليل للتأكد من اكتمال النسخ على السيرفر البعيد
                            System.Threading.Thread.Sleep(2000)

                            If IO.File.Exists(remoteFilePath) Then
                                IO.File.Copy(remoteFilePath, fullBackupPath, True)
                                If IO.File.Exists(fullBackupPath) Then
                                    fileMoved = True
                                    ' محاولة حذف الملف من السيرفر البعيد
                                    Try
                                        IO.File.Delete(remoteFilePath)
                                    Catch
                                    End Try
                                End If
                            End If
                        End If
                    Catch
                        ' فشل الوصول للملف على السيرفر البعيد
                    End Try
                End If

                ' محاولة 4: طريقة بديلة - تنزيل الملف من السيرفر البعيد باستخدام SQL Server Binary
                ' هذه الطريقة لا تحتاج مشاركة ملفات - تقرأ الملف كـ binary من SQL Server ثم تكتبه محلياً
                If Not fileMoved AndAlso isRemoteServer Then
                    Try
                        ' تفعيل Ad Hoc Distributed Queries إذا لزم الأمر (لـ OPENROWSET)
                        Try
                            GlCommand.CommandText = "EXEC sp_configure 'show advanced options', 1; RECONFIGURE;"
                            GlCommand.ExecuteNonQuery()
                            GlCommand.CommandText = "EXEC sp_configure 'Ad Hoc Distributed Queries', 1; RECONFIGURE;"
                            GlCommand.ExecuteNonQuery()
                        Catch
                            ' قد يكون مفعل بالفعل أو لا توجد صلاحية
                        End Try

                        ' انتظار قليل للتأكد من اكتمال النسخ على السيرفر البعيد
                        System.Threading.Thread.Sleep(2000)

                        ' قراءة الملف من السيرفر البعيد كـ binary باستخدام OPENROWSET
                        ' هذه الطريقة تعمل بدون مشاركة ملفات
                        Dim downloadQuery As String = String.Format(
                            "SELECT BulkColumn FROM OPENROWSET(BULK '{0}', SINGLE_BLOB) AS x",
                            sqlServerFullPath.Replace("'", "''"))

                        GlCommand.CommandTimeout = 0 ' لا timeout للملفات الكبيرة
                        GlCommand.CommandText = downloadQuery
                        Dim fileData As Object = GlCommand.ExecuteScalar()

                        If fileData IsNot Nothing AndAlso TypeOf fileData Is Byte() Then
                            Dim bytes As Byte() = DirectCast(fileData, Byte())

                            ' كتابة البيانات على الجهاز المحلي
                            Using fs As New IO.FileStream(fullBackupPath, IO.FileMode.Create, IO.FileAccess.Write)
                                fs.Write(bytes, 0, bytes.Length)
                                fs.Flush()
                            End Using

                            ' التحقق من نجاح الكتابة
                            If IO.File.Exists(fullBackupPath) Then
                                Dim fileInfo As New IO.FileInfo(fullBackupPath)
                                If fileInfo.Length > 0 Then
                                    fileMoved = True

                                    ' محاولة حذف الملف من السيرفر البعيد
                                    Try
                                        Dim deleteCommand As String = String.Format("EXEC xp_cmdshell 'del /F /Q ""{0}""'", sqlServerFullPath)
                                        GlCommand.CommandText = deleteCommand
                                        GlCommand.ExecuteNonQuery()
                                    Catch
                                    End Try
                                End If
                            End If
                        End If
                    Catch binaryEx As Exception
                        ' إذا فشلت طريقة Binary، جرب الطريقة التالية
                        ' قد تفشل إذا كان Ad Hoc Distributed Queries معطل أو لا توجد صلاحيات
                    End Try
                End If

                ' محاولة 5: إذا كان السيرفر بعيد وفشلت جميع المحاولات، استخدم PowerShell لتنزيل الملف
                If Not fileMoved AndAlso isRemoteServer AndAlso Not String.IsNullOrEmpty(remoteServerName) Then
                    Try
                        ' استخدام PowerShell لتنزيل الملف من السيرفر البعيد
                        ' نحتاج لتحويل المسار إلى UNC path
                        Dim driveLetter As String = ""
                        Dim pathWithoutDrive As String = ""
                        If sqlServerFullPath.Length >= 3 AndAlso sqlServerFullPath(1) = ":"c AndAlso sqlServerFullPath(2) = "\"c Then
                            driveLetter = sqlServerFullPath.Substring(0, 1)
                            pathWithoutDrive = sqlServerFullPath.Substring(3)
                            Dim remoteFilePath As String = "\\" & remoteServerName & "\" & driveLetter & "$\" & pathWithoutDrive

                            ' استخدام Process لتنفيذ copy command
                            Dim psi As New ProcessStartInfo()
                            psi.FileName = "cmd.exe"
                            psi.Arguments = "/c copy /Y """ & remoteFilePath & """ """ & fullBackupPath & """"
                            psi.UseShellExecute = False
                            psi.CreateNoWindow = True
                            psi.RedirectStandardOutput = True
                            psi.RedirectStandardError = True

                            Using process As Process = Process.Start(psi)
                                process.WaitForExit(30000) ' انتظار 30 ثانية كحد أقصى

                                ' انتظار قليل للتأكد من اكتمال النسخ
                                System.Threading.Thread.Sleep(1000)

                                If IO.File.Exists(fullBackupPath) Then
                                    fileMoved = True
                                    ' محاولة حذف الملف من السيرفر البعيد
                                    Try
                                        IO.File.Delete(remoteFilePath)
                                    Catch
                                    End Try
                                End If
                            End Using
                        End If
                    Catch
                        ' فشل تنزيل الملف
                    End Try
                End If

                ' تحديد المسار النهائي للعرض
                If fileMoved Then
                    finalBackupPath = fullBackupPath
                Else
                    ' إذا فشل النقل وكان السيرفر بعيد، نعرض رسالة توضح المشكلة
                    If isRemoteServer Then
                        finalBackupPath = sqlServerFullPath
                    Else
                        finalBackupPath = sqlServerFullPath
                    End If
                End If
            End If ' End If لـ If Not backupSucceeded Then في السطر 180

            ' عرض رسالة النجاح
            prbBackup.Value = 100
            Timer1.Stop()
            
            ' تحديد ما إذا كان الملف في المسار المطلوب
            Dim fileInCorrectLocation As Boolean = (finalBackupPath = fullBackupPath)
            
            ' إذا كان الملف في المسار المطلوب، استخدمه للاسترداد
            If fileInCorrectLocation Then
                txtRestorePath.Text = finalBackupPath
            Else
                ' إذا كان الملف في مكان آخر، استخدم المسار الفعلي
                txtRestorePath.Text = finalBackupPath
            End If
            
            btnRestore.Enabled = True
            
            If fileInCorrectLocation Then
                ' الملف في المسار المطلوب
                MsgBox("تم النسخ الاحتياطي بنجاح!" & vbCrLf & "Database backup successful!" & vbCrLf & vbCrLf & "الملف: " & finalBackupPath, MsgBoxStyle.Information, AppTitle)
            Else
                ' الملف في مكان آخر (مجلد SQL Server أو السيرفر البعيد)
                Dim messageText As String = "تم النسخ الاحتياطي بنجاح!" & vbCrLf & "Database backup successful!" & vbCrLf & vbCrLf & "الملف موجود في:" & vbCrLf & finalBackupPath & vbCrLf & vbCrLf
                
                If isRemoteServer Then
                    messageText &= "ملاحظة: الملف موجود على السيرفر البعيد (" & remoteServerName & ")." & vbCrLf & "يرجى الوصول للسيرفر لنسخ الملف يدوياً إلى المسار المطلوب." & vbCrLf & vbCrLf & "أو يمكنك استخدام مسار مشترك (Shared Folder) يمكن الوصول إليه من السيرفر البعيد."
                Else
                    messageText &= "ملاحظة: لم نتمكن من نقل الملف إلى المسار المحدد." & vbCrLf & "يرجى نسخ الملف يدوياً من الموقع أعلاه."
                End If
                
                MsgBox(messageText, MsgBoxStyle.Information, AppTitle)
            End If
            
        Catch ex As Exception
            MsgBox("خطأ في النسخ الاحتياطي:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, AppTitle)
        End Try
        If ManualBackup = False Then Dispose()
    End Sub
    Private Sub Sql_InfoMessage(sender As Object, e As SqlInfoMessageEventArgs)
        For Each err As SqlError In e.Errors
            If err.Message.Contains("percent processed") Then
                ' استخراج النسبة
                Dim msg As String = err.Message ' مثال: "60 percent processed"
                Dim percentString As String = msg.Split(" "c)(0)
                Dim percentValue As Integer
                If Integer.TryParse(percentString, percentValue) Then
                    Label3.Invoke(Sub() Label3.Text = $"جارٍ المعالجة: {percentValue}%")
                    prbBackup.Invoke(Sub() prbBackup.Value = percentValue)
                End If
            End If
        Next
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Backup()
    End Sub

    Private Sub Restore()
        If txtRestorePath.Text Is String.Empty Then
            MsgBox("حدد مسار النسخة الاحتياطية أولًا" & vbCrLf & "Please enter backup file location", , AppTitle)
            Exit Sub
        End If
        
        ' تنظيف المسار وإزالة المسافات الزائدة
        Dim restorePath As String = txtRestorePath.Text.Trim()
        
        ' إزالة علامات الاقتباس إذا كانت موجودة
        If restorePath.StartsWith("""") AndAlso restorePath.EndsWith("""") Then
            restorePath = restorePath.Substring(1, restorePath.Length - 2)
        End If
        
        ' التحقق من وجود المجلد أولاً
        Dim directoryPath As String = IO.Path.GetDirectoryName(restorePath)
        If Not String.IsNullOrEmpty(directoryPath) AndAlso Not IO.Directory.Exists(directoryPath) Then
            Dim errorMsg As String = "المجلد غير موجود!" & vbCrLf & vbCrLf &
                "المجلد: " & directoryPath & vbCrLf & vbCrLf &
                "Directory not found!" & vbCrLf & vbCrLf &
                "Directory: " & directoryPath & vbCrLf & vbCrLf &
                "يرجى التحقق من أن المجلد موجود وأن المسار صحيح."
            
            MsgBox(errorMsg, MsgBoxStyle.Critical, AppTitle)
            btnRestore.Enabled = True
            Exit Sub
        End If
        
        ' التحقق من وجود الملف
        If Not IO.File.Exists(restorePath) Then
            Dim fileName As String = IO.Path.GetFileName(restorePath)
            Dim errorMsg As String = "الملف غير موجود في المسار المحدد!" & vbCrLf & vbCrLf &
                "اسم الملف: " & fileName & vbCrLf &
                "المجلد: " & directoryPath & vbCrLf &
                "المسار الكامل: " & restorePath & vbCrLf & vbCrLf &
                "File not found at specified path!" & vbCrLf & vbCrLf &
                "File name: " & fileName & vbCrLf &
                "Directory: " & directoryPath & vbCrLf &
                "Full path: " & restorePath & vbCrLf & vbCrLf &
                "يرجى التحقق من:" & vbCrLf &
                "1. أن الملف موجود في هذا المسار" & vbCrLf &
                "2. أن اسم الملف صحيح" & vbCrLf &
                "3. أن لديك صلاحيات للوصول للملف" & vbCrLf &
                "4. أن الملف لم يتم نقله أو حذفه" & vbCrLf & vbCrLf &
                "Please check:" & vbCrLf &
                "1. The file exists at this path" & vbCrLf &
                "2. The file name is correct" & vbCrLf &
                "3. You have permissions to access the file" & vbCrLf &
                "4. The file was not moved or deleted"
            
            MsgBox(errorMsg, MsgBoxStyle.Critical, AppTitle)
            btnRestore.Enabled = True
            Exit Sub
        End If
        
        ' التحقق من أن الملف ليس فارغاً
        Try
            Dim fileInfo As New IO.FileInfo(restorePath)
            If fileInfo.Length = 0 Then
                MsgBox("الملف فارغ أو تالف!" & vbCrLf & "File is empty or corrupted!" & vbCrLf & vbCrLf & "المسار: " & restorePath, MsgBoxStyle.Critical, AppTitle)
                btnRestore.Enabled = True
                Exit Sub
            End If
        Catch
        End Try

        ' تعريف المتغيرات خارج Try block لتكون متاحة في Catch block
        Dim tempRestorePath As String = ""
        Dim useTempPath As Boolean = False

        Try
            btnRestore.Enabled = False
            Dim con As New SqlConnection(SqlServerConnectionString)
            Dim database As String = con.Database.ToString()
            If con.State <> ConnectionState.Open Then
                con.Open()
            End If
            
            ' فحص إصدار SQL Server المحلي
            Dim localVersion As String = ""
            Dim localVersionNumber As Decimal = 0
            Try
                Dim versionCmd As New SqlCommand("SELECT @@VERSION", con)
                Dim versionText As String = versionCmd.ExecuteScalar().ToString()
                
                ' استخراج رقم الإصدار من نص الإصدار
                ' مثال: "Microsoft SQL Server 2014 (SP3) (12.0.6024.0)"
                Dim versionMatch As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(versionText, "(\d+)\.(\d+)\.(\d+)\.(\d+)")
                If versionMatch.Success Then
                    localVersion = versionMatch.Groups(1).Value & "." & versionMatch.Groups(2).Value
                    Decimal.TryParse(localVersion, localVersionNumber)
                End If
            Catch
            End Try
            
            ' فحص إصدار SQL Server في ملف Backup
            Dim backupVersion As String = ""
            Dim backupVersionNumber As Decimal = 0
            Try
                Dim sqlBackupPath As String = restorePath.Replace("'", "''")
                Dim backupInfoCmd As New SqlCommand(
                    "RESTORE HEADERONLY FROM DISK = N'" & sqlBackupPath & "'", con)
                backupInfoCmd.CommandTimeout = 30
                
                Using reader As SqlDataReader = backupInfoCmd.ExecuteReader()
                    If reader.Read() Then
                        ' DatabaseVersion هو رقم الإصدار (مثال: 14 = SQL Server 2017)
                        If Not reader.IsDBNull("DatabaseVersion") Then
                            Dim dbVersion As Integer = reader.GetInt32("DatabaseVersion")
                            backupVersionNumber = dbVersion
                            
                            ' تحويل رقم الإصدار إلى نص
                            Select Case dbVersion
                                Case 11
                                    backupVersion = "11.0 (SQL Server 2012)"
                                Case 12
                                    backupVersion = "12.0 (SQL Server 2014)"
                                Case 13
                                    backupVersion = "13.0 (SQL Server 2016)"
                                Case 14
                                    backupVersion = "14.0 (SQL Server 2017)"
                                Case 15
                                    backupVersion = "15.0 (SQL Server 2019)"
                                Case 16
                                    backupVersion = "16.0 (SQL Server 2022)"
                                Case Else
                                    backupVersion = dbVersion.ToString() & ".0"
                            End Select
                        End If
                    End If
                End Using
            Catch backupInfoEx As Exception
                ' إذا فشل فحص معلومات Backup، نتابع المحاولة
            End Try
            
            ' التحقق من توافق الإصدارات
            If backupVersionNumber > 0 AndAlso localVersionNumber > 0 Then
                If backupVersionNumber > localVersionNumber Then
                    Dim errorMsg As String = "تعارض في إصدارات SQL Server!" & vbCrLf & vbCrLf &
                        "إصدار SQL Server في ملف Backup: " & backupVersion & vbCrLf &
                        "إصدار SQL Server المحلي: " & localVersion & vbCrLf & vbCrLf &
                        "لا يمكن استعادة backup من إصدار أحدث على إصدار أقدم." & vbCrLf & vbCrLf &
                        "الحلول الممكنة:" & vbCrLf &
                        "1. قم بتحديث SQL Server المحلي إلى إصدار " & backupVersion & " أو أحدث" & vbCrLf &
                        "2. أو قم بعمل backup جديد من SQL Server " & localVersion & vbCrLf & vbCrLf &
                        "SQL Server Version Conflict!" & vbCrLf &
                        "Backup was created on: " & backupVersion & vbCrLf &
                        "Local SQL Server: " & localVersion & vbCrLf & vbCrLf &
                        "Cannot restore a backup from a newer version to an older version."
                    
                    MsgBox(errorMsg, MsgBoxStyle.Critical, AppTitle)
                    btnRestore.Enabled = True
                    con.Close()
                    Exit Sub
                End If
            End If
            
            ' التحقق إذا كان السيرفر بعيد
            Dim isRemoteServer As Boolean = False
            Dim remoteServerName As String = ""
            Try
                Dim connBuilder As New SqlConnectionStringBuilder(SqlServerConnectionString)
                Dim dataSource As String = connBuilder.DataSource
                remoteServerName = dataSource
                
                ' استخراج اسم السيرفر (بدون الـ instance)
                If dataSource.Contains("\") Then
                    remoteServerName = dataSource.Split("\"c)(0)
                End If
                
                ' التحقق إذا كان السيرفر بعيد
                Dim localMachineName As String = Environment.MachineName
                Dim isIPAddress As Boolean = System.Text.RegularExpressions.Regex.IsMatch(remoteServerName, "^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$")
                
                isRemoteServer = isIPAddress OrElse 
                                  (Not remoteServerName.Equals("localhost", StringComparison.OrdinalIgnoreCase) AndAlso 
                                   Not remoteServerName.Equals("(local)", StringComparison.OrdinalIgnoreCase) AndAlso
                                   Not remoteServerName.Equals(localMachineName, StringComparison.OrdinalIgnoreCase) AndAlso
                                   Not remoteServerName.Equals(".") AndAlso
                                   Not remoteServerName.StartsWith("."))
            Catch
            End Try
            
            ' نسخ الملف إلى السيرفر إذا كان بعيداً
            Dim finalRestorePath As String = restorePath
            Dim fileName As String = IO.Path.GetFileName(restorePath)
            
            If isRemoteServer Then
                ' إذا كان السيرفر بعيد، يجب نسخ الملف من الجهاز المحلي إلى السيرفر أولاً
                ' الحصول على مسار SQL Server DATA على السيرفر البعيد
                Dim sqlServerDataPath As String = ""
                Try
                    Dim dataPathCmd As New SqlCommand("SELECT SERVERPROPERTY('InstanceDefaultDataPath')", con)
                    Dim dataPathObj As Object = dataPathCmd.ExecuteScalar()
                    If dataPathObj IsNot Nothing AndAlso Not IsDBNull(dataPathObj) Then
                        sqlServerDataPath = dataPathObj.ToString().TrimEnd("\"c)
                    End If
                Catch
                End Try
                
                ' إذا لم نجد مسار SQL Server، استخدم C:\
                If String.IsNullOrEmpty(sqlServerDataPath) Then
                    sqlServerDataPath = "C:\"
                End If
                
                Dim serverRestorePath As String = sqlServerDataPath & "\" & fileName
                
                ' التحقق إذا كان الملف موجوداً على السيرفر
                Dim fileExistsOnServer As Boolean = False
                Try
                    Dim checkCmd As New SqlCommand("RESTORE HEADERONLY FROM DISK = N'" & serverRestorePath.Replace("'", "''") & "'", con)
                    checkCmd.CommandTimeout = 5
                    checkCmd.ExecuteScalar()
                    fileExistsOnServer = True
                    finalRestorePath = serverRestorePath
                    tempRestorePath = serverRestorePath
                    useTempPath = True
                Catch
                    ' الملف غير موجود على السيرفر - سنقوم بنسخه
                    fileExistsOnServer = False
                End Try
                
                If Not fileExistsOnServer Then
                    ' نسخ الملف من الجهاز المحلي إلى السيرفر البعيد
                    Try
                        ' تفعيل Ad Hoc Distributed Queries و xp_cmdshell
                        Try
                            Dim enableCmd As New SqlCommand("EXEC sp_configure 'show advanced options', 1; RECONFIGURE;", con)
                            enableCmd.ExecuteNonQuery()
                            enableCmd.CommandText = "EXEC sp_configure 'Ad Hoc Distributed Queries', 1; RECONFIGURE;"
                            enableCmd.ExecuteNonQuery()
                            enableCmd.CommandText = "EXEC sp_configure 'xp_cmdshell', 1; RECONFIGURE;"
                            enableCmd.ExecuteNonQuery()
                        Catch
                        End Try
                        
                        ' قراءة الملف من الجهاز المحلي
                        Dim fileBytes As Byte() = IO.File.ReadAllBytes(restorePath)
                        
                        ' إنشاء مجلد مؤقت على السيرفر إذا لم يكن موجوداً
                        Dim tempDir As String = sqlServerDataPath & "\TempRestore"
                        Try
                            Dim mkdirCmd As New SqlCommand("EXEC xp_cmdshell 'if not exist """ & tempDir & """ mkdir """ & tempDir & """'", con)
                            mkdirCmd.ExecuteNonQuery()
                        Catch
                        End Try
                        
                        serverRestorePath = tempDir & "\" & fileName
                        
                        ' نسخ الملف إلى السيرفر باستخدام PowerShell و Base64
                        ' نستخدم طريقة Base64 لتجنب مشاكل الأحرف الخاصة
                        Try
                            ' تحويل الملف إلى Base64
                            Dim base64Content As String = Convert.ToBase64String(fileBytes)
                            
                            ' تقسيم Base64 إلى أجزاء صغيرة لتجنب مشاكل طول الأوامر
                            Dim chunkSize As Integer = 8000 ' حجم كل جزء
                            Dim chunks As New List(Of String)
                            For i As Integer = 0 To base64Content.Length - 1 Step chunkSize
                                Dim length As Integer = Math.Min(chunkSize, base64Content.Length - i)
                                chunks.Add(base64Content.Substring(i, length))
                            Next
                            
                            ' كتابة Base64 إلى ملف نصي على السيرفر جزء جزء
                            Dim tempBase64File As String = tempDir & "\" & fileName & ".b64"
                            Dim firstChunk As Boolean = True
                                            
                            For Each chunk As String In chunks
                                Dim appendFlag As String = If(firstChunk, ">", ">>")
                                Dim psCmd As String = "powershell -Command ""'" & chunk.Replace("'", "''") & "' | Out-File -FilePath '" & tempBase64File.Replace("\", "\\") & "' -Encoding ASCII -Append"""
                                Dim writeCmd As New SqlCommand("EXEC xp_cmdshell '" & psCmd & "'", con)
                                writeCmd.ExecuteNonQuery()
                                firstChunk = False
                            Next
                            
                            ' تحويل Base64 إلى ملف ثنائي على السيرفر
                            Dim convertCmd As String = "powershell -Command ""$content = [System.IO.File]::ReadAllText('" & tempBase64File.Replace("\", "\\") & "'); $bytes = [System.Convert]::FromBase64String($content); [System.IO.File]::WriteAllBytes('" & serverRestorePath.Replace("\", "\\") & "', $bytes)"""
                            
                            Dim convertSqlCmd As New SqlCommand("EXEC xp_cmdshell '" & convertCmd & "'", con)
                            convertSqlCmd.ExecuteNonQuery()
                            
                            ' حذف ملف Base64 المؤقت
                            Try
                                Dim delCmd As New SqlCommand("EXEC xp_cmdshell 'del """ & tempBase64File & """'", con)
                                delCmd.ExecuteNonQuery()
                            Catch
                            End Try
                            
                            ' التحقق من وجود الملف على السيرفر
                            System.Threading.Thread.Sleep(1000) ' انتظار قليل
                            Try
                                Dim verifyCmd As New SqlCommand("RESTORE HEADERONLY FROM DISK = N'" & serverRestorePath.Replace("'", "''") & "'", con)
                                verifyCmd.CommandTimeout = 5
                                verifyCmd.ExecuteScalar()
                                fileExistsOnServer = True
                                finalRestorePath = serverRestorePath
                                tempRestorePath = serverRestorePath
                                useTempPath = True
                            Catch
                                ' الملف لم يُنسخ بنجاح
                                fileExistsOnServer = False
                            End Try
                            
                        Catch base64Ex As Exception
                            RecordRrrors(DescriptionRrrors:="Failed to copy restore file to remote server using Base64: " & base64Ex.ToString)
                            fileExistsOnServer = False
                        End Try
                        
                        If Not fileExistsOnServer Then
                            ' إذا فشلت طريقة Base64، اطلب من المستخدم نسخ الملف يدوياً
                            Dim errorMsg As String = "⚠️ فشل نسخ الملف تلقائياً إلى السيرفر البعيد!" & vbCrLf & vbCrLf &
                                "يرجى نسخ الملف التالي:" & vbCrLf &
                                restorePath & vbCrLf & vbCrLf &
                                "إلى السيرفر في المسار التالي:" & vbCrLf &
                                serverRestorePath & vbCrLf & vbCrLf &
                                "ثم حاول مرة أخرى." & vbCrLf & vbCrLf &
                                "⚠️ Failed to automatically copy file to remote server!" & vbCrLf & vbCrLf &
                                "Please manually copy the following file:" & vbCrLf &
                                restorePath & vbCrLf & vbCrLf &
                                "To the server at:" & vbCrLf &
                                serverRestorePath & vbCrLf & vbCrLf &
                                "Then try again."
                            
                            MsgBox(errorMsg, MsgBoxStyle.Exclamation, AppTitle)
                            btnRestore.Enabled = True
                            con.Close()
                            Exit Sub
                        End If
                        
                    Catch remoteEx As Exception
                        RecordRrrors(DescriptionRrrors:="Failed to copy restore file to remote server: " & remoteEx.ToString)
                        MsgBox("خطأ في نسخ الملف إلى السيرفر البعيد." & vbCrLf & 
                              "Error copying file to remote server: " & remoteEx.Message, 
                              MsgBoxStyle.Critical, AppTitle)
                        btnRestore.Enabled = True
                        con.Close()
                        Exit Sub
                    End Try
                End If
            Else
                ' إذا كان السيرفر محلي، نسخ الملف إلى C:\ أو مجلد SQL Server DATA
                Try
                    Dim cDrivePath As String = "C:\" & fileName
                    
                    ' نسخ الملف إلى C:\
                    IO.File.Copy(restorePath, cDrivePath, True)
                    
                    ' التحقق من نجاح النسخ
                    If IO.File.Exists(cDrivePath) Then
                        finalRestorePath = cDrivePath
                        tempRestorePath = cDrivePath
                        useTempPath = True
                    End If
                Catch copyEx As Exception
                    ' إذا فشل النسخ إلى C:\، جرب مجلد SQL Server DATA
                    Try
                        ' الحصول على مسار SQL Server DATA
                        Dim sqlServerDataPath As String = ""
                        Try
                            Dim dataPathCmd As New SqlCommand("SELECT SERVERPROPERTY('InstanceDefaultDataPath')", con)
                            Dim dataPathObj As Object = dataPathCmd.ExecuteScalar()
                            If dataPathObj IsNot Nothing AndAlso Not IsDBNull(dataPathObj) Then
                                sqlServerDataPath = dataPathObj.ToString().TrimEnd("\"c)
                            End If
                        Catch
                        End Try
                        
                        ' إذا لم نجد مسار SQL Server، جرب مسارات افتراضية
                        If String.IsNullOrEmpty(sqlServerDataPath) Then
                            Dim possiblePaths As String() = {
                                "C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA",
                                "C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA",
                                "C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA",
                                "C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA"
                            }
                            For Each path As String In possiblePaths
                                If IO.Directory.Exists(path) Then
                                    sqlServerDataPath = path
                                    Exit For
                                End If
                            Next
                        End If
                        
                        ' إذا وجدنا مسار SQL Server، انسخ الملف إليه
                        If Not String.IsNullOrEmpty(sqlServerDataPath) Then
                            tempRestorePath = sqlServerDataPath & "\" & fileName
                            IO.File.Copy(restorePath, tempRestorePath, True)
                            
                            If IO.File.Exists(tempRestorePath) Then
                                finalRestorePath = tempRestorePath
                                useTempPath = True
                            End If
                        End If
                    Catch
                        ' إذا فشل كل شيء، استخدم المسار الأصلي
                        finalRestorePath = restorePath
                    End Try
                End Try
            End If
            
            ' استخدام المسار النهائي للاستعادة
            Dim sqlRestorePath As String = finalRestorePath.Replace("'", "''")
            
            Timer1.Start()
            Dim sqlStmt2 As String = String.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE")
            Dim bu2 As SqlCommand = New SqlCommand(sqlStmt2, con)
            bu2.CommandTimeout = 0
            bu2.ExecuteNonQuery()
            
            Dim sqlStmt3 As String = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK=N'" + sqlRestorePath + "' WITH REPLACE, STATS = 10"
            Dim bu3 As SqlCommand = New SqlCommand(sqlStmt3, con)
            bu3.CommandTimeout = 0
            bu3.ExecuteNonQuery()
            Dim sqlStmt4 As String = String.Format("ALTER DATABASE [" + database + "] SET MULTI_USER")
            Dim bu4 As New SqlCommand(sqlStmt4, con)
            bu4.CommandTimeout = 0
            bu4.ExecuteNonQuery()
            con.Close()
            If con.State = ConnectionState.Open Then
                prbRestore.Increment(1)
            ElseIf con.State = ConnectionState.Closed Then
                prbRestore.Increment(100)
                Timer1.Stop()
                
                ' حذف الملف المؤقت إذا تم استخدامه
                If useTempPath AndAlso Not String.IsNullOrEmpty(tempRestorePath) AndAlso IO.File.Exists(tempRestorePath) Then
                    Try
                        IO.File.Delete(tempRestorePath)
                    Catch
                    End Try
                End If
                
                MsgBox("تم إرجاع النسخة الاحتياطية بنجاح" & vbCrLf & "Database Restore Done Successfully", , AppTitle)
            Else
            End If
        Catch ex As Exception
            ' حذف الملف المؤقت إذا تم استخدامه
            If useTempPath AndAlso Not String.IsNullOrEmpty(tempRestorePath) AndAlso IO.File.Exists(tempRestorePath) Then
                Try
                    IO.File.Delete(tempRestorePath)
                Catch
                End Try
            End If
            
            Dim errorMessage As String = ex.Message
            
            ' تحسين رسالة الخطأ لتكون أكثر وضوحاً
            If errorMessage.Contains("version") OrElse errorMessage.Contains("incompatible") Then
                errorMessage = "تعارض في إصدارات SQL Server!" & vbCrLf & vbCrLf &
                    "النسخ الاحتياطي تم على إصدار أحدث من SQL Server المحلي." & vbCrLf & vbCrLf &
                    "الحل: قم بتحديث SQL Server المحلي أو استخدم backup من إصدار متوافق." & vbCrLf & vbCrLf &
                    "SQL Server Version Conflict!" & vbCrLf &
                    "The backup was created on a newer SQL Server version." & vbCrLf &
                    "Solution: Update your local SQL Server or use a compatible backup."
            ElseIf errorMessage.Contains("Access is denied") OrElse errorMessage.Contains("error 5") Then
                errorMessage = "خطأ في الصلاحيات!" & vbCrLf & vbCrLf &
                    "SQL Server لا يملك صلاحيات للوصول للملف في هذا المسار." & vbCrLf & vbCrLf &
                    "المسار: " & restorePath & vbCrLf & vbCrLf &
                    "الحلول الممكنة:" & vbCrLf &
                    "1. انسخ الملف إلى مجلد يمكن لـ SQL Server الوصول إليه" & vbCrLf &
                    "2. أو أضف صلاحيات للوصول للملف/المجلد" & vbCrLf &
                    "3. أو استخدم مسار في مجلد SQL Server DATA" & vbCrLf & vbCrLf &
                    "Access Denied Error!" & vbCrLf &
                    "SQL Server cannot access the file at this path." & vbCrLf & vbCrLf &
                    "Path: " & restorePath & vbCrLf & vbCrLf &
                    "Solutions:" & vbCrLf &
                    "1. Copy file to a folder SQL Server can access" & vbCrLf &
                    "2. Add permissions to the file/folder" & vbCrLf &
                    "3. Use a path in SQL Server DATA folder"
            End If
            
            MsgBox("خطأ في النسخة الاحتياطية:" & vbCrLf & errorMessage & vbCrLf & vbCrLf & "Database Restore Failed", MsgBoxStyle.Critical, AppTitle)
            btnRestore.Enabled = True
        End Try
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Restore()
    End Sub

    Private Sub btnRestorePath_Click(sender As Object, e As EventArgs) Handles btnRestorePath.Click
        'مسار الاسترداد
        Dim dlg As OpenFileDialog = New OpenFileDialog()
        dlg.Filter = "SQL SERVER database backup files|*.bak"
        dlg.Title = "Database Restore"

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtRestorePath.Text = dlg.FileName
            btnRestore.Enabled = True
            btnRestorePath.Enabled = False
        End If
    End Sub

    Private Sub btnSavePath_Click(sender As Object, e As EventArgs) Handles btnSavePath.Click
        'مسار الحفط
        Dim dlg As FolderBrowserDialog = New FolderBrowserDialog()
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtBackupPath.Text = dlg.SelectedPath
            btnSave.Enabled = True
            txtBackupPath.Enabled = True
        End If
    End Sub

    Private Sub btnDefaultPath_Click(sender As Object, e As EventArgs) Handles btnSaveDefaultPath.Click
        If chkAutoBackup.Checked = False Then
            GlCommand.CommandText = "UPDATE [Settings] SET [SET_INVARCHR160] = N''"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Settings] SET [SET_INVARCHR161] = N''"
            GlCommand.ExecuteNonQuery()
            If IO.Directory.Exists(txtBackupPath.Text.Trim) Then
                GlCommand.CommandText = "UPDATE [Settings] SET [SET_INVARCHR159] = N'" & txtBackupPath.Text.Trim & "'"
                GlCommand.ExecuteNonQuery()
            End If
            GetBackupValues()
            Exit Sub
        End If
        If txtBackupPath.Text.Trim = "" Then
            MsgBox("حدد مسار أولا" & vbCrLf & "Please Select a path first", vbExclamation)
        Else
            If IO.Directory.Exists(txtBackupPath.Text.Trim) Then
                GlCommand.CommandText = "UPDATE [Settings] SET [SET_INVARCHR159] = N'" & txtBackupPath.Text.Trim & "'"
                GlCommand.ExecuteNonQuery()
            Else
                MsgBox("حدد مسار صالح أولا" & vbCrLf & "Please Select a valid path first", vbExclamation)
            End If
            GlCommand.CommandText = "UPDATE [Settings] SET [SET_INVARCHR160] = N'" & nudBackupHour.Value & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Settings] SET [SET_INVARCHR161] = N'" & nudBackupMinute.Value & "'"
            GlCommand.ExecuteNonQuery()
        End If
        GetBackupValues()
    End Sub

    Private Sub chkAutoBackup_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoBackup.CheckedChanged
        nudBackupHour.Enabled = chkAutoBackup.Checked
        nudBackupMinute.Enabled = chkAutoBackup.Checked
    End Sub

    Private Sub txtBackupPath_TextChanged(sender As Object, e As EventArgs) Handles txtBackupPath.TextChanged
        btnSave.Enabled = True
    End Sub
    
    ' دالة لتنزيل الملف من السيرفر البعيد إلى الجهاز المحلي
    Private Sub DownloadBackupFromRemoteServer()
        Try
            If String.IsNullOrEmpty(txtBackupPath.Text.Trim()) Then
                MsgBox("لم يتم تحديد مسار الحفظ" & vbCrLf & "Please enter backup file location", , AppTitle)
                Exit Sub
            End If
            
            Dim backupPath As String = txtBackupPath.Text.Trim()
            
            ' التحقق من وجود المسار وإنشائه إذا لم يكن موجوداً
            If Not IO.Directory.Exists(backupPath) Then
                Try
                    IO.Directory.CreateDirectory(backupPath)
                Catch dirEx As Exception
                    MsgBox("خطأ في إنشاء المجلد - تأكد من صحة المسار" & vbCrLf & dirEx.Message, MsgBoxStyle.Critical, AppTitle)
                    Exit Sub
                End Try
            End If
            
            ' فتح الاتصال بقاعدة البيانات
            OpenDataBase()
            
            ' التحقق من نوع الاتصال (محلي أم بعيد)
            Dim isRemoteServer As Boolean = False
            Dim remoteServerName As String = ""
            Try
                Dim connBuilder As New SqlConnectionStringBuilder(SqlServerConnectionString)
                Dim dataSource As String = connBuilder.DataSource
                remoteServerName = dataSource
                
                If dataSource.Contains("\") Then
                    remoteServerName = dataSource.Split("\"c)(0)
                End If
                
                Dim localMachineName As String = Environment.MachineName
                Dim isIPAddress As Boolean = System.Text.RegularExpressions.Regex.IsMatch(remoteServerName, "^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$")
                
                isRemoteServer = isIPAddress OrElse 
                                  (Not remoteServerName.Equals("localhost", StringComparison.OrdinalIgnoreCase) AndAlso 
                                   Not remoteServerName.Equals("(local)", StringComparison.OrdinalIgnoreCase) AndAlso
                                   Not remoteServerName.Equals(localMachineName, StringComparison.OrdinalIgnoreCase) AndAlso
                                   Not remoteServerName.Equals(".") AndAlso
                                   Not remoteServerName.StartsWith("."))
            Catch
            End Try
            
            If Not isRemoteServer Then
                MsgBox("أنت متصل بسيرفر محلي. هذه الوظيفة مخصصة للسيرفرات البعيدة فقط." & vbCrLf & "You are connected to a local server. This function is for remote servers only.", MsgBoxStyle.Information, AppTitle)
                Exit Sub
            End If
            
            ' البحث عن آخر ملف backup على السيرفر البعيد
            Dim sqlServerBackupPath As String = ""
            Try
                GlCommand.CommandText = "SELECT SERVERPROPERTY('InstanceDefaultDataPath')"
                Dim dataPath As Object = GlCommand.ExecuteScalar()
                If dataPath IsNot Nothing AndAlso Not IsDBNull(dataPath) Then
                    sqlServerBackupPath = dataPath.ToString().TrimEnd("\"c)
                End If
            Catch
            End Try
            
            ' إذا لم نتمكن من الحصول على المسار، نحاول الحصول على اسم الـ instance
            If String.IsNullOrEmpty(sqlServerBackupPath) Then
                Try
                    GlCommand.CommandText = "SELECT @@SERVERNAME"
                    Dim serverName As Object = GlCommand.ExecuteScalar()
                    If serverName IsNot Nothing AndAlso Not IsDBNull(serverName) Then
                        Dim serverNameStr As String = serverName.ToString()
                        Dim instanceName As String = ""
                        If serverNameStr.Contains("\") Then
                            instanceName = serverNameStr.Split("\"c)(1)
                        Else
                            instanceName = "MSSQLSERVER"
                        End If
                        
                        Dim possiblePaths As String() = {
                            "C:\Program Files\Microsoft SQL Server\MSSQL14." & instanceName & "\MSSQL\DATA",
                            "C:\Program Files\Microsoft SQL Server\MSSQL15." & instanceName & "\MSSQL\DATA",
                            "C:\Program Files\Microsoft SQL Server\MSSQL16." & instanceName & "\MSSQL\DATA"
                        }
                        
                        For Each path As String In possiblePaths
                            If IO.Directory.Exists("\\" & remoteServerName & "\" & path.Substring(0, 1) & "$\" & path.Substring(3)) Then
                                sqlServerBackupPath = path
                                Exit For
                            End If
                        Next
                    End If
                Catch
                End Try
            End If
            
            If String.IsNullOrEmpty(sqlServerBackupPath) Then
                ' محاولة استخراج اسم السيرفر من connection string
                Try
                    Dim connBuilder As New SqlConnectionStringBuilder(SqlServerConnectionString)
                    Dim dataSource As String = connBuilder.DataSource
                    Dim instanceName As String = "MSSQLSERVER"
                    
                    If dataSource.Contains("\") Then
                        instanceName = dataSource.Split("\"c)(1)
                    End If
                    
                    sqlServerBackupPath = "C:\Program Files\Microsoft SQL Server\MSSQL14." & instanceName & "\MSSQL\DATA"
                Catch
                End Try
            End If
            
            ' البحث عن ملفات backup في المجلد باستخدام SQL
            Dim backupFiles As New List(Of String)
            Dim sqlServerFullPath As String = ""
            Dim localBackupPath As String = ""
            
            Try
                ' استخدام xp_cmdshell للبحث عن الملفات
                Try
                    GlCommand.CommandText = "EXEC sp_configure 'show advanced options', 1; RECONFIGURE;"
                    GlCommand.ExecuteNonQuery()
                    GlCommand.CommandText = "EXEC sp_configure 'xp_cmdshell', 1; RECONFIGURE;"
                    GlCommand.ExecuteNonQuery()
                Catch
                End Try
                
                ' البحث عن آخر ملف backup
                Dim findCommand As String = String.Format("EXEC xp_cmdshell 'forfiles /P ""{0}"" /M ""{1}-*.bak"" /C ""cmd /c echo @path"" /O-D', NO_OUTPUT", sqlServerBackupPath, database)
                GlCommand.CommandText = findCommand
                
                Using reader As SqlDataReader = GlCommand.ExecuteReader()
                    While reader.Read()
                        If Not reader.IsDBNull(0) Then
                            Dim line As String = reader.GetString(0).Trim()
                            If line.EndsWith(".bak") AndAlso line.Contains(database) Then
                                backupFiles.Add(line)
                            End If
                        End If
                    End While
                End Using
                
                ' إذا فشلت الطريقة الأولى، جرب طريقة أخرى
                If backupFiles.Count = 0 Then
                    findCommand = String.Format("EXEC xp_cmdshell 'dir /B /O-D ""{0}\{1}-*.bak""'", sqlServerBackupPath, database)
                    GlCommand.CommandText = findCommand
                    
                    Using reader As SqlDataReader = GlCommand.ExecuteReader()
                        While reader.Read()
                            If Not reader.IsDBNull(0) Then
                                Dim fileName As String = reader.GetString(0).Trim()
                                If fileName.EndsWith(".bak") AndAlso Not fileName.StartsWith("NULL") Then
                                    backupFiles.Add(fileName)
                                End If
                            End If
                        End While
                    End Using
                End If
            Catch
            End Try
            
            ' إذا لم نجد ملفات، نطلب من المستخدم إدخال اسم الملف
            If backupFiles.Count = 0 Then
                Dim fileNameInput As String = InputBox("لم يتم العثور على ملفات backup تلقائياً." & vbCrLf & "يرجى إدخال اسم ملف backup الموجود على السيرفر البعيد:" & vbCrLf & vbCrLf & "No backup files found automatically." & vbCrLf & "Please enter the backup file name on remote server:", "تنزيل من السيرفر البعيد", database & "-*.bak")
                
                If String.IsNullOrEmpty(fileNameInput) Then
                    Exit Sub
                End If
                
                sqlServerFullPath = sqlServerBackupPath & "\" & fileNameInput
                localBackupPath = backupPath & "\" & fileNameInput
            Else
                ' استخدام أول ملف (الأحدث)
                Dim latestBackupFile As String = backupFiles(0)
                ' إذا كان المسار كامل، استخدمه مباشرة
                If latestBackupFile.Contains("\") Then
                    sqlServerFullPath = latestBackupFile
                    localBackupPath = backupPath & "\" & IO.Path.GetFileName(latestBackupFile)
                Else
                    sqlServerFullPath = sqlServerBackupPath & "\" & latestBackupFile
                    localBackupPath = backupPath & "\" & latestBackupFile
                End If
            End If
            
            ' تنزيل الملف باستخدام Binary Download
            prbBackup.Value = 0
            Label3.Text = "جارٍ تنزيل الملف من السيرفر البعيد..."
            
            Try
                ' تفعيل Ad Hoc Distributed Queries
                Try
                    GlCommand.CommandText = "EXEC sp_configure 'Ad Hoc Distributed Queries', 1; RECONFIGURE;"
                    GlCommand.ExecuteNonQuery()
                Catch
                End Try
                
                ' قراءة الملف كـ binary
                Dim downloadQuery As String = String.Format(
                    "SELECT BulkColumn FROM OPENROWSET(BULK '{0}', SINGLE_BLOB) AS x",
                    sqlServerFullPath.Replace("'", "''"))
                
                GlCommand.CommandTimeout = 0
                GlCommand.CommandText = downloadQuery
                Dim fileData As Object = GlCommand.ExecuteScalar()
                
                If fileData IsNot Nothing AndAlso TypeOf fileData Is Byte() Then
                    Dim bytes As Byte() = DirectCast(fileData, Byte())
                    
                    prbBackup.Value = 50
                    Label3.Text = "جارٍ كتابة الملف على الجهاز المحلي..."
                    
                    ' كتابة البيانات على الجهاز المحلي
                    Using fs As New IO.FileStream(localBackupPath, IO.FileMode.Create, IO.FileAccess.Write)
                        fs.Write(bytes, 0, bytes.Length)
                        fs.Flush()
                    End Using
                    
                    prbBackup.Value = 100
                    Label3.Text = "اكتمل التنزيل بنجاح!"
                    
                    ' التحقق من نجاح الكتابة
                    If IO.File.Exists(localBackupPath) Then
                        Dim fileInfo As New IO.FileInfo(localBackupPath)
                        If fileInfo.Length > 0 Then
                            txtRestorePath.Text = localBackupPath
                            btnRestore.Enabled = True
                            MsgBox("تم تنزيل الملف بنجاح!" & vbCrLf & "File downloaded successfully!" & vbCrLf & vbCrLf & "الملف: " & localBackupPath, MsgBoxStyle.Information, AppTitle)
                        End If
                    End If
                Else
                    MsgBox("فشل في قراءة الملف من السيرفر البعيد." & vbCrLf & "Failed to read file from remote server.", MsgBoxStyle.Critical, AppTitle)
                End If
            Catch downloadEx As Exception
                MsgBox("خطأ في تنزيل الملف:" & vbCrLf & downloadEx.Message, MsgBoxStyle.Critical, AppTitle)
            End Try
            
        Catch ex As Exception
            MsgBox("خطأ في تنزيل النسخ الاحتياطي:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, AppTitle)
        End Try
    End Sub
    
    Private Sub btnDownloadFromServer_Click(sender As Object, e As EventArgs) Handles btnDownloadFromServer.Click
        DownloadBackupFromRemoteServer()
    End Sub
End Class