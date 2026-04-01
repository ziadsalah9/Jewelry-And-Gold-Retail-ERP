
Public Class AuctionBarCode
    Dim BarCodeFont As New Font("3 of 9 Barcode", 10, FontStyle.Bold)
    Dim CountryFont As New Font("Arial", 6, FontStyle.Regular)
    Dim NoFont As New Font("Arial", 10, FontStyle.Regular)
    Dim DataTextFont As New Font("Arial", 6, FontStyle.Regular)
    Dim CompanyTextFont As New Font("Arial", 6, FontStyle.Regular)
    Dim ArabicOtherTextFont As New Font("Arial", 15, FontStyle.Italic)
    Dim EnglishOtherTextFont As New Font("Arial", 10, FontStyle.Bold)
    Private Sub barcood_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub

    Private Sub barcood_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ControlsAsColor(ColorSelect:=Me)
        language_start(Name)
        AuctionBarCode1TableAdapter.Fill(DT_restrantDataSet.AuctionBarCode1)
        AuctionBarCode2TableAdapter.Fill(DT_restrantDataSet.AuctionBarCode2)
        Comp_informTableAdapter.Fill(DT_restrantDataSet.comp_inform)
        Auction_BarcodeConfigTableAdapter.Fill(DT_restrantDataSet.Auction_BarcodeConfig)

        TextBox1.Text = "1"
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        AuctionBarCode1BindingSource.MoveLast()
        AuctionBarCode2BindingSource.MoveLast()
        AuctionBarCode1BindingSource.MovePrevious()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If Print_setTextBox.Text.Trim <> "" Then
            cmbPrinter.Text = Print_setTextBox.Text.Trim
        End If
        min_BarCode.Hide()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintGoldBarCode()
    End Sub
    Public Sub PrintGoldBarCode()
        If IsNumeric(TextBox1.Text.Trim) = False Then
            MsgBox("أدخل عدد ملصقات صحيح" & vbCrLf & "Enter Valid Label Qty.", , Apptitle)
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        End If
        Try
            For x As Integer = 1 To TextBox1.Text
                ValidateChildren()
                Auction_BarcodeConfigBindingSource.EndEdit()
                Auction_BarcodeConfigTableAdapter.Update(DT_restrantDataSet.Auction_BarcodeConfig)
                Auction_BarcodeConfigTableAdapter.Fill(DT_restrantDataSet.Auction_BarcodeConfig)
                PrintDialog1.PrinterSettings.PrinterName = Print_setTextBox.Text
                PrintDocument1.Print()
            Next
        Catch ex As Exception
            MsgBox("خطأ في إدخال قيم ضبط الباركود" & vbCrLf & "Error in BarCode Data", , Apptitle)
            'Next
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ''الجه اليمني من الباركود
        e.Graphics.DrawString("*" & Auction_IDtxt1.Text & "*", BarCodeFont, Brushes.Black, L_IDTextBox_DTextBox.Text, L_IDTextBox_UTextBox.Text) ''الباركود الجه اليمن
        e.Graphics.DrawString("السعر\" & Pricetxt1.Text, CountryFont, Brushes.Black, L_FO_madeTextBox_DTextBox.Text, L_FO_madeTextBox_UTextBox.Text) ''اسم المورد / الشركه
        e.Graphics.DrawString(Auction_IDtxt1.Text, NoFont, Brushes.Black, L_font_IDTextBox_DTextBox.Text, L_font_IDTextBox_UTextBox.Text) ''رقم الباركود الجه اليمن
        e.Graphics.DrawString(cmbCompany.Text, CompanyTextFont, Brushes.Black, L_ComboBox3_DTextBox.Text, L_ComboBox3_UTextBox.Text) '' اسم الشركه الجه اليمني


        e.Graphics.DrawString(":الموديل", DataTextFont, Brushes.Black, L_W_DTextBox.Text, L_W_UTextBox.Text) ''اسم الموديل
        e.Graphics.DrawString(":سيريال", DataTextFont, Brushes.Black, L_M_DTextBox.Text, L_M_UTextBox.Text) ''اسم السيريال
        e.Graphics.DrawString(":استلام", DataTextFont, Brushes.Black, L_C_DTextBox.Text, L_C_UTextBox.Text) '' العيار
        e.Graphics.DrawString(":" & GuaranteeDatetxt1.Text, DataTextFont, Brushes.Black, L_S_DTextBox.Text, L_S_UTextBox.Text) ''رقم الفص

        e.Graphics.DrawString(Modeltxt1.Text, DataTextFont, Brushes.Black, L_FO_gramTextBox_DTextBox.Text, L_FO_gramTextBox_UTextBox.Text) ''رقم الموديل
        e.Graphics.DrawString(Serialtxt1.Text, DataTextFont, Brushes.Black, L_FO_gramMadeTextBox_DTextBox.Text, L_FO_gramMadeTextBox_UTextBox.Text) ''رقم المصنعيه
        e.Graphics.DrawString(ReceiveDatetxt1.Text, DataTextFont, Brushes.Black, L_Gram_valuTextBox_DTextBox.Text, L_Gram_valuTextBox_UTextBox.Text) ''رقم العيار
        e.Graphics.DrawString(GuaranteeStatustxt1.Text, DataTextFont, Brushes.Black, L_FO_extrasTextBox_DTextBox.Text, L_FO_extrasTextBox_UTextBox.Text) '' الفص

        ' ''الجه اليسري من الباركود
        ' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        e.Graphics.DrawString("*" & Auction_IDtxt2.Text & "*", BarCodeFont, Brushes.Black, R_IDTextBox_DTextBox.Text, R_IDTextBox_UTextBox.Text) ''الباركود الجه اليسري
        e.Graphics.DrawString("السعر\" & Pricetxt2.Text, CountryFont, Brushes.Black, R_FO_madeTextBox_DTextBox.Text, R_FO_madeTextBox_UTextBox.Text) ''اسم المورد / الشركه
        e.Graphics.DrawString(Auction_IDtxt2.Text, NoFont, Brushes.Black, R_font_IDTextBox_DTextBox.Text, R_font_IDTextBox_UTextBox.Text) ''رقم الباركود الجه اليسري
        e.Graphics.DrawString(cmbCompany.Text, CompanyTextFont, Brushes.Black, R_ComboBox3_DTextBox.Text, R_ComboBox3_UTextBox.Text) '' اسم الشركه الجه اليسري
        e.Graphics.DrawString(":الموديل", DataTextFont, Brushes.Black, R_W_DTextBox.Text, R_W_UTextBox.Text) ''اليسري اسم الوزن
        e.Graphics.DrawString(":سيريال", DataTextFont, Brushes.Black, R_M_DTextBox.Text, R_M_UTextBox.Text) ''اليسري سعر الفضة
        e.Graphics.DrawString(":استلام", DataTextFont, Brushes.Black, R_C_DTextBox.Text, R_C_UTextBox.Text) ''  اليسري العيار
        e.Graphics.DrawString(":" & GuaranteeDatetxt2.Text, DataTextFont, Brushes.Black, R_S_DTextBox.Text, R_S_UTextBox.Text) ''  اليسري الفص

        e.Graphics.DrawString(Modeltxt2.Text, DataTextFont, Brushes.Black, R_FO_gramTextBox_DTextBox.Text, R_FO_gramTextBox_UTextBox.Text) ''اليسري رقم الوزن
        e.Graphics.DrawString(Serialtxt2.Text, DataTextFont, Brushes.Black, R_FO_gramMadeTextBox_DTextBox.Text, R_FO_gramMadeTextBox_UTextBox.Text) ''رقم المصنعيه اليسري 
        e.Graphics.DrawString(ReceiveDatetxt2.Text, DataTextFont, Brushes.Black, R_Gram_valuTextBox_DTextBox.Text, R_Gram_valuTextBox_UTextBox.Text) ''رقم العيار اليسري
        e.Graphics.DrawString(GuaranteeStatustxt2.Text, DataTextFont, Brushes.Black, R_FO_extrasTextBox_DTextBox.Text, R_FO_extrasTextBox_UTextBox.Text) '' اليسري رقم الفص

        e.Graphics.DrawString("سبائك الكويت", ArabicOtherTextFont, Brushes.Black, سبايكdTextBox.Text, سبايكuTextBox.Text) ''سبائك الكويت
        e.Graphics.DrawString("www.sabayiks.net", EnglishOtherTextFont, Brushes.Black, ويبdTextBox.Text, ويبuTextBox.Text) ''الموقع
        e.Graphics.DrawString("Golden-SAP-Program", EnglishOtherTextFont, Brushes.Black, باركود_ويبdTextBox.Text, باركود_ويبuTextBox.Text) 'سبائك الكويت
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
                Auction_BarcodeConfigBindingSource.EndEdit()
                Auction_BarcodeConfigTableAdapter.Update(DT_restrantDataSet.Auction_BarcodeConfig)
                Auction_BarcodeConfigTableAdapter.Fill(DT_restrantDataSet.Auction_BarcodeConfig)
                MsgBox("تم حفظ الإعدادات بنجاح" & vbCrLf & "Setting Saved Successfully", , Apptitle)
            Catch ex As Exception
                MsgBox("خطأ في الإعدادات النصية" & vbCrLf & "Error in Settings Data", , Apptitle)
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
End Class