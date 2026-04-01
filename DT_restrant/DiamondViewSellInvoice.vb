Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class DiamondViewSellInvoice
    Dim RptPath As String
    Public GetInvoce As DataTable

    Private Sub GetCastomAccReportPath()
        GetInvoceReportSettings(PathFiled:="SET_INVARCHR146")
        ReportViewer1.LocalReport.ReportPath = ReportPath

        If chkEngInvoice.Checked = True Then
            'Diamond-Eng
            If ChkWholeSale.Checked = False Then
                ReportViewer1.LocalReport.ReportPath = Replace(ReportPath, ".rdlc", "-EN.rdlc")
            Else
                ReportViewer1.LocalReport.ReportPath = Replace(ReportPath, ".rdlc", "-WholeSale-EN.rdlc")
            End If
        Else
            'Diamond-Ar
            If ChkWholeSale.Checked = False Then
                ReportViewer1.LocalReport.ReportPath = ReportPath
            Else
                ReportViewer1.LocalReport.ReportPath = Replace(ReportPath, ".rdlc", "-WholeSale.rdlc")
            End If
        End If
    End Sub

    Private Sub DiamondViewSellInvoice_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
        Dispose()
    End Sub

    Private Sub DiamondViewSellInvoice_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        frmMain.Timer1.Stop()

        GetCastomAccReportPath()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        txtInvoiceNo.SelectAll()
        txtInvoiceNo.Focus()
        If Not BackWorkLoodInv.IsBusy Then
            BackWorkLoodInv.RunWorkerAsync()
        End If
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Public Sub WeightSum()
        Try
            ReportViewer1.LocalReport.Refresh()

            Dim GetTotalSum As DataTable = GetRecordSet("SELECT descont, SUM(CAST(test_116 AS DECIMAL(18, 3))) AS test_116, SUM(GOLD_mezan) AS GOLD_mezan, " & vbCrLf &
                                    "SUM(DIMO_mezan) AS DIMO_mezan,SUM(DIMO_qult)as DIMO_qult, SUM(CAST(test_16 AS DECIMAL(18, 3))) AS test_16, " & vbCrLf &
                                    "SUM(CAST(test_13 AS DECIMAL(18, 3))) AS test_13, SUM(CAST(test_19 AS DECIMAL(18, 3))) AS test_19" & vbCrLf &
                                    "FROM dbo.dimon_invce where descont=N'" & txtInvoiceNo.Text.Trim & "' AND Item_Actv='1'  GROUP BY descont")
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
                ReportViewer1.RefreshReport()
                GetCastomAccReportPath()
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub InvoiceSearch()
        Try
            GetInvoce = GetRecordSet("select * from for_print_dimon_finel  where BAY_SARYAL = '" & txtInvoiceNo.Text & "' AND [Item_Actv] = 1")
            If GetInvoce.Rows.Count > 0 Then
                Dim ReportDataSource = New ReportDataSource("DataSet1", GetInvoce)
                ReportViewer1.LocalReport.DataSources.Clear()
                ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
                ReportViewer1.RefreshReport()
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                ReportViewer1.RefreshReport()
            ElseIf GetInvoce.Rows.Count < 0 Then
                MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
                txtInvoiceNo.SelectAll()
                txtInvoiceNo.Focus()
                ReportViewer1.Visible = False
            End If
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString)
            MsgBox("لا يوجد فاتورة مسجلة بهذا الرقم" & vbCrLf & "No Invoice with That No.", , AppTitle)
        End Try
    End Sub

    Private Sub chkEngInvoice_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkEngInvoice.CheckedChanged
        GetCastomAccReportPath()
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub txtInvoiceNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            InvoiceSearch()
            WeightSum()
            e.Handled = True
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        ReportViewer1.PrintDialog()
    End Sub

    Private Sub btnView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnView.Click
        GetCastomAccReportPath()
        InvoiceSearch()
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub ChkWholeSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkWholeSale.CheckedChanged
        GetCastomAccReportPath()
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub BackWorkLoodInv_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackWorkLoodInv.DoWork
        Dim GetInvNo As DataTable = GetRecordSet("SELECT [BAY_ID], [BAY_SARYAL] FROM [dimon_bay] WHERE [Item_Actv] = 1 ORDER BY [BAY_ID] DESC")
        If GetInvNo.Rows.Count > 0 Then
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.DataSource = GetInvNo)
            txtInvoiceNo.Invoke(Sub() txtInvoiceNo.DisplayMember = "BAY_SARYAL")
        End If
    End Sub

    Private Sub txtInvoiceNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtInvoiceNo.SelectedIndexChanged
        'BackWorkLoodInv.RunWorkerAsync()
    End Sub
End Class