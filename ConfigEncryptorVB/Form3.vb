Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class Form3

    Public Sub New(dataTable As DataTable, title As String)
        InitializeComponent()
        AddHandler dgvInvoiceData.DataError, AddressOf dgvInvoiceData_DataError
        
        If dataTable IsNot Nothing Then
            dgvInvoiceData.DataSource = dataTable
            Me.Text = title
            lblInvoiceInfo.Text = title
            lblRowCount.Text = "عدد السجلات: " & dataTable.Rows.Count
            
            If dataTable.Columns.Contains("INV_Actv") Then
                Try
                    Dim invActvColumn As DataGridViewColumn = dgvInvoiceData.Columns("INV_Actv")
                    If invActvColumn IsNot Nothing Then
                        invActvColumn.DisplayIndex = 0
                        invActvColumn.Width = 100
                        invActvColumn.HeaderText = "INV_Actv"
                    End If
                Catch
                End Try
            End If
            
            AdjustColumnWidths()
        Else
            Me.Text = "خطأ - لا توجد بيانات"
            lblInvoiceInfo.Text = "خطأ - لا توجد بيانات"
            lblRowCount.Text = "عدد السجلات: 0"
        End If
    End Sub

    Private Sub dgvInvoiceData_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        e.ThrowException = False
        e.Cancel = True
    End Sub

    Private Sub AdjustColumnWidths()
        If dgvInvoiceData.Columns.Count = 0 Then Return

        For Each column As DataGridViewColumn In dgvInvoiceData.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Dim headerWidth As Integer = TextRenderer.MeasureText(column.HeaderText, dgvInvoiceData.Font).Width + 30

            Dim maxContentWidth As Integer = headerWidth
            Dim sampleCount As Integer = Math.Min(50, dgvInvoiceData.Rows.Count)
            
            For i As Integer = 0 To sampleCount - 1
                If dgvInvoiceData.Rows(i).Cells(column.Index).Value IsNot Nothing Then
                    Dim cellText As String = dgvInvoiceData.Rows(i).Cells(column.Index).Value.ToString()
                    If Not String.IsNullOrEmpty(cellText) Then
                        Dim cellWidth As Integer = TextRenderer.MeasureText(cellText, dgvInvoiceData.Font).Width + 30
                        If cellWidth > maxContentWidth Then
                            maxContentWidth = cellWidth
                        End If
                    End If
                End If
            Next

            column.Width = Math.Max(120, Math.Min(maxContentWidth, 400))
        Next
    End Sub

End Class

