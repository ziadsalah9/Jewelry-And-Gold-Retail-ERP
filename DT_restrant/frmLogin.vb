'Imports DT_restrant.DT_restrantDataSetTableAdapters
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmLogin
    Public texte As String
    Public Sub SetLanguage()
        If SET_INVARCHR149TextBox.Text = "E" Then
            rbtnEn.Checked = True
        Else
            rbtnAr.Checked = True
        End If
        SettingsTableAdapter.Update(DT_restrantDataSet.Settings)
    End Sub
    Public Sub UploadDataBulk(OnLineSqlConnection As String)
        Dim DataTb As DataTable = GetRecordSet("SELECT dbo.CastomerDETELS.CastomerCAIVELid, dbo.CastomerDETELS.CastomerNAme," & vbCrLf &
                                               "dbo.CastomerDETELS.CastomerADr, dbo.CastomerDETELS.CastomerTE, dbo.CastomerDETELS.CastomerNA," & vbCrLf &
                                               "dbo.CastomerDETELS.CastomerNameEn, dbo.comp_inform.comp_name" & vbCrLf &
                                               "FROM dbo.CastomerDETELS CROSS JOIN dbo.comp_inform")
        If DataTb Is Nothing OrElse DataTb.Rows.Count = 0 Then
            Exit Sub
        End If
        Try
            Using bulkCopy As New SqlBulkCopy(OnLineSqlConnection, SqlBulkCopyOptions.KeepIdentity)
                bulkCopy.DestinationTableName = "CastomerDETELS"
                bulkCopy.BulkCopyTimeout = 0
                bulkCopy.ColumnMappings.Add("CastomerCAIVELid", "CastomerCAIVELid")
                bulkCopy.ColumnMappings.Add("CastomerNAme", "CastomerNAme")
                bulkCopy.ColumnMappings.Add("CastomerADr", "CastomerADr")
                bulkCopy.ColumnMappings.Add("CastomerTE", "CastomerTE")
                bulkCopy.ColumnMappings.Add("CastomerNA", "CastomerNA")
                bulkCopy.ColumnMappings.Add("CastomerNameEn", "CastomerNameEn")
                bulkCopy.ColumnMappings.Add("comp_name", "CompanyName")
                bulkCopy.WriteToServer(DataTb)
            End Using
        Catch ex As Exception
        RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
    End Sub
    Public Sub DELETEFROMCastomerDETELS()
        Try
            Dim DataTab1 As New DataTable
            Using SqlCon1 As New SqlConnection(OnLineSqlConnection)
                Using SqlCom1 As New SqlCommand("EXEC Clean_CastomerDETELS", SqlCon1)
                    SqlCom1.CommandTimeout = 0
                    SqlCon1.Open()
                    Using SqlDataRe1 As SqlDataReader = SqlCom1.ExecuteReader()
                        DataTab1.Load(SqlDataRe1)
                    End Using
                End Using
            End Using
            If DataTab1.Rows.Count > 0 Then
                Dim deletedDuplicates As Integer = Convert.ToInt32(DataTab1.Rows(0)("DeletedDuplicates"))
                Dim deletedInvalid As Integer = Convert.ToInt32(DataTab1.Rows(0)("DeletedInvalid"))
                RecordRrrors(DescriptionRrrors:="تم حذف التكرارات: " & deletedDuplicates & "وتم حذف السجلات غير الصالحة: " & deletedInvalid & "نتيجة التنظيف")
            End If
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try
    End Sub

    Private Async Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        UpdateSettings()
        Dim connStr = GetAvailableSqlConnection()

        If connStr = "" Then
            connStr = GetAvailableSqlConnection_new()
        End If

        Permissions()
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        SetLanguage()
        Inv_startTableAdapter.Fill(DT_restrantDataSet.inv_start)
        DateTimePicker1.Text = Date.Now
        LicensTableAdapter.Fill(DT_restrantDataSet.licens)
        UserTableAdapter.Fill(DT_restrantDataSet.user)
        chkShowPassword.Checked = False
        If (CpuId.Trim & SystemSerialNumber.Trim & licenseID) = "BFEBFBFF000A0655/HT7QF73/CNFCW0009U00AD/" Or (CpuId.Trim & SystemSerialNumber.Trim & licenseID) = "BFEBFBFF000306A96CR32836Y8" Then
            txtUserName.Text = "HOSAM"
            txtPassword.Text = "123"
            'btnLogin.PerformClick()
        End If
        '  MsgBox(connStr)
        '  MsgBox(OnLineSqlConnection)
        'frmMain.LodFromMin()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub lblClose_MouseLeave(sender As Object, e As EventArgs)
        sender.ForeColor = Color.Black
        sender.BackColor = Color.Transparent
    End Sub

    Private Sub btn_MouseMove(sender As Object, e As MouseEventArgs)
        sender.BackColor = Color.LightGreen
        sender.Cursor = Cursors.Hand
    End Sub

    'Private Async Sub btnLogin_Click(sender As Object, e As EventArgs)



    'End Sub
    Private Sub FixPrivilages()
        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkLimitStock') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD [chkLimitStock] BIT NULL DEFAULT 0 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkModifyInvoce') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD [chkModifyInvoce] bit NULL " & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
            'GlCommand.CommandText = "UPDATE [user] SET [chkInvPayInstallment]='TRUE' WHERE [chkInvPayInstallment] IS NULL"
            ' = 0 : GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkInvPayInstallment') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD [chkInvPayInstallment] BIT NULL DEFAULT 0 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkModifyInvoce') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD [chkModifyInvoce] BIT NULL DEFAULT 1 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkDelItem') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD [chkDelItem] BIT NULL DEFAULT 1 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            GlCommand.CommandText = "IF COL_LENGTH('user', 'chkItemSelectInvo') IS NULL " & vbCrLf &
                                    "BEGIN " & vbCrLf &
                                    "ALTER TABLE [user] ADD [chkItemSelectInvo] BIT NULL DEFAULT 1 WITH VALUES" & vbCrLf &
                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try


            GlCommand.CommandText = "UPDATE [User] SET [chkSell] = '0' WHERE [chkSell] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkBarCode] = '0' WHERE [chkBarCode] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkModify] = '0' WHERE [chkModify] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkGramPrice] = '0' WHERE [chkGramPrice] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkSalary] = '0' WHERE [chkSalary] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkWholeSaleBuy] = '0' WHERE [chkWholeSaleBuy] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkUsers] = '0' WHERE [chkUsers] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkCashier] = '0' WHERE [chkCashier] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkWholesale] = '0' WHERE [chkWholesale] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkReports] = '0' WHERE [chkReports] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkExpenses] = '0' WHERE [chkExpenses] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkStock] = '0' WHERE [chkStock] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkItem] = '0' WHERE [chkItem] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkLimitStock] = '0' WHERE [chkLimitStock] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkModifyInvoce] = '0' WHERE [chkModifyInvoce] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkInvPayInstallment] = '0' WHERE [chkInvPayInstallment] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [User] SET [chkSell] = '1' , [chkBarCode] = '1' , [chkModify] = '1' , [chkGramPrice] = '1' , [chkSalary] = '1' , [chkWholeSaleBuy] = '1' , [chkUsers] = '1' , [chkCashier] = '1' , [chkWholesale] = '1' , [chkReports] = '1' , [chkExpenses] = '1' , [chkStock] = '1' , [chkItem] = '1' , [chkLimitStock] = '0',[chkModifyInvoce]='1',[chkInvPayInstallment]='1' WHERE [user_name] = N'hosam'"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
        End Try

    End Sub
    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        Try
            UserBindingSource.Filter = " [user_name] LIKE '%" & txtUserName.Text.Trim & "%'"
            If txtUserName.Text.ToUpper = User_nameTextBox.Text.ToUpper Then
                txtUserName.ForeColor = Color.DarkGreen
            Else
                txtUserName.ForeColor = Color.Black
            End If
        Catch ex As Exception
            MsgBox("لايسمح بإدخال الرموز في اسم المستخدم" & vbCrLf & "Symbols Are Not Allowed in User Name", , AppTitle)

        End Try

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Try
            UserBindingSource.Filter = "  [password] LIKE  '%" & txtPassword.Text & "%'"
            UserBindingSource.Filter = "  [user_name] LIKE  '%" & txtUserName.Text & "%'"
            If txtPassword.Text = PasswordTextBox.Text Then
                txtPassword.ForeColor = Color.DarkGreen
            Else
                txtPassword.ForeColor = Color.Black
            End If
        Catch ex As Exception
            MsgBox("لايسمح بإدخال الرموز في كلمة المرور" & vbCrLf & "Symbols Are Not Allowed in Password", , AppTitle)
        End Try
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = False Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Public Sub SaveLanguage()
        If rbtnEn.Checked = True Then
            GlCommand.CommandText = "UPDATE [Settings] SET [SET_INVARCHR149] = N'E'"
            GlCommand.ExecuteNonQuery()
            lblUserName.Text = "User Name"
            lblPassword.Text = "Password"
        End If
        If rbtnAr.Checked = True Then
            GlCommand.CommandText = "UPDATE [Settings] SET [SET_INVARCHR149] = N'A'"
            GlCommand.ExecuteNonQuery()
            lblUserName.Text = "اسم المستخدم"
            lblPassword.Text = "كلمة المرور"
        End If
    End Sub

    Private Sub rbtnAr_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnAr.CheckedChanged, rbtnEn.CheckedChanged
        SaveLanguage()
    End Sub

    Private Sub BackWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackWorker.DoWork
        UploadDataBulk(OnLineSqlConnection)
        DELETEFROMCastomerDETELS()
    End Sub

    Private Sub lblPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPassword.Click

    End Sub

    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'If txtUserName.Text.ToUpper = User_nameTextBox.Text.ToUpper AndAlso txtPassword.Text = PasswordTextBox.Text Then
        '    Dim dt1 As DataTable = GetRecordSet("SELECT [Active] FROM [user] WHERE [user_name] = N'" & txtUserName.Text & "'")
        '    If dt1.Rows.Count > 0 Then
        '        If dt1.Rows(0)(0) = False Then
        '            MsgBox("مستخدم محذوف")
        '            Exit Sub
        '        End If
        '    End If

        If String.Equals(txtUserName.Text, User_nameTextBox.Text, StringComparison.OrdinalIgnoreCase) _
   AndAlso txtPassword.Text = PasswordTextBox.Text Then

            Dim sql As String = "SELECT [Active] FROM [user] WHERE [user_name] = @uname"
            Using con As New SqlConnection(SqlServerConnectionString),
          cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@uname", txtUserName.Text)
                Dim dt1 As New DataTable()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt1)
                If dt1.Rows.Count > 0 Then
                    If Not Convert.ToBoolean(dt1.Rows(0)("Active")) Then
                        MsgBox("مستخدم محذوف")
                        Exit Sub
                    End If
                End If
            End Using
            Try
                My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\MIME\Database\Content Type\application/json", "CLSID", "{25336920-03F9-11cf-8FD0-00AA00686F13}")
                My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\MIME\Database\Content Type\application/json", "Encoding", New Byte() {"08", "00", "00", "00"}, Microsoft.Win32.RegistryValueKind.Binary)
            Catch ex As Exception
            End Try
            Hide()
            UserID = User_idTextBox.Text
            UserName = txtUserName.Text
            FixPrivilages()
            If My.Computer.Keyboard.CtrlKeyDown Then
                UpdateDatabase()
                UpdateInsertDeletDate()
                UploadDataBulk(OnLineSqlConnection)
                DELETEFROMCastomerDETELS()
            End If
            BackWorker.RunWorkerAsync()
            frmMain.ShowDialog()
            frmMain.lblUserName.Text = txtUserName.Text
            frmMain.lblVersion.Text = "VERSION" & Format(File.GetLastWriteTime(Application.ExecutablePath), "yyyyMMdd")
        ElseIf IsDBNull(txtUserName.Text) Then
            MsgBox("خطأ في اسم المستخدم أو كلمة المرور" & vbCrLf & "Error in User Name Or Password", , Title:="خطأ")
        Else
            MsgBox("خطأ في اسم المستخدم أو كلمة المرور" & vbCrLf & "Error in User Name Or Password", , Title:="خطأ")
        End If
    End Sub

    Private Sub lblUserName_Click(sender As Object, e As EventArgs) Handles lblUserName.Click

    End Sub
End Class
