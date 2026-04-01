Imports System.Drawing.Printing
Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class SilverInvoicePay
    Dim RptPath As String
    Dim Stautes As String
    Dim AutoClose As String
    Dim Multiplepayment As Boolean





    Private Sub GetSettings()
        Dim dt1 As DataTable = GetRecordSet("select * from Settings")
        If dt1.Rows.Count > 0 Then
            PrintRepeat = dt1.Rows(0)("SET_INVARCHR138").ToString
            AutoClose = dt1.Rows(0)("SET_INVARCHR144").ToString
            Multiplepayment = dt1.Rows(0)("SET9").ToString
        End If
    End Sub


    Dim Path As String = Settings.SET_INVARCHR148TextBox.Text
    Public InvoiceTime As String
    Public InvID As String
    Public Sub Radio()
        If rbCash.Checked = True Then
            Stautes = "نقدا"
            rbCredit.Checked = False
        ElseIf rbCash.Checked = False Then
            Stautes = "أجل"
            rbCredit.Checked = True
        End If
    End Sub
    Private Sub baymony_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If Saved Then SilverInvoice.Close()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub
    Private Sub GoldInvoicePay_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ApplyIconsToContainer(Me)
        GetSettings()
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        GetPayMethod()
        GetPayMethodSelect()
        btnPrint.Enabled = False
        txtPrice.Text = Val(SilverInvoice.txtTotalPriceValue.Text)
        txtKnet.Text = 0
        txtCash.Text = 0
        btnPDF.Visible = False
        rbCash.Checked = True
        cmbPayMethod.SelectedIndex = 0
        Dim PayMethodSet As DataTable = GetRecordSet("select [SET5],[SET6],[SET7],[SET8],[SET9] from [Settings]")
        If PayMethodSet.Rows.Count > 0 Then
            cmbPayMethod1.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET5")), 0, (PayMethodSet.Rows(0)("SET5")))
            cmbPayMethod2.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET6")), 1, (PayMethodSet.Rows(0)("SET6")))
            cmbPayMethod3.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET7")), 2, (PayMethodSet.Rows(0)("SET7")))
            cmbPayMethod4.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET8")), 3, (PayMethodSet.Rows(0)("SET8")))
            If (PayMethodSet.Rows(0)("SET9").ToString) = 0 Then
                txtBank1.Visible = False
                txtBank2.Visible = False
                txtBank3.Visible = False
                txtBank4.Visible = False
                cmbPayMethod1.Visible = False
                cmbPayMethod2.Visible = False
                cmbPayMethod3.Visible = False
                cmbPayMethod4.Visible = False
                lblPayMethod1.Visible = False
                'PnlPyment.Bounds = New Rectangle(175, 15, 243, 97)
            ElseIf (PayMethodSet.Rows(0)("SET9").ToString) = 1 Then
                txtBank1.Visible = True
                txtBank2.Visible = True
                txtBank3.Visible = True
                txtBank4.Visible = True
                cmbPayMethod1.Visible = True
                cmbPayMethod2.Visible = True
                cmbPayMethod3.Visible = True
                cmbPayMethod4.Visible = True
                lblPayMethod1.Visible = True
                'PnlPyment.Bounds = New Rectangle(384, 15, 243, 97)
            End If
        End If
        If AutoClose <> "0" Then
            chkAutoClose.Checked = True
        End If
        RadCastm.Checked = True
        GetCastomAccReportPath()
    End Sub
    Private Sub GetPayMethod()
        Dim dt1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If dt1.Rows.Count > 0 Then
            cmbPayMethod.DataSource = dt1
            cmbPayMethod.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod.ValueMember = "ID"
        End If
    End Sub
    Private Sub GetPayMethodSelect()
        Dim DT1 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        Dim DT2 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        Dim DT3 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        Dim DT4 As DataTable = GetRecordSet("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'")
        If DT1.Rows.Count > 0 Then
            cmbPayMethod1.DataSource = DT1
            cmbPayMethod1.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod1.ValueMember = "ID"
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If DT2.Rows.Count > 0 Then
            cmbPayMethod2.DataSource = DT2
            cmbPayMethod2.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod2.ValueMember = "ID"
        End If
        If DT3.Rows.Count > 0 Then
            cmbPayMethod3.DataSource = DT3
            cmbPayMethod3.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod3.ValueMember = "ID"
        End If
        If DT4.Rows.Count > 0 Then
            cmbPayMethod4.DataSource = DT4
            cmbPayMethod4.DisplayMember = If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr")
            cmbPayMethod4.ValueMember = "ID"
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If Val(txtRemaining.Text) > 0 Then
            MsgBox("إجمالي السعر لا يساوي مجموع الكاش والكي نت" & vbCrLf & "Total Price is NOT Equal to Cash And K-NET", , "خطأ")
            Exit Sub
        End If
        If Val(txtCash.Text) < 0 OrElse Val(txtKnet.Text) < 0 OrElse Val(txtBank1.Text) < 0 OrElse Val(txtBank2.Text) < 0 OrElse Val(txtBank3.Text) < 0 OrElse Val(txtBank4.Text) < 0 Then
            MsgBox("لا يمكن إدخال أرقام سالبة" & vbCrLf & "You Can't Enter Negative Values", , "خطأ")
            Exit Sub
        End If
        If rbCash.Checked = True Then
            If Val(txtCash.Text) + Val(txtKnet.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text) <> Val(txtPrice.Text) OrElse Val(txtCash.Text) < 0 OrElse Val(txtKnet.Text) < 0 Then
                MsgBox("إجمالي السعر لا يساوي مجموع الكاش والكي نت" & vbCrLf & "Total Price is NOT Equal to Cash And K-NET", , "خطأ")
                Exit Sub
            End If
        ElseIf rbCredit.Checked = True Then

        End If
        Dim DtInvID As DataTable = GetRecordSet("SELECT BAY_ID +1 AS InvIDAuto FROM SilverBAY WHERE BAY_ID=(SELECT max(BAY_ID)FROM SilverBAY)")
        If DtInvID.Rows.Count > 0 Then
            InvID = Val(DtInvID.Rows(0)(0).ToString)
        Else
            InvID = "1"
        End If
        'Try


        GlCommand.CommandText = " INSERT INTO [SilverBAY]" &
                                           " ([BAY_SARYAL]" &
                                           " ,[TOTAL_mony]" &
                                           " ,[KENT]" &
                                           " ,[CACH]" &
                                           " ,[arbic_tayb]" &
                                           " ,[balance]" &
                                           " ,[staytes]" &
                                           " ,[English_tayb]" &
                                           " ,[Active]" &
                                           " ,[Notes]" &
                                           " ,[PayMethod]" &
                                           " ,[PayMethod1]" &
                                           " ,[PayMethod2]" &
                                            " ,[PayMethod3]" &
                                            " ,[PayMethod4]" &
                                            " ,[Bank1]" &
                                            " ,[Bank2]" &
                                            " ,[Bank3]" &
                                             " ,[Bank4]" &
                                             " ,[InvVatType]" &
                                              " ,[InvVat])" &
                                      " VALUES" &
                                          "(@BAY_SARYAL" &
                                           " ,@TOTAL_mony" &
                                           " ,@KENT" &
                                           " ,@CACH" &
                                           " ,@arbic_tayb" &
                                           " ,@balance" &
                                           " ,@staytes" &
                                           " ,@English_tayb" &
                                           " ,@Active" &
                                           " ,@Notes" &
                                           " ,@PayMethod" &
                                           " ,@PayMethod1" &
                                           " ,@PayMethod2" &
                                           " ,@PayMethod3" &
                                           " ,@PayMethod4" &
                                           " ,@Bank1" &
                                           " ,@Bank2" &
                                           " ,@Bank3" &
                                          " ,@Bank4" &
                                           " ,@InvVatType" &
                                           " ,@InvVat)"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@BAY_SARYAL", InvoiceStringNo(Val(InvID)))
                .AddWithValue("@TOTAL_mony", Val(txtPrice.Text.Trim))
                .AddWithValue("@KENT", If(IsDBNull(txtKnet.Text.Trim), "0", Val(txtKnet.Text.Trim)))
                .AddWithValue("@CACH", If(IsDBNull(txtCash.Text.Trim), "0", Val(txtCash.Text.Trim)))
                .AddWithValue("@arbic_tayb", kokotxt(Val(txtPrice.Text), CurrencyMainAr, CurrencySubAr, True))
                .AddWithValue("@balance", txtRemaining.Text.Trim)
            .AddWithValue("@staytes", If(rbCash.Checked = True, "1", "0"))
            .AddWithValue("@English_tayb", ConvertNumberToENG(txtPrice.Text.Trim))
                .AddWithValue("@Active", "1")
                .AddWithValue("@Notes", "0")
                .AddWithValue("@PayMethod", cmbPayMethod.SelectedValue)
                .AddWithValue("@PayMethod1", cmbPayMethod1.SelectedValue)
                .AddWithValue("@PayMethod2", cmbPayMethod2.SelectedValue)
                .AddWithValue("@PayMethod3", cmbPayMethod3.SelectedValue)
                .AddWithValue("@PayMethod4", cmbPayMethod4.SelectedValue)
                .AddWithValue("@Bank1", If(IsDBNull(txtBank1.Text.Trim), "0", Val(txtBank1.Text.Trim)))
                .AddWithValue("@Bank2", If(IsDBNull(txtBank2.Text.Trim), "0", Val(txtBank2.Text.Trim)))
                .AddWithValue("@Bank3", If(IsDBNull(txtBank3.Text.Trim), "0", Val(txtBank3.Text.Trim)))
                .AddWithValue("@Bank4", If(IsDBNull(txtBank4.Text.Trim), "0", Val(txtBank4.Text.Trim)))
                .AddWithValue("@InvVatType", If(IsDBNull(SilverInvoice.txtTaxAmo.Text.Trim), "0", Val(GoldInvoice.txtTaxAmo.Text.Trim)))
                .AddWithValue("@InvVat", If(IsDBNull(SilverInvoice.txtTpriceTtax.Text.Trim), "0", Val(GoldInvoice.txtTpriceTtax.Text.Trim)))
            End With
            GlCommand.ExecuteNonQuery()
            For i As Integer = 0 To SilverInvoice.grid.Rows.Count - 1
                GlCommand.CommandText = "INSERT INTO [SilverInvoceDetels]" &
                   "([Castomerid]" &
                   ",[ItemID]" &
                   ",[userID]" &
                   ",[item_name]" &
                   ",[item_desp]" &
                   ",[item_GramPrice]" &
                   ",[item_gram]" &
                   ",[item_gramMade]" &
                   ",[item_totalPrice]" &
                   ",[item_cantrey]" &
                   ",[cacher]" &
                   ",[date]" &
                   ",[invoc_date_time]" &
                   ",[Cash]" &
                   ",[qunt]" &
                   ",[sroom_name]" &
                   ",[invoc_time]" &
                   ",[item_extrasMAZAN]" &
                   ",[StoneName1]" &
                   ",[StoneColor1]" &
                   ",[item_extrasPRICE]" &
                   ",[StonePriceType1]" &
                   ",[StoneWeight2]" &
                   ",[StoneName2]" &
                   ",[StoneColor2]" &
                   ",[StonePrice2]" &
                   ",[StonePriceType2]" &
                   ",[StoneWeight3]" &
                   ",[StoneName3]" &
                   ",[StoneColor3]" &
                   ",[StonePrice3]" &
                   ",[StonePriceType3]" &
                   ",[GoledKarat]" &
                   ",[MetalPrice]" &
                   ",[Active]" &
                   ",[ItemVatType]" &
                   ",[ItemVat])" &
             "VALUES" &
                   "(@Castomerid" &
                   ",@ItemID" &
                   ",@userID" &
                   ",@item_name" &
                   ",@item_desp" &
                   ",@item_GramPrice" &
                   ",@item_gram" &
                   ",@item_gramMade" &
                   ",@item_totalPrice" &
                   ",@item_cantrey" &
                   ",@cacher" &
                   ",@date" &
                   ",@invoc_date_time" &
                   ",@Cash" &
                   ",@qunt" &
                   ",@sroom_name" &
                   ",@invoc_time" &
                   ",@item_extrasMAZAN" &
                   ",@StoneName1" &
                   ",@StoneColor1" &
                   ",@item_extrasPRICE" &
                   ",@StonePriceType1" &
                   ",@StoneWeight2" &
                   ",@StoneName2" &
                   ",@StoneColor2" &
                   ",@StonePrice2" &
                   ",@StonePriceType2" &
                   ",@StoneWeight3" &
                   ",@StoneName3" &
                   ",@StoneColor3" &
                   ",@StonePrice3" &
                   ",@StonePriceType3" &
                   ",@GoledKarat" &
                   ",@MetalPrice" &
                   ",@Active" &
                   ",@ItemVatType" &
                   ",@ItemVat)"
                With GlCommand.Parameters
                .Clear()
                .AddWithValue("@Castomerid", SilverInvoice.grid.Rows(i).Cells("colCastomerid").Value)
                .AddWithValue("@ItemID", SilverInvoice.grid.Rows(i).Cells("colItemID").Value)
                .AddWithValue("@userID", SilverInvoice.grid.Rows(i).Cells("coluserID").Value)
                .AddWithValue("@item_name", SilverInvoice.grid.Rows(i).Cells("colItemName").Value)
                .AddWithValue("@item_desp", SilverInvoice.grid.Rows(i).Cells("colGoledPurchasPrice").Value)
                .AddWithValue("@item_GramPrice", SilverInvoice.grid.Rows(i).Cells("colGramPrice").Value)
                .AddWithValue("@item_gram", SilverInvoice.grid.Rows(i).Cells("colGoldWeight").Value)
                .AddWithValue("@item_gramMade", SilverInvoice.grid.Rows(i).Cells("colGoledMakeCharge").Value)
                .AddWithValue("@item_totalPrice", SilverInvoice.grid.Rows(i).Cells("colTotalGoledPrice").Value)
                .AddWithValue("@item_cantrey", SilverInvoice.grid.Rows(i).Cells("colItemCantrey").Value)
                .AddWithValue("@cacher", SilverInvoice.grid.Rows(i).Cells("colcacher").Value)
                .AddWithValue("@date", SilverInvoice.grid.Rows(i).Cells("coldate").Value)
                .AddWithValue("@invoc_date_time", SilverInvoice.grid.Rows(i).Cells("colInvocDateTime").Value)
                .AddWithValue("@Cash", SilverInvoice.grid.Rows(i).Cells("coldate").Value)
                .AddWithValue("@qunt", SilverInvoice.grid.Rows(i).Cells("colGoledPiecesQuantity").Value)
                .AddWithValue("@sroom_name", SilverInvoice.grid.Rows(i).Cells("colSroomName").Value)
                .AddWithValue("@invoc_time", InvoiceStringNo(Val(InvID)))
                .AddWithValue("@item_extrasMAZAN", SilverInvoice.grid.Rows(i).Cells("colStonWeight1").Value)
                .AddWithValue("@StoneName1", SilverInvoice.grid.Rows(i).Cells("colStonName1").Value)
                .AddWithValue("@StoneColor1", SilverInvoice.grid.Rows(i).Cells("colStonColor1").Value)
                .AddWithValue("@item_extrasPRICE", SilverInvoice.grid.Rows(i).Cells("colStonPrice1").Value)
                .AddWithValue("@StonePriceType1", SilverInvoice.grid.Rows(i).Cells("colStonePriceType1").Value)
                .AddWithValue("@StoneWeight2", SilverInvoice.grid.Rows(i).Cells("colStonWeight2").Value)
                .AddWithValue("@StoneName2", SilverInvoice.grid.Rows(i).Cells("colStonName2").Value)
                .AddWithValue("@StoneColor2", SilverInvoice.grid.Rows(i).Cells("colStonColor2").Value)
                .AddWithValue("@StonePrice2", SilverInvoice.grid.Rows(i).Cells("colStonPrice2").Value)
                .AddWithValue("@StonePriceType2", SilverInvoice.grid.Rows(i).Cells("colStonePriceType2").Value)
                .AddWithValue("@StoneWeight3", SilverInvoice.grid.Rows(i).Cells("colStonWeight3").Value)
                .AddWithValue("@StoneName3", SilverInvoice.grid.Rows(i).Cells("colStonName3").Value)
                .AddWithValue("@StoneColor3", SilverInvoice.grid.Rows(i).Cells("colStonColor3").Value)
                .AddWithValue("@StonePrice3", SilverInvoice.grid.Rows(i).Cells("colStonPrice3").Value)
                .AddWithValue("@StonePriceType3", SilverInvoice.grid.Rows(i).Cells("colStonePriceType3").Value)
                .AddWithValue("@GoledKarat", SilverInvoice.grid.Rows(i).Cells("colGoledKarat").Value)
                .AddWithValue("@MetalPrice", SilverInvoice.grid.Rows(i).Cells("colGoledPrice").Value)
                .AddWithValue("@Active", "1")
                .AddWithValue("@ItemVatType", SilverInvoice.grid.Rows(i).Cells("colTaxTextAm").Value)
                .AddWithValue("@ItemVat", SilverInvoice.grid.Rows(i).Cells("colTaxAmo").Value)
            End With
                GlCommand.ExecuteNonQuery()
            Next
            GlCommand.CommandText = ("UPDATE [SilverInvoceDetels] SET [nots] =N'" & SilverInvoice.txtNotes.Text.Trim & "' WHERE  [invoc_time]='" & InvoiceStringNo(Val(InvID)) & "'")
            GlCommand.ExecuteNonQuery()
            txtInvoiceNo.Text = InvoiceStringNo(Val(InvID))
            InvoiceTime = InvoiceStringNo(Val(InvID))
            GetCastomAccReportPath()
            Dim DT As DataTable = GetRecordSet("select * from ViwSilverInvoceReport  WHERE  [invoc_time]='" & InvoiceStringNo(Val(InvID)) & "'")
            If DT.Rows.Count > 0 Then
                Dim ReportDataSource = New ReportDataSource("DataSet1", DT)
                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
                ReportViewer1.RefreshReport()
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Else
            End If
            btnPrint.Enabled = True
            btnSave.Enabled = False
            txtKnet.Enabled = False
            txtCash.Enabled = False
            rbCash.Enabled = False
            rbCredit.Enabled = False
            btnPDF.Visible = True
            Saved = True
            cmbPayMethod.Enabled = False
            'End If
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub



    Private Sub rbNow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbCash.CheckedChanged
        'Radio()
    End Sub

    Private Sub rbLater_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbCredit.CheckedChanged
        'Radio()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)

        Try
            If ReportViewer1.PrintDialog() = Windows.Forms.DialogResult.Cancel Then
                'Put your stuff here
            End If
        Catch ex As Exception
            MsgBox("تجري الطباعة الان" & vbCrLf & "Printing in Progress..", , AppTitle)
        End Try
    End Sub
    Private Sub PrintReport()
        Try
            Dim printerSettings As New PrinterSettings()
            printerSettings.Copies = If(PrintRepeat = "", "2", PrintRepeat)
            ReportViewer1.PrinterSettings = printerSettings
            ReportViewer1.PrintDialog()
            Me.Close()
        Catch ex As Exception
            MsgBox("انتظر ظهور الفاتورة علي الشاشة" & vbCrLf & "Wait for the Invoice to be Fully Dispalyed", , AppTitle)
        End Try
    End Sub

    ' Call this method whenever you want to print the report
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        PrintReport()
    End Sub
    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        Saved = True
        PrintReport()
    End Sub
    Private Sub txtPrice_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles txtPrice.LinkClicked
        txtCash.Text = "0"
        txtKnet.Text = Val(SilverInvoice.txtTotalPriceValue.Text)
        NegativeColor()
    End Sub
    Private Sub lblKNET_Click(ByVal sender As Object, ByVal e As EventArgs)
        txtKnet.Text = txtPrice.Text
        txtCash.Text = "0"
        NegativeColor()
    End Sub

    Private Sub lblCash_Click(ByVal sender As Object, ByVal e As EventArgs)
        txtCash.Text = txtPrice.Text
        txtKnet.Text = "0"
        NegativeColor()
    End Sub
    Private Sub txtKnet_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim KNET As Decimal = Val(txtKnet.Text)
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            Dim Bank1 As Decimal = Val(txtBank1.Text)
            Dim Bank2 As Decimal = Val(txtBank2.Text)
            Dim Bank3 As Decimal = Val(txtBank3.Text)
            Dim Bank4 As Decimal = Val(txtBank4.Text)
            txtRemaining.Text = (KNET + Cash + Bank1 + Bank2 + Bank3 + Bank4) - (Price)
        Catch ex As Exception
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub
    Private Sub txtKnet_KeyPress(ByVal sender As Object, ByVal e As KeyEventArgs)
        If rbCash.Checked = True Then
            If Multiplepayment = 0 Then
                Dim KNET As Decimal = Val(txtKnet.Text)
                Dim Price As Decimal = Val(txtPrice.Text)
                txtCash.Text = Price - KNET
                NegativeColor()
            ElseIf Multiplepayment = 1 Then
                NegativeColor()
            End If
        ElseIf rbCredit.Checked = True Then
        End If
    End Sub
    Private Sub txtBank1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim KNET As Decimal = Val(txtKnet.Text)
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            Dim Bank1 As Decimal = Val(txtBank1.Text)
            Dim Bank2 As Decimal = Val(txtBank2.Text)
            Dim Bank3 As Decimal = Val(txtBank3.Text)
            Dim Bank4 As Decimal = Val(txtBank4.Text)
            txtRemaining.Text = (KNET + Cash + Bank1 + Bank2 + Bank3 + Bank4) - (Price)
        Catch ex As Exception
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub

    Private Sub txtCash_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim KNET As Decimal = Val(txtKnet.Text)
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            Dim Bank1 As Decimal = Val(txtBank1.Text)
            Dim Bank2 As Decimal = Val(txtBank2.Text)
            Dim Bank3 As Decimal = Val(txtBank3.Text)
            Dim Bank4 As Decimal = Val(txtBank4.Text)
            txtRemaining.Text = (KNET + Cash + Bank1 + Bank2 + Bank3 + Bank4) - (Price)
        Catch ex As Exception
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub
    Private Sub txtCash_Keyup(ByVal sender As Object, ByVal e As KeyEventArgs)
        If rbCash.Checked = True Then
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            txtKnet.Text = Price - Cash
            NegativeColor()
        ElseIf rbCredit.Checked = True Then
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

    Private Sub BtnPDF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPDF.Click
        Dim data As New Date
        data = Date.Now
        Try
            ReportViewer1.LocalReport.DisplayName = CivilIDForm.txtName.Text.Trim
        Catch ex As Exception
            MsgBox("خطأ في موقع الحفظ" & vbCrLf & "Error in Save Location", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
        Try
            Dim Path As String = Settings.SET_INVARCHR148TextBox.Text
            If Strings.Right(Path, 1) <> "\" Then Path &= "\"
            ReportViewer1.LocalReport.EnableExternalImages = True
            Dim byteViewer As Byte() = ReportViewer1.LocalReport.Render("PDF")
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "*PDF files (*.PDF)|*.PDF"
            saveFileDialog1.FileName = CivilIDForm.txtName.Text.Trim
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If Directory.Exists(Path & "Gold-Silver\" & CivilIDForm.txtName.Text.Trim & "-" & CivilIDForm.txtCID.Text.Trim) = False Then Directory.CreateDirectory(Path & "Gold-Silver\" & CivilIDForm.txtName.Text.Trim & "-" & CivilIDForm.txtCID.Text.Trim)
            Dim newFile As New FileStream(Path & "Gold-Silver\" & CivilIDForm.txtName.Text.Trim & "-" & CivilIDForm.txtCID.Text.Trim & "\" & txtInvoiceNo.Text & ".PDF", FileMode.Create)
            newFile.Write(byteViewer, 0, byteViewer.Length)
            newFile.Close()
            If MsgBox("تم الحفظ. هل تريد عرض مجلد الفاتورة؟" & vbCrLf & "Save Done. Open Invoice Folder?", vbYesNo, AppTitle) = vbYes Then
                Process.Start(Path & "Gold-Silver\" & CivilIDForm.txtName.Text.Trim & "-" & CivilIDForm.txtCID.Text.Trim)
            End If
        Catch ex As Exception
            MsgBox("PDF يرجى تثبيت قارئ أولا لملفات" & vbCrLf & "Please Install PDf Reader First.", MsgBoxStyle.Information, AppTitle)
            Exit Sub
        End Try
    End Sub

    Private Sub chkEngInvoice_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkEngInvoice.CheckedChanged
        GetCastomAccReportPath()
        If Saved Then ReportViewer1.RefreshReport()

    End Sub
    Private Sub GetCastomAccReportPath()
        GetInvoceReportPath(PathFiled:="Report_Path11")
        If RadCastm.Checked = True Then
            ReportViewer1.LocalReport.ReportPath = ReportPath
        ElseIf RadAcc.Checked = True Then
            ReportViewer1.LocalReport.ReportPath = Replace(ReportPath, ".rdlc", "-Acc.rdlc")
        End If
    End Sub
    'Private Sub GetReportPath()
    '    Dim GoldArPath As String = RptPath
    '        If chkEngInvoice.Checked = True Then
    '            'Silver-Eng
    '            ReportViewer1.LocalReport.ReportPath = Replace(Replace(GoldArPath, "Gold", "Silver"), ".rdlc", "-EN.rdlc")
    '        Else
    '            'Silver-Ar
    '            ReportViewer1.LocalReport.ReportPath = Replace(GoldArPath, "Gold", "Silver")
    '        End If
    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    '    'MsgBox("https://saponlin.net/payment" / "SAP_COP" / "" & CastomerNAmeLabel.Text & "" & lblInvoiceNo.Text.Trim & "" / "" & Val(txtKnet.Text) & "".ToString)



    '    'Dim webAddress As String = "https://saponlin.net/payment " & "SAP_COP" & "/" & "HOSAM" & "/" & txtKnet.Text & ""
    '    'Process.Start(webAddress)





    '    Dim COOD As String = ("https://saponlin.net/payment/ " & "SAP_COMP" & "/" & CastomeridTextBox.Text.Trim & "-DATE-2023-01-29" & txtInvoiceNo.Text & "/" & txtKnet.Text.Trim)
    '    MsgBox(COOD)
    '    'Dim webAddress As String = "https://saponlin.net/payment/ " & COOD.ToString
    '    'Process.Start(webAddress)
    '    Clipboard.SetText(COOD)
    '    frmLlnk.LinkLabel1.Text = COOD
    '    frmLlnk.ShowDialog()





    'End Sub



#Region "BankSum"
    Private Sub txtBank2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim KNET As Decimal = Val(txtKnet.Text)
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            Dim Bank1 As Decimal = Val(txtBank1.Text)
            Dim Bank2 As Decimal = Val(txtBank2.Text)
            Dim Bank3 As Decimal = Val(txtBank3.Text)
            Dim Bank4 As Decimal = Val(txtBank4.Text)
            txtRemaining.Text = (KNET + Cash + Bank1 + Bank2 + Bank3 + Bank4) - (Price)
        Catch ex As Exception
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub
    Private Sub txtBank3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim KNET As Decimal = Val(txtKnet.Text)
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            Dim Bank1 As Decimal = Val(txtBank1.Text)
            Dim Bank2 As Decimal = Val(txtBank2.Text)
            Dim Bank3 As Decimal = Val(txtBank3.Text)
            Dim Bank4 As Decimal = Val(txtBank4.Text)
            txtRemaining.Text = (KNET + Cash + Bank1 + Bank2 + Bank3 + Bank4) - (Price)
        Catch ex As Exception
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub
    Private Sub txtBank4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim KNET As Decimal = Val(txtKnet.Text)
            Dim Cash As Decimal = Val(txtCash.Text)
            Dim Price As Decimal = Val(txtPrice.Text)
            Dim Bank1 As Decimal = Val(txtBank1.Text)
            Dim Bank2 As Decimal = Val(txtBank2.Text)
            Dim Bank3 As Decimal = Val(txtBank3.Text)
            Dim Bank4 As Decimal = Val(txtBank4.Text)
            txtRemaining.Text = (KNET + Cash + Bank1 + Bank2 + Bank3 + Bank4) - (Price)
        Catch ex As Exception
            'MsgBox("خطأ في المدخلات الرقميه 123 راجع مصمم البرنامج", , AppTitle)
        End Try
    End Sub
#End Region

    Private Sub RadCastm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCastm.CheckedChanged
        GetCastomAccReportPath()
        If Saved Then ReportViewer1.RefreshReport()
    End Sub

    Private Sub RadAcc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadAcc.CheckedChanged
        GetCastomAccReportPath()
        If Saved Then ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
  
    End Sub
End Class