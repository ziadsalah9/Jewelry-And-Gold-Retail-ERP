Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Text

Public Class Settings

    Public Sub Settings_LOOD_FROM()
        frmMain.Timer1.Stop()
        Panel1.Enabled = False
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        Try
            GlCommand.CommandText = "IF COL_LENGTH('Settings', 'DefaultBarcode') IS NULL " & vbCrLf &
                                                    "BEGIN " & vbCrLf &
                                                    "ALTER TABLE [Settings] ADD [DefaultBarcode] nvarchar (255) NULL " & vbCrLf &
                                                    "END"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Try
            Dim DT As DataTable = GetRecordSet("SELECT * FROM  [Settings]")
            If DT.Rows.Count > 0 Then
                TxtBoxDefaultBarcode.SelectedText = DT.Rows(0)("DefaultBarcode").ToString
                txt1.Text = DT.Rows(0)("SET5").ToString
                txt2.Text = DT.Rows(0)("SET6").ToString
                txt3.Text = DT.Rows(0)("SET7").ToString
                txt4.Text = DT.Rows(0)("SET8").ToString
                txtActiv.Text = DT.Rows(0)("SET9").ToString
            End If
        Catch ex As Exception
        End Try

        Dim CurrencyTb As DataTable = GetRecordSet("SELECT * FROM CurrencyType")
        If CurrencyTb.Rows.Count >= 0 Then
            txtCountryAR.Text = CurrencyTb.Rows(0)("CurrencyCountry").ToString
            TxtCurrencyMinAR.Text = CurrencyTb.Rows(0)("CurrencyTypeMin").ToString
            TxtCurrencyMin2AR.Text = CurrencyTb.Rows(0)("CurrencyType").ToString
            txtCountryEN.Text = CurrencyTb.Rows(1)("CurrencyCountry").ToString
            TxtCurrencyMinEN.Text = CurrencyTb.Rows(1)("CurrencyTypeMin").ToString
            TxtCurrencyMin2EN.Text = CurrencyTb.Rows(1)("CurrencyType").ToString
        End If

    End Sub
    Private Sub Settings_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub


    Private Sub Settings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Settings_LOOD_FROM()
    End Sub

    Public Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        'txtBarCodeNote
        Try
            GlCommand.CommandText = "UPDATE [Settings] SET BarCodeNote= N'" & txtBarCodeNote.Text.Trim & "'"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception

        End Try
        Try
            GlCommand.CommandText = "UPDATE [Settings] SET DefaultBarcode= N'" & TxtBoxDefaultBarcode.Text.Trim & "'"
            GlCommand.ExecuteNonQuery()
        Catch ex As Exception

        End Try

        Try
            ValidateChildren()
            SettingsBindingSource.EndEdit()
            SettingsTableAdapter.Update(DT_restrantDataSet.Settings)

            MsgBox("تم الحفظ")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim OFD As New OpenFileDialog
        OFD.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                PIC1PictureBox.Image = Image.FromFile(.FileName)
            Else
                Return
            End If
        End With
        PIC1PictureBox.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub PIC1PictureBox_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles PIC1PictureBox.DoubleClick
        PIC1PictureBox.Image = Nothing
    End Sub

    Private Sub btnAccessories_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAccessoriesSell.Click
        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = Application.StartupPath & "\Report"
        OFD.FileName = "rptAccessories_Invoice*"
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                SET_INVARCHR150TextBox.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub btnInvoice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInvoice.Click
        Dim FBD As New FolderBrowserDialog
        With FBD
            If FBD.ShowDialog = Windows.Forms.DialogResult.OK Then
                SET_INVARCHR148TextBox.Text = FBD.SelectedPath
            Else
                Return
            End If
        End With
    End Sub

    Public Sub btnDefaults_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDefaults.Click
        If MsgBox("هل تريد استعادة الافتراضيات؟", vbYesNo) = vbYes Then
            SET_INVARCHR142TextBox.Text = "1" 'تحديث تلقائي للأسعار
            SET_INVARCHR143TextBox.Text = "1" 'تفعيل المدنية
            If SET_INVARCHR19TextBox.Text = "" Then 'إخفاء التكلفة للألماس
                SET_INVARCHR19TextBox.Text = "0"
            End If
            SetDefaultDiamond()
            SetDefaultGold()
            SetDefaultAccessories()
        End If
    End Sub
    Private Sub SetDefaultDiamond()
        tc.SelectedTab = tpDiamond
        SET_INVARCHR115TextBox.Text = "اسم"
        SET_INVARCHR116TextBox.Text = "نقاوة"
        SET_INVARCHR117TextBox.Text = "لون"
        SET_INVARCHR119TextBox.Text = "قص"
        SET_INVARCHR120TextBox.Text = "سعر"
        SET_INVARCHR121TextBox.Text = "قيراط"
        SET_INVARCHR122TextBox.Text = "ذهب"
        SET_INVARCHR123TextBox.Text = "عيار"
        SET_INVARCHR124TextBox.Text = "SAP"
        SET_INVARCHR125TextBox.Text = "GOLD SAP"
        SET_INVARCHR126TextBox.Text = "92296701"
        SET_INVARCHR127TextBox.Text = "92291380"
        SET_INVARCHR113TextBox.Text = "رقم"
        SET_INVARCHR114TextBox.Text = "6"
        SET_INVARCHR131TextBox.Text = "R"
        SET_INVARCHR132TextBox.Text = "6"
        SET_INVARCHR133TextBox.Text = "R"
        SET_INVARCHR134TextBox.Text = "10"
        SET_INVARCHR135TextBox.Text = "R"
        SET_INVARCHR136TextBox.Text = "6"
        SET_INVARCHR137TextBox.Text = "R"
        SET_INVARCHR110TextBox.Text = "6"
        SET_INVARCHR111TextBox.Text = "R"
        SET_INVARCHR152TextBox.Text = "0"
        If SET_INVARCHR141TextBox.Text = "" Then SET_INVARCHR141TextBox.Text = "2"
        If SET_INVARCHR146TextBox.Text = "" Then SET_INVARCHR146TextBox.Text = Application.StartupPath & "\Report\rptDiamondSellPayDetails.rdlc"
        If SET_INVARCHR157TextBox.Text = "" Then SET_INVARCHR157TextBox.Text = Application.StartupPath & "\Report\rptDiamondBuyPayDetails.rdlc"
        If My.Computer.Keyboard.CtrlKeyDown Then
            SET_INVARCHR146TextBox.Text = Application.StartupPath & "\Report\rptDiamondSellPayDetails.rdlc"
            SET_INVARCHR157TextBox.Text = Application.StartupPath & "\Report\rptDiamondBuyPayDetails.rdlc"
        End If
    End Sub
    Private Sub SetDefaultGold()
        tc.SelectedTab = tpGold
        SET_INVARCHR128TextBox.Text = ""
        SET_INVARCHR1TextBox.Text = ""
        SET_INVARCHR11TextBox.Text = ":وزن"
        SET_INVARCHR12TextBox.Text = ":مصنعية"
        SET_INVARCHR13TextBox.Text = ":سعر"
        SET_INVARCHR14TextBox.Text = ":عيار"
        SET_INVARCHR15TextBox.Text = "SAP"
        SET_INVARCHR16TextBox.Text = ""
        SET_INVARCHR17TextBox.Text = "GOLD SAP"
        SET_INVARCHR151TextBox.Text = "0"
        If SET_INVARCHR147TextBox.Text = "test" Then SET_INVARCHR147TextBox.Text = ""
        If SET_INVARCHR140TextBox.Text = "" Then SET_INVARCHR140TextBox.Text = "2"
        If SET_INVARCHR156TextBox.Text = "" Then SET_INVARCHR156TextBox.Text = Application.StartupPath & "\Report\rptGoldSellPay.rdlc"
        If SET_INVARCHR158TextBox.Text = "" Then SET_INVARCHR158TextBox.Text = Application.StartupPath & "\Report\rptGoldBuyPay.rdlc"
        If My.Computer.Keyboard.CtrlKeyDown Then
            SET_INVARCHR156TextBox.Text = Application.StartupPath & "\Report\rptGoldSellPay.rdlc"
            SET_INVARCHR158TextBox.Text = Application.StartupPath & "\Report\rptGoldBuyPay.rdlc"
        End If
    End Sub
    Private Sub SetDefaultAccessories()
        tc.SelectedTab = tpAccessories
        SET_INVARCHR148TextBox.Text = My.Computer.FileSystem.SpecialDirectories.Desktop
        SET_INVARCHR149TextBox.Text = "A"
        If SET_INVARCHR150TextBox.Text = "" Then SET_INVARCHR150TextBox.Text = Application.StartupPath & "\Report\rptAccessories_Invoice_A4.rdlc"
        If SET_INVARCHR153TextBox.Text = "" Then SET_INVARCHR153TextBox.Text = Application.StartupPath & "\Report\rptAccessories_BuyPay_A4.rdlc"
        If My.Computer.Keyboard.CtrlKeyDown Then
            SET_INVARCHR150TextBox.Text = Application.StartupPath & "\Report\rptAccessories_Invoice_A4.rdlc"
            SET_INVARCHR153TextBox.Text = Application.StartupPath & "\Report\rptAccessories_BuyPay_A4.rdlc"
        End If

        SET_INVARCHR144TextBox.Text = "1"
        If SET_INVARCHR138TextBox.Text = "" Then SET_INVARCHR138TextBox.Text = "2"
        If SET_INVARCHR139TextBox.Text = "" Then SET_INVARCHR139TextBox.Text = "2"
        If SET_INVARCHR162TextBox.Text = "" Then SET_INVARCHR162TextBox.Text = "0"
        If SET_INVARCHR163TextBox.Text = "" Then SET_INVARCHR163TextBox.Text = "0"
    End Sub

    Private Sub lblDiamond_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lblDiamond.DoubleClick
        If MsgBox("هل تريد استعادة افتراضيات الألماس؟", vbYesNo) = vbYes Then
            SetDefaultDiamond()
        End If
    End Sub

    Private Sub lblGold_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lblGold.DoubleClick
        If MsgBox("هل تريد استعادة افتراضيات الذهب؟", vbYesNo) = vbYes Then
            SetDefaultGold()
        End If
    End Sub

    Private Sub btnAccessoriesBuy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAccessoriesBuy.Click
        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = Application.StartupPath & "\Report"
        OFD.FileName = "rptAccessories_BuyPay*"
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        OFD.RestoreDirectory = True
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                SET_INVARCHR153TextBox.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub btnGoldUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGoldUpdate.Click
        'GlCommand.Dispose()
        ''GlDataAdapter.Dispose(GlDataset.Clear)
        'GlDataset.Clear()
        'GlDataset.Clone()
        'GlCommand.ExecuteNonQuery()
        'Try
        GlCommand.CommandText = "UPDATE [BAY] SET [Active] = '1' WHERE [Active] IS NULL"
        GlCommand.ExecuteNonQuery()
        GlCommand.CommandText = "UPDATE [selInvoceDetels] SET [Active] = '1' WHERE [Active] IS NULL"
        GlCommand.ExecuteNonQuery()
        GlCommand.CommandText = "UPDATE [FO_min] SET [BarCode] = [ID] WHERE [BarCode] IS NULL"
        GlCommand.ExecuteNonQuery()
        GlCommand.CommandText = "UPDATE [FO_min] SET [FO_GramPrice] = (SELECT [COMP_NAME_SHORT] FROM [COMPANY_BAY_DETELS] WHERE [COMP_NAME] = [FO_min].[FO_GramPrice])"
        GlCommand.ExecuteNonQuery()
        GlCommand.CommandText = "UPDATE BAY SET NOTES = (SELECT TOP 1 [nots] FROM [SelinvoceDetels] WHERE [invoc_time] = [BAY].[BAY_Saryal] AND [nots] IS NOT NULL ORDER BY [SelinvoceDetels].[ID] DESC) WHERE [Notes] IS NULL"
        GlCommand.ExecuteNonQuery()
        GlCommand.CommandText = "UPDATE [BAY] SET [PayMethod] = '0' WHERE [PayMethod] IS NULL"
        GlCommand.ExecuteNonQuery()

       

    End Sub

    Private Sub btnCashier_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCashier.Click

        Try
            GlCommand.CommandText = "UPDATE [cacher] SET [Active] = '1' WHERE [Active] IS NULL"
            GlCommand.ExecuteNonQuery()
            Beep()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLicense_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLicense.Click
        License_SAP.ShowDialog()
    End Sub

    Private Sub btnGoldInvoice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGoldInvoice.Click
        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = Application.StartupPath & "\Report"
        OFD.FileName = "rptGoldSellPay*"
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        OFD.RestoreDirectory = True
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                SET_INVARCHR156TextBox.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub

    Private Sub btnDiamondInvoice_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDiamondInvoice.Click
        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = Application.StartupPath & "\Report"
        OFD.FileName = "rptDiamondSellPayDetails*"
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        OFD.RestoreDirectory = True
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                SET_INVARCHR146TextBox.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub
    Private Sub btnDiamondBuy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDiamondBuy.Click
        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = Application.StartupPath & "\Report"
        OFD.FileName = "rptDiamondBuyPayDetails*"
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        OFD.RestoreDirectory = True
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                SET_INVARCHR157TextBox.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub
    Private Sub Label17_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles Label17.DoubleClick
        SET_INVARCHR129TextBox.Text = License_SAP.CpuId()
    End Sub
    Private Sub btnDiamondUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDiamondUpdate.Click
        Try
            GlCommand.CommandText = "UPDATE [DIMON_detels] SET [Item_Actv] = '1' WHERE [Item_Actv] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [DIMON_detels] SET [test_119] = [DIMOND_ID] WHERE [test_119] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [dimon_invce] SET [test_119] = [dimo_id] WHERE [test_119] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [dimon_invce] SET [test_117] = [test_17] WHERE [test_117] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [dimon_invce] SET [test_118] = [test_110] WHERE [test_118] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [dimon_invce] SET [SoldItem] = [DIMO_Type] WHERE [SoldItem] IS NULL"
            GlCommand.ExecuteNonQuery()
            Beep()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAccessoriesUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAccessoriesUpdate.Click
        Try
            GlCommand.CommandText = "UPDATE [Accessories_BAY] SET [Accessories_Active] = '1' WHERE [Accessories_Active] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Accessories_INV] SET [Accessories_Active] = '1' WHERE [Accessories_Active] IS NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "UPDATE [Accessories_Buy] SET [BarCode] = (SELECT [AccessoriesID] FROM [Accessories_Item] WHERE [Accessories_Item].[Accessories_nom] = [Accessories_Buy].[Accessories_nom])"
            GlCommand.ExecuteNonQuery()

            Beep()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDiamondWeight00_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDiamondWeight00.Click
        Try
            GlCommand.CommandText = "ALTER TABLE [DIMON_detels] ALTER COLUMN [DIMO_mezan] decimal(18,2) NOT NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [DIMON_detels] ALTER COLUMN [GOLD_mezan] decimal(18,2) NOT NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [dimon_invce] ALTER COLUMN [DIMO_mezan] decimal(18,2) NOT NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [dimon_invce] ALTER COLUMN [GOLD_mezan] decimal(18,2) NOT NULL"
            GlCommand.ExecuteNonQuery()
            Beep()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnDiamondWeight000_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDiamondWeight000.Click
        Try
            GlCommand.CommandText = "ALTER TABLE [DIMON_detels] ALTER COLUMN [DIMO_mezan] decimal(18,3) NOT NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [DIMON_detels] ALTER COLUMN [GOLD_mezan] decimal(18,3) NOT NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [dimon_invce] ALTER COLUMN [DIMO_mezan] decimal(18,3) NOT NULL"
            GlCommand.ExecuteNonQuery()
            GlCommand.CommandText = "ALTER TABLE [dimon_invce] ALTER COLUMN [GOLD_mezan] decimal(18,3) NOT NULL"
            GlCommand.ExecuteNonQuery()
            Beep()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnPrivilages_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrivilages.Click
        Try
            GlCommand.CommandText = "UPDATE [user] SET [chkSell] = '1' ,[chkBarCode] = '1' ,[chkModify] = '1' ,[chkGramPrice] = '1' ,[chkSalary] = '1' ,[chkWholeSaleBuy] = '1' ,[chkUsers] = '1' ,[chkCashier] = '1' ,[chkWholesale] = '1' ,[chkReports] = '1' ,[chkExpenses] = '1' ,[chkStock] = '1' ,[chkItem] = '1'   "
            GlCommand.ExecuteNonQuery()
            Beep()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReportTXTModify.Click
        frmReportTXTModify.ShowDialog()
    End Sub

    Private Sub btnSQL_Command_Click(ByVal sender As Object, ByVal e As EventArgs)
        'SQL_COM.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        Report_Path.ShowDialog()
    End Sub
    Private Sub TextBox_MouseHover(ByVal sender As Object, ByVal e As EventArgs) Handles SET_INVARCHR146TextBox.MouseHover, SET_INVARCHR157TextBox.MouseHover, SET_INVARCHR156TextBox.MouseHover, SET_INVARCHR148TextBox.MouseHover, SET_INVARCHR150TextBox.MouseHover, SET_INVARCHR153TextBox.MouseHover
        ToolTip1.SetToolTip(sender, sender.Text)
    End Sub

    Private Sub btnGoldBuy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGoldBuy.Click
        Dim OFD As New OpenFileDialog
        OFD.InitialDirectory = Application.StartupPath & "\Report"
        OFD.FileName = "rptGoldBuyPay*"
        OFD.Filter = "Reports (*.RDLC) | *.RDLC; *.rdlc | All Files (*.*) | *.*"
        OFD.RestoreDirectory = True
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                SET_INVARCHR158TextBox.Text = OFD.FileName
            Else
                Return
            End If
        End With
    End Sub
    

    Private Sub btnSQLCreateAlter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSQLCreateAlter.Click
        UpdateDatabase()
        UpdateInsertDeletDate()
    End Sub
    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'UplodData()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DeleteUpdateSqlCommend(SqlComm:="UPDATE [Settings] SET [SET5] = '" & txt1.Text.Trim & "',[SET6] = '" & txt2.Text.Trim & "',[SET7] = '" & txt3.Text.Trim & "',[SET8]  = '" & txt4.Text.Trim & "',[SET9]  ='" & txtActiv.Text.Trim & "'")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend(SqlComm:="UPDATE [CurrencyType]SET [CurrencyCountry] =N'" & txtCountryAR.Text.Trim & "',[CurrencyTypeMin] =N'" & TxtCurrencyMinAR.Text.Trim & "',[CurrencyType] =N'" & TxtCurrencyMin2AR.Text.Trim & "'  WHERE CurrencyID=1")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend(SqlComm:="UPDATE [CurrencyType]SET [CurrencyCountry] =N'" & txtCountryEN.Text.Trim & "',[CurrencyTypeMin] =N'" & TxtCurrencyMinEN.Text.Trim & "',[CurrencyType] =N'" & TxtCurrencyMin2EN.Text.Trim & "'  WHERE CurrencyID=2")
        LocSqlGlCom.ExecuteReader()
        MsgBox("تم تحديث بيانات العمله والدوله بنجاح" & vbCrLf & "Currency and country data updated successfully.", MsgBoxStyle.Information, AppTitle)
    End Sub

  
    Private Sub BtnDimDEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDimDEL.Click
        Try
        DeleteUpdateSqlCommend("DELETE FROM [dimon_bay]")
        LocSqlGlCom.ExecuteReader()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        DeleteUpdateSqlCommend("DELETE FROM [dimon_invce]")
        LocSqlGlCom.ExecuteReader()

        ResetIDSeed(TableName:="dimon_bay", FieldName:="BAY_ID")
        ResetIDSeed(TableName:="dimon_invce", FieldName:="dim_inv_id")
            MsgBox("تم الحزف")
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub BtnDimBayDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDimBayDel.Click
        Try
        DeleteUpdateSqlCommend("DELETE FROM [Buy_Diamond]")
        LocSqlGlCom.ExecuteReader()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        DeleteUpdateSqlCommend("DELETE FROM [Bay_Diamond_mony]")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("DELETE FROM [Bay_Diamond_id]")
        LocSqlGlCom.ExecuteReader()
        ResetIDSeed(TableName:="Bay_Diamond_mony", FieldName:="bay_id")
        ResetIDSeed(TableName:="Buy_Diamond", FieldName:="B_Diamond_id")
            ResetIDSeed(TableName:="Bay_Diamond_id", FieldName:="Bay_Diamond_id")
            MsgBox("تم حزف مشتريات الالماس")
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub BtnDimItemDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDimItemDel.Click
        Try
            DeleteUpdateSqlCommend("DELETE FROM [DIMON_detels]")
            LocSqlGlCom.ExecuteReader()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ResetIDSeed(TableName:="DIMON_detels", FieldName:="DIMOND_ID", StartFrom:=100)
            MsgBox("تم حزف اصناف الالماس")
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub BtnGoldDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGoldDel.Click
        Try
            DeleteUpdateSqlCommend("DELETE FROM [BAY]")
            LocSqlGlCom.ExecuteReader()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            DeleteUpdateSqlCommend("DELETE FROM [selInvoceDetels]")
            LocSqlGlCom.ExecuteReader()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ResetIDSeed(TableName:="BAY", FieldName:="BAY_ID")
            ResetIDSeed(TableName:="selInvoceDetels", FieldName:="ID")
            MsgBox("تم حزف فواتير بيع الذهب ")
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub BtnBayGoldDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBayGoldDel.Click
        Try
            DeleteUpdateSqlCommend("DELETE FROM [bay_goled_mony]")
            LocSqlGlCom.ExecuteReader()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            DeleteUpdateSqlCommend("DELETE FROM [Buy_Gold]")
            LocSqlGlCom.ExecuteReader()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ResetIDSeed(TableName:="bay_goled_mony", FieldName:="bay_id")
            ResetIDSeed(TableName:="Buy_Gold", FieldName:="B_gold_id")
            MsgBox("تم حزف فواتير شراء الذهب ")
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub BtnGoldItemDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGoldItemDel.Click
        Try
            DeleteUpdateSqlCommend("DELETE FROM [FO_min]")
            LocSqlGlCom.ExecuteReader()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ResetIDSeed(TableName:="FO_min", FieldName:="ID", StartFrom:=100)
            MsgBox("تم حزف فواتير شراء الذهب ")
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "0113211587" Then
            Panel1.Enabled = True
        ElseIf TextBox1.Text <= "0113211587" Then
            Panel1.Enabled = False
        End If
    End Sub

    Private Sub BtnSilverCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSilverCopy.Click

        Try
            Dim dt1 As DataTable = GetRecordSet("SELECT *FROM [FO_min]" & vbCrLf &
                                                "WHERE  (FO_name LIKE N'%فضه%') OR" & vbCrLf &
                                               "(FO_name LIKE N'%الفضة%')OR" & vbCrLf &
                                               "(FO_name LIKE N'%فضة%')OR" & vbCrLf &
                                               "(FO_name LIKE N'%فضه%')OR" & vbCrLf &
                                               "(FO_name LIKE N'%الفضه%')OR" & vbCrLf &
                                               "(FO_name LIKE N'%فضي%')OR" & vbCrLf &
                                               "(FO_name LIKE N'%فضيه%')OR" & vbCrLf &
                                               "(FO_name LIKE N'%فضية%')OR" & vbCrLf &
                                               "(FO_name LIKE N'%سبيكه فضه%')OR" & vbCrLf &
                                               "(FO_name LIKE N'%SILVER%')OR" & vbCrLf &
                                               "(FO_name LIKE N'%Silver Bar%')OR" & vbCrLf &
                                               "(FO_name LIKE N'%Silver Bar%')OR" & vbCrLf &
                                               "(Gram_valu= '800')OR" & vbCrLf &
                                               "(Gram_valu= '750')OR" & vbCrLf &
                                               "(Gram_valu= '925')")
            If dt1.Rows.Count > 0 Then

                '''''''''''''''''''''''''''''''''''''''''''''''''
                For i As Integer = 0 To dt1.Rows.Count - 1
                    GlCommand.CommandText = "INSERT INTO [SilverItem]" &
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
                                                     ",[ITEM_IMGE]" &
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
                                                     ",@ITEM_IMGE" &
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
                    With GlCommand.Parameters
                        .Clear()
                        .AddWithValue("@userID", dt1.Rows(i)("userID"))
                        .AddWithValue("@FO_name", dt1.Rows(i)("FO_name"))
                        .AddWithValue("@FO_desp", dt1.Rows(i)("FO_desp"))
                        .AddWithValue("@FO_price", dt1.Rows(i)("FO_price"))
                        .AddWithValue("@FO_GramPrice", dt1.Rows(i)("FO_GramPrice"))
                        .AddWithValue("@FO_gram", dt1.Rows(i)("FO_gram"))
                        .AddWithValue("@FO_gramMade", dt1.Rows(i)("FO_gramMade"))
                        .AddWithValue("@FO_made", dt1.Rows(i)("FO_made"))
                        .AddWithValue("@FO_extras", dt1.Rows(i)("FO_extras"))
                        .AddWithValue("@FO_totalPrice", dt1.Rows(i)("FO_totalPrice"))
                        .AddWithValue("@Gram_valu", dt1.Rows(i)("Gram_valu").ToString)
                        .Add("@ITEM_IMGE", SqlDbType.Image).Value = dt1.Rows(i)("ITEM_IMGE")
                        .AddWithValue("@date_care", dt1.Rows(i)("date_care"))
                        .AddWithValue("@FO_ItemNo", dt1.Rows(i)("FO_ItemNo"))
                        .AddWithValue("@Item_Actv", dt1.Rows(i)("Item_Actv"))
                        .AddWithValue("@StoneColor1", dt1.Rows(i)("StoneColor1"))
                        .AddWithValue("@StonePrice1", dt1.Rows(i)("StonePrice1"))
                        .AddWithValue("@StoneWeight2", dt1.Rows(i)("StoneWeight2"))
                        .AddWithValue("@StoneName2", dt1.Rows(i)("StoneName2"))
                        .AddWithValue("@StoneColor2", dt1.Rows(i)("StoneColor2"))
                        .AddWithValue("@StonePrice2", dt1.Rows(i)("StonePrice2"))
                        .AddWithValue("@StoneWeight3", dt1.Rows(i)("StoneWeight3"))
                        .AddWithValue("@StoneName3", dt1.Rows(i)("StoneName3"))
                        .AddWithValue("@StoneColor3", dt1.Rows(i)("StoneColor3"))
                        .AddWithValue("@StonePrice3", dt1.Rows(i)("StonePrice3"))
                        .AddWithValue("@Qty", dt1.Rows(i)("Qty"))
                        .AddWithValue("@BarCode", dt1.Rows(i)("BarCode"))
                        .AddWithValue("@LastEditDate", dt1.Rows(i)("LastEditDate"))
                        .AddWithValue("@ItemNote", dt1.Rows(i)("ItemNote"))
                        .AddWithValue("@GoldCaret999", dt1.Rows(i)("GoldCaret999"))
                        .AddWithValue("@GoldWeight999", dt1.Rows(i)("GoldWeight999"))
                        .AddWithValue("@PurInvNumber", dt1.Rows(i)("PurInvNumber"))
                        .AddWithValue("@MultiItem", dt1.Rows(i)("MultiItem"))
                    End With
                    GlCommand.ExecuteNonQuery()

                    GlCommand.CommandText = "DELETE FROM [FO_min] WHERE [ID]=" & dt1.Rows(i)("ID") & ""
                    GlCommand.ExecuteNonQuery()
                Next
                MsgBox("تم")
            End If
        Catch ex As Exception
            FailMessages &= ex.Message & vbCrLf
        End Try
    End Sub

    Private Sub BtnImgPa_Click(sender As Object, e As EventArgs) Handles BtnImgPa.Click
        Dim OFD As New OpenFileDialog
        OFD.FileName = "Image*"
        OFD.Filter = "Image Formats (*.PNG; *.JPG; *.BMP ; *.JPEG) |*.PNG;*.JPG;*.BMP;*.JPEG| All Files (*.*) | *.*"
        OFD.RestoreDirectory = True
        With OFD
            If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtImgPath.Text = OFD.FileName
                PictureBox1.Image = Image.FromFile(.FileName)
            Else
                Return
            End If
        End With
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub btnSqlsave_Click(sender As Object, e As EventArgs) Handles btnSqlsave.Click
        OnLineSqlGlCom.CommandText = "UPDATE [ADS_SERVICES] SET [IMGE1] = @IMGE1,[IMGEActive]= @IMGEActive"
        With OnLineSqlGlCom.Parameters
            .Clear()
            .Add("@IMGE1", SqlDbType.Image).Value = If(PictureBox1.Image Is Nothing, DBNull.Value, ImageToByte(PictureBox1.Image))
            .AddWithValue("@IMGEActive", "1")
            OnLineSqlGlCom.ExecuteNonQuery()
        End With

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        GlCommand.CommandText = "INSERT INTO dbo.Buy_Gold(" & vbCrLf &
                                "inv_id," & vbCrLf &
                                "castomer_id," & vbCrLf &
                                "bay_val," & vbCrLf &
                                "bay_mazan," & vbCrLf &
                                "bay_gram_price," & vbCrLf &
                                "bay_total_price," & vbCrLf &
                                "Item_Des," & vbCrLf &
                                "INV_Actv," & vbCrLf &
                                "Qunt," & vbCrLf &
                                "AddToItem," & vbCrLf &
                                "Note," & vbCrLf &
                                "GoldCaret999," & vbCrLf &
                                "GoldWeight999)" & vbCrLf &
                                "SELECT " & vbCrLf &
                                "m.saryal AS inv_id, " & vbCrLf &
                                "0       AS castomer_id," & vbCrLf &
                                "21      AS bay_val," & vbCrLf &
                                "0       AS bay_mazan," & vbCrLf &
                                "0       AS bay_gram_price," & vbCrLf &
                                "0       AS bay_total_price," & vbCrLf &
                                "N'0000' AS Item_Des," & vbCrLf &
                                "1       AS INV_Actv," & vbCrLf &
                                "1       AS Qunt," & vbCrLf &
                                "0       AS AddToItem," & vbCrLf &
                                "N''     AS Note," & vbCrLf &
                                "0       AS GoldCaret999," & vbCrLf &
                                "0       AS GoldWeight999" & vbCrLf &
                                "FROM dbo.bay_goled_mony m" & vbCrLf &
                                "WHERE NOT EXISTS (" & vbCrLf &
                                "SELECT 1" & vbCrLf &
                                "FROM dbo.Buy_Gold g" & vbCrLf &
                                "WHERE g.inv_id = m.saryal);"
        GlCommand.ExecuteNonQuery()
        MsgBox("تم تحديث الفواتير" & vbCrLf & " updated successfully.", MsgBoxStyle.Information, AppTitle)
    End Sub

    Private Sub BtnAccessoriesDel_Click(sender As Object, e As EventArgs) Handles BtnAccessoriesDel.Click
        Try
            DeleteUpdateSqlCommend("DELETE FROM [Accessories_BAY]")
            LocSqlGlCom.ExecuteReader()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            DeleteUpdateSqlCommend("DELETE FROM [Accessories_Buy]")
            LocSqlGlCom.ExecuteReader()
            DeleteUpdateSqlCommend("DELETE FROM [Accessories_Buy_Pay]")
            LocSqlGlCom.ExecuteReader()
            DeleteUpdateSqlCommend("DELETE FROM [Accessories_INV]")
            LocSqlGlCom.ExecuteReader()
            DeleteUpdateSqlCommend("DELETE FROM [AuctionInvoiceDetails]")
            LocSqlGlCom.ExecuteReader()
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub BtnUserDel_Click(sender As Object, e As EventArgs) Handles BtnUserDel.Click
        Try
            DeleteUpdateSqlCommend("DELETE FROM [user] where user_name Not Like '%hosam%'")
            LocSqlGlCom.ExecuteReader()
            MsgBox("تم الحزف")
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub BtnCastomDel_Click(sender As Object, e As EventArgs) Handles BtnCastomDel.Click
        Try
            DeleteUpdateSqlCommend("DELETE FROM [CastomerDETELS]")
            LocSqlGlCom.ExecuteReader()
            MsgBox("تم الحزف")
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub BtnAccessoriesItemDel_Click(sender As Object, e As EventArgs) Handles BtnAccessoriesItemDel.Click
        Try
            DeleteUpdateSqlCommend("DELETE FROM [Accessories_ITEM]")
            LocSqlGlCom.ExecuteReader()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            DeleteUpdateSqlCommend("DELETE FROM [Auction_AddItemDetails]")
            LocSqlGlCom.ExecuteReader()

            ResetIDSeed(TableName:="Accessories_ITEM", FieldName:="AccessoriesID", StartFrom:=100)
            ResetIDSeed(TableName:="Auction_AddItemDetails", FieldName:="Auction_ID", StartFrom:=100)
            MsgBox("تم الحزف")
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub BtnCashierDel_Click(sender As Object, e As EventArgs) Handles BtnCashierDel.Click
        Try
            DeleteUpdateSqlCommend("DELETE FROM [cacher]")
            LocSqlGlCom.ExecuteReader()
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            DeleteUpdateSqlCommend("INSERT INTO [dbo].[cacher]([cacher_name],[start_wark],[full_name],[adr],[svil_id],[Active])VALUES(1,'2026-02-23 20:33:20.787',1,'Kuwait',1,1)")
            LocSqlGlCom.ExecuteReader()

            MsgBox("تم حزف الموجود واضفة كاشير افتراضي 1")
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

    Private Sub BtnDelAll_Click(sender As Object, e As EventArgs) Handles BtnDelAll.Click

        DeleteUpdateSqlCommend("DELETE FROM [dimon_bay]")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("DELETE FROM [dimon_invce]")
        LocSqlGlCom.ExecuteReader()
        ResetIDSeed(TableName:="dimon_bay", FieldName:="BAY_ID")
        ResetIDSeed(TableName:="dimon_invce", FieldName:="dim_inv_id")
        DeleteUpdateSqlCommend("DELETE FROM [Buy_Diamond]")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("DELETE FROM [Bay_Diamond_mony]")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("DELETE FROM [Bay_Diamond_id]")
        LocSqlGlCom.ExecuteReader()
        ResetIDSeed(TableName:="Bay_Diamond_mony", FieldName:="bay_id")
        ResetIDSeed(TableName:="Buy_Diamond", FieldName:="B_Diamond_id")
        ResetIDSeed(TableName:="Bay_Diamond_id", FieldName:="Bay_Diamond_id")
        DeleteUpdateSqlCommend("DELETE FROM [DIMON_detels]")
        LocSqlGlCom.ExecuteReader()
        ResetIDSeed(TableName:="DIMON_detels", FieldName:="DIMOND_ID", StartFrom:=100)
        DeleteUpdateSqlCommend("DELETE FROM [Accessories_BAY]")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("DELETE FROM [Accessories_Buy]")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("DELETE FROM [Accessories_Buy_Pay]")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("DELETE FROM [Accessories_INV]")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("DELETE FROM [AuctionInvoiceDetails]")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("DELETE FROM [user] where user_name Not Like '%hosam%'")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("DELETE FROM [CastomerDETELS]")
        LocSqlGlCom.ExecuteReader() : LocSqlGlCom.CommandTimeout = 0
        DeleteUpdateSqlCommend("DELETE FROM [BAY]")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("DELETE FROM [selInvoceDetels]")
        LocSqlGlCom.ExecuteReader()
        ResetIDSeed(TableName:="BAY", FieldName:="BAY_ID")
        ResetIDSeed(TableName:="selInvoceDetels", FieldName:="ID")
        DeleteUpdateSqlCommend("DELETE FROM [bay_goled_mony]")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("DELETE FROM [Buy_Gold]")
        LocSqlGlCom.ExecuteReader()
        ResetIDSeed(TableName:="bay_goled_mony", FieldName:="bay_id")
        ResetIDSeed(TableName:="Buy_Gold", FieldName:="B_gold_id")
        DeleteUpdateSqlCommend("DELETE FROM [FO_min]")
        LocSqlGlCom.ExecuteReader()
        ResetIDSeed(TableName:="FO_min", FieldName:="ID", StartFrom:=100)
        DeleteUpdateSqlCommend("DELETE FROM [Accessories_ITEM]")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("DELETE FROM [Auction_AddItemDetails]")
        LocSqlGlCom.ExecuteReader()
        ResetIDSeed(TableName:="Accessories_ITEM", FieldName:="AccessoriesID", StartFrom:=100)
        ResetIDSeed(TableName:="Auction_AddItemDetails", FieldName:="Auction_ID", StartFrom:=100)
        DeleteUpdateSqlCommend("DELETE FROM [cacher]")
        LocSqlGlCom.ExecuteReader()
        DeleteUpdateSqlCommend("INSERT INTO [dbo].[cacher]([cacher_name],[start_wark],[full_name],[adr],[svil_id],[Active])VALUES(1,'2026-02-23 20:33:20.787',1,'Kuwait',1,1)")
        LocSqlGlCom.ExecuteReader()

        Try
            Dim log As New StringBuilder()
            Dim stepNo As Integer = 0

            ' تنفيذ SQL مع تسجيل
            Dim Exec As Action(Of String, String, String) =
    Sub(sql As String, ar As String, en As String)

        stepNo += 1

        DeleteUpdateSqlCommend(sql)
        Dim affected As Integer = LocSqlGlCom.ExecuteNonQuery()

        log.AppendLine($"{stepNo}) {ar}")
        log.AppendLine($"   {en}")
        log.AppendLine($"   الصفوف المتأثرة / Affected rows: {affected}")
        log.AppendLine()

    End Sub

            ' إعادة ضبط الترقيم
            Dim Seed As Action(Of String, String, Integer?) =
    Sub(tableName As String, fieldName As String, startFrom As Integer?)

        stepNo += 1

        If startFrom.HasValue Then

            ResetIDSeed(tableName, fieldName, startFrom.Value)

            log.AppendLine($"{stepNo}) تم إعادة ضبط ترقيم جدول {tableName} ليبدأ من {startFrom.Value}")
            log.AppendLine($"   Identity reset for {tableName} to start from {startFrom.Value}")

        Else

            ResetIDSeed(tableName, fieldName)

            log.AppendLine($"{stepNo}) تم إعادة ضبط ترقيم جدول {tableName}")
            log.AppendLine($"   Identity reset for {tableName}")

        End If

        log.AppendLine()

    End Sub


            ' ===== العمليات =====

            Exec("DELETE FROM dimon_bay", "تم حذف جدول المبيعات", "Sales table cleared")
            Exec("DELETE FROM dimon_invce", "تم حذف جدول الفواتير", "Invoices table cleared")

            Seed("dimon_bay", "BAY_ID", Nothing)
            Seed("dimon_invce", "dim_inv_id", Nothing)

            Exec("DELETE FROM DIMON_detels", "تم حذف تفاصيل الألماس", "Diamond details cleared")

            Seed("DIMON_detels", "DIMOND_ID", 100)

            Exec("DELETE FROM cacher", "تم حذف الكاشير", "Cashier table cleared")

            Exec("INSERT INTO cacher(cacher_name,start_wark,full_name,adr,svil_id,Active)
          VALUES(1,GETDATE(),1,'Kuwait',1,1)",
          "تم إنشاء كاشير افتراضي",
          "Default cashier created")


            ' ===== الرسالة النهائية =====

            MsgBox(
        "تمت تهيئة النظام بنجاح ✅" & vbCrLf &
        "System initialization completed successfully ✅" & vbCrLf & vbCrLf &
        log.ToString(),
        MsgBoxStyle.Information,
        "تقرير التنفيذ / Execution Report"
    )

        Catch ex As Exception

            MsgBox(
        "حدث خطأ أثناء التنفيذ ❌" & vbCrLf &
        "Error occurred during execution ❌" & vbCrLf & vbCrLf &
        ex.Message,
        MsgBoxStyle.Critical,
        "خطأ / Error"
    )

        End Try
    End Sub
End Class