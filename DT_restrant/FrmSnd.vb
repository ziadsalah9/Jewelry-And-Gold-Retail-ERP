Imports DT_restrant.DT_restrantDataSetTableAdapters
Imports Microsoft.Reporting.WinForms
Imports PACICardLibrary
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Net.Mail

Public Class FrmSnd
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
    Private Sub CalculatorPayment()
        Try
            TxtTotal.Text = (Val(TxtCash.Text) + Val(TxtBank.Text) + Val(txtBank1.Text) + Val(txtBank2.Text) + Val(txtBank3.Text) + Val(txtBank4.Text)).ToString("0.000")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub PrinetInv()
        FrmPupPrentInv.TxtInv.Text = LabSndTxtNo.Text.Trim
        ReportPath = If(RidoPersonal.Checked = True, "SELECT [Report_Path5]  FROM [ReportPath]", "SELECT [Report_Path6]  FROM [ReportPath]")
        SqlFillCom = "SELECT SndNumber FROM SndToCustomer WHERE Activite = '1'"
        SqlComGetInv = "select * from ViwSndToCustomer where SndNumber ='"
        FrmPupPrentInv.InvShow()
        FrmPupPrentInv.ShowDialog()
    End Sub
    Dim paci As PACMAN
    Dim stringReader1 As String
    Public texte As String
    Public saryil As String
    Private InvoiceNo As String
    Dim _clsSnd As New ClsSnd
    Public MAX_ID As String
    Public Sub GetLastInvNo()
        Try
            Dim DT As DataTable = GetRecordSet("SELECT SndNumber +1 AS SndNumber FROM SndToCustomer WHERE Id=(SELECT max(Id) FROM SndToCustomer)")
            If DT.Rows.Count > 0 Then
                LabSndTxtNo.Text = Val(DT.Rows(0)(0).ToString)
            Else
                LabSndTxtNo.Text = "1"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub Get_Casher_Data()
        Try
            Dim DT As DataTable = GetRecordSet("SELECT * FROM cacher")
            If DT.Rows.Count > 0 Then
                ComCasher.DataSource = DT
                ComCasher.DisplayMember = "cacher_name"
                ComCasher.ValueMember = "svil_id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub Get_comp_Data()
        Try
            Dim DT As DataTable = GetRecordSet("SELECT * FROM COMPANY_BAY_DETELS")
            If DT.Rows.Count > 0 Then
                Cob_Comp_nam.DataSource = DT
                Cob_Comp_nam.DisplayMember = "COMP_NAME_SHORT"
                Cob_Comp_nam.ValueMember = "COMP_NAME_SHORT"
                Cob_Comp_nam.DropDownWidth = GetMaxDataSize(DT, "COMP_NAME_SHORT", Cob_Comp_nam)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub GetBondType()
        GetFillComboBox(ComboBoxName:=ComSndType, DisMem:=If(frmLogin.rbtnEn.Checked = True, "BondTypeEnName", "BondTypeArName"),
        SqlCom:=("SELECT * FROM [TBBondType] WHERE [BondTypeActiv] ='1'"), ValMem:="BondTypeID")
    End Sub
    Private Sub GetPayMethod()
        GetFillComboBox(ComboBoxName:=ComPaymentMethod, DisMem:=If(frmLogin.rbtnEn.Checked = True, "PayMethodEn", "PayMethodAr"),
        SqlCom:=("SELECT [ID] , [PayMethodAr] , [PayMethodEn] FROM [PayMethod] WHERE [Active] ='1'"), ValMem:="ID")
    End Sub
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSave.Click
        If RidoPersonal.Checked = False And RidoComp.Checked = False Then
            MsgBox("اختر نوع السند" & vbCrLf & "Choose the type of bond", , "خطأ")
            Return
        End If
        If RidoComp.Checked = True And Cob_Comp_nam.Text = "" Or IsDBNull(Cob_Comp_nam.Text) Then
            'MsgBox("اختر اسم المورد/الشركه/الورشه" & vbCrLf & "Choose the name of the supplier/company/workshop", , "خطأ")
            If IsDBNull(Cob_Comp_nam.Text) Or Cob_Comp_nam.SelectedIndex = -1 Then
                MsgBox("اختر اسم المورد/الشركه/الورشه" & vbCrLf & "Choose the name of the supplier/company/workshop", , "خطأ")
                Cob_Comp_nam.DroppedDown = True
                Return
            End If

            Return
        End If

        Dim CID As String = CivilIDForm.txtCID.Text.Trim
        If CivilIDForm.SaveCustomerData() = False Then
            Exit Sub
        Else
            CivilIDForm.txtCID.Enabled = False
        End If

        If ComSndType.SelectedIndex = -1 Or ComSndType.Text = String.Empty Then
            MsgBox("لم يتم تحديد نوع السند" & vbCrLf & "The type of bond is not specified", , "خطأ")
            ComSndType.DroppedDown = True
            Return
        End If
        If TxtTotal.Text = 0 Or TxtTotal.Text = String.Empty Then
            MsgBox("الاجمالى يساوى صفر" & vbCrLf & "The total equals zero", , "خطأ")
            Return
        End If
        If ComPaymentMethod.Text = String.Empty Then
            MsgBox("طريقة الدفع غير مكتملة" & vbCrLf & "Payment method is incomplete", , "خطأ")
            Return
        End If
        If String.IsNullOrWhiteSpace(TxtNote.Text) Then
            MsgBox("اكتب البيان" & vbCrLf & "Write the Description", , "خطأ")
            Return
        End If
        If String.IsNullOrWhiteSpace(ComCasher.Text) Then
            MsgBox("اختر الكاشير" & vbCrLf & "Choose the cashier", , "خطأ")
            ComCasher.DroppedDown = True
            Return
        End If
        GlCommand.CommandText = " INSERT INTO [SndToCustomer]" & vbCrLf &
                                   "([SndNumber]" & vbCrLf &
                                   " ,[Amount]" & vbCrLf &
                                   ",[Cash]" & vbCrLf &
                                   ",[Kent]" & vbCrLf &
                                   ",[Date_]" & vbCrLf &
                                   ",[Time_]" & vbCrLf &
                                   ",[Note_]" & vbCrLf &
                                   ",[NumToWorld_AR]" & vbCrLf &
                                   ",[NumToWorld_EN]" & vbCrLf &
                                   ",[Activite]" & vbCrLf &
                                   ",[SndType]" & vbCrLf &
                                   ",[Casher]" & vbCrLf &
                                   ",[UserId]" & vbCrLf &
                                   ",[civilid]" & vbCrLf &
                                   ",[PayMID]" & vbCrLf &
                                   ",[CompName]" & vbCrLf &
                                   ",[SndPhoto]" & vbCrLf &
                                   ",[TypeTransaction]" & vbCrLf &
                                   ",[LastEditDate]" & vbCrLf &
                                   ",[CreationDate]" & vbCrLf &
                                   ",[PayMethod1]" & vbCrLf &
                                   ",[PayMethod2]" & vbCrLf &
                                   ",[PayMethod3]" & vbCrLf &
                                   ",[PayMethod4]" & vbCrLf &
                                   ",[Bank1]" & vbCrLf &
                                   ",[Bank2]" & vbCrLf &
                                   ",[Bank3]" & vbCrLf &
                                   ",[Bank4])" & vbCrLf &
                                   "VALUES" & vbCrLf &
                                   "(@SndNumber" & vbCrLf &
                                   ",@Amount" & vbCrLf &
                                   ",@Cash" & vbCrLf &
                                   ",@Kent" & vbCrLf &
                                   ",@Date_" & vbCrLf &
                                   ",@Time_" & vbCrLf &
                                   ",@Note_" & vbCrLf &
                                   ",@NumToWorld_AR" & vbCrLf &
                                   ",@NumToWorld_EN" & vbCrLf &
                                   ",@Activite" & vbCrLf &
                                   ",@SndType" & vbCrLf &
                                   ",@Casher" & vbCrLf &
                                   ",@UserId" & vbCrLf &
                                   ",@civilid" & vbCrLf &
                                   ",@PayMID" & vbCrLf &
                                   ",@CompName" & vbCrLf &
                                   ",@SndPhoto" & vbCrLf &
                                   ",@TypeTransaction" & vbCrLf &
                                   ",@LastEditDate" & vbCrLf &
                                   ",@CreationDate" & vbCrLf &
                                   ",@PayMethod1" & vbCrLf &
                                   ",@PayMethod2" & vbCrLf &
                                   ",@PayMethod3" & vbCrLf &
                                   ",@PayMethod4" & vbCrLf &
                                   ",@Bank1" & vbCrLf &
                                   ",@Bank2" & vbCrLf &
                                   ",@Bank3" & vbCrLf &
                                   ",@Bank4)"
        With GlCommand.Parameters
            .Clear()
            .AddWithValue("@SndNumber", LabSndTxtNo.Text.Trim)
            .AddWithValue("@Amount", TxtTotal.Text.Trim())
            .AddWithValue("@Cash", If(IsDBNull(TxtCash.Text.Trim), "0", Val(TxtCash.Text.Trim)))
            .AddWithValue("@Kent", If(IsDBNull(TxtBank.Text.Trim), "0", Val(TxtBank.Text.Trim)))
            .AddWithValue("@Date_", DateToSave(dtExpensesDate.Value))
            .AddWithValue("@Time_", DateTimeToView(dtExpensesDate.Value))
            .AddWithValue("@Note_", TxtNote.Text.Trim)
            .AddWithValue("@NumToWorld_AR", kokotxt(Val(TxtTotal.Text.Trim), CurrencyMainAr, CurrencySubAr, True))
            .AddWithValue("@NumToWorld_EN", ConvertNumberToENG(Val(TxtTotal.Text.Trim)))
            .AddWithValue("@Activite", "1")
            .AddWithValue("@SndType", ComSndType.SelectedValue)
            .AddWithValue("@Casher", ComCasher.SelectedValue)
            .AddWithValue("@UserId", frmLogin.User_idTextBox.Text.Trim)
            .AddWithValue("@civilid", CivilIDForm.txtCID.Text.Trim)
            .AddWithValue("@PayMID", If(ComPaymentMethod.SelectedIndex = -1, 0, ComPaymentMethod.SelectedValue))
            .AddWithValue("@CompName", Cob_Comp_nam.Text.Trim)
            .AddWithValue("@SndPhoto", SqlDbType.Image).Value = ImageToByte(pbPhoto.Image)
            .AddWithValue("@TypeTransaction", If(RidoPersonal.Checked = True, 0, RidoComp.Checked = True))
            .AddWithValue("@LastEditDate", (Date.Now))
            .AddWithValue("@CreationDate", (Date.Now))
            .AddWithValue("@PayMethod1", If(cmbPayMethod1.SelectedIndex = -1, 0, cmbPayMethod1.SelectedValue))
            .AddWithValue("@PayMethod2", If(cmbPayMethod2.SelectedIndex = -1, 0, cmbPayMethod2.SelectedValue))
            .AddWithValue("@PayMethod3", If(cmbPayMethod3.SelectedIndex = -1, 0, cmbPayMethod3.SelectedValue))
            .AddWithValue("@PayMethod4", If(cmbPayMethod4.SelectedIndex = -1, 0, cmbPayMethod4.SelectedValue))
            .AddWithValue("@Bank1", If(IsDBNull(txtBank1.Text.Trim), "0", Val(txtBank1.Text.Trim)))
            .AddWithValue("@Bank2", If(IsDBNull(txtBank2.Text.Trim), "0", Val(txtBank2.Text.Trim)))
            .AddWithValue("@Bank3", If(IsDBNull(txtBank3.Text.Trim), "0", Val(txtBank3.Text.Trim)))
            .AddWithValue("@Bank4", If(IsDBNull(txtBank4.Text.Trim), "0", Val(txtBank4.Text.Trim)))
        End With
        GlCommand.ExecuteNonQuery()
        If MsgBox("تم الحفظ اضغط نعم للطباعه او  الغاء الامر" & vbCrLf & "Saved, click Yes to print or cancel", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "سند صرف/قبض نقدي" & vbCrLf & "Bond issued/received cash") = MsgBoxResult.Ok Then
            PrinetInv()
            MsgBox("تم حفظ السند و طباعته" & vbCrLf & "The Bond Was Saved And Printed.", , AppTitle)
        Else
            MsgBox("تم حفظ السند دون طباعته" & vbCrLf & "Delete Cancelled.", , AppTitle)
            Beep()
            'Exit Sub
        End If

        If MsgBox("اضغط نعم لانشاء سند جديد او  الغاء الامر" & vbCrLf & "Click Yes to create a new Bond or cancel the order", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "سند صرف/قبض نقدي" & vbCrLf & "Bond issued/received cash") = MsgBoxResult.Ok Then
            Try
                CivilIDForm.txtCID.Clear()
                CivilIDForm.txtCID.Enabled = True
            Catch ex As Exception
            End Try
            GetLastInvNo()
        Else
            Me.Close()
        End If
    End Sub
    Public Sub Checked_Act()
        If RidoPersonal.Checked = True Then
            RidoComp.Checked = False
            Cob_Comp_nam.Enabled = False
            Cob_Comp_nam.Text = ""
        ElseIf RidoPersonal.Checked = False Then
            RidoComp.Checked = True
            Cob_Comp_nam.Enabled = True
        End If
    End Sub
    Private Sub FrmSnd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub
    Private Sub FrmNewSnd_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        Try
            CivilIDForm = New CivilID With {.Bounds = New Rectangle(2, 0, 995, 255)}
            Controls.Add(CivilIDForm)
            CardServiceStart()
            paci = New PACMAN
        Catch ex As Exception
        End Try

        Get_Casher_Data()
        GetLastInvNo()
        Get_comp_Data()
        GetPayMethod()
        GetPayMethodSelect()
        Cob_Comp_nam.Enabled = False
        Cob_Comp_nam.Text = ""
        frmMain.Timer1.Stop()
        GetBondType()
        ComSndType.SelectedIndex = -1
        ComCasher.SelectedIndex = -1
        Cob_Comp_nam.SelectedIndex = -1
        Dim PayMethodSet As DataTable = GetRecordSet("select [SET5],[SET6],[SET7],[SET8],[SET9] from [Settings]")
        If PayMethodSet.Rows.Count > 0 Then
            cmbPayMethod1.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET5")), 0, (PayMethodSet.Rows(0)("SET5")))
            cmbPayMethod2.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET6")), 1, (PayMethodSet.Rows(0)("SET6")))
            cmbPayMethod3.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET7")), 2, (PayMethodSet.Rows(0)("SET7")))
            cmbPayMethod4.SelectedIndex = If(IsDBNull(PayMethodSet.Rows(0)("SET8")), 3, (PayMethodSet.Rows(0)("SET8")))
            If (PayMethodSet.Rows(0)("SET9").ToString) = 0 Then
                PnlPyment.Visible = False
            ElseIf (PayMethodSet.Rows(0)("SET9").ToString) = 1 Then
                PnlPyment.Visible = True
            End If
        End If
    End Sub
    Private Sub FrmSnd_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub Ra_Pars_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RidoPersonal.CheckedChanged
        Checked_Act()
    End Sub

    Private Sub Ra_comp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RidoComp.CheckedChanged
        Checked_Act()
    End Sub

    Private Sub btnCompName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompName.Click
        frmSuppliers.ShowDialog()
    End Sub

    Private Sub Cob_Comp_nam_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cob_Comp_nam.DropDown
        '
    End Sub

    Private Sub TxtCash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCash.TextChanged
        CalculatorPayment()
    End Sub

    Private Sub TxtBank_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBank.TextChanged
        CalculatorPayment()
    End Sub

    Private Sub btnAddPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPhoto.Click
        Dim OFD As New OpenFileDialog
        pbPhoto.BackgroundImageLayout = ImageLayout.Stretch
        OFD.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                pbPhoto.Image = Image.FromFile(.FileName)
            Else
                Return
            End If
        End With
        pbPhoto.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub VFormButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(ReportPath.ToString)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmBondType.ShowDialog()
    End Sub

    Private Sub txtBank1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank1.TextChanged
        CalculatorPayment()
    End Sub

    Private Sub txtBank2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank2.TextChanged
        CalculatorPayment()
    End Sub

    Private Sub txtBank3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank3.TextChanged
        CalculatorPayment()
    End Sub

    Private Sub txtBank4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBank4.TextChanged
        CalculatorPayment()
    End Sub

    Private Sub Cob_Comp_nam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cob_Comp_nam.SelectedIndexChanged

    End Sub

    Private Sub FrmSnd_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub
End Class