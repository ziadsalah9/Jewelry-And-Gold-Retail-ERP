Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class FormTableData

    Private currentTableName As String = String.Empty
    Private currentConnectionString As String = String.Empty
    Private currentDataTable As DataTable = Nothing
    Private currentWhereClause As String = String.Empty
    Private currentParamValue As String = Nothing

    Public Sub New(tableName As String, connectionString As String, invoiceId As String, whereClause As String, Optional paramValue As String = Nothing)
        InitializeComponent()
        currentTableName = tableName
        currentConnectionString = connectionString
        currentWhereClause = whereClause
        currentParamValue = paramValue
        Me.Text = "جدول: " & tableName & " - فاتورة: " & invoiceId
        AddHandler dgvTableData.DataError, AddressOf dgvTableData_DataError
        AddHandler dgvTableData.CellDoubleClick, AddressOf dgvTableData_CellDoubleClick
        LoadTableData(tableName, connectionString, whereClause, paramValue)
    End Sub

    Private Sub dgvTableData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return
        If currentDataTable Is Nothing OrElse currentDataTable.Rows.Count = 0 Then Return

        Try
            Dim row As DataRow = currentDataTable.Rows(e.RowIndex)
            Dim columnName As String = dgvTableData.Columns(e.ColumnIndex).Name
            Dim cellValue As Object = row(columnName)

            Dim primaryKeyColumn As String = GetPrimaryKeyColumn()
            Dim primaryKeyValue As Object = row(primaryKeyColumn)

            Dim editForm As New FormEditCell(currentTableName, columnName, primaryKeyColumn, primaryKeyValue, currentConnectionString, cellValue)
            If editForm.ShowDialog() = DialogResult.OK Then
                LoadTableData(currentTableName, currentConnectionString, currentWhereClause, currentParamValue)
            End If

        Catch ex As Exception
            MessageBox.Show("خطأ في فتح نافذة التعديل: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetPrimaryKeyColumn() As String
        If currentDataTable Is Nothing Then Return String.Empty

        For Each column As DataColumn In currentDataTable.PrimaryKey
            Return column.ColumnName
        Next

        If currentDataTable.Columns.Contains("id") Then Return "id"
        If currentDataTable.Columns.Contains("ID") Then Return "ID"
        If currentDataTable.Columns.Contains(currentTableName & "_id") Then Return currentTableName & "_id"

        Return currentDataTable.Columns(0).ColumnName
    End Function

    Private Function GetWhereClauseForRow(row As DataRow) As String
        Dim primaryKeyColumn As String = GetPrimaryKeyColumn()
        Dim primaryKeyValue As Object = row(primaryKeyColumn)

        If TypeOf primaryKeyValue Is String Then
            Return "[" & primaryKeyColumn & "] = '" & primaryKeyValue.ToString().Replace("'", "''") & "'"
        Else
            Return "[" & primaryKeyColumn & "] = " & primaryKeyValue.ToString()
        End If
    End Function

    Private Sub AdjustColumnWidths()
        If dgvTableData.Columns.Count = 0 Then Return

        For Each column As DataGridViewColumn In dgvTableData.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Dim headerWidth As Integer = TextRenderer.MeasureText(column.HeaderText, dgvTableData.Font).Width + 30

            Dim maxContentWidth As Integer = headerWidth
            Dim sampleCount As Integer = Math.Min(50, dgvTableData.Rows.Count)
            
            For i As Integer = 0 To sampleCount - 1
                If dgvTableData.Rows(i).Cells(column.Index).Value IsNot Nothing Then
                    Dim cellText As String = dgvTableData.Rows(i).Cells(column.Index).Value.ToString()
                    If Not String.IsNullOrEmpty(cellText) Then
                        Dim cellWidth As Integer = TextRenderer.MeasureText(cellText, dgvTableData.Font).Width + 30
                        If cellWidth > maxContentWidth Then
                            maxContentWidth = cellWidth
                        End If
                    End If
                End If
            Next

            column.Width = Math.Max(120, Math.Min(maxContentWidth, 400))
        Next
    End Sub

    Private Sub dgvTableData_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        e.ThrowException = False
        e.Cancel = True
    End Sub

    Private Sub LoadTableData(tableName As String, connectionString As String, whereClause As String, paramValue As String)
        currentTableName = tableName
        currentConnectionString = connectionString
        Try
            Me.Cursor = Cursors.WaitCursor

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Replace @InvoiceId with actual value to avoid int overflow
                Dim finalWhereClause As String = whereClause
                If Not String.IsNullOrEmpty(paramValue) AndAlso whereClause.Contains("@InvoiceId") Then
                    finalWhereClause = whereClause.Replace("@InvoiceId", "N'" & paramValue & "'")
                End If

                Dim query As String = "SELECT * FROM " & tableName & " WHERE " & finalWhereClause

                Using cmd As New SqlCommand(query, connection)

                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
                            currentDataTable = dataTable
                            dgvTableData.DataSource = dataTable
                            AdjustColumnWidths()
                            lblStatus.Text = "عدد السجلات: " & dataTable.Rows.Count
                            lblStatus.ForeColor = Color.Green
                        Else
                            currentDataTable = Nothing
                            dgvTableData.DataSource = Nothing
                            lblStatus.Text = "لا توجد بيانات"
                            lblStatus.ForeColor = Color.Orange
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            lblStatus.Text = "خطأ: " & ex.Message
            lblStatus.ForeColor = Color.Red
            MessageBox.Show("فشل تحميل البيانات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

End Class

