Imports System.Data.SqlClient

Public Class SQL_COM
    'Dim SQLEXEU As String = TextBox1.Text
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SqlConLOC As New SqlConnection
        Dim SqlComLOC As New SqlCommand
        Dim SqlDataReLOC As SqlDataReader
        Dim DataTabLOC As New DataTable
        Dim SqlDataAdaLOC As New SqlDataAdapter
        DataTabLOC.Clear()
        SqlConLOC.ConnectionString = My.Settings.DT_restrantConnectionString10
        SqlConLOC.Open()
        SqlComLOC.Connection = SqlConLOC
        SqlComLOC.CommandText = TextBox1.Text
        SqlDataReLOC = SqlComLOC.ExecuteReader
        DataTabLOC.Load(SqlDataReLOC)
        SqlDataReLOC.Close()
        SqlConLOC.Close()

    End Sub

    Private Sub SQL_COM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class