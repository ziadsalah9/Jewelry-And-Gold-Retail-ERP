
Imports PACICardLibrary
Imports Microsoft.Reporting.WinForms
Public Class FrmEditDelete
    Public Sub PrinetInv()
        Dim GetSndType As DataTable = GetRecordSet("SELECT [SndType] FROM [SndToCustomer]")
        If GetSndType.Rows.Count > 0 Then
            FrmPupPrentInv.TxtInv.Text = CmbInvNo.Text.Trim
            ReportPath = If(GetSndType.Rows(0)("SndType").ToString = 1, "SELECT [Report_Path5]  FROM [ReportPath]", "SELECT [Report_Path6]  FROM [ReportPath]")
            SqlFillCom = "SELECT SndNumber FROM SndToCustomer WHERE Activite = '1'"
            SqlComGetInv = "select * from ViwSndToCustomer where SndNumber ='"
            FrmPupPrentInv.InvShow()
            FrmPupPrentInv.ShowDialog()
        End If
    End Sub
    Private Sub FrmEditDelete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        frmMain.Timer1.Stop()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        GetCashier(cmbCashier:=ComCasher)
        '''''''''''''''''''''''''''''''''''''''''''''''''
        GetPayMethod(cmbPayMethod:=ComPaymentMethod)
        '''''''''''''''''''''''''''''''''''''''''''''
        GetFillComboBox(ComboBoxName:=CmbInvNo, SqlCom:="SELECT ExpensesID,ExpensesInvID, Active FROM Expenses WHERE (Active = 1)", DisMem:="ExpensesInvID", ValMem:="ExpensesInvID")
        GetFillComboBox(ComboBoxName:=cmbExpensesType, SqlCom:="SELECT * FROM [ExpensesType]", DisMem:="ExpensesType", ValMem:="ExpensesType")
        GetFillComboBox(ComboBoxName:=CmbCashVoucherNo, SqlCom:="SELECT * FROM SndToCustomer  WHERE Activite = '1'", DisMem:="SndNumber", ValMem:="SndNumber")
        ComPaymentMethod.SelectedIndex = -1
        ComCasher.SelectedIndex = -1
        CmbInvNo.SelectedIndex = -1
        cmbExpensesType.SelectedIndex = -1
        CmbCashVoucherNo.SelectedIndex = -1
        DateToSave(dtExpensesDate.Value)
    End Sub

    Private Sub btnExpensesPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpensesPhoto.Click
        Dim OFD As New OpenFileDialog
        pbExpensesPhoto.BackgroundImageLayout = ImageLayout.Stretch
        OFD.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                pbExpensesPhoto.Image = Image.FromFile(.FileName)
            Else
                Return
            End If
        End With
        pbExpensesPhoto.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub btnItemName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemName.Click
        ExpType.ShowDialog()
    End Sub

    Private Sub btnCashVoucherShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCashVoucherShow.Click
        'FrmSnd.ShowDialog()
        PrinetInv()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        ClearInnerControls(pnlItemDetails)
        ClearControls(pnlItemDetails)
        Dim dt1 As DataTable = GetRecordSet(" SELECT dbo.Expenses.ExpensesID, dbo.Expenses.ExpensesType, " &
                                            " dbo.Expenses.ExpensesDate, dbo.Expenses.ExpensesUserID, " &
                                            " dbo.Expenses.ExpensesCashValue, dbo.Expenses.ExpensesKNETValue, " &
                                            " dbo.Expenses.ExpensesPhoto, dbo.Expenses.ExpensesDescription, " &
                                            " dbo.Expenses.PayMethod, dbo.Expenses.Active, dbo.Expenses.CashVoucherNo, dbo.Expenses.ExpensesInvID, " &
                                            " dbo.Expenses.ExpensesDateTime, dbo.Expenses.Cacher, dbo.[user].user_name, " &
                                            " dbo.cacher.cacher_name, dbo.PayMethod.PayMethodAr, dbo.PayMethod.PayMethodEn " &
                                            " FROM dbo.Expenses LEFT OUTER JOIN " &
                                            " dbo.PayMethod ON dbo.Expenses.PayMethod = dbo.PayMethod.ID LEFT OUTER JOIN " &
                                            " dbo.cacher ON dbo.Expenses.Cacher = dbo.cacher.svil_id LEFT OUTER JOIN " &
                                            " dbo.[user] ON dbo.Expenses.ExpensesInvID = dbo.[user].user_id " &
                                            " WHERE (dbo.Expenses.Active = 1) AND (dbo.Expenses.ExpensesInvID = N'" & CmbInvNo.SelectedValue & "')")
        If dt1.Rows.Count > 0 Then
            cmbExpensesType.SelectedValue = dt1.Rows(0)("ExpensesType").ToString
            ComCasher.SelectedValue = dt1.Rows(0)("Cacher").ToString
            txtExpensesDescription.SelectedText = dt1.Rows(0)("ExpensesDescription").ToString
            CmbCashVoucherNo.SelectedValue = dt1.Rows(0)("CashVoucherNo").ToString
            txtExpensesKNETValue.Text = dt1.Rows(0)("ExpensesKNETValue").ToString
            txtExpensesCashValue.Text = dt1.Rows(0)("ExpensesCashValue").ToString
            ComPaymentMethod.SelectedText = If(frmLogin.rbtnEn.Checked = True, dt1.Rows(0)("PayMethodEn").ToString, dt1.Rows(0)("PayMethodAr").ToString)
            laltotal.Text = Val(dt1.Rows(0)("ExpensesCashValue").ToString) + Val(dt1.Rows(0)("ExpensesKNETValue").ToString)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If Not IsDBNull((dt1.Rows(0)("ExpensesPhoto"))) Then
                pbExpensesPhoto.Image = ByteToImage(dt1.Rows(0)("ExpensesPhoto"))
            ElseIf IsDBNull((dt1.Rows(0)("ExpensesPhoto"))) Then
            End If
        End If
    End Sub

    Private Sub btnDeleteInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteInvoice.Click
        ComCasher.SelectedValue = -1
    End Sub
End Class