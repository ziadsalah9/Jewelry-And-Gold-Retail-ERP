Imports System.Data.SqlClient
Imports DT_restrant.My

Public Class ConnectionClass
    Public SQL_GET_CONNC As String = My.MySettings.Default.DT_restrantConnectionString10
    Dim SQLCON_TELE As New SqlConnection(SQL_GET_CONNC)
    'Sub New()
    '    SQLCON_TELE = New SqlConnection(SQL_GET_CONNC)
    'End Sub
    Public Sub OPEN_CON()
        If SQLCON_TELE.State = ConnectionState.Closed Then
            SQLCON_TELE.Open()
        End If
    End Sub
    Public Sub CLOSE_CON()
        If SQLCON_TELE.State = ConnectionState.Open Then
            SQLCON_TELE.Close()
        End If
    End Sub
    Public Sub EXECUTE_TXT(TXT_ As String)
        Dim CMD As New SqlCommand
        CMD.CommandType = CommandType.Text
        CMD.Connection = SQLCON_TELE
        CMD = New SqlCommand(TXT_, SQLCON_TELE)
        OPEN_CON()
        CMD.ExecuteNonQuery()
        CLOSE_CON()
    End Sub
    Public Function SELECT_TXT(TXT_ As String) As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim ADP As New SqlDataAdapter(TXT_, SQLCON_TELE)
        ADP.SelectCommand.CommandTimeout = 0
        ADP.Fill(DT)
        Return DT
    End Function
    Public Sub CONNECT()
        If SQLCON_TELE.State <> ConnectionState.Open Then
            SQLCON_TELE.Open()
        End If
    End Sub
    Public Sub DISCONNECT()
        If SQLCON_TELE.State <> ConnectionState.Closed Then
            SQLCON_TELE.Close()
        End If
    End Sub
    Public Sub EXECUTECOMMAND(ByVal TXT_ As String, ByVal PARAM() As SqlParameter)
        CONNECT()
        Dim CMD As New SqlCommand(TXT_, SQLCON_TELE)
        CMD.CommandType = CommandType.Text
        If Not PARAM Is Nothing Then
            For I As Integer = 0 To PARAM.Length - 1
                CMD.Parameters.Add(PARAM(I))
            Next
        End If
        CMD.ExecuteNonQuery()
        DISCONNECT()
    End Sub
    Public Function SELECTDATA(ByVal TXT_ As String, ByVal PARAM() As SqlParameter) As DataTable
        Dim CMD As New SqlCommand(TXT_, SQLCON_TELE)
        CMD.CommandType = CommandType.Text
        If Not PARAM Is Nothing Then
            For I As Integer = 0 To PARAM.Length - 1
                CMD.Parameters.Add(PARAM(I))
            Next
        End If
        Dim DA As New SqlDataAdapter(CMD)
        Dim DT As New DataTable : DA.Fill(DT)
        Return DT
    End Function
End Class
