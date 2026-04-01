Imports System.Data.SqlClient

Public Class ClsSnd
    Public Function PayemtWay()
        Dim con As New ConnectionClass
        Dim DT As New DataTable
        DT.Clear()
        DT = con.SELECT_TXT("SELECT ID, PayMethodAr, PayMethodEn FROM PayMethod where Active = 1")
        Return DT
    End Function
    'Public Sub InsertSnd(SndNumber As String, Amount As Double, Cash As Double, Kent As Double, Note_ As String,
    '                       NumToWorld_AR As String, NumToWorld_EN As String, SndType As String, PaymentMethod As Integer,
    '                        civilid As Double)
    '    Dim con As New ConnectionClass
    '    Dim prm(5) As SqlParameter
    '    prm(0) = New SqlParameter("@Dtp", SqlDbType.DateTime) With {.Value = Date.Now}
    '    prm(1) = New SqlParameter("@NOTE", SqlDbType.NVarChar) With {.Value = Note_}
    '    prm(2) = New SqlParameter("@NumToWorld_AR", SqlDbType.NVarChar) With {.Value = NumToWorld_AR}
    '    prm(3) = New SqlParameter("@NumToWorld_EN", SqlDbType.NVarChar) With {.Value = NumToWorld_EN}
    '    prm(4) = New SqlParameter("@SndType", SqlDbType.NVarChar) With {.Value = SndType}
    '    prm(5) = New SqlParameter("@SndNumber", SqlDbType.NVarChar) With {.Value = SndNumber}
    '    con.EXECUTECOMMAND("INSERT INTO SndToCustomer
    '       (SndNumber, Amount, Cash, Kent, Date_ ,Note_ ,NumToWorld_AR ,NumToWorld_EN
    '       ,SndType ,Casher ,UserId, PaymentMethod, civilid)
    '            VALUES
    '       (@SndNumber, " & Amount & ", " & Cash & ", " & Kent & ", @Dtp, @NOTE, @NumToWorld_AR,
    '        @NumToWorld_EN, @SndType, 0, 0, " & PaymentMethod & ", " & civilid & ")", prm)
    'End Sub
    Public Function MaxNumber()
        Dim con As New ConnectionClass
        Dim DT As New DataTable
        DT.Clear()
        DT = con.SELECT_TXT("SELECT ISNULL(MAX(ID) + 1, 1) FROM SndToCustomer")
        Return DT
    End Function
End Class
