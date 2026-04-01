Imports System.Data.SqlClient
Public Class Report_Path
    Dim SqlCon As New SqlConnection
    Dim SqlCom As New SqlCommand
    Dim SqlDataRe As SqlDataReader
    Dim DataTab As New DataTable
    Dim SqlDataAda As New SqlDataAdapter
    Private Function SafeStr(value As Object) As String
        If value Is Nothing OrElse value Is DBNull.Value Then Return String.Empty
        Return value.ToString()
    End Function

    Public Sub ClearControler()
        ClearInnerControls(GboxSilver)
        ClearInnerControls(GboxDia)
        ClearInnerControls(GboxGold)
        ClearInnerControls(GboxBond)
        Grid.Rows.Clear()
        Grid.RefreshEdit()
    End Sub
    Private Function LoadReportPath(ByVal connectionString As String) As DataTable
        Dim dt As New DataTable()
        Using cn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand("SELECT * FROM dbo.ReportPath", cn)
                cmd.CommandType = CommandType.Text
                cmd.CommandTimeout = 30
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function
    Public Sub LOOD_DATA()
        Try
            Dim connStr As String = SqlServerConnectionString
            Dim dt As DataTable = LoadReportPath(connStr)
            If dt Is Nothing OrElse dt.Rows.Count = 0 Then Exit Sub
            Grid.SuspendLayout()
            Grid.Rows.Clear()
            For Each r As DataRow In dt.Rows
                Dim rowIndex As Integer = Grid.Rows.Add()
                Dim row As DataGridViewRow = Grid.Rows(rowIndex)
                row.Cells("colDiamondSellShort").Value = SafeStr(r("Report_Path1"))
                row.Cells("colDiamondSellPayDetails").Value = SafeStr(r("Report_Path2"))
                row.Cells("colDiamondBuyPayDetails_A4").Value = SafeStr(r("Report_Path3"))
                row.Cells("colGoldBuyPay").Value = SafeStr(r("Report_Path4"))
                row.Cells("colBondCashPersonal").Value = SafeStr(r("Report_Path5"))
                row.Cells("colBondCashComp").Value = SafeStr(r("Report_Path6"))
                row.Cells("colDiamondSellDetailedPortrait").Value = SafeStr(r("Report_Path7"))
                row.Cells("colTPSellBuyWholesaleInvoce").Value = SafeStr(r("Report_Path8"))
                row.Cells("colExpensesInv").Value = SafeStr(r("Report_Path9"))
                row.Cells("colBondCashDetailed").Value = SafeStr(r("Report_Path10"))
                row.Cells("colSilverSellPay").Value = SafeStr(r("Report_Path11"))
                row.Cells("colSilverBuyPay").Value = SafeStr(r("Report_Path12"))
                row.Cells("colSilverSellReport").Value = SafeStr(r("Report_Path13"))
                row.Cells("colGoldSellReport").Value = SafeStr(r("Report_Path17"))
                row.Cells("colGoldGoldVoucher").Value = SafeStr(r("Report_Path18"))
                row.Cells("colSilvertemAvailable").Value = SafeStr(r("Report_Path19"))
                row.Cells("GoldSellReportShort").Value = SafeStr(r("Report_Path20"))
                row.Cells("colGoldVoucherReserve").Value = SafeStr(r("Report_Path21"))
                row.Cells("colAccessoriesReportShort").Value = SafeStr(r("Report_Path22"))
                row.Cells("colWholesaleInvoce").Value = SafeStr(r("Report_Path23"))
                row.Cells("coltxtGoldProfitsReport").Value = SafeStr(r("Report_Path24"))
                row.Cells("colDiamondSellShort").Value = SafeStr(r("Report_Path25"))
                row.Cells("colGoldSellReportShortKYC").Value = SafeStr(r("Report_Path26"))
                row.Cells("colSilverProfitsReport").Value = SafeStr(r("Report_Path27"))

                '
                'txtDiamondSellShort
            Next

            ' تعبئة الكنترولات من أول صف
            Re_Path_DiaSelShort.Text = SafeStr(dt.Rows(0)("Report_Path1"))
            TEXTDiaRepRwitRHeadR.Text = SafeStr(dt.Rows(0)("Report_Path2"))
            TeBoxDmonBAY.Text = SafeStr(dt.Rows(0)("Report_Path3"))
            TtBoxGoldBay.Text = SafeStr(dt.Rows(0)("Report_Path4"))
            RepSndToCust.Text = SafeStr(dt.Rows(0)("Report_Path5"))
            RepSndToComp.Text = SafeStr(dt.Rows(0)("Report_Path6"))
            rptDiamondSellDetailedPortrait.Text = SafeStr(dt.Rows(0)("Report_Path7"))
            ReportTPSellBuyWholesaleInvoce.Text = SafeStr(dt.Rows(0)("Report_Path8"))
            rptExpensesInv.Text = SafeStr(dt.Rows(0)("Report_Path9"))
            rptBondCashDetailed.Text = SafeStr(dt.Rows(0)("Report_Path10"))
            txtSilverInvoce.Text = SafeStr(dt.Rows(0)("Report_Path11"))
            txtSilverBay.Text = SafeStr(dt.Rows(0)("Report_Path12"))
            txtSilverSellReport.Text = SafeStr(dt.Rows(0)("Report_Path13"))
            txtGoldSellReport.Text = SafeStr(dt.Rows(0)("Report_Path17"))
            RepSndToGOLED.Text = SafeStr(dt.Rows(0)("Report_Path18"))
            txtSilvertemAvailable.Text = SafeStr(dt.Rows(0)("Report_Path19"))
            txtGoldSellReportShort.Text = SafeStr(dt.Rows(0)("Report_Path20"))
            txtGoldVoucherReserve.Text = SafeStr(dt.Rows(0)("Report_Path21"))
            txtAccessoriesReportShort.Text = SafeStr(dt.Rows(0)("Report_Path22"))
            txtWholesaleInvoce.Text = SafeStr(dt.Rows(0)("Report_Path23"))
            txtGoldProfitsReport.Text = SafeStr(dt.Rows(0)("Report_Path24"))
            txtDiamondSellShort.Text = SafeStr(dt.Rows(0)("Report_Path25"))
            txtGoldSellReportShortKYC.Text = SafeStr(dt.Rows(0)("Report_Path26"))
            txtSilverProfitsReport.Text = SafeStr(dt.Rows(0)("Report_Path27"))
            'colSilverProfitsReport
            Grid.ResumeLayout()
        Catch ex As Exception
            RecordRrrors(DescriptionRrrors:=ex.ToString())
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '  
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            DataTab.Clear()
            SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
            SqlCon.Open()
            SqlCom.Connection = SqlCon
            SqlCom.CommandText = "UPDATE ReportPath SET Report_Path1='" & Re_Path_DiaSelShort.Text.Trim & "'"
            SqlDataRe = SqlCom.ExecuteReader
            DataTab.Load(SqlDataRe)
            SqlDataRe.Close()
            SqlCon.Close()
            LOOD_DATA()
            MsgBox(MsgBox("تم تحديث المسار" & vbCrLf & "Path Updated", , AppTitle))
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Report_Path_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
         DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
        LOOD_DATA()
        TooltipHelper.EnableTextBoxTooltips(Me)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                Re_Path_DiaSelShort.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                TEXTDiaRepRwitRHeadR.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            DataTab.Clear()
            SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
            SqlCon.Open()
            SqlCom.Connection = SqlCon
            SqlCom.CommandText = "UPDATE ReportPath SET Report_Path2='" & TEXTDiaRepRwitRHeadR.Text.Trim & "'"
            SqlDataRe = SqlCom.ExecuteReader
            DataTab.Load(SqlDataRe)
            SqlDataRe.Close()
            SqlCon.Close()
            LOOD_DATA()
            MsgBox(MsgBox("تم تحديث المسار" & vbCrLf & "Path update", , AppTitle))
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                TeBoxDmonBAY.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub


    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                TtBoxGoldBay.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            DataTab.Clear()
            SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
            SqlCon.Open()
            SqlCom.Connection = SqlCon
            SqlCom.CommandText = "UPDATE ReportPath SET Report_Path3='" & TeBoxDmonBAY.Text.Trim & "'"
            SqlDataRe = SqlCom.ExecuteReader
            DataTab.Load(SqlDataRe)
            SqlDataRe.Close()
            SqlCon.Close()
            LOOD_DATA()
            MsgBox(MsgBox("تم تحديث المسار" & vbCrLf & "Path update", , AppTitle))
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try
            DataTab.Clear()
            SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
            SqlCon.Open()
            SqlCom.Connection = SqlCon
            SqlCom.CommandText = "UPDATE ReportPath SET Report_Path4='" & TtBoxGoldBay.Text.Trim & "'"
            SqlDataRe = SqlCom.ExecuteReader
            DataTab.Load(SqlDataRe)
            SqlDataRe.Close()
            SqlCon.Close()
            LOOD_DATA()
            MsgBox("تم تحديث المسار" & vbCrLf & "Path update", , AppTitle)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub DataSave()
        Dim Path1 As String = If(IsDBNull(Re_Path_DiaSelShort.Text.Trim) Or (Re_Path_DiaSelShort.Text.Trim = ""), Application.StartupPath & "\Report\rptDiamondSellShort.rdlc", Re_Path_DiaSelShort.Text.Trim)
        Dim Path2 As String = If(IsDBNull(TEXTDiaRepRwitRHeadR.Text.Trim) Or (TEXTDiaRepRwitRHeadR.Text.Trim = ""), Application.StartupPath & "\Report\rptDiamondSellPayDetails(A4)-background.rdlc", TEXTDiaRepRwitRHeadR.Text.Trim)
        Dim Path3 As String = If(IsDBNull(TeBoxDmonBAY.Text.Trim) Or (TeBoxDmonBAY.Text.Trim = ""), Application.StartupPath & "\Report\rptDiamondBuyPayDetails_A4.rdlc", TeBoxDmonBAY.Text.Trim)
        Dim Path4 As String = If(IsDBNull(TtBoxGoldBay.Text.Trim) Or (TtBoxGoldBay.Text.Trim = ""), Application.StartupPath & "\Report\rptGoldBuyPay.rdlc", TtBoxGoldBay.Text.Trim)
        Dim Path5 As String = If(IsDBNull(RepSndToCust.Text.Trim) Or (RepSndToCust.Text.Trim = ""), Application.StartupPath & "\Report\rptBondCashPersonal.rdlc", RepSndToCust.Text.Trim)
        Dim Path6 As String = If(IsDBNull(RepSndToComp.Text.Trim) Or (RepSndToComp.Text.Trim = ""), Application.StartupPath & "\Report\rptBondCashComp.rdlc", RepSndToComp.Text.Trim)
        Dim Path7 As String = If(IsDBNull(rptDiamondSellDetailedPortrait.Text.Trim) Or (rptDiamondSellDetailedPortrait.Text.Trim = ""), Application.StartupPath & "\Report\rptDiamondSellDetailedPortrait.rdlc", rptDiamondSellDetailedPortrait.Text.Trim)
        Dim Path8 As String = If(IsDBNull(ReportTPSellBuyWholesaleInvoce.Text.Trim) Or (ReportTPSellBuyWholesaleInvoce.Text.Trim = ""), Application.StartupPath & "\Report\ReportTPSellBuyWholesaleInvoce.rdlc", ReportTPSellBuyWholesaleInvoce.Text.Trim)
        Dim Path9 As String = If(IsDBNull(rptExpensesInv.Text.Trim) Or (rptExpensesInv.Text.Trim = ""), Application.StartupPath & "\Report\rptExpensesInv.rdlc", rptExpensesInv.Text.Trim)
        Dim Path10 As String = If(IsDBNull(rptBondCashDetailed.Text.Trim) Or (rptBondCashDetailed.Text.Trim = ""), Application.StartupPath & "\Report\rptBondCashDetailed.rdlc", rptBondCashDetailed.Text.Trim)
        Dim Path11 As String = If(IsDBNull(txtSilverInvoce.Text.Trim) Or (txtSilverInvoce.Text.Trim = ""), Application.StartupPath & "\Report\rptSilverSellPay.rdlc", txtSilverInvoce.Text.Trim)
        Dim Path12 As String = If(IsDBNull(txtSilverBay.Text.Trim) Or (txtSilverBay.Text.Trim = ""), Application.StartupPath & "\Report\rptSilverBuyPay.rdlc", txtSilverBay.Text.Trim)
        Dim Path13 As String = If(IsDBNull(txtSilverSellReport.Text.Trim) Or (txtSilverSellReport.Text.Trim = ""), Application.StartupPath & "\Report\rptSilverSellDetailed.rdlc", txtSilverSellReport.Text.Trim)
        Dim Path14 As String = If(IsDBNull(txtSilverItemDetails.Text.Trim) Or (txtSilverItemDetails.Text.Trim = ""), Application.StartupPath & "0", txtSilverItemDetails.Text.Trim)
        Dim Path15 As String = If(IsDBNull(txtSilverBay.Text.Trim) Or (txtSilverBay.Text.Trim = ""), Application.StartupPath & "0", txtSilverBay.Text.Trim)
        Dim Path16 As String = If(IsDBNull(txtSilverItemRemaining.Text.Trim) Or (txtSilverItemRemaining.Text.Trim = ""), Application.StartupPath & "0", txtSilverItemRemaining.Text.Trim)
        Dim Path17 As String = If(IsDBNull(txtGoldSellReport.Text.Trim) Or (txtGoldSellReport.Text.Trim = ""), Application.StartupPath & "\Report\rptGoldSellDetailed.rdlc", txtGoldSellReport.Text.Trim)
        Dim Path18 As String = If(IsDBNull(RepSndToGOLED.Text.Trim) Or (RepSndToGOLED.Text.Trim = ""), Application.StartupPath & "\Report\rptGoldGoldVoucher.rdlc", RepSndToGOLED.Text.Trim)
        Dim Path19 As String = If(IsDBNull(txtSilvertemAvailable.Text.Trim) Or (txtSilvertemAvailable.Text.Trim = ""), Application.StartupPath & "\Report\ReportSilvertemAvailable.rdlc", txtSilvertemAvailable.Text.Trim)
        Dim Path20 As String = If(IsDBNull(txtGoldSellReportShort.Text.Trim) Or (txtGoldSellReportShort.Text.Trim = ""), Application.StartupPath & "\Report\rptGoldSellShort.rdlc", txtGoldSellReportShort.Text.Trim)
        Dim Path21 As String = If(IsDBNull(txtGoldVoucherReserve.Text.Trim) Or (txtGoldVoucherReserve.Text.Trim = ""), Application.StartupPath & "\Report\rptGoldGoldVoucherReceive.rdlc", txtGoldVoucherReserve.Text.Trim)
        Dim Path22 As String = If(IsDBNull(txtAccessoriesReportShort.Text.Trim) Or (txtAccessoriesReportShort.Text.Trim = ""), Application.StartupPath & "\Report\rptViwAccessoriesInvoceReport.rdlc", txtAccessoriesReportShort.Text.Trim)
        Dim Path23 As String = If(IsDBNull(txtWholesaleInvoce.Text.Trim) Or (txtWholesaleInvoce.Text.Trim = ""), Application.StartupPath & "\Report\ReportTPSellBuyWholesaleInvoce.rdlc", txtWholesaleInvoce.Text.Trim)
        Dim Path24 As String = If(IsDBNull(txtGoldProfitsReport.Text.Trim) Or (txtGoldProfitsReport.Text.Trim = ""), Application.StartupPath & "\Report\rptGoldProfitsReport.rdlc", txtGoldProfitsReport.Text.Trim)
        Dim Path25 As String = If(IsDBNull(txtDiamondSellShort.Text.Trim) Or (txtDiamondSellShort.Text.Trim = ""), Application.StartupPath & "\Report\rptDiamondSellShort.rdlc", txtDiamondSellShort.Text.Trim)
        Dim Path26 As String = If(IsDBNull(txtGoldSellReportShortKYC.Text.Trim) Or (txtGoldSellReportShortKYC.Text.Trim = ""), Application.StartupPath & "\Report\rptGoldSellShortKYC.rdlc", txtGoldSellReportShortKYC.Text.Trim)
        Dim Path27 As String = If(IsDBNull(txtSilverProfitsReport.Text.Trim) Or (txtSilverProfitsReport.Text.Trim = ""), Application.StartupPath & "\Report\rptSilverProfitsReport.rdlc", txtSilverProfitsReport.Text.Trim)
        Dim dt1 As DataTable = GetRecordSet("SELECT * FROM ReportPath")
        If dt1.Rows.Count = 0 Then
            GlCommand.CommandText = "INSERT INTO ReportPath ([Report_Path1]  " & vbCrLf &
                                                            ",[Report_Path2]" & vbCrLf &
                                                            ",[Report_Path3]" & vbCrLf &
                                                            ",[Report_Path4]" & vbCrLf &
                                                            ",[Report_Path5]" & vbCrLf &
                                                            ",[Report_Path6]" & vbCrLf &
                                                            ",[Report_Path7]" & vbCrLf &
                                                            ",[Report_Path8]" & vbCrLf &
                                                            ",[Report_Path9]" & vbCrLf &
                                                            ",[Report_Path10]" & vbCrLf &
                                                            ",[Report_Path11]" & vbCrLf &
                                                            ",[Report_Path12]" & vbCrLf &
                                                            ",[Report_Path13]" & vbCrLf &
                                                            ",[Report_Path14]" & vbCrLf &
                                                            ",[Report_Path15]" & vbCrLf &
                                                            ",[Report_Path16]" & vbCrLf &
                                                            ",[Report_Path17]" & vbCrLf &
                                                            ",[Report_Path18]" & vbCrLf &
                                                            ",[Report_Path19]" & vbCrLf &
                                                            ",[Report_Path20]" & vbCrLf &
                                                            ",[Report_Path21]" & vbCrLf &
                                                            ",[Report_Path22]" & vbCrLf &
                                                            ",[Report_Path23]" & vbCrLf &
                                                            ",[Report_Path24]" & vbCrLf &
                                                            ",[Report_Path25]" & vbCrLf &
                                                            ",[Report_Path26]" & vbCrLf &
                                                            ",[Report_Path27])" & vbCrLf &
                                    " VALUES (" &
                                    "'" & Path1 & "' ," & vbCrLf &
                                    "'" & Path2 & "' ," & vbCrLf &
                                    "'" & Path3 & "' ," & vbCrLf &
                                    "'" & Path4 & "' ," & vbCrLf &
                                    "'" & Path5 & "' ," & vbCrLf &
                                    "'" & Path6 & "' ," & vbCrLf &
                                    "'" & Path7 & "' ," & vbCrLf &
                                    "'" & Path8 & "' ," & vbCrLf &
                                    "'" & Path9 & "' ," & vbCrLf &
                                    "'" & Path10 & "' ," & vbCrLf &
                                    "'" & Path11 & "' ," & vbCrLf &
                                    "'" & Path12 & "' ," & vbCrLf &
                                    "'" & Path13 & "' ," & vbCrLf &
                                    "'" & Path14 & "' ," & vbCrLf &
                                    "'" & Path15 & "' ," & vbCrLf &
                                    "'" & Path16 & "' ," & vbCrLf &
                                    "'" & Path17 & "' ," & vbCrLf &
                                    "'" & Path18 & "' ," & vbCrLf &
                                    "'" & Path19 & "' ," & vbCrLf &
                                    "'" & Path20 & "' ," & vbCrLf &
                                    "'" & Path21 & "' ," & vbCrLf &
                                    "'" & Path22 & "' ," & vbCrLf &
                                    "'" & Path23 & "' ," & vbCrLf &
                                    "'" & Path24 & "' ," & vbCrLf &
                                    "'" & Path25 & "' ," & vbCrLf &
                                     "'" & Path26 & "' ," & vbCrLf &
                                    "'" & Path27 & "')"
            GlCommand.ExecuteNonQuery()
        Else
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path1='" & Path1 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path2='" & Path2 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path3='" & Path3 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path4='" & Path4 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path5='" & Path5 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path6='" & Path6 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path7='" & Path7 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path8='" & Path8 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path9='" & Path9 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path10='" & Path10 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path11='" & Path11 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path12='" & Path12 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path13='" & Path13 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path14='" & Path14 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path15='" & Path15 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path16='" & Path16 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path17='" & Path17 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path18='" & Path18 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path19='" & Path19 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path20='" & Path20 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path21='" & Path21 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path22='" & Path22 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path23='" & Path23 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path24='" & Path24 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path25='" & Path25 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path26='" & Path26 & "'"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE ReportPath SET Report_Path27='" & Path27 & "'"
            GlCommand.ExecuteNonQuery()
            LOOD_DATA()
            MsgBox("تم تحديث المسار" & vbCrLf & "Path Updated", , AppTitle)
        End If
    End Sub
    Private Sub btnDefault_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDefault.Click
        If MsgBox("هل تريد تريد استعادة افتراضيات مسار التقارير؟", vbYesNo) = vbYes Then
            GlCommand.CommandText = "DELETE FROM [ReportPath]"
            GlCommand.ExecuteNonQuery()
            For i As Integer = 1 To Grid.Rows.Count > 0
                Grid.Rows.RemoveAt(i)
            Next
            ClearControler()
            Dim Path1 As String = Application.StartupPath & "\Report\rptDiamondSellShort.rdlc"
            Dim Path2 As String = Application.StartupPath & "\Report\rptDiamondSellPayDetails(A4)-background.rdlc"
            Dim Path3 As String = Application.StartupPath & "\Report\rptDiamondBuyPayDetails_A4.rdlc"
            Dim Path4 As String = Application.StartupPath & "\Report\rptGoldBuyPay.rdlc"
            Dim Path5 As String = Application.StartupPath & "\Report\rptBondCashPersonal.rdlc"
            Dim Path6 As String = Application.StartupPath & "\Report\rptBondCashComp.rdlc"
            Dim Path7 As String = Application.StartupPath & "\Report\rptDiamondSellDetailedPortrait.rdlc"
            Dim Path8 As String = Application.StartupPath & "\Report\ReportTPSellBuyWholesaleInvoce.rdlc"
            Dim Path9 As String = Application.StartupPath & "\Report\rptExpensesInv.rdlc"
            Dim Path10 As String = Application.StartupPath & "\Report\rptBondCashDetailed.rdlc"
            Dim Path11 As String = Application.StartupPath & "\Report\rptSilverSellPay.rdlc"
            Dim Path12 As String = Application.StartupPath & "\Report\rptSilverBuyPay.rdlc"
            Dim Path13 As String = Application.StartupPath & "\Report\rptSilverSellDetailed.rdlc"
            Dim Path14 As String = "0"
            Dim Path15 As String = "0"
            Dim Path16 As String = "0"
            Dim Path17 As String = Application.StartupPath & "\Report\rptGoldSellDetailed.rdlc"
            Dim Path18 As String = Application.StartupPath & "\Report\rptGoldGoldVoucher.rdlc"
            Dim Path19 As String = Application.StartupPath & "\Report\ReportSilvertemAvailable.rdlc"
            Dim Path20 As String = Application.StartupPath & "\Report\rptGoldSellShort.rdlc"
            Dim Path21 As String = Application.StartupPath & "\Report\rptGoldGoldVoucherReceive.rdlc"
            Dim Path22 As String = Application.StartupPath & "\Report\rptViwAccessoriesInvoceReport.rdlc"
            Dim Path23 As String = Application.StartupPath & "\Report\ReportTPSellBuyWholesaleInvoce.rdlc"
            Dim Path24 As String = Application.StartupPath & "\Report\rptGoldProfitsReport.rdlc"
            Dim Path25 As String = Application.StartupPath & "\Report\rptDiamondSellShort.rdlc"
            Dim Path26 As String = Application.StartupPath & "\Report\rptGoldSellShortKYC.rdlc"
            Dim Path27 As String = Application.StartupPath & "\Report\rptSilverProfitsReport.rdlc"
            Dim dt1 As DataTable = GetRecordSet("SELECT * FROM ReportPath")
            If dt1.Rows.Count = 0 Then
                GlCommand.CommandText = "INSERT INTO ReportPath ([Report_Path1]  " & vbCrLf &
                                                                ",[Report_Path2]" & vbCrLf &
                                                                ",[Report_Path3]" & vbCrLf &
                                                                ",[Report_Path4]" & vbCrLf &
                                                                ",[Report_Path5]" & vbCrLf &
                                                                ",[Report_Path6]" & vbCrLf &
                                                                ",[Report_Path7]" & vbCrLf &
                                                                ",[Report_Path8]" & vbCrLf &
                                                                ",[Report_Path9]" & vbCrLf &
                                                                ",[Report_Path10]" & vbCrLf &
                                                                ",[Report_Path11]" & vbCrLf &
                                                                ",[Report_Path12]" & vbCrLf &
                                                                ",[Report_Path13]" & vbCrLf &
                                                                ",[Report_Path14]" & vbCrLf &
                                                                ",[Report_Path15]" & vbCrLf &
                                                                ",[Report_Path16]" & vbCrLf &
                                                                ",[Report_Path17]" & vbCrLf &
                                                                ",[Report_Path18]" & vbCrLf &
                                                                ",[Report_Path19]" & vbCrLf &
                                                                ",[Report_Path20]" & vbCrLf &
                                                                ",[Report_Path21]" & vbCrLf &
                                                                ",[Report_Path22]" & vbCrLf &
                                                                ",[Report_Path23]" & vbCrLf &
                                                                ",[Report_Path24]" & vbCrLf &
                                                                ",[Report_Path25]" & vbCrLf &
                                                                ",[Report_Path26]" & vbCrLf &
                                                                ",[Report_Path27])" & vbCrLf &
                                        " VALUES (" &
                                        "'" & Path1 & "' ," & vbCrLf &
                                        "'" & Path2 & "' ," & vbCrLf &
                                        "'" & Path3 & "' ," & vbCrLf &
                                        "'" & Path4 & "' ," & vbCrLf &
                                        "'" & Path5 & "' ," & vbCrLf &
                                        "'" & Path6 & "' ," & vbCrLf &
                                        "'" & Path7 & "' ," & vbCrLf &
                                        "'" & Path8 & "' ," & vbCrLf &
                                        "'" & Path9 & "' ," & vbCrLf &
                                        "'" & Path10 & "' ," & vbCrLf &
                                        "'" & Path11 & "' ," & vbCrLf &
                                        "'" & Path12 & "' ," & vbCrLf &
                                        "'" & Path13 & "' ," & vbCrLf &
                                        "'" & Path14 & "' ," & vbCrLf &
                                        "'" & Path15 & "' ," & vbCrLf &
                                        "'" & Path16 & "' ," & vbCrLf &
                                        "'" & Path17 & "' ," & vbCrLf &
                                        "'" & Path18 & "' ," & vbCrLf &
                                        "'" & Path19 & "' ," & vbCrLf &
                                        "'" & Path20 & "' ," & vbCrLf &
                                        "'" & Path21 & "' ," & vbCrLf &
                                        "'" & Path22 & "' ," & vbCrLf &
                                        "'" & Path23 & "' ," & vbCrLf &
                                        "'" & Path24 & "' ," & vbCrLf &
                                       "'" & Path25 & "' ," & vbCrLf &
                                       "'" & Path26 & "' ," & vbCrLf &
                                        "'" & Path27 & "')"
                GlCommand.ExecuteNonQuery()
            Else
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path1='" & Path1 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path2='" & Path2 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path3='" & Path3 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path4='" & Path4 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path5='" & Path5 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path6='" & Path6 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path7='" & Path7 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path8='" & Path8 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path9='" & Path9 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path10='" & Path10 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path11='" & Path11 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path12='" & Path12 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path13='" & Path13 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path14='" & Path14 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path15='" & Path15 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path16='" & Path16 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path17='" & Path17 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path18='" & Path18 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path19='" & Path18 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path20='" & Path20 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path21='" & Path21 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path22='" & Path22 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path23='" & Path23 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path24='" & Path24 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path25='" & Path25 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path26='" & Path26 & "'"
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE ReportPath SET Report_Path27='" & Path27 & "'"
                GlCommand.ExecuteNonQuery()
                MsgBox("تم تحديث المسار" & vbCrLf & "Path Updated", , AppTitle)
            End If
        End If
        LOOD_DATA()
    End Sub
    Private Sub LinkLabel5_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                RepSndToCust.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub
    Private Sub Button1_Click_1(ByVal sender As Object, ByVal e As EventArgs)
        Try
            DataTab.Clear()
            SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
            SqlCon.Open()
            SqlCom.Connection = SqlCon
            SqlCom.CommandText = "UPDATE ReportPath SET Report_Path5='" & RepSndToCust.Text.Trim & "'"
            SqlDataRe = SqlCom.ExecuteReader
            DataTab.Load(SqlDataRe)
            SqlDataRe.Close()
            SqlCon.Close()
            LOOD_DATA()
            MsgBox("تم تحديث المسار" & vbCrLf & "Path update", , AppTitle)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            DataTab.Clear()
            SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
            SqlCon.Open()
            SqlCom.Connection = SqlCon
            SqlCom.CommandText = "UPDATE ReportPath SET Report_Path6 ='" & RepSndToComp.Text.Trim & "'"
            SqlDataRe = SqlCom.ExecuteReader
            DataTab.Load(SqlDataRe)
            SqlDataRe.Close()
            SqlCon.Close()

            LOOD_DATA()
            MsgBox("تم تحديث المسار" & vbCrLf & "Path update", , AppTitle)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub LinkLabel6_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.FileName = "rptGoldGoldVoucher.rdlc*"
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                RepSndToGOLED.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                RepSndToComp.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                rptDiamondSellDetailedPortrait.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            DataTab.Clear()
            SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
            SqlCon.Open()
            SqlCom.Connection = SqlCon
            SqlCom.CommandText = "UPDATE ReportPath SET Report_Path7 ='" & rptDiamondSellDetailedPortrait.Text.Trim & "'"
            SqlDataRe = SqlCom.ExecuteReader
            DataTab.Load(SqlDataRe)
            SqlDataRe.Close()
            SqlCon.Close()

            LOOD_DATA()
            MsgBox("تم تحديث المسار" & vbCrLf & "Path update", , AppTitle)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        'ReportTPSellBuyWholesaleInvoce
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                ReportTPSellBuyWholesaleInvoce.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            DataTab.Clear()
            SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
            SqlCon.Open()
            SqlCom.Connection = SqlCon
            SqlCom.CommandText = "UPDATE ReportPath SET Report_Path8 ='" & ReportTPSellBuyWholesaleInvoce.Text.Trim & "'"
            SqlDataRe = SqlCom.ExecuteReader
            DataTab.Load(SqlDataRe)
            SqlDataRe.Close()
            SqlCon.Close()

            LOOD_DATA()
            MsgBox("تم تحديث المسار" & vbCrLf & "Path update", , AppTitle)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            DataTab.Clear()
            SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
            SqlCon.Open()
            SqlCom.Connection = SqlCon
            SqlCom.CommandText = "UPDATE ReportPath SET Report_Path9 ='" & rptExpensesInv.Text.Trim & "'"
            SqlDataRe = SqlCom.ExecuteReader
            DataTab.Load(SqlDataRe)
            SqlDataRe.Close()
            SqlCon.Close()
            LOOD_DATA()
            MsgBox("تم تحديث المسار" & vbCrLf & "Path update", , AppTitle)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                rptExpensesInv.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'rptBondCashDetailed
        Try
            DataTab.Clear()
            SqlCon.ConnectionString = My.Settings.DT_restrantConnectionString10
            SqlCon.Open()
            SqlCom.Connection = SqlCon
            SqlCom.CommandText = "UPDATE ReportPath SET Report_Path10 ='" & rptBondCashDetailed.Text.Trim & "'"
            SqlDataRe = SqlCom.ExecuteReader
            DataTab.Load(SqlDataRe)
            SqlDataRe.Close()
            SqlCon.Close()

            LOOD_DATA()
            MsgBox("تم تحديث المسار" & vbCrLf & "Path update", , AppTitle)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub LinkLabel11_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                rptBondCashDetailed.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblSilverInvoce_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblSilverInvoce.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtSilverInvoce.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblSilverSellReport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblSilverSellReport.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtSilverSellReport.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblSilverSellReportShort_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblSilverSellReportShort.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtSilverSellReportShort.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblSilverItemDetails_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblSilverItemDetails.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtSilverItemDetails.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblSilverItemSold_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblSilverItemSold.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtSilverBay.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblSilverItemRemaining_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblSilverItemRemaining.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtSilverItemRemaining.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        DataSave()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblGoldSellReport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblGoldSellReport.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtGoldSellReport.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblSilvertemAvailable_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSilvertemAvailable.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtSilvertemAvailable.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblGoldSellReportShort_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblGoldSellReportShort.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtGoldSellReportShort.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblGoldVoucherReserve_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblGoldVoucherReserve.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = Application.StartupPath & "\Report"
        OFD.FileName = "rptGoldGoldVoucherReceive.rdlc*"
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtGoldVoucherReserve.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblAccessoriesReportShort_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblAccessoriesReportShort.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        OFD.InitialDirectory = Application.StartupPath & "\Report"
        OFD.FileName = "rptGoldGoldVoucherReceive*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtAccessoriesReportShort.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblWholesaleInvoce_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblWholesaleInvoce.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = Application.StartupPath & "\Report"
        OFD.FileName = "ReportTPSellBuyWholesaleInvoce*"
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtWholesaleInvoce.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub lblGoldProfitsReport_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblGoldProfitsReport.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = Application.StartupPath & "\Report"
        OFD.FileName = "rptGoldProfitsReport*"
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtGoldProfitsReport.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblDiamondSellShort_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblDiamondSellShort.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = Application.StartupPath & "\Report"
        OFD.FileName = "rptDiamondSellShort.rdlc*"
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtDiamondSellShort.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblGoldSellReportShortKYC_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblGoldSellReportShortKYC.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = Application.StartupPath & "\Report"
        OFD.FileName = "rptGoldSellShortKYC*"
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtGoldSellReportShortKYC.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub lblSilverProfitsReport_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSilverProfitsReport.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = Application.StartupPath & "\Report"
        OFD.FileName = "rptSilverProfitsReport*"
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtSilverProfitsReport.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub
End Class