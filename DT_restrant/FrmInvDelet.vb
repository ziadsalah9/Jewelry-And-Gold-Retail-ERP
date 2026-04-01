Option Strict On
Option Explicit On

Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Data.SqlClient




Partial Public Class FrmInvDelet
    Private Class InvoiceNodes
        Public Property InvNode As TreeNode
        Public Property ItemsRoot As TreeNode
        Public Property ItemMap As Dictionary(Of String, TreeNode)
    End Class
    Dim SQLCommend As String
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub FrmInvDelet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        DGV_Style.ApplyGoldenStyle(GridGold)
        TooltipHelper.EnableTextBoxTooltips(Me)
        ApplyIconsToContainer(Me)
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)

        DateFromGold.Format = DateTimePickerFormat.Custom
        DateFromGold.CustomFormat = "dd/MM/yyyy"
        DateToGold.Format = DateTimePickerFormat.Custom
        DateToGold.CustomFormat = "dd/MM/yyyy"
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        TabDelContr.Alignment = TabAlignment.Top
        TabDelContr.Multiline = False
        TabDelContr.DrawMode = TabDrawMode.OwnerDrawFixed
        TabDelContr.SizeMode = TabSizeMode.Fixed
        TabDelContr.ItemSize = New Size(110, 44)  ' غيّرها 120/130 حسب رغبتك
        TabDelContr.Padding = New Point(10, 4)
        TabDelContr.HotTrack = True
        TabDelContr.RightToLeft = RightToLeft.Yes
        TabDelContr.RightToLeftLayout = True
        RemoveHandler TabDelContr.DrawItem, AddressOf TabDelContr_DrawItem
        AddHandler TabDelContr.DrawItem, AddressOf TabDelContr_DrawItem
    End Sub

