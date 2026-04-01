Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class License_SAP
    Dim MAXVAL As String
    Dim sqlcon As New SqlConnection
    Dim Sqlcmd As New SqlCommand
    Dim D_Reader As SqlDataReader
    Dim D_Table As New DataTable
    Dim D_Adapter As New SqlDataAdapter
    Dim NEW_Q As String
    Private Sub UPDATE_T()
        sqlcon.ConnectionString = OnLineSqlConnection
        sqlcon.Open()
        Sqlcmd.Connection = sqlcon
        Sqlcmd.CommandText = "SELECT * FROM LICENSE_T"
        D_Reader = Sqlcmd.ExecuteReader
        D_Table.Load(D_Reader)
        D_Reader.Close()
        sqlcon.Close()
        grid.DataSource = D_Table
    End Sub
    Public Sub RETERN_DATA_TO_TEXT()
        txtShopName.Clear()
        txtContractNo.Clear()
        txtSerial.Clear()
        txtShopName.SelectedText = D_Table.Rows(0)("LICENSE_SHOP_NAME").ToString
        txtContractNo.SelectedText = D_Table.Rows(0)("status").ToString
        txtSerial.SelectedText = D_Table.Rows(0)("LICENSECode").ToString
        currency_CO.SelectedText = D_Table.Rows(0)("PriceCurrency").ToString
        PRICE_LINK.SelectedText = D_Table.Rows(0)("PriceLinek").ToString
    End Sub
    Private Sub retern_shop_name()
        D_Table.Clear()
        sqlcon.ConnectionString = OnLineSqlConnection
        sqlcon.Open()
        Sqlcmd.Connection = sqlcon
        Sqlcmd.CommandText = "SELECT * FROM LICENSE_T WHERE LICENSE_ID = ( SELECT MAX(LICENSE_ID) FROM LICENSE_T)"
        D_Reader = Sqlcmd.ExecuteReader
        D_Table.Load(D_Reader)
        D_Reader.Close()
        sqlcon.Close()
        grid.DataSource = D_Table

    End Sub

    Private Sub select_by_shop_cod()
        D_Table.Clear()
        sqlcon.ConnectionString = OnLineSqlConnection
        sqlcon.Open()
        Sqlcmd.Connection = sqlcon
        Sqlcmd.CommandText = "SELECT * FROM LICENSE_T WHERE LICENSECode= '" & CpuIdSystemSerialNumber & "'"
        D_Reader = Sqlcmd.ExecuteReader
        D_Table.Load(D_Reader)
        D_Reader.Close()
        sqlcon.Close()
        grid.DataSource = D_Table
    End Sub
    Public Sub COM_BOX_GET_DATA()
        Dim sqlcon_COM_BOX As New SqlConnection
        Dim Sqlcmd_COM_BOX As New SqlCommand
        Dim D_Rea As SqlDataReader
        Dim D_Table_COM_BOX As New DataTable
        Dim D_Adapter_COM_BOX As New SqlDataAdapter
        cmbNameSearch.Items.Clear()
        D_Table_COM_BOX.Clear()
        sqlcon_COM_BOX.ConnectionString = OnLineSqlConnection
        sqlcon_COM_BOX.Open()
        Sqlcmd_COM_BOX.Connection = sqlcon_COM_BOX
        Sqlcmd_COM_BOX.CommandText = "SELECT LICENSE_SHOP_NAME FROM LICENSE_T"
        D_Rea = Sqlcmd_COM_BOX.ExecuteReader
        D_Table_COM_BOX.Load(D_Rea)
        D_Rea.Close()
        sqlcon_COM_BOX.Close()
        For i As Integer = 0 To D_Table_COM_BOX.Rows.Count - 1
            cmbNameSearch.Items.Add(D_Table_COM_BOX.Rows(i)("LICENSE_SHOP_NAME").ToString)
        Next
    End Sub
    Public Sub SELECT_MAX_VAL_MYSQL()
        Dim sqlcon_MAX_VAL As New SqlConnection
        Dim Sqlcmd_MAX_VAL As New SqlCommand
        Dim D_ReaMAX_VAL As SqlDataReader
        Dim D_Table_MAX_VAL As New DataTable
        Dim D_Adapter_MAX_VAL As New SqlDataAdapter
        cmbNameSearch.Items.Clear()
        D_Table_MAX_VAL.Clear()
        sqlcon_MAX_VAL.ConnectionString = OnLineSqlConnection
        sqlcon_MAX_VAL.Open()
        Sqlcmd_MAX_VAL.Connection = sqlcon_MAX_VAL
        Sqlcmd_MAX_VAL.CommandText = "SELECT MAX(LICENSE_ID) FROM LICENSE_T"
        D_ReaMAX_VAL = Sqlcmd_MAX_VAL.ExecuteReader
        D_Table_MAX_VAL.Load(D_ReaMAX_VAL)
        D_ReaMAX_VAL.Close()
        sqlcon_MAX_VAL.Close()
        MAXVAL = D_Table_MAX_VAL.Rows(0)("MAX(LICENSE_ID)").ToString
    End Sub


    Private Function SystemSerialNumber() As String
        Dim wmi As Object = GetObject("WinMgmts:")
        Dim serial_numbers As String = ""
        Dim mother_boards As Object =
            wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board
        If serial_numbers.Length > 0 Then serial_numbers =
            serial_numbers.Substring(2)
        Return serial_numbers
    End Function
    Public Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:{impersonationLevel=impersonate}!\\" & computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("SELECT * FROM Win32_Processor")
        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids =
            cpu_ids.Substring(2)
        Return cpu_ids
    End Function

    Private Sub LICENSE_SAP_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub LICENSE_SAP_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If Settings.SET_INVARCHR129TextBox.Text = "" Then Settings.SET_INVARCHR129TextBox.Text = CpuId()
        txtSearchContract.Text = Settings.SET_INVARCHR154TextBox.Text.Trim
        txtSerialSearch.Text = Settings.SET_INVARCHR129TextBox.Text
        txtSerial.Text = Settings.SET_INVARCHR129TextBox.Text
        select_by_shop_cod()
        COM_BOX_GET_DATA()
    End Sub


    Private Sub btnSearchContractNo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearchContractNo.Click
        select_by_shop_cod()
    End Sub

    Private Sub btnAddShop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddShop.Click
        SELECT_MAX_VAL_MYSQL()
        txtContractNo.Text = MAXVAL + 1
        If txtShopName.Text = "" Then
            msgnotdin()
            Exit Sub
        ElseIf txtContractNo.Text = "" Then
            msgnotdin()
            Exit Sub
        ElseIf txtSerial.Text = "" Then
            msgnotdin()
            Exit Sub
        End If

        sqlcon.ConnectionString = OnLineSqlConnection
        sqlcon.Open()
        NEW_Q = "INSERT INTO LICENSE_T(PriceCurrency,PriceLinek,LICENSE_SHOP_NAME,LICENSE_START_DATAE,LICENSE_END_DATAE,status,LICENSECode) VALUES ( '" & currency_CO.Text.Trim & "','" & PRICE_LINK.Text.Trim & "','" & txtShopName.Text.Trim & "','" & Format(dtStartDate.Value, "yyyy-MM-dd") & "','" & Format(dtEndDate.Value, "yyyy-MM-dd") & "','" & txtContractNo.Text.Trim & "','" & txtSerial.Text.Trim & "')"
        Sqlcmd = New SqlCommand(NEW_Q, sqlcon)
        Sqlcmd.ExecuteNonQuery()
        sqlcon.Close()
        sqlcon.Dispose()
        retern_shop_name()
        '\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        'تحديث رقم العقد في ال SQL
        Dim SqlConLOC As New SqlConnection
        Dim SqlComLOC As New SqlCommand
        Dim SqlDataReLOC As SqlDataReader
        Dim DataTabLOC As New DataTable
        Dim SqlDataAdaLOC As New SqlDataAdapter
        DataTabLOC.Clear()
        SqlConLOC.ConnectionString = My.Settings.DT_restrantConnectionString10
        SqlConLOC.Open()
        SqlComLOC.Connection = SqlConLOC
        'SqlComLOC.CommandText = "UPDATE (Settings.SET_INVARCHR154 SET =" & txtContractNo.Text & " SET_INVARCHR155 SET =" & txtContractNo.Text & ")"
        SqlComLOC.CommandText = "UPDATE Settings Set  SET_INVARCHR154='" & txtContractNo.Text & "' , SET_INVARCHR155='" & txtContractNo.Text & "'"
        SqlDataReLOC = SqlComLOC.ExecuteReader
        DataTabLOC.Load(SqlDataReLOC)
        SqlDataReLOC.Close()
        SqlConLOC.Close()
        Settings.Settings_LOOD_FROM()
        'frmMain.frmMain_Load_SUB()
    End Sub

    Private Sub btnSearchByNo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearchByNo.Click
        sqlcon.ConnectionString = OnLineSqlConnection
        sqlcon.Open()
        Sqlcmd.Connection = sqlcon
        Sqlcmd.CommandText = "SELECT * FROM LICENSE_T WHERE LICENSECode = " & txtSerialSearch.Text & ""
        D_Reader = Sqlcmd.ExecuteReader
        D_Table.Load(D_Reader)
        D_Reader.Close()
        sqlcon.Close()
        grid.DataSource = D_Table
    End Sub

    Private Sub btnUpdateShop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdateShop.Click
        sqlcon.ConnectionString = OnLineSqlConnection
        sqlcon.Open()
        NEW_Q = " UPDATE LICENSE_T SET  PriceLinek='" & PRICE_LINK.Text.Trim & "',PriceCurrency='" & currency_CO.Text.Trim & "',LICENSE_SHOP_NAME='" & txtShopName.Text.Trim & "',LICENSE_START_DATAE='" & Format(dtStartDate.Value, "yyyy-MM-dd") & "',LICENSE_END_DATAE= '" & Format(dtEndDate.Value, "yyyy-MM-dd") & "',status='" & txtContractNo.Text.Trim & "',LICENSECode='" & txtSerial.Text.Trim & "' WHERE LICENSE_ID='" & Settings.SET_INVARCHR154TextBox.Text & "'"
        Sqlcmd = New SqlCommand(NEW_Q, sqlcon)
        D_Reader = Sqlcmd.ExecuteReader
        sqlcon.Close()
        select_by_shop_cod()
        'frmMain.frmMain_Load_SUB()
        'SELECT_MAX_VAL_MYSQL()
    End Sub
    Private Sub btnSearchByName_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearchByName.Click
        Dim sqlcon As New SqlConnection
        Dim Sqlcmd As New SqlCommand
        Dim D_Reader As SqlDataReader
        Dim D_Table As New DataTable
        Dim D_Adapter As New SqlDataAdapter
        D_Table.Clear()
        txtShopName.Clear()
        txtContractNo.Clear()
        txtSerial.Clear()
        txtSearchContract.Clear()
        sqlcon.ConnectionString = OnLineSqlConnection
        sqlcon.Open()
        Sqlcmd.Connection = sqlcon
        Sqlcmd.CommandText = "SELECT * FROM LICENSE_T WHERE LICENSE_SHOP_NAME= '" & cmbNameSearch.Text & "'"
        D_Reader = Sqlcmd.ExecuteReader
        D_Table.Load(D_Reader)
        D_Reader.Close()
        sqlcon.Close()
        grid.DataSource = D_Table
        txtShopName.SelectedText = D_Table.Rows(0)("LICENSE_SHOP_NAME").ToString
        txtContractNo.SelectedText = D_Table.Rows(0)("status").ToString
        txtSerial.SelectedText = D_Table.Rows(0)("LICENSECode").ToString
        dtStartDate.Value = D_Table.Rows(0)("LICENSE_START_DATAE").ToString
        dtEndDate.Value = D_Table.Rows(0)("LICENSE_END_DATAE").ToString
        txtSearchContract.SelectedText = D_Table.Rows(0)("LICENSE_ID").ToString
        currency_CO.SelectedText = D_Table.Rows(0)("PriceCurrency").ToString
        PRICE_LINK.SelectedText = D_Table.Rows(0)("PriceLinek").ToString
    End Sub

    Private Sub grid_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles grid.SelectionChanged
        Try
            If grid.RowCount <= 0 Then Exit Sub
            If grid.SelectedRows.Count <= 0 Then Exit Sub
            txtShopName.Text = grid.SelectedRows(0).Cells("LICENSE_SHOP_NAME").Value
            dtStartDate.Value = grid.SelectedRows(0).Cells("LICENSE_START_DATAE").Value
            dtEndDate.Value = grid.SelectedRows(0).Cells("LICENSE_END_DATAE").Value
            txtContractNo.Text = grid.SelectedRows(0).Cells("status").Value
            txtSerial.Text = grid.SelectedRows(0).Cells("LICENSECode").Value
            currency_CO.Text = grid.SelectedRows(0).Cells("PriceCurrency").Value
            PRICE_LINK.Text = grid.SelectedRows(0).Cells("PriceLinek").Value
        Catch ex As Exception
            If grid.RowCount <= 0 Then Exit Sub
            If grid.SelectedRows.Count <= 0 Then Exit Sub
            txtShopName.Text = grid.SelectedRows(0).Cells("LICENSE_SHOP_NAME").Value
            dtStartDate.Value = grid.SelectedRows(0).Cells("LICENSE_START_DATAE").Value
            dtEndDate.Value = grid.SelectedRows(0).Cells("LICENSE_END_DATAE").Value
            txtContractNo.Text = grid.SelectedRows(0).Cells("status").Value
            txtSerial.Text = grid.SelectedRows(0).Cells("LICENSECode").Value
            currency_CO.Text = ""
            PRICE_LINK.Text = ""
        End Try
    End Sub
    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click
        sqlcon.ConnectionString = OnLineSqlConnection
        sqlcon.Open()
        Sqlcmd.Connection = sqlcon
        Sqlcmd.CommandText = "SELECT * FROM LICENSE_T "
        D_Reader = Sqlcmd.ExecuteReader
        D_Table.Load(D_Reader)
        D_Reader.Close()
        sqlcon.Close()
        grid.DataSource = D_Table
    End Sub
    Private Sub btnViewCurrent_Click(sender As Object, e As EventArgs) Handles btnViewCurrent.Click
        select_by_shop_cod()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PRICE_LINK.Text = "https://saponlin.net/kw/public/api/feed"
    End Sub
End Class