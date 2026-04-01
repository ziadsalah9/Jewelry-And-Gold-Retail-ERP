Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Text
Imports System.Collections.Generic

Public Class FormEmptyCellsReport

    Private connectionString As String = String.Empty
    Private invoiceId As String = String.Empty
    Private isBuyInvoice As Boolean = True
    Private selectedTables As List(Of Form2.TableInfo) = Nothing

    Public Sub New(connString As String, invId As String, isBuy As Boolean, tables As List(Of Form2.TableInfo))
        InitializeComponent()
        connectionString = connString
        invoiceId = invId
        isBuyInvoice = isBuy
        selectedTables = tables
        Me.Text = "تقرير الخلايا الفارغة - فاتورة رقم: " & invoiceId
        AddHandler dgvReport.CellDoubleClick, AddressOf dgvReport_CellDoubleClick
        CheckEmptyCells()
    End Sub

    Private Sub dgvReport_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Return

        Try
            Dim row As DataGridViewRow = dgvReport.Rows(e.RowIndex)
            Dim tableName As String = row.Cells("colTableName").Value.ToString()
            Dim columnName As String = row.Cells("colColumnName").Value.ToString()
            Dim primaryKeyValue As String = row.Cells("colPrimaryKey").Value.ToString()

            If primaryKeyValue = "N/A" Then
                MessageBox.Show("لا يمكن تعديل هذا السجل - لا يوجد مفتاح أساسي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim primaryKeyColumn As String = GetPrimaryKeyColumnForTable(tableName)
            If String.IsNullOrEmpty(primaryKeyColumn) Then
                MessageBox.Show("لا يمكن تحديد المفتاح الأساسي للجدول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim currentValue As Object = GetCurrentCellValue(tableName, primaryKeyColumn, primaryKeyValue, columnName)

            Dim editForm As New FormEditCell(tableName, columnName, primaryKeyColumn, primaryKeyValue, connectionString, currentValue)
            If editForm.ShowDialog() = DialogResult.OK Then
                CheckEmptyCells()
            End If

        Catch ex As Exception
            MessageBox.Show("خطأ في فتح نافذة التعديل: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetPrimaryKeyColumnForTable(tableName As String) As String
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT TOP 1 * FROM [" & tableName & "]"

                Using cmd As New SqlCommand(query, connection)
                    cmd.CommandTimeout = 30
                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
                            Return GetPrimaryKeyColumn(dataTable)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
        End Try

        Select Case tableName.ToLower()
            Case "buy_gold"
                Return "B_gold_id"
            Case "bay"
                Return "BAY_ID"
            Case "castomerdetels"
                Return "CastomerCAIVELid"
            Case "cacher"
                Return "svil_id"
            Case "paymethod"
                Return "ID"
            Case "selinvocedetels"
                Return "ID"
            Case "fo_min"
                Return "BarCode"
            Case Else
                Return "id"
        End Select
    End Function

    Private Function GetCurrentCellValue(tableName As String, primaryKeyColumn As String, primaryKeyValue As String, columnName As String) As Object
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT [" & columnName & "] FROM [" & tableName & "] WHERE [" & primaryKeyColumn & "] = @PrimaryKey"

                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)
                    Dim result As Object = cmd.ExecuteScalar()
                    Return If(IsDBNull(result), Nothing, result)
                End Using
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub CheckEmptyCells()
        Try
            Me.Cursor = Cursors.WaitCursor
            dgvReport.Rows.Clear()

            If selectedTables Is Nothing OrElse selectedTables.Count = 0 Then
                lblSummary.Text = "لا توجد جداول محددة للفحص"
                lblSummary.ForeColor = Color.Orange
                Return
            End If

            Dim tables As List(Of Form2.TableInfo) = selectedTables

            Dim totalEmptyCells As Integer = 0

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                For Each tableInfo As Form2.TableInfo In tables
                    Try
                        ' Replace @InvoiceId to avoid int overflow
                        Dim finalWhereClause As String = tableInfo.WhereClause
                        If Not String.IsNullOrEmpty(tableInfo.ParamValue) AndAlso tableInfo.WhereClause.Contains("@InvoiceId") Then
                            finalWhereClause = tableInfo.WhereClause.Replace("@InvoiceId", "N'" & tableInfo.ParamValue & "'")
                        End If

                        Dim query As String = "SELECT * FROM [" & tableInfo.TableName & "] WHERE " & finalWhereClause

                        Using cmd As New SqlCommand(query, connection)
                            cmd.CommandTimeout = 30

                            Using adapter As New SqlDataAdapter(cmd)
                                Dim dataTable As New DataTable()
                                adapter.Fill(dataTable)

                                If dataTable IsNot Nothing AndAlso dataTable.Rows.Count > 0 Then
                                    Dim primaryKeyColumn As String = GetPrimaryKeyColumn(dataTable)

                                    For Each row As DataRow In dataTable.Rows
                                        Dim primaryKeyValue As String = If(primaryKeyColumn <> String.Empty AndAlso dataTable.Columns.Contains(primaryKeyColumn), row(primaryKeyColumn).ToString(), "N/A")

                                        For Each column As DataColumn In dataTable.Columns
                                            If column.ColumnName = primaryKeyColumn Then Continue For

                                            Dim cellValue As Object = row(column.ColumnName)
                                            Dim isEmpty As Boolean = False
                                            Dim issueType As String = String.Empty

                                            If IsDBNull(cellValue) Then
                                                isEmpty = True
                                                issueType = "NULL"
                                            ElseIf TypeOf cellValue Is String AndAlso String.IsNullOrWhiteSpace(cellValue.ToString()) Then
                                                isEmpty = True
                                                issueType = "فارغ"
                                            End If

                                            If isEmpty Then
                                                dgvReport.Rows.Add(
                                                    tableInfo.TableName,
                                                    column.ColumnName,
                                                    primaryKeyValue,
                                                    issueType,
                                                    GetColumnDataType(column)
                                                )
                                                totalEmptyCells += 1
                                            End If
                                        Next
                                    Next
                                End If
                            End Using
                        End Using
                    Catch ex As Exception
                        dgvReport.Rows.Add(tableInfo.TableName, "خطأ في القراءة", "N/A", ex.Message, "Error")
                    End Try
                Next
            End Using

            lblSummary.Text = "إجمالي الخلايا الفارغة: " & totalEmptyCells
            If totalEmptyCells > 0 Then
                lblSummary.ForeColor = Color.Red
                lblSummary.Text &= " - يوجد مشاكل في البيانات"
            Else
                lblSummary.ForeColor = Color.Green
                lblSummary.Text &= " - لا توجد مشاكل"
            End If

        Catch ex As Exception
            MessageBox.Show("خطأ في فحص الخلايا الفارغة: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GetPrimaryKeyColumn(dataTable As DataTable) As String
        If dataTable.PrimaryKey.Length > 0 Then
            Return dataTable.PrimaryKey(0).ColumnName
        End If

        If dataTable.Columns.Contains("id") Then Return "id"
        If dataTable.Columns.Contains("ID") Then Return "ID"
        If dataTable.Columns.Contains("B_gold_id") Then Return "B_gold_id"
        If dataTable.Columns.Contains("BAY_ID") Then Return "BAY_ID"
        If dataTable.Columns.Contains("CastomerCAIVELid") Then Return "CastomerCAIVELid"
        If dataTable.Columns.Contains("svil_id") Then Return "svil_id"

        If dataTable.Columns.Count > 0 Then
            Return dataTable.Columns(0).ColumnName
        End If

        Return String.Empty
    End Function

    Private Function GetColumnDataType(column As DataColumn) As String
        If column.DataType Is GetType(String) Then
            Return "String"
        ElseIf column.DataType Is GetType(Integer) OrElse column.DataType Is GetType(Long) Then
            Return "Number"
        ElseIf column.DataType Is GetType(Decimal) OrElse column.DataType Is GetType(Double) Then
            Return "Decimal"
        ElseIf column.DataType Is GetType(DateTime) Then
            Return "Date"
        ElseIf column.DataType Is GetType(Boolean) Then
            Return "Boolean"
        Else
            Return column.DataType.Name
        End If
    End Function


End Class

