Imports System.Drawing.Printing
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class DiamondInvoicePay
    Dim CurrentInvoiceNo As String = "0"
    Dim RptPath As String
    Public GetInvoce As DataTable
    Private Sub GetCastomAccReportPath()
        GetInvoceReportSettings(PathFiled:="SET_INVARCHR146")
        ReportViewer1.LocalReport.ReportPath = ReportPath
    End Sub
    Private Sub DiamondInvoicePay_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Saved = True Then
            DiamondInvoice.Close()
        End If
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Public Sub GetSumValus()
        Dim DtInvID As DataTable = GetRecordSet("SELECT MaxID +1 AS InvIDAuto FROM [dimon_bay] WHERE BAY_ID =(SELECT max(BAY_ID) FROM [dimon_bay])")
        If DtInvID.Rows.Count > 0 Then
            InvID = Val(DtInvID.Rows(0)(0).ToString)
            txtInvoiceNo.Text = InvoiceStringNo(DtInvID.Rows(0)(0).ToString)
        Else
            InvID = "1"
        End If
        GlCommand.CommandText = "UPDATE [dimon_bay] SET [BAY_SARYAL] = N'" & txtInvoiceNo.Text & "' WHERE [BAY_ID] = N'" & DtInvID.Rows(0)(0).ToString & "'"
        GlCommand.ExecuteNonQuery()
    End Sub

    Private Sub DiamondInvoicePay_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        GetReportPath()
        GetPayMethod()
        rbtnCash.Checked = True
        btnPrint.Enabled = False
        btnPDF.Visible = False
        cmbPayMethod.SelectedIndex = 0
        If SET_INVARCHR144TextBox.Text <> "0" Then
            chkAutoClose.Checked = True
        End If
        If SET_INVARCHR165TextBox.Text = "1" Then
            txtCash.Enabled = False
            txtKnet.Enabled = False
            txtKnet.Text = txtPrice.Text
            txtCash.Text = "0"
            cmbPayMethod.DroppedDown = True
            CheckUserPermissions(UserID)
        End If
    End Sub
    Private Sub GetPayMethod()
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = dt1
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt1 As DataTable = GetRecordSet("SELECT MaxID +1 AS InvIDAuto FROM [dimon_bay] WHERE BAY_ID =(SELECT max(BAY_ID) FROM [dimon_bay])")
        If dt1.Rows.Count > 0 Then
            CurrentInvoiceNo = Val(dt1.Rows(0)(0).ToString)
        Else
            CurrentInvoiceNo = "1"
        End If
        If Val(txtCash.Text) > 3000 Then
            MsgBox("According to Kuwaiti law, cash payments are not allowed more than three thousand Kuwaiti dinars in cash" & vbCrLf & "!حسب القانون الكويتي، لايسمح بالدفع كاش أكثر من ثلاثة آلاف دينار كويتي نقدًا", , AppTitle)
            txtCash.Focus()
            txtCash.SelectAll()
            Exit Sub
        End If
        If rbtnCash.Checked = True AndAlso (Val(txtPrice.Text) <> Val(txtCash.Text) + Val(txtKnet.Text)) Then
            MsgBox("لم يتم دفع مبلغ الفاتورة بالكامل" & vbCrLf & "Paid Amount is not Sufficient", , AppTitle)
            Exit Sub
        End If
        If Val(txtCash.Text) < 0 OrElse Val(txtKnet.Text) < 0 Then
            MsgBox("لا يمكن أن يكون المدفوع بالسالب" & vbCrLf & "Paid Amount Can't be Negative!", , AppTitle)
            Exit Sub
        End If

        If Val(txtPrice.Text) < Val(txtCash.Text) + Val(txtKnet.Text) Then
            MsgBox("المبلغ المدفوع أكبر من مبلغ الفاتورة" & vbCrLf & "Paid Amount is more than Invoice amount", , AppTitle)
            Exit Sub
        End If
        If txtCash.Text = "" Then txtCash.Text = "0"
        If txtKnet.Text = "" Then txtKnet.Text = "0"
        Try
            GlCommand.CommandText = "INSERT INTO [dimon_bay] " &
                                    "([BAY_SARYAL] " &
                                    ",[TOTAL_mony] " &
                                    ",[KENT] " &
                                    ",[CACH] " &
                                    ",[arbic_tayb] " &
                                    ",[balance] " &
                                    ",[staytes] " &
                                    ",[English_tayb] " &
                                    ",[PayMethod] " &
                                    ",[user_id] " &
                                    ",[Item_Actv]" &
                                    ",[MaxID])" &
                                    "VALUES " &
                                    "(@BAY_SARYAL " &
                                    ",@TOTAL_mony " &
                                    ",@KENT " &
                                    ",@CACH " &
                                    ",@arbic_tayb " &
                                    ",@balance " &
                                    ",@staytes " &
                                    ",@English_tayb " &
                                    ",@PayMethod " &
                                    ",@user_id " &
                                    ",@Item_Actv " &
                                    ",@MaxID)"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@BAY_SARYAL", InvoiceStringNo(Val(CurrentInvoiceNo)))
                .AddWithValue("@TOTAL_mony", Val(txtPrice.Text.Trim))
                .AddWithValue("@KENT", If(IsDBNull(txtKnet.Text.Trim), "0", Val(txtKnet.Text.Trim)))
                .AddWithValue("@CACH", If(IsDBNull(txtCash.Text.Trim), "0", Val(txtCash.Text.Trim)))
                .AddWithValue("@arbic_tayb", kokotxt(Val(txtPrice.Text), CurrencyMainAr, CurrencySubAr, True))
                .AddWithValue("@balance", Val(txtPrice.Text.Trim) - Val(txtKnet.Text.Trim) - Val(txtCash.Text.Trim))
                .AddWithValue("@staytes", If(rbtnInstallment.Checked = True And Val(txtRemaining.Text) <> 0, "1", "0"))
                .AddWithValue("@English_tayb", ConvertNumberToENG(Val(txtPrice.Text)))
                .AddWithValue("@PayMethod", If(cmbPayMethod.SelectedIndex = -1, 0, cmbPayMethod.SelectedValue))
                .AddWithValue("@user_id", UserID)
                .AddWithValue("@Item_Actv", "1")
                .AddWithValue("@MaxID", Val(CurrentInvoiceNo))
            End With
            GlCommand.ExecuteNonQuery()
            txtInvoiceNo.Text = InvoiceStringNo(Val(CurrentInvoiceNo))
            DiamondInvoice.SaveGrid(InvoiceStringNo(Val(CurrentInvoiceNo)))
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        btnSave.Enabled = False
        btnPrint.Enabled = True
        Saved = True
        btnPDF.Visible = True
        cmbPayMethod.Enabled = False
        Try
            Dim GetTotalSum As DataTable =
            GetRecordSet("SELECT descont, SUM(CAST(test_116 AS DECIMAL(18, 3))) AS test_116, " & vbCrLf &
            "SUM(GOLD_mezan) AS GOLD_mezan, " & vbCrLf &
            "SUM(DIMO_mezan) AS DIMO_mezan,SUM(DIMO_qult)as DIMO_qult, " & vbCrLf &
            "SUM(CAST(test_16 AS DECIMAL(18, 3))) AS test_16, " & vbCrLf &
            "SUM(CAST(test_13 AS DECIMAL(18, 3))) AS test_13, " & vbCrLf &
            "SUM(CAST(test_19 AS DECIMAL(18, 3))) AS test_19" & vbCrLf &
            "FROM dbo.dimon_invce where descont=N'" & txtInvoiceNo.Text & "'" & vbCrLf &
            "GROUP BY descont")
            If GetTotalSum.Rows.Count > 0 Then
                Dim GrossWi As Decimal = GetTotalSum.Rows(0)("test_116")
                Dim GoledWi As Decimal = GetTotalSum.Rows(0)("GOLD_mezan")
                Dim DimonWI As Decimal = GetTotalSum.Rows(0)("DIMO_mezan")
                Dim ParaQunt As Decimal = GetTotalSum.Rows(0)("DIMO_qult")
                Dim STON1 As Decimal = GetTotalSum.Rows(0)("test_16")
                Dim STON2 As Decimal = GetTotalSum.Rows(0)("test_13")
                Dim STON3 As Decimal = GetTotalSum.Rows(0)("test_19")
                Dim GrsWi As New ReportParameter("ParGrossWt", GrossWi)
                Dim GolWi As New ReportParameter("ParGoldWt", GoledWi)
                Dim DimI As New ReportParameter("ParDWt", DimonWI)
                Dim ST1 As New ReportParameter("ParPreciousSemiWtCTS", STON1)
                Dim ST2 As New ReportParameter("ParSyntheticWtCTS", STON2)
                Dim ST3 As New ReportParameter("ParaPearlWt", STON3)
                Dim DimonQunt As New ReportParameter("ParaQunt", ParaQunt)
                ReportViewer1.LocalReport.SetParameters(GrsWi)
                ReportViewer1.LocalReport.SetParameters(GolWi)
                ReportViewer1.LocalReport.SetParameters(DimI)
                ReportViewer1.LocalReport.SetParameters(ST1)
                ReportViewer1.LocalReport.SetParameters(ST2)
                ReportViewer1.LocalReport.SetParameters(ST3)
                ReportViewer1.LocalReport.SetParameters(DimonQunt)
            End If

        Catch ex As Exception
            'MsgBox(ex.ToString)
            'Exit Sub
        End Try
        InvoiceSearch()
        'SetReportPaper(ReportViewer1)
        ReportViewer1.RefreshReport()
        ReportViewer1.Visible = True

    End Sub
    Public Sub InvoiceSearch()
        Try
            GetInvoce = GetRecordSet("select * from for_print_dimon_finel  where BAY_SARYAL = '" & InvoiceStringNo(Val(CurrentInvoiceNo)) & "' AND [Item_Actv] = 1")
            If GetInvoce.Rows.Count > 0 Then
                Dim ReportDataSource = New ReportDataSource("DataSet1", GetInvoce)
                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
                ReportViewer1.RefreshReport()
                ReportViewer1.RefreshReport()
            End If
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
            MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Saved = True
        Try
            Dim printerSettings1 As New PrinterSettings
            printerSettings1.Copies = If(SET_INVARCHR141TextBox.Text = "", "2", SET_INVARCHR141TextBox.Text.Trim)
            ReportViewer1.PrintDialog(printerSettings1)
        Catch ex As Exception
            MsgBox("تجري الطباعة الآن" & vbCrLf & "Printing in Progress.......", , AppTitle)
        End Try

        If chkAutoClose.Checked = True Then
            Close()
        End If
    End Sub

    Private Sub txtPrice_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtPrice.LinkClicked
        'If SET_INVARCHR165TextBox.Text = "1" Then
        txtKnet.Text = Val(txtPrice.Text)

        'Else
        '    txtCash.Text = Val(txtPrice.Text)
        'End If
    End Sub


    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        Try
            ReportViewer1.LocalReport.DisplayName = DiamondInvoice.CurrentCustomerName
        Catch ex As Exception
            MsgBox("خطأ في موقع الحفظ" & vbCrLf & "Error in Save Location", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        'Try
        Dim Path As String = Settings.SET_INVARCHR148TextBox.Text
        If Strings.Right(Path, 1) <> "\" Then Path &= "\"
        ReportViewer1.LocalReport.EnableExternalImages = True
        Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
        Dim saveFileDialog1 As New SaveFileDialog()
        With saveFileDialog1
            .Filter = "*PDF files (*.PDF)|*.PDF"
            .FileName = DiamondInvoice.CurrentCustomerName
            .FilterIndex = 2
            .RestoreDirectory = True
        End With

        If Directory.Exists(Path & "Diamond\" & DiamondInvoice.CurrentCustomerName & "-" & DiamondInvoice.CurrentCustomerID) = False Then Directory.CreateDirectory(Path & "Diamond\" & DiamondInvoice.CurrentCustomerName & "-" & DiamondInvoice.CurrentCustomerID)
        Dim newFile As New FileStream(Path & "Diamond\" & DiamondInvoice.CurrentCustomerName & "-" & DiamondInvoice.CurrentCustomerID & "\" & txtInvoiceNo.Text & ".PDF", FileMode.Create)
        newFile.Write(byteViewer, 0, byteViewer.Length)
        newFile.Close()
        If MsgBox("تم الحفظ. هل تريد عرض مجلد الفاتورة؟" & vbCrLf & "Save Done. Open Invoice Folder?", vbYesNo, AppTitle) = vbYes Then
            Process.Start(Path & "Diamond\" & DiamondInvoice.CurrentCustomerName & "-" & DiamondInvoice.CurrentCustomerID)
        End If
    End Sub
    Private Sub chkEngInvoice_CheckedChanged(sender As Object, e As EventArgs) Handles chkEngInvoice.CheckedChanged
        GetReportPath()
        If Saved Then ReportViewer1.RefreshReport()
    End Sub
    Private Sub GetReportPath()

        Dim DiamondArPath As String = SET_INVARCHR146TextBox.Text.Trim
        If chkEngInvoice.Checked = True Then
            'Diamond-Eng
            If ChkWholeSale.Checked = False Then
                ReportViewer1.LocalReport.ReportPath = Replace(DiamondArPath, ".rdlc", "-EN.rdlc")
            Else
                ReportViewer1.LocalReport.ReportPath = Replace(DiamondArPath, ".rdlc", "-WholeSale-EN.rdlc")
            End If
        Else
            'Diamond-Ar
            If ChkWholeSale.Checked = False Then
                ReportViewer1.LocalReport.ReportPath = DiamondArPath
            Else
                ReportViewer1.LocalReport.ReportPath = Replace(DiamondArPath, ".rdlc", "-WholeSale.rdlc")
            End If
        End If
    End Sub
    Private Sub txtKnet_TextChanged(sender As Object, e As EventArgs) Handles txtKnet.TextChanged
        txtRemaining.Text = Val(txtKnet.Text) + Val(txtCash.Text) - Val(txtPrice.Text)
    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        txtRemaining.Text = Val(txtKnet.Text) + Val(txtCash.Text) - Val(txtPrice.Text)
    End Sub
    Private Sub txtCash_Keyup(sender As Object, e As KeyEventArgs) Handles txtCash.KeyUp
        If rbtnCash.Checked = True Then
            txtKnet.Text = Val(txtPrice.Text) - Val(txtCash.Text)
            NegativeColor()
        End If
    End Sub

    Private Sub txtKnet_KeyPress(sender As Object, e As KeyEventArgs) Handles txtKnet.KeyUp
        If rbtnCash.Checked = True Then
            txtCash.Text = Val(txtPrice.Text) - Val(txtKnet.Text)
            NegativeColor()
        End If
    End Sub
    Private Sub NegativeColor()
        If Val(txtKnet.Text) < 0 Then
            txtKnet.ForeColor = Color.Red
        Else
            txtKnet.ForeColor = Color.Black
        End If
        If Val(txtCash.Text) < 0 Then
            txtCash.ForeColor = Color.Red
        Else
            txtCash.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ChkWholeSale_CheckedChanged(sender As Object, e As EventArgs) Handles ChkWholeSale.CheckedChanged
        GetReportPath()
        If Saved Then ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class