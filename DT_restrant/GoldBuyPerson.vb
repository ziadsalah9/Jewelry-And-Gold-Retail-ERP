Imports PACICardLibrary
Imports System.IO
Public Class GoldBuyPerson
    Private InvoiceNo As String
    Public CurrentInvoiceNo As String = "0"
    Dim DATETIME As Date = Date.Now
    Public Sub for_sum()
        Dim totala As Decimal
        For i As Decimal = 0 To grid.Rows.Count - 1
            totala += grid.Rows(i).Cells("colTotalPrice").Value
            TextBox3.Text = totala
        Next
    End Sub
    Dim total As Decimal
    Public a As Integer
    Public dte As Date
    Public Sub GetNameCacher()
        Dim DtGetNameCacher As DataTable = GetRecordSet("SELECT * FROM [cacher] where [Active]=1")
        If DtGetNameCacher.Rows.Count > 0 Then
            cmbCashier.DataSource = DtGetNameCacher
            cmbCashier.DisplayMember = "cacher_name"
            cmbCashier.ValueMember = "svil_id"
        End If
    End Sub
    Public Sub GetItemName()
        Dim DtGetName As DataTable = GetRecordSet("SELECT Item_Des FROM  Buy_Gold GROUP BY Item_Des")
        If DtGetName.Rows.Count > 0 Then
            TeBoxItem_Des.DataSource = DtGetName
            TeBoxItem_Des.DisplayMember = "Item_Des"
        End If
    End Sub
    Private Sub GoldBuyPerson_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
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
    Private Sub GoldBuyPerson_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        GredDsin(grid)
        chkAddToItem.Checked = False
        GetNameCacher()
        GetData()
        GoldCaret()
        ControlsAsColor(ColorSelect:=Me)
        GetItemName()
        language_start(Name)
        Visible = False
        'txtGramPrice.Text = gold21
        btnPayPrint.Enabled = False
        'GoldOrSilver()
        'If GoldOrSilver = True Then
        '    Gram_valTableAdapter.Fill(DT_restrantDataSet.Gram_val)
        '    GramvalBindingSource.Filter = "Gram_Valu <='24'"
        'Else
        '    'Gram_valTableAdapter.Fill(DT_restrantDataSet.Gram_val)
        '    'GramvalBindingSource.Filter = "Gram_Valu >='700'"
        'End If
        AddTextBox.Text = "1"
        EditForm = False
        CivilIDForm = New CivilID With {.Bounds = New Rectangle(2, 0, 995, 350)}
        Controls.Add(CivilIDForm)
        Try
            CardServiceStart()
            paci = New PACMAN
        Catch ex As Exception
            MsgBox(ex.Message)
            RecordRrrors(ex.ToString)
        End Try
        Visible = True
        CivilIDForm.txtCID.SelectAll()
        CivilIDForm.txtCID.Focus()
        TeBoxItem_Des.Text = ""
        GetPricePerGram()
        cmbKarat.SelectedIndex = 0
    End Sub



    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
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

        Try
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            btnPayPrint.Enabled = True
            With (grid)
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells("colcastomer_id").Value = CivilIDForm.txtCID.Text.Trim()
                .Rows(.Rows.Count - 1).Cells("colbay_mazan").Value = Val(txtWeight.Text)
                .Rows(.Rows.Count - 1).Cells("colbay_gram_price").Value = Val(txtGramPrice.Text)
                .Rows(.Rows.Count - 1).Cells("colbay_val").Value = Val(cmbKarat.Text)
                .Rows(.Rows.Count - 1).Cells("colTotalPrice").Value = Val(txtPrice.Text)
                .Rows(.Rows.Count - 1).Cells("colItem_Des").Value = TeBoxItem_Des.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colGoldCaret999").Value = If(IsDBNull(ComBxGoCaret999.Text.Trim), "999", Val(ComBxGoCaret999.Text.Trim))
                .Rows(.Rows.Count - 1).Cells("colGoldWeight999").Value = If(IsDBNull(TXTGoCaret999.Text.Trim), "0", Val(TXTGoCaret999.Text.Trim))
                .Rows(.Rows.Count - 1).Cells("colQunt").Value = txtQunt.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colItem_Des").Value = TeBoxItem_Des.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colQunt").Value = txtQunt.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colAddToItem").Value = If(chkAddToItem.Checked = True, 1, 0)
                .Rows(.Rows.Count - 1).Cells("colCashier").Value = cmbCashier.SelectedValue
            End With

            msgdin()
            Dim totala As Decimal
            For i As Decimal = 0 To grid.Rows.Count - 1
                totala += grid.Rows(i).Cells("colTotalPrice").Value
                TextBox3.Text = totala
            Next
            Saved = False 'لم يتم استكمال تفاصيل الدفع
        Catch ex As Exception
            MsgBox(ex.Message)
            RecordRrrors(ex.ToString)
            Exit Sub
        End Try
        chkAddToItem.Checked = False
        For i = 0 To grid.Rows.Count - 1
            If grid.Rows(i).Cells("colAddToItem").Value = "1" Then
                grid.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed
                grid.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            End If
        Next

        For i = 0 To grid.Rows.Count - 1
            grid.Rows(i).Cells("colNote").Value = txtNote.Text.Trim
        Next

        txtWeight.Text = 0
        txtGramPrice.Text = 0
        txtPrice.Text = 0
        TeBoxItem_Des.Text = ""
        txtQunt.Text = ""
    End Sub
    Private Sub btnPayPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPayPrint.Click

        If grid.RowCount = 0 Then
            btnSave.PerformClick()
        End If
        With GoldBuyPersonPay
            .lblPrice.Text = Val(TextBox3.Text)
            .ShowDialog()
        End With
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Buy_GoldBindingSource.MovePrevious()
    End Sub

    Private Sub cmbKarat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub cmbCarat_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        btnSave.Enabled = True
        cmbKarat.Enabled = True
        txtWeight.Enabled = True
        txtGramPrice.Enabled = True
        grid.Enabled = True
        'btnPrice.Enabled = True
        'btnPricePerGram.Enabled = True
        GetPricePerGram()
        'Dim CaretChnge As Decimal
        'If Val(ComBxGoCaret999.Text) < 100 Then
        '    CaretChnge = Val(cmbKarat.Text) / 24 * 1000
        '    ComBxGoCaret999.Text = Val(CaretChnge)
        'Else
        'End If
        GoldWeight()
    End Sub
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

    Private Sub btnGP_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Val(txtWeight.Text) = 0 Then
            'MsgBox("يرجى إدخال الوزن" & vbCrLf & "Please Enter Weight")
            txtWeight.SelectAll()
            txtWeight.Focus()
            Exit Sub
        End If
        If Val(txtPrice.Text) = 0 Then
            'MsgBox("يرجى إدخال السعر" & vbCrLf & "Please Enter Price")
            txtPrice.SelectAll()
            txtPrice.Focus()
            Exit Sub
        End If
        txtGramPrice.Text = Val(txtPrice.Text) / Val(txtWeight.Text)
    End Sub

    Private Sub btnPrice_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Val(txtWeight.Text) = 0 Then
            'MsgBox("يرجى إدخال الوزن" & vbCrLf & "Please Enter Weight")
            Exit Sub
        End If
        If Val(txtGramPrice.Text) = 0 Then
            'MsgBox("يرجى إدخال سعر الجرام" & vbCrLf & "Please Enter Price Per Gram")
            txtGramPrice.SelectAll()
            txtGramPrice.Focus()
            Exit Sub
        End If
        txtPrice.Text = Val(txtWeight.Text) * Val(txtGramPrice.Text)
    End Sub

    Private Sub Buy_GoldDataGridView_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        If e.RowIndex = -1 Then Exit Sub
        If e.ColumnIndex = -1 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "Delete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد الحذف؟ " & vbCrLf & "Do You Want to Delete? ", vbYesNo) = vbYes Then
                grid.Rows.RemoveAt(grid.CurrentRow.Index)
                If grid.Rows.Count = 0 Then
                    cmbCashier.Enabled = True
                    CivilIDForm.txtCID.Enabled = True
                End If
                Try
                    for_sum()
                Catch ex As Exception
                    MsgBox("لا يوجد بيانات" & vbCrLf & "No Data..", , AppTitle)
                End Try
            End If
        End If
        for_sum()
    End Sub
    Private Sub grid_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub
    Private Sub grid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grid.CellClick
        If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد حذف القطعة" & grid.Rows(e.RowIndex).Cells("colItem_Des").Value & "؟" & vbCrLf & "Do You Want to Delete Item No. " & grid.Rows(e.RowIndex).Cells("colItem_Des").Value, vbYesNo) = vbYes Then
                Try
                    grid.Rows.RemoveAt(grid.CurrentRow.Index)
                    If grid.Rows.Count = 0 Then
                        cmbCashier.Enabled = True
                        CivilIDForm.txtCID.Enabled = True
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, , AppTitle)
                End Try
            End If
        End If
        for_sum()
    End Sub
    Private Sub txtWeight_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtWeight.KeyPress, txtPrice.KeyPress, txtGramPrice.KeyPress
        ValidateTextbox(sender, 3, e)
    End Sub





    Private Sub GoldWeight()
        Dim GoledCart As Decimal = Val(cmbKarat.Text) / 24 * 1000
        Try
            TXTGoCaret999.Text = If(IsDBNull(txtWeight.Text), 0, Val(txtWeight.Text) * Val(GoledCart / ComBxGoCaret999.Text).ToString("#,###,###,###.000"))
        Catch ex As Exception
            'Return
        End Try
    End Sub
    Private Sub ComBxGoCaret999_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComBxGoCaret999.TextChanged
        GoldWeight()
    End Sub

    Private Sub txtWeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWeight.TextChanged
        GoldWeight()
        'txtGramPrice.Text = Math.Round(Val(txtPrice.Text) / Val(txtWeight.Text), 3)
    End Sub

    Private Sub cmbKarat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKarat.SelectedIndexChanged
        GetPricePerGram()
    End Sub

    Private Sub ComBxGoCaret999_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComBxGoCaret999.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TeBoxItem_Des_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TeBoxItem_Des.KeyUp, cmbKarat.KeyUp, txtWeight.KeyUp, txtQunt.KeyUp, txtPrice.KeyUp, btnSave.KeyUp
        If e.KeyCode = Keys.Enter = True Then
            Me.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

    Private Sub txtPrice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrice.KeyDown

    End Sub

    Private Sub txtGramPrice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGramPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.PerformClick()
            TeBoxItem_Des.Focus()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub



    'Private Sub txtGramPrice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGramPrice.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        btnSave.PerformClick()
    '        cmbCashier.Focus()
    '        e.Handled = True
    '        e.SuppressKeyPress = True
    '    End If
    'End Sub

    Private Sub Bay_gram_priceLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Bay_gram_priceLabel.LinkClicked
        'txtGramPrice.Text = Math.Round(Val(txtPrice.Text) / Val(txtWeight.Text), 3)

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
End Class