Public Class TEST
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GlCommand.CommandText = "INSERT INTO [TPBranchDetails]" &
                               "([BranchDT]" &
                               ",[BranchServerNa]" &
                               ",[BranchUser]" &
                               ",[BranchPassword]" &
                               ",[BranchPublic]" &
                               ",[BranchActive])" &
                                "VALUES" &
                               "(@BranchDT" &
                               ",@BranchServerNa" &
                               ",@BranchUser" &
                               ",@BranchPassword" &
                               ",@BranchPublic" &
                               ",@BranchActive)"
        With GlCommand.Parameters
            .Clear()
            .AddWithValue("@BranchDT", 1)
            .AddWithValue("@BranchServerNa", 1)
            .AddWithValue("@BranchUser", 1)
            .AddWithValue("@BranchPassword", 1)
            .AddWithValue("@BranchPublic", 1)
            .AddWithValue("@BranchActive", 1)
        End With
    End Sub
End Class