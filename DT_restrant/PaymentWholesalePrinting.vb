Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Public Class PaymentWholesalePrinting
    Public SaveMode As Boolean = False
    Private Sub GetReportPath()
        GetInvoceReportPath(PathFiled:="Report_Path23")
        RepPaymentWholesalePrinting.LocalReport.ReportPath = ReportPath
    End Sub
    Private Sub printerSettings()
        Try
            Dim printerSettings As New PrinterSettings()
            printerSettings.Copies = If(PrintRepeat = "", "2", PrintRepeat)
            RepPaymentWholesalePrinting.PrinterSettings = printerSettings
            RepPaymentWholesalePrinting.PrintDialog()
        Catch ex As Exception
            MsgBox("انتظر ظهور الفاتورة علي الشاشة" & vbCrLf & "Wait for the Invoice to be Fully Dispalyed", , AppTitle)
        End Try
    End Sub
    Public Sub ReportPrint()
        GetReportPath()
        Dim DT As DataTable = GetRecordSet("SELECT * FROM  ReportDetailsWholesalePurchases   WHERE (InvID =N'" & comboxInvNO.Text.Trim & "')")
        If DT.Rows.Count > 0 Then
            Dim ReportDataSource = New ReportDataSource("DataSet1", DT)
            RepPaymentWholesalePrinting.LocalReport.DataSources.Clear()
            RepPaymentWholesalePrinting.LocalReport.DataSources.Add(ReportDataSource)
            RepPaymentWholesalePrinting.RefreshReport()
            RepPaymentWholesalePrinting.SetDisplayMode(DisplayMode.PrintLayout)
        Else
        End If
    End Sub
    Private Sub PaymentWholesalePrinting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        GetReportPath()
        ReportPrint()
        Me.RepPaymentWholesalePrinting.RefreshReport()
    End Sub
    Private Sub PaymentWholesalePrinting_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Timer1.Start()
        Dispose()
        SellBuyWholesale.Close()
    End Sub

    Private Sub PaymentWholesalePrinting_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        RepPaymentWholesalePrinting.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
        SellBuyWholesale.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ReportPrint()
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If SaveMode = False Then
            ReportPrint()
        ElseIf SaveMode = True Then
            SellBuyWholesale.SaveDataFromTPSellBuyWholesale(SellBuyWholesale.InvID)
            ReportPrint()
            SellBuyWholesale.ActivInput(Activ:=False)
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        printerSettings()
    End Sub
    Private Sub BackWorkerLodInvoce_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackWorkerLodInvoce.DoWork
        Dim GetInvNo As DataTable = GetRecordSet("SELECT InvID, Active FROM BAYWholesale WHERE (Active = 1) ORDER BY ID DESC")
        If GetInvNo.Rows.Count > 0 Then
            comboxInvNO.Invoke(Sub() comboxInvNO.DataSource = GetInvNo)
            comboxInvNO.Invoke(Sub() comboxInvNO.DisplayMember = "InvID")
        End If
    End Sub

    Private Sub comboxInvNO_DropDown(sender As Object, e As EventArgs) Handles comboxInvNO.DropDown
        If comboxInvNO.Items.Count <> 0 Then
            comboxInvNO.SelectedIndex = comboxInvNO.Items.Count - 1
        ElseIf comboxInvNO.Items.Count <= 0 Then
            BackWorkerLodInvoce.RunWorkerAsync()
            comboxInvNO.SelectedIndex = comboxInvNO.Items.Count - 1
        End If
    End Sub
End Class