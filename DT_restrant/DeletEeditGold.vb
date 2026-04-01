Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports PACICardLibrary
Imports System.Data.SqlClient
Public Class DeletEeditGold
    Dim EditControl As Boolean
    Dim InvNo As String
    Private Sub GetPricePerGram()
        If cmbKarat.Text.Trim = "24" Then
            txtGramPrice.Text = frmMain.lbl24BUY.Text.Trim
        ElseIf cmbKarat.Text.Trim = "22" Then
            txtGramPrice.Text = frmMain.lbl22BUY.Text.Trim
        ElseIf cmbKarat.Text.Trim = "21" Then
            txtGramPrice.Text = frmMain.lbl21BUY.Text.Trim
        ElseIf cmbKarat.Text.Trim = "18" Then
            txtGramPrice.Text = frmMain.lbl18BUY.Text.Trim
        End If
    End Sub
    Public Function CalculatePriceDifference() As Decimal
        Dim CashKnet As Decimal = Val(txtCash.Text) + Val(txtKnet.Text)
        On Error Resume Next
        For i As Decimal = 0 To grid.Rows.Count - 1
            CalculatePriceDifference += grid.Rows(i).Cells("colGoledPrice").Value
            txtTotalPriceValue.Text = Math.Round((CalculatePriceDifference), 4)
        Next
        txtPriceReturn.Text = Math.Round(CalculatePriceDifference - Val(CashKnet), 3)
        If Val(txtPriceReturn.Text) < 0 Then
            lblReturn.Text = If(frmLogin.rbtnAr.Checked = True, "ارجع الي العميل", "Return To Clients")
        ElseIf Val(txtPriceReturn.Text) > 0 Then
            lblReturn.Text = If(frmLogin.rbtnAr.Checked = True, "مطلوب من العميل", "Required Rrom The Client")
        End If
        Return CalculatePriceDifference
        Beep()
    End Function
    Private Sub EditItemInDataGrid()
        Dim UpdateRows As DataGridViewRow = grid.SelectedRows(0)
        UpdateRows.Cells("colCastomerid").Value = CivilIDForm.txtCID.Text.Trim()
        UpdateRows.Cells("colGoldWeight").Value = Val(txtWeight.Text)
        UpdateRows.Cells("colGramPrice").Value = Val(txtGramPrice.Text)
        UpdateRows.Cells("colGoledKarat").Value = Val(cmbKarat.Text)
        UpdateRows.Cells("colGoledPrice").Value = Val(txtPrice.Text)
        UpdateRows.Cells("colGoledNetKarat").Value = ComBxGoCaret999.Text.Trim
        UpdateRows.Cells("colGoldNetWeight").Value = TXTGoCaret999.Text.Trim
        UpdateRows.Cells("colGoledPiecesQuantity").Value = txtQunt.Text.Trim
        UpdateRows.Cells("colItemName").Value = TeBoxItem_Des.Text.Trim
        UpdateRows.Cells("colAddToItem").Value = If(chkAddToItem.Checked = True, 1, 0)
        UpdateRows.Cells("colcacher").Value = cmbCashier.SelectedValue
        UpdateRows.Cells("coldate").Value = DateToSave(dtDate.Value)
        UpdateRows.Cells("colNots").Value = txtNotes.Text.Trim
        UpdateRows.Cells("colInvId").Value = InvNo.Trim
        UpdateRows.Cells("colInvocDateTime").Value = Format(dtDate.Value, "dd/MM/yyyy hh:mm")
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        GlCommand.CommandText = "UPDATE [Buy_Gold] SET [castomer_id] = '" & CivilIDForm.txtCID.Text.Trim() & "'" &
                                ",[bay_val] = '" & grid.SelectedRows(0).Cells("colGoledKarat").Value & "'" &
                                ",[bay_mazan] = '" & grid.SelectedRows(0).Cells("colGoldWeight").Value & "'" &
                                ",[bay_gram_price] = '" & grid.SelectedRows(0).Cells("colGramPrice").Value & "'" &
                                ",[bay_total_price] = '" & grid.SelectedRows(0).Cells("colGoledPrice").Value & "'" &
                                ",[inv_id] = '" & InvNo.Trim & "'" &
                                ",[Item_Des] = N'" & If(IsDBNull(grid.SelectedRows(0).Cells("colItemName").Value), "ـــــــــ", grid.SelectedRows(0).Cells("colItemName").Value & "'" &
                                ",[INV_Actv] = '1'" & vbCrLf &
                                ",[AddToItem] = '" & If(chkAddToItem.Checked = True, 1, 0) & "'" &
                                ",[GoldWeight999] = '" & grid.SelectedRows(0).Cells("colGoldNetWeight").Value & "'" &
                                ",[Qunt] = '" & grid.SelectedRows(0).Cells("colGoledPiecesQuantity").Value & "'" &
                                ",[GoldCaret999] = '" & grid.SelectedRows(0).Cells("colGoledNetKarat").Value & "'" &
                                " WHERE [inv_id]='" & (grid.SelectedRows(0).Cells("colInvId").Value) & "'AND B_gold_id= '" & (grid.SelectedRows(0).Cells("colID").Value) & "'")
        GlCommand.ExecuteNonQuery()
        'تحديث الملاحظه
        GlCommand.CommandText = ("UPDATE [Buy_Gold]SET [Note] =N'" & txtNotes.Text.Trim & "' WHERE  [inv_id]='" & InvNo.Trim & "'")
        GlCommand.ExecuteNonQuery()
        ' تحديث الرقم المدني
        GlCommand.CommandText = "UPDATE [Buy_Gold] SET [castomer_id] = '" & CivilIDForm.txtCID.Text.Trim() & "'" &
                               " WHERE [inv_id]='" & InvNo.Trim & "'"
        GlCommand.ExecuteNonQuery()
        CalculatePriceDifference()
        'تحديث الكاشير
        GlCommand.CommandText = ("UPDATE [bay_goled_mony]SET [Cashier] ='" & cmbCashier.SelectedValue & "' WHERE  [saryal]='" & InvNo.Trim & "'")
        GlCommand.ExecuteNonQuery()

        MsgBox("تم تعديل الصنف " & vbCrLf & "Item Edit successfully", , AppTitle)


        BtnSaveEdte.Text = If(frmLogin.rbtnAr.Checked = True, "اضافة صنف ", "Add New Items")
        txtWeight.Clear()
        TXTGoCaret999.Clear()
        txtQunt.Clear()
        txtGramPrice.Clear()
        txtPrice.Clear()
        txtNotes.Clear()
        TeBoxItem_Des.Text = ""
        EditControl = False
    End Sub
    Private Sub GoldWeight()
        Dim GoledCart As Decimal = Val(cmbKarat.Text) / 24 * 1000
        Try
            TXTGoCaret999.Text = If(IsDBNull(txtWeight.Text), 0, Val(txtWeight.Text) * Val(GoledCart / ComBxGoCaret999.Text).ToString("#,###,###,###.000"))
        Catch ex As Exception
            'Return
        End Try
    End Sub