#Region "TabControl - Colored Tabs (OwnerDraw + RTL Fix)"
    Private Sub TabDelContr_DrawItem(sender As Object, e As DrawItemEventArgs)
        Dim tab = DirectCast(sender, TabControl)
        If e.Index < 0 OrElse e.Index >= tab.TabPages.Count Then Exit Sub

        Dim page = tab.TabPages(e.Index)
        Dim r = tab.GetTabRect(e.Index)

        ' ✅ هذا هو الإصلاح الأساسي لمشكلة RTL (الرسم كان في مكان والضغط في مكان)
        If tab.RightToLeftLayout Then
            r = New Rectangle(tab.ClientSize.Width - r.Right, r.Y, r.Width, r.Height)
        End If

        If r.Width <= 5 OrElse r.Height <= 5 Then Exit Sub

        Dim selected As Boolean = (e.Index = tab.SelectedIndex)

        Dim c1 As Color, c2 As Color
        Select Case page.Name
            Case "TabGold"
                c1 = If(selected, Color.FromArgb(205, 150, 35), Color.FromArgb(230, 180, 60))
                c2 = If(selected, Color.FromArgb(160, 110, 20), Color.FromArgb(200, 140, 35))
            Case "TabSilver"
                c1 = If(selected, Color.FromArgb(96, 105, 122), Color.FromArgb(140, 148, 163))
                c2 = If(selected, Color.FromArgb(60, 68, 80), Color.FromArgb(105, 112, 125))
            Case "TabDaimond"
                c1 = If(selected, Color.FromArgb(46, 196, 182), Color.FromArgb(120, 220, 210))
                c2 = If(selected, Color.FromArgb(14, 132, 122), Color.FromArgb(40, 170, 160))
            Case Else
                c1 = If(selected, Color.FromArgb(64, 99, 175), Color.FromArgb(120, 145, 200))
                c2 = If(selected, Color.FromArgb(35, 60, 120), Color.FromArgb(80, 105, 160))
        End Select

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        ' خلفية Gradient
        Using br As New Drawing2D.LinearGradientBrush(r, c1, c2, Drawing2D.LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(br, r)
        End Using

        ' إطار خفيف
        Using p As New Pen(Color.FromArgb(50, 0, 0, 0))
            e.Graphics.DrawRectangle(p, r)
        End Using

        ' أيقونة صغيرة يمين (RTL)
        Dim iconRect As New Rectangle(r.Right - 22, r.Top + (r.Height \ 2) - 6, 12, 12)
        DrawTabIcon(e.Graphics, page.Name, iconRect, Color.White)

        ' نص التبويب
        Dim textRect As New RectangleF(r.Left + 6, r.Top, r.Width - 30, r.Height)

        Using sf As New StringFormat()
            sf.Alignment = StringAlignment.Center
            sf.LineAlignment = StringAlignment.Center
            sf.FormatFlags = StringFormatFlags.DirectionRightToLeft

            Using txtBrush As New SolidBrush(Color.White)
                e.Graphics.DrawString(page.Text, tab.Font, txtBrush, textRect, sf)
            End Using
        End Using

        ' underline للتبويب المحدد
        If selected Then
            Using pSel As New Pen(Color.White, 3)
                e.Graphics.DrawLine(pSel, r.Left + 8, r.Bottom - 3, r.Right - 8, r.Bottom - 3)
            End Using
        End If
    End Sub

    Private Sub DrawTabIcon(g As Graphics, tabName As String, rc As Rectangle, col As Color)
        Using b As New SolidBrush(col)
            Select Case tabName
                Case "TabGold"
                    g.FillEllipse(b, rc) ' دائرة
                Case "TabSilver"
                    g.FillRectangle(b, rc) ' مربع
                Case "TabDaimond"
                    ' معيّن صغير
                    Dim cx As Integer = rc.Left + rc.Width \ 2
                    Dim cy As Integer = rc.Top + rc.Height \ 2
                    Dim pts() As Point = {
                    New Point(cx, rc.Top),
                    New Point(rc.Right, cy),
                    New Point(cx, rc.Bottom),
                    New Point(rc.Left, cy)
                }
                    g.FillPolygon(b, pts)
                Case Else
                    g.FillEllipse(b, rc)
            End Select
        End Using
    End Sub
#End Region

#Region "ذهب بيع وشراء"

    Dim TreeViewSelSqlCom As String
    Dim TreeViewPurchaseSqlCom As String
    Private Sub TreeViewSellInv()
        Dim dt As DataTable = GetRecordSet(TreeViewSelSqlCom)
        TreeViewInv.BeginUpdate()
        If dt.Rows.Count > 0 Then
            Try
                TreeViewInv.Nodes.Clear()
                If dt Is Nothing OrElse dt.Rows.Count = 0 Then Exit Try
                Dim invMap As New Dictionary(Of String, InvoiceNodes)(StringComparer.OrdinalIgnoreCase)
                For Each r As DataRow In dt.Rows
                    Dim invNo As String = r("BAY_SARYAL").ToString().Trim()
                    If invNo = "" Then Continue For
                    Dim itemName As String = r("item_name").ToString().Trim()
                    Dim barCode As String = r("BarCode").ToString().Trim()
                    Dim itemW As String = r("item_gram").ToString().Trim()
                    Dim itemMakeCh As String = r("item_gramMade").ToString().Trim()
                    Dim itemTotalPrice As String = r("item_totalPrice").ToString().Trim()
                    Dim castomerId As String = r("Castomerid").ToString().Trim()
                    Dim castomerName As String = r("CastomerNAme").ToString().Trim()
                    Dim castomerTe As String = r("CastomerTE").ToString().Trim()
                    Dim castomerNa As String = r("CastomerNA").ToString().Trim()
                    Dim total As String = r("TOTAL_mony").ToString().Trim()
                    Dim nodes As InvoiceNodes = Nothing
                    If Not invMap.TryGetValue(invNo, nodes) Then
                        Dim invNode As TreeNode = TreeViewInv.Nodes.Add($"INV:{invNo}", $"فاتورة رقم: {invNo}")
                        invNode.Tag = invNo
                        Dim itemsRoot As TreeNode = invNode.Nodes.Add($"ITEMS:{invNo}", "الأصناف")
                        Dim custNode As TreeNode = invNode.Nodes.Add($"CUST:{invNo}", "بيانات العميل")
                        custNode.Nodes.Add($"CID:{invNo}", $"الرقم المدني: {castomerId}")
                        custNode.Nodes.Add($"CNAME:{invNo}", $"اسم العميل: {castomerName}")
                        custNode.Nodes.Add($"CNAT:{invNo}", $"الجنسية: {castomerNa}")
                        custNode.Nodes.Add($"CTEL:{invNo}", $"رقم التلفون: {castomerTe}")
                        Dim payNode As TreeNode = invNode.Nodes.Add($"PAY:{invNo}", "بيانات الدفع")
                        payNode.Nodes.Add($"TOTAL:{invNo}", $"اجمالي المبلغ: {total}")
                        nodes = New InvoiceNodes With {
                        .InvNode = invNode,
                        .ItemsRoot = itemsRoot,
                        .ItemMap = New Dictionary(Of String, TreeNode)(StringComparer.OrdinalIgnoreCase)
                    }
                        invMap(invNo) = nodes
                    End If
                    Dim itemKey As String = $"{itemName}|{barCode}"
                    If Not nodes.ItemMap.ContainsKey(itemKey) Then
                        Dim itemNode As TreeNode = nodes.ItemsRoot.Nodes.Add($"ITEM:{invNo}:{itemKey}", $"الصنف: {itemName}")
                        itemNode.Tag = barCode ' مفيد لاحقاً عند الضغط
                        If barCode <> "" Then itemNode.Nodes.Add($"BAR:{invNo}:{itemKey}", $"الباركود: {barCode}")
                        If itemW <> "" Then itemNode.Nodes.Add($"W:{invNo}:{itemKey}", $"الوزن: {itemW} جم")
                        If itemMakeCh <> "" Then itemNode.Nodes.Add($"MAKE:{invNo}:{itemKey}", $"المصنعيه: {itemMakeCh}")
                        If itemTotalPrice <> "" Then itemNode.Nodes.Add($"IPRICE:{invNo}:{itemKey}", $"السعر الإجمالي: {itemTotalPrice}")
                        nodes.ItemMap(itemKey) = itemNode
                    End If
                Next
            Finally
                TreeViewInv.EndUpdate()
            End Try
        End If
    End Sub
    Private Sub TreeViewPurchaseInv()
        Dim dt As DataTable = GetRecordSet(TreeViewPurchaseSqlCom)
        TreeViewInv.BeginUpdate()
        If dt.Rows.Count > 0 Then
            Try
                TreeViewInv.Nodes.Clear()
                If dt Is Nothing OrElse dt.Rows.Count = 0 Then Exit Try
                Dim invMap As New Dictionary(Of String, InvoiceNodes)(StringComparer.OrdinalIgnoreCase)
                For Each r As DataRow In dt.Rows
                    Dim invNo As String = r("inv_id").ToString().Trim()
                    If invNo = "" Then Continue For
                    Dim itemName As String = r("Item_Des").ToString().Trim()
                    Dim barCode As String = r("B_gold_id").ToString().Trim()
                    Dim itemW As String = r("bay_mazan").ToString().Trim()
                    Dim itemTotalPrice As String = r("bay_total_price").ToString().Trim()
                    Dim castomerId As String = r("castomer_id").ToString().Trim()
                    Dim castomerName As String = r("CastomerNAme").ToString().Trim()
                    Dim castomerTe As String = r("CastomerTE").ToString().Trim()
                    Dim castomerNa As String = r("CastomerNA").ToString().Trim()
                    Dim total As String = r("total_price").ToString().Trim()
                    Dim nodes As InvoiceNodes = Nothing
                    If Not invMap.TryGetValue(invNo, nodes) Then
                        Dim invNode As TreeNode = TreeViewInv.Nodes.Add($"INV:{invNo}", $"فاتورة رقم: {invNo}")
                        invNode.Tag = invNo
                        Dim itemsRoot As TreeNode = invNode.Nodes.Add($"ITEMS:{invNo}", "الأصناف")
                        Dim custNode As TreeNode = invNode.Nodes.Add($"CUST:{invNo}", "بيانات العميل")
                        custNode.Nodes.Add($"CID:{invNo}", $"الرقم المدني: {castomerId}")
                        custNode.Nodes.Add($"CNAME:{invNo}", $"اسم العميل: {castomerName}")
                        custNode.Nodes.Add($"CNAT:{invNo}", $"الجنسية: {castomerNa}")
                        custNode.Nodes.Add($"CTEL:{invNo}", $"رقم التلفون: {castomerTe}")
                        Dim payNode As TreeNode = invNode.Nodes.Add($"PAY:{invNo}", "بيانات الدفع")
                        payNode.Nodes.Add($"TOTAL:{invNo}", $"اجمالي المبلغ: {total}")
                        nodes = New InvoiceNodes With {
                        .InvNode = invNode,
                        .ItemsRoot = itemsRoot,
                        .ItemMap = New Dictionary(Of String, TreeNode)(StringComparer.OrdinalIgnoreCase)
                    }
                        invMap(invNo) = nodes
                    End If
                    Dim itemKey As String = $"{itemName}|{barCode}"
                    If Not nodes.ItemMap.ContainsKey(itemKey) Then
                        Dim itemNode As TreeNode = nodes.ItemsRoot.Nodes.Add($"ITEM:{invNo}:{itemKey}", $"الصنف: {itemName}")
                        itemNode.Tag = barCode ' مفيد لاحقاً عند الضغط
                        If barCode <> "" Then itemNode.Nodes.Add($"BAR:{invNo}:{itemKey}", $"الباركود: {barCode}")
                        If itemW <> "" Then itemNode.Nodes.Add($"W:{invNo}:{itemKey}", $"الوزن: {itemW} جم")
                        If itemTotalPrice <> "" Then itemNode.Nodes.Add($"IPRICE:{invNo}:{itemKey}", $"السعر الإجمالي: {itemTotalPrice}")
                        nodes.ItemMap(itemKey) = itemNode
                    End If
                Next
            Finally
                TreeViewInv.EndUpdate()
            End Try
        End If
    End Sub
    Public Sub ViwAllGold()
        GridGold.Rows.Clear()
        Select Case True
            Case RdoSell.Checked = True
                Dim GetSellReporData As DataTable = GetRecordSet("SELECT Castomerid, TOTAL_mony, invoc_date_time, BAY_SARYAL,CastomerNAme, SUM(item_gram) AS item_gram FROM dbo.ViwGoldInvoceDeletReport GROUP BY Castomerid, TOTAL_mony, invoc_date_time, BAY_SARYAL, CastomerNAme")
                If GetSellReporData.Rows.Count > 0 Then
                    For i As Integer = 0 To GetSellReporData.Rows.Count - 1
                        CmbInvRetr.DataSource = GetSellReporData
                        CmbInvRetr.DisplayMember = "BAY_SARYAL"
                        CmbInvRetr.ValueMember = "BAY_SARYAL"
                        CmbInvRetr.DropDownWidth = GetMaxDataSize(GetSellReporData, "BAY_SARYAL", CmbInvRetr)
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        With (GridGold)
                            .Rows.Add()
                            .Rows(i).Cells("colInvId").Value = (GetSellReporData.Rows(i)("BAY_SARYAL").ToString)
                            .Rows(i).Cells("colGoldWeight").Value = (GetSellReporData.Rows(i)("item_gram").ToString)
                            .Rows(i).Cells("colCastomId").Value = (GetSellReporData.Rows(i)("Castomerid").ToString)
                            .Rows(i).Cells("colCastomName").Value = (GetSellReporData.Rows(i)("CastomerNAme").ToString)
                            .Rows(i).Cells("colInvAmon").Value = (GetSellReporData.Rows(i)("TOTAL_mony").ToString)
                            .Rows(i).Cells("colDate").Value = (GetSellReporData.Rows(i)("invoc_date_time").ToString)
                        End With
                    Next
                End If

                TreeViewSelSqlCom = "Select * from ViwGoldInvoceDeletReport"
                TreeViewSellInv()

            Case RdoBuy.Checked = True
                Dim GetPurchaseReporData As DataTable = GetRecordSet("SELECT castomer_id, CastomerNAme, CastomerTE, CastomerNA, SUM(bay_mazan) AS bay_mazan, total_price, date, inv_id, TIME_INV" & vbCrLf &
                                                                     "FROM dbo.ViwDeletGoldPurchaseInvoice" & vbCrLf &
                                                                     "GROUP BY castomer_id, CastomerNAme, CastomerTE, CastomerNA, total_price, date, inv_id, TIME_INV ")
                If GetPurchaseReporData.Rows.Count > 0 Then
                    For i As Integer = 0 To GetPurchaseReporData.Rows.Count - 1
                        CmbInvRetr.DataSource = GetPurchaseReporData
                        CmbInvRetr.DisplayMember = "inv_id"
                        CmbInvRetr.ValueMember = "inv_id"
                        CmbInvRetr.DropDownWidth = GetMaxDataSize(GetPurchaseReporData, "inv_id", CmbInvRetr)
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        With (GridGold)
                            .Rows.Add()
                            .Rows(i).Cells("colInvId").Value = (GetPurchaseReporData.Rows(i)("inv_id").ToString)
                            .Rows(i).Cells("colGoldWeight").Value = (GetPurchaseReporData.Rows(i)("bay_mazan").ToString)
                            .Rows(i).Cells("colCastomId").Value = (GetPurchaseReporData.Rows(i)("castomer_id").ToString)
                            .Rows(i).Cells("colCastomName").Value = (GetPurchaseReporData.Rows(i)("CastomerNAme").ToString)
                            .Rows(i).Cells("colInvAmon").Value = (GetPurchaseReporData.Rows(i)("total_price").ToString)
                            .Rows(i).Cells("colDate").Value = (GetPurchaseReporData.Rows(i)("TIME_INV").ToString)
                        End With
                    Next
                End If
                TreeViewPurchaseSqlCom = "Select * from ViwDeletGoldPurchaseInvoice"
                TreeViewPurchaseInv()
        End Select
        DGV_Style.AutoFitColumns(GridGold)
    End Sub
    Public Sub ViwAllGoldByDate()
        GridGold.Rows.Clear()
        Select Case True
            Case RdoSell.Checked = True
                Dim GetSellReporData As DataTable = GetRecordSet("SELECT Castomerid, TOTAL_mony, invoc_date_time, BAY_SARYAL, CastomerNAme, SUM(item_gram) AS item_gram, date  FROM  dbo.ViwGoldInvoceDeletReport" & vbCrLf &
                                                                "WHERE (date BETWEEN '" & Format(DateFromGold.Value, "yyyy/MM/dd") & "' AND '" & Format(DateToGold.Value, "yyyy/MM/dd") & "')" & vbCrLf &
                                                                "GROUP BY Castomerid, TOTAL_mony, invoc_date_time, BAY_SARYAL, CastomerNAme, date")
                If GetSellReporData.Rows.Count > 0 Then
                    For i As Integer = 0 To GetSellReporData.Rows.Count - 1
                        CmbInvRetr.DataSource = GetSellReporData
                        CmbInvRetr.DisplayMember = "BAY_SARYAL"
                        CmbInvRetr.ValueMember = "BAY_SARYAL"
                        CmbInvRetr.DropDownWidth = GetMaxDataSize(GetSellReporData, "BAY_SARYAL", CmbInvRetr)
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        With (GridGold)
                            .Rows.Add()
                            .Rows(i).Cells("colInvId").Value = (GetSellReporData.Rows(i)("BAY_SARYAL").ToString)
                            .Rows(i).Cells("colGoldWeight").Value = (GetSellReporData.Rows(i)("item_gram").ToString)
                            .Rows(i).Cells("colCastomId").Value = (GetSellReporData.Rows(i)("Castomerid").ToString)
                            .Rows(i).Cells("colCastomName").Value = (GetSellReporData.Rows(i)("CastomerNAme").ToString)
                            .Rows(i).Cells("colInvAmon").Value = (GetSellReporData.Rows(i)("TOTAL_mony").ToString)
                            .Rows(i).Cells("colDate").Value = (GetSellReporData.Rows(i)("invoc_date_time"))
                        End With
                    Next
                End If
                TreeViewSelSqlCom = "Select * from ViwGoldInvoceDeletReport WHERE (date BETWEEN '" & Format(DateFromGold.Value, "yyyy/MM/dd") & "' AND '" & Format(DateToGold.Value, "yyyy/MM/dd") & "')"
                TreeViewSellInv()
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Case RdoBuy.Checked = True
                Dim GetPurchaseReporData As DataTable = GetRecordSet("SELECT castomer_id, CastomerNAme, CastomerTE, CastomerNA, SUM(bay_mazan) AS bay_mazan, total_price, date, inv_id, TIME_INV" & vbCrLf &
                                                                     "FROM  dbo.ViwDeletGoldPurchaseInvoice" & vbCrLf &
                                                                     " WHERE (date BETWEEN '" & Format(DateFromGold.Value, "yyyy/MM/dd") & "' AND '" & Format(DateToGold.Value, "yyyy/MM/dd") & "')" & vbCrLf &
                                                                     "GROUP BY castomer_id, CastomerNAme, CastomerTE, CastomerNA, total_price, date, inv_id, TIME_INV")
                If GetPurchaseReporData.Rows.Count > 0 Then
                    For i As Integer = 0 To GetPurchaseReporData.Rows.Count - 1
                        CmbInvRetr.DataSource = GetPurchaseReporData
                        CmbInvRetr.DisplayMember = "inv_id"
                        CmbInvRetr.ValueMember = "inv_id"
                        CmbInvRetr.DropDownWidth = GetMaxDataSize(GetPurchaseReporData, "inv_id", CmbInvRetr)
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        With (GridGold)
                            .Rows.Add()
                            .Rows(i).Cells("colInvId").Value = (GetPurchaseReporData.Rows(i)("inv_id").ToString)
                            .Rows(i).Cells("colGoldWeight").Value = (GetPurchaseReporData.Rows(i)("bay_mazan").ToString)
                            .Rows(i).Cells("colCastomId").Value = (GetPurchaseReporData.Rows(i)("castomer_id").ToString)
                            .Rows(i).Cells("colCastomName").Value = (GetPurchaseReporData.Rows(i)("CastomerNAme").ToString)
                            .Rows(i).Cells("colInvAmon").Value = (GetPurchaseReporData.Rows(i)("total_price").ToString)
                            .Rows(i).Cells("colDate").Value = (GetPurchaseReporData.Rows(i)("TIME_INV"))
                        End With
                    Next
                End If

                TreeViewPurchaseSqlCom = ("Select * FROM  dbo.ViwDeletGoldPurchaseInvoice WHERE (Date BETWEEN '" & Format(DateFromGold.Value, "yyyy/MM/dd") & "' and '" & Format(DateToGold.Value, "yyyy/MM/dd") & "')")
                TreeViewPurchaseInv()
        End Select
        DGV_Style.AutoFitColumns(GridGold)
    End Sub
    Private Sub BtnViwAllGold_Click(sender As Object, e As EventArgs) Handles BtnViwAllGold.Click
        ViwAllGold()
    End Sub

    Private Sub btnInvRetr_Click(sender As Object, e As EventArgs) Handles btnInvRetr.Click
        Select Case True
            Case RdoSell.Checked = True
                MsgBox(CmbInvRetr.Text.Trim)
                GlCommand.CommandText = "UPDATE [dbo].[BAY] SET [Active] = 1  WHERE [BAY_SARYAL] =" & CmbInvRetr.Text.Trim & " "
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE [dbo].[selInvoceDetels] SET [Active] = 1  WHERE [invoc_time] =" & CmbInvRetr.Text.Trim & " "
                GlCommand.ExecuteNonQuery()
                MsgBox("✔ تم استرجاع الفاتورة المحذوفة بنجاح" & vbCrLf &
               "✔ Deleted invoice has been restored successfully." & vbCrLf & vbCrLf &
               "رقم الفاتورة / Invoice No: " & CmbInvRetr.Text.Trim,
               MsgBoxStyle.Information Or MsgBoxStyle.OkOnly,
               "استرجاع الفاتورة / Invoice Restore Confirmation")
                ViwAllGold()
            Case RdoBuy.Checked = True
                GlCommand.CommandText = "UPDATE [dbo].[bay_goled_mony] SET [INV_Actv] = 1  WHERE [saryal] =" & CmbInvRetr.Text.Trim & " "
                GlCommand.ExecuteNonQuery()
                GlCommand.CommandText = "UPDATE [dbo].[Buy_Gold] SET [INV_Actv] = 1  WHERE [inv_id] =" & CmbInvRetr.Text.Trim & " "
                GlCommand.ExecuteNonQuery()
                MsgBox("✔ تم استرجاع الفاتورة المحذوفة بنجاح" & vbCrLf &
               "✔ Deleted invoice has been restored successfully." & vbCrLf & vbCrLf &
               "رقم الفاتورة / Invoice No: " & CmbInvRetr.Text.Trim,
               MsgBoxStyle.Information Or MsgBoxStyle.OkOnly,
               "استرجاع الفاتورة / Invoice Restore Confirmation")
                ViwAllGold()
        End Select
    End Sub

    Private Sub FrmInvDelet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub FrmInvDelet_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub BtnViwBayDateGold_Click(sender As Object, e As EventArgs) Handles BtnViwBayDateGold.Click
        ViwAllGoldByDate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TreeViewSelSqlCom = "Select * from ViwGoldInvoceDeletReport"
        TreeViewSellInv()
    End Sub
#End Region
End Class