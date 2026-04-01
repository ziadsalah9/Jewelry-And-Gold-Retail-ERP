Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text


Public Class TransfersItem

    ''' <summary>
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' </summary>
    Public FrombranchUser As String
    Public FrombranchPassword As String
    Public FromBranchDT As String
    Public FrombranchServer As String
    Public BarCodeValue As String
    Public existingBarcodes As New List(Of String)
    ''' <summary>
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' 
    ''' </summary>
    Dim TobranchUser As String
    Dim TobranchPassword As String
    Dim ToBranchDT As String
    Dim TobranchServer As String
    Private Sub LodData()
        Grid.Rows.Clear()
        Dim GetDTsHopName As DataTable = GetRecordSet("select* from TPBranchDetails where BranchActive=1")
        Dim GetDTsHopNameto As DataTable = GetRecordSet("select* from TPBranchDetails where BranchActive=1")
        Dim DtLodDta As DataTable = GetRecordSet("select* from TPBranchDetails where BranchActive=1")
        If DtLodDta.Rows.Count > 0 Then
            For i As Integer = 0 To DtLodDta.Rows.Count - 1
                With (Grid)
                    .Rows.Add()
                    .Rows(i).Cells("colBranchServerNa").Value = (DtLodDta.Rows(i)("BranchServerNa").ToString)
                    .Rows(i).Cells("colBranchDT").Value = (DtLodDta.Rows(i)("BranchDT").ToString)
                    .Rows(i).Cells("colBranchUser").Value = (DtLodDta.Rows(i)("BranchUser").ToString)
                    .Rows(i).Cells("colBranchPassword").Value = (DtLodDta.Rows(i)("BranchPassword").ToString)
                    .Rows(i).Cells("colBranchPublic").Value = (DtLodDta.Rows(i)("BranchPublic").ToString)
                End With
            Next
        End If

        If GetDTsHopName.Rows.Count > 0 Then
            With ComBoxFrom
                .DataSource = GetDTsHopName
                .DisplayMember = "BranchPublic"   ' المعروض للمستخدم
                If .Items.Count < 1 Then
                    .SelectedIndex = 0
                ElseIf .Items.Count > 0 Then
                    .SelectedIndex = 0
                End If
            End With
        End If
        If GetDTsHopNameto.Rows.Count > 0 Then
            With ComBoxTo
                .DataSource = GetDTsHopNameto
                .DisplayMember = "BranchPublic"   ' المعروض للمستخدم
                If .Items.Count > 1 Then
                    .SelectedIndex = 1
                ElseIf .Items.Count > 0 Then
                    .SelectedIndex = 0
                End If

            End With
        End If

    End Sub
    Private Sub TransfersItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
         DGV_Style.ApplyGoldenStyle(Grid) : DGV_Style.AutoFitColumns(Grid)
        GredDsin(GredName:=TrnsfGrid)
        CheckUserPermissions(userID:=UserID)
        LodData()
        TabPage2.Enabled = False
        frmMain.Timer1.Stop()
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(0, 0, 20, 20, 180, 90)
        path.AddArc(Me.Width - 20, 0, 20, 20, 270, 90)
        path.AddArc(Me.Width - 20, Me.Height - 20, 20, 20, 0, 90)
        path.AddArc(0, Me.Height - 20, 20, 20, 90, 90)
        path.CloseAllFigures()
        Me.Region = New Region(path)
        MyBase.OnPaint(e)
    End Sub

    Private Sub BtnViwData_Click(sender As Object, e As EventArgs) Handles BtnViwData.Click
        TrnsfGrid.Rows.Clear()
        If RadoGold.Checked = True Then
            language_start("GOLDADDITEMDETAILS")

            Dim dt As DataTable = GetRecordSetLocal("SELECT * FROM [ViwGoldIItemAvailableReport]")
            For i As Integer = 0 To dt.Rows.Count - 1
                With (TrnsfGrid)
                    .Rows.Add()
                    .Rows(i).Cells("colBarCode").Value = (dt.Rows(i)("BarCode").ToString)
                    .Rows(i).Cells("colGram_valu").Value = (dt.Rows(i)("Gram_valu").ToString)
                    .Rows(i).Cells("colFO_name").Value = (dt.Rows(i)("FO_name").ToString)
                    .Rows(i).Cells("colFO_gram").Value = (dt.Rows(i)("FO_gram").ToString)
                    .Rows(i).Cells("colQty").Value = (dt.Rows(i)("Qty").ToString)
                    .Rows(i).Cells("coldate_care").Value = (dt.Rows(i)("date_care").ToString)
                    .Rows(i).Cells("colLastEditDate").Value = (dt.Rows(i)("LastEditDate").ToString)
                    .Rows(i).Cells("coluserID").Value = (dt.Rows(i)("userID").ToString)
                    .Rows(i).Cells("colPurInvNumber").Value = (dt.Rows(i)("PurInvNumber").ToString)
                End With
            Next

        ElseIf Radosilver.Checked = True Then
            language_start("SILVERADDITEMDETAILS")
            'GetSilvertemName()
            'ItemLod = ("SELECT * FROM [SilverItem] where [Item_Actv]=1")
            'LoadData()
        ElseIf RadoDia.Checked = True Then
            language_start("SILVERADDITEMDETAILS")
            'GetSilvertemName()
            'ItemLod = ("SELECT * FROM [SilverItem] where [Item_Actv]=1")
            'LoadData()
        End If
    End Sub
    Private Sub ComBoxTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComBoxTo.SelectedIndexChanged
        If ComBoxTo.SelectedItem IsNot Nothing Then
            Dim selectedRow As DataRowView = TryCast(ComBoxTo.SelectedItem, DataRowView)
            If selectedRow IsNot Nothing Then
                TobranchUser = selectedRow("BranchUser").ToString()
                TobranchPassword = selectedRow("BranchPassword").ToString()
                ToBranchDT = selectedRow("BranchDT").ToString()
                TobranchServer = selectedRow("BranchServerNa").ToString()
                '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                TOSQLServer = TobranchServer
                TOSQLDatabase = ToBranchDT
                TOSQLUser = TobranchUser
                TOSQLPassword = TobranchPassword
                TOSQLDatabaseconnection = "Data Source=" & TOSQLServer & ";Initial Catalog=" & TOSQLDatabase & ";Persist Security Info=True;User ID=" & TOSQLUser & ";Password=" & TOSQLPassword & ";Connection Timeout=1000"
            End If
        End If
    End Sub
    Private Sub ComBoxFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComBoxFrom.SelectedIndexChanged
        If ComBoxFrom.SelectedItem IsNot Nothing Then
            Dim selectedRow As DataRowView = TryCast(ComBoxFrom.SelectedItem, DataRowView)
            If selectedRow IsNot Nothing Then
                FrombranchUser = selectedRow("BranchUser").ToString()
                FrombranchPassword = selectedRow("BranchPassword").ToString()
                FromBranchDT = selectedRow("BranchDT").ToString()
                FrombranchServer = selectedRow("BranchServerNa").ToString()
                '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                FromSQLServer = FrombranchServer
                FromSQLDatabase = FromBranchDT
                FromSQLUser = FrombranchUser
                FromSQLPassword = FrombranchPassword
                FromSQLDatabaseconnection = "Data Source=" & FromSQLServer & ";Initial Catalog=" & FromSQLDatabase & ";Persist Security Info=True;User ID=" & FromSQLUser & ";Password=" & FromSQLPassword & ";Connection Timeout=1000"
            End If
        End If
    End Sub

    Private Sub FindServer()
        Try
            Dim sqlSources As DataTable = SqlDataSourceEnumerator.Instance.GetDataSources
            cmbServerName.Items.Clear()
            For Each row As DataRow In sqlSources.Rows
                Dim serverName As String = row("ServerName").ToString()
                Dim instanceName As String = row("InstanceName").ToString()

                ' إذا كان هناك اسم لمثيل، أضفه
                If Not String.IsNullOrEmpty(instanceName) Then
                    serverName &= "\" & instanceName
                End If
                cmbServerName.Items.Add(serverName)
            Next
            If cmbServerName.Items.Count > 0 Then
                cmbServerName.SelectedIndex = 0 ' اختيار أول عنصر تلقائياً
            Else
                MessageBox.Show("لم يتم العثور على خوادم SQL في الشبكة.")
            End If
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء اكتشاف الخوادم: " & ex.Message)
        End Try
    End Sub
    Private Sub FindDt()
        Dim serverName As String = cmbServerName.Text.Trim
        If String.IsNullOrEmpty(serverName) Then
            MessageBox.Show("يرجى إدخال اسم السيرفر أو اختياره أولاً.")
            Exit Sub
        End If
        Dim connectionString As String = $"Data Source={serverName};User ID={txtUser.Text.Trim};Password={txtPassword.Text.Trim};Connect Timeout=500000;Encrypt=False;Column Encryption Setting=Disabled"
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim cmd As New SqlCommand("SELECT name FROM sys.databases ORDER BY name", conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                cmbDtName.Items.Clear()

                While reader.Read()
                    cmbDtName.Items.Add(reader("name").ToString())
                End While

                If cmbDtName.Items.Count > 0 Then
                    cmbDtName.SelectedIndex = 0
                Else
                    MessageBox.Show("لم يتم العثور على قواعد بيانات.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("فشل الاتصال بالسيرفر: " & ex.Message)
        End Try
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub BtnFindServer_Click(sender As Object, e As EventArgs) Handles BtnFindServer.Click

        If String.IsNullOrEmpty(txtPassword.Text.Trim) Then
            MessageBox.Show("يرجى إدخال كلمة مرور السيرفرأولاً.")
            txtPassword.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtUser.Text.Trim) Then
            MessageBox.Show("يرجى إدخال اسم المستخدم للسيرفرأولاً.")
            txtUser.Focus()
            Exit Sub
        End If
        FindServer()
        FindDt()
    End Sub

    'Private Sub BtnFindDt_Click(sender As Object, e As EventArgs) Handles BtnFindDt.Click
    '    FindDt()
    'End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim Dt As DataTable = GetRecordSet("SELECT [BranchDT],[BranchPublic] FROM [TPBranchDetails] where BranchActive =1")
        If Dt.Rows.Count > 0 Then
            For i As Integer = 0 To Dt.Rows.Count - 1
                If (Dt.Rows(i)("BranchDT").ToString) = cmbDtName.Text.Trim Then
                    If MsgBox("أسم المعرض موجود مسبقا هلي تريد تحديث الاسم" & (Dt.Rows(i)("BranchPublic").ToString) & "؟" & vbCrLf & "The shop name already exists. Do you want to update the name?. " & (Dt.Rows(i)("BranchPublic").ToString), vbYesNo) = vbYes Then
                        GlCommand.CommandText = "UPDATE [TPBranchDetails]" & vbCrLf &
                                                    "Set [BranchDT] = @BranchDT" & vbCrLf &
                                                    ",[BranchServerNa] =@BranchServerNa" & vbCrLf &
                                                    ",[BranchUser] = @BranchUser" & vbCrLf &
                                                    ",[BranchPassword] =@BranchPassword" & vbCrLf &
                                                    ",[BranchPublic] =@BranchPublic" & vbCrLf &
                                                    ",[BranchActive] = @BranchActive" & vbCrLf &
                                                    "WHERE [BranchDT] LIKE @WhereBranchDT"

                        With GlCommand.Parameters
                            .Clear()
                            .AddWithValue("@BranchDT", cmbDtName.Text.Trim)
                            .AddWithValue("@BranchServerNa", cmbServerName.Text.Trim)
                            .AddWithValue("@BranchUser", txtUser.Text.Trim)
                            .AddWithValue("@BranchPassword", txtPassword.Text.Trim)
                            .AddWithValue("@BranchPublic", txtShopName.Text.Trim)
                            .AddWithValue("@BranchActive", 1)
                            .AddWithValue("@WhereBranchDT", cmbDtName.Text.Trim)  ' هذا الجديد لجملة WHERE
                        End With
                        GlCommand.ExecuteNonQuery()
                        MsgBox("تم التحديث بنجاح" & vbCrLf & "Update successfully", , AppTitle)
                        LodData()
                    Else
                        'Catch ex As Exception
                        MsgBox("تم الغاء  التحديث" & vbCrLf & "The Update Has Been Cancelled", , AppTitle)
                        'End Try
                    End If
                    Exit Sub

                End If
            Next
        Else

        End If
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
            .AddWithValue("@BranchDT", cmbDtName.Text.Trim)
            .AddWithValue("@BranchServerNa", cmbServerName.Text.Trim)
            .AddWithValue("@BranchUser", txtUser.Text.Trim)
            .AddWithValue("@BranchPassword", txtPassword.Text.Trim)
            .AddWithValue("@BranchPublic", txtShopName.Text.Trim)
            .AddWithValue("@BranchActive", 1)
        End With
        GlCommand.ExecuteNonQuery()
        LodData()
    End Sub

    Private Sub grid_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles Grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If Grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub
    Private Sub BtnSelectAll_Click(sender As Object, e As EventArgs) Handles BtnSelectAll.Click
        For Each row As DataGridViewRow In TrnsfGrid.Rows
            If row.Cells("colSelect").Value = True Then
                row.Cells("colSelect").Value = False
            ElseIf row.Cells("colSelect").Value = False Then
                row.Cells("colSelect").Value = True
            End If
        Next
    End Sub
    Private Sub TrnsfGrid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles TrnsfGrid.CellClick
        If TrnsfGrid.Columns(e.ColumnIndex).Name = "colTrans" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد تحويل القطعة رقم " & TrnsfGrid.Rows(e.RowIndex).Cells("colBarCode").Value & "؟" & vbCrLf & "Do You Want to Transfer Item No. " & TrnsfGrid.Rows(e.RowIndex).Cells("colBarCode").Value, vbYesNo) = vbYes Then
                BarCodeValue = TrnsfGrid.Rows(e.RowIndex).Cells("colBarCode").Value
                'استعلام اذا كان الباركود موجود او لا
                Dim TransToDt As DataTable = GetRecordSetToLocal("SELECT [BarCode] FROM [FO_min] WHERE BarCode LIKE '" & BarCodeValue & "'")
                If TransToDt.Rows.Count > 0 Then
                    'MsgBox("!الباركود المحول موجود بالفعل في  الفرع المحول له" & vbCrLf & "The transferred barcode already exists in the branch to which it was transferred !", , AppTitle)
                    MsgBox("تم العثور على الباركودات التالية في الفرع المحول إليه :" & vbCrLf & String.Join(vbCrLf, BarCodeValue) & vbCrLf & "The following barcodes were found in the branch ?: " & vbCrLf & "The following barcodes were found at the branch being transferred", , AppTitle)
                    Exit Sub
                End If
                Dim TransFromDt As DataTable = GetRecordSetLocal("SELECT * FROM [ViwGoldIItemAvailableReport] WHERE BarCode LIKE '" & BarCodeValue & "'")
                If TransFromDt.Rows.Count > 0 Then
                    TOSQLGlCommand.CommandText = "INSERT INTO [FO_min]" &
                                            " ([userID]" &
                                            ",[FO_name]" &
                                            ",[FO_desp]" &
                                            ",[FO_price]" &
                                            ",[FO_GramPrice]" &
                                            ",[FO_gram]" &
                                            ",[FO_gramMade]" &
                                            ",[FO_made]" &
                                            ",[FO_extras]" &
                                            ",[FO_totalPrice]" &
                                            ",[Gram_valu]" &
                                            ",[date_care]" &
                                            ",[FO_ItemNo]" &
                                            ",[Item_Actv]" &
                                            ",[StoneColor1]" &
                                            ",[StonePrice1]" &
                                            ",[StoneWeight2]" &
                                            ",[StoneName2]" &
                                            ",[StoneColor2]" &
                                            ",[StonePrice2]" &
                                            ",[StoneWeight3]" &
                                            ",[StoneName3]" &
                                            ",[StoneColor3]" &
                                            ",[StonePrice3]" &
                                            ",[Qty]" &
                                            ",[BarCode]" &
                                            ",[LastEditDate]" &
                                            ",[ItemNote]" &
                                            ",[GoldCaret999]" &
                                            ",[GoldWeight999]" &
                                            ",[PurInvNumber]" &
                                            ",[MultiItem])" &
                                            "VALUES" &
                                            "(@userID" &
                                            ",@FO_name" &
                                            ",@FO_desp" &
                                            ",@FO_price" &
                                            ",@FO_GramPrice" &
                                            ",@FO_gram" &
                                            ",@FO_gramMade" &
                                            ",@FO_made" &
                                            ",@FO_extras" &
                                            ",@FO_totalPrice" &
                                            ",@Gram_valu" &
                                            ",@date_care" &
                                            ",@FO_ItemNo" &
                                            ",@Item_Actv" &
                                            ",@StoneColor1" &
                                            ",@StonePrice1" &
                                            ",@StoneWeight2" &
                                            ",@StoneName2" &
                                            ",@StoneColor2" &
                                            ",@StonePrice2" &
                                            ",@StoneWeight3" &
                                            ",@StoneName3" &
                                            ",@StoneColor3" &
                                            ",@StonePrice3" &
                                            ",@Qty" &
                                            ",@BarCode" &
                                            ",@LastEditDate" &
                                            ",@ItemNote" &
                                            ",@GoldCaret999" &
                                            ",@GoldWeight999" &
                                            ",@PurInvNumber" &
                                            ",@MultiItem)"
                    With TOSQLGlCommand.Parameters
                        .Clear()
                        .AddWithValue("@userID", If((TransFromDt.Rows(0)("userID").ToString) = "", UserName, (TransFromDt.Rows(0)("userID").ToString)))
                        .AddWithValue("@FO_name", (TransFromDt.Rows(0)("FO_name").ToString))
                        .AddWithValue("@FO_desp", (TransFromDt.Rows(0)("FO_desp").ToString))
                        .AddWithValue("@FO_price", If(IsDBNull((TransFromDt.Rows(0)("FO_price").ToString)), "", (TransFromDt.Rows(0)("FO_price").ToString)))
                        .AddWithValue("@FO_GramPrice", (TransFromDt.Rows(0)("FO_GramPrice").ToString))
                        .AddWithValue("@FO_gram", (TransFromDt.Rows(0)("FO_gram").ToString))
                        .AddWithValue("@FO_gramMade", (TransFromDt.Rows(0)("FO_gramMade").ToString))
                        .AddWithValue("@FO_made", (TransFromDt.Rows(0)("FO_made").ToString))
                        .AddWithValue("@FO_extras", If(IsDBNull((TransFromDt.Rows(0)("FO_extras").ToString)) Or ((TransFromDt.Rows(0)("FO_extras").ToString) = ""), 0, ((TransFromDt.Rows(0)("FO_extras").ToString))))
                        .AddWithValue("@FO_totalPrice", (TransFromDt.Rows(0)("FO_totalPrice").ToString))
                        .AddWithValue("@Gram_valu", (TransFromDt.Rows(0)("Gram_valu").ToString))
                        '.Add("@ITEM_IMGE", SqlDbType.Image).Value = (TransFromDt.Rows(0)("ITEM_IMGE"))
                        .AddWithValue("@date_care", DateToSave((TransFromDt.Rows(0)("date_care").ToString)))
                        .AddWithValue("@FO_ItemNo", (TransFromDt.Rows(0)("FO_ItemNo").ToString))
                        .AddWithValue("@Item_Actv", "1")
                        .AddWithValue("@StoneColor1", (TransFromDt.Rows(0)("StoneColor1").ToString))
                        .AddWithValue("@StonePrice1", If(IsDBNull((TransFromDt.Rows(0)("StonePrice1").ToString)) Or ((TransFromDt.Rows(0)("StonePrice1").ToString) = ""), 0, (TransFromDt.Rows(0)("StonePrice1").ToString)))
                        .AddWithValue("@StoneWeight2", If(IsDBNull((TransFromDt.Rows(0)("StoneWeight2").ToString)) Or ((TransFromDt.Rows(0)("StoneWeight2").ToString) = ""), 0, (TransFromDt.Rows(0)("StoneWeight2").ToString)))
                        .AddWithValue("@StoneName2", If(IsDBNull(TransFromDt.Rows(0)("StoneName2").ToString), "", (TransFromDt.Rows(0)("StoneName2").ToString)))
                        .AddWithValue("@StoneColor2", (TransFromDt.Rows(0)("StoneColor2").ToString))
                        .AddWithValue("@StonePrice2", If(IsDBNull((TransFromDt.Rows(0)("StonePrice2").ToString)) Or ((TransFromDt.Rows(0)("StonePrice2").ToString) = ""), 0, (TransFromDt.Rows(0)("StonePrice2").ToString)))
                        .AddWithValue("@StoneWeight3", If(IsDBNull((TransFromDt.Rows(0)("StoneWeight3").ToString)) Or ((TransFromDt.Rows(0)("StoneWeight3").ToString) = ""), 0, (TransFromDt.Rows(0)("StoneWeight3").ToString)))
                        .AddWithValue("@StoneName3", If(IsDBNull(TransFromDt.Rows(0)("StoneName3").ToString), "", TransFromDt.Rows(0)("StoneName3").ToString))
                        .AddWithValue("@StoneColor3", (TransFromDt.Rows(0)("StonePrice3").ToString))
                        .AddWithValue("@StonePrice3", If(IsDBNull((TransFromDt.Rows(0)("StonePrice3").ToString)) Or (TransFromDt.Rows(0)("StonePrice3").ToString) = "", 0, (TransFromDt.Rows(0)("StonePrice3").ToString)))
                        .AddWithValue("@Qty", If(IsDBNull((TransFromDt.Rows(0)("Qty").ToString)), 1, (TransFromDt.Rows(0)("Qty").ToString)))
                        .AddWithValue("@BarCode", If(IsDBNull((TransFromDt.Rows(0)("BarCode").ToString)) Or (TransFromDt.Rows(0)("BarCode").ToString) = "", (TransFromDt.Rows(0)("BarCode").ToString), (TransFromDt.Rows(0)("BarCode").ToString)))
                        .AddWithValue("@LastEditDate", Date.UtcNow)
                        .AddWithValue("@ItemNote", (TransFromDt.Rows(0)("ItemNote").ToString))
                        .AddWithValue("@GoldCaret999", If(IsDBNull((TransFromDt.Rows(0)("GoldCaret999").ToString)) Or (TransFromDt.Rows(0)("GoldCaret999").ToString) = "", "999", (TransFromDt.Rows(0)("GoldCaret999").ToString)))
                        .AddWithValue("@GoldWeight999", (TransFromDt.Rows(0)("GoldWeight999").ToString))
                        .AddWithValue("@PurInvNumber", (TransFromDt.Rows(0)("PurInvNumber").ToString))
                        .AddWithValue("@MultiItem", If((TransFromDt.Rows(0)("MultiItem").ToString) = False, 0, 1))
                    End With
                    TOSQLGlCommand.ExecuteNonQuery()

                    'اضافة الباركود المحول الي الفرع المحول منه
                    FromSQLGlCommand.CommandText = "INSERT INTO [TPTransfer]" &
                                                   "([BarCodeTransfer], [DateBarCode], [TimeBarCode], [TransferStatus])" &
                                                   "VALUES" &
                                                  "(@BarCodeTransfer, @DateBarCode, @TimeBarCode, @TransferStatus)"
                    With FromSQLGlCommand.Parameters
                        .Clear()
                        .AddWithValue("@BarCodeTransfer", (BarCodeValue))
                        .AddWithValue("@DateBarCode", DateToSave(Date.Now))
                        .AddWithValue("@TimeBarCode", (Date.UtcNow))
                        .AddWithValue("@TransferStatus", ("0"))
                        FromSQLGlCommand.ExecuteNonQuery()
                    End With
                    'اضافة الباركود الي الفرع المحول له
                    TOSQLGlCommand.CommandText = "INSERT INTO [TPTransfer]" &
                                                   "([BarCodeTransfer], [DateBarCode], [TimeBarCode], [TransferStatus])" &
                                                   "VALUES" &
                                                  "(@BarCodeTransfer, @DateBarCode, @TimeBarCode, @TransferStatus)"
                    With TOSQLGlCommand.Parameters
                        .Clear()
                        .AddWithValue("@BarCodeTransfer", (BarCodeValue))
                        .AddWithValue("@DateBarCode", DateToSave(Date.Now))
                        .AddWithValue("@TimeBarCode", (Date.UtcNow))
                        .AddWithValue("@TransferStatus", ("1"))
                        TOSQLGlCommand.ExecuteNonQuery()
                    End With
                    FromSQLGlCommand.CommandText = ("UPDATE [FO_min] Set [BarCodeNote] = N'  تم تحويل الباركود من فرع   " & ComBoxTo.Text.Trim & " الي فرع " & ComBoxFrom.Text.Trim & "' ,[Item_Actv] = '0' WHERE BarCode LIKE '" & BarCodeValue & "'")
                    FromSQLGlCommand.ExecuteNonQuery()
                    TOSQLGlCommand.CommandText = ("UPDATE [FO_min] Set [BarCodeNote] = N' تم استلام الباركود من فرع   " & ComBoxFrom.Text.Trim & " الي فرع " & ComBoxTo.Text.Trim & "' ,[Item_Actv] = '1' WHERE BarCode LIKE '" & BarCodeValue & "'")
                    TOSQLGlCommand.ExecuteNonQuery()
                    MsgBox(".تم تحويل الباركود المحدد بنجاح" & vbCrLf & "The Selected Barcode Has Been Transfer Successfully.", , AppTitle)
                Else
                    MessageBox.Show("لا توجد بيانات مطابقة.")
                End If
            Else
                MessageBox.Show("الباركود غير متوفر أو الصف غير محدد.")
            End If
        End If
    End Sub
    Private Sub TrnsfGrid_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles TrnsfGrid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If TrnsfGrid.Columns(e.ColumnIndex).Name = "colTrans" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.paper_plane__plus, CInt((e.CellBounds.Width / 2) - (My.Resources.paper_plane__plus.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.paper_plane__plus.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub
    Private Sub grid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles Grid.CellClick
        If Grid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            If MsgBox("هل تريد حذف الفرع رقم " & Grid.Rows(e.RowIndex).Cells("colBranchPublic").Value & "؟" & vbCrLf & "Do You Want to Delete Branch No. " & Grid.Rows(e.RowIndex).Cells("colBranchPublic").Value, vbYesNo) = vbYes Then
                Try
                    GlCommand.CommandText = "UPDATE [TPBranchDetails] SET [BranchActive]='0' WHERE BranchDT='" & Grid.CurrentRow.Cells("colBranchDT").Value & "'"
                    GlCommand.ExecuteNonQuery()
                    MsgBox("تم الحذف بنجاح" & vbCrLf & "Delete successfully", , AppTitle)
                    Grid.Rows.Remove(Grid.SelectedRows(0))
                Catch ex As Exception
                    MsgBox("تم الغاء الحذف" & vbCrLf & "Delete Has Been Cancelled", , AppTitle)
                End Try
            End If
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TEST.ShowDialog()
    End Sub

    Private Sub TransfersItem_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub TransfersItem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub


    Private Sub txtFrmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtFrmPassword.TextChanged
        '
        If txtFrmPassword.Text = "@sap2020" Then
            TabPage2.Enabled = True
            ComBoxFrom.Enabled = True
        Else
            TabPage2.Enabled = False
            ComBoxFrom.Enabled = False
        End If
    End Sub

    Private Sub BtnTransSelect_Click(sender As Object, e As EventArgs) Handles BtnTransSelect.Click

        Dim SelectFrom As String
        Dim SelectTo As String
        If ComBoxFrom.SelectedItem IsNot Nothing Then
            Dim selectedRow As DataRowView = TryCast(ComBoxFrom.SelectedItem, DataRowView)
            If selectedRow IsNot Nothing Then
                SelectFrom = selectedRow("BranchDT").ToString()
            End If
        End If
        If ComBoxTo.SelectedItem IsNot Nothing Then
            Dim selectedRow As DataRowView = TryCast(ComBoxTo.SelectedItem, DataRowView)
            If selectedRow IsNot Nothing Then
                SelectTo = (selectedRow("BranchDT").ToString())
            End If
        End If
        If SelectFrom = SelectTo Then
            MessageBox.Show("لايمكن اجراء التحويل رجاي اختيار فرع مختلف عن فرع التحول" & vbCrLf & "The transfer cannot be made. Please choose a branch different from the transfer branch.", "خطأ في اختيار اسم الفرع", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        For Each row As DataGridViewRow In TrnsfGrid.Rows
            If Not row.IsNewRow Then
                If Convert.ToBoolean(row.Cells("colSelect").Value) = True Then
                    BarCodeValue = row.Cells("colBarCode").Value.ToString()
                    Dim TransToDt As DataTable = GetRecordSetToLocal("SELECT [BarCode] FROM [FO_min] WHERE BarCode LIKE '" & BarCodeValue & "'")
                    If TransToDt.Rows.Count > 0 Then
                        existingBarcodes.Add(BarCodeValue)
                    End If
                End If
            End If
        Next
        If existingBarcodes.Count > 0 Then
            MsgBox("تم العثور على الباركودات التالية في الفرع المحول إليه :" & vbCrLf & String.Join(vbCrLf, existingBarcodes) & vbCrLf & "The following barcodes were found in the branch ?: " & vbCrLf & "The following barcodes were found at the branch being transferred", , AppTitle)
            existingBarcodes.Clear()
            Exit Sub
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Transfer()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub
    Private Sub Transfer()
        For Each row As DataGridViewRow In TrnsfGrid.Rows
            If Not row.IsNewRow Then
                If Convert.ToBoolean(row.Cells("colSelect").Value) = True Then
                    BarCodeValue = row.Cells("colBarCode").Value.ToString()
                    Dim TransFromDt As DataTable = GetRecordSetLocal("SELECT * FROM [ViwGoldIItemAvailableReport] WHERE BarCode Like '" & BarCodeValue & "'")
                If TransFromDt.Rows.Count > 0 Then
                        TOSQLGlCommand.CommandText = "INSERT INTO [FO_min]" &
                                            " ([userID]" &
                                            ",[FO_name]" &
                                            ",[FO_desp]" &
                                            ",[FO_price]" &
                                            ",[FO_GramPrice]" &
                                            ",[FO_gram]" &
                                            ",[FO_gramMade]" &
                                            ",[FO_made]" &
                                            ",[FO_extras]" &
                                            ",[FO_totalPrice]" &
                                            ",[Gram_valu]" &
                                            ",[date_care]" &
                                            ",[FO_ItemNo]" &
                                            ",[Item_Actv]" &
                                            ",[StoneColor1]" &
                                            ",[StonePrice1]" &
                                            ",[StoneWeight2]" &
                                            ",[StoneName2]" &
                                            ",[StoneColor2]" &
                                            ",[StonePrice2]" &
                                            ",[StoneWeight3]" &
                                            ",[StoneName3]" &
                                            ",[StoneColor3]" &
                                            ",[StonePrice3]" &
                                            ",[Qty]" &
                                            ",[BarCode]" &
                                            ",[LastEditDate]" &
                                            ",[ItemNote]" &
                                            ",[GoldCaret999]" &
                                            ",[GoldWeight999]" &
                                            ",[PurInvNumber]" &
                                            ",[MultiItem])" &
                                            "VALUES" &
                                            "(@userID" &
                                            ",@FO_name" &
                                            ",@FO_desp" &
                                            ",@FO_price" &
                                            ",@FO_GramPrice" &
                                            ",@FO_gram" &
                                            ",@FO_gramMade" &
                                            ",@FO_made" &
                                            ",@FO_extras" &
                                            ",@FO_totalPrice" &
                                            ",@Gram_valu" &
                                            ",@date_care" &
                                            ",@FO_ItemNo" &
                                            ",@Item_Actv" &
                                            ",@StoneColor1" &
                                            ",@StonePrice1" &
                                            ",@StoneWeight2" &
                                            ",@StoneName2" &
                                            ",@StoneColor2" &
                                            ",@StonePrice2" &
                                            ",@StoneWeight3" &
                                            ",@StoneName3" &
                                            ",@StoneColor3" &
                                            ",@StonePrice3" &
                                            ",@Qty" &
                                            ",@BarCode" &
                                            ",@LastEditDate" &
                                            ",@ItemNote" &
                                            ",@GoldCaret999" &
                                            ",@GoldWeight999" &
                                            ",@PurInvNumber" &
                                            ",@MultiItem)"
                        With TOSQLGlCommand.Parameters
                            .Clear()
                            .AddWithValue("@userID", If((TransFromDt.Rows(0)("userID").ToString) = "", UserName, (TransFromDt.Rows(0)("userID").ToString)))
                            .AddWithValue("@FO_name", (TransFromDt.Rows(0)("FO_name").ToString))
                            .AddWithValue("@FO_desp", (TransFromDt.Rows(0)("FO_desp").ToString))
                            .AddWithValue("@FO_price", If(IsDBNull((TransFromDt.Rows(0)("FO_price").ToString)), "", (TransFromDt.Rows(0)("FO_price").ToString)))
                            .AddWithValue("@FO_GramPrice", (TransFromDt.Rows(0)("FO_GramPrice").ToString))
                            .AddWithValue("@FO_gram", (TransFromDt.Rows(0)("FO_gram").ToString))
                            .AddWithValue("@FO_gramMade", (TransFromDt.Rows(0)("FO_gramMade").ToString))
                            .AddWithValue("@FO_made", (TransFromDt.Rows(0)("FO_made").ToString))
                            .AddWithValue("@FO_extras", If(IsDBNull((TransFromDt.Rows(0)("FO_extras").ToString)) Or ((TransFromDt.Rows(0)("FO_extras").ToString) = ""), 0, ((TransFromDt.Rows(0)("FO_extras").ToString))))
                            .AddWithValue("@FO_totalPrice", (TransFromDt.Rows(0)("FO_totalPrice").ToString))
                            .AddWithValue("@Gram_valu", (TransFromDt.Rows(0)("Gram_valu").ToString))
                            '.Add("@ITEM_IMGE", SqlDbType.Image).Value = (TransFromDt.Rows(0)("ITEM_IMGE"))
                            .AddWithValue("@date_care", DateToSave((TransFromDt.Rows(0)("date_care").ToString)))
                            .AddWithValue("@FO_ItemNo", (TransFromDt.Rows(0)("FO_ItemNo").ToString))
                            .AddWithValue("@Item_Actv", "1")
                            .AddWithValue("@StoneColor1", (TransFromDt.Rows(0)("StoneColor1").ToString))
                            .AddWithValue("@StonePrice1", If(IsDBNull((TransFromDt.Rows(0)("StonePrice1").ToString)) Or ((TransFromDt.Rows(0)("StonePrice1").ToString) = ""), 0, (TransFromDt.Rows(0)("StonePrice1").ToString)))
                            .AddWithValue("@StoneWeight2", If(IsDBNull((TransFromDt.Rows(0)("StoneWeight2").ToString)) Or ((TransFromDt.Rows(0)("StoneWeight2").ToString) = ""), 0, (TransFromDt.Rows(0)("StoneWeight2").ToString)))
                            .AddWithValue("@StoneName2", If(IsDBNull(TransFromDt.Rows(0)("StoneName2").ToString), "", (TransFromDt.Rows(0)("StoneName2").ToString)))
                            .AddWithValue("@StoneColor2", (TransFromDt.Rows(0)("StoneColor2").ToString))
                            .AddWithValue("@StonePrice2", If(IsDBNull((TransFromDt.Rows(0)("StonePrice2").ToString)) Or ((TransFromDt.Rows(0)("StonePrice2").ToString) = ""), 0, (TransFromDt.Rows(0)("StonePrice2").ToString)))
                            .AddWithValue("@StoneWeight3", If(IsDBNull((TransFromDt.Rows(0)("StoneWeight3").ToString)) Or ((TransFromDt.Rows(0)("StoneWeight3").ToString) = ""), 0, (TransFromDt.Rows(0)("StoneWeight3").ToString)))
                            .AddWithValue("@StoneName3", If(IsDBNull(TransFromDt.Rows(0)("StoneName3").ToString), "", TransFromDt.Rows(0)("StoneName3").ToString))
                            .AddWithValue("@StoneColor3", (TransFromDt.Rows(0)("StonePrice3").ToString))
                            .AddWithValue("@StonePrice3", If(IsDBNull((TransFromDt.Rows(0)("StonePrice3").ToString)) Or (TransFromDt.Rows(0)("StonePrice3").ToString) = "", 0, (TransFromDt.Rows(0)("StonePrice3").ToString)))
                            .AddWithValue("@Qty", If(IsDBNull((TransFromDt.Rows(0)("Qty").ToString)), 1, (TransFromDt.Rows(0)("Qty").ToString)))
                            .AddWithValue("@BarCode", If(IsDBNull((TransFromDt.Rows(0)("BarCode").ToString)) Or (TransFromDt.Rows(0)("BarCode").ToString) = "", (TransFromDt.Rows(0)("BarCode").ToString), (TransFromDt.Rows(0)("BarCode").ToString)))
                            .AddWithValue("@LastEditDate", Date.UtcNow)
                            .AddWithValue("@ItemNote", (TransFromDt.Rows(0)("ItemNote").ToString))
                            .AddWithValue("@GoldCaret999", If(IsDBNull((TransFromDt.Rows(0)("GoldCaret999").ToString)) Or (TransFromDt.Rows(0)("GoldCaret999").ToString) = "", "999", (TransFromDt.Rows(0)("GoldCaret999").ToString)))
                            .AddWithValue("@GoldWeight999", (TransFromDt.Rows(0)("GoldWeight999").ToString))
                            .AddWithValue("@PurInvNumber", (TransFromDt.Rows(0)("PurInvNumber").ToString))
                            .AddWithValue("@MultiItem", If((TransFromDt.Rows(0)("MultiItem").ToString) = False, 0, 1))
                        End With
                        TOSQLGlCommand.ExecuteNonQuery()
                        'اضافة الباركود المحول الي الفرع المحول منه
                        FromSQLGlCommand.CommandText = "INSERT INTO [TPTransfer]" &
                                                   "([BarCodeTransfer], [DateBarCode], [TimeBarCode], [TransferStatus])" &
                                                   "VALUES" &
                                                  "(@BarCodeTransfer, @DateBarCode, @TimeBarCode, @TransferStatus)"
                        With FromSQLGlCommand.Parameters
                            .Clear()
                            .AddWithValue("@BarCodeTransfer", (BarCodeValue))
                            .AddWithValue("@DateBarCode", DateToSave(Date.Now))
                            .AddWithValue("@TimeBarCode", (Date.UtcNow))
                            .AddWithValue("@TransferStatus", ("0"))
                            FromSQLGlCommand.ExecuteNonQuery()
                        End With
                        'اضافة الباركود الي الفرع المحول له
                        TOSQLGlCommand.CommandText = "INSERT INTO [TPTransfer]" &
                                                   "([BarCodeTransfer], [DateBarCode], [TimeBarCode], [TransferStatus])" &
                                                   "VALUES" &
                                                  "(@BarCodeTransfer, @DateBarCode, @TimeBarCode, @TransferStatus)"
                        With TOSQLGlCommand.Parameters
                            .Clear()
                            .AddWithValue("@BarCodeTransfer", (BarCodeValue))
                            .AddWithValue("@DateBarCode", DateToSave(Date.Now))
                            .AddWithValue("@TimeBarCode", (Date.UtcNow))
                            .AddWithValue("@TransferStatus", ("1"))
                            TOSQLGlCommand.ExecuteNonQuery()
                        End With
                        FromSQLGlCommand.CommandText = ("UPDATE [FO_min] Set [BarCodeNote] = N'  تم تحويل الباركود من فرع   " & ComBoxTo.Text.Trim & " الي فرع " & ComBoxFrom.Text.Trim & "' ,[Item_Actv] = '0' WHERE BarCode LIKE '" & BarCodeValue & "'")
                        FromSQLGlCommand.ExecuteNonQuery()
                        TOSQLGlCommand.CommandText = ("UPDATE [FO_min] Set [BarCodeNote] = N' تم استلام الباركود من فرع   " & ComBoxFrom.Text.Trim & " الي فرع " & ComBoxTo.Text.Trim & "' ,[Item_Actv] = '1' WHERE BarCode LIKE '" & BarCodeValue & "'")
                        TOSQLGlCommand.ExecuteNonQuery()

                    Else
                        MessageBox.Show("لا توجد بيانات مطابقة.")
                    End If
                    'Else
                    '    MessageBox.Show("الباركود غير متوفر أو الصف غير محدد.")
                End If

            End If

        Next
        MsgBox(".تم تحويل الباركود المحدد بنجاح" & vbCrLf & "The Selected Barcode Has Been Transfer Successfully.", , AppTitle)
    End Sub
End Class