#Region "GetPayMethodSelect"
    Private Sub GetPayMethodSelect()
        Dim DT1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If DT1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = DT1
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
    End Sub
    Private Sub GetPayMethod()
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = dt1
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
        GetPayMethodSelect()
    End Sub
#End Region

    Private Sub Get_Casher_Data()
        'Try
        Dim DT As DataTable = GetRecordSet("SELECT * FROM cacher where Active=1")
        If DT.Rows.Count > 0 Then
            cmbCashier.DataSource = DT
            cmbCashier.DisplayMember = "cacher_name"
            cmbCashier.ValueMember = "cacherID"
        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        'End Try
    End Sub
#Region "FillComboBox"
    Public Sub GoldCaret()
        GetFillComboBox(ComboBoxName:=cmbKarat, DisMem:="Gram_valu", SqlCom:=("SELECT Gram_valu FROM Gram_val GROUP BY Gram_valu ORDER BY Gram_valu DESC"), ValMem:="Gram_valu")

    End Sub
    Public Sub GetItemName()
        GetFillComboBox(ComboBoxName:=TeBoxItem_Des, DisMem:="Item_Des", SqlCom:=("SELECT Item_Des FROM dbo.Buy_Gold GROUP BY Item_Des"), ValMem:="Item_Des")
    End Sub
    Public Sub GoldCaretNet()
        GetFillComboBox(ComboBoxName:=ComBxGoCaret999, DisMem:="FractionValues", SqlCom:=("SELECT FractionValues FROM Gram_val GROUP BY FractionValues ORDER BY FractionValues DESC"), ValMem:="FractionValues")
    End Sub
#End Region
    Private Sub DeletEeditGold_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnSaveEdte.Text = If(frmLogin.rbtnAr.Checked = True, "اضافة صنف", "Add New Item")
        GetPayMethod()
        GoldCaret()
        GoldCaretNet()
        GetItemName()
        cmbKarat.SelectedValue = "21"
        Get_Casher_Data()
        ControlsAsColor(ColorSelect:=Me)
         DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
        CheckUserPermissions(UserID)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        language_start(Name)
        CivilIDForm = New CivilID
        CivilIDForm.gbCustomerData.BackColor = Color.FromArgb(64, 64, 64)
        CivilIDForm.Bounds = New Rectangle(2, 40, 995, 255)
        Controls.Add(CivilIDForm)
        CardServiceStart()
        paci = New PACMAN
        frmMain.Timer1.Stop()
        BackgroundWorker1.RunWorkerAsync()
        grid.Enabled = True
        CivilIDForm.txtCID.Text = ""
        btnDeleteInvoice.Enabled = False
        btnSave.Enabled = False
        btnPayPrint.Enabled = False
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'BtnSaveEdte.Enabled = False
        txtPriceReturn.Text = "000.000"
        dtDate.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub FillDataGred()
        grid.Rows.Clear()
        Dim GetInvoceDetels As DataTable = GetRecordSet("SELECT * FROM  ReportGoldBuyInvoice WHERE (INV_Actv_bay = 1) AND (INV_Actv = 1) AND (inv_id = N'" & txtInvoiceNo.Text.Trim & "')")
        If GetInvoceDetels.Rows.Count > 0 Then
            For i As Integer = 0 To GetInvoceDetels.Rows.Count - 1
                With (grid)
                    .Rows.Add()
                    .Rows(i).Cells("colID").Value = (GetInvoceDetels.Rows(i)("B_gold_id").ToString)
                    .Rows(i).Cells("colInvId").Value = (GetInvoceDetels.Rows(i)("inv_id").ToString)
                    .Rows(i).Cells("colItemName").Value = GetInvoceDetels.Rows(i)("Item_Des").ToString
                    .Rows(i).Cells("colGoldWeight").Value = GetInvoceDetels.Rows(i)("bay_mazan").ToString
                    .Rows(i).Cells("colGramPrice").Value = GetInvoceDetels.Rows(i)("bay_gram_price").ToString
                    .Rows(i).Cells("colGoledPrice").Value = GetInvoceDetels.Rows(i)("bay_total_price").ToString
                    .Rows(i).Cells("colGoledKarat").Value = GetInvoceDetels.Rows(i)("bay_val").ToString
                    .Rows(i).Cells("colGoledPiecesQuantity").Value = GetInvoceDetels.Rows(i)("Qunt").ToString
                    .Rows(i).Cells("colInvocDateTime").Value = GetInvoceDetels.Rows(i)("TIME_INV").ToString
                    .Rows(i).Cells("colGoledNetKarat").Value = GetInvoceDetels.Rows(i)("GoldCaret999").ToString
                    .Rows(i).Cells("colGoldNetWeight").Value = GetInvoceDetels.Rows(i)("GoldWeight999").ToString
                    .Rows(i).Cells("colAddToItem").Value = GetInvoceDetels.Rows(i)("AddToItem")
                End With
            Next
        End If
        For i = 0 To grid.Rows.Count - 1
            If grid.Rows(i).Cells("colAddToItem").Value = "1" Then
                grid.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed
                grid.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
        cmbCashier.SelectedValue = GetInvoceDetels.Rows(0)("Cashier").ToString
        CivilIDForm.txtCID.Text = GetInvoceDetels.Rows(0)("castomer_id").ToString
        dtDate.Value = CDate(GetInvoceDetels.Rows(0)("date").ToString)
        txtTotalPriceValue.Text = GetInvoceDetels.Rows(0)("total_price").ToString
        txtNotes.Text = GetInvoceDetels.Rows(0)("Note").ToString
        txtCash.Text = GetInvoceDetels.Rows(0)("cach").ToString
        txtKnet.Text = GetInvoceDetels.Rows(0)("kenet").ToString
        cmbPayMethod.SelectedValue = GetInvoceDetels.Rows(0)("PayMethod").ToString
        btnDeleteInvoice.Enabled = True
        btnSave.Enabled = True
        CalculatePriceDifference()
    End Sub
    Private Sub GetInvoiceNumber()
        Dim dt1 As DataTable = GetRecordSet("SELECT  saryal  FROM bay_goled_mony WHERE (INV_Actv = 1) ORDER BY bay_id DESC")
        If dt1.Rows.Count > 0 Then
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.DataSource = dt1)
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.DisplayMember = "saryal")
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.ValueMember = "saryal")
        End If
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        GetInvoiceNumber()
    End Sub
    Private Sub grid_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs)

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        'If txtInvoiceNo.SelectedItem = -1 Then
        '    MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
        '    txtInvoiceNo.Focus()
        '    Exit Sub
        'End If
        'Try
        '    InvNo = txtInvoiceNo.Text.TrimEnd
        '    FillDataGred()
        'Catch ex As Exception
        '    MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
        'End Try



        'If txtInvoiceNo.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(txtInvoiceNo.Text) Then
        '    MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
        '    txtInvoiceNo.Focus()
        '    Exit Sub
        'End If

        Try
            InvNo = txtInvoiceNo.Text.Trim()
            FillDataGred()
        Catch ex As Exception
        'MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
        txtInvoiceNo.Focus()
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grid.Rows.Clear()
    End Sub

    Private Sub grid_CellPainting_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "colModify" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Search, CInt((e.CellBounds.Width / 2) - (My.Resources.Search.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Search.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Private Sub grid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellClick
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            If grid.Rows.Count > 1 Then
                If MsgBox("هل تريد حذف القطعة" & grid.Rows(e.RowIndex).Cells("colID").Value & grid.Rows(e.RowIndex).Cells("colItemName").Value & " ? " & vbCrLf & "Do You Want to Delete Item " & grid.Rows(e.RowIndex).Cells("colID").Value & grid.Rows(e.RowIndex).Cells("colItemName").Value, vbYesNo) = vbYes Then
                    Try
                        GlCommand.CommandText = ("UPDATE [Buy_Gold] SET INV_Actv='0' WHERE inv_id='" & (grid.SelectedRows(0).Cells("colInvId").Value) & "'AND B_gold_id= '" & (grid.SelectedRows(0).Cells("colID").Value) & "'")
                        GlCommand.ExecuteNonQuery()
                        grid.Rows.RemoveAt(grid.CurrentRow.Index)
                        Beep()
                        CalculatePriceDifference()
                        If grid.Rows.Count = 0 Then
                            cmbCashier.Enabled = True
                            CivilIDForm.txtCID.Enabled = True
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            ElseIf grid.Rows.Count = 1 Then
                If MsgBox("سوف يتم حذف كامل بيانات الفاتورة اضغط نعم للاستمرار أو إلغاء الامر" & vbCrLf & "Whole invoice will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! عند حذف كامل بيانات الفاتورة لايمكن استرجاعها" & vbCrLf & "Warning! Deleted invoices can not be undone.") = MsgBoxResult.Ok Then
                    GlCommand.CommandText = ("UPDATE [Buy_Gold] SET INV_Actv='0' WHERE inv_id='" & (grid.SelectedRows(0).Cells("colInvId").Value) & "'AND B_gold_id= '" & (grid.SelectedRows(0).Cells("colID").Value) & "'")
                    GlCommand.ExecuteNonQuery()
                    grid.Rows.RemoveAt(grid.CurrentRow.Index)
                    'txtTotalPriceValue.Text = CalculateTotalGridPrice()
                    GlCommand.CommandText = ("UPDATE [bay_goled_mony] SET INV_Actv='0' WHERE saryal='" & txtInvoiceNo.Text.Trim & "'")
                    GlCommand.ExecuteNonQuery()
                    If grid.Rows.Count = 0 Then
                        cmbCashier.Enabled = True
                        CivilIDForm.txtCID.Enabled = True
                        CalculatePriceDifference()
                    Else
                        MsgBox("تم إلغاء الحذف" & vbCrLf & "Delete Cancelled.", , AppTitle)
                        Beep()
                    End If
                End If
            End If
        ElseIf grid.Columns(e.ColumnIndex).Name = "colModify" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد تعديل القطعة رقم " & grid.Rows(e.RowIndex).Cells("colID").Value & grid.Rows(e.RowIndex).Cells("colItemName").Value & " ? " & vbCrLf & "Do You Want to Modify Item No. " & grid.Rows(e.RowIndex).Cells("colID").Value & grid.Rows(e.RowIndex).Cells("colItemName").Value, vbYesNo) = vbYes Then
                Try
                    'txtBarCode.Enabled = False
                    'EditControl = True
                    TeBoxItem_Des.Text = grid.Rows(e.RowIndex).Cells("colItemName").Value
                    cmbKarat.SelectedValue = grid.Rows(e.RowIndex).Cells("colGoledKarat").Value
                    txtWeight.Text = grid.Rows(e.RowIndex).Cells("colGoldWeight").Value
                    ComBxGoCaret999.SelectedValue = grid.Rows(e.RowIndex).Cells("colGoledNetKarat").Value
                    TXTGoCaret999.Text = grid.Rows(e.RowIndex).Cells("colGoldNetWeight").Value
                    txtQunt.Text = grid.Rows(e.RowIndex).Cells("colGoledPiecesQuantity").Value
                    txtGramPrice.Text = grid.Rows(e.RowIndex).Cells("colGramPrice").Value
                    txtPrice.Text = grid.Rows(e.RowIndex).Cells("colGoledPrice").Value
                    chkAddToItem.Checked = grid.Rows(e.RowIndex).Cells("colAddToItem").Value
                    CalculatePriceDifference()
                    BtnSaveEdte.Enabled = True
                    EditControl = True
                    BtnSaveEdte.Text = If(frmLogin.rbtnAr.Checked = True, "حفظ التعديل", "Save Edits")
                    If grid.Rows.Count = 0 Then
                        cmbCashier.Enabled = True
                        CivilIDForm.txtCID.Enabled = True
                    End If
                    
                    'cmbItem.Enabled = False
                Catch ex As Exception
                    MsgBox(ex.Message, , AppTitle)
                End Try
            End If
        End If
    End Sub

    Private Sub DeletEeditGold_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Timer1.Start()
        sc.Dispose()
        Dispose()
    End Sub

    Private Sub DeletEeditGold_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Timer1.Start()
        sc.Dispose()
        Dispose()
    End Sub

    Private Sub cmbCashier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCashier.SelectedIndexChanged

    End Sub
    Private Sub DeleteInvoice()
        GlCommand.CommandText = "UPDATE [bay_goled_mony] SET [INV_Actv] ='0' WHERE [saryal] = '" & txtInvoiceNo.Text.Trim & "'"
        GlCommand.ExecuteNonQuery()
        GlCommand.CommandText = "UPDATE [Buy_Gold] SET [INV_Actv] ='0' WHERE [inv_id]='" & txtInvoiceNo.Text.Trim & "'"
        GlCommand.ExecuteNonQuery()
    End Sub
    Private Sub btnDeleteInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteInvoice.Click
        If MsgBox("سوف يتم حذف كامل بيانات الفاتورة اضغط نعم للاستمرار أو إلغاء الامر" & vbCrLf & "Whole invoice will be deleted..Click OK to delete or Cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "انتبه ! عند حذف كامل بيانات الفاتورة لايمكن استرجاعها" & vbCrLf & "Warning! Deleted invoices can not be undone.") = MsgBoxResult.Ok Then
            DeleteInvoice()
            Beep()
            'Close()
        Else
            MsgBox("تم إلغاء الحذف" & vbCrLf & "Delete Cancelled.", , AppTitle)
            Beep()
            Exit Sub
        End If
    End Sub

    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub
    Public Sub AddNewItemInDataGred()
        Dim CID As String = CivilIDForm.txtCID.Text.Trim
        If CivilIDForm.SaveCustomerData() = False Then
            Exit Sub
        Else
            CivilIDForm.txtCID.Enabled = False
        End If
        If txtWeight.Text = "" Then
            MsgBox("أدخل الوزن" & vbCrLf & "Enter Weight", , AppTitle)
            txtWeight.SelectAll()
            txtWeight.Focus()
            Exit Sub
        End If

        If txtGramPrice.Text = "" Then
            MsgBox("أدخل سعر الجرام" & vbCrLf & "Enter Gram Price", , AppTitle)
            txtGramPrice.SelectAll()
            txtGramPrice.Focus()
            Exit Sub
        End If

        If txtPrice.Text = "" Then
            MsgBox("لايمكن ترك قيمة إجمالي المبلغ فارغة" & vbCrLf & "Total Price Can't be empty", , AppTitle)
            txtPrice.SelectAll()
            txtPrice.Focus()
            Exit Sub
        End If

        If CivilIDForm.txtCID.Text.Trim = "" OrElse IsNumeric(CivilIDForm.txtCID.Text.Trim) = False Then
            MsgBox("أدخل الرقم المدني للعميل أولا" & vbCrLf & "Add Customer Details First.", , AppTitle)
            CivilIDForm.txtCID.SelectAll()
            CivilIDForm.txtCID.Focus()
            Exit Sub
        End If

        If Val(txtPrice.Text) > Val(txtGramPrice.Text) * Val(txtWeight.Text) Then
            If MsgBox("سعر شراء الجرام أكبر من سعر الجرام الحالي، هل تريد الشراء؟" & vbCrLf & "Purchase Price per Gram is More than Gram Price..Proceed with Purchase?", vbYesNo, AppTitle) = vbNo Then
                Exit Sub
            End If
        End If

        'Try
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btnPayPrint.Enabled = True
        With (grid)
            .Rows.Add()
            .Rows(.Rows.Count - 1).Cells("colCastomerid").Value = CivilIDForm.txtCID.Text.Trim()
            .Rows(.Rows.Count - 1).Cells("colGoldWeight").Value = Val(txtWeight.Text)
            .Rows(.Rows.Count - 1).Cells("colGramPrice").Value = Val(txtGramPrice.Text)
            .Rows(.Rows.Count - 1).Cells("colGoledKarat").Value = Val(cmbKarat.Text)
            .Rows(.Rows.Count - 1).Cells("colGoledPrice").Value = Val(txtPrice.Text)
            .Rows(.Rows.Count - 1).Cells("colGoledNetKarat").Value = If(IsDBNull(ComBxGoCaret999.Text.Trim), "999", Val(ComBxGoCaret999.Text.Trim))
            .Rows(.Rows.Count - 1).Cells("colGoldNetWeight").Value = If(IsDBNull(TXTGoCaret999.Text.Trim), "0", Val(TXTGoCaret999.Text.Trim))
            .Rows(.Rows.Count - 1).Cells("colGoledPiecesQuantity").Value = txtQunt.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colItemName").Value = TeBoxItem_Des.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colAddToItem").Value = If(chkAddToItem.Checked = True, 1, 0)
            .Rows(.Rows.Count - 1).Cells("colcacher").Value = cmbCashier.SelectedValue
            .Rows(.Rows.Count - 1).Cells("coldate").Value = DateToSave(dtDate.Value)
            .Rows(.Rows.Count - 1).Cells("colNots").Value = txtNotes.Text.Trim
            .Rows(.Rows.Count - 1).Cells("colInvId").Value = InvNo.Trim
            .Rows(.Rows.Count - 1).Cells("colInvocDateTime").Value = Format(dtDate.Value, "dd/MM/yyyy hh:mm:ss")
        End With
        Dim totala As Decimal
        For i As Decimal = 0 To grid.Rows.Count - 1
            totala += grid.Rows(i).Cells("colGoledPrice").Value
            txtTotalPriceValue.Text = totala
        Next
        Saved = False 'لم يتم استكمال تفاصيل الدفع
        chkAddToItem.Checked = False
        For i = 0 To grid.Rows.Count - 1
            If grid.Rows(i).Cells("colAddToItem").Value = "1" Then
                grid.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed
                grid.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            End If
        Next
        For i = 0 To grid.Rows.Count - 1
            grid.Rows(i).Cells("colNots").Value = txtNotes.Text.Trim
        Next

        Try
            grid.CurrentCell = grid(0, grid.Rows.Count - 1)
            GlCommand.CommandText = "INSERT INTO  [Buy_Gold]" &
                                                                 "([castomer_id]" &
                                                                 " ,[bay_val]" &
                                                                 " ,[bay_mazan]" &
                                                                 " ,[bay_gram_price]" &
                                                                 " ,[bay_total_price]" &
                                                                 " ,[inv_id]" &
                                                                 " ,[Item_Des]" &
                                                                 " ,[INV_Actv]" &
                                                                 " ,[AddToItem]" &
                                                                 " ,[Note]" &
                                                                 " ,[GoldWeight999]" &
                                                                 " ,[GoldCaret999]" &
                                                                 " ,[Qunt])" &
                                                                 " VALUES" &
                                                                 " (@castomer_id " &
                                                                 " ,@bay_val " &
                                                                 " ,@bay_mazan " &
                                                                 " ,@bay_gram_price " &
                                                                 " ,@bay_total_price " &
                                                                 " ,@inv_id " &
                                                                 " ,@Item_Des " &
                                                                 " ,@INV_Actv" &
                                                                 " ,@AddToItem" &
                                                                 " ,@Note" &
                                                                 " ,@GoldWeight999" &
                                                                 " ,@GoldCaret999" &
                                                                 " ,@Qunt)"

            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@castomer_id", CivilIDForm.txtCID.Text.Trim())
                .AddWithValue("@bay_val", grid.SelectedRows(0).Cells("colGoledKarat").Value)
                .AddWithValue("@bay_mazan", grid.SelectedRows(0).Cells("colGoldWeight").Value)
                .AddWithValue("@bay_gram_price", grid.SelectedRows(0).Cells("colGramPrice").Value)
                .AddWithValue("@bay_total_price", grid.SelectedRows(0).Cells("colGoledPrice").Value)
                .AddWithValue("@inv_id", InvNo.Trim)
                .AddWithValue("@Item_Des", grid.SelectedRows(0).Cells("colItemName").Value)
                .AddWithValue("@INV_Actv", "1")
                .AddWithValue("@AddToItem", grid.SelectedRows(0).Cells("colAddToItem").Value)
                .AddWithValue("@Note", grid.SelectedRows(0).Cells("colNots").Value)
                .AddWithValue("@GoldWeight999", grid.SelectedRows(0).Cells("colGoldNetWeight").Value)
                .AddWithValue("@GoldCaret999", grid.SelectedRows(0).Cells("colGoledNetKarat").Value)
                .AddWithValue("@Qunt", grid.SelectedRows(0).Cells("colGoledPiecesQuantity").Value)
            End With
            GlCommand.ExecuteNonQuery()
            MsgBox("تم إضافة الصنف " & vbCrLf & "Item Added successfully", , AppTitle)
            BtnSaveEdte.Text = If(frmLogin.rbtnAr.Checked = True, "اضافة صنف ", "Add New Items")
            txtWeight.Clear()
            TXTGoCaret999.Clear()
            txtQunt.Clear()
            txtGramPrice.Clear()
            txtPrice.Clear()
            txtNotes.Clear()
            TeBoxItem_Des.Text = ""
        Catch ex As Exception
            ex.ToString()
            MsgBox("DB-NOT-CON")
            Return
        End Try
    End Sub
    Private Sub BtnSaveEdte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveEdte.Click
        If EditControl = True Then
            EditItemInDataGrid()
            CalculatePriceDifference()
            EditControl = False
        ElseIf EditControl = False Then
            AddNewItemInDataGred()
            CalculatePriceDifference()
            'BtnSaveEdte.Text = If(frmLogin.rbtnAr.Checked = True, "اضافة صنف ", "Add New Items")
        End If
    End Sub

    Private Sub cmbKarat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKarat.SelectedIndexChanged
        GetPricePerGram()
        GoldWeight()
    End Sub

    Private Sub txtWeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWeight.TextChanged
        GoldWeight()
    End Sub

    Private Sub Bay_gram_priceLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Bay_gram_priceLabel.LinkClicked
        If Val(txtWeight.Text) = 0 Then
            MsgBox("يرجى إدخال الوزن" & vbCrLf & "Please Enter Weight")
            txtWeight.SelectAll()
            txtWeight.Focus()
            Exit Sub
        End If
        If Val(txtPrice.Text) = 0 Then
            MsgBox("يرجى إدخال السعر" & vbCrLf & "Please Enter Price")
            txtPrice.SelectAll()
            txtPrice.Focus()
            Exit Sub
        End If
        txtGramPrice.Text = Math.Round(Val(txtPrice.Text) / Val(txtWeight.Text), 3)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'txtPrice.Text = Math.Round(Val(txtWeight.Text) * Val(txtGramPrice.Text), 3)
        If Val(txtWeight.Text) = 0 Then
            MsgBox("يرجى إدخال الوزن" & vbCrLf & "Please Enter Weight")
            Exit Sub
        End If
        If Val(txtGramPrice.Text) = 0 Then
            MsgBox("يرجى إدخال سعر الجرام" & vbCrLf & "Please Enter Price Per Gram")
            txtGramPrice.SelectAll()
            txtGramPrice.Focus()
            Exit Sub
        End If
        txtPrice.Text = Math.Round(Val(txtWeight.Text) * Val(txtGramPrice.Text), 3)
    End Sub

    Private Sub ComBxGoCaret999_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComBxGoCaret999.SelectedIndexChanged
        GoldWeight()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        grid.CurrentCell = grid(0, grid.Rows.Count - 1)
        MsgBox((grid.SelectedRows(0).Cells("colItemName").Value))
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtInvoiceNo.Text = "" Then
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
            txtInvoiceNo.Focus()
            Exit Sub
        End If
        CalculatePriceDifference()
        If Val(txtCash.Text) < 0 OrElse Val(txtKnet.Text) < 0 Then
            MsgBox("لا يمكن إدخال أرقام سالبة" & vbCrLf & "You Can't Enter Negative Values", , "خطأ")
            Exit Sub
        End If
        If Val(txtCash.Text) + Val(txtKnet.Text) <> Val(txtTotalPriceValue.Text) OrElse Val(txtCash.Text) < 0 OrElse Val(txtKnet.Text) < 0 Then
            MsgBox("إجمالي السعر لا يساوي مجموع الكاش والكي نت" & vbCrLf & "Total Price is NOT Equal to Cash And K-NET", , "خطأ")
            Exit Sub
        End If
        GlCommand.CommandText = "UPDATE [bay_goled_mony] SET [total_price] = '" & Val(txtTotalPriceValue.Text.Trim) & "'" &
                              ",[cach] = '" & If(IsDBNull(txtCash.Text.Trim), "0", Val(txtCash.Text.Trim)) & "'" &
                              ",[kenet] = '" & If(IsDBNull(txtKnet.Text.Trim), "0", Val(txtKnet.Text.Trim)) & "'" &
                              ",[arabik] = N'" & kokotxt(Val(txtTotalPriceValue.Text), CurrencyMainAr, CurrencySubAr, True) & "'" &
                              ",[date] = '" & DateToSave(dtDate.Value) & "'" &
                              ",[English] = '" & ConvertNumberToENG(txtTotalPriceValue.Text.Trim) & "'" &
                              ",[TIME_INV] = '" & Format(dtDate.Value, "dd/MM/yyyy hh:mm:ss") & "'" &
                              ",[PayMethod] = '" & cmbPayMethod.SelectedValue & "'" &
                              "WHERE [saryal]='" & txtInvoiceNo.Text.Trim & "'"
        GlCommand.ExecuteNonQuery()
        GlCommand.CommandText = "UPDATE [Buy_Gold] SET [castomer_id] ='" & CivilIDForm.txtCID.Text.Trim & "' WHERE [inv_id]='" & txtInvoiceNo.Text.Trim & "'"
        GlCommand.ExecuteNonQuery()
        btnPayPrint.Enabled = True
        MsgBox("تم تعديل الفاتوره" & vbCrLf & "The invoice has been Modified.")
    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCash.TextChanged
        CalculatePriceDifference()
    End Sub

    Private Sub txtKnet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKnet.TextChanged
        CalculatePriceDifference()
    End Sub

    Private Sub btnPayPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayPrint.Click
        CalculatePriceDifference()
        If Val(txtCash.Text) < 0 OrElse Val(txtKnet.Text) < 0 Then
            MsgBox("لا يمكن إدخال أرقام سالبة" & vbCrLf & "You Can't Enter Negative Values", , "خطأ")
            Exit Sub
        End If
        If Val(txtCash.Text) + Val(txtKnet.Text) <> Val(txtTotalPriceValue.Text) OrElse Val(txtCash.Text) < 0 OrElse Val(txtKnet.Text) < 0 Then
            MsgBox("إجمالي السعر لا يساوي مجموع الكاش والكي نت" & vbCrLf & "Total Price is NOT Equal to Cash And K-NET", , "خطأ")
            Exit Sub
        End If
        If txtInvoiceNo.Text = "" Then
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
            txtInvoiceNo.Focus()
            Exit Sub
        End If
        btnPayPrint.Enabled = True
        Try
            With GoldViewBuyInvoice
                .txtInvoiceNo.Text = txtInvoiceNo.Text.Trim
                .txtInvoiceNo.Enabled = False
                .ViwInv()
                .ReportViewer.RefreshReport()
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox("أدخل رقم الفاتورة" & vbCrLf & "Enter Invoice No.", , AppTitle)
        End Try
    End Sub
    '""
End Class