Imports PACICardLibrary
Imports System.ServiceProcess
Public Class DiamondBuyPerson
    Public Sub for_sum()
        Dim total As Decimal
        For i As Decimal = 6 To Buy_DiamondDataGridView.RowCount - 1
            total = Buy_DiamondDataGridView.Rows(i).Cells(0).Value
            txtTotalPrice.Text = Val(total)
        Next
    End Sub
    Private Sub GetCasherName()
        Dim DTComCasher As DataTable = GetRecordSet("SELECT [cacher_name] FROM [cacher]")
        If DTComCasher.Rows.Count > 0 Then
            ComCasher.DataSource = DTComCasher
            ComCasher.DisplayMember = "cacher_name"
            ComCasher.ValueMember = "cacher_name"
        End If
    End Sub
    Dim total As Decimal
    Dim paci As PACMAN
    Dim cardConnected As Boolean = False
    Public a As Integer
    Public dte As Date

    Private Sub Buy_GoldBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Validate()
        Buy_DiamondBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DT_restrantDataSet)

    End Sub



    Private Sub DiamondBuyPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        ControlsAsColor(ColorSelect:=Me)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'btnPayPrint.Enabled = False
        CivilIDForm = New CivilID
        CivilIDForm.Bounds = New Rectangle(2, 0, 960, 350)
        Controls.Add(CivilIDForm)
        CardServiceStart()
        paci = New PACMAN


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        frmMain.Timer1.Stop()
        language_start(Name)

        Dimon_catTableAdapter.Fill(DT_restrantDataSet.dimon_cat)
        ReportDiamondBuyInvoiceTableAdapter.Fill(DT_restrantDataSet.ReportDiamondBuyInvoice)
        Bay_Diamond_idTableAdapter.Fill(DT_restrantDataSet.Bay_Diamond_id)
        Bay_Diamond_id_filterTableAdapter.Fill(DT_restrantDataSet.Bay_Diamond_id_filter)
        Loc_nameTableAdapter.Fill(DT_restrantDataSet.loc_name)
        Gram_valTableAdapter.Fill(DT_restrantDataSet.Gram_val)
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker1.Text = Date.Now
        Bay_Diamond_idBindingSource.AddNew()
        AddTextBox.Text = "1"
        CivilIDForm.txtCID.Focus()
        Buy_DiamondDataGridView.Columns(0).Width = 100
        'GetCasherName()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If cardConnected Then
            Dim dt1 As DataTable = GetRecordSet("SELECT [SET_INVARCHR143] FROM [Settings]")
            If dt1.Rows.Count > 0 Then
                If dt1.Rows(0)(0).ToString <> "1" Then
                    MsgBox("لم يتم تفعيل قارئ البطاقة المدنية" & vbCrLf & "Card Reader is not Activated", , "خطأ")
                    Exit Sub
                End If
            End If
            GetCustomerDataFromCID()
        End If
    End Sub
    Private Sub NewData(Active As Boolean)
        btnSave.Enabled = Active
        btnDelete.Enabled = Active
        btnFirst.Enabled = Active
        btnLast.Enabled = Active
        btnNext.Enabled = Active
        btnPrevious.Enabled = Active
        btnPayPrint.Enabled = Active

        txtItemName.Enabled = Active
        txtClarity.Enabled = Active
        txtColor.Enabled = Active
        txtCarat.Enabled = Active
        cmbCut.Enabled = Active
        txtSerialNo.Enabled = Active
        txtGoldWeight.Enabled = Active
        cmbKarat.Enabled = Active
        txtPrice.Enabled = Active
        Buy_DiamondDataGridView.Enabled = Active
    End Sub

    Private Sub Paci_ConnectionEvent(ReaderIndex As Integer)
        Try
            cardConnected = True
        Catch ex As SmartCardServiceUnavailableException
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Paci_DisconnectionEvent(ReaderIndex As Integer)
        Try
            If cardConnected Then
                cardConnected = False
            End If
        Catch ex As SmartCardServiceUnavailableException

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Paci_ReadersEvent()
        Try
            If cardConnected Then

                cardConnected = False
            End If
        Catch ex As SmartCardServiceUnavailableException

        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        If CivilIDForm.txtCID.Text.Trim <> "" Then
            Clipboard.SetText(CivilIDForm.txtCID.Text)
        Else
            Clipboard.Clear()
        End If
        select_scaner_med()
        TopMost = True
        If IsNumeric(Clipboard.GetText) = True Then
            CivilIDForm.txtCID.Text = ""
            CivilIDForm.txtCID.Text = Clipboard.GetText()
        End If
        TopMost = False
        txtItemName.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim CID As String = CivilIDForm.txtCID.Text.Trim
        If CivilIDForm.SaveCustomerData() = False Then
            Exit Sub
        Else
            CivilIDForm.txtCID.Enabled = False
        End If

        If txtPrice.Text = "" Then
            MsgBox("لايمكن ترك قيمة إجمالي المبلغ فارغة" & vbCrLf & "Total Price Can't be empty", , Apptitle)
            Exit Sub
        End If
        If ComCasher.Text = "" Then
            MsgBox("لايمكن ترك اسم الكاشير فارغ" & vbCrLf & "The cashier's name Can't be empty", , AppTitle)
            ComCasher.DroppedDown = True
            Exit Sub
        End If

        If IsNumeric(txtGoldWeight.Text.Trim) = False Then
            MsgBox("يجب إدخال أرقام فقط" & vbCrLf & "You must Enter Numbers ONLY", , Apptitle)
            txtGoldWeight.SelectAll()
            txtGoldWeight.Focus()
            Exit Sub
        End If
        If IsNumeric(txtCarat.Text.Trim) = False Then
            MsgBox("يجب إدخال أرقام فقط" & vbCrLf & "You must Enter Numbers ONLY", , Apptitle)
            txtCarat.SelectAll()
            txtCarat.Focus()
            Exit Sub
        End If
        If IsNumeric(txtPrice.Text.Trim) = False Then
            MsgBox("يجب إدخال أرقام فقط" & vbCrLf & "You must Enter Numbers ONLY", , Apptitle)
            txtPrice.SelectAll()
            txtPrice.Focus()
            Exit Sub
        End If
        Try
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ValidateChildren()
            Bay_Diamond_idBindingSource.EndEdit()
            Bay_Diamond_idTableAdapter.Update(DT_restrantDataSet.Bay_Diamond_id)
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Buy_DiamondBindingSource.AddNew()
            Inv_idTextBox.Text = Val(Bay_Diamond_idTextBox.Text)
            Castomer_idTextBox.Text = CivilIDForm.txtCID.Text.Trim

            DIMO_depTextBox.Text = txtItemName.Text.Trim
            DIM_na9awaTextBox.Text = txtClarity.Text.Trim
            Ext_colerTextBox.Text = txtColor.Text.Trim
            DIMO_mezanTextBox.Text = txtCarat.Text.Trim
            SarualTextBox.Text = txtSerialNo.Text.Trim
            Gold_mezanTextBox.Text = Val(txtGoldWeight.Text)
            Val_goldTextBox.Text = Val(cmbKarat.Text)
            Test_12TextBox.Text = Val(txtPrice.Text)
            Test_11TextBox.Text = cmbCut.Text
            QultTextBox.Text = ComCasher.Text.Trim
            NotesTextBox.Text = txtNotes.Text.Trim
            Bay_total_priceTextBox.Text = Val(txtPrice.Text)

            ValidateChildren()
            Buy_DiamondBindingSource.EndEdit()
            Buy_DiamondTableAdapter.Update(DT_restrantDataSet.Buy_Diamond)
            msgdin()
            Dim totala As Decimal
            For i As Decimal = 0 To Buy_DiamondDataGridView.Rows.Count - 1
                totala += Buy_DiamondDataGridView.Rows(i).Cells("test_12").Value
                txtTotalPrice.Text = totala
            Next
            Saved = False 'لم يتم استكمال تفاصيل الدفع
        Catch ex As Exception
            MsgBox(ex.Message)
            msgnotdin()
            Buy_DiamondBindingSource.CancelEdit()
            Exit Sub
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Buy_DiamondBindingSource.RemoveCurrent()
            Dim totala As Decimal
            For i As Decimal = 0 To Buy_DiamondDataGridView.Rows.Count - 1
                totala += Buy_DiamondDataGridView.Rows(i).Cells(6).Value
                txtTotalPrice.Text = totala
            Next
            ValidateChildren()
            Buy_DiamondBindingSource.EndEdit()
            Buy_DiamondTableAdapter.Update(DT_restrantDataSet.Buy_Diamond)
            MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete Completed successfully", , Apptitle)
        Catch ex As Exception
            MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete Completed successfully", , Apptitle)
        End Try
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Buy_DiamondBindingSource.MoveFirst()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Buy_DiamondBindingSource.MoveLast()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Buy_DiamondBindingSource.MoveNext()
    End Sub

    Private Sub btnPayPrint_Click(sender As Object, e As EventArgs) Handles btnPayPrint.Click
        If Buy_DiamondDataGridView.Rows.Count = 0 Then
            btnSave.PerformClick()
        End If
        With DiamondBuyPay
            .txtInvoiceNo.Text = Inv_idTextBox.Text
            .txtPrice.Text = Val(txtTotalPrice.Text)
            .ShowDialog()
        End With
        Close()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Buy_DiamondBindingSource.MovePrevious()
    End Sub

    Private Sub txtCID_TextChanged(sender As Object, e As EventArgs) Handles txtCID.TextChanged
        If IsNumeric(CivilIDForm.txtCID.Text.Trim) = True Then
            GetCustomerDataFromDB()
        End If
    End Sub
    Private Sub GetCustomerDataFromCID()
        Try
            CivilIDForm.txtCID.Text = paci.Civil_ID(0)
        Catch ex As Exception
            MsgBox("أعد إدخال قارئ البطاقة مرة أخرى" & vbCrLf & "Please re-insert Civil ID Reader again", , Apptitle)
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GetCustomerDataFromDB()
        CastomerDETELSTableAdapter.GetDataByCastomer_id(DT_restrantDataSet.CastomerDETELS, txtCID.Text.Trim)
        PictureBox1.Image = FotoPictureBox.Image
        If CastomerNAmeLinkLabel.Text.Trim <> "" Then
            NewData(True)
        End If

    End Sub

    Private Sub prsnal_pay_gold_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Saved = False Then
            Bay_Diamond_idBindingSource.RemoveCurrent()
            ValidateChildren()
            Bay_Diamond_idBindingSource.EndEdit()
            Bay_Diamond_idTableAdapter.Update(DT_restrantDataSet.Bay_Diamond_id)
            Do While Buy_DiamondBindingSource.Count <> 0 'removes displayed rows
                Buy_DiamondBindingSource.MoveFirst()
                Buy_DiamondBindingSource.RemoveCurrent()
                Validate()
                Buy_DiamondBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DT_restrantDataSet)
                Buy_DiamondBindingSource.EndEdit()
                Buy_DiamondTableAdapter.Update(DT_restrantDataSet.Buy_Diamond)
            Loop
        End If
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub ComCasher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComCasher.SelectedIndexChanged

    End Sub

    Private Sub ComCasher_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ComCasher.MouseClick
        GetCasherName()
    End Sub
End Class