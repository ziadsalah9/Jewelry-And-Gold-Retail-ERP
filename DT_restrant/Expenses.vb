Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Imports System.IO
Public Class Expenses
    Dim EditMode As Boolean = False
    Public CurrentInvoiceNo As String = "0"
    Public sqlcomReportPath, SqlCom, ComInvNo As String
    Public Sub EnableControls(ByVal Status As Boolean)
        btnItemSave.Enabled = Status
        pnlItemDetails.Enabled = Status
    End Sub
    Private Sub GetPayMethod()
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            ComPaymentMethod.DataSource = dt1
            ComPaymentMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            ComPaymentMethod.ValueMember = "ID"
        End If
    End Sub
    Public Sub ExpensesType()
        Dim dt1 As DataTable = GetRecordSet("SELECT * FROM [ExpensesType]")
        If dt1.Rows.Count > 0 Then
            cmbExpensesType.DataSource = dt1
            cmbExpensesType.DisplayMember = "ExpensesType"
        End If
    End Sub
    Private Sub CashVoucherNo()
        Dim dt1 As DataTable = GetRecordSet("SELECT *FROM SndToCustomer  WHERE (Activite = '1')")
        If dt1.Rows.Count > 0 Then
            CmbCashVoucherNo.DataSource = dt1
            CmbCashVoucherNo.DisplayMember = "SndNumber"
            CmbCashVoucherNo.ValueMember = "SndNumber"
        End If
    End Sub
    Public Sub GetLastInvNo()
        Try
            Dim DT As DataTable = GetRecordSet("SELECT ExpensesInvID +1 AS ExpensesInvID FROM Expenses WHERE ExpensesID=(SELECT max(ExpensesID) FROM Expenses)")
            If DT.Rows.Count > 0 Then
                labExpeNo.Text = Val(DT.Rows(0)(0).ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub Get_Casher_Data()
        Try
            Dim DT As DataTable = GetRecordSet("SELECT * FROM cacher")
            If DT.Rows.Count > 0 Then
                ComCasher.DataSource = DT
                ComCasher.DisplayMember = "cacher_name"
                ComCasher.ValueMember = "svil_id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub PrinetInv()
        FrmPupPrentInv.TxtInv.Text = labExpeNo.Text.Trim
        ReportPath = "SELECT [Report_Path9]  FROM [ReportPath]"
        SqlFillCom = "select ExpensesInvID from ReportExpensesAllData where Active='1'"
        SqlComGetInv = "select * from ReportExpensesAllData where ExpensesInvID ='"
        FrmPupPrentInv.InvShow()
        FrmPupPrentInv.ShowDialog()
    End Sub
    Public Sub PDF()
        Try
            Try
                FrmPupPrentInv.rptPupPrentInv.LocalReport.DisplayName = cmbExpensesType.Text
            Catch ex As Exception
                MsgBox("خطأ في موقع الحفظ" & vbCrLf & "Error in Save Location", MsgBoxStyle.Information, AppTitle)
                Exit Sub
            End Try
            'Try
            Dim Path As String = "C:\"
            If Strings.Right(Path, 1) <> "\" Then Path &= "\"
            FrmPupPrentInv.rptPupPrentInv.LocalReport.EnableExternalImages = True
            Dim byteViewer As Byte() = FrmPupPrentInv.rptPupPrentInv.LocalReport.Render("PDF")
            Dim saveFileDialog1 As New SaveFileDialog()
            With saveFileDialog1
                .Filter = "*PDF files (*.PDF)|*.PDF"
                .FileName = DiamondInvoice.CurrentCustomerName
                .FilterIndex = 2
                .RestoreDirectory = True
            End With
            If Directory.Exists(Path & "Expenses\المصروفات\" & cmbExpensesType.Text & "-" & labExpeNo.Text) = False Then Directory.CreateDirectory(Path & "Expenses\المصروفات\" & cmbExpensesType.Text & "-" & labExpeNo.Text)
            Dim newFile As New FileStream(Path & "Expenses\المصروفات\" & cmbExpensesType.Text & "-" & labExpeNo.Text & "\" & labExpeNo.Text & ".PDF", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
            If MsgBox("تم الحفظ. هل تريد عرض مجلد الفاتورة؟" & vbCrLf & "Save Done. Open Invoice Folder?", vbYesNo, AppTitle) = vbYes Then
                Process.Start(Path & "Expenses\المصروفات\" & cmbExpensesType.Text & "-" & labExpeNo.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Expenses_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Timer1.Start()
        Dispose()
    End Sub
    Private Sub btnItemSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItemSave.Click

        If cmbExpensesType.SelectedIndex = -1 Then
            MsgBox("اختر التصنيف" & vbCrLf & "Please Select Category", , "خطأ")
            cmbExpensesType.DroppedDown = True
            Exit Sub
        End If
        If txtExpensesCashValue.Text.Trim = "" AndAlso txtExpensesKNETValue.Text.Trim = "" Then
            MsgBox("اكتب المبلغ" & vbCrLf & "Please Enter Value", , "خطأ")
            txtExpensesCashValue.SelectAll()
            txtExpensesCashValue.Focus()
            Exit Sub
        End If
        If txtExpensesDescription.Text.Trim = "" Then
            txtExpensesDescription.Text = "-"
        End If
        If txtExpensesCashValue.Text.Trim = "" Then
            txtExpensesCashValue.Text = "0"
        End If
        If txtExpensesKNETValue.Text.Trim = "" Then
            txtExpensesKNETValue.Text = "0"
        End If
        If ComCasher.Items.Count = 1 Then
            ComCasher.SelectedIndex = 0
        Else
            If frmLogin.rbtnAr.Checked = True Then
                ComCasher.Text = "اختر اسم الكاشير"
            ElseIf frmLogin.rbtnEn.Checked = True Then
                ComCasher.Text = "Select Cashier"
            End If
        End If
        Dim dt1 As DataTable = GetRecordSet("SELECT ExpensesInvID +1 AS ExpensesInvID FROM Expenses WHERE ExpensesID=(SELECT max(ExpensesID) FROM Expenses)")
        If dt1.Rows.Count > 0 Then
            CurrentInvoiceNo = Val(dt1.Rows(0)(0).ToString)
        Else
            CurrentInvoiceNo = "1"
        End If
        GlCommand.CommandText = " INSERT INTO [Expenses]" &
           "([ExpensesType]" &
          " ,[ExpensesDate]" &
           ",[ExpensesUserID]" &
           ",[ExpensesCashValue]" &
           ",[ExpensesKNETValue]" &
           ",[ExpensesPhoto]" &
           ",[ExpensesDescription]" &
           ",[PayMethod]" &
           ",[Cacher]" &
           ",[Active]" &
           ",[CashVoucherNo]" &
           ",[ExpensesInvID]" &
           ",[ExpensesDateTime])" &
           "VALUES" &
           "(@ExpensesType" &
           ",@ExpensesDate" &
           ",@ExpensesUserID" &
           ",@ExpensesCashValue" &
           ",@ExpensesKNETValue" &
           ",@ExpensesPhoto" &
           ",@ExpensesDescription" &
           ",@PayMethod" &
           ",@Cacher" &
           ",@Active" &
           ",@CashVoucherNo" &
           ",@ExpensesInvID" &
           ",@ExpensesDateTime)"
        With GlCommand.Parameters
            .Clear()
            .AddWithValue("@ExpensesType", cmbExpensesType.Text.Trim())
            .AddWithValue("@ExpensesDate", DateToSave(dtExpensesDate.Value))
            .AddWithValue("@ExpensesUserID", frmLogin.User_idTextBox.Text.Trim)
            .AddWithValue("@ExpensesCashValue", If(IsDBNull(txtExpensesCashValue.Text.Trim), "0", Val(txtExpensesCashValue.Text.Trim)))
            .AddWithValue("@ExpensesKNETValue", If(IsDBNull(txtExpensesKNETValue.Text.Trim), "0", Val(txtExpensesKNETValue.Text.Trim)))
            .AddWithValue("@ExpensesPhoto", SqlDbType.Image).Value = ImageToByte(pbExpensesPhoto.Image)
            .AddWithValue("@ExpensesDescription", txtExpensesDescription.Text.Trim())
            .AddWithValue("@PayMethod", If(ComPaymentMethod.SelectedIndex = -1, 0, ComPaymentMethod.SelectedValue))
            .AddWithValue("@Cacher", ComCasher.SelectedValue)
            .AddWithValue("@Active", "1")
            .AddWithValue("@CashVoucherNo", CmbCashVoucherNo.Text.Trim)
            .AddWithValue("@ExpensesInvID", CurrentInvoiceNo)
            .AddWithValue("@ExpensesDateTime", Format(dtExpensesDate.Value, "dd/MM/yyyy hh:mm:ss tt"))
        End With
        GlCommand.ExecuteNonQuery()
        btnItemSave.Enabled = False
        btnItemNew.Enabled = True
        pnlItemDetails.Enabled = False
        If MsgBox("تم الحفظ اضغط نعم للطباعه او  الغاء الامر" & vbCrLf & "Saved, click Yes to print or cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "المصروفات" & vbCrLf & "Expenses.") = MsgBoxResult.Ok Then
            PrinetInv()
            MsgBox("تم الحفظ وطباعه السند")
        Else
            MsgBox("تم حفظ السند دون طباعته" & vbCrLf & "Delete Cancelled.", , AppTitle)
            Beep()
            Exit Sub
        End If
    End Sub
    Private Sub btnItemNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItemNew.Click
        ComPaymentMethod.SelectedIndex = 0
        ClearControls(pnlItemDetails)
        btnItemNew.Enabled = False
        btnItemSave.Enabled = True
        EditMode = False
        pnlItemDetails.Enabled = True
        GetLastInvNo()
    End Sub
    Private Sub btnPhoto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExpensesPhoto.Click
        Dim OFD As New OpenFileDialog
        pbExpensesPhoto.BackgroundImageLayout = ImageLayout.Stretch
        OFD.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                pbExpensesPhoto.Image = Image.FromFile(.FileName)
            Else
                Return
            End If
        End With
        pbExpensesPhoto.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
    Private Sub Accessories_AddItems_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub
    Private Sub btnItemName_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnItemName.Click
        ExpType.ShowDialog()
    End Sub
    Private Sub txtValue_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtExpensesCashValue.KeyPress, txtExpensesKNETValue.KeyPress
        ValidateTextbox(sender, 3, e)
    End Sub
    Private Sub pbItem_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles pbExpensesPhoto.DoubleClick
        If pbExpensesPhoto.Image Is Nothing Then Exit Sub
        If MsgBox("هل تريد حذف الصورة؟" & vbCrLf & "Delete Photo?", vbYesNo, "") = vbYes Then
            pbExpensesPhoto.Image = Nothing
        End If
    End Sub
    Private Sub btnCashVoucherShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashVoucherShow.Click
        FrmSnd.ShowDialog()
    End Sub
    Private Sub CmbCashVoucherNo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmbCashVoucherNo.MouseClick
        CashVoucherNo()
    End Sub
    Private Sub total()
        Try
            laltotal.Text = Math.Round((Val(txtExpensesCashValue.Text) + Val(txtExpensesKNETValue.Text)), 3)
        Catch ex As Exception
        End Try

    End Sub
    Private Sub Expenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        ExpensesType()
        Get_Casher_Data()
        GetPayMethod()
        ComPaymentMethod.SelectedIndex = 0
        CashVoucherNo()
        btnItemSave.Enabled = False
        pnlItemDetails.Enabled = False
        GetLastInvNo()
        frmMain.Timer1.Stop()
    End Sub

    Private Sub txtExpensesCashValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExpensesCashValue.TextChanged
        total()
    End Sub

    Private Sub txtExpensesKNETValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExpensesKNETValue.TextChanged
        total()
    End Sub
End Class
