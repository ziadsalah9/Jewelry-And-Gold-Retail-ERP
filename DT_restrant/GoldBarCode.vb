Imports System.Data.SqlClient

Public Class GoldBarCode
    Dim SELECT_COM As String
    Dim SERVER As String = My.MySettings.Default.DT_restrantConnectionString10
    Dim sqlcon As New SqlConnection
    Dim Sqlcmd As New SqlCommand
    Dim D_Reader As SqlDataReader
    Dim D_Table As New DataTable
    Dim D_Adapter As New SqlDataAdapter
    Dim NEW_Q As String
    Dim CompanyTextFont As Font
    Dim CountryFont As Font
    Dim BarCodeFont As Font
    Dim DataTextFont As Font
    Dim NoFont As New Font("Arial", 10, FontStyle.Bold)
    Dim ArabicOtherTextFont As New Font("Arial", 15, FontStyle.Italic)
    Dim EnglishOtherTextFont As New Font("Arial", 10, FontStyle.Bold)
    Private Sub SetFontSize()
        CompanyTextFont = New Font("Arial", CSng(CompanyTextFontValueTextBox.Text), GetFontStyle(CompanyTextFontStyleTextBox.Text))
        CountryFont = New Font("Arial", CSng(CountryFontValueTextBox.Text), GetFontStyle(CountryFontStyleTextBox.Text))
        'BarCodeFont = New Font("IDAutomationHC39M Code 39 Barcode", CSng(BarCodeFontValueTextBox.Text), GetFontStyle(BarCodeFontStyleTextBox.Text))
        BarCodeFont = New Font("3 of 9 Barcode", CSng(BarCodeFontValueTextBox.Text), GetFontStyle(BarCodeFontStyleTextBox.Text))
        DataTextFont = New Font("Arial", CSng(DataTextFontValueTextBox.Text), GetFontStyle(DataTextFontStyleTextBox.Text))
        'IDAutomationHC39M Code 39 Barcode
    End Sub
    Private Function GetFontStyle(StringStyle As String) As FontStyle
        Select Case StringStyle.ToUpper
            Case "Bold"
                Return FontStyle.Bold
            Case "Italic"
                Return FontStyle.Italic
            Case "Regular"
                Return FontStyle.Regular
            Case "Strikeout"
                Return FontStyle.Strikeout
            Case "Underline"
                Return FontStyle.Underline
            Case Else
                Return FontStyle.Regular
        End Select
    End Function
    Public Sub COM_BOX_GET_DATA()
        Dim sqlcon_COM_BOX As New SqlConnection
        Dim Sqlcmd_COM_BOX As New SqlCommand
        Dim D_Rea As SqlDataReader
        Dim D_Table_COM_BOX As New DataTable
        Dim D_Adapter_COM_BOX As New SqlDataAdapter
        cmbPrintRange.Items.Clear()
        D_Table_COM_BOX.Clear()
        sqlcon_COM_BOX.ConnectionString = SERVER
        sqlcon_COM_BOX.Open()
        Sqlcmd_COM_BOX.Connection = sqlcon_COM_BOX
        If GoldOrSilver = True Then
            'Gold
            Sqlcmd_COM_BOX.CommandText = "SELECT [FO_name] FROM [Print_Parcood1] WHERE [Gram_Valu] BETWEEN '18' AND '24'"
        Else
            'Silver
            Sqlcmd_COM_BOX.CommandText = "SELECT [FO_name] FROM [Print_Parcood1] WHERE [Gram_Valu] BETWEEN '700' AND '925'"
        End If
        D_Rea = Sqlcmd_COM_BOX.ExecuteReader
        D_Table_COM_BOX.Load(D_Rea)
        D_Rea.Close()
        sqlcon_COM_BOX.Close()
        For i As Integer = 0 To D_Table_COM_BOX.Rows.Count - 1
            cmbPrintRange.Items.Add(D_Table_COM_BOX.Rows(i)("FO_name").ToString)
        Next
    End Sub

    Private Sub GoldBarCode_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub

    Private Sub GoldBarCode_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        SELECT_COM = "تنتهي الطباعة عند"
        chkPrintRange.Checked = False
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        frmMain.Timer1.Stop()
        If GoldOrSilver = True Then
            'Gold
            language_start(Name)
            Print_Parcood2TableAdapter.FillBy(DT_restrantDataSet.Print_Parcood2, GoldLowestCarat, GoldHighestCarat)
            Print_Parcood1TableAdapter.FillBy(DT_restrantDataSet.Print_Parcood1, GoldLowestCarat, GoldHighestCarat)
        Else
            'Silver
            language_start("SILVERBARCODE")
            Print_Parcood2TableAdapter.FillBy(DT_restrantDataSet.Print_Parcood2, SilverLowestCarat, SilverHighestCarat)
            Print_Parcood1TableAdapter.FillBy(DT_restrantDataSet.Print_Parcood1, SilverLowestCarat, SilverHighestCarat)
        End If

        Comp_informTableAdapter.Fill(DT_restrantDataSet.comp_inform)
        CONFI_barcoodTableAdapter.Fill(DT_restrantDataSet.CONFI_barcood)


        txtQty.Text = "1"
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If NewForm = True Then
            Print_Parcood1BindingSource.MoveLast()
            Print_Parcood2BindingSource.MoveLast()
        End If
        Print_Parcood1BindingSource.MovePrevious()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        cmbLeftItem.Text = FO_nameTextBox1.Text
        cmbRightItem.Text = FO_nameTextBox.Text
        If Print_setTextBox.Text.Trim <> "" Then
            cmbPrinter.Text = Print_setTextBox.Text.Trim
        End If
        Try
            SetFontSize()
        Catch ex As Exception
            btnDefaults.PerformClick()
            btnSave.PerformClick()
        End Try

    End Sub

    Private Sub cmbRightItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRightItem.SelectedIndexChanged
        Try
            txtBarCodeRight.Text = cmbRightItem.SelectedValue
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub cmbLeftItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLeftItem.SelectedIndexChanged
        txtBarCodeLeft.Text = cmbLeftItem.SelectedValue
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If chkPrintRange.Checked = False Then
            If My.Computer.Keyboard.CtrlKeyDown Then
                PrintBarCodePreview()
            Else
                PrintGoldBarCode()
            End If
        ElseIf chkPrintRange.Checked = True Then
            Print_Multi()
        End If
    End Sub
    Public Sub PrintGoldBarCode()
        If IsNumeric(txtQty.Text.Trim) = False Then
            MsgBox("أدخل عدد ملصقات صحيح" & vbCrLf & "Enter Valid Label Qty.", , Apptitle)
            txtQty.Focus()
            txtQty.SelectAll()
            Exit Sub
        End If
        Try
            For x As Integer = 1 To txtQty.Text
                ValidateChildren()
                CONFI_barcoodBindingSource.EndEdit()
                CONFI_barcoodTableAdapter.Update(DT_restrantDataSet.CONFI_barcood)
                CONFI_barcoodTableAdapter.Fill(DT_restrantDataSet.CONFI_barcood)
                PrintDialog1.PrinterSettings.PrinterName = Print_setTextBox.Text
                PrintDocument1.Print()
            Next
        Catch ex As Exception
            MsgBox("خطأ في إدخال قيم ضبط الباركود" & vbCrLf & "Error in BarCode Data", , Apptitle)
        End Try
    End Sub
    Private Sub PrintBarCodePreview()
        ValidateChildren()
        CONFI_barcoodBindingSource.EndEdit()
        CONFI_barcoodTableAdapter.Update(DT_restrantDataSet.CONFI_barcood)
        CONFI_barcoodTableAdapter.Fill(DT_restrantDataSet.CONFI_barcood)
        With PrintPreviewDialog1
            .Size = New Size(750, 400)
            .StartPosition = FormStartPosition.CenterScreen
            .Document = PrintDocument1
            .PrintPreviewControl.Zoom = 2
            .ShowDialog()
        End With
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ''الجهة اليمني من الباركود
        'e.Graphics.DrawString(BarCodeTextBox.Text, BarCodeFont, Brushes.Black, L_IDTextBox_DTextBox.Text, L_IDTextBox_UTextBox.Text) ''الباركود الجهة اليمن
        e.Graphics.DrawString("*" & BarCodeTextBox.Text & "*", BarCodeFont, Brushes.Black, L_IDTextBox_DTextBox.Text, L_IDTextBox_UTextBox.Text) ''الباركود الجهة اليمن
        e.Graphics.DrawString(SET_INVARCHR128TextBox.Text & FO_madeTextBox.Text, CountryFont, Brushes.Black, L_FO_CountryTextBox_DTextBox.Text, L_FO_CountryTextBox_UTextBox.Text) ''بلد المنشأ 
        e.Graphics.DrawString(SET_INVARCHR1TextBox.Text & FO_GramPriceTextBox.Text, CountryFont, Brushes.Black, L_FO_madeTextBox_DTextBox.Text, L_FO_madeTextBox_UTextBox.Text) ''اسم المورد / الشركة
        e.Graphics.DrawString(BarCodeTextBox.Text, NoFont, Brushes.Black, L_font_IDTextBox_DTextBox.Text, L_font_IDTextBox_UTextBox.Text) ''رقم الباركود الجهة اليمن
        e.Graphics.DrawString(cmbCompany.Text, CompanyTextFont, Brushes.Black, L_ComboBox3_DTextBox.Text, L_ComboBox3_UTextBox.Text) '' اسم الشركه الجهة اليمني
        e.Graphics.DrawString(FO_gramTextBox.Text, DataTextFont, Brushes.Black, L_FO_gramTextBox_DTextBox.Text, L_FO_gramTextBox_UTextBox.Text) ''رقم الوزن
        e.Graphics.DrawString(SET_INVARCHR11TextBox.Text, DataTextFont, Brushes.Black, L_W_DTextBox.Text, L_W_UTextBox.Text) ''اسم الوزن
        If GoldOrSilver = True Then
            'Gold
            e.Graphics.DrawString(SET_INVARCHR12TextBox.Text, DataTextFont, Brushes.Black, L_M_DTextBox.Text, L_M_UTextBox.Text) ''اسم المصنعية
        Else
            'Silver
            e.Graphics.DrawString(SET_INVARCHR13TextBox.Text, DataTextFont, Brushes.Black, L_M_DTextBox.Text, L_M_UTextBox.Text) ''السعر للفضة
        End If

        e.Graphics.DrawString(FO_gramMadeTextBox.Text, DataTextFont, Brushes.Black, L_FO_gramMadeTextBox_DTextBox.Text, L_FO_gramMadeTextBox_UTextBox.Text) ''رقم المصنعية
        e.Graphics.DrawString(Gram_valuTextBox.Text, DataTextFont, Brushes.Black, L_Gram_valuTextBox_DTextBox.Text, L_Gram_valuTextBox_UTextBox.Text) ''رقم العيار
        e.Graphics.DrawString(SET_INVARCHR14TextBox.Text, DataTextFont, Brushes.Black, L_C_DTextBox.Text, L_C_UTextBox.Text) '' العيار
        e.Graphics.DrawString(FO_priceTextBox.Text, DataTextFont, Brushes.Black, L_S_DTextBox.Text, L_S_UTextBox.Text) ''اسم الفص1
        e.Graphics.DrawString(StoneName2TextBox.Text, DataTextFont, Brushes.Black, L_Stone2Text_DTextBox.Text, L_Stone2Text_UTextBox.Text) ''اسم الفص2
        e.Graphics.DrawString(StoneName3TextBox.Text, DataTextFont, Brushes.Black, L_Stone3Text_DTextBox.Text, L_Stone3Text_UTextBox.Text) ''اسم الفص3
        e.Graphics.DrawString(FO_extrasTextBox.Text, DataTextFont, Brushes.Black, L_FO_extrasTextBox_DTextBox.Text, L_FO_extrasTextBox_UTextBox.Text) '' وزن الفص1
        e.Graphics.DrawString(StoneWeight2TextBox.Text, DataTextFont, Brushes.Black, L_Stone2Value_DTextBox.Text, L_Stone2Value_UTextBox.Text) '' وزن الفص2
        e.Graphics.DrawString(StoneWeight3TextBox.Text, DataTextFont, Brushes.Black, L_Stone3Value_DTextBox.Text, L_Stone3Value_UTextBox.Text) '' وزن الفص2
        e.Graphics.DrawString(FO_ItemNoTextBox.Text, DataTextFont, Brushes.Black, L_CodeValue_DTextBox.Text, L_CodeValue_UTextBox.Text) ''رقم الرمز
        e.Graphics.DrawString("الرمز", DataTextFont, Brushes.Black, L_CodeText_DTextBox.Text, L_CodeText_UTextBox.Text) '' الرمز

        ' ''الجهة اليسري من الباركود
        ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        e.Graphics.DrawString("*" & BarCodeTextBox1.Text & "*", BarCodeFont, Brushes.Black, R_IDTextBox_DTextBox.Text, R_IDTextBox_UTextBox.Text) ''الباركود الجهة اليسري
        'e.Graphics.DrawString(BarCodeTextBox1.Text, BarCodeFont, Brushes.Black, R_IDTextBox_DTextBox.Text, R_IDTextBox_UTextBox.Text) ''الباركود الجهة اليسري
        e.Graphics.DrawString(SET_INVARCHR128TextBox.Text & FO_madeTextBox1.Text, CountryFont, Brushes.Black, R_FO_CountryTextBox_DTextBox.Text, R_FO_CountryTextBox_UTextBox.Text) ''بلد المنشأ 
        e.Graphics.DrawString(SET_INVARCHR1TextBox.Text & FO_GramPriceTextBox1.Text, CountryFont, Brushes.Black, R_FO_madeTextBox_DTextBox.Text, R_FO_madeTextBox_UTextBox.Text) ''اسم المورد / الشركه
        e.Graphics.DrawString(BarCodeTextBox1.Text, NoFont, Brushes.Black, R_font_IDTextBox_DTextBox.Text, R_font_IDTextBox_UTextBox.Text) ''رقم الباركود الجهة اليسري
        e.Graphics.DrawString(cmbCompany.Text, CompanyTextFont, Brushes.Black, R_ComboBox3_DTextBox.Text, R_ComboBox3_UTextBox.Text) '' اسم الشركة الجهة اليسري
        e.Graphics.DrawString(FO_gramTextBox1.Text, DataTextFont, Brushes.Black, R_FO_gramTextBox_DTextBox.Text, R_FO_gramTextBox_UTextBox.Text) ''اليسري رقم الوزن
        e.Graphics.DrawString(SET_INVARCHR11TextBox.Text, DataTextFont, Brushes.Black, R_W_DTextBox.Text, R_W_UTextBox.Text) ''اليسري اسم الوزن
        If GoldOrSilver = True Then
            'Gold
            e.Graphics.DrawString(SET_INVARCHR12TextBox.Text, DataTextFont, Brushes.Black, R_M_DTextBox.Text, R_M_UTextBox.Text) ''اليسري اسم المصنعية
        Else
            'Silver
            e.Graphics.DrawString(SET_INVARCHR13TextBox.Text, DataTextFont, Brushes.Black, R_M_DTextBox.Text, R_M_UTextBox.Text) ''اليسري سعر الفضة
        End If

        e.Graphics.DrawString(FO_gramMadeTextBox1.Text, DataTextFont, Brushes.Black, R_FO_gramMadeTextBox_DTextBox.Text, R_FO_gramMadeTextBox_UTextBox.Text) ''رقم المصنعية اليسري 
        e.Graphics.DrawString(Gram_valuTextBox1.Text, DataTextFont, Brushes.Black, R_Gram_valuTextBox_DTextBox.Text, R_Gram_valuTextBox_UTextBox.Text) ''رقم العيار اليسري
        e.Graphics.DrawString(SET_INVARCHR14TextBox.Text, DataTextFont, Brushes.Black, R_C_DTextBox.Text, R_C_UTextBox.Text) ''  اليسري العيار

        e.Graphics.DrawString(FO_priceTextBox1.Text, DataTextFont, Brushes.Black, R_S_DTextBox.Text, R_S_UTextBox.Text) ''اسم الفص1
        e.Graphics.DrawString(StoneName2TextBox1.Text, DataTextFont, Brushes.Black, R_Stone2Text_DTextBox.Text, R_Stone2Text_UTextBox.Text) ''اسم الفص2
        e.Graphics.DrawString(StoneName3TextBox1.Text, DataTextFont, Brushes.Black, R_Stone3Text_DTextBox.Text, R_Stone3Text_UTextBox.Text) ''اسم الفص3
        e.Graphics.DrawString(FO_extrasTextBox1.Text, DataTextFont, Brushes.Black, R_FO_extrasTextBox_DTextBox.Text, R_FO_extrasTextBox_UTextBox.Text) '' وزن الفص1
        e.Graphics.DrawString(StoneWeight2TextBox1.Text, DataTextFont, Brushes.Black, R_Stone2Value_DTextBox.Text, R_Stone2Value_UTextBox.Text) '' وزن الفص2
        e.Graphics.DrawString(StoneWeight3TextBox1.Text, DataTextFont, Brushes.Black, R_Stone3Value_DTextBox.Text, R_Stone3Value_UTextBox.Text) '' وزن الفص2
        e.Graphics.DrawString(FO_ItemNoTextBox1.Text, DataTextFont, Brushes.Black, R_CodeValue_DTextBox.Text, R_CodeValue_UTextBox.Text) ''رقم الرمز
        e.Graphics.DrawString("الرمز", DataTextFont, Brushes.Black, R_CodeText_DTextBox.Text, R_CodeText_UTextBox.Text) '' الرمز

        e.Graphics.DrawString(SET_INVARCHR15TextBox.Text, ArabicOtherTextFont, Brushes.Black, txtSAP_D.Text, txtSAP_U.Text) ''سبائك الكويت
        e.Graphics.DrawString(SET_INVARCHR17TextBox.Text, EnglishOtherTextFont, Brushes.Black, txtGOLDENSAP_D.Text, txtGOLDENSAP_U.Text) 'سبائك الكويت
    End Sub

    Private Sub cmbPrinter_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbPrinter.MouseClick
        cmbPrinter.Items.Clear()
        For Each InstalledPrinter As String In Printing.PrinterSettings.InstalledPrinters
            cmbPrinter.Items.Add(InstalledPrinter)
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbPrinter.Text = "" Then
            MsgBox("لايمكن حفظ الإعدادات دون تحديد الطابعة" & vbCrLf & "Can't Save Settings Without Selecting a Printer..", , Apptitle)
            Exit Sub
        Else
            Try
                Print_setTextBox.Text = cmbPrinter.Text.Trim
                ValidateChildren()
                CONFI_barcoodBindingSource.EndEdit()
                CONFI_barcoodTableAdapter.Update(DT_restrantDataSet.CONFI_barcood)
                CONFI_barcoodTableAdapter.Fill(DT_restrantDataSet.CONFI_barcood)
                SetFontSize()
                MsgBox("تم حفظ الإعدادات بنجاح" & vbCrLf & "Setting Saved Successfully", , Apptitle)
            Catch ex As Exception
                MsgBox("خطأ في الإعدادات النصية" & vbCrLf & "Error in Settings Data", , Apptitle)
            End Try
        End If
    End Sub

    Private Sub pbHLeftValue_DoubleClick(sender As Object, e As EventArgs) Handles pbHLeftValue.DoubleClick
        HLeftValue()
    End Sub
    Private Sub pbVLeftValue_DoubleClick(sender As Object, e As EventArgs) Handles pbVLeftValue.DoubleClick
        VLeftValue()
    End Sub
    Private Sub pbHLeftText_DoubleClick(sender As Object, e As EventArgs) Handles pbHLeftText.DoubleClick
        HLeftText()
    End Sub
    Private Sub pbVLeftText_DoubleClick(sender As Object, e As EventArgs) Handles pbVLeftText.DoubleClick
        VLeftText()
    End Sub
    Private Sub pbHRightValue_DoubleClick(sender As Object, e As EventArgs) Handles pbHRightValue.DoubleClick
        HRightValue()
    End Sub
    Private Sub pbVRightValue_DoubleClick(sender As Object, e As EventArgs) Handles pbVRightValue.DoubleClick
        VRightValue()
    End Sub
    Private Sub pbHRightText_DoubleClick(sender As Object, e As EventArgs) Handles pbHRightText.DoubleClick
        HRightText()
    End Sub
    Private Sub pbVRightText_DoubleClick(sender As Object, e As EventArgs) Handles pbVRightText.DoubleClick
        VRightText()
    End Sub
    Private Sub HLeftValue()
        R_FO_gramMadeTextBox_DTextBox.Text = R_FO_gramTextBox_DTextBox.Text
        R_Gram_valuTextBox_DTextBox.Text = R_FO_gramTextBox_DTextBox.Text
        R_FO_extrasTextBox_DTextBox.Text = R_FO_gramTextBox_DTextBox.Text
        R_Stone2Value_DTextBox.Text = R_FO_gramTextBox_DTextBox.Text
        R_Stone3Value_DTextBox.Text = R_FO_gramTextBox_DTextBox.Text
        If R_CodeValue_DTextBox.Text = "" Then R_CodeValue_DTextBox.Text = "0"
    End Sub
    Private Sub VLeftValue()
        R_FO_gramMadeTextBox_UTextBox.Text = Val(R_FO_gramTextBox_UTextBox.Text) + 10
        R_Gram_valuTextBox_UTextBox.Text = Val(R_FO_gramTextBox_UTextBox.Text) + 20
        R_FO_extrasTextBox_UTextBox.Text = Val(R_FO_gramTextBox_UTextBox.Text) + 30
        R_Stone2Value_UTextBox.Text = Val(R_FO_gramTextBox_UTextBox.Text) + 35
        R_Stone3Value_UTextBox.Text = Val(R_FO_gramTextBox_UTextBox.Text) + 40
        If R_CodeValue_UTextBox.Text = "" Then R_CodeValue_UTextBox.Text = "0"
    End Sub
    Private Sub HLeftText()
        R_font_IDTextBox_DTextBox.Text = R_FO_madeTextBox_DTextBox.Text
        R_IDTextBox_DTextBox.Text = Val(R_FO_madeTextBox_DTextBox.Text) - 10
        R_M_DTextBox.Text = R_W_DTextBox.Text
        R_C_DTextBox.Text = R_W_DTextBox.Text
        R_S_DTextBox.Text = R_W_DTextBox.Text
        R_Stone2Text_DTextBox.Text = R_W_DTextBox.Text
        R_Stone3Text_DTextBox.Text = R_W_DTextBox.Text
        If R_CodeText_DTextBox.Text = "" Then R_CodeText_DTextBox.Text = "0"
    End Sub
    Private Sub VLeftText()
        R_IDTextBox_UTextBox.Text = Val(R_FO_madeTextBox_UTextBox.Text) + 15
        R_font_IDTextBox_UTextBox.Text = Val(R_FO_madeTextBox_UTextBox.Text) + 25
        R_M_UTextBox.Text = Val(R_W_UTextBox.Text) + 10
        R_C_UTextBox.Text = Val(R_W_UTextBox.Text) + 20
        R_S_UTextBox.Text = Val(R_W_UTextBox.Text) + 30
        R_Stone2Text_UTextBox.Text = Val(R_W_UTextBox.Text) + 35
        R_Stone3Text_UTextBox.Text = Val(R_W_UTextBox.Text) + 40
        If R_CodeText_UTextBox.Text = "" Then R_CodeText_UTextBox.Text = "0"
    End Sub
    Private Sub HRightValue()
        L_FO_gramMadeTextBox_DTextBox.Text = L_FO_gramTextBox_DTextBox.Text
        L_Gram_valuTextBox_DTextBox.Text = L_FO_gramTextBox_DTextBox.Text
        L_FO_extrasTextBox_DTextBox.Text = L_FO_gramTextBox_DTextBox.Text
        L_Stone2Value_DTextBox.Text = L_FO_gramTextBox_DTextBox.Text
        L_Stone3Value_DTextBox.Text = L_FO_gramTextBox_DTextBox.Text
        If L_CodeValue_DTextBox.Text = "" Then L_CodeValue_DTextBox.Text = "0"
    End Sub
    Private Sub VRightValue()
        L_FO_gramMadeTextBox_UTextBox.Text = Val(L_FO_gramTextBox_UTextBox.Text) + 10
        L_Gram_valuTextBox_UTextBox.Text = Val(L_FO_gramTextBox_UTextBox.Text) + 20
        L_FO_extrasTextBox_UTextBox.Text = Val(L_FO_gramTextBox_UTextBox.Text) + 30
        L_Stone2Value_UTextBox.Text = Val(L_FO_gramTextBox_UTextBox.Text) + 35
        L_Stone3Value_UTextBox.Text = Val(L_FO_gramTextBox_UTextBox.Text) + 40
        If L_CodeValue_UTextBox.Text = "" Then L_CodeValue_UTextBox.Text = "0"
    End Sub
    Private Sub HRightText()
        L_font_IDTextBox_DTextBox.Text = L_FO_madeTextBox_DTextBox.Text
        L_IDTextBox_DTextBox.Text = Val(L_FO_madeTextBox_DTextBox.Text) - 10
        L_M_DTextBox.Text = L_W_DTextBox.Text
        L_C_DTextBox.Text = L_W_DTextBox.Text
        L_S_DTextBox.Text = L_W_DTextBox.Text
        L_Stone2Text_DTextBox.Text = L_W_DTextBox.Text
        L_Stone3Text_DTextBox.Text = L_W_DTextBox.Text
        If L_CodeText_DTextBox.Text = "" Then L_CodeText_DTextBox.Text = "0"
    End Sub
    Private Sub VRightText()
        L_IDTextBox_UTextBox.Text = Val(L_FO_madeTextBox_UTextBox.Text) + 15
        L_font_IDTextBox_UTextBox.Text = Val(L_FO_madeTextBox_UTextBox.Text) + 25
        L_M_UTextBox.Text = Val(L_W_UTextBox.Text) + 10
        L_C_UTextBox.Text = Val(L_W_UTextBox.Text) + 20
        L_S_UTextBox.Text = Val(L_W_UTextBox.Text) + 30
        L_Stone2Text_UTextBox.Text = Val(L_W_UTextBox.Text) + 35
        L_Stone3Text_UTextBox.Text = Val(L_W_UTextBox.Text) + 40
        If L_CodeText_UTextBox.Text = "" Then L_CodeText_UTextBox.Text = "0"
    End Sub
    Public Sub Print_Multi()
        If cmbPrintRange.Text = "تنتهي الطباعة عند" Then
            MsgBox("حدد انتهاء الطباعة" & vbCrLf & "Select the end of printing.", , Apptitle)
            Exit Sub
        End If
        If chkPrintRange.Checked = False Then
            If My.Computer.Keyboard.CtrlKeyDown Then
                PrintBarCodePreview()
            Else
                PrintGoldBarCode()
            End If
        ElseIf chkPrintRange.Checked = True Then
            If My.Computer.Keyboard.CtrlKeyDown Then
                PrintBarCodePreview()
            Else
                PrintGoldBarCode()
            End If
            Do While -1
                Print_Parcood1BindingSource.MoveNext()
                Print_Parcood1BindingSource.MoveNext()
                Print_Parcood2BindingSource.MoveNext()
                Print_Parcood2BindingSource.MoveNext()
                PrintGoldBarCode()
                If cmbLeftItem.Text = cmbPrintRange.Text Then
                    cmbPrintRange.Text = "تنتهي الطباعة عند"
                    COM_BOX_GET_DATA()
                    Exit Do
                    Exit Sub
                ElseIf cmbRightItem.Text = cmbPrintRange.Text Then
                    cmbPrintRange.Text = "تنتهي الطباعة عند"
                    COM_BOX_GET_DATA()
                    Exit Do
                    Exit Sub
                End If
            Loop
        End If

    End Sub

    Private Sub txtBarCodeRight_TextChanged(sender As Object, e As EventArgs) Handles txtBarCodeRight.TextChanged
        cmbRightItem.SelectedValue = txtBarCodeRight.Text.Trim
    End Sub

    Private Sub txtBarCodeLeft_TextChanged(sender As Object, e As EventArgs) Handles txtBarCodeLeft.TextChanged
        cmbLeftItem.SelectedValue = txtBarCodeLeft.Text.Trim
    End Sub

    Private Sub Cop_select_val_Click(sender As Object, e As EventArgs) Handles cmbPrintRange.Click
        COM_BOX_GET_DATA()

    End Sub

    Private Sub Cop_select_val_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrintRange.SelectedIndexChanged
        'SELECT_COM = Cop_select_val.SelectedValue
        ListView1.Clear()
        ListView2.Clear()
    End Sub

    Private Sub btnDefaults_Click(sender As Object, e As EventArgs) Handles btnDefaults.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If MsgBox("ضبط الافتراضيات للكل؟" & vbCrLf & "Restore All Defaults?", vbYesNo) = vbYes Then
                R_FO_gramTextBox_DTextBox.Text = "10"
                HLeftValue()
                R_FO_gramTextBox_UTextBox.Text = "105"
                VLeftValue()
                R_W_DTextBox.Text = Val(R_FO_gramTextBox_DTextBox.Text) + 35
                R_FO_CountryTextBox_DTextBox.Text = R_FO_gramTextBox_DTextBox.Text
                SetDefaultFonts()
                txtSAP_D.Text = "130"
                txtSAP_U.Text = "50"
                txtGOLDENSAP_D.Text = "120"
                txtGOLDENSAP_U.Text = "70"
            End If
        Else
            If MsgBox("ضبط الافتراضيات؟" & vbCrLf & "Restore Defaults?", vbYesNo) = vbYes Then
                SetDefaultFonts()
            End If
        End If

        For Each txt As Control In gbLeftValue.Controls
            If TypeOf txt Is TextBox Then
                If CType(txt, TextBox).Text = "" Then CType(txt, TextBox).Text = "0"
            End If
        Next
        For Each txt As Control In gbLeftText.Controls
            If TypeOf txt Is TextBox Then
                If CType(txt, TextBox).Text = "" Then CType(txt, TextBox).Text = "0"
            End If
        Next
        For Each txt As Control In gbRightValue.Controls
            If TypeOf txt Is TextBox Then
                If CType(txt, TextBox).Text = "" Then CType(txt, TextBox).Text = "0"
            End If
        Next
        For Each txt As Control In gbRightText.Controls
            If TypeOf txt Is TextBox Then
                If CType(txt, TextBox).Text = "" Then CType(txt, TextBox).Text = "0"
            End If
        Next

    End Sub
    Private Sub SetDefaultFonts()
        CompanyTextFontValueTextBox.Text = "6"
        CompanyTextFontStyleTextBox.Text = "R"
        CountryFontValueTextBox.Text = "6"
        CountryFontStyleTextBox.Text = "R"
        BarCodeFontValueTextBox.Text = "10"
        BarCodeFontStyleTextBox.Text = "R"
        DataTextFontValueTextBox.Text = "8"
        DataTextFontStyleTextBox.Text = "R"
    End Sub

    Private Sub chkPrintMulti_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrintRange.CheckedChanged
        cmbPrintRange.Enabled = chkPrintRange.Checked
    End Sub

    Private Sub cmbPrinter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPrinter.SelectedIndexChanged

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
End Class