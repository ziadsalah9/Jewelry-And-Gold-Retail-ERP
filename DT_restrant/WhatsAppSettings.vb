Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.IO
Imports System.Text
Imports System.Web
Imports System.Threading.Tasks
Imports System.Net.HttpWebResponse
Imports System.Net.HttpWebRequest
Imports System.Net
Imports PACICardLibrary
Public Class WhatsAppSettings
    Dim OldFilePath As String
    Dim LastBarCode As String
    Dim Device_uuid, App_key
    Private Sub WhatsAppSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'GredDsin(dtGreid)
        'GredDsinw(Grid)
        Me.CheckForIllegalCrossThreadCalls = False
        ControlsAsColor(ColorSelect:=Me)
        frmMain.Timer1.Stop()
        language_start(Name)
        Call GetSQLWhatsappData()
        Call ApiLinek()
        Call login()
        Call notify()
        BackWorkGetQr.RunWorkerAsync()
    End Sub
    Public Sub GredDsinw(ByVal GredName As Object)
        GredName.DefaultCellStyle.SelectionBackColor = Color.BlueViolet
        GredName.DefaultCellStyle.SelectionForeColor = Color.Gold
        GredName.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Green
        GredName.RowsDefaultCellStyle.BackColor = Color.White
        GredName.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(192, 255, 255)
        GredName.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        GredName.RowHeadersVisible = False
        GredName.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GredName.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        GredName.BackgroundColor = Color.DarkSlateGray
        GredName.BorderStyle = BorderStyle.Fixed3D
        GredName.AllowUserToAddRows = False
        GredName.AllowUserToDeleteRows = False
        GredName.AllowUserToOrderColumns = True
        GredName.ReadOnly = False
        GredName.MultiSelect = False
        GredName.AllowUserToResizeColumns = False
        For i As Integer = 0 To GredName.Columns.Count - 1
            GredName.Columns(i).HeaderCell.Style.Font = New Font("Calibri", 12, FontStyle.Bold)
        Next
    End Sub
    Sub login()
        On Error Resume Next
        Dim login_state = api_login(AutKey)
        If login_state = "" Or AutKey = "" Then
            MsgBox("NOT ALLOWED")
        Else
            Dim jsonResponse As JObject = JObject.Parse(login_state)
            If jsonResponse("status").ToString() = "1" Then
                Dim device_array As JArray = JArray.Parse(api_get_devices(AutKey))
                For Each item As JObject In device_array
                    Device_uuid = DirectCast(item("Device id"), JValue).Value.ToString()
                    App_key = DirectCast(item("App key"), JValue).Value.ToString()
                Next
            Else
                MsgBox("NOT ALLOWED")
            End If
        End If
    End Sub
    Private Sub btnQrCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call get_device()
    End Sub
    Public Sub get_device()
        Dim response = api_getqr(AutKey, Device_uuid)
        If response.ToString = "1" Then
            PicQrCode.Image = My.Resources.WhatsApp
            Timer1.Stop()
            Exit Sub
        ElseIf response.ToString = "0" Then
            Timer1.Start()
        Else
            Dim x As Image = response
            PicQrCode.Image = x
            Timer1.Start()
        End If
    End Sub
    Private Sub WhatsAppSettings_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Timer1.Start()
        Dispose()
    End Sub
    Private Sub WhatsAppSettings_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub
    Private Sub BtnLoodFromDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoodFromDt.Click
        dtGreid.Rows.Clear()
        Dim GetCastonDetels As DataTable = GetRecordSet("SELECT  CastomerNAme, RIGHT([CastomerTE],8)AS CastomerTE , CastomerCAIVELid, CastomerADr FROM CastomerDETELS WHERE  CastomerTE  NOT LIKE  N'%لايوجد رقم هاتف%'   AND CastomerNAme NOT LIKE 0  AND CastomerTE  NOT LIKE 0")
        If GetCastonDetels.Rows.Count > 0 Then
            For i As Integer = 0 To GetCastonDetels.Rows.Count - 1
                With (dtGreid)
                    .Rows.Add()
                    .Rows(i).Cells("colID").Value = i + 1
                    .Rows(i).Cells("colCastomName").Value = (GetCastonDetels.Rows(i)("CastomerNAme").ToString)
                    .Rows(i).Cells("colCastomNo").Value = ("965" & GetCastonDetels.Rows(i)("CastomerTE").ToString)
                    .Rows(i).Cells("colCastomCivilID").Value = (GetCastonDetels.Rows(i)("CastomerCAIVELid").ToString)
                    .Rows(i).Cells("colCastomAdr").Value = (GetCastonDetels.Rows(i)("CastomerADr").ToString)
                End With
            Next
        End If

    End Sub
    Private Sub TPAddAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ControlsAsColor(ColorSelect:=Me)
        GredDsin(GredName:=dtGreid)
        CheckUserPermissions(UserID)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        language_start(Name)
        CivilIDForm = New CivilID
        CivilIDForm.gbCustomerData.BackColor = Color.FromArgb(64, 64, 64)
        CivilIDForm.Bounds = New Rectangle(2, 40, 995, 255)
        Controls.Add(CivilIDForm)
        CardServiceStart()
        paci = New PACMAN
    End Sub
    Private Sub btnSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSent.Click
        'Timer2.Start()
        If txtFile.Text = "" Then
            api_send(txtphonNom.Text, txtMsges.Text, AutKey, App_key)
        Else
            send_apifile(txtphonNom.Text, txtMsges.Text, AutKey, App_key, txtFile.Text)
        End If
    End Sub
    Private Sub btnBros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBros.Click
        OpenFileDialog1.InitialDirectory = "C:\" ' Set initial directory if needed
        OpenFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf" ' Filter to specific file types
        OpenFileDialog1.FilterIndex = 1 ' Index of the filter to be selected by default
        ' Show the file dialog and check if the user selected a file
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedFilePath As String = OpenFileDialog1.FileName
            txtFile.Text = selectedFilePath
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'If Date.Now.Second Mod 100 = 0 Then
        '    'MsgBox("54")
        '    If txtFile.Text = "" Then
        '        api_send(txtphonNom.Text, txtMsges.Text, AutKey, App_key)
        '    Else
        '        send_apifile(txtphonNom.Text, txtMsges.Text, AutKey, App_key, txtFile.Text)
        '    End If
        'End If
        If Date.Now.Second Mod 30 = 0 Then
            CASTO()
        End If
        




    End Sub
    Private Sub BtnSignOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSignOut.Click
        'If IsDBNull(PicQrCode.Image) Then
        '    Call get_device()
        '    Timer1.Start()
        'Else
        SignOut(AutKey, Device_uuid)
        Call get_device()
        'Timer1.Start()
        'End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'get_device()
        'Dim BW As BackgroundWorker = New BackgroundWorker
        'AddHandler BW.DoWork, AddressOf ThreadState
        'BackWorkGetQr.RunWorkerAsync()
    End Sub
    Private Sub BackWorkGetQr_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackWorkGetQr.DoWork
        For i = 0 To 1000
            'Label4.Text = i
            Call get_device()
            'System.Threading.Thread.Sleep(200)
            'Call get_device()
            'Label4.Refresh()
        Next
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        ' Excel functionality removed
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

  
    Private Sub btnBrowse_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        ' Excel functionality removed
    End Sub

    Private Sub gbLoad_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbLoad.Enter

    End Sub

    Private Sub dtGreid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGreid.CellClick
        Try
            If dtGreid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
                If dtGreid.Rows.Count > 1 Then
                    If MsgBox("هل تريد حذف رقم العميل" & dtGreid.Rows(e.RowIndex).Cells("colCastomName").Value & "؟" & vbCrLf & "Do you Want To Delete The Customer Number " & dtGreid.Rows(e.RowIndex).Cells("colCastomName").Value, vbYesNo) = vbYes Then
                        dtGreid.Rows.RemoveAt(dtGreid.CurrentRow.Index)
                        Beep()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            RecordRrrors(ex.ToString)
        End Try
    End Sub

    Private Sub dtGreid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtGreid.CellContentClick

    End Sub

    Private Sub dtGreid_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dtGreid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If dtGreid.Columns(e.ColumnIndex).Name = "colDelete" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    

    Private Sub BtnAddMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMsg.Click
        Try
            With (Grid)
                .Rows.Add()
                .Rows(.Rows.Count - 1).Cells("colMsg").Value = txtMsg.Text.Trim
                .Rows(.Rows.Count - 1).Cells("colFillPath").Value = txtFillPath.Text.Trim
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            RecordRrrors(ex.ToString)
        End Try
        Try
            GlCommand.CommandText = "INSERT INTO [TPWhatsAppMessages]" & vbCrLf &
                                               "([TextMessages]" & vbCrLf &
                                               ",[FillPath]" & vbCrLf &
                                               ",[DateCreated])" & vbCrLf &
                                               " VALUES" & vbCrLf &
                                               "(@TextMessages" & vbCrLf &
                                               ",@FillPath" & vbCrLf &
                                               ",@DateCreated)"
            With GlCommand.Parameters
                .Clear()
                .AddWithValue("@TextMessages", txtMsg.Text.Trim)
                .AddWithValue("@FillPath", txtFillPath.Text.Trim)
                .AddWithValue("@DateCreated", DateToSave(Date.Now))
            End With
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            RecordRrrors(ex.ToString)
        End Try
    End Sub

    Private Sub Grid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellClick
        Try
            If Grid.Columns(e.ColumnIndex).Name = "colDell" AndAlso e.RowIndex >= 0 Then
                If Grid.Rows.Count = 1 Then
                    If MsgBox("هل تريد حزف الرساله" & Grid.Rows(e.RowIndex).Cells("colMsg").Value, vbYesNo) = vbYes Then
                        Grid.Rows.RemoveAt(Grid.CurrentRow.Index)
                        Beep()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            RecordRrrors(ex.ToString)
        End Try
    End Sub

    Private Sub Grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grid.CellContentClick

    End Sub

    Private Sub Grid_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles Grid.CellPainting
        If e.ColumnIndex < 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub
        If Grid.Columns(e.ColumnIndex).Name = "colDell" AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            e.Graphics.DrawImage(My.Resources.Delete, CInt((e.CellBounds.Width / 2) - (My.Resources.Delete.Width / 2)) + e.CellBounds.X, CInt((e.CellBounds.Height / 2) - (My.Resources.Delete.Height / 2)) + e.CellBounds.Y)
            e.Handled = True
        End If
    End Sub

    Private Sub lblFillPath_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblFillPath.LinkClicked
        OldFilePath = txtFillPath.Text
        Dim OFD As New OpenFileDialog
        With OFD
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                txtFillPath.Text = .FileName
            End If
        End With
    End Sub
    Private Sub CASTO()
        For i = 0 To dtGreid.Rows.Count - 1 And Grid.Rows.Count - 1 Step 1

            'If IsDBNull(Grid.Rows(0).Cells("colFillPath").Value) Or (Grid.Rows(0).Cells("colFillPath").Value) = "" Then
            '    api_send(dtGreid.Rows(i).Cells("colCastomNo").Value, Grid.Rows(0).Cells("colMsg").Value, AutKey, App_key)
            'Else
            send_apifile(dtGreid.Rows(i).Cells("colCastomNo").Value, (Grid.Rows(i).Cells("colMsg").Value & dtGreid.Rows(i).Cells("colCastomNo").Value), AutKey, App_key, Grid.Rows(i).Cells("colFillPath").Value)
            'End If
        Next
    End Sub
   
    Private Sub MSG()
     
        For i = 0 To Grid.Rows.Count - 1
            MsgBox(Grid.Rows(0).Cells("colMsg").Value & Grid.Rows(0).Cells("colFillPath").Value)
        Next
        'Do
        '    MsgBox(Grid.Rows(0).Cells("colMsg").Value & Grid.Rows(0).Cells("colFillPath").Value)
        'Loop
    End Sub



    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        'Timer2.Start()
        For i = 0 To dtGreid.Rows.Count - 1 And Grid.Rows.Count - 1
            MsgBox(Grid.Rows(i).Cells("colMsg").Value & Grid.Rows(i).Cells("colFillPath").Value)
            'For x = 0 To dtGreid.Rows.Count - 1
            Dim UpdateRows As DataGridViewRow = dtGreid.Rows(i)
            UpdateRows.Cells("colMsgText").Value = Grid.Rows(i).Cells("colMsg").Value
            'Next

        Next
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dt As DataTable = GetRecordSet(" SELECT * FROM  TPWhatsAppMessages")
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                With (Grid)
                    .Rows.Add()
                    .Rows(i).Cells("colMsg").Value = (dt.Rows(i)("TextMessages").ToString)
                    .Rows(i).Cells("colFillPath").Value = (dt.Rows(i)("FillPath").ToString)
                End With
            Next
        End If
    End Sub
End Class