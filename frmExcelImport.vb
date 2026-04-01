Imports System.Data.OleDb
Public Class frmExcelImport
    Dim connExcel As OleDbConnection
    Dim cmd As OleDbDataAdapter
    Dim dt As New DataTable
    Dim OldFilePath As String
#Region "Initialize"
    Private Sub frmImportData_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load, btnRefresh.Click
        Initialize()
    End Sub
    Public Sub Initialize()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        lblFormName.Text = Text
        ClearControl(Me)
        GetFontData(Me)
        Grid.Rows.Clear()
    End Sub
#End Region
#Region "Editing"
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnBrowse.Click
        OldFilePath = txtFilePath.Text
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            txtFilePath.Text = OpenFileDialog1.FileName
            GetSheets(OpenFileDialog1.FileName)
        End If
    End Sub
    Public Sub GetSheets(ByVal FilePath As String)
        Dim CharToTrim As Char() = {"$"c, "'"c}
        connExcel = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FilePath & ";Extended Properties='Excel 12.0 Xml;HDR=NO;IMEX=1';")
        Try
            connExcel.Open()
            If OldFilePath <> FilePath Then dt.Rows.Clear()
            Dim dataSet As DataTable = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            cmbSheet.Items.Clear()
            For i As Integer = 0 To dataSet.Rows.Count - 1
                cmbSheet.Items.Add(dataSet.Rows(i)("TABLE_NAME").ToString.Trim(CharToTrim))
            Next
            If cmbSheet.Items.Count = 1 Then
                cmbSheet.SelectedIndex = 0
            End If
            connExcel.Close()
        Catch ex As Exception
            ' MsgBox("تعذر فتح الملف " & vbCrLf & "إذا كان الملف مفتوحًا داخل إكسل يرجى إغلاقه أولاً", vbExcl, MainTitle)
            MsgBox(ex.Message, vbExcl, MainTitle)
        End Try
    End Sub
    Public Sub GetData()
        If connExcel.State = ConnectionState.Closed Then connExcel.Open()
        strField = "[م] , [الاسم] , [الرقم المدني] , [رقم الشقة] , [تاريخ بداية العقد] , [الإيجار] , [Name] , [الهاتف] , [جهة العمل] , [Works At] "
        'cmd = New OleDbDataAdapter("SELECT " & strField & " FROM [" & cmbSheet.SelectedItem.ToString & "$] ORDER BY [م]", connExcel)
        cmd = New OleDbDataAdapter("SELECT * FROM [" & cmbSheet.SelectedItem.ToString & "$]", connExcel)
        dt.Reset()
        Grid.Rows.Clear()
        Try
            cmd.Fill(dt)
            Dim row As DataRow = dt.Rows(0)
            For i As Integer = 0 To row.ItemArray.Length - 1
                dt.Columns(i).ColumnName = row.Item(i).ToString()
            Next
            dt.Rows.RemoveAt(0)
            dt.AcceptChanges()
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).Item(1).ToString <> "" Then
                        Grid.Rows.Add(Trim(dt.Rows(i)(0).ToString),
                                      Trim(dt.Rows(i)(1).ToString),
                                      Trim(dt.Rows(i)(2).ToString),
                                      Trim(dt.Rows(i)(3).ToString),
                                      If(IsDate(dt.Rows(i)(4).ToString), CDate(dt.Rows(i)(4).ToString).ToShortDateString, ""),
                                      Trim(dt.Rows(i)(5).ToString()),
                                      Trim(dt.Rows(i)(6).ToString()),
                                      Trim(dt.Rows(i)(7).ToString()),
                                      Trim(dt.Rows(i)(8).ToString()),
                                      Trim(dt.Rows(i)(9).ToString())
                                      )
                    End If

                Next
            End If
        Catch ex As Exception
            MsgBox("لا يمكن استيراد بيانات من ورقة إكسل المحددة" & vbCrLf & "تأكد من أن الورقة المحددة تحتوي على حقول بنفس الأسماء في الجدول الموجود بالأسفل", vbCrit, MainTitle)
        End Try
        If connExcel.State = ConnectionState.Open Then connExcel.Close()
    End Sub

    Private Sub cmbSheet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles cmbSheet.SelectedIndexChanged
        GetData()
    End Sub
#End Region
#Region "Displaying"
    Private Sub grid_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Grid.CellPainting
        If e.ColumnIndex = 1 Then Exit Sub
        If e.ColumnIndex = 8 Then Exit Sub
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            e.PaintBackground(e.CellBounds, True)
            TextRenderer.DrawText(e.Graphics,
                                  e.FormattedValue.ToString(),
                                  e.CellStyle.Font,
                                  e.CellBounds,
                                  e.CellStyle.ForeColor,
                                  TextFormatFlags.HorizontalCenter)
            e.Handled = True
        End If
    End Sub
#End Region
#Region "Validate"
    Private Sub Grid_CellValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellValidated
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex < 0 OrElse e.ColumnIndex > 4 Then Exit Sub
        ValidateCellValue(e.RowIndex, e.ColumnIndex)

    End Sub
    Private Function ValidateCellValue(ByVal RowNo As Integer, ByVal ColumnNo As Integer) As Boolean
        Dim x As Boolean = False
        Grid.Rows(RowNo).Cells(ColumnNo).ErrorText = ""

        If Trim(Grid.Rows(RowNo).Cells(ColumnNo).Value) = "" Then
            Grid.Rows(RowNo).Cells(ColumnNo).ErrorText = "يرجى إدخال بيانات كاملة!"
            x = True
        End If

        If IsDate(Grid.Rows(RowNo).Cells("colRentDate").Value) = False Then
            Grid.Rows(RowNo).Cells("colRentDate").ErrorText = "يرجى إدخال تاريخ صحيح!"
            x = True
        End If

        If IsNumeric(Grid.Rows(RowNo).Cells("colPrice").Value) = False Then
            Grid.Rows(RowNo).Cells("colPrice").ErrorText = "يرجى إدخال أرقام فقط!"
            x = True
        End If
        Return x
    End Function
    Private Sub btnHelp_Click(sender As System.Object, e As EventArgs) Handles btnHelp.Click
        MsgBox("ملف الإكسل يجب أن تتوفر فيه الشروط التالية:" & vbCrLf &
               "1-الملف بتنسيق إكسل 2007 أو ما بعده" & vbCrLf &
               "2-الملف يحتوي على صف رؤوس أعمدة بالأسماء :" & vbCrLf & " م , الاسم , الرقم المدني ,  رقم الشقة ,  تاريخ الإيجار , الإيجار , Name , الهاتف , جهة العمل , Works At" & vbCrLf & "(تجنب الأخطاء الإملائية)" & vbCrLf &
               "3-تأكد أن كل عمود تم تنسيق بياناته بنوع واحد فقط , مثل الأرقام فقط أو النصوص فقط أو التواريخ فقط" & vbCrLf &
               "4-يجب إدخال البيانات في الأعمدة الاسم , الرقم المدني ,  رقم الشقة ,  تاريخ الإيجار , الإيجار" & vbCrLf &
               "5-باقي الأعمدة يفضل إدخال البيانات فيها بالكامل" & vbCrLf &
               "6-يجب أن يطابق رقم الشقة ما تم إدخاله في شاشة توزيع الشقق", vbInfo, MainTitle)
    End Sub
#End Region
#Region "Saving"
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles CmdSave.Click
        Dim ErrorFound, DataFound As Boolean
        For i As Integer = 0 To Grid.Rows.Count - 1
            For j As Integer = 1 To 5
                If ValidateCellValue(i, j) = True Then
                    ErrorFound = True
                End If
            Next
        Next
        If ErrorFound = True Then
            MsgBox("راجع البيانات المدخلة و صححها", vbExcl, MainTitle)
            Exit Sub
        End If
        strSQL = "SELECT FlatNo FROM MainTable WHERE BuildingNo = '" & BuildingNo & "' ORDER BY FlatNo ASC"
        Dim dt1 As DataTable = GetRecordSet(strSQL)
        If dt1.Rows.Count > 0 Then
            For i As Integer = 0 To Grid.Rows.Count - 1
                DataFound = False
                For j As Integer = 0 To dt1.Rows.Count - 1
                    If Grid.Rows(i).Cells("colFlatNo").Value = dt1.Rows(j).Item("FlatNo").ToString Then
                        DataFound = True
                        Exit For
                    End If
                Next
                If DataFound = False Then
                    MsgBox("لا توجد شقة مسجلة برقم " & Grid.Rows(i).Cells("colFlatNo").Value, vbExcl, MainTitle)
                    Exit Sub
                End If
            Next
        End If
        Try
            For i As Integer = 0 To Grid.Rows.Count - 1
                Glcomd.CommandText = "UPDATE MainTable SET " &
                                                           "[CustomerName] = @CustomerName , " &
                                                           "[CustomerNameEn] = @CustomerNameEn , " &
                                                           "[ID] = @ID , " &
                                                           "[Phone] = @Phone , " &
                                                           "[Work] = @Work , " &
                                                           "[WorkEn] = @WorkEn , " &
                                                           "[RentDate] = @RentDate , " &
                                                           "[Price] = @Price " &
                                                           " WHERE FlatNo = N'" & Trim(Grid.Rows(i).Cells("colFlatNo").Value) & "'" &
                                                           " AND BuildingNo = '" & BuildingNo & "'"
                With Glcomd.Parameters
                    .Clear()
                    .AddWithValue("@CustomerName", Trim(Grid.Rows(i).Cells("colCustomerName").Value))
                    .AddWithValue("@CustomerNameEn", Trim(Grid.Rows(i).Cells("colCustomerNameEn").Value))
                    .AddWithValue("@ID", Trim(Grid.Rows(i).Cells("colID").Value))
                    .AddWithValue("@Phone", Trim(Grid.Rows(i).Cells("colPhone").Value))
                    .AddWithValue("@Work", Trim(Grid.Rows(i).Cells("colWork").Value))
                    .AddWithValue("@WorkEn", Trim(Grid.Rows(i).Cells("colWorkEn").Value))
                    .AddWithValue("@RentDate", DateToSave(CDate(Grid.Rows(i).Cells("colRentDate").Value)))
                    .AddWithValue("@Price", CSng(Trim(Grid.Rows(i).Cells("colPrice").Value)))
                End With
                Glcomd.ExecuteNonQuery()
            Next
            MsgBox("تم الحفظ.", vbInfo, MainTitle)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("لم يتم الحفظ , تأكدأن قاعدة البيانات غير مفتوحة", vbCrit, MainTitle)
        End Try

    End Sub
#End Region
#Region "Finalize"
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub frmImportData_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
        GC.Collect()
    End Sub
#End Region
End Class