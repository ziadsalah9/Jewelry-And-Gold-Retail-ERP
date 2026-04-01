Imports System
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Drawing

Public Class FormEditCell

    Private tableName As String
    Private columnName As String
    Private primaryKeyColumn As String
    Private primaryKeyValue As Object
    Private connectionString As String
    Private originalValue As Object

    Public Sub New(tblName As String, colName As String, pkColumn As String, pkValue As Object, connString As String, oldValue As Object)
        InitializeComponent()
        tableName = tblName
        columnName = colName
        primaryKeyColumn = pkColumn
        primaryKeyValue = pkValue
        connectionString = connString
        originalValue = oldValue

        Me.Text = "تعديل: " & colName & " في جدول " & tblName
        lblTableName.Text = "الجدول: " & tblName
        lblColumnName.Text = "العمود: " & colName
        
        If oldValue Is Nothing OrElse IsDBNull(oldValue) Then
            txtOldValue.Text = "[NULL - فارغ]"
            txtOldValue.ForeColor = Color.Red
            txtNewValue.Text = ""
        ElseIf TypeOf oldValue Is String AndAlso String.IsNullOrWhiteSpace(oldValue.ToString()) Then
            txtOldValue.Text = "[فارغ - Empty String]"
            txtOldValue.ForeColor = Color.Orange
            txtNewValue.Text = ""
        Else
            txtOldValue.Text = oldValue.ToString()
            txtOldValue.ForeColor = Color.Black
            txtNewValue.Text = oldValue.ToString()
        End If
        
        txtNewValue.SelectAll()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            btnSave.Enabled = False

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim columnDataType As Type = GetColumnDataType(connection, tableName, columnName)
                Dim query As String = "UPDATE [" & tableName & "] SET [" & columnName & "] = @NewValue WHERE [" & primaryKeyColumn & "] = @PrimaryKey"

                Using cmd As New SqlCommand(query, connection)
                    If String.IsNullOrWhiteSpace(txtNewValue.Text) Then
                        cmd.Parameters.AddWithValue("@NewValue", DBNull.Value)
                    Else
                        Dim convertedValue As Object = ConvertValue(txtNewValue.Text, columnDataType)
                        cmd.Parameters.AddWithValue("@NewValue", convertedValue)
                    End If
                    cmd.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("تم التحديث بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    Else
                        MessageBox.Show("لم يتم تحديث أي سجل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("فشل التحديث: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
            btnSave.Enabled = True
        End Try
    End Sub

    Private Function GetColumnDataType(connection As SqlConnection, tableName As String, columnName As String) As Type
        Try
            Dim query As String = "SELECT DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TableName AND COLUMN_NAME = @ColumnName"
            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@TableName", tableName)
                cmd.Parameters.AddWithValue("@ColumnName", columnName)
                Dim dataType As String = cmd.ExecuteScalar()?.ToString()

                Select Case dataType?.ToLower()
                    Case "int", "bigint", "smallint", "tinyint"
                        Return GetType(Integer)
                    Case "decimal", "numeric", "money", "smallmoney"
                        Return GetType(Decimal)
                    Case "float", "real"
                        Return GetType(Double)
                    Case "datetime", "datetime2", "date", "time"
                        Return GetType(DateTime)
                    Case "bit"
                        Return GetType(Boolean)
                    Case Else
                        Return GetType(String)
                End Select
            End Using
        Catch
            Return GetType(String)
        End Try
    End Function

    Private Function ConvertValue(value As String, targetType As Type) As Object
        If String.IsNullOrWhiteSpace(value) Then
            Return DBNull.Value
        End If

        Try
            If targetType Is GetType(Integer) OrElse targetType Is GetType(Long) Then
                Return Convert.ToInt32(value)
            ElseIf targetType Is GetType(Decimal) OrElse targetType Is GetType(Double) Then
                Return Convert.ToDecimal(value)
            ElseIf targetType Is GetType(DateTime) Then
                Return Convert.ToDateTime(value)
            ElseIf targetType Is GetType(Boolean) Then
                Return Convert.ToBoolean(value)
            Else
                Return value
            End If
        Catch
            Return value
        End Try
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class

