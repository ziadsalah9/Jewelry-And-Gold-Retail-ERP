Imports System.IO
Imports Microsoft.Reporting
Imports Microsoft.Reporting.WinForms

Public Class DiamondBuyPay
    Dim Path As String = Report_Path.TeBoxDmonBAY.Text.Trim
    Dim sum As Decimal
    Dim a As Decimal
    Dim d As Date


    Private Sub Bay_goled_monyBindingNavigatorSaveItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Validate()
        Bay_Diamond_monyBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DT_restrantDataSet)
    End Sub
    Public Sub report_new()
        Try
            ReportViewer1.LocalReport.DisplayName = CastomerNAmeLabel1.Text
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
            saveFileDialog1.FileName = CastomerNAmeLabel1.Text
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            Dim newFile As New FileStream(SET_INVARCHR148TextBox.Text & CastomerNAmeLabel1.Text & ".PDF", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
        Catch ex As Exception
            MsgBox("PDF غير مثبت" & vbCrLf & "No PDF Reader Installed", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        Try
            Dim webAddress As String = "https://api.whatsapp.com/send?phone= " & "+" & CastomerTETextBox.Text & ""
            Process.Start(webAddress)
        Catch ex As Exception
            MsgBox("خطأ انتر نت غير متوفر" & vbCrLf & "Check Internet Connection", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try


    End Sub

    Private Sub bay_goled_mony_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If Saved = False Then
            MsgBox("يرجى إكمال الدفع أولا ثم الحفظ" & vbCrLf & "Please Complete Payment First Then Save.", MsgBoxStyle.Exclamation, AppTitle)
            e.Cancel = True
            Exit Sub
        End If
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Private Sub bay_goled_mony_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        ReportDiamondBuyInvoiceTableAdapter.Fill(DT_restrantDataSet.ReportDiamondBuyInvoice)
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker1.Text = Date.Now
        If SET_INVARCHR144TextBox.Text <> "0" Then
            chkAutoClose.Checked = True
        End If
        rbCash.Checked = True
        btnPrint.Enabled = False
        txtKNET.Text = "0"
        txtCash.Text = "0"
        GetReportPath()
        GetPayMethod()
    End Sub
    Private Sub GetPayMethod()
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = dt1
            cmbPayMethod.DisplayMember = If(chkEngInvoice.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click

        d = Date.Now
        If rbCash.Checked = True Then
            If Val(txtCash.Text) < 0 OrElse Val(txtKNET.Text) < 0 Then
                MsgBox("لا يمكن أن يكون المدفوع بالسالب" & vbCrLf & "Paid amount can't be Negative!", , AppTitle)
                Exit Sub
            End If
        End If

        sum = Val(txtCash.Text) + Val(txtKNET.Text)
        If sum > Val(txtPrice.Text) Then
            MsgBox("المبلغ المدفوع أكثر من إجمالي الفاتورة!" & vbCrLf & "Paid amount is More Than Total Bill!", , AppTitle)
            Exit Sub
        ElseIf sum < Val(txtPrice.Text) Then
            MsgBox("لم يتم دفع المبلغ بالكامل" & vbCrLf & "Please Pay Total Bill First.", , AppTitle)
            Exit Sub
        End If
        Try
            DateTimePicker1.Text = Date.Now
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
            Bay_Diamond_monyBindingSource.AddNew()
            SaryalTextBox.Text = DiamondBuyPerson.Inv_idTextBox.Text
            Total_priceTextBox.Text = Val(txtPrice.Text)
            CachTextBox.Text = Val(txtCash.Text)
            KenetTextBox.Text = Val(txtKNET.Text)
            DateTextBox.Text = DateTimePicker1.Value
            ArabikTextBox.Text = kokotxt(Val(DiamondBuyPerson.txtTotalPrice.Text), CurrencyMainAr, CurrencySubAr, True)
            EnglishTextBox.Text = ConvertNumberToENG(Val(DiamondBuyPerson.txtTotalPrice.Text))
            ValidateChildren()
            Bay_Diamond_monyBindingSource.EndEdit()
            Bay_Diamond_monyTableAdapter.Update(DT_restrantDataSet.Bay_Diamond_mony)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'فلتر طباعة الفاتورة
            'ReportDiamondBuyInvoiceTableAdapter.Fill(DT_restrantDataSet.ReportDiamondBuyInvoice)

            'ReportDiamondBuyInvoiceTableAdapter.FillByGetDataBySarualID(DT_restrantDataSet.ReportDiamondBuyInvoice, DiamondBuyPerson.Inv_idTextBox.Text)


            'FillByGetDataBySarualID
            'ReportDiamondBuyInvoiceBindingSource.Filter = "Inv_Id = N'" & DiamondBuyPerson.Inv_idTextBox.Text & "'"
           
            

            GetReportPath()
            ReportViewer1.RefreshReport()
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            btnPrint.Enabled = True
            btnSave.Enabled = False
            txtCash.Enabled = False
            txtKNET.Enabled = False
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Saved = True
            Try
                GlCommand.CommandText = "UPDATE [Buy_Diamond] SET [Active]='1' WHERE [Active]IS NULL"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE [Bay_Diamond_mony] SET [Active]='1' WHERE [Active] IS NULL"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE [Bay_Diamond_mony] SET [Active]='1' WHERE [Active] IS NULL"
                GlCommand.ExecuteNonQuery()
            Catch ex As Exception

            End Try
            ReportDiamondBuyInvoiceTableAdapter.FillByGetDataBySarualID(DT_restrantDataSet.ReportDiamondBuyInvoice, DiamondBuyPerson.Inv_idTextBox.Text)
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("خطأ لم يتم إدخال بيانات الفاتورة بالكامل" & vbCrLf & "Invoice Data is Not Completed", , AppTitle)
        End Try

    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Try
            ReportViewer1.PrintDialog()
            If chkAutoClose.Checked = True Then
                DiamondBuyPerson.Close()
            End If

        Catch ex As Exception
            MsgBox("انتظر ظهور الفاتورة علي الشاشة" & vbCrLf & "Wait for the Invoice to be Fully Dispalyed", , AppTitle)
        End Try
    End Sub

    Private Sub txtKnet_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtKNET.TextChanged
        Try
            a = Val(txtKNET.Text) + Val(txtCash.Text) - Val(txtPrice.Text)
            txtRemaining.Text = Val(a)
        Catch ex As Exception
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCash.TextChanged
        Try
            a = Val(txtKNET.Text) + Val(txtCash.Text) - Val(txtPrice.Text)
            txtRemaining.Text = Val(a)
        Catch ex As Exception
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub
    Private Sub txtCash_Keyup(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtCash.KeyUp
        txtKNET.Text = Val(txtPrice.Text) - Val(txtCash.Text)
        NegativeColor()
    End Sub

    Private Sub txtKnet_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtKNET.KeyUp
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

    Private Sub lnkPrice_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles txtPrice.LinkClicked
        txtKNET.Text = Val(txtPrice.Text)
        txtCash.Text = "0"
    End Sub

    Private Sub btnWhatsApp_Click(ByVal sender As Object, ByVal e As EventArgs)
        report_new()
    End Sub

    Private Sub chkEngInvoice_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkEngInvoice.CheckedChanged
        GetReportPath()
        If Saved Then ReportViewer1.RefreshReport()
    End Sub
    Private Sub GetReportPath()
        Dim DiamondArPath As String = SET_INVARCHR157TextBox.Text.Trim
        If chkEngInvoice.Checked = True Then
            'Diamond-Eng
            ReportViewer1.LocalReport.ReportPath = Replace(DiamondArPath, ".rdlc", "-EN.rdlc")
        Else
            'Diamond-Ar
            ReportViewer1.LocalReport.ReportPath = DiamondArPath
        End If
    End Sub


End Class