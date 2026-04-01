
Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms
Imports System.IO


Public Class Accessories_InvoicePay
    Private Sub GetSettings()
        Dim dt1 As DataTable = GetRecordSet("select * from Settings")
        If dt1.Rows.Count > 0 Then
            RptPath = dt1.Rows(0)("SET_INVARCHR150").ToString
            PrintRepeat = dt1.Rows(0)("SET_INVARCHR138").ToString
        End If
    End Sub
    Dim RptPath As String
    Dim InvID As String
    Dim Check_rbCash As Integer
    Dim Check_rbPostPone As Integer
    Dim Check_rbCash_ar As String
    Dim Check_rbPostPone_ar As String
    Dim a As Decimal
    Public Sub cked()

        If rbCash.Checked = True Then
            Check_rbCash = 1
            rbCredit.Checked = False
        ElseIf rbCash.Checked = False Then
            rbCredit.Checked = True
            Check_rbPostPone_ar = "أجل"
            Check_rbCash = 0
        End If
    End Sub
    Public Sub report_new()
        Try
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
            saveFileDialog1.FileName = CivilIDForm.txtName.Text.Trim
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            Dim newFile As New FileStream(txtInvoiceNo.Text & CivilIDForm.txtName.Text.Trim & ".PDF", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
        Catch ex As Exception
            MsgBox("PDF غير مثبت" & vbCrLf & "No PDF Reader Installed", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        Try
            Dim webAddress As String = "https://api.whatsapp.com/send?phone= " & "+" & CivilIDForm.txtName.Text.Trim & ""
            'Process.Start(webAddress)
        Catch ex As Exception
            MsgBox("خطأ انتر نت غير متوفر" & vbCrLf & "Check Internet Connection", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try


    End Sub

    Private Sub Accessories_Bay_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If Saved = True Then Accessories_Invoice.Close()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Private Sub Accessories_Bay_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        GetSettings()
        GetReportPath()
        GetPayMethod()
        btnSave.Enabled = True
        rbCash.Checked = True
        btnPrint.Enabled = False
        txtKNET.Text = 0
        txtCash.Text = 0
        cked()
        cmbPayMethod.SelectedIndex = 0
    End Sub
    Private Sub GetPayMethod()
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = dt1
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If Val(txtCash.Text) < 0 OrElse Val(txtKNET.Text) < 0 Then
            MsgBox("لا يمكن أن يكون المدفوع بالسالب" & vbCrLf & "Paid Amount Can't be Negative!", , AppTitle)
            Exit Sub
        End If
        If rbCash.Checked = True Then
            If txtRemaining.Text <> 0 Then
                MsgBox("خطأ في إدخال مبلغ الفاتورة" & vbCrLf & "Error entering the invoice amount", MsgBoxStyle.Information, AppTitle)
                Exit Sub
            End If
        Else
            If txtRemaining.Text > 0 Then
                MsgBox("المبلغ المدخل أكبر من المطلوب" & vbCrLf & "Entered Amount Exceeds Required.", MsgBoxStyle.Information, AppTitle)
                Exit Sub
            End If
        End If

        If txtRemaining.Text = 0 Then

            Dim DtInvID As DataTable = GetRecordSet("SELECT Accessories_BAY_SARYAL +1 AS InvIDAuto FROM Accessories_BAY WHERE Accessories_BAY_ID=(SELECT max(Accessories_BAY_ID)FROM Accessories_BAY)")
            If DtInvID.Rows.Count > 0 Then
                InvID = Val(DtInvID.Rows(0)(0).ToString)
            Else
                InvID = "1"
            End If
            txtInvoiceNo.Text = InvID
            GlCommand.CommandText = "INSERT INTO [Accessories_BAY]" & vbCrLf &
                                              "([Accessories_BAY_SARYAL]" & vbCrLf &
                                              ",[Accessories_TOTAL_mony]" & vbCrLf &
                                              ",[Accessories_KENT]" & vbCrLf &
                                              ",[Accessories_CACH]" & vbCrLf &
                                              ",[Accessories_arbic_tayb]" & vbCrLf &
                                              ",[Accessories_balance]" & vbCrLf &
                                              ",[Accessories_staytes]" & vbCrLf &
                                              ",[Accessories_Casher]" & vbCrLf &
                                              ",[Accessories_PaymentType]" & vbCrLf &
                                              ",[Accessories_Active]" & vbCrLf &
                                              ",[Accessories_Notes]" & vbCrLf &
                                              ",[Accessories_PayMethod])" & vbCrLf &
                                              " VALUES" & vbCrLf &
                                              "(@Accessories_BAY_SARYAL" & vbCrLf &
                                              ",@Accessories_TOTAL_mony" & vbCrLf &
                                              ",@Accessories_KENT" & vbCrLf &
                                              ",@Accessories_CACH" & vbCrLf &
                                              ",@Accessories_arbic_tayb" & vbCrLf &
                                              ",@Accessories_balance" & vbCrLf &
                                              ",@Accessories_staytes" & vbCrLf &
                                              ",@Accessories_Casher" & vbCrLf &
                                              ",@Accessories_PaymentType" & vbCrLf &
                                              ",@Accessories_Active" & vbCrLf &
                                              ",@Accessories_Notes" & vbCrLf &
                                              ",@Accessories_PayMethod)"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@Accessories_BAY_SARYAL", InvoiceStringNo(Val(InvID)))
                .AddWithValue("@Accessories_TOTAL_mony", Val(txtPrice.Text.Trim))
                .AddWithValue("@Accessories_KENT", If(IsDBNull(txtKNET.Text.Trim), "0", Val(txtKNET.Text.Trim)))
                .AddWithValue("@Accessories_CACH", If(IsDBNull(txtCash.Text.Trim), "0", Val(txtCash.Text.Trim)))
                .AddWithValue("@Accessories_arbic_tayb", kokotxt(Val(txtPrice.Text), CurrencyMainAr, CurrencySubAr, True))
                .AddWithValue("@Accessories_balance", txtRemaining.Text.Trim)
                .AddWithValue("@Accessories_staytes", "1")
                .AddWithValue("@Accessories_Casher", Accessories_Invoice.cmbCashier.SelectedValue)
                .AddWithValue("@Accessories_PaymentType", "نقدا")
                .AddWithValue("@Accessories_Active", "1")
                .AddWithValue("@Accessories_Notes", "0")
                .AddWithValue("@Accessories_PayMethod", cmbPayMethod.SelectedValue)
            End With
            GlCommand.ExecuteNonQuery()
            For i As Integer = 0 To Accessories_Invoice.grid.Rows.Count - 1
                GlCommand.CommandText = "INSERT INTO [Accessories_INV]" & vbCrLf &
                                                  "([Accessories_INV_ITEM_ID]" & vbCrLf &
                                                 ",[Accessories_INV_QUNT]" & vbCrLf &
                                                 ",[Accessories_INV_un_price]" & vbCrLf &
                                                 ",[Accessories_INV_total_price]" & vbCrLf &
                                                 ",[Accessories_INV_CASTOMER_ID]" & vbCrLf &
                                                 ",[Accessories_INV_DATE]" & vbCrLf &
                                                 ",[Accessories_INV_TIME]" & vbCrLf &
                                                 ",[Accessories_INV_USER]" & vbCrLf &
                                                 ",[Accessories_INV_NO_ID]" & vbCrLf &
                                                 ",[Accessories_Active]" & vbCrLf &
                                                 ",[AccessoriesInvoceDESC]" & vbCrLf &
                                                 ",[AccessoriesBrand_ID]" & vbCrLf &
                                                 ",[AccessoriesGUARRANTYYEAR]" & vbCrLf &
                                                 ",[AccessoriesType_ID]" & vbCrLf &
                                                 ",[ItemName]" & vbCrLf &
                                                 ",[Code]" & vbCrLf &
                                                 ",[Supplier]" & vbCrLf &
                                                 ",[Department]" & vbCrLf &
                                                 ",[Category]" & vbCrLf &
                                                 ",[Attachment]" & vbCrLf &
                                                 ",[Cost]" & vbCrLf &
                                                 ",[Cashier]" & vbCrLf &
                                                 ",[IMG]" & vbCrLf &
                                                 ",[Note]" & vbCrLf &
                                                 ",[ItemNo]" & vbCrLf &
                                                 ",[ModelNo])" & vbCrLf &
                                                 "VALUES" & vbCrLf &
                                                 "(@Accessories_INV_ITEM_ID" & vbCrLf &
                                                 ",@Accessories_INV_QUNT" & vbCrLf &
                                                 ",@Accessories_INV_un_price" & vbCrLf &
                                                 ",@Accessories_INV_total_price" & vbCrLf &
                                                 ",@Accessories_INV_CASTOMER_ID" & vbCrLf &
                                                 ",@Accessories_INV_DATE" & vbCrLf &
                                                 ",@Accessories_INV_TIME" & vbCrLf &
                                                 ",@Accessories_INV_USER" & vbCrLf &
                                                 ",@Accessories_INV_NO_ID" & vbCrLf &
                                                 ",@Accessories_Active" & vbCrLf &
                                                 ",@AccessoriesInvoceDESC" & vbCrLf &
                                                 ",@AccessoriesBrand_ID" & vbCrLf &
                                                 ",@AccessoriesGUARRANTYYEAR" & vbCrLf &
                                                 ",@AccessoriesType_ID" & vbCrLf &
                                                 ",@ItemName" & vbCrLf &
                                                 ",@Code" & vbCrLf &
                                                 ",@Supplier" & vbCrLf &
                                                 ",@Department" & vbCrLf &
                                                 ",@Category" & vbCrLf &
                                                 ",@Attachment" & vbCrLf &
                                                 ",@Cost" & vbCrLf &
                                                 ",@Cashier" & vbCrLf &
                                                 ",@IMG" & vbCrLf &
                                                 ",@Note" & vbCrLf &
                                                 ",@ItemNo" & vbCrLf &
                                                 ",@ModelNo)"
                With GlCommand.Parameters
                    .Clear()
                    .AddWithValue("@Accessories_INV_ITEM_ID", Accessories_Invoice.grid.Rows(i).Cells("colBarcod").Value)
                    .AddWithValue("@Accessories_INV_QUNT", Accessories_Invoice.grid.Rows(i).Cells("colQty").Value)
                    .AddWithValue("@Accessories_INV_un_price", Accessories_Invoice.grid.Rows(i).Cells("colPrice").Value)
                    .AddWithValue("@Accessories_INV_total_price", "0")
                    .AddWithValue("@Accessories_INV_CASTOMER_ID", Accessories_Invoice.grid.Rows(i).Cells("colCivilID").Value)
                    .AddWithValue("@Accessories_INV_DATE", Accessories_Invoice.grid.Rows(i).Cells("colDate").Value)
                    .AddWithValue("@Accessories_INV_TIME", Accessories_Invoice.grid.Rows(i).Cells("colDateTime").Value)
                    .AddWithValue("@Accessories_INV_USER", Accessories_Invoice.grid.Rows(i).Cells("colUser").Value)
                    .AddWithValue("@Accessories_INV_NO_ID", InvoiceStringNo(Val(InvID)))
                    .AddWithValue("@Accessories_Active", "1")
                    .AddWithValue("@AccessoriesInvoceDESC", Accessories_Invoice.grid.Rows(i).Cells("colDescription").Value)
                    .AddWithValue("@AccessoriesBrand_ID", Accessories_Invoice.grid.Rows(i).Cells("colBrand").Value)
                    .AddWithValue("@AccessoriesGUARRANTYYEAR", Accessories_Invoice.grid.Rows(i).Cells("colYear").Value)
                    .AddWithValue("@AccessoriesType_ID", Accessories_Invoice.grid.Rows(i).Cells("colCategory").Value)
                    .AddWithValue("@ItemName", Accessories_Invoice.grid.Rows(i).Cells("colItemName").Value)
                    .AddWithValue("@Code", Accessories_Invoice.grid.Rows(i).Cells("colItemCode").Value)
                    .AddWithValue("@Supplier", Accessories_Invoice.grid.Rows(i).Cells("colSupplier").Value)
                    .AddWithValue("@Department", Accessories_Invoice.grid.Rows(i).Cells("colDepartment").Value)
                    .AddWithValue("@Category", Accessories_Invoice.grid.Rows(i).Cells("colCategory").Value)
                    .AddWithValue("@Attachment", Accessories_Invoice.grid.Rows(i).Cells("colAttachment").Value)
                    .AddWithValue("@Cost", Accessories_Invoice.grid.Rows(i).Cells("colCost").Value)
                    .AddWithValue("@Cashier", Accessories_Invoice.grid.Rows(i).Cells("colCashier").Value)
                    .AddWithValue("@IMG", Accessories_Invoice.grid.Rows(i).Cells("colPic").Value)
                    .AddWithValue("@Note", "")
                    .AddWithValue("@ItemNo", Accessories_Invoice.grid.Rows(i).Cells("colItemNo").Value)
                    .AddWithValue("@ModelNo", Accessories_Invoice.grid.Rows(i).Cells("colModelNo").Value)
                End With
                GlCommand.ExecuteNonQuery()
            Next
            btnSave.Enabled = False
            btnPrint.Enabled = True
            Dim DT As DataTable = GetRecordSet("select * from ViwAccReport WHERE (Accessories_INV_NO_ID = N'" & txtInvoiceNo.Text.Trim & "')")
            ReportViewer1.LocalReport.ReportPath = RptPath
            If DT.Rows.Count > 0 Then
                Dim ReportDataSource = New ReportDataSource("DataSet1", DT)
                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
                ReportViewer1.RefreshReport()
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Else
            End If
            ReportViewer1.LocalReport.ReportPath = RptPath
            ReportViewer1.RefreshReport()
            Dim staytesParameter As New ReportParameter("staytesParameter", "نقدا")
            ReportViewer1.LocalReport.SetParameters(staytesParameter)
            ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Else
            rbCredit.Checked = True
            btnSave.Enabled = False
            btnPrint.Enabled = True
            ReportViewer1.LocalReport.ReportPath = RptPath
            ReportViewer1.RefreshReport()
            Dim staytesParameter As New ReportParameter("staytesParameter", "اجل")
            ReportViewer1.LocalReport.SetParameters(staytesParameter)
            ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        End If
        Saved = True
    End Sub

    Private Sub txtKnet_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtKNET.TextChanged
        Try
            a = txtKNET.Text + Val(txtCash.Text) - Val(txtPrice.Text)
            txtRemaining.Text = Val(a)
            btnSave.Enabled = True
        Catch ex As Exception
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub
    Private Sub chkEngInvoice_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkEngInvoice.CheckedChanged
        GetReportPath()
        If Saved Then ReportViewer1.RefreshReport()
    End Sub
    Private Sub GetReportPath()

        Dim AccessoriesArPath As String = RptPath
        If chkEngInvoice.Checked = True Then
            ReportViewer1.LocalReport.ReportPath = Replace(AccessoriesArPath, ".rdlc", "-EN.rdlc")
        Else
            ReportViewer1.LocalReport.ReportPath = AccessoriesArPath
        End If

    End Sub
    Private Sub txtCash_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCash.TextChanged
        Try
            a = txtKNET.Text + Val(txtCash.Text) - Val(txtPrice.Text)
            txtRemaining.Text = Val(a)
            btnSave.Enabled = True
        Catch ex As Exception
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Dim printerSettings1 As New PrinterSettings
        printerSettings1.Copies = If(PrintRepeat = "", "1", PrintRepeat)
        ReportViewer1.PrintDialog(printerSettings1)
        Saved = True
        If chkAutoClose.Checked = True Then
            Close()
        End If
        ReportViewer1.PrinterSettings.Copies = "2"
    End Sub

    Private Sub rbCash_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbCash.CheckedChanged
        cked()
    End Sub

    Private Sub rbPostPone_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbCredit.CheckedChanged
        cked()
    End Sub

    Private Sub lnkPrice_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles txtPrice.LinkClicked
        txtCash.Text = txtPrice.Text
    End Sub

    Private Sub btnWhatsApp_Click(ByVal sender As Object, ByVal e As EventArgs)
        report_new()
    End Sub
    Private Sub txtCash_Keyup(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtCash.KeyUp
        If rbCash.Checked = True Then
            txtKNET.Text = Val(txtPrice.Text) - Val(txtCash.Text)
        End If
        NegativeColor()
    End Sub

    Private Sub txtKnet_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtKNET.KeyUp
        If rbCash.Checked = True Then
            txtCash.Text = Val(txtPrice.Text) - Val(txtKNET.Text)
        End If
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
End Class