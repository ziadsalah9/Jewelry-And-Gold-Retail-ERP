Imports System.Drawing.Printing
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class AccessoriesBuyPay
    Dim sum As Decimal
    Dim a As Decimal
    Private Sub AccessoriesBuyPay_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Saved Then AccessoriesBuy.Close()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Private Sub GetPayMethod()
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = dt1
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
    End Sub
    Private Sub AccessoriesBuyPay_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        GetPayMethod()
        ControlsAsColor(ColorSelect:=Me)
        Accessories_ITEMTableAdapter.Fill(DT_restrantDataSet.Accessories_ITEM)
        Accessories_Buy_PayVwTableAdapter.Fill(DT_restrantDataSet.Accessories_Buy_PayVw)
        Accessories_Buy_PayTableAdapter.Fill(DT_restrantDataSet.Accessories_Buy_Pay)
        language_start(Name)
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        rbCash.Checked = True
        btnPrint.Enabled = False
        txtKNET.Text = "0"
        txtCash.Text = "0"
        GetDataFromBuyFrom()
        ReportViewer1.LocalReport.ReportPath = SET_INVARCHR153TextBox.Text
    End Sub
    Private Sub GetDataFromBuyFrom()
        txtInvoiceNo.Text = AccessoriesBuy.txtInvoiceNoDB.Text
        Dim TotalPrice As Double
        For i As Integer = 0 To AccessoriesBuy.grid.RowCount - 1
            TotalPrice += AccessoriesBuy.grid.Rows(i).Cells("colAccessories_Price").Value
        Next
        txtPrice.Text = Format(TotalPrice, "0.000")

    End Sub
    Private Sub report_new()
        Try
            ReportViewer1.LocalReport.DisplayName = CivilIDForm.txtName.Text
        Catch ex As Exception
            MsgBox("خطأ في موقع الحفظ" & vbCrLf & "Error in Saving Location", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        ' الحفظ ولالرسال عبر الوتس اب
        Try
            ReportViewer1.LocalReport.EnableExternalImages = True
            Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "*PDF files (*.PDF)|*.PDF"
            saveFileDialog1.FileName = CivilIDForm.txtName.Text
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            Dim newFile As New FileStream(SET_INVARCHR148TextBox.Text & "\" & CivilIDForm.txtName.Text & ".PDF", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
        Catch ex As Exception
            MsgBox("PDF غير مثبت" & vbCrLf & "No PDF Reader Installed", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        Try
            Dim webAddress As String = "https://api.whatsapp.com/send?phone= " & "+965" & CivilIDForm.txtPhone.Text & ""
            Process.Start(webAddress)
        Catch ex As Exception
            MsgBox("خطأ انتر نت غير متوفر" & vbCrLf & "Check Internet Connection", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Val(txtCash.Text) < 0 OrElse Val(txtKNET.Text) < 0 Then
            MsgBox("لا يمكن إدخال أرقام سالبة" & vbCrLf & "You Can't Enter Negative Values", , "خطأ")
            Exit Sub
        End If

        If Val(txtCash.Text) + Val(txtKNET.Text) <> Val(txtPrice.Text) OrElse Val(txtCash.Text) < 0 OrElse Val(txtKNET.Text) < 0 Then
            MsgBox("إجمالي السعر لا يساوي مجموع الكاش والكي نت" & vbCrLf & "Total Price is NOT Equal to Cash And K-NET", , "خطأ")
            Exit Sub
        End If

        Try
            Accessories_Buy_PayBindingSource.AddNew()
            Accessories_InvoiceNoTextBox.Text = txtInvoiceNo.Text
            Accessories_TOTAL_PriceTextBox.Text = Val(txtPrice.Text)
            Accessories_CASHTextBox.Text = Val(txtCash.Text)
            Accessories_KNETTextBox.Text = Val(txtKNET.Text)
            Accessories_balanceTextBox.Text = txtRemaining.Text
            Accessories_staytesTextBox.Text = If(rbCash.Checked = True, "1", "0")
            Accessories_PaymentTypeTextBox.Text = If(rbCash.Checked = True, "نقدا", "آجل")
            Accessories_Arabic_taybTextBox.Text = kokotxt(Val(txtPrice.Text), CurrencyMainAr, CurrencySubAr, True)
            Accessories_CasherTextBox.Text = AccessoriesBuy.CacherIDTextBox.Text
            ValidateChildren()
            Accessories_Buy_PayBindingSource.EndEdit()
            Accessories_Buy_PayTableAdapter.Update(DT_restrantDataSet.Accessories_Buy_Pay)
            AddItemsToStock()

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'فلتر طباعة الفاتورة
            Accessories_Buy_PayVwTableAdapter.FillByInvoiceNo(DT_restrantDataSet.Accessories_Buy_PayVw, txtInvoiceNo.Text)
        Dim ReportParameter1 As New ReportParameter("ReportParameter1", cmbPayMethod.Text)
        ReportViewer1.LocalReport.SetParameters(ReportParameter1)
        GlCommand.CommandText = ("UPDATE [Accessories_Buy_Pay] SET [PayMethod] =N'" & cmbPayMethod.SelectedValue & "' WHERE  [Accessories_InvoiceNo]='" & txtInvoiceNo.Text & "'")
        GlCommand.ExecuteNonQuery()
        ReportViewer1.RefreshReport()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btnPrint.Enabled = True
            btnSave.Enabled = False
            txtCash.Enabled = False
            txtKNET.Enabled = False
            Saved = True
        Catch ex As Exception
        MsgBox("خطأ لم يتم إدخال بيانات الفاتورة بالكامل" & vbCrLf & "Invoice Data is Not Completed", , AppTitle)
        End Try

    End Sub
    Private Sub AddItemsToStock()
        For i As Integer = 0 To AccessoriesBuy.grid.Rows.Count - 1
            Accessories_ITEMBindingSource.AddNew()
            Accessories_NAMETextBox.Text = AccessoriesBuy.grid.Rows(i).Cells("colAccessoriesNAME").Value
            Accessories_BRANDTextBox.Text = AccessoriesBuy.grid.Rows(i).Cells("colAccessoriesBRAND").Value
            Accessories_DESCTextBox.Text = If(IsDBNull(AccessoriesBuy.grid.Rows(i).Cells("colAccessoriesDESC").Value), "", AccessoriesBuy.grid.Rows(i).Cells("colAccessoriesDESC").Value)
            Accessories_CATTextBox.Text = If(IsDBNull(AccessoriesBuy.grid.Rows(i).Cells("colAccessoriesCAT").Value), "", AccessoriesBuy.grid.Rows(i).Cells("colAccessoriesCAT").Value)
            Accessories_DEPTextBox.Text = If(IsDBNull(AccessoriesBuy.grid.Rows(i).Cells("colAccessoriesDEP").Value), "", AccessoriesBuy.grid.Rows(i).Cells("colAccessoriesDEP").Value)
            Accessories_model_noTextBox.Text = If(IsDBNull(AccessoriesBuy.grid.Rows(i).Cells("colAccessoriesModel").Value), "", AccessoriesBuy.grid.Rows(i).Cells("colAccessoriesModel").Value)
            Accessories_nomTextBox.Text = If(IsDBNull(AccessoriesBuy.grid.Rows(i).Cells("colAccessoriesNom").Value), "", AccessoriesBuy.grid.Rows(i).Cells("colAccessoriesNom").Value)
            Accessories_TIMEDateTimePicker.Value = Now
            Accessories_DATE_CREDateTimePicker.Value = Now
            Accessories_USER_CRETTextBox.Text = txtUserName.Text
            Accessories_CostTextBox.Text = AccessoriesBuy.grid.Rows(i).Cells("colAccessories_Price").Value
            Accessories_PriceTextBox.Text = AccessoriesBuy.grid.Rows(i).Cells("colAccessories_Price").Value
            Validate()
            Accessories_ITEMBindingSource.EndEdit()
            Accessories_ITEMTableAdapter.Update(DT_restrantDataSet.Accessories_ITEM)
            SaveDataToDB("Accessories_Buy", "BarCode", AccessoriesIDTextBox.Text.Trim, 3, "AccessoriesID = N' " & AccessoriesBuy.grid.Rows(i).Cells("colAccessoriesID").Value & "'")
        Next
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim printerSettings1 As New PrinterSettings
            printerSettings1.Copies = If(SET_INVARCHR139TextBox.Text = "", "1", SET_INVARCHR139TextBox.Text.Trim)
            ReportViewer1.PrintDialog(printerSettings1)
            Close()
        Catch ex As Exception
            MsgBox("انتظر ظهور الفاتورة علي الشاشة" & vbCrLf & "Wait for the Invoice to be Fully Dispalyed", , AppTitle)
        End Try
    End Sub

    Private Sub txtKnet_TextChanged(sender As Object, e As EventArgs) Handles txtKNET.TextChanged
        Try
            a = Val(txtKNET.Text) + Val(txtCash.Text) - Val(txtPrice.Text)
            txtRemaining.Text = Val(a)
        Catch ex As Exception
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Try
            a = Val(txtKNET.Text) + Val(txtCash.Text) - Val(txtPrice.Text)
            txtRemaining.Text = Val(a)
        Catch ex As Exception
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub
    Private Sub txtCash_Keyup(sender As Object, e As KeyEventArgs) Handles txtCash.KeyUp
        txtKNET.Text = Val(txtPrice.Text) - Val(txtCash.Text)
        NegativeColor()
    End Sub

    Private Sub txtKnet_KeyPress(sender As Object, e As KeyEventArgs) Handles txtKNET.KeyUp
        txtCash.Text = Val(txtPrice.Text) - Val(txtKNET.Text)
        NegativeColor()
    End Sub
    Private Sub NegativeColor()
        If Val(txtKNET.Text) < 0 Then
            txtKNET.ForeColor = Color.Red
        Else
            txtKNET.ForeColor = Color.Black
        End If
        If Val(txtCash.Text) < 0 Then
            txtCash.ForeColor = Color.Red
        Else
            txtCash.ForeColor = Color.Black
        End If
    End Sub

    Private Sub lnkPrice_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtPrice.LinkClicked
        txtKNET.Text = Val(txtPrice.Text)
        txtCash.Text = "0"
        NegativeColor()
    End Sub

    Private Sub btnWhatsApp_Click(sender As Object, e As EventArgs)
        report_new()
    End Sub

End Class