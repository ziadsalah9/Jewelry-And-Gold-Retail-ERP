Imports System.Data.SqlClient

Public Class DiamondBarCode
    Dim SERVER As String = My.MySettings.Default.DT_restrantConnectionString10
    Dim fontBarcode As Font
    Dim fontTextSize As Font
    Dim fontStoneTextSize As Font
    Dim fontCompanyTextSize As Font
    Dim fontGoldSAP As New Font("Arial", 12, FontStyle.Bold)
    Dim fontTelephone As New Font("Arial", 10, FontStyle.Bold)
    Dim fontCode As Font
    Private Function GetFontStyle(StringStyle As String) As FontStyle
        Select Case StringStyle.ToUpper
            Case "B"
                Return FontStyle.Bold
            Case "R"
                Return FontStyle.Regular
            Case Else
                Return FontStyle.Regular
        End Select
    End Function

    Private Sub DiamondBarCode_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmMain.Timer1.Start()
        Dispose()
    End Sub
    Private Sub DiamondBarCode_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        InitializeDiamondBarCode()
    End Sub
    Public Sub InitializeDiamondBarCode()
        frmMain.Timer1.Stop()
        language_start(Name)
        SettingsTableAdapter.Fill(DT_restrantDataSet.Settings)
        DIMON_BARICOOD_SELECT_RIGHTTableAdapter.Fill(DT_restrantDataSet.DIMON_BARICOOD_SELECT_RIGHT)
        DIMON_BARICOOD_FOR_SELECT_LEFTTableAdapter.Fill(DT_restrantDataSet.DIMON_BARICOOD_FOR_SELECT_LEFT)
        DIMON_BARICOOD_RIGHTTableAdapter.Fill(DT_restrantDataSet.DIMON_BARICOOD_RIGHT)
        DIMON_BARICOOD_LEFTTableAdapter.Fill(DT_restrantDataSet.DIMON_BARICOOD_LEFT)
        Comp_informTableAdapter.Fill(DT_restrantDataSet.comp_inform)
        CONFI_barcood_dimonTableAdapter.Fill(DT_restrantDataSet.CONFI_barcood_dimon)
        txtQty.Text = 1
        If Print_nameTextBox.Text.Trim <> "" Then
            cmbPrinterName.Text = Print_nameTextBox.Text
        End If
        SetFontSize()
    End Sub
    Private Sub SetFontSize()
        If SET_INVARCHR171TextBox.Text = "" Then SET_INVARCHR171TextBox.Text = "6"
        If SET_INVARCHR172TextBox.Text = "" Then SET_INVARCHR172TextBox.Text = "R"
        fontBarcode = New Font("3 of 9 Barcode", CSng(txtBarCodeSize.Text), GetFontStyle(txtBarCodeStyle.Text))
        fontTextSize = New Font("Arial", CSng(txtFontSize.Text), GetFontStyle(txtFontStyle.Text))
        fontStoneTextSize = New Font("Arial", CSng(txtStoneSize.Text), GetFontStyle(txtStoneStyle.Text))
        fontCompanyTextSize = New Font("Arial", CSng(txtCompanySize.Text), GetFontStyle(txtCompanyStyle.Text))
        fontCode = New Font("Arial", CSng(txtCompanySize.Text), GetFontStyle(txtCompanyStyle.Text))
        fontTelephone = New Font("Arial", CSng(SET_INVARCHR171TextBox.Text), GetFontStyle(SET_INVARCHR172TextBox.Text))
    End Sub
    Private Sub cmbPrinterName_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbPrinterName.MouseClick
        cmbPrinterName.Items.Clear()
        For Each InstalledPrinter As String In Printing.PrinterSettings.InstalledPrinters
            cmbPrinterName.Items.Add(InstalledPrinter)
        Next
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbPrinterName.Text = "" Then
            MsgBox("لايمكن حفظ الإعدادات دون تحديد طابعة" & vbCrLf & "Can't Save Setting Without Selecting a Printer", , Apptitle)
            Exit Sub
        Else
            Try
                Print_nameTextBox.Text = cmbPrinterName.Text
                ValidateChildren()
                CONFI_barcood_dimonBindingSource.EndEdit()
                CONFI_barcood_dimonTableAdapter.Update(DT_restrantDataSet.CONFI_barcood_dimon)
                SettingsBindingSource.EndEdit()
                SettingsTableAdapter.Update(DT_restrantDataSet.Settings)
                SetFontSize()
                MsgBox("تم حفظ الإعدادات بنجاح" & vbCrLf & "Setting Saved Successfully", , Apptitle)
            Catch ex As Exception
                MsgBox("خطأ في الإعدادات النصية" & vbCrLf & "Error in Data Entry", , Apptitle)
            End Try
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'الباركود الجهة اليسري
        'e.Graphics.DrawString(Test_119TextBox1.Text, fontBarcode, Brushes.Black, DIMOND_ID_leftTextBox.Text, DIMOND_ID_left1upTextBox.Text) 'الباركود الجهة اليسري
        e.Graphics.DrawString("*" & Test_119TextBox1.Text & "*", fontBarcode, Brushes.Black, DIMOND_ID_leftTextBox.Text, DIMOND_ID_left1upTextBox.Text) 'الباركود الجهة اليسري
        e.Graphics.DrawString(Test_119TextBox1.Text, fontTextSize, Brushes.Black, Test_1_leftTextBox.Text, Test_1_left1upTextBox.Text) 'خط الباركود الجهة اليسري
        e.Graphics.DrawString(DIMON_NAMETextBox1.Text, fontCompanyTextSize, Brushes.Black, DIMO_dep_leftTextBox.Text, DIMO_dep_left1upTextBox.Text) 'اسم الصنف الجهة اليسري
        e.Graphics.DrawString(DIM_na9awaTextBox1.Text, fontTextSize, Brushes.Black, DIM_na9awa_leftTextBox.Text, DIM_na9awa_left1upTextBox.Text) 'النقاوه الجهة اليسري
        e.Graphics.DrawString(DIMO_mezanTextBox1.Text, fontTextSize, Brushes.Black, DIMO_mezan_leftTextBox.Text, DIMO_mezan_left1upTextBox.Text) 'قيراط الالماس
        e.Graphics.DrawString(Ext_colerTextBox1.Text, fontTextSize, Brushes.Black, Ext_coler_leftTextBox.Text, Ext_coler_left1upTextBox.Text) 'اللون

        If SET_INVARCHR18TextBox.Text = "1" Then
            e.Graphics.DrawString(" KD " & Test_1TextBox1.Text, fontTextSize, Brushes.Black, Qult_leftTextBox.Text, Qult_left1upTextBox.Text) ' السعر
        Else
            e.Graphics.DrawString(Test_1TextBox1.Text & " KD ", fontTextSize, Brushes.Black, Qult_leftTextBox.Text, Qult_left1upTextBox.Text) ' السعر
        End If

        e.Graphics.DrawString(SarualTextBox1.Text, fontCompanyTextSize, Brushes.Black, Sarual_leftTextBox.Text, Sarual_left1upTextBox.Text) 'السريال نمبر
        e.Graphics.DrawString(Val_goldTextBox1.Text.ToString, fontTextSize, Brushes.Black, Val_gold_leftTextBox.Text, Val_gold_left1upTextBox.Text) 'عيار الذهب
        e.Graphics.DrawString(GOLD_mezanTextBox1.Text, fontTextSize, Brushes.Black, GOLD_mezan_leftTextBox.Text, GOLD_mezan_left1upTextBox.Text) 'وزن الذهب
        e.Graphics.DrawString(Test_11TextBox1.Text, fontCompanyTextSize, Brushes.Black, Test_12_leftTextBox.Text, Test_1_rightTextBox1.Text) 'القص
        e.Graphics.DrawString(cmbCompanyName.Text, fontCompanyTextSize, Brushes.Black, NoteTextBox1.Text, Note2TextBox1.Text) 'اسم المعرض
        e.Graphics.DrawString(Test_14TextBox1.Text, fontStoneTextSize, Brushes.Black, LeftValueLRStoneName1.Text, LeftValueUDStoneName1.Text) 'نوع الحجر1
        e.Graphics.DrawString(Test_13TextBox1.Text, fontStoneTextSize, Brushes.Black, LeftValueLRStoneWeight1.Text, LeftValueUDStoneWeight1.Text) 'وزن الحجر1
        e.Graphics.DrawString(Cut1TextBox1.Text, fontStoneTextSize, Brushes.Black, Cut1_LeftupTextBox.Text, Cut1_Left1upTextBox.Text) 'قصة الحجر1
        e.Graphics.DrawString(Test_17TextBox1.Text, fontStoneTextSize, Brushes.Black, LeftValueLRStoneName2.Text, LeftValueUDStoneName2.Text) 'نوع الحجر2
        e.Graphics.DrawString(Test_16TextBox1.Text, fontStoneTextSize, Brushes.Black, LeftValueLRStoneWeight2.Text, LeftValueUDStoneWeight2.Text) 'وزن الحجر2
        e.Graphics.DrawString(Cut2TextBox1.Text, fontStoneTextSize, Brushes.Black, Cut2_LeftupTextBox.Text, Cut2_Left1upTextBox.Text) 'قصة الحجر2
        e.Graphics.DrawString(Test_110TextBox1.Text, fontStoneTextSize, Brushes.Black, LeftValueLRStoneName3.Text, LeftValueUDStoneName3.Text) 'نوع الحجر3
        e.Graphics.DrawString(Test_19TextBox1.Text, fontStoneTextSize, Brushes.Black, LeftValueLRStoneWeight3.Text, LeftValueUDStoneWeight3.Text) 'وزن الحجر3
        e.Graphics.DrawString(Cut3TextBox1.Text, fontStoneTextSize, Brushes.Black, Cut3_LeftupTextBox.Text, Cut3_Left1upTextBox.Text) 'قصة الحجر3
        e.Graphics.DrawString(Test_115TextBox1.Text, fontCode, Brushes.Black, Code_LeftupTextBox.Text, Code_Left1upTextBox.Text) 'الرمز

        Dim TotalStoneWeightLeft As Decimal
        TotalStoneWeightLeft = Math.Round(Val(DIMO_mezanTextBox1.Text) + Val(Test_13TextBox1.Text) + Val(Test_16TextBox1.Text) + Val(Test_19TextBox1.Text), 2)
        e.Graphics.DrawString(TotalStoneWeightLeft, fontCode, Brushes.Black, TotalStoneWeight_LeftupTextBox.Text, TotalStoneWeight_Left1upTextBox.Text) 'وزن إجمالي للفصوص

        '\\\\ الجهة اليمني  الباركود
        'e.Graphics.DrawString(Test_119TextBox.Text, fontBarcode, Brushes.Black, DIMOND_ID_rightTextBox.Text, DIMOND_ID_right1upTextBox.Text) 'الباركود الجهة اليمني
        e.Graphics.DrawString("*" & Test_119TextBox.Text & "*", fontBarcode, Brushes.Black, DIMOND_ID_rightTextBox.Text, DIMOND_ID_right1upTextBox.Text) 'الباركود الجهة اليمني
        e.Graphics.DrawString(Test_119TextBox.Text, fontTextSize, Brushes.Black, Test_12_left1upTextBox.Text, Test_1_right1upTextBox.Text) 'خط الباركود الجهة اليمني
        e.Graphics.DrawString(DIMON_NAMETextBox.Text, fontCompanyTextSize, Brushes.Black, DIMO_dep_rightTextBox.Text, DIMO_dep_right1upTextBox.Text) 'اسم الصنف الجهة اليمني
        e.Graphics.DrawString(DIM_na9awaTextBox.Text, fontTextSize, Brushes.Black, DIM_na9awa_rightTextBox.Text, DIM_na9awa_right1upTextBox.Text) 'النقاوه الجهة اليمني
        e.Graphics.DrawString(DIMO_mezanTextBox.Text, fontTextSize, Brushes.Black, DIMO_mezan_rightTextBox.Text, DIMO_mezan_right1upTextBox.Text) ' اليمني قيراط الالماس
        e.Graphics.DrawString(Ext_colerTextBox.Text, fontTextSize, Brushes.Black, Ext_coler_rightTextBox.Text, Ext_coler_right1upTextBox.Text) ' اليمني اللون

        If SET_INVARCHR18TextBox.Text = "1" Then
            e.Graphics.DrawString(" KD " & Test_1TextBox.Text, fontTextSize, Brushes.Black, Qult_rightTextBox.Text, Qult_right1upTextBox.Text) ' السعر
        Else
            e.Graphics.DrawString(Test_1TextBox.Text & " KD ", fontTextSize, Brushes.Black, Qult_rightTextBox.Text, Qult_right1upTextBox.Text) ' اليمني السعر
        End If

        e.Graphics.DrawString(SarualTextBox.Text, fontCompanyTextSize, Brushes.Black, Sarual_rightTextBox.Text, Sarual_right1upTextBox.Text) 'اليمني السريال نمبر
        e.Graphics.DrawString(Val_goldTextBox.Text.ToString, fontTextSize, Brushes.Black, Val_gold_rightTextBox.Text, Val_gold_right1upTextBox.Text) 'اليمني عيار الذهب
        e.Graphics.DrawString(GOLD_mezanTextBox.Text, fontTextSize, Brushes.Black, GOLD_mezan_rightTextBox.Text, GOLD_mezan_right1upTextBox.Text) 'وزن الذهب اليمني 
        e.Graphics.DrawString(Test_11TextBox.Text, fontCompanyTextSize, Brushes.Black, Test_11_left1upTextBox.Text, Test_11_rightTextBox.Text) 'القص اليمني 
        e.Graphics.DrawString(cmbCompanyName.Text, fontCompanyTextSize, Brushes.Black, Note1upTextBox.Text, Note21upTextBox.Text) 'اليمني السم المعرض
        e.Graphics.DrawString(Test_14TextBox.Text, fontStoneTextSize, Brushes.Black, RightValueLRStoneName1.Text, RightValueUDStoneName1.Text) 'نوع الحجر1
        e.Graphics.DrawString(Test_13TextBox.Text, fontStoneTextSize, Brushes.Black, RightValueLRStoneWeight1.Text, RightValueUDStoneWeight1.Text) 'وزن الحجر1
        e.Graphics.DrawString(Cut1TextBox.Text, fontStoneTextSize, Brushes.Black, Cut1_RightupTextBox.Text, Cut1_Right1upTextBox.Text) 'قصة الحجر1
        e.Graphics.DrawString(Test_17TextBox.Text, fontStoneTextSize, Brushes.Black, RightValueLRStoneName2.Text, RightValueUDStoneName2.Text) 'نوع الحجر2
        e.Graphics.DrawString(Test_16TextBox.Text, fontStoneTextSize, Brushes.Black, RightValueLRStoneWeight2.Text, RightValueUDStoneWeight2.Text) 'وزن الحجر2
        e.Graphics.DrawString(Cut2TextBox.Text, fontStoneTextSize, Brushes.Black, Cut2_RightupTextBox.Text, Cut2_Right1upTextBox.Text) 'قصة الحجر2
        e.Graphics.DrawString(Test_110TextBox.Text, fontStoneTextSize, Brushes.Black, RightValueLRStoneName3.Text, RightValueUDStoneName3.Text) 'نوع الحجر3
        e.Graphics.DrawString(Test_19TextBox.Text, fontStoneTextSize, Brushes.Black, RightValueLRStoneWeight3.Text, RightValueUDStoneWeight3.Text) 'وزن الحجر3
        e.Graphics.DrawString(Cut3TextBox.Text, fontStoneTextSize, Brushes.Black, Cut3_RightupTextBox.Text, Cut3_Right1upTextBox.Text) 'قصة الحجر3
        e.Graphics.DrawString(Test_115TextBox.Text, fontCode, Brushes.Black, Code_RightupTextBox.Text, Code_Right1upTextBox.Text) 'الرمز
        Dim TotalStoneWeightRight As Decimal
        TotalStoneWeightRight = Math.Round(Val(DIMO_mezanTextBox.Text) + Val(Test_13TextBox.Text) + Val(Test_16TextBox.Text) + Val(Test_19TextBox.Text), 2)
        e.Graphics.DrawString(TotalStoneWeightRight, fontCode, Brushes.Black, TotalStoneWeight_RightupTextBox.Text, TotalStoneWeight_Right1upTextBox.Text) 'وزن إجمالي للفصوص

        'مسميات الحقول يسار
        e.Graphics.DrawString(SET_INVARCHR115TextBox.Text, fontTextSize, Brushes.Black, Test_13_left1upTextBox.Text, Test_112_left1upTextBox.Text) 'اسم الصنف الجهة يسار
        e.Graphics.DrawString(SET_INVARCHR116TextBox.Text, fontTextSize, Brushes.Black, Test_14_left1upTextBox.Text, Test_113_left1upTextBox.Text) 'النقاوه الجهة يسار
        e.Graphics.DrawString(SET_INVARCHR121TextBox.Text, fontTextSize, Brushes.Black, Test_15_left1upTextBox.Text, Test_114_left1upTextBox.Text) '  يساراليمني قيراط الالماس
        e.Graphics.DrawString(SET_INVARCHR117TextBox.Text, fontTextSize, Brushes.Black, Test_16_left1upTextBox.Text, Test_115_left1upTextBox.Text) 'يسار اليمني اللون
        e.Graphics.DrawString(SET_INVARCHR123TextBox.Text, fontTextSize, Brushes.Black, Test_17_left1upTextBox.Text, Test_116_left1upTextBox.Text) ' يسار اليمني عيار الذهب
        e.Graphics.DrawString(SET_INVARCHR122TextBox.Text, fontTextSize, Brushes.Black, Test_18_left1upTextBox.Text, Test_117_left1upTextBox.Text) 'وزن الذهب  يسار  
        e.Graphics.DrawString(SET_INVARCHR120TextBox.Text, fontTextSize, Brushes.Black, Test_19_left1upTextBox.Text, Test_118_left1upTextBox.Text) 'السعر يسار 
        e.Graphics.DrawString(SET_INVARCHR130TextBox.Text, fontTextSize, Brushes.Black, LeftTextLRStoneName1.Text, LeftTextUDStoneName1.Text) 'نوع الحجر1 يسار 
        e.Graphics.DrawString(If(Test_112TextBox1.Text = "1", "gm", "ct"), fontTextSize, Brushes.Black, LeftTextLRStoneWeight1.Text, LeftTextUDStoneWeight1.Text) 'وزن الحجر1 يسار 
        e.Graphics.DrawString(SET_INVARCHR130TextBox.Text, fontTextSize, Brushes.Black, LeftTextLRStoneName2.Text, LeftTextUDStoneName2.Text) 'نوع الحجر2 يسار 
        e.Graphics.DrawString(If(Test_113TextBox1.Text = "1", "gm", "ct"), fontTextSize, Brushes.Black, LeftTextLRStoneWeight2.Text, LeftTextUDStoneWeight2.Text) 'وزن الحجر2 يسار 
        e.Graphics.DrawString(SET_INVARCHR130TextBox.Text, fontTextSize, Brushes.Black, LeftTextLRStoneName3.Text, LeftTextUDStoneName3.Text) 'نوع الحجر3 يسار 
        e.Graphics.DrawString(If(Test_114TextBox1.Text = "1", "gm", "ct"), fontTextSize, Brushes.Black, LeftTextLRStoneWeight3.Text, LeftTextUDStoneWeight3.Text) 'وزن الحجر3 يسار 
        e.Graphics.DrawString(SET_INVARCHR113TextBox.Text.ToString, fontCompanyTextSize, Brushes.Black, Test_110_left1upTextBox.Text, Test_119_left1upTextBox.Text) 'رقم القطعة يسار 


        'مسميات الحقول اليمني
        e.Graphics.DrawString(SET_INVARCHR115Text.Text, fontTextSize, Brushes.Black, Test_112_right1upTextBox.Text, Test_111_right1upTextBox.Text) 'اسم الصنف الجه اليمني
        e.Graphics.DrawString(SET_INVARCHR116Text.Text, fontTextSize, Brushes.Black, Test_11_right1upTextBox.Text, Test_119_right1upTextBox.Text) 'النقاوه الجه اليمني
        e.Graphics.DrawString(SET_INVARCHR121Text.Text, fontTextSize, Brushes.Black, Test_12_right1upTextBox.Text, Test_118_right1upTextBox.Text) '  اليمني  اليمني قيراط الالماس
        e.Graphics.DrawString(SET_INVARCHR117Text.Text, fontTextSize, Brushes.Black, Test_13_right1upTextBox.Text, Test_111_left1upTextBox1.Text) 'اليمني اليمني اللون
        e.Graphics.DrawString(SET_INVARCHR123Text.Text, fontTextSize, Brushes.Black, Test_14_right1upTextBox.Text, Test_117_right1upTextBox.Text) ' اليمني اليمني عيار الذهب
        e.Graphics.DrawString(SET_INVARCHR122Text.Text, fontTextSize, Brushes.Black, Test_15_right1upTextBox.Text, Test_116_right1upTextBox.Text) 'وزن الذهب اليمني اليمني  
        e.Graphics.DrawString(SET_INVARCHR120Text.Text, fontTextSize, Brushes.Black, Test_16_right1upTextBox.Text, Test_115_right1upTextBox.Text) 'السعر اليمني 
        e.Graphics.DrawString(SET_INVARCHR130TextBox.Text, fontStoneTextSize, Brushes.Black, RightTextLRStoneName1.Text, RightTextUDStoneName1.Text) 'نوع الحجر1 يمين 
        e.Graphics.DrawString(If(Test_112TextBox.Text = "1", "gm", "ct"), fontStoneTextSize, Brushes.Black, RightTextLRStoneWeight1.Text, RightTextUDStoneWeight1.Text) 'وزن الحجر1 يمين 
        e.Graphics.DrawString(SET_INVARCHR130TextBox.Text, fontStoneTextSize, Brushes.Black, RightTextLRStoneName2.Text, RightTextUDStoneName2.Text) 'نوع الحجر2 يمين 
        e.Graphics.DrawString(If(Test_113TextBox.Text = "1", "gm", "ct"), fontStoneTextSize, Brushes.Black, RightTextLRStoneWeight2.Text, RightTextUDStoneWeight2.Text) 'وزن الحجر2 يمين 
        e.Graphics.DrawString(SET_INVARCHR130TextBox.Text, fontStoneTextSize, Brushes.Black, RightTextLRStoneName3.Text, RightTextUDStoneName3.Text) 'نوع الحجر3 يمين 
        e.Graphics.DrawString(If(Test_114TextBox.Text = "1", "gm", "ct"), fontStoneTextSize, Brushes.Black, RightTextLRStoneWeight3.Text, RightTextUDStoneWeight3.Text) 'وزن الحجر3 يمين 
        e.Graphics.DrawString(SET_INVARCHR113Text.Text, fontCompanyTextSize, Brushes.Black, Test_114_left1upTextBox.Text, Test_113_right1upTextBox.Text) 'رقم القطعه اليمني 


        'اضافات الباركود
        e.Graphics.DrawString(SET_INVARCHR124TextBox.Text, fontGoldSAP, Brushes.Black, Test_110_right1upTextBox.Text, Program_name1upTextBox.Text) 'اسم البرنامج
        e.Graphics.DrawString(SET_INVARCHR125TextBox.Text, fontTelephone, Brushes.Black, Test_119_rightTextBox.Text, Test_118_rightTextBox.Text) 'الدعم الفني
        e.Graphics.DrawString(SET_INVARCHR126TextBox.Text, fontTelephone, Brushes.Black, TelTextBox1.Text, Test_17_right1upTextBox.Text) '  رقم الدعم1
        e.Graphics.DrawString(SET_INVARCHR127TextBox.Text, fontTelephone, Brushes.Black, Program_nameTextBox2.Text, Tel1upTextBox.Text) 'رقم الدعم2

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        If chkPrintRange.Checked = False Then
            If My.Computer.Keyboard.CtrlKeyDown Then
                PrintBarCodeDiamondPreview()
            Else
                PrintBarCodeDiamond()
            End If
        ElseIf chkPrintRange.Checked = True Then
            print_aut()
        End If
    End Sub
    Public Sub print_aut()
        If cmbPrintRange.Text = "تنتهي الطباعة عند" Then
            MsgBox("حدد انتهاء الطباعة" & vbCrLf & "Select the end of printing.", , Apptitle)
            Exit Sub
        End If
        If chkPrintRange.Checked = False Then
            If My.Computer.Keyboard.CtrlKeyDown Then
                PrintBarCodeDiamondPreview()
            Else
                PrintBarCodeDiamond()
            End If
        ElseIf chkPrintRange.Checked = True Then
            If My.Computer.Keyboard.CtrlKeyDown Then
                PrintBarCodeDiamondPreview()
            Else
                PrintBarCodeDiamond()
            End If
            Do While -1
                DIMONBARICOODFORSELECTLEFTBindingSource.MoveNext()
                DIMONBARICOODFORSELECTLEFTBindingSource.MoveNext()
                DIMONBARICOODSELECTRIGHTBindingSource.MoveNext()
                DIMONBARICOODSELECTRIGHTBindingSource.MoveNext()
                PrintBarCodeDiamond()
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
    Private Sub COM_BOX_GET_DATA()
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
        Sqlcmd_COM_BOX.CommandText = "SELECT DIMON_NAME FROM DIMON_BARICOOD_LEFT"
        D_Rea = Sqlcmd_COM_BOX.ExecuteReader
        D_Table_COM_BOX.Load(D_Rea)
        D_Rea.Close()
        sqlcon_COM_BOX.Close()
        For i As Integer = 0 To D_Table_COM_BOX.Rows.Count - 1
            cmbPrintRange.Items.Add(D_Table_COM_BOX.Rows(i)("DIMON_NAME").ToString)
        Next
    End Sub
    Private Sub Cop_select_val_Click(sender As Object, e As EventArgs) Handles cmbPrintRange.Click
        COM_BOX_GET_DATA()
    End Sub

    Private Sub pbHLeftValue_DoubleClick(sender As Object, e As EventArgs) Handles pbHLeftValue.DoubleClick

        Test_1_leftTextBox.Text = Val(DIMOND_ID_leftTextBox.Text) + 10
        Qult_leftTextBox.Text = DIMOND_ID_leftTextBox.Text
        Val_gold_leftTextBox.Text = DIMOND_ID_leftTextBox.Text

        DIMO_mezan_leftTextBox.Text = Ext_coler_leftTextBox.Text
        DIM_na9awa_leftTextBox.Text = Ext_coler_leftTextBox.Text
        GOLD_mezan_leftTextBox.Text = Ext_coler_leftTextBox.Text
    End Sub

    Private Sub pbHRightValue_DoubleClick(sender As Object, e As EventArgs) Handles pbHRightValue.DoubleClick

        Test_12_left1upTextBox.Text = Val(DIMOND_ID_rightTextBox.Text) + 10
        Qult_rightTextBox.Text = DIMOND_ID_rightTextBox.Text
        Val_gold_rightTextBox.Text = DIMOND_ID_rightTextBox.Text

        DIMO_mezan_rightTextBox.Text = Ext_coler_rightTextBox.Text
        DIM_na9awa_rightTextBox.Text = Ext_coler_rightTextBox.Text
        GOLD_mezan_rightTextBox.Text = Ext_coler_rightTextBox.Text
    End Sub

    Private Sub pbVLeftValue_DoubleClick(sender As Object, e As EventArgs) Handles pbVLeftValue.DoubleClick
        Test_1_left1upTextBox.Text = Val(DIMOND_ID_left1upTextBox.Text) + 10
        Qult_left1upTextBox.Text = Val(DIMOND_ID_left1upTextBox.Text) + 20
        Val_gold_left1upTextBox.Text = Val(DIMOND_ID_left1upTextBox.Text) + 30


        DIMO_mezan_left1upTextBox.Text = Val(Ext_coler_left1upTextBox.Text) + 10
        DIM_na9awa_left1upTextBox.Text = Val(Ext_coler_left1upTextBox.Text) + 20
        GOLD_mezan_left1upTextBox.Text = Val(Ext_coler_left1upTextBox.Text) + 30

    End Sub

    Private Sub pbVrightValue_DoubleClick(sender As Object, e As EventArgs) Handles pbVRightValue.DoubleClick
        Test_1_right1upTextBox.Text = Val(DIMOND_ID_right1upTextBox.Text) + 10
        Qult_right1upTextBox.Text = Val(DIMOND_ID_right1upTextBox.Text) + 20
        Val_gold_right1upTextBox.Text = Val(DIMOND_ID_right1upTextBox.Text) + 30


        DIMO_mezan_right1upTextBox.Text = Val(Ext_coler_right1upTextBox.Text) + 10
        DIM_na9awa_right1upTextBox.Text = Val(Ext_coler_right1upTextBox.Text) + 20
        GOLD_mezan_right1upTextBox.Text = Val(Ext_coler_right1upTextBox.Text) + 30

    End Sub

    Private Sub pbHLeftText_DoubleClick(sender As Object, e As EventArgs) Handles pbHLeftText.DoubleClick
        DIMO_dep_leftTextBox.Text = Val(Test_12_leftTextBox.Text) + 50
        NoteTextBox1.Text = Val(Test_12_leftTextBox.Text) + 100

        Test_17_left1upTextBox.Text = Test_19_left1upTextBox.Text

        Test_15_left1upTextBox.Text = Test_16_left1upTextBox.Text
        Test_14_left1upTextBox.Text = Test_16_left1upTextBox.Text
        Test_18_left1upTextBox.Text = Test_16_left1upTextBox.Text
    End Sub

    Private Sub pbVLeftText_DoubleClick(sender As Object, e As EventArgs) Handles pbVLeftText.DoubleClick
        DIMO_dep_left1upTextBox.Text = Test_1_rightTextBox1.Text
        Note2TextBox1.Text = Test_1_rightTextBox1.Text

        Test_118_left1upTextBox.Text = Qult_left1upTextBox.Text
        Test_116_left1upTextBox.Text = Val(Test_118_left1upTextBox.Text) + 10

        Test_115_left1upTextBox.Text = Ext_coler_left1upTextBox.Text
        Test_114_left1upTextBox.Text = Val(Ext_coler_left1upTextBox.Text) + 10
        Test_113_left1upTextBox.Text = Val(Ext_coler_left1upTextBox.Text) + 20
        Test_117_left1upTextBox.Text = Val(Ext_coler_left1upTextBox.Text) + 30
    End Sub

    Private Sub pbHrightText_DoubleClick(sender As Object, e As EventArgs) Handles pbHRightText.DoubleClick
        DIMO_dep_rightTextBox.Text = Val(Test_11_left1upTextBox.Text) - 50
        Note1upTextBox.Text = Val(Test_11_left1upTextBox.Text) - 100

        Test_14_right1upTextBox.Text = Test_16_right1upTextBox.Text

        Test_12_right1upTextBox.Text = Test_13_right1upTextBox.Text
        Test_11_right1upTextBox.Text = Test_13_right1upTextBox.Text
        Test_15_right1upTextBox.Text = Test_13_right1upTextBox.Text
    End Sub

    Private Sub pbVrightText_DoubleClick(sender As Object, e As EventArgs) Handles pbVRightText.DoubleClick
        DIMO_dep_right1upTextBox.Text = Test_11_rightTextBox.Text
        Note21upTextBox.Text = Test_11_rightTextBox.Text

        Test_115_right1upTextBox.Text = Qult_right1upTextBox.Text
        Test_117_right1upTextBox.Text = Val(Test_115_right1upTextBox.Text) + 10

        Test_111_left1upTextBox1.Text = Ext_coler_right1upTextBox.Text
        Test_118_right1upTextBox.Text = Val(Ext_coler_right1upTextBox.Text) + 10
        Test_119_right1upTextBox.Text = Val(Ext_coler_right1upTextBox.Text) + 20
        Test_116_right1upTextBox.Text = Val(Ext_coler_right1upTextBox.Text) + 30
    End Sub
    Public Sub PrintBarCodeDiamond()
        Try
            For x As Integer = 1 To txtQty.Text
                ValidateChildren()
                CONFI_barcood_dimonBindingSource.EndEdit()
                CONFI_barcood_dimonTableAdapter.Update(DT_restrantDataSet.CONFI_barcood_dimon)
                CONFI_barcood_dimonTableAdapter.Fill(DT_restrantDataSet.CONFI_barcood_dimon)
                PrintDialog1.PrinterSettings.PrinterName = Print_nameTextBox.Text
                PrintDocument1.Print()
            Next

        Catch ex As Exception
            MsgBox("خطأ في إدخال قيم ضبط الباركود" & vbCrLf & "Error in BarCode Data", , Apptitle)
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Private Sub PrintBarCodeDiamondPreview()
        ValidateChildren()
        CONFI_barcood_dimonBindingSource.EndEdit()
        CONFI_barcood_dimonTableAdapter.Update(DT_restrantDataSet.CONFI_barcood_dimon)
        CONFI_barcood_dimonTableAdapter.Fill(DT_restrantDataSet.CONFI_barcood_dimon)
        With PrintPreviewDialog1
            .Size = New Size(750, 400)
            .StartPosition = FormStartPosition.CenterScreen
            .Document = PrintDocument1
            .PrintPreviewControl.Zoom = 2
            .ShowDialog()
        End With
    End Sub
    Private Sub cmbRightItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRightItem.SelectedIndexChanged
        DIMON_BARICOOD_LEFTTableAdapter.FillByBarCodeString(DT_restrantDataSet.DIMON_BARICOOD_LEFT, cmbRightItem.SelectedValue)
    End Sub

    Private Sub cmbLeftItem_SSelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLeftItem.SelectedIndexChanged
        DIMON_BARICOOD_RIGHTTableAdapter.FillByBarCodeString(DT_restrantDataSet.DIMON_BARICOOD_RIGHT, cmbLeftItem.SelectedValue)

    End Sub

    Private Sub txtBarCodeLeft_TextChanged(sender As Object, e As EventArgs) Handles txtBarCodeLeft.TextChanged
        cmbLeftItem.SelectedValue = txtBarCodeLeft.Text.Trim
    End Sub

    Private Sub txtBarCodeRight_TextChanged(sender As Object, e As EventArgs) Handles txtBarCodeRight.TextChanged
        cmbRightItem.SelectedValue = txtBarCodeRight.Text.Trim
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnl.Paint

    End Sub

    Private Sub btnDefaults_Click(sender As Object, e As EventArgs) Handles btnDefaults.Click
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

    Private Sub chkPrintRange_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrintRange.CheckedChanged
        cmbPrintRange.Enabled = chkPrintRange.Checked
    End Sub

    Private Sub cmbPrintRange_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrintRange.SelectedIndexChanged

    End Sub
End Class