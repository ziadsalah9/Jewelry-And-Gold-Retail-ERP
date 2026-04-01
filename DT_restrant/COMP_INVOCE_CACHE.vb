
Imports PACICardLibrary
Imports System.ServiceProcess
Public Class COMP_INVOCE_CACHE

    Public BA As Integer = 1
    Public resev As Integer = 2
    Public Day_M As Short
    Public Month_M As Short
    Public Year_M As Short
    Public Month_M_Name As String
    Public Day_M_Name As String
    Public Date1 As String
    Public Day_C As Short
    Public Month_C As Short
    Public Year_C As Short
    Public Month_C_Name As String
    Dim sum As Decimal
    Dim a As Decimal
    Dim d As Date
    Dim paci As PACMAN
    Dim cardConnected As Boolean = False

    Dim toteel As Decimal
    Dim a1 As String
    Public Sub finel_sum()
        Dim a As Decimal
        a = Val(txtCash.Text) + Val(txtKNET.Text)
        txtRemaining.Text = LinkLabel1.Text - a
    End Sub

    Public Sub save()
        ValidateChildren()
        COMP_INVOCE_CACHEBindingSource.EndEdit()
        COMP_INVOCE_CACHETableAdapter.Update(DT_restrantDataSet.COMP_INVOCE_CACHE)
        Validate()
        COMP_INVOCE_CACHEBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DT_restrantDataSet)
    End Sub

    Public Sub nuale()
        If CastomerNAmeTextBox.Text = "" Then
            btnReadData.Enabled = True
        Else
            btnReadData.Enabled = False
        End If
    End Sub
    Public Sub nuale2()
        If CastomerNAmeTextBox.Text = "" Then
        Else
            btnAddNewCustomer.Enabled = False
            MsgBox("عميل مسجل مسبقا", , Apptitle)
        End If
    End Sub
    Public Sub chked()
        If txtCash.Text = LinkLabel1.Text Then
            txtKNET.Enabled = False
        End If
    End Sub
    Private Sub COMP_INVOCE_CACHEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Validate()
        COMP_INVOCE_CACHEBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DT_restrantDataSet)
    End Sub

    Private Sub COMP_INVOCE_CACHE_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Saved = False Then
            Do While COMP_INVOCE_CACHEBindingSource.Count <> 0 'removes displayed rows
                COMP_INVOCE_CACHEBindingSource.MoveFirst()
                COMP_INVOCE_CACHEBindingSource.RemoveCurrent()
                Validate()
                ValidateChildren()
                COMP_INVOCE_CACHEBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(DT_restrantDataSet)
                COMP_INVOCE_CACHEBindingSource.EndEdit()
                COMP_INVOCE_CACHETableAdapter.Update(DT_restrantDataSet.COMP_INVOCE_CACHE)
            Loop
        End If
        frmMain.Timer1.Start()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        ReportViewer2.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub

    Private Sub COMP_INVOCE_CACHE_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        ControlsAsColor(ColorSelect:=Me)
        company_pay_finel_prinetTableAdapter.Fill(DT_restrantDataSet.company_pay_finel_prinet)
        frmMain.Timer1.Stop()
        language_start(Name)
        BAY_from_comp_bay_saryilTableAdapter.Fill(DT_restrantDataSet.BAY_from_comp_bay_saryil)
        txtCash.Text = 0
        txtKNET.Text = 0
        btnPrint.Enabled = False
        Gram_valTableAdapter.Fill(DT_restrantDataSet.Gram_val)
        btnAddNewCustomer.Enabled = False
        btnReadData.Enabled = False
        RadioButton1.Checked = True
        COMPANY_BAY_SORT_NAMETableAdapter.Fill(DT_restrantDataSet.COMPANY_BAY_SORT_NAME)
        Dim sc As New ServiceController("SCardSvr")
        If sc.Status = ServiceControllerStatus.Running Then
            paci = New PACMAN
            AddHandler paci.ReadersEvent, New PACMAN.ReadersStateChanged(AddressOf Paci_ReadersEvent)
            AddHandler paci.CardConnectionEvent, New PACMAN.CardConnectionHandler(AddressOf Paci_ConnectionEvent)
            AddHandler paci.CardDisconnectionEvent, New PACMAN.CardDisconnectionHandler(AddressOf Paci_DisconnectionEvent)
        End If
        txtWeight.Text = 0
        txtGramPrice.Text = 0
        Saved = False
        ReportViewer1.RefreshReport()
        ReportViewer2.RefreshReport()
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
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ComboBox1.SelectedValue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddCompany.Click
        frmSuppliers.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        Try
            TextBox2.Text = paci.Civil_ID(0)
            CastomerDETELSTableAdapter.GetDataByCastomer_id(DT_restrantDataSet.CastomerDETELS, TextBox2.Text)
            TextBox3.Text = CastomerNAmeTextBox.Text
            TextBox4.Text = CastomerADrTextBox.Text
            TextBox5.Text = CastomerTETextBox.Text
            TextBox6.Text = CastomerNATextBox.Text
            'If  Then
            nuale()
            nuale2()
        Catch ex As Exception
            MsgBox("تأكد من وجود البطاقة بالقارئ" & vbCrLf & "Check Civil ID is in the Reader", , Apptitle)
            Exit Sub
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAddNewCustomer.Click
        Try
            CastomerDETELSBindingSource.AddNew()
            CastomerCAIVELidTextBox.Text = TextBox2.Text
            CastomerNAmeTextBox.Text = TextBox3.Text
            CastomerTETextBox.Text = TextBox4.Text
            CastomerADrTextBox.Text = TextBox5.Text
            CastomerNATextBox.Text = TextBox6.Text
            TextBox3.BackColor = Color.Green
            TextBox4.BackColor = Color.Green
            TextBox5.BackColor = Color.Green
            TextBox6.BackColor = Color.Green
            ValidateChildren()
            CastomerDETELSBindingSource.EndEdit()
            CastomerDETELSTableAdapter.Update(DT_restrantDataSet.CastomerDETELS)
            nuale()
            btnAddNewCustomer.Enabled = False
        Catch ex As Exception
            MsgBox("اعرض البيانات اولا", , Apptitle)
            Exit Sub
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CastomerDETELSBindingSource.AddNew()
        CastomerNAmeTextBox.Text = TextBox3.Text
        CastomerTETextBox.Text = TextBox4.Text
        CastomerADrTextBox.Text = TextBox5.Text
        CastomerNATextBox.Text = TextBox6.Text
        ValidateChildren()
        CastomerDETELSBindingSource.EndEdit()
        CastomerDETELSTableAdapter.Update(DT_restrantDataSet.CastomerDETELS)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnReadData.Click
        Try
            TextBox2.Text = paci.Civil_ID(0)
            TextBox3.Text = paci.Arabic_Name_Full(0)
            TextBox4.Text = paci.Telephone_1(0)
            TextBox5.Text = paci.District(0) & ",مبنى" & paci.Building_Plot_Number(0) & "," & paci.Street_Name(0)
            TextBox6.Text = paci.Nationality_Arabic(0) & " ,  الوظيفة/ " & paci.Additional_F_1(0)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            TextBox3.BackColor = Color.Red
            TextBox4.BackColor = Color.Red
            TextBox5.BackColor = Color.Red
            TextBox6.BackColor = Color.Red
            btnReadData.Enabled = False
            btnAddNewCustomer.Enabled = True
        Catch ex As Exception
            MsgBox("تاكد من وجود البطاقه بالقارئ", , Apptitle)
            Exit Sub
        End Try
    End Sub

    Private Sub txtGramPrice_TextChanged(sender As Object, e As EventArgs) Handles txtGramPrice.TextChanged
        Try
            Dim tot As Decimal
            tot = Val(txtWeight.Text * txtGramPrice.Text)
            txtPrice.Text = tot
        Catch ex As Exception
            MsgBox("القيم العشرية من رقمين فقط & حقل رقمي لا يقبل النصوص", , Apptitle)
            txtPrice.Text = 0
        End Try

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ValidateChildren()
        COMP_INVOCE_CACHEBindingSource.EndEdit()
        COMP_INVOCE_CACHETableAdapter.Update(DT_restrantDataSet.COMP_INVOCE_CACHE)
        Validate()
        COMP_INVOCE_CACHEBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(DT_restrantDataSet)
    End Sub

    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles txtWeight.TextChanged
        Try
            Dim tot As Decimal
            tot = Val(txtWeight.Text * txtGramPrice.Text)
            txtPrice.Text = tot
        Catch ex As Exception
            txtWeight.Text = 0
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If TextBox2.Text = "" Then
                TextBox2.Text = 0

            End If
            If Val(TextBox1.Text) = 0 Then
                MsgBox("اختر اسم الشركه اولا", , Apptitle)
                Exit Sub
            ElseIf Val(txtWeight.Text) = 0 Then
                MsgBox("لم يتم ادخال الوزن", , Apptitle)
                Exit Sub
            ElseIf Val(txtGramPrice.Text) = 0 Then
                MsgBox("لم يتم ادخال سعر الجرام", , Apptitle)
                Exit Sub
            ElseIf Val(txtPrice.Text) = 0 Then
                MsgBox("لم يتم ادخال اجمالي سعر ", , Apptitle)
                Exit Sub
            ElseIf cmbCarat.Text = "اختر العيار" Then
                MsgBox("اختر العيار اولا", , Apptitle)
                Exit Sub
            End If
            btnPay.Enabled = True
            COMP_INVOCE_CACHEBindingSource.AddNew()
            BAY_idTextBox.Text = SaryalTextBox.Text
            COMP_IDTextBox.Text = Val(TextBox1.Text)
            CASTOMER_ID_tTextBox.Text = TextBox2.Text
            GOLED_wazenTextBox.Text = txtWeight.Text
            GOLED_VALUSTextBox.Text = cmbCarat.Text
            GOLED_GRAM_PRICETextBox.Text = txtGramPrice.Text
            GOLED_TOTAL_PRICETextBox.Text = txtPrice.Text
            Note1TextBox.Text = BA
            ValidateChildren()
            COMP_INVOCE_CACHEBindingSource.EndEdit()
            COMP_INVOCE_CACHETableAdapter.Update(DT_restrantDataSet.COMP_INVOCE_CACHE)
            COMP_INVOCE_CACHEBindingSource.AddNew()
            COMP_INVOCE_CACHEBindingSource.RemoveCurrent()
            save()
            msgdin()
            Dim totala As Decimal
            For i As Decimal = 0 To COMP_INVOCE_CACHEDataGridView.Rows.Count - 1
                totala += COMP_INVOCE_CACHEDataGridView.Rows(i).Cells(5).Value
                LinkLabel1.Text = totala
            Next
            LinkLabel2.Text = SaryalTextBox.Text
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("لم يتم الحفظ بعض الحقول فارغه", , AppTitle)
            Exit Sub
        End Try
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Try
            Dim td As String
            BAY_from_comp_bayBindingSource.AddNew()
            chked()
            COMP_saryilTextBox.Text = SaryalTextBox.Text
            COMP_TOTALTextBox.Text = Val(LinkLabel1.Text)
            COMP_CACHTextBox.Text = txtCash.Text
            COMP_KENTTextBox.Text = txtKNET.Text
            COMP_aribcTextBox.Text = kokotxt(Val(LinkLabel1.Text), CurrencyMainAr, CurrencySubAr, True)
            Date_bayaTextBox.Text = Date.Now
            finel_sum()
            If txtRemaining.Text = "0" Then
                td = "نقدا"
            Else
                td = "أجل"
            End If
            Staytes1TextBox.Text = td
            Validate()
            ValidateChildren()
            BAY_from_comp_bayBindingSource.EndEdit()
            BAY_from_comp_bayTableAdapter.Update(DT_restrantDataSet.BAY_from_comp_bay)
            BAY_from_comp_bayBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(DT_restrantDataSet)
            BAY_from_comp_bayBindingSource.AddNew()
            BAY_from_comp_bayBindingSource.RemoveCurrent()
            btnPrint.Enabled = True
            btnPay.Enabled = False
            company_pay_finel_prinetTableAdapter.FillBy(DT_restrantDataSet.company_pay_finel_prinet, SaryalTextBox.Text)
            ReportViewer1.RefreshReport()
            ReportViewer2.RefreshReport()
            Saved = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        chked()
        finel_sum()
    End Sub

    Private Sub txtKNET_TextChanged(sender As Object, e As EventArgs) Handles txtKNET.TextChanged
        finel_sum()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If BA = 1 Then
            ReportViewer1.PrintDialog()
        Else
            ReportViewer2.PrintDialog()
        End If
        Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            COMP_INVOCE_CACHEBindingSource.RemoveCurrent()
            ValidateChildren()
            COMP_INVOCE_CACHEBindingSource.EndEdit()
            COMP_INVOCE_CACHETableAdapter.Update(DT_restrantDataSet.COMP_INVOCE_CACHE)
        Catch ex As Exception
            MsgBox("خطأ132", , Apptitle)
            Exit Sub
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

        Close()
    End Sub
End Class