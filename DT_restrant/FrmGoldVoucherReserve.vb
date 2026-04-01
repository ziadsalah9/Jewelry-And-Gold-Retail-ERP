Imports PACICardLibrary
Imports DT_restrant.DT_restrantDataSetTableAdapters
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports Microsoft.Reporting.WinForms
Imports System.ComponentModel

Public Class FrmGoldVoucherReserve
    Public CmbVoucherNumberEdit As Boolean = False
    Public texte As String
    Public saryil As String
    Dim _clsSnd As New ClsSnd
    Dim MAX_ID As String
    Dim GoldPrice As Decimal
    Dim MakeCharge As Decimal
    Dim TotalPrice As Decimal = GoldPrice + MakeCharge
    Dim InvID As String
    Private Function CalculateTotalGridPrice() As Decimal
        CalculateTotalGridPrice = 0
        For i As Integer = 0 To Grid.RowCount - 1
            CalculateTotalGridPrice += Grid.Rows(i).Cells("colTXTGoCaret999").Value
        Next
        Return Math.Round(CalculateTotalGridPrice, 3)
    End Function

    Private Sub GetPricePerGram()
        If cmbKarat.Text.Trim = "24" Then
            txtGramPrice.Text = frmMain.lbl24.Text.Trim
        ElseIf cmbKarat.Text.Trim = "22" Then
            txtGramPrice.Text = frmMain.lbl22.Text.Trim
        ElseIf cmbKarat.Text.Trim = "21" Then
            txtGramPrice.Text = frmMain.lbl21.Text.Trim
        ElseIf cmbKarat.Text.Trim = "18" Then
            txtGramPrice.Text = frmMain.lbl18.Text.Trim
        End If
    End Sub
    Private Sub grid_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles Grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If Grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If Grid.Columns(e.ColumnIndex).Name = "colModify" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Search, CInt((e.CellBounds.Width / 2) - (My.Resources.Search.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Search.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Public Sub GetBondType()
        GetFillComboBox(ComboBoxName:=ComGoldype, DisMem:=If(frmLogin.rbtnEn.Checked = True, "BondTypeEnName", "BondTypeArName"),
       SqlCom:=("SELECT * FROM [TBBondGoldType] WHERE [BondTypeActiv] ='1' and BondType='1'"), ValMem:="BondGoldTypeID")
    End Sub
    Public Sub Get_comp_Data()
        GetFillComboBox(ComboBoxName:=Cob_Comp_nam, SqlCom:="SELECT [BranchName],BranchID FROM [TPCompanyBranches]", DisMem:="BranchName", ValMem:="BranchID")
    End Sub
    Private Sub FrmGoldVoucherReserve_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        BtnSave.Enabled = False
        ChkAutocalculation.Checked = True
        DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
        ApplyIconsToButtons(Me)
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        Try
            EditForm = False
            CivilIDForm = New CivilID
            CivilIDForm.gbCustomerData.BackColor = Color.FromArgb(64, 64, 64)
            CivilIDForm.Bounds = New Rectangle(0, 0, 995, 255)
            Controls.Add(CivilIDForm)
            CivilIDForm.txtCID.ForeColor = Color.Black
            CardServiceStart()
            paci = New PACMAN
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        frmMain.Timer1.Stop()
        Get_Casher_Data()
        Get_comp_Data()
        GetBondType()
        GetData()
        GoldCaret()
        ComGoldype.SelectedIndex = -1
        ComCasher.SelectedIndex = -1
        Cob_Comp_nam.SelectedIndex = -1
        GetPricePerGram()
        BackgroundWorkerGetInv.RunWorkerAsync()
    End Sub

    Public Sub Get_Casher_Data()
        Try
            Dim DT As DataTable = GetRecordSet("SELECT * FROM cacher where Active =1")
            If DT.Rows.Count > 0 Then
                ComCasher.DataSource = DT
                ComCasher.DisplayMember = "cacher_name"
                ComCasher.ValueMember = "svil_id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Dim IsVoke As Boolean = False
    Dim TxtFractions As Double = 0
    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim DT As DataTable = GetRecordSet("SELECT CastomerDETELS.CastomerNAme, CastomerDETELS.CastomerCAIVELid, CastomerDETELS.CastomerTE, CastomerDETELS.CastomerADr, CastomerDETELS.CastomerNA, CastomerDETELS.foto, " &
                     " CastomerDETELS.fotoBack, CastomerDETELS.Signature, CastomerDETELS.CastomerNameEn, SndGold.Cash, SndGold.Kent, SndGold.Amount, SndGold.Time_, SndGold.SndNumber, " &
                     " SndGold.SndType, cacher.cacher_name, PayMethod.PayMethodAr, PayMethod.PayMethodEn, cacher.CashierSignature, SndGold.NumToWorld_AR, SndGold.NumToWorld_EN, SndGold.Note_, " &
                     " COMPANY_BAY_DETELS.COMP_NAME, SndGold.GrossWeight, SndGold.Karat, SndGold.Weight, SndGold.ReciviedName, SndGold.SandWeight  " &
                     " FROM CastomerDETELS INNER JOIN " &
                     " SndGold ON CastomerDETELS.CastomerCAIVELid = SndGold.civilid INNER JOIN " &
                     " [user] ON SndGold.UserId = [user].user_id INNER JOIN " &
                     " cacher ON SndGold.Casher = cacher.svil_id INNER JOIN " &
                     " PayMethod ON SndGold.PayMID = PayMethod.ID INNER JOIN " &
                     " COMPANY_BAY_DETELS ON SndGold.Supplier = COMPANY_BAY_DETELS.COM_ID " &
                     " WHERE (SndGold.SndNumber = N'" & MAX_ID & "')")
        From_ReportSndToCustomer.txtInvoiceNo.Text = MAX_ID
        From_ReportSndToCustomer.LblFilter.Text = 1
        From_ReportSndToCustomer.Re_View_SndToCustomer.LocalReport.ReportPath = From_ReportSndToCustomer.GetReportPath.Rows(0)(1).ToString()
        If DT.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", DT)
            From_ReportSndToCustomer.Re_View_SndToCustomer.LocalReport.DataSources.Clear()
            From_ReportSndToCustomer.Re_View_SndToCustomer.LocalReport.DataSources.Add(ReportDataSource)
            From_ReportSndToCustomer.Re_View_SndToCustomer.RefreshReport()
            From_ReportSndToCustomer.Re_View_SndToCustomer.SetDisplayMode(DisplayMode.PrintLayout)
        Else
        End If
        From_ReportSndToCustomer.ShowDialog()
    End Sub


    Private Sub FrmGoldVoucherReserve_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        sc.Dispose()
        Dispose()
    End Sub

    Private Sub FrmGoldVoucherReserve_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        sc.Dispose()
        Dispose()
    End Sub

    Private Sub GoldWeight()
        If Val(cmbKarat.Text) > 25 Then
            TXTGoCaret999.Text = Math.Round(If(IsDBNull(txtWeight.Text), 0, Val(txtWeight.Text) * Val(cmbKarat.Text) / (ComBxGoCaret999.Text)), 3)
        ElseIf Val(cmbKarat.Text) < 25 Then
            Dim GoledCart As Decimal = Val(cmbKarat.Text) / 24 * 1000
            Try
                TXTGoCaret999.Text = Math.Round(If(IsDBNull(txtWeight.Text), 0, Val(txtWeight.Text) * Val(GoledCart) / (ComBxGoCaret999.Text)), 3)
            Catch ex As Exception
                'Return
            End Try
        End If
    End Sub
    Private Sub TotalGoldPrice()
        If ChkAutocalculation.Checked = True Then
            Try
                GoldPrice = Math.Round(Val(txtGramPrice.Text.Trim) * Val(txtWeight.Text.Trim), 3)
                txtGoldPrice.Text = Math.Round(Val(GoldPrice), 3)
                txtTotalPrice.Text = Math.Round(Val(MakeCharge) + Val(GoldPrice), 3)
            Catch ex As Exception
                'Return
            End Try
        ElseIf ChkAutocalculation.Checked = False Then
        End If

    End Sub
    Private Sub TotalMakeCharge()
        If ChkAutocalculation.Checked = True Then
            Try
                MakeCharge = Math.Round(Val(txtMakeCharge.Text.Trim) * Val(txtWeight.Text.Trim), 3)
                txtTMakeCharge.Text = Math.Round(Val(MakeCharge), 3)
                txtTotalPrice.Text = Math.Round(Val(MakeCharge) + Val(GoldPrice), 3)
            Catch ex As Exception
                'Return
            End Try
        ElseIf ChkAutocalculation.Checked = False Then
        End If
    End Sub
    Private Sub cmbKarat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKarat.SelectedIndexChanged
        GoldWeight()
        GetPricePerGram()
        TotalGoldPrice()
    End Sub

    Private Sub txtWeight_TextChanged_1(sender As Object, e As EventArgs) Handles txtWeight.TextChanged
        GoldWeight()
        TotalGoldPrice()
        TotalMakeCharge()
    End Sub

    Private Sub ComBxGoCaret999_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComBxGoCaret999.SelectedIndexChanged
        GoldWeight()
    End Sub
    Public Sub GetData()
        Dim ComBx999 As DataTable = GetRecordSet("SELECT FractionValues FROM Gram_val GROUP BY FractionValues ORDER BY FractionValues DESC")
        If ComBx999.Rows.Count > 0 Then
            ComBxGoCaret999.DataSource = ComBx999
            ComBxGoCaret999.DisplayMember = "FractionValues"
        End If
    End Sub

    Public Sub GoldCaret()
        Dim GoldCaretDt As DataTable = GetRecordSet("SELECT Gram_valu FROM Gram_val  GROUP BY Gram_valu")
        If GoldCaretDt.Rows.Count > 0 Then
            cmbKarat.DataSource = GoldCaretDt
            cmbKarat.DisplayMember = "Gram_valu"
            cmbKarat.ValueMember = "Gram_valu"
        End If
    End Sub

    Private Sub btnCompName_Click(sender As Object, e As EventArgs) Handles btnCompName.Click
        frmSuppliers.ShowDialog()
    End Sub
    Public Sub GetLastInvNo()
        Try
            Dim DT As DataTable = GetRecordSet("SELECT VoucherNumber +1 AS VoucherNumber FROM TPGoldVoucherReceive WHERE GoldVoucherReceiveID=(SELECT max(GoldVoucherReceiveID) FROM TPGoldVoucherReceive)")
            If DT.Rows.Count > 0 Then
                InvID = Val(DT.Rows(0)(0).ToString)
            Else
                InvID = "1"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If ComGoldype.SelectedIndex = -1 Then
            MsgBox("اختر نوع السند" & vbCrLf & "Choose the type of bond", , "خطأ")
            ComGoldype.DroppedDown = True
            Return
        End If
        If IsDBNull(Cob_Comp_nam.Text) Or Cob_Comp_nam.SelectedIndex = -1 Then
            MsgBox("اختر اسم المورد/الشركه/الورشه" & vbCrLf & "Choose the name of the supplier/company/workshop", , "خطأ")
            Cob_Comp_nam.DroppedDown = True
            Return
        End If

        Dim CID As String = CivilIDForm.txtCID.Text.Trim
        If CivilIDForm.SaveCustomerData() = False Then
            Exit Sub
        Else
            CivilIDForm.txtCID.Enabled = False
        End If
        If String.IsNullOrWhiteSpace(TxtNote.Text) Then
            MsgBox("اكتب البيان" & vbCrLf & "Write the Description", , "خطأ")
            Return
        End If
        If ComCasher.Text = "اختر اسم الكاشير" OrElse ComCasher.Text = "Select Cashier" Then
            MsgBox("اسم الكاشير لم يتم إدخاله" & vbCrLf & "Please Select Cashier", , "خطأ")
            ComCasher.DroppedDown = True
            Exit Sub
        End If
        If ComCasher.SelectedIndex = -1 Then
            MsgBox("اختر كاشيرًا من الموجودين..لا تكتب كاشيرًا جديدًا" & vbCrLf & "Please Select Cashier, Don't Enter Manually", , "خطأ")
            ComCasher.DroppedDown = True
            Exit Sub
        End If
        If Val(txtWeight.Text) = 0 Then
            MsgBox("أدخل وزنًا" & vbCrLf & "Please Enter Weight", , "خطأ")
            txtWeight.Focus()
            txtWeight.SelectAll()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtQuntt.Text) Then
            MsgBox("لم يتم ادخال العدد" & vbCrLf & "Quantity Not Entered", , "خطأ")
            Return
        End If
        If Val(txtGramPrice.Text) = 0 Then
            MsgBox("أدخل سعر الجرام" & vbCrLf & "Please Enter Gram Price", , "خطأ")
            txtGramPrice.Focus()
            txtGramPrice.SelectAll()
            Exit Sub
        End If

        If Val(txtGoldPrice.Text) = 0 Then
            MsgBox("أدخل سعر الذهب" & vbCrLf & "Please Enter Gold Price", , "خطأ")
            txtGoldPrice.Focus()
            txtGoldPrice.SelectAll()
            Exit Sub
        End If
        If Val(txtMakeCharge.Text) = 0 Then
            txtMakeCharge.Text = 0
        End If

        If Val(txtTMakeCharge.Text) = 0 Then
            txtTMakeCharge.Text = 0
        End If

        If Val(txtTotalPrice.Text) = 0 Then
            MsgBox("أدخل اجمالي السعر " & vbCrLf & "Please Enter Total Price", , "خطأ")
            txtTotalPrice.Focus()
            txtTotalPrice.SelectAll()
            Exit Sub
        End If


        If cmbKarat.SelectedIndex = -1 Then
            MsgBox("لم يتم ادخال العيار" & vbCrLf & "Gold Carat Not Entered", , "خطأ")
            cmbKarat.DroppedDown = True
            Return
        End If
        CalculateTotalGridPrice()
        With (Grid)
            .Rows.Add()
            .Rows(.Rows.Count - 1).Cells("colCastomerid").Value = CivilIDForm.txtCID.Text.Trim()
            .Rows(.Rows.Count - 1).Cells("colComGoldype").Value = ComGoldype.SelectedValue
            .Rows(.Rows.Count - 1).Cells("colCob_Comp_nam").Value = Cob_Comp_nam.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colComCasher").Value = ComCasher.SelectedValue
            .Rows(.Rows.Count - 1).Cells("colcmbKarat").Value = cmbKarat.Text.Trim()
            .Rows(.Rows.Count - 1).Cells("coltxtWeight").Value = txtWeight.Text.Trim()
            .Rows(.Rows.Count - 1).Cells("colComBxGoCaret999").Value = If(IsDBNull(ComBxGoCaret999.Text.Trim), "999", Val(ComBxGoCaret999.Text.Trim))
            .Rows(.Rows.Count - 1).Cells("colTXTGoCaret999").Value = TXTGoCaret999.Text.Trim()
            .Rows(.Rows.Count - 1).Cells("coltxtQuntt").Value = txtQuntt.Text.Trim()
            .Rows(.Rows.Count - 1).Cells("coldtExpensesDate").Value = dtExpensesDate.Text.Trim()
            .Rows(.Rows.Count - 1).Cells("colTxtNote").Value = TxtNote.Text.Trim()
            .Rows(.Rows.Count - 1).Cells("coltxtGramPrice").Value = txtGramPrice.Text.Trim()
            .Rows(.Rows.Count - 1).Cells("coltxtGoldPrice").Value = txtGoldPrice.Text.Trim()
            .Rows(.Rows.Count - 1).Cells("coltxtMakeCharge").Value = If(IsDBNull(txtMakeCharge.Text.Trim), "0", (txtMakeCharge.Text.Trim))
            .Rows(.Rows.Count - 1).Cells("coltxtTMakeCharge").Value = If(IsDBNull(txtTMakeCharge.Text.Trim), "0", (txtTMakeCharge.Text.Trim))
            .Rows(.Rows.Count - 1).Cells("coltxtTotalPrice").Value = txtTotalPrice.Text.Trim()
            .Rows(.Rows.Count - 1).Cells("colWeightArletters").Value = kokotxt(Val(txtWeight.Text), "جرام", "ملي", True).ToString
            .Rows(.Rows.Count - 1).Cells("colWeightEnletters").Value = ConvertWeightToENG(txtWeight.Text.Trim).ToString
            .Rows(.Rows.Count - 1).Cells("colTotalPriceArletters").Value = kokotxt(Val(txtTotalPrice.Text), CurrencyMainAr, CurrencySubAr, True).ToString
            .Rows(.Rows.Count - 1).Cells("colTotalPriceEnletters").Value = ConvertWeightToENG(txtTotalPrice.Text.Trim).ToString
        End With
        MsgBox("تم اضافة الصنف" & vbCrLf & "Item Added.", , AppTitle)
        BtnSave.Enabled = True
    End Sub
    Public Sub PrinetInv()
        Try
            With frmGoldVoucherReceive
                .txtInvoiceNo.Text = InvoiceStringNo(Val(InvID)).ToString()
                .ReportPrint()
                .RptView.RefreshReport()
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
        End Try
    End Sub
    Private Sub FrmGoldVoucherReserve_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub FrmGoldVoucherReserve_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Timer1.Start()
        Dispose()
    End Sub
    Private Sub txtGramPrice_TextChanged(sender As Object, e As EventArgs) Handles txtGramPrice.TextChanged
        TotalGoldPrice()
    End Sub
    Private Sub cmbKarat_TextChanged(sender As Object, e As EventArgs) Handles cmbKarat.TextChanged
        GoldWeight()
        GetPricePerGram()
        TotalGoldPrice()
    End Sub

    Private Sub txtMakeCharge_TextChanged(sender As Object, e As EventArgs) Handles txtMakeCharge.TextChanged
        TotalMakeCharge()
        TotalGoldPrice()
    End Sub
    Private Sub grid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles Grid.CellClick
        If Grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد حذف الصنف ؟" & vbCrLf & "Do You Want to Delete Item ? ", vbYesNo) = vbYes Then
                Try
                    Grid.Rows.RemoveAt(Grid.CurrentRow.Index)
                    If Grid.Rows.Count = 0 Then
                        CivilIDForm.txtCID.Enabled = True
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, , AppTitle)
                End Try
            End If
        End If
        '''''''''''''''''''''
        If Grid.Columns(e.ColumnIndex).Name = "colModify" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد تعديل القطعة رقم " & Grid.Rows(e.RowIndex).Cells("colComGoldype").Value & "؟" & vbCrLf & "Do You Want to Modify Item No. " & Grid.Rows(e.RowIndex).Cells("colComGoldype").Value, vbYesNo) = vbYes Then
                ComGoldype.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colComGoldype").Value), "", (Grid.SelectedRows(0).Cells("colComGoldype").Value))
                Cob_Comp_nam.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colCob_Comp_nam").Value), "", (Grid.SelectedRows(0).Cells("colCob_Comp_nam").Value))
                ComCasher.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colComCasher").Value), "", (Grid.SelectedRows(0).Cells("colComCasher").Value))
                cmbKarat.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colcmbKarat").Value), "", (Grid.SelectedRows(0).Cells("colcmbKarat").Value))
                txtWeight.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtWeight").Value), "", (Grid.SelectedRows(0).Cells("coltxtWeight").Value))
                ComBxGoCaret999.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colComBxGoCaret999").Value), "", (Grid.SelectedRows(0).Cells("colComBxGoCaret999").Value))
                TXTGoCaret999.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colTXTGoCaret999").Value), "", (Grid.SelectedRows(0).Cells("colTXTGoCaret999").Value))
                txtQuntt.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtQuntt").Value), "", (Grid.SelectedRows(0).Cells("coltxtQuntt").Value))
                dtExpensesDate.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coldtExpensesDate").Value), "", (Grid.SelectedRows(0).Cells("coldtExpensesDate").Value))
                TxtNote.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colTxtNote").Value), "", (Grid.SelectedRows(0).Cells("colTxtNote").Value))
                txtGramPrice.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtGramPrice").Value), "", (Grid.SelectedRows(0).Cells("coltxtGramPrice").Value))
                txtGoldPrice.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtGoldPrice").Value), "", (Grid.SelectedRows(0).Cells("coltxtGoldPrice").Value))
                txtMakeCharge.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtMakeCharge").Value), "0", (Grid.SelectedRows(0).Cells("coltxtMakeCharge").Value))
                txtTMakeCharge.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtTMakeCharge").Value), "0", (Grid.SelectedRows(0).Cells("coltxtTMakeCharge").Value))
                txtTotalPrice.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtTotalPrice").Value), "", (Grid.SelectedRows(0).Cells("coltxtTotalPrice").Value))
                'txtWeight.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colWeightArletters").Value), "", (Grid.SelectedRows(0).Cells("colWeightArletters").Value))
                'txtWeight.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colWeightEnletters").Value), "", (Grid.SelectedRows(0).Cells("colWeightEnletters").Value))
                'txtTotalPrice.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colTotalPriceArletters").Value), "", (Grid.SelectedRows(0).Cells("colTotalPriceArletters").Value))
                'txtTotalPrice.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colTotalPriceEnletters").Value), "", (Grid.SelectedRows(0).Cells("colTotalPriceEnletters").Value))
            End If
        End If
    End Sub

    Private Sub ChkAutocalculation_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAutocalculation.CheckedChanged
        If ChkAutocalculation.Checked = True Then
            GetPricePerGram()
            TotalGoldPrice()
        ElseIf ChkAutocalculation.Checked = False Then
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        UpdateGrid()
        GetLastInvNo()
        SaveData()
    End Sub

    Private Sub UpdateGrid()
        For i As Integer = 0 To Grid.Rows.Count - 1
            Dim UpdateRows As DataGridViewRow = Grid.Rows(i)
            UpdateRows.Cells("colCob_Comp_nam").Value = Cob_Comp_nam.Text.Trim
            UpdateRows.Cells("colTxtNote").Value = TxtNote.Text.Trim()
            UpdateRows.Cells("colComGoldype").Value = ComGoldype.SelectedValue
            UpdateRows.Cells("colComCasher").Value = ComCasher.SelectedValue
            UpdateRows.Cells("colCastomerid").Value = CivilIDForm.txtCID.Text.Trim()
            UpdateRows.Cells("colPurWeightArletters").Value = kokotxt(CalculateTotalGridPrice(), "جرام", "ملي", True).ToString()
            UpdateRows.Cells("colPurWeightEnletters").Value = ConvertWeightToENG(CalculateTotalGridPrice).ToString
        Next
    End Sub
    Private Sub SaveData()
        For i As Integer = 0 To Grid.Rows.Count - 1
            GlCommand.CommandText = "INSERT INTO [TPGoldVoucherReceive]" & vbCrLf &
                            "([VoucherNumber]" & vbCrLf &
                            ",[CivilID]" & vbCrLf &
                            ",[UserID]" & vbCrLf &
                            ",[Casher]" & vbCrLf &
                            ",[VoucherType]" & vbCrLf &
                            ",[Supplier]" & vbCrLf &
                            ",[GoldKarat]" & vbCrLf &
                            ",[PurKarat]" & vbCrLf &
                            ",[GoldWeight]" & vbCrLf &
                            ",[PurWeight]" & vbCrLf &
                            ",[GramPrice]" & vbCrLf &
                            ",[GoldPrice]" & vbCrLf &
                            ",[MakeCharge]" & vbCrLf &
                            ",[TotalMakeCharge]" & vbCrLf &
                            ",[TotalPrice]" & vbCrLf &
                            ",[Qunt]" & vbCrLf &
                            ",[WeightArletters]" & vbCrLf &
                            ",[WeightEnletters]" & vbCrLf &
                            ",[TotalPriceArletters]" & vbCrLf &
                            ",[TotalPriceEnletters]" & vbCrLf &
                            ",[purWeightArletters]" & vbCrLf &
                            ",[purWeightEnletters]" & vbCrLf &
                            ",[CreationDate]" & vbCrLf &
                            ",[LastEditDate]" & vbCrLf &
                            ",[Time]" & vbCrLf &
                            ",[Note]" & vbCrLf &
                            ",[Activite])" & vbCrLf &
                            "VALUES" & vbCrLf &
                            "(@VoucherNumber" & vbCrLf &
                            ",@CivilID" & vbCrLf &
                            ",@UserID" & vbCrLf &
                            ",@Casher" & vbCrLf &
                            ",@VoucherType" & vbCrLf &
                            ",@Supplier" & vbCrLf &
                            ",@GoldKarat" & vbCrLf &
                            ",@PurKarat" & vbCrLf &
                            ",@GoldWeight" & vbCrLf &
                            ",@PurWeight" & vbCrLf &
                            ",@GramPrice" & vbCrLf &
                            ",@GoldPrice" & vbCrLf &
                            ",@MakeCharge" & vbCrLf &
                            ",@TotalMakeCharge" & vbCrLf &
                            ",@TotalPrice" & vbCrLf &
                            ",@Qunt" & vbCrLf &
                            ",@WeightArletters" & vbCrLf &
                            ",@WeightEnletters" & vbCrLf &
                            ",@TotalPriceArletters" & vbCrLf &
                            ",@TotalPriceEnletters" & vbCrLf &
                            ",@purWeightArletters" & vbCrLf &
                            ",@purWeightEnletters" & vbCrLf &
                            ",@CreationDate" & vbCrLf &
                            ",@LastEditDate" & vbCrLf &
                            ",@Time" & vbCrLf &
                            ",@Note" & vbCrLf &
                            ",@Activite)"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@VoucherNumber", InvoiceStringNo(Val(InvID))).ToString()
                .AddWithValue("@CivilID", Grid.Rows(i).Cells("colCastomerid").Value)
                .AddWithValue("@UserID", frmLogin.User_idTextBox.Text)
                .AddWithValue("@Casher", Grid.Rows(i).Cells("colComCasher").Value)
                .AddWithValue("@VoucherType", Grid.Rows(i).Cells("colComGoldype").Value)
                .AddWithValue("@Supplier", Cob_Comp_nam.SelectedValue)
                .AddWithValue("@GoldKarat", Grid.Rows(i).Cells("colcmbKarat").Value)
                .AddWithValue("@PurKarat", Grid.Rows(i).Cells("colComBxGoCaret999").Value)
                .AddWithValue("@GoldWeight", Grid.Rows(i).Cells("coltxtWeight").Value)
                .AddWithValue("@PurWeight", Grid.Rows(i).Cells("colTXTGoCaret999").Value)
                .AddWithValue("@GramPrice", Grid.Rows(i).Cells("coltxtGramPrice").Value)
                .AddWithValue("@GoldPrice", Grid.Rows(i).Cells("coltxtGoldPrice").Value)
                .AddWithValue("@MakeCharge", Grid.Rows(i).Cells("coltxtMakeCharge").Value)
                .AddWithValue("@TotalMakeCharge", Grid.Rows(i).Cells("coltxtTMakeCharge").Value)
                .AddWithValue("@TotalPrice", Grid.Rows(i).Cells("coltxtTotalPrice").Value)
                .AddWithValue("@Qunt", Grid.Rows(i).Cells("coltxtQuntt").Value)
                .AddWithValue("@WeightArletters", Grid.Rows(i).Cells("colWeightArletters").Value)
                .AddWithValue("@WeightEnletters", Grid.Rows(i).Cells("colWeightEnletters").Value)
                .AddWithValue("@TotalPriceArletters", Grid.Rows(i).Cells("colTotalPriceArletters").Value)
                .AddWithValue("@TotalPriceEnletters", Grid.Rows(i).Cells("colTotalPriceEnletters").Value)
                .AddWithValue("@PurWeightArletters", Grid.Rows(i).Cells("colPurWeightArletters").Value)
                .AddWithValue("@PurWeightEnletters", Grid.Rows(i).Cells("colPurWeightEnletters").Value)
                .AddWithValue("@CreationDate", DateToSave(Date.Now))
                .AddWithValue("@LastEditDate", DateToSave(Date.Now))
                .AddWithValue("@Time", Format(dtExpensesDate.Value, "dd/MM/yyyy hh:mm:ss").ToString)
                .AddWithValue("@Note", (Grid.Rows(i).Cells("colTxtNote").Value))
                .AddWithValue("@Activite", "1")
            End With
            GlCommand.ExecuteNonQuery()
        Next
        If MsgBox("تم الحفظ اضغط نعم للطباعه او  الغاء الامر" & vbCrLf & "Saved, click Yes to print or cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "سند صرف/قبض نقدي" & vbCrLf & "Bond issued/received cash") = MsgBoxResult.Ok Then
            PrinetInv()
            MsgBox("تم حفظ السند و طباعته" & vbCrLf & "The Bond Was Saved And Printed.", , AppTitle)
        Else
            MsgBox("تم حفظ السند دون طباعته" & vbCrLf & "Delete Cancelled.", , AppTitle)
            Beep()
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmBondGoldType.ShowDialog()
    End Sub

    Private Sub BackgroundWorkerGetInv_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorkerGetInv.DoWork

        Dim GetInvNo As DataTable = GetRecordSet("SELECT MIN(GoldVoucherReceiveID) AS GoldVoucherReceiveID, VoucherNumber" & vbCrLf &
                                               "FROM TPGoldVoucherReceive" & vbCrLf &
                                               "WHERE Activite = 1" & vbCrLf &
                                               "GROUP BY VoucherNumber" & vbCrLf &
                                               "ORDER BY MIN(GoldVoucherReceiveID) DESC")
        If GetInvNo.Rows.Count > 0 Then
            CmbVoucherNumber.Invoke(Sub() CmbVoucherNumber.DataSource = GetInvNo)
            CmbVoucherNumber.Invoke(Sub() CmbVoucherNumber.DisplayMember = "VoucherNumber")
            'CmbVoucherNumber.Invoke(Sub() CmbVoucherNumber.SelectedValue = "VoucherNumber")
        End If

    End Sub

    Private Sub GridSelectionChanged()
        If Grid.RowCount >= 0 AndAlso Grid.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = Grid.SelectedRows(0)
            ComGoldype.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colComGoldype").Value), "", (Grid.SelectedRows(0).Cells("colComGoldype").Value))
            Cob_Comp_nam.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colCob_Comp_nam").Value), "", (Grid.SelectedRows(0).Cells("colCob_Comp_nam").Value))
            ComCasher.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colComCasher").Value), "", (Grid.SelectedRows(0).Cells("colComCasher").Value))
            cmbKarat.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colcmbKarat").Value), "", (Grid.SelectedRows(0).Cells("colcmbKarat").Value))
            txtWeight.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtWeight").Value), "", (Grid.SelectedRows(0).Cells("coltxtWeight").Value))
            ComBxGoCaret999.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colComBxGoCaret999").Value), "", (Grid.SelectedRows(0).Cells("colComBxGoCaret999").Value))
            TXTGoCaret999.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colTXTGoCaret999").Value), "", (Grid.SelectedRows(0).Cells("colTXTGoCaret999").Value))
            txtQuntt.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtQuntt").Value), "", (Grid.SelectedRows(0).Cells("coltxtQuntt").Value))
            dtExpensesDate.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coldtExpensesDate").Value), "", (Grid.SelectedRows(0).Cells("coldtExpensesDate").Value))
            TxtNote.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colTxtNote").Value), "", (Grid.SelectedRows(0).Cells("colTxtNote").Value))
            txtGramPrice.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtGramPrice").Value), "", (Grid.SelectedRows(0).Cells("coltxtGramPrice").Value))
            txtGoldPrice.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtGoldPrice").Value), "", (Grid.SelectedRows(0).Cells("coltxtGoldPrice").Value))
            txtMakeCharge.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtMakeCharge").Value), "0", (Grid.SelectedRows(0).Cells("coltxtMakeCharge").Value))
            txtTMakeCharge.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtTMakeCharge").Value), "0", (Grid.SelectedRows(0).Cells("coltxtTMakeCharge").Value))
            txtTotalPrice.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("coltxtTotalPrice").Value), "", (Grid.SelectedRows(0).Cells("coltxtTotalPrice").Value))
            txtWeight.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colWeightArletters").Value), "", (Grid.SelectedRows(0).Cells("colWeightArletters").Value))
            txtWeight.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colWeightEnletters").Value), "", (Grid.SelectedRows(0).Cells("colWeightEnletters").Value))
            txtTotalPrice.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colTotalPriceArletters").Value), "", (Grid.SelectedRows(0).Cells("colTotalPriceArletters").Value))
            txtTotalPrice.Text = If(IsDBNull(Grid.SelectedRows(0).Cells("colTotalPriceEnletters").Value), "", (Grid.SelectedRows(0).Cells("colTotalPriceEnletters").Value))
        End If
    End Sub
    Private Sub CmbVoucherNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbVoucherNumber.SelectedIndexChanged
        If CmbVoucherNumberEdit = True Then
            Grid.Rows.Clear()
            Dim GetInvDetels As DataTable = GetRecordSet("SELECT * FROM ViwGoldVoucher WHERE VoucherNumber like '" & CmbVoucherNumber.Text & "'")
            If GetInvDetels.Rows.Count > 0 Then
                CivilIDForm.txtCID.Text = (GetInvDetels.Rows(0)("CivilID").ToString)
                For i As Integer = 0 To GetInvDetels.Rows.Count - 1
                    With (Grid)
                        .Rows.Add()
                        .Rows(i).Cells("colComGoldype").Value = (GetInvDetels.Rows(i)("BondTypeArName").ToString)
                        .Rows(i).Cells("colCob_Comp_nam").Value = (GetInvDetels.Rows(i)("COMP_NAME").ToString)
                        .Rows(i).Cells("colComCasher").Value = (GetInvDetels.Rows(i)("Casher").ToString)
                        .Rows(i).Cells("colcmbKarat").Value = (GetInvDetels.Rows(i)("GoldKarat").ToString)
                        .Rows(i).Cells("coltxtWeight").Value = (GetInvDetels.Rows(i)("GoldWeight").ToString)
                        .Rows(i).Cells("colComBxGoCaret999").Value = (GetInvDetels.Rows(i)("PurKarat").ToString)
                        .Rows(i).Cells("colTXTGoCaret999").Value = (GetInvDetels.Rows(i)("PurWeight").ToString)
                        .Rows(i).Cells("coltxtQuntt").Value = (GetInvDetels.Rows(i)("Qunt").ToString)
                        .Rows(i).Cells("coldtExpensesDate").Value = (GetInvDetels.Rows(i)("CreationDate").ToString)
                        .Rows(i).Cells("colTxtNote").Value = (GetInvDetels.Rows(i)("Note").ToString)
                        .Rows(i).Cells("coltxtGramPrice").Value = (GetInvDetels.Rows(i)("GramPrice").ToString)
                        .Rows(i).Cells("coltxtGoldPrice").Value = (GetInvDetels.Rows(i)("GoldPrice").ToString)
                        .Rows(i).Cells("coltxtMakeCharge").Value = (GetInvDetels.Rows(i)("MakeCharge").ToString)
                        .Rows(i).Cells("coltxtTMakeCharge").Value = (GetInvDetels.Rows(i)("TotalMakeCharge").ToString)
                        .Rows(i).Cells("coltxtTotalPrice").Value = (GetInvDetels.Rows(i)("TotalPrice").ToString)
                        .Rows(i).Cells("colCastomerid").Value = (GetInvDetels.Rows(i)("CivilID").ToString)
                        .Rows(i).Cells("colWeightArletters").Value = (GetInvDetels.Rows(i)("WeightArletters").ToString)
                        .Rows(i).Cells("colWeightEnletters").Value = (GetInvDetels.Rows(i)("WeightEnletters").ToString)
                        .Rows(i).Cells("colTotalPriceArletters").Value = (GetInvDetels.Rows(i)("TotalPriceArletters").ToString)
                        .Rows(i).Cells("colTotalPriceEnletters").Value = (GetInvDetels.Rows(i)("TotalPriceEnletters").ToString)
                        .Rows(i).Cells("colPurWeightArletters").Value = (GetInvDetels.Rows(i)("PurWeightArletters").ToString)
                        .Rows(i).Cells("colPurWeightEnletters").Value = (GetInvDetels.Rows(i)("PurWeightEnletters").ToString)
                    End With
                Next
            End If
        ElseIf CmbVoucherNumberEdit = False Then
        End If
    End Sub
    'Private Sub Grid_SelectionChanged(sender As Object, e As EventArgs) Handles Grid.SelectionChanged
    '    GridSelectionChanged()
    'End Sub
End Class
