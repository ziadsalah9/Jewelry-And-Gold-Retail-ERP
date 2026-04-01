
Public Class AccessoriesBarCode
    Dim BarCodeFont As Font
    Dim DataTextFont As Font
    Dim CompanyTextFont As Font
    Dim BarCodeNoFont As Font
    Dim ArabicOtherTextFont As New Font("Arial", 12, FontStyle.Italic)
    Dim EnglishOtherTextFont As New Font("Arial", 10, FontStyle.Bold)
    Private Sub AccessoriesBarCode_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub SetFontSize()
        'Dim fontSize As Single = If(IsNumeric(TextBoxFontSize.Text), CSng(TextBoxFontSize.Text), 12)
        CompanyTextFont = New Font("Arial", CSng(CompanyTextFontValueTextBox.Text), GetFontStyle(CompanyTextFontStyleTextBox.Text))
        BarCodeFont = New Font("3 of 9 Barcode", CSng(BarCodeFontValueTextBox.Text), GetFontStyle(BarCodeFontStyleTextBox.Text))
        BarCodeNoFont = New Font("Arial", CSng(BarCodeNoFontValueTextBox.Text), GetFontStyle(BarCodeNoFontStyleTextBox.Text))
        DataTextFont = New Font("Arial", CSng(DataTextFontValueTextBox.Text), GetFontStyle(DataTextFontStyleTextBox.Text))
    End Sub
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
    Private Sub AccessoriesBarCode_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        AccessoriesBarCode1TableAdapter.Fill(DT_restrantDataSet.AccessoriesBarCode1)
        AccessoriesBarCode2TableAdapter.Fill(DT_restrantDataSet.AccessoriesBarCode2)
        Comp_informTableAdapter.Fill(DT_restrantDataSet.comp_inform)
        Accessories_BarcodeConfigTableAdapter.Fill(DT_restrantDataSet.Accessories_BarcodeConfig)

        TextBox1.Text = "1"
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If NewForm = True Then
            AccessoriesBarCode1BindingSource.MoveLast()
            AccessoriesBarCode2BindingSource.MoveLast()
            AccessoriesBarCode1BindingSource.MovePrevious()
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If Print_setTextBox.Text.Trim <> "" Then
            cmbPrinter.Text = Print_setTextBox.Text.Trim
        End If
        min_BarCode.Hide()
        Try
            SetFontSize()
        Catch ex As Exception
            btnDefaults.PerformClick()
            btnSave.PerformClick()
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            PrintBarCodePreview()
        Else
            PrintBarCode()
        End If

    End Sub
    Private Sub PrintBarCodePreview()
        ValidateChildren()
        Acc_BCBindingSource.EndEdit()
        Accessories_BarcodeConfigTableAdapter.Update(DT_restrantDataSet.Accessories_BarcodeConfig)
        Accessories_BarcodeConfigTableAdapter.Fill(DT_restrantDataSet.Accessories_BarcodeConfig)
        With PrintPreviewDialog1
            .Size = New Size(750, 400)
            .StartPosition = FormStartPosition.CenterScreen
            .Document = PrintDocument1
            .PrintPreviewControl.Zoom = 2
            .ShowDialog()
        End With
    End Sub
    Public Sub PrintBarCode()
        If IsNumeric(TextBox1.Text.Trim) = False Then
            MsgBox("أدخل عدد ملصقات صحيح" & vbCrLf & "Enter Valid Label Qty.", , Apptitle)
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        End If
        Try
            For x As Integer = 1 To TextBox1.Text
                ValidateChildren()
                Acc_BCBindingSource.EndEdit()
                Accessories_BarcodeConfigTableAdapter.Update(DT_restrantDataSet.Accessories_BarcodeConfig)
                Accessories_BarcodeConfigTableAdapter.Fill(DT_restrantDataSet.Accessories_BarcodeConfig)
                PrintDialog1.PrinterSettings.PrinterName = Print_setTextBox.Text
                PrintDocument1.Print()
            Next
        Catch ex As Exception
            MsgBox("خطأ في إدخال قيم ضبط الباركود" & vbCrLf & "Error in BarCode Data", , Apptitle)
            'Next
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ''الجهة اليمني من الباركود
        e.Graphics.DrawString("*" & IDtxt1.Text & "*", BarCodeFont, Brushes.Black, L_IDTextBox_DTextBox.Text, L_IDTextBox_UTextBox.Text) ''الباركود الجهة اليمن
        e.Graphics.DrawString("KD" & Pricetxt1.Text, DataTextFont, Brushes.Black, L_FO_madeTextBox_DTextBox.Text, L_FO_madeTextBox_UTextBox.Text) ''السعر
        e.Graphics.DrawString(IDtxt1.Text, BarCodeNoFont, Brushes.Black, L_font_IDTextBox_DTextBox.Text, L_font_IDTextBox_UTextBox.Text) ''رقم الباركود الجهة اليمن
        e.Graphics.DrawString(cmbCompany.Text, CompanyTextFont, Brushes.Black, L_ComboBox3_DTextBox.Text, L_ComboBox3_UTextBox.Text) '' اسم الشركه الجهة اليمني

        e.Graphics.DrawString(":النوع", DataTextFont, Brushes.Black, L_W_DTextBox.Text, L_W_UTextBox.Text) ''النوع
        e.Graphics.DrawString(":الماركة", DataTextFont, Brushes.Black, L_M_DTextBox.Text, L_M_UTextBox.Text) ''الماركة
        e.Graphics.DrawString(":رقم", DataTextFont, Brushes.Black, L_C_DTextBox.Text, L_C_UTextBox.Text) '' الرقم
        e.Graphics.DrawString(":موديل", DataTextFont, Brushes.Black, L_S_DTextBox.Text, L_S_UTextBox.Text) ''السيريال
        e.Graphics.DrawString(":رمز", DataTextFont, Brushes.Black, txtCodeTextRD.Text, txtCodeTextRU.Text) ''الرمز
        e.Graphics.DrawString(":سنة", DataTextFont, Brushes.Black, txtYearTextRD.Text, txtYearTextRU.Text) ''السنة
        e.Graphics.DrawString(":مزود", DataTextFont, Brushes.Black, txtSupplierTextRD.Text, txtSupplierTextRU.Text) ''مزود
        e.Graphics.DrawString(":مرفق", DataTextFont, Brushes.Black, txtAttachmentTextRD.Text, txtAttachmentTextRU.Text) ''مرفق

        e.Graphics.DrawString(Nametxt1.Text, DataTextFont, Brushes.Black, L_FO_gramTextBox_DTextBox.Text, L_FO_gramTextBox_UTextBox.Text) ''النوع
        e.Graphics.DrawString(BrandShorttxt1.Text, DataTextFont, Brushes.Black, L_FO_gramMadeTextBox_DTextBox.Text, L_FO_gramMadeTextBox_UTextBox.Text) ''الماركة
        e.Graphics.DrawString(Notxt1.Text, DataTextFont, Brushes.Black, L_Gram_valuTextBox_DTextBox.Text, L_Gram_valuTextBox_UTextBox.Text) ''الرقم
        e.Graphics.DrawString(Serialtxt1.Text, DataTextFont, Brushes.Black, L_FO_extrasTextBox_DTextBox.Text, L_FO_extrasTextBox_UTextBox.Text) '' الموديل
        e.Graphics.DrawString(CodeTextBox1.Text, DataTextFont, Brushes.Black, txtCodeValueRD.Text, txtCodeValueRU.Text) ''الرمز
        e.Graphics.DrawString(YearTextBox1.Text, DataTextFont, Brushes.Black, txtYearValueRD.Text, txtYearValueRU.Text) '' السنة
        e.Graphics.DrawString(SupplierTextBox1.Text, DataTextFont, Brushes.Black, txtSupplierValueRD.Text, txtSupplierValueRU.Text) '' مزود
        e.Graphics.DrawString(AttachmentsTextBox1.Text, DataTextFont, Brushes.Black, txtAttachmentValueRD.Text, txtAttachmentValueRU.Text) '' مرفق

        ' ''الجهة اليسري من الباركود
        ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        e.Graphics.DrawString("*" & IDtxt2.Text & "*", BarCodeFont, Brushes.Black, R_IDTextBox_DTextBox.Text, R_IDTextBox_UTextBox.Text) ''الباركود الجهة اليسري
        e.Graphics.DrawString("KD" & Pricetxt2.Text, DataTextFont, Brushes.Black, R_FO_madeTextBox_DTextBox.Text, R_FO_madeTextBox_UTextBox.Text) ''اسم المورد / الشركه
        e.Graphics.DrawString(IDtxt2.Text, BarCodeNoFont, Brushes.Black, R_font_IDTextBox_DTextBox.Text, R_font_IDTextBox_UTextBox.Text) ''رقم الباركود الجهة اليسري
        e.Graphics.DrawString(cmbCompany.Text, CompanyTextFont, Brushes.Black, R_ComboBox3_DTextBox.Text, R_ComboBox3_UTextBox.Text) '' اسم الشركه الجهة اليسري

        e.Graphics.DrawString(":النوع", DataTextFont, Brushes.Black, R_W_DTextBox.Text, R_W_UTextBox.Text) ''اليسري النوع
        e.Graphics.DrawString(":الماركة", DataTextFont, Brushes.Black, R_M_DTextBox.Text, R_M_UTextBox.Text) ''اليسري الماركة
        e.Graphics.DrawString(":رقم", DataTextFont, Brushes.Black, R_C_DTextBox.Text, R_C_UTextBox.Text) ''  اليسري الرقم
        e.Graphics.DrawString(":موديل", DataTextFont, Brushes.Black, R_S_DTextBox.Text, R_S_UTextBox.Text) ''  اليسري الموديل
        e.Graphics.DrawString(":رمز", DataTextFont, Brushes.Black, txtCodeTextLD.Text, txtCodeTextLU.Text) ''الرمز
        e.Graphics.DrawString(":سنة", DataTextFont, Brushes.Black, txtYearTextLD.Text, txtYearTextLU.Text) ''السنة
        e.Graphics.DrawString(":مزود", DataTextFont, Brushes.Black, txtSupplierTextLD.Text, txtSupplierTextLU.Text) ''مزود
        e.Graphics.DrawString(":مرفق", DataTextFont, Brushes.Black, txtAttachmentTextLD.Text, txtAttachmentTextLU.Text) ''مرفق

        e.Graphics.DrawString(Nametxt2.Text, DataTextFont, Brushes.Black, R_FO_gramTextBox_DTextBox.Text, R_FO_gramTextBox_UTextBox.Text) ''اليسري النوع
        e.Graphics.DrawString(BrandShorttxt2.Text, DataTextFont, Brushes.Black, R_FO_gramMadeTextBox_DTextBox.Text, R_FO_gramMadeTextBox_UTextBox.Text) ''رقم االماركة 
        e.Graphics.DrawString(Notxt2.Text, DataTextFont, Brushes.Black, R_Gram_valuTextBox_DTextBox.Text, R_Gram_valuTextBox_UTextBox.Text) ''رقم االرقم
        e.Graphics.DrawString(Serialtxt2.Text, DataTextFont, Brushes.Black, R_FO_extrasTextBox_DTextBox.Text, R_FO_extrasTextBox_UTextBox.Text) '' اليسري السيريال
        e.Graphics.DrawString(CodeTextBox2.Text, DataTextFont, Brushes.Black, txtCodeValueLD.Text, txtCodeValueLU.Text) ''الرمز
        e.Graphics.DrawString(YearTextBox2.Text, DataTextFont, Brushes.Black, txtYearValueLD.Text, txtYearValueLU.Text) '' السنة
        e.Graphics.DrawString(SupplierTextBox2.Text, DataTextFont, Brushes.Black, txtSupplierValueLD.Text, txtSupplierValueLU.Text) '' مزود
        e.Graphics.DrawString(AttachmentsTextBox2.Text, DataTextFont, Brushes.Black, txtAttachmentValueLD.Text, txtAttachmentValueLU.Text) '' مرفق

        e.Graphics.DrawString("ساب للحلول البرمجية", ArabicOtherTextFont, Brushes.Black, سبايكdTextBox.Text, سبايكuTextBox.Text) ''سبائك الكويت
        e.Graphics.DrawString("SAP", EnglishOtherTextFont, Brushes.Black, ويبdTextBox.Text, ويبuTextBox.Text) ''الموقع
        e.Graphics.DrawString("Gold SAP", EnglishOtherTextFont, Brushes.Black, باركود_ويبdTextBox.Text, باركود_ويبuTextBox.Text) 'سبائك الكويت
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
                Acc_BCBindingSource.EndEdit()
                Accessories_BarcodeConfigTableAdapter.Update(DT_restrantDataSet.Accessories_BarcodeConfig)
                Accessories_BarcodeConfigTableAdapter.Fill(DT_restrantDataSet.Accessories_BarcodeConfig)
                SetFontSize()
            MsgBox("تم حفظ الإعدادات بنجاح" & vbCrLf & "Setting Saved Successfully", , AppTitle)
            Catch ex As Exception
            MsgBox("خطأ في الإعدادات النصية" & vbCrLf & "Error in Settings Data", , AppTitle)
            End Try
        End If
    End Sub

    Private Sub pbHLeftValue_DoubleClick(sender As Object, e As EventArgs) Handles pbHLeftValue.DoubleClick
        R_FO_gramMadeTextBox_DTextBox.Text = R_FO_gramTextBox_DTextBox.Text
        R_Gram_valuTextBox_DTextBox.Text = R_FO_gramTextBox_DTextBox.Text
        R_FO_extrasTextBox_DTextBox.Text = R_FO_gramTextBox_DTextBox.Text
    End Sub
    Private Sub pbVLeftValue_DoubleClick(sender As Object, e As EventArgs) Handles pbVLeftValue.DoubleClick
        R_FO_gramMadeTextBox_UTextBox.Text = Val(R_FO_gramTextBox_UTextBox.Text) + 10
        R_Gram_valuTextBox_UTextBox.Text = Val(R_FO_gramTextBox_UTextBox.Text) + 20
        R_FO_extrasTextBox_UTextBox.Text = Val(R_FO_gramTextBox_UTextBox.Text) + 30
    End Sub

    Private Sub pbHLeftText_DoubleClick(sender As Object, e As EventArgs) Handles pbHLeftText.DoubleClick
        R_font_IDTextBox_DTextBox.Text = R_FO_madeTextBox_DTextBox.Text
        R_IDTextBox_DTextBox.Text = Val(R_FO_madeTextBox_DTextBox.Text) - 10
        R_M_DTextBox.Text = R_W_DTextBox.Text
        R_C_DTextBox.Text = R_W_DTextBox.Text
        R_S_DTextBox.Text = R_W_DTextBox.Text
    End Sub

    Private Sub pbVLeftText_DoubleClick(sender As Object, e As EventArgs) Handles pbVLeftText.DoubleClick
        R_IDTextBox_UTextBox.Text = Val(R_FO_madeTextBox_UTextBox.Text) + 15
        R_font_IDTextBox_UTextBox.Text = Val(R_FO_madeTextBox_UTextBox.Text) + 25
        R_M_UTextBox.Text = Val(R_W_UTextBox.Text) + 10
        R_C_UTextBox.Text = Val(R_W_UTextBox.Text) + 20
        R_S_UTextBox.Text = Val(R_W_UTextBox.Text) + 30
    End Sub

    Private Sub pbHRightValue_DoubleClick(sender As Object, e As EventArgs) Handles pbHRightValue.DoubleClick
        L_FO_gramMadeTextBox_DTextBox.Text = L_FO_gramTextBox_DTextBox.Text
        L_Gram_valuTextBox_DTextBox.Text = L_FO_gramTextBox_DTextBox.Text
        L_FO_extrasTextBox_DTextBox.Text = L_FO_gramTextBox_DTextBox.Text
    End Sub

    Private Sub pbVRightValue_DoubleClick(sender As Object, e As EventArgs) Handles pbVRightValue.DoubleClick
        L_FO_gramMadeTextBox_UTextBox.Text = Val(L_FO_gramTextBox_UTextBox.Text) + 10
        L_Gram_valuTextBox_UTextBox.Text = Val(L_FO_gramTextBox_UTextBox.Text) + 20
        L_FO_extrasTextBox_UTextBox.Text = Val(L_FO_gramTextBox_UTextBox.Text) + 30
    End Sub

    Private Sub pbHRightText_DoubleClick(sender As Object, e As EventArgs) Handles pbHRightText.DoubleClick
        L_font_IDTextBox_DTextBox.Text = L_FO_madeTextBox_DTextBox.Text
        L_IDTextBox_DTextBox.Text = Val(L_FO_madeTextBox_DTextBox.Text) - 10
        L_M_DTextBox.Text = L_W_DTextBox.Text
        L_C_DTextBox.Text = L_W_DTextBox.Text
        L_S_DTextBox.Text = L_W_DTextBox.Text
    End Sub

    Private Sub pbVRightText_DoubleClick(sender As Object, e As EventArgs) Handles pbVRightText.DoubleClick
        L_IDTextBox_UTextBox.Text = Val(L_FO_madeTextBox_UTextBox.Text) + 15
        L_font_IDTextBox_UTextBox.Text = Val(L_FO_madeTextBox_UTextBox.Text) + 25
        L_M_UTextBox.Text = Val(L_W_UTextBox.Text) + 10
        L_C_UTextBox.Text = Val(L_W_UTextBox.Text) + 20
        L_S_UTextBox.Text = Val(L_W_UTextBox.Text) + 30
    End Sub

    Private Sub txtBarCodeRight_TextChanged(sender As Object, e As EventArgs) Handles txtBarCodeRight.TextChanged
        cmbRightItem.SelectedValue = txtBarCodeRight.Text.Trim
    End Sub

    Private Sub txtBarCodeLeft_TextChanged(sender As Object, e As EventArgs) Handles txtBarCodeLeft.TextChanged
        cmbLeftItem.SelectedValue = txtBarCodeLeft.Text.Trim
    End Sub

    Private Sub btnDefaults_Click(sender As Object, e As EventArgs) Handles btnDefaults.Click
        If My.Computer.Keyboard.CtrlKeyDown Then
            If MsgBox("ضبط الافتراضيات للكل؟" & vbCrLf & "Restore All Defaults?", vbYesNo) = vbYes Then
                SetDefaultFonts()
            End If
        Else
            If MsgBox("ضبط الافتراضيات؟" & vbCrLf & "Restore Defaults?", vbYesNo) = vbYes Then
                SetDefaultFonts()
            End If
        End If
    End Sub
    Private Sub SetDefaultFonts()
        On Error Resume Next
        GlCommand.CommandText = "DELETE FROM [DT_restrant].[dbo].[Accessories_BarcodeConfig]"
        GlCommand.ExecuteNonQuery()
        GlCommand.CommandText = "INSERT [dbo].[Accessories_BarcodeConfig] ([L_IDTextBox_U], [L_IDTextBox_D], [L_FO_madeTextBox_U]," & vbCrLf &
                                "[L_FO_madeTextBox_D], [L_font_IDTextBox_U], [L_font_IDTextBox_D], [L_ComboBox3_U], [L_ComboBox3_D], [L_FO_gramTextBox_U]," & vbCrLf &
                                "[L_FO_gramTextBox_D], [L_الوزن_U], [L_الوزن_D], [L_المصنعيه_U], [L_المصنعيه_D], [L_FO_gramMadeTextBox_U]," & vbCrLf &
                                "[L_FO_gramMadeTextBox_D], [L_Gram_valuTextBox_U], [L_Gram_valuTextBox_D], [L_العيار_U], [L_العيار_D], [L_FO_extrasTextBox_U]," & vbCrLf &
                                "[L_FO_extrasTextBox_D], [L_فصوص_U], [L_فصوص_D], [R_IDTextBox_U], [R_IDTextBox_D], [R_FO_madeTextBox_U], [R_FO_madeTextBox_D]," & vbCrLf &
                                "[R_font_IDTextBox_U], [R_font_IDTextBox_D], [R_ComboBox3_U], [R_ComboBox3_D], [R_FO_gramTextBox_U], [R_FO_gramTextBox_D]," & vbCrLf &
                                "[R_الوزن_U], [R_الوزن_D], [R_المصنعيه_U], [R_المصنعيه_D], [R_FO_gramMadeTextBox_U], [R_FO_gramMadeTextBox_D], [R_Gram_valuTextBox_U]," & vbCrLf &
                                "[R_Gram_valuTextBox_D], [R_العيار_U], [R_العيار_D], [R_FO_extrasTextBox_U], [R_FO_extrasTextBox_D], [R_فصوص_U], [R_فصوص_D], [سبايكu]," & vbCrLf &
                                "[سبايكd], [ويبu], [ويبd], [باركود_ويبu], [باركود_ويبd], [tel_u], [tel_d], [print_set], [print], [L_CodeValue_U], [L_CodeValue_D], " & vbCrLf &
                                "[L_CodeText_U], [L_CodeText_D], [L_YearValue_U], [L_YearValue_D], [L_YearText_U], [L_YearText_D], [R_CodeValue_U], [R_CodeValue_D], " & vbCrLf &
                                "[R_CodeText_U], [R_CodeText_D], [R_YearValue_U], [R_YearValue_D], [R_YearText_U], [R_YearText_D], [L_SupplierValue_U], [L_SupplierValue_D], " & vbCrLf &
                                "[L_SupplierText_U], [L_SupplierText_D], [L_AttachmentValue_U], [L_AttachmentValue_D], [L_AttachmentText_U], [L_AttachmentText_D], " & vbCrLf &
                                "[R_SupplierValue_U], [R_SupplierValue_D], [R_SupplierText_U], [R_SupplierText_D], [R_AttachmentValue_U], [R_AttachmentValue_D], " & vbCrLf &
                                "[R_AttachmentText_U], [R_AttachmentText_D], [BarCodeFontValue], [BarCodeFontStyle], [BarCodeNoFontValue], [BarCodeNoFontStyle], " & vbCrLf &
                                "[DataTextFontValue], [DataTextFontStyle], [CompanyTextFontValue], [CompanyTextFontStyle])" & vbCrLf &
                                "VALUES (N'25', N'260', N'10', N'250', N'35', N'270', N'27', N'150', N'60', N'252', N'60', N'285', N'70', N'285', N'70', " & vbCrLf &
                                "N'252', N'80', N'252', N'80', N'285', N'90', N'252', N'100', N'285', N'70', N'20', N'55', N'10', N'80', N'30', N'123', " & vbCrLf &
                                "N'95', N'105', N'10', N'100', N'55', N'115', N'55', N'115', N'10', N'125', N'10', N'135', N'55', N'135', N'10', N'125', " & vbCrLf &
                                "N'55', N'50', N'120', N'70', N'100', N'90', N'95', N'65', N'100', N'ZDesigner ZD888-203dpi ZPL', NULL, N'0', N'0', N'0', " & vbCrLf &
                                "N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'00', N'0', N'0', N'0', N'0', N'0', N'0', N'0', " & vbCrLf &
                                "N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'0', N'8', N'R', N'8', N'R', N'8', N'R', N'6', N'R')"
        GlCommand.ExecuteNonQuery()
        Accessories_BarcodeConfigTableAdapter.Fill(DT_restrantDataSet.Accessories_BarcodeConfig)
    End Sub
End Class