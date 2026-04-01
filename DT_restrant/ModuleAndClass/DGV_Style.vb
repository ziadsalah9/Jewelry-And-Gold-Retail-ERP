Imports System.Runtime.CompilerServices
Module DGV_Style
    <Extension()>
    Public Sub EnableDoubleBuffering(dgv As DataGridView)
        Dim dgvType = dgv.GetType()
        Dim prop = dgvType.GetProperty("DoubleBuffered",
                Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        If prop IsNot Nothing Then prop.SetValue(dgv, True, Nothing)
    End Sub
    Public Sub ApplyGoldenStyle(dgv As DataGridView)
        dgv.SuspendLayout()
        dgv.EnableDoubleBuffering()
        With dgv
            .EnableHeadersVisualStyles = False
            .RowHeadersVisible = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(212, 175, 55)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            .ColumnHeadersHeight = 45
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 240, 228)
            .DefaultCellStyle.Font = New Font("Segoe UI", 10)
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 204, 102)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .GridColor = Color.Goldenrod
            .RowTemplate.Height = 32
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        End With
        dgv.ResumeLayout()
    End Sub
    Public Sub AutoFitColumns(DGV As DataGridView)
        DGV.SuspendLayout()
        For Each col As DataGridViewColumn In DGV.Columns
            If col.Name.ToLower().Contains("name") OrElse
           col.Name.ToLower().Contains("desc") OrElse
           col.Name.ToLower().Contains("comp") Then
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            End If
            Dim w As Integer = col.Width
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            col.Width = w
        Next
        DGV.ResumeLayout()
       
    End Sub
End Module

