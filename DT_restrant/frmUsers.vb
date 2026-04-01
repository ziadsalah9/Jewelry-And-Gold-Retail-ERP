Public Class frmUsers
    Dim CheckedState As New CheckState
    Private Sub frmUsers_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
        NewData()
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        btnNew.Enabled = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        txtUser_name.Enabled = True
        txtPassword.Enabled = True
        gbPrivilage.Enabled = True
        ClearCheckBox()
        UpdateUserName()
        txtUser_name.Focus()
        txtUser_name.SelectAll()
    End Sub
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        cmbUserName.Left = txtUser_name.Left
        cmbUserName.Top = txtUser_name.Top
        cmbUserName.Width = txtUser_name.Width
        cmbUserName.Visible = True

        btnNew.Enabled = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = True
        txtUser_name.Enabled = False
        txtPassword.Enabled = True
        gbPrivilage.Enabled = True
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtUser_name.Text.Trim = "" Then
            MsgBox("اكتب اسمًا للمستخدم" & vbCrLf & "Write a User Name", vbExclamation, Apptitle)
            txtUser_name.SelectAll()
            txtUser_name.Focus()
            Exit Sub
        End If
        If txtPassword.Text.Trim = "" Then
            MsgBox("اكتب كلمة مرور" & vbCrLf & "Write a Password", vbExclamation, Apptitle)
            txtPassword.SelectAll()
            txtPassword.Focus()
            Exit Sub
        End If
        Dim checkedItem As Boolean = False
        For Each chk As Control In gbPrivilage.Controls
            If TypeOf chk Is CheckBox Then
                If CType(chk, CheckBox).Checked = True Then checkedItem = True
            End If
        Next
        If checkedItem = False Then
            MsgBox("اختر الصلاحيات" & vbCrLf & "Select Privilages", vbExclamation, Apptitle)
            Exit Sub
        End If

        Try
            Save()
            NewData()
        Catch ex As Exception
        MsgBox("لم يتم الحفظ" & vbCrLf & "Saving Error", vbExclamation, AppTitle)
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Delete()
    End Sub
    Private Sub btnAllPrivilage_Click(sender As Object, e As EventArgs) Handles btnAllPrivilage.Click
        CheckedState = Not CheckedState
        For Each chk As Control In gbPrivilage.Controls
            If TypeOf chk Is CheckBox Then CType(chk, CheckBox).Checked = CheckedState
        Next
    End Sub
    Private Sub frmUsers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CheckPrivilage(UserID)
        frmMain.Timer1.Start()
        Dispose()
    End Sub
    Public Sub Save()
        If cmbUserName.Visible = False Then
            Dim dt1 As DataTable = GetRecordSet("SELECT [user_name] FROM [user] WHERE [user_name] = N'" & txtUser_name.Text.Trim & "'")
            If dt1.Rows.Count > 0 Then
                MsgBox("اسم المستخدم مكرر" & vbCrLf & "User Name is already used", vbExclamation, Apptitle)
                Exit Sub
            Else
                'chkModifyInvoce
                GlCommand.CommandText = "INSERT INTO [user]" &
                                        "([user_name]  " &
                                        ",[password]   " &
                                        ",[DateCreated]   " &
                                        ",[chkSell]  " &
                                        ",[chkBarCode]  " &
                                        ",[chkModify]  " &
                                        ",[chkGramPrice]  " &
                                        ",[chkSalary] " &
                                        ",[chkWholeSaleBuy] " &
                                        ",[chkUsers]  " &
                                        ",[chkCashier]  " &
                                        ",[chkWholesale]  " &
                                        ",[chkReports]  " &
                                        ",[chkExpenses]  " &
                                        ",[chkStock]  " &
                                        ",[chkItem]  " &
                                        ",[chkLimitStock]  " &
                                        ",[Active]  " &
                                        ",[chkInvPayInstallment] " &
                                        ",[chkModifyInvoce] " &
                                        ",[chkDelItem] " &
                                        ",[chkItemSelectInvo]) " &
                                        "VALUES " &
                                        "(@user_name " &
                                        ",@password " &
                                        ",@DateCreated " &
                                        ",@chkSell " &
                                        ",@chkBarCode " &
                                        ",@chkModify " &
                                        ",@chkGramPrice " &
                                        ",@chkSalary " &
                                        ",@chkWholeSaleBuy " &
                                        ",@chkUsers " &
                                        ",@chkCashier " &
                                        ",@chkWholesale " &
                                        ",@chkReports " &
                                        ",@chkExpenses " &
                                        ",@chkStock " &
                                        ",@chkItem " &
                                        ",@chkLimitStock " &
                                        ",@Active " &
                                        ",@chkInvPayInstallment " &
                                        ",@chkModifyInvoce " &
                                        ",@chkDelItem " &
                                        ",@chkItemSelectInvo)"

                With GlCommand.Parameters
                    .Clear()
                    .AddWithValue("@user_name", txtUser_name.Text.Trim)
                    .AddWithValue("@password", txtPassword.Text.Trim)
                    .AddWithValue("@DateCreated", Date.Now)
                    .AddWithValue("@chkSell", chkSell.Checked)
                    .AddWithValue("@chkBarCode", chkBarCode.Checked)
                    .AddWithValue("@chkModify", chkModify.Checked)
                    .AddWithValue("@chkGramPrice", chkGramPrice.Checked)
                    .AddWithValue("@chkSalary", chkSalary.Checked)
                    .AddWithValue("@chkWholeSaleBuy", chkWholeSaleBuy.Checked)
                    .AddWithValue("@chkUsers", chkUsers.Checked)
                    .AddWithValue("@chkCashier", chkCashier.Checked)
                    .AddWithValue("@chkWholesale", chkWholesale.Checked)
                    .AddWithValue("@chkReports", chkReports.Checked)
                    .AddWithValue("@chkExpenses", chkExpenses.Checked)
                    .AddWithValue("@chkStock", chkStock.Checked)
                    .AddWithValue("@chkItem", chkItem.Checked)
                    .AddWithValue("@chkLimitStock", chkLimitStock.Checked)
                    .AddWithValue("@Active", True)
                    .AddWithValue("@chkModifyInvoce", chkModifyInvoce.Checked)
                    .AddWithValue("@chkInvPayInstallment", chkInvPayInstallment.Checked)
                    .AddWithValue("@chkDelItem", chkDelItem.Checked)
                    .AddWithValue("@chkItemSelectInvo", chkItemSelectInvo.Checked)
                End With
                GlCommand.ExecuteNonQuery()
                MsgBox("تمت الإضافة بنجاح" & vbCrLf & "Adding Completed Successfully", , AppTitle)
                CheckUserPermissions(UserID)
            End If
        Else
            GlCommand.CommandText = "UPDATE [user] SET " &
                                    "[user_name] = @user_name , " &
                                    "[password] =  @password , " &
                                    "[DateCreated] =  @DateCreated , " &
                                    "[chkSell] = @chkSell , " &
                                    "[chkBarCode] = @chkBarCode , " &
                                    "[chkModify] = @chkModify , " &
                                    "[chkGramPrice] = @chkGramPrice , " &
                                    "[chkSalary] = @chkSalary , " &
                                    "[chkWholeSaleBuy] = @chkWholeSaleBuy , " &
                                    "[chkUsers] = @chkUsers , " &
                                    "[chkCashier] = @chkCashier , " &
                                    "[chkWholesale] = @chkWholesale , " &
                                    "[chkReports] = @chkReports , " &
                                    "[chkExpenses] = @chkExpenses , " &
                                    "[chkStock] = @chkStock , " &
                                    "[chkItem] = @chkItem , " &
                                    "[chkLimitStock] = @chkLimitStock , " &
                                    "[Active] = @Active , " &
                                    "[chkInvPayInstallment] = @chkInvPayInstallment , " &
                                    "[chkModifyInvoce] = @chkModifyInvoce , " &
                                    "[chkDelItem] = @chkDelItem , " &
                                    "[chkItemSelectInvo] = @chkItemSelectInvo  " &
                                    " WHERE [user_name] = N'" & txtUser_name.Text.Trim & "'"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@user_name", txtUser_name.Text.Trim)
                .AddWithValue("@password", txtPassword.Text.Trim)
                .AddWithValue("@DateCreated", Date.Now)
                .AddWithValue("@chkSell", chkSell.Checked)
                .AddWithValue("@chkBarCode", chkBarCode.Checked)
                .AddWithValue("@chkModify", chkModify.Checked)
                .AddWithValue("@chkGramPrice", chkGramPrice.Checked)
                .AddWithValue("@chkSalary", chkSalary.Checked)
                .AddWithValue("@chkWholeSaleBuy", chkWholeSaleBuy.Checked)
                .AddWithValue("@chkUsers", chkUsers.Checked)
                .AddWithValue("@chkCashier", chkCashier.Checked)
                .AddWithValue("@chkWholesale", chkWholesale.Checked)
                .AddWithValue("@chkReports", chkReports.Checked)
                .AddWithValue("@chkExpenses", chkExpenses.Checked)
                .AddWithValue("@chkStock", chkStock.Checked)
                .AddWithValue("@chkItem", chkItem.Checked)
                .AddWithValue("@chkLimitStock", chkLimitStock.Checked)
                .AddWithValue("@Active", True)
                .AddWithValue("@chkInvPayInstallment", chkInvPayInstallment.Checked)
                .AddWithValue("@chkModifyInvoce", chkModifyInvoce.Checked)
                .AddWithValue("@chkDelItem", chkDelItem.Checked)
                .AddWithValue("@chkItemSelectInvo", chkItemSelectInvo.Checked)
            End With
            GlCommand.ExecuteNonQuery()
            MsgBox("تم التعديل بنجاح" & vbCrLf & "Modifying Completed Successfully", , AppTitle)
            CheckUserPermissions(UserID)
        End If

    End Sub
    Public Sub Delete()
        If cmbUserName.SelectedIndex = -1 Then
            Message("اختر المستخدم المطلوب حذفه أولا" & vbCrLf & "Select a User first")
            Exit Sub
        End If

        If cmbUserName.Items.Count = 1 Then
            MsgBox("لا يمكن حذف المستخدم الأخير..أضف مستخدم آخر أولا" & vbCrLf & "Can't Delete Last User.. Please Add Another User First.", , Apptitle)
            Exit Sub
        End If

        If MsgBox("هل أنت متأكد من الحذف؟" & vbCrLf & "Are You Sure You Want To Delete this user?", vbYesNo) = vbYes Then
            GlCommand.CommandText = "UPDATE [User] SET [Active] = '0' WHERE [User_Name] = N'" & txtUser_name.Text.Trim & "'"
            GlCommand.ExecuteNonQuery()
            NewData()
        End If

    End Sub

    Private Sub NewData()
        UpdateUserName()
        cmbUserName.Visible = False
        txtUser_name.Text = ""
        txtPassword.Text = ""
        btnNew.Enabled = True
        btnModify.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = False
        txtUser_name.Enabled = False
        txtPassword.Enabled = False
        gbPrivilage.Enabled = False
        ClearCheckBox()
    End Sub
    Private Sub UpdateUserName()
        If My.Computer.Keyboard.CtrlKeyDown Then
            StrSQL = "SELECT [User_Name] FROM [User]"
        Else
            StrSQL = "SELECT [User_Name] FROM [User] WHERE [Active] = '1'"
        End If
        Dim dt1 As DataTable = GetRecordSet(StrSQL)
        cmbUserName.Items.Clear()
        For i As Integer = 0 To dt1.Rows.Count - 1
            cmbUserName.Items.Add(dt1.Rows(i)(0))
        Next
    End Sub
    
    Private Sub ClearCheckBox()
        For Each chk As Control In gbPrivilage.Controls
            If TypeOf chk Is CheckBox Then CType(chk, CheckBox).Checked = False
        Next
    End Sub
    Private Sub cmbUserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUserName.SelectedIndexChanged
        txtUser_name.Text = cmbUserName.Text
        Dim dt1 As DataTable = GetRecordSet("select * FROM  [user] WHERE [User_name] = N'" & txtUser_name.Text.Trim & "'")
        If dt1.Rows.Count > 0 Then
            chkSell.Checked = If(IsDBNull(dt1.Rows(0)("chkSell")), False, dt1.Rows(0)("chkSell"))
            chkBarCode.Checked = If(IsDBNull(dt1.Rows(0)("chkBarCode")), False, dt1.Rows(0)("chkBarCode"))
            chkModify.Checked = If(IsDBNull(dt1.Rows(0)("chkModify")), False, dt1.Rows(0)("chkModify"))
            chkGramPrice.Checked = If(IsDBNull(dt1.Rows(0)("chkGramPrice")), False, dt1.Rows(0)("chkGramPrice"))
            chkSalary.Checked = If(IsDBNull(dt1.Rows(0)("chkSalary")), False, dt1.Rows(0)("chkSalary"))
            chkWholeSaleBuy.Checked = If(IsDBNull(dt1.Rows(0)("chkWholeSaleBuy")), False, dt1.Rows(0)("chkWholeSaleBuy"))
            chkUsers.Checked = If(IsDBNull(dt1.Rows(0)("chkUsers")), False, dt1.Rows(0)("chkUsers"))
            chkCashier.Checked = If(IsDBNull(dt1.Rows(0)("chkCashier")), False, dt1.Rows(0)("chkCashier"))
            chkWholesale.Checked = If(IsDBNull(dt1.Rows(0)("chkWholesale")), False, dt1.Rows(0)("chkWholesale"))
            chkReports.Checked = If(IsDBNull(dt1.Rows(0)("chkReports")), False, dt1.Rows(0)("chkReports"))
            chkExpenses.Checked = If(IsDBNull(dt1.Rows(0)("chkExpenses")), False, dt1.Rows(0)("chkExpenses"))
            chkStock.Checked = If(IsDBNull(dt1.Rows(0)("chkStock")), False, dt1.Rows(0)("chkStock"))
            chkItem.Checked = If(IsDBNull(dt1.Rows(0)("chkItem")), False, dt1.Rows(0)("chkItem"))
            chkLimitStock.Checked = If(IsDBNull(dt1.Rows(0)("chkLimitStock")), False, dt1.Rows(0)("chkLimitStock"))
            chkModifyInvoce.Checked = If(IsDBNull(dt1.Rows(0)("chkModifyInvoce")), False, dt1.Rows(0)("chkModifyInvoce"))
            chkInvPayInstallment.Checked = If(IsDBNull(dt1.Rows(0)("chkInvPayInstallment")), "", dt1.Rows(0)("chkInvPayInstallment").ToString)
            chkModifyInvoce.Checked = If(IsDBNull(dt1.Rows(0)("chkModifyInvoce")), "", dt1.Rows(0)("chkModifyInvoce").ToString)
            chkDelItem.Checked = If(IsDBNull(dt1.Rows(0)("chkDelItem")), "", dt1.Rows(0)("chkDelItem").ToString)
            chkItemSelectInvo.Checked = If(IsDBNull(dt1.Rows(0)("chkItemSelectInvo")), "", dt1.Rows(0)("chkItemSelectInvo").ToString)
            txtPassword.Text = If(IsDBNull(dt1.Rows(0)("password")), "", dt1.Rows(0)("password").ToString)
        Else
            ClearCheckBox()
        End If
    End Sub


    Private Sub txtUser_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser_name.TextChanged

    End Sub

    Private Sub btnUnPrivilage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClearCheckBox()
    End Sub
End Class