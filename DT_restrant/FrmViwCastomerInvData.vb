Imports System.Drawing.Printing

Public Class FrmViwCastomerInvData

    'Private WithEvents  As New PrintDocument
    Private printRow As Integer

    ' Button click to start printing
    'Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
    '    printRow = 0
    '    PrintPreviewDialog1.Document = PrintDoc
    '    PrintPreviewDialog1.ShowDialog()
    'End Sub

    ' Handle the PrintPage event
    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim y As Integer = 100
        Dim x As Integer = 50
        Dim rowHeight As Integer = 30
        Dim font As New Font("Arial", 10)

        ' Print headers
        For Each column As DataGridViewColumn In grid.Columns
            e.Graphics.DrawString(column.HeaderText, font, Brushes.Black, x, y)
            x += column.Width
        Next

        y += rowHeight
        x = 50

        ' Print rows
        While printRow < grid.Rows.Count
            Dim dgvRow = grid.Rows(printRow)
            If dgvRow.IsNewRow Then Exit While

            For Each cell As DataGridViewCell In dgvRow.Cells
                e.Graphics.DrawString(cell.Value?.ToString(), font, Brushes.Black, x, y)
                x += cell.OwningColumn.Width
            Next

            printRow += 1
            y += rowHeight
            x = 50

            ' Check if page full
            If y > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Return
            End If
        End While

        e.HasMorePages = False
    End Sub


    Private Sub FrmViwCastomerInvData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
         DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
        CheckUserPermissions(UserID)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        language_start(Name)

        GetLastInvoceDatagrid()
    End Sub
    Private Sub grid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles grid.CellClick

        If GoldInvoice.Visible = True Then
            If grid.Columns(e.ColumnIndex).Name = "colViwInv" AndAlso e.RowIndex >= 0 Then
                'Try
                With GoldViewSellInvoice
                    .txtInvoiceNo.Text = grid.CurrentRow.Cells("colInvNo").Value
                    .InvoiceSearch()
                    .ReportViewer1.RefreshReport()
                    .ShowDialog()
                End With
                'Catch ex As Exception
                '    RecordRrrors(DescriptionRrrors:=ex.ToString)
                'End Try
            End If
        ElseIf GoldOrSilver = False Then
            ' If grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            'Try
            '    With GoldViewSellInvoice
            '        .txtInvoiceNo.Text = grid.CurrentRow.Cells("colID").Value
            '        .InvoiceSearch()
            '        .ReportViewer1.RefreshReport()
            '        .ShowDialog()
            '    End With
            'Catch ex As Exception
            '    RecordRrrors(DescriptionRrrors:=ex.ToString)
            'End Try
        End If
    End Sub
    Private Sub grid_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If grid.Columns(e.ColumnIndex).Name = "colViwInv" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.PrinterSmall, CInt((e.CellBounds.Width / 2) - (My.Resources.PrinterSmall.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.PrinterSmall.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
        'Print Arb.png
    End Sub
    Private Sub GetLastInvoceDatagrid()

        If GoldInvoice.Visible = True Then
            Dim ShortData As DataTable = GetRecordSet("SELECT  CastomerNAme, CastomerTE, cacher_name, SUM(item_gram) AS" & vbCrLf &
                                                     "item_gram, CACH, Bank1 + Bank2 + Bank3 + Bank4 + KENT AS KENT, TOTAL_mony, BAY_SARYAL, " & vbCrLf &
                                                     "invoc_date_time, Castomerid" & vbCrLf &
                                                     "FROM dbo.ViwGoldInvoceReport" & vbCrLf &
                                                     "GROUP BY CastomerNAme, CastomerTE, cacher_name, " & vbCrLf &
                                                     "CACH, Bank1 + Bank2 + Bank3 + Bank4 + KENT, TOTAL_mony, BAY_SARYAL, invoc_date_time, Castomerid" & vbCrLf &
                                                     "HAVING (Castomerid ='" & CivilIDForm.txtCID.Text.Trim & "')" & vbCrLf &
                                                     "ORDER BY BAY_SARYAL DESC")
            If ShortData.Rows.Count > 0 Then
                For i As Integer = 0 To ShortData.Rows.Count - 1
                    With (grid)
                        .Rows.Add()
                        .Rows(i).Cells("colCatomerName").Value = (ShortData.Rows(i)("CastomerNAme").ToString)
                        .Rows(i).Cells("colCastomTel").Value = (ShortData.Rows(i)("CastomerTE").ToString)
                        .Rows(i).Cells("colCashier").Value = (ShortData.Rows(i)("cacher_name").ToString)
                        .Rows(i).Cells("colGoldW").Value = (ShortData.Rows(i)("item_gram").ToString)
                        .Rows(i).Cells("colCash").Value = (ShortData.Rows(i)("CACH").ToString)
                        .Rows(i).Cells("colKenet").Value = (ShortData.Rows(i)("KENT").ToString)
                        .Rows(i).Cells("colTotalAmount").Value = (ShortData.Rows(i)("TOTAL_mony").ToString)
                        .Rows(i).Cells("colInvNo").Value = (ShortData.Rows(i)("BAY_SARYAL").ToString)
                        .Rows(i).Cells("colDate").Value = Format(ShortData.Rows(i)("invoc_date_time"))

                    End With
                Next
            End If
        ElseIf DiamondInvoice.Visible = True Then

        ElseIf SilverInvoice.Visible = True Then

        End If
    End Sub

    Private Sub FrmViwCastomerInvData_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        sc.Dispose()
        Dispose()
    End Sub

    Private Sub FrmViwCastomerInvData_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        sc.Dispose()
        Dispose()
    End Sub

    Private Sub PrintPreviewDialog_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog.Load

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click



        'PageSetupDialog.PageSettings.Landscape = True
        'PageSetupDialog.PageSettings.Margins.Left = 0
        'PageSetupDialog.PageSettings.Margins.Right = 0
        'PageSetupDialog.Document = PrintDocument

        'PrintPreviewDialog.Document = PrintDocument
        'PrintPreviewDialog.PrintPreviewControl.Zoom = 1

        'PageSetupDialog.PageSettings.Margins.Left = 0
        'PageSetupDialog.PageSettings.Margins.Right = 0

        'PageSetupDialog.PageSettings.Landscape = True
        'PageSetupDialog.PageSettings.PaperSize.PaperName = "A4"
        'PageSetupDialog.ShowDialog()
        'PrintPreviewDialog.ShowDialog()
        'PageSetupDialog.ShowDialog()


        'printRow = 0
        'PrintPreviewDialog.Document = PrintDoc
        'PrintPreviewDialog.ShowDialog()
        'PrintDocument.Print()

        printRow = 0
        ' Set Landscape mode
        PrintDoc.DefaultPageSettings.Landscape = True
        ' Connect PrintDocument to the PrintPreviewDialog
        PrintPreviewDialog.Document = PrintDoc
        ' Show preview
        PrintPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage

        Dim BitMap As New Bitmap(Me.grid.Width, Me.grid.Height)
        grid.DrawToBitmap(BitMap, New Rectangle(0, 0, Me.grid.Width, Me.grid.Height))
        e.Graphics.DrawImage(BitMap, 0, 0)

    End Sub

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs)
        PrintPreviewDialog.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        PageSetupDialog.ShowDialog()
    End Sub
End Class