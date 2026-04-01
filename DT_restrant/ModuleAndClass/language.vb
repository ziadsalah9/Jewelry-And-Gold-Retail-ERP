Module language

    Public Sub language_start(ByVal FormName As String)
        'Try
        Select Case FormName.ToUpper
                Case "FRMPUPRRENTINV"
                    If frmLogin.rbtnEn.Checked = True Then
                        With FrmPupPrentInv
                            FrmPupPrentInv.Text = "Review Bills"
                            .btnView.Text = "Show"
                            .btnPrint.Text = "Print"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With FrmPupPrentInv
                            FrmPupPrentInv.Text = "مراجعة الفواتير"
                            .btnView.Text = "عرض"
                            .btnPrint.Text = "طباعه"
                        End With
                    End If
                Case "FRMVIWCASTOMERINVDATA"
                    If frmLogin.rbtnEn.Checked = True Then
                        With FrmViwCastomerInvData
                            FrmViwCastomerInvData.Text = "Customer Sales Statement"
                            .grid.Columns("colCatomerName").HeaderText = "Catomer Name"
                            .grid.Columns("colCastomTel").HeaderText = "Catomer Tel"
                            .grid.Columns("colCashier").HeaderText = "Cashier"
                            .grid.Columns("colGoldW").HeaderText = "Gold Weight"
                            .grid.Columns("colCash").HeaderText = "Cash"
                            .grid.Columns("colKenet").HeaderText = "In Bank"
                            .grid.Columns("colTotalAmount").HeaderText = "Total Amount"
                            .grid.Columns("colInvNo").HeaderText = "Invoice No."
                            .grid.Columns("colDate").HeaderText = "Invoice Date"
                            .grid.Columns("colViwInv").HeaderText = "View"
                            .BtnPrint.Text = "Print"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With FrmViwCastomerInvData
                            FrmViwCastomerInvData.Text = "بيان مبيعات العميل"
                            .grid.Columns("colCatomerName").HeaderText = "أسم العميل"
                            .grid.Columns("colCastomTel").HeaderText = "رقم الهاتف"
                            .grid.Columns("colCashier").HeaderText = "الكاشير"
                            .grid.Columns("colGoldW").HeaderText = "وزن الذهب"
                            .grid.Columns("colCash").HeaderText = "اجمالي الكاش"
                            .grid.Columns("colKenet").HeaderText = "اجمالي البنكي"
                            .grid.Columns("colTotalAmount").HeaderText = "اجمالي السعر"
                            .grid.Columns("colInvNo").HeaderText = "رقم الفاتوره"
                            .grid.Columns("colDate").HeaderText = "تاريخ/وقت الفاتوره"
                            .grid.Columns("colViwInv").HeaderText = "عرض"
                            .BtnPrint.Text = "طباعه"
                        End With
                    End If

                ''''''''التحويلات
                Case "TRANSFERSITEM"
                    If frmLogin.rbtnEn.Checked = True Then
                        With TransfersItem
                            .Text = "Transfers"
                            .TabPage1.Text = "Transfers"
                            .TabPage2.Text = "Branch Names"
                            .GrpFrom.Text = "Transfers From"
                            .GrpTo.Text = "Transfers To"
                            .RadoGold.Text = "Gold"
                            .Radosilver.Text = "Silver"
                            .RadoDia.Text = "silver"
                            .BtnViwData.Text = "Viw Data"
                            .BtnSelectAll.Text = "SelectAll"
                            .BtnTransSelect.Text = "Transfers Select"
                            .TrnsfGrid.Columns("colBarCode").HeaderText = "BarCode"
                            .TrnsfGrid.Columns("colGram_valu").HeaderText = "Gold Karat"
                            .TrnsfGrid.Columns("colFO_name").HeaderText = "Item Name"
                            .TrnsfGrid.Columns("colFO_gram").HeaderText = "Gold Weight"
                            .TrnsfGrid.Columns("colQty").HeaderText = "Quantity"
                            .TrnsfGrid.Columns("coldate_care").HeaderText = "Entry Date"
                            .TrnsfGrid.Columns("colLastEditDate").HeaderText = "Last Edit Date"
                            .TrnsfGrid.Columns("coluserID").HeaderText = "user"
                            .TrnsfGrid.Columns("colPurInvNumber").HeaderText = "Purchase invoice No."
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With TransfersItem
                            .Text = "التحويلات"
                            .TabPage1.Text = "التحويلات"
                            .TabPage2.Text = "اسماء الفروع"
                            .GrpFrom.Text = "تحويل من"
                            .GrpTo.Text = "تحويل الي"
                            .RadoGold.Text = "ذهب"
                            .Radosilver.Text = "فضه"
                            .RadoDia.Text = "الماس"
                            .BtnViwData.Text = "عرض البيانات"
                            .BtnSelectAll.Text = "اختيار الكل"
                            .BtnTransSelect.Text = "تحويل المحدد"
                            .TrnsfGrid.Columns("colBarCode").HeaderText = "باركود"
                            .TrnsfGrid.Columns("colGram_valu").HeaderText = "عيار"
                            .TrnsfGrid.Columns("colFO_name").HeaderText = "اسم الصنف"
                            .TrnsfGrid.Columns("colFO_gram").HeaderText = "الوزن"
                            .TrnsfGrid.Columns("colQty").HeaderText = "العدد"
                            .TrnsfGrid.Columns("coldate_care").HeaderText = "تاريخ الادخال"
                            .TrnsfGrid.Columns("colLastEditDate").HeaderText = "تاريخ اخر تعديل"
                            .TrnsfGrid.Columns("coluserID").HeaderText = "اسم المستخدم"
                            .TrnsfGrid.Columns("colPurInvNumber").HeaderText = "رقم فاتورة الشراء"
                        End With
                    End If

                Case "ADDCUSTOMER"
                If frmLogin.rbtnEn.Checked = True Then
                    With AddCustomer
                        .gbData.Text = "Customer Data"
                        .btnAdd.Text = "Add/Update Customer"
                        .lblCID.Text = "Civil ID"
                        .lblCustomerName.Text = "Name"
                        .lblAddress.Text = "Address"
                        .lblPhone.Text = "Phone"
                        .lblNationality.Text = "Nationality"
                        .btnView.Text = "Show"
                        .btnScannerSettings.Text = "Scanner Settings"
                        .btnAddSignature.Text = "Digital Signature"
                        .Text = "Customer Data"
                    End With
                ElseIf frmLogin.rbtnAr.Checked = True Then
                    With AddCustomer
                        .gbData.Text = "بيانات العميل"
                        .btnAdd.Text = "إضافة عميل جديد/تحديث بيانات"
                        .lblCID.Text = "الرقم المدني"
                        .lblCustomerName.Text = "اسم العميل"
                        .lblAddress.Text = "العنوان"
                        .lblPhone.Text = "رقم الهاتف"
                        .lblNationality.Text = "الجنسية"
                        .btnView.Text = "عرض"
                        .btnScannerSettings.Text = "إعدادات الماسح الضوئي"
                        .btnAddSignature.Text = "إضافة التوقيع الإلكتروني"
                        .Text = "بيانات العميل"
                    End With
                End If
                '' المحزوفات
            Case "FRMINVDELET"
                If frmLogin.rbtnEn.Checked = True Then
                    With FrmInvDelet
                        .Text = "View Deleted Invoice"
                        .RightToLeft = 0
                        .RightToLeft = 0
                        .RdoSell.Text = "Sell"
                        .RdoBuy.Text = "Buy"
                        .TabGold.Text = "Gold"
                        .TabSilver.Text = "Silver"
                        .TabDaimond.Text = "Daimond"
                        .BtnViwAllGold.Text = "Show All"
                        .BtnAdvSelGold.Text = "Show Select"
                        .lblFromGold.Text = "From"
                        .lblToGold.Text = "To"
                        .BtnViwBayDateGold.Text = "Show By Date"
                        .btnInvRetr.Text = "Restore Invoice"
                        .cmbAdvSelGold.Items.Clear()
                        .cmbAdvSelGold.Items.Add("Customer Name")
                        .cmbAdvSelGold.Items.Add("Civil ID")
                        .cmbAdvSelGold.Items.Add("Phone No.")
                        .cmbAdvSelGold.Items.Add("Invoice No.")
                        .GridGold.Columns(0).HeaderText = "Invoice No."
                        .GridGold.Columns(1).HeaderText = "Civil ID"
                        .GridGold.Columns(2).HeaderText = "Customer Name"
                        .GridGold.Columns(3).HeaderText = "Gold Weight"
                        .GridGold.Columns(4).HeaderText = "Total Amount"
                        .GridGold.Columns(5).HeaderText = "Del"
                        '''''''''''''''''''''''''''''''''''''
                    End With
                ElseIf frmLogin.rbtnAr.Checked = True Then
                    With FrmInvDelet
                        .Text = "عرض المحزوفات"
                        .RightToLeft = 0
                        .RightToLeft = 0
                        .RdoSell.Text = "بيع"
                        .RdoBuy.Text = "شراء"
                        .TabGold.Text = "ذهب"
                        .TabSilver.Text = "فضه"
                        .TabDaimond.Text = "الماس"
                        .BtnViwAllGold.Text = "عرض الكل"
                        .BtnAdvSelGold.Text = "عرض المحدد"
                        .lblFromGold.Text = "من تاريخ"
                        .lblToGold.Text = "الي تاريخ"
                        .BtnViwBayDateGold.Text = "عرض حسب التاريخ"
                        .btnInvRetr.Text = "استرجاع الفاتوره"
                        .cmbAdvSelGold.Items.Clear()
                        .cmbAdvSelGold.Items.Add("اسم العميل")
                        .cmbAdvSelGold.Items.Add("الرقم المدني")
                        .cmbAdvSelGold.Items.Add("رقم الهاتف")
                        .cmbAdvSelGold.Items.Add("رقم الفاتوره")
                        .GridGold.Columns(0).HeaderText = "رقم الفاتوره"
                        .GridGold.Columns(1).HeaderText = "الرقم المدني"
                        .GridGold.Columns(2).HeaderText = "اسم العميل"
                        .GridGold.Columns(3).HeaderText = "الوزن"
                        .GridGold.Columns(4).HeaderText = "اجمالي المبلغ"
                        .GridGold.Columns(5).HeaderText = "حذف"
                    End With
                End If
            ''ترجمة الفضه
            Case "REPORTSILVERSELLDETAILED"
                    If frmLogin.rbtnEn.Checked = True Then
                        With ReportSilverSellDetailed
                            .Text = "Detailed Silver Sell Report"
                            .btnViewAll.Text = "View All"
                            .RightToLeft = 0
                            .RightToLeft = 0
                            .ChBoxBayDate.Text = "With Date Select"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .lblFromDate.Text = "From Date"
                            .lblToDate.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Customer Name")
                            .cmbSearch.Items.Add("Civil ID")
                            .cmbSearch.Items.Add("Phone No.")
                            .cmbSearch.Items.Add("Cashier")
                            .cmbSearch.Items.Add("Invoice No.")
                            .cmbSearch.Items.Add("Item Name.")
                            .cmbSearch.Items.Add("BarCode")
                            .cmbSearch.Items.Add("Silver Karet")
                            '''''''''''''''''''''''''''''''''''''
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With ReportSilverSellDetailed
                            .Text = "تقرير مبيعات الفضه"
                            .btnViewAll.Text = "عرض الكل"
                            .RightToLeft = 0
                            .RightToLeft = 0
                            .ChBoxBayDate.Text = "تقيد التاريخ"
                            .btnPreview.Text = "معاينه"
                            .btnCancelPreview.Text = "الغاء المعاينه"
                            .btnPrint.Text = "طباعة التقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمه"
                            .btnSearch.Text = "عرض"
                            .lblFromDate.Text = "من تاريخ"
                            .lblToDate.Text = "الي تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم العميل")
                            .cmbSearch.Items.Add("الرقم المدني")
                            .cmbSearch.Items.Add("رقم الهاتف")
                            .cmbSearch.Items.Add("الكاشير")
                            .cmbSearch.Items.Add("رقم الفاتوره")
                            .cmbSearch.Items.Add("اسم الصنف")
                            .cmbSearch.Items.Add("الباركود")
                            .cmbSearch.Items.Add("عيار الفضه")
                        End With
                    End If
                ''الذهب
                Case "REPORTGOLDSELLDETAILED"
                    If frmLogin.rbtnEn.Checked = True Then
                        With ReportGoldSellDetailed
                            .Text = "Detailed Gold Sell Report "
                            .btnViewAll.Text = "View All"
                            .RightToLeft = 0
                            .RightToLeft = 0
                            .ChBoxBayDate.Text = "With Date Select"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .lblFromDate.Text = "From Date"
                            .lblToDate.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Customer Name")
                            .cmbSearch.Items.Add("Civil ID")
                            .cmbSearch.Items.Add("Phone No.")
                            .cmbSearch.Items.Add("Cashier")
                            .cmbSearch.Items.Add("Invoice No.")
                            .cmbSearch.Items.Add("Item Name.")
                            .cmbSearch.Items.Add("BarCode")
                            .cmbSearch.Items.Add("Gold Karet")
                            '''''''''''''''''''''''''''''''''''''
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With ReportGoldSellDetailed
                            .Text = "تقرير مبيعات الذهب تفصيلي"
                            .btnViewAll.Text = "عرض الكل"
                            .RightToLeft = 0
                            .RightToLeft = 0
                            .ChBoxBayDate.Text = "تقيد التاريخ"
                            .btnPreview.Text = "معاينه"
                            .btnCancelPreview.Text = "الغاء المعاينه"
                            .btnPrint.Text = "طباعة التقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمه"
                            .btnSearch.Text = "عرض"
                            .lblFromDate.Text = "من تاريخ"
                            .lblToDate.Text = "الي تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم العميل")
                            .cmbSearch.Items.Add("الرقم المدني")
                            .cmbSearch.Items.Add("رقم الهاتف")
                            .cmbSearch.Items.Add("الكاشير")
                            .cmbSearch.Items.Add("رقم الفاتوره")
                            .cmbSearch.Items.Add("اسم الصنف")
                            .cmbSearch.Items.Add("الباركود")
                            .cmbSearch.Items.Add("عيار الذهب")
                        End With
                    End If
                Case "DIAMONDDELETEEDITEINVOCEBUY"
                    If frmLogin.rbtnEn.Checked = True Then
                        With DiamondDeleteEditeInvoceBuy
                            .txtInvoiceNo.Text = ""
                            .btnSave.Text = "Save"
                            .btnPrint.Text = "Print"
                            .btnDeleteInvoice.Text = "Delete"
                            .btnView.Text = "Search"
                            .lblInvoiceNo.Text = "Invoice NO."
                            .gbInvoiceData.Text = "Payment Data"
                            .lblDate.Text = "Invoice Date"
                            .lblCashier.Text = "Casher"
                            .rbtnCash.Text = "Cash"
                            .rbtnInstallment.Text = "Installment"
                            .lblPriceReturn.Text = "Return Price"
                            .lblPriceRequired.Text = "Required Price"
                            .lblCash.Text = "Cash"
                            .lblKnet.Text = "Bank"
                            .lblPayMethod.Text = "Pay Method"
                            .DGridItemDetels.Columns(0).HeaderText = "Del"
                            .DGridItemDetels.Columns(1).HeaderText = "Item Details"
                            .DGridItemDetels.Columns(2).HeaderText = "Gold-Wt"
                            .DGridItemDetels.Columns(3).HeaderText = "D-Carat"
                            .DGridItemDetels.Columns(4).HeaderText = "Gold-Karat"
                            .DGridItemDetels.Columns(5).HeaderText = "Total-Price"
                            .DGridItemDetels.Columns(6).HeaderText = "D-Clarity"
                            .DGridItemDetels.Columns(7).HeaderText = "D-Color"
                            .DGridItemDetels.Columns(8).HeaderText = "Item No."
                            .DGridItemDetels.Columns(9).HeaderText = "D-Cut"
                            .DGridItemDetels.Columns(10).HeaderText = "Invoice-Notes"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With DiamondDeleteEditeInvoceBuy
                            .txtInvoiceNo.Text = ""
                            .btnSave.Text = "حفظ"
                            .btnPrint.Text = "طباعه"
                            .btnDeleteInvoice.Text = "حزف"
                            .btnView.Text = "عرض"
                            .lblInvoiceNo.Text = "رقم الفاتوره"
                            .gbInvoiceData.Text = "بيانات الدفع"
                            .lblDate.Text = "تاريخ الفاتوره"
                            .lblCashier.Text = "الكاشير"
                            .rbtnCash.Text = "كاش"
                            .rbtnInstallment.Text = "آجل"
                            .lblPriceReturn.Text = "ارجع للعمل"
                            .lblPriceRequired.Text = "مبلغ الفاتوره"
                            .lblCash.Text = "كاش"
                            .lblKnet.Text = "بنكي"
                            .lblPayMethod.Text = "طريقة الدفع"
                            .DGridItemDetels.Columns(0).HeaderText = "حزف"
                            .DGridItemDetels.Columns(1).HeaderText = "اسم الصنف"
                            .DGridItemDetels.Columns(2).HeaderText = "وزن الذهب "
                            .DGridItemDetels.Columns(3).HeaderText = "وزن الالماس"
                            .DGridItemDetels.Columns(4).HeaderText = "عيار الذهب"
                            .DGridItemDetels.Columns(5).HeaderText = "اجمال السعر"
                            .DGridItemDetels.Columns(6).HeaderText = "النقاء"
                            .DGridItemDetels.Columns(7).HeaderText = "اللون"
                            .DGridItemDetels.Columns(8).HeaderText = "رقم القطعه."
                            .DGridItemDetels.Columns(9).HeaderText = "القص"
                            .DGridItemDetels.Columns(10).HeaderText = "ملاحظات"
                        End With
                    End If
                Case "FRMBONDTYPE"
                    If frmLogin.rbtnEn.Checked = True Then
                        With FrmBondType
                            .Text = "Bond Type"
                            '.btnDelete.Text = "Delete"
                            .btnEdit.Text = "Edit"
                            .btnNew.Text = "New"
                            .btnSave.Text = "Save"
                            .lblBondType.Text = "Bond Type"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With FrmBondType
                            .Text = "نوع المعامله"
                            '.btnDelete.Text = "حزف"
                            .btnEdit.Text = "تعديل"
                            .btnNew.Text = "جديد"
                            .btnSave.Text = "حفظ"
                            .lblBondType.Text = "نوع المعامله"
                        End With
                    End If

                Case "FRMBONDGOLDTYPE"
                    If frmLogin.rbtnEn.Checked = True Then
                        With FrmBondGoldType
                            .Text = "Bond Type"
                            '.btnDelete.Text = "Delete"
                            .btnEdit.Text = "Edit"
                            .btnNew.Text = "New"
                            .btnSave.Text = "Save"
                            .lblBondType.Text = "Bond Type"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With FrmBondGoldType
                            .Text = "نوع المعامله"
                            '.btnDelete.Text = "حزف"
                            .btnEdit.Text = "تعديل"
                            .btnNew.Text = "جديد"
                            .btnSave.Text = "حفظ"
                            .lblBondType.Text = "نوع المعامله"
                        End With
                    End If

                Case "BACKUP"
                    If frmLogin.rbtnEn.Checked = True Then
                        With frmBackup
                            .gbBackup.RightToLeft = 0
                            .gbBackup.Text = "Backup"
                            .btnSave.Text = "Save"
                            .btnSavePath.Text = "Save Location..."
                            .txtBackupPath.Text = "Select Save Location"
                            .gbRestore.RightToLeft = 0
                            .gbRestore.Text = "Restore"
                            .btnRestore.Text = "Begin Restore"
                            .btnRestorePath.Text = "Restore Path..."
                            .txtRestorePath.Text = "Select Restore Location"
                            .Text = "Backup DataBase"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With frmBackup
                            .gbBackup.RightToLeft = 1
                            .gbBackup.Text = "نسخ احتياطي"
                            .btnSave.Text = "بدء النسخ"
                            .btnSavePath.Text = "مسار الحفظ..."
                            .txtBackupPath.Text = "حدد مسار الحفظ"
                            .gbRestore.RightToLeft = 1
                            .gbRestore.Text = "استرداد"
                            .btnRestore.Text = "بدء الاسترداد"
                            .btnRestorePath.Text = "مسار الاسترداد..."
                            .txtRestorePath.Text = "حدد مسار الاسترداد"
                            .Text = "نسخ احتياطي لقاعدة البيانات"
                        End With
                    End If
                Case "FRMSND"
                    If frmLogin.rbtnEn.Checked = True Then
                        With FrmSnd
                            .Text = "Cash receipt/Disbursement voucher"
                            .BtnSave.Text = "Save"
                            .RidoPersonal.Text = "Personal"
                            .RidoComp.Text = "Company"
                            .LabSndName.Text = "Bond Type"
                            .LabComName.Text = "Supplier/company/workshop"
                            .LabCasher.Text = "Cashier"
                            .LabDate.Text = "Date"
                            .LabDescription.Text = "Description"
                            .lblCash.Text = "Cash"
                            .LabBank.Text = "Bank"
                            .lblPayMethod1.Text = "Other With"
                            .LabSndNo.Text = "Bond No."
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With FrmSnd
                            .Text = "سند قبض / صرف نقدي"
                            .BtnSave.Text = "حفظ"
                            .RidoPersonal.Text = "شخصي"
                            .RidoComp.Text = "شركه"
                            .LabSndName.Text = "نوع السند"
                            .LabComName.Text = "اسم المورد/الشركه/الورشه"
                            .LabCasher.Text = "كاشير"
                            .LabDate.Text = "التاريخ"
                            .LabDescription.Text = "الــــوصــــف"
                            .lblCash.Text = "كاش"
                            .LabBank.Text = "بنكي"
                            .lblPayMethod1.Text = "عمليات دفع اخري"
                            .LabSndNo.Text = "رقم السند"
                        End With
                    End If
                Case "COMP_INVOCE_CACHE"
                    If frmLogin.rbtnEn.Checked = True Then
                        With COMP_INVOCE_CACHE
                            .lblCompanyName.Text = "Company Name/Supplier"
                            .btnAddCompany.Text = "Add Company"
                            .btnGetData.Text = "Get Data"
                            .btnReadData.Text = "View Data"
                            .btnAddNewCustomer.Text = "Add New Customer"
                            .lblName.Text = "Name"
                            .lblAddress.Text = "Address"
                            .lblTel.Text = "Phone No."
                            .lblNationality.Text = "Nationality"
                            .btnSave.Text = "Save"
                            .lblTotal.Text = "Total"
                            .lblInvoiceNo.Text = "Invoice No."
                            .btnDelete.Text = "Delete"
                            .btnPay.Text = "Pay"
                            .btnPrint.Text = "Print"
                            .GOLED_wazenLabel.Text = "Weight"
                            .GOLED_VALUSLabel.Text = "Carat"
                            .GOLED_GRAM_PRICELabel.Text = "Gram Price"
                            .GOLED_TOTAL_PRICELabel.Text = "Total Price"
                            .Label5.Text = "Cash"
                            .Label6.Text = "K-NET"
                            .Label7.Text = "Remaining"
                            .DataGridViewTextBoxColumn4.HeaderText = "Weight"
                            .DataGridViewTextBoxColumn5.HeaderText = "Carat"
                            .DataGridViewTextBoxColumn6.HeaderText = "Gram Price"
                            .DataGridViewTextBoxColumn7.HeaderText = "Total Price"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With COMP_INVOCE_CACHE
                            .lblCompanyName.Text = "اسم الشركة/المورد"
                            .btnAddCompany.Text = "إضافة شركة/مزود"
                            .btnGetData.Text = "استعلام"
                            .btnReadData.Text = "عرض بيانات العميل"
                            .btnAddNewCustomer.Text = "إضافة عميل جديد"
                            .lblName.Text = "الاسم"
                            .lblAddress.Text = "العنوان"
                            .lblTel.Text = "رقم الهاتف"
                            .lblNationality.Text = "الجنسية"
                            .btnSave.Text = "حفظ"
                            .lblTotal.Text = "إجمالي"
                            .lblInvoiceNo.Text = "رقم الفاتورة"
                            .btnDelete.Text = "حذف"
                            .btnPay.Text = "دفع"
                            .btnPrint.Text = "طباعة"
                            .GOLED_wazenLabel.Text = "الوزن"
                            .GOLED_VALUSLabel.Text = "العيار"
                            .GOLED_GRAM_PRICELabel.Text = "سعر الجرام"
                            .GOLED_TOTAL_PRICELabel.Text = "إجمالي السعر"
                            .Label5.Text = "كاش"
                            .Label6.Text = "كي-نت"
                            .Label7.Text = "متبقي"
                            .DataGridViewTextBoxColumn4.HeaderText = "الوزن"
                            .DataGridViewTextBoxColumn5.HeaderText = "العيار"
                            .DataGridViewTextBoxColumn6.HeaderText = "سعر الجرام"
                            .DataGridViewTextBoxColumn7.HeaderText = "إجمالي السعر"
                        End With
                    End If
                Case "FRMSUPPLIERS"
                    If frmLogin.rbtnEn.Checked = True Then
                        With frmSuppliers
                            '.btnAddNew.Text = "Add New"
                            '.btnEdite.Text = "Save"
                            '.btnDelete.Text = "Delete"
                            '.btnEdite.Text = "Save"
                            '.gbData.Text = "Supplier Data"
                            '.lblCompanyName.Text = "Company Name/Supplier"
                            ''.lblShowRoom.Text = "Printed Name"
                            '.lblCommerceNo.Text = "Commercial Record"
                            '.lblPhone.Text = "Phone"
                            '.lblFax.Text = "Fax"
                            '.lblAutoNo.Text = "PACI No."
                            '.lblNote.Text = "Notes"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With frmSuppliers
                            '.btnAddNew.Text = "إضافة جديد"
                            '.btnEdite.Text = "حفظ"
                            '.btnDelete.Text = "حذف"
                            '.gbData.Text = "بيانات المورد"
                            '.lblCompanyName.Text = "اسم الشركة/المورد"
                            ''.lblShowRoom.Text = "الاسم المطبوع"
                            '.lblCommerceNo.Text = "السجل التجاري"
                            '.lblPhone.Text = "الهاتف"
                            '.lblFax.Text = "فاكس"
                            '.lblAutoNo.Text = "الرقم الآلي"
                            '.lblNote.Text = "ملاحظات"
                        End With
                    End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Case "STONEADD"
                    If frmLogin.rbtnEn.Checked = True Then
                        With StoneAdd  'بيان الدفع الألماس انجليزي
                            .btnNew.Text = "New"
                            .btnSave.Text = "Save"
                            .Gram_priceLabel.Text = "Stone type"
                            .Text = "Add Stone"
                            .colStoneName.HeaderText = "Stone Name"
                            .colDelete.HeaderText = "Del"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With StoneAdd
                            .btnNew.Text = "جديد"
                            .btnSave.Text = "حفظ"
                            .Gram_priceLabel.Text = "نوع الحجر"
                            .Text = "إضافة الاحجار"
                            .colStoneName.HeaderText = "اسم الحجر"
                            .colDelete.HeaderText = "حزف"
                        End With
                    End If

                Case "DIAMONDCUT"
                    If frmLogin.rbtnEn.Checked = True Then
                        With DiamondCut
                            .btnNew.Text = "New"
                            .btnSave.Text = "Save"
                            .btnEdit.Text = "Edit"
                            .lblName.Text = "Cut Name"
                            .Text = "Add Diamond Cuts"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With DiamondCut
                            .btnNew.Text = "جديد"
                            .btnSave.Text = "حفظ"
                            .btnEdit.Text = "تعديل"
                            .lblName.Text = "اسم القصة"
                            .Text = "إضافة قصات الألماس"
                        End With
                    End If

                Case "COUNTRYMADE"
                    If frmLogin.rbtnEn.Checked = True Then
                        With CountryMade  'بيان الدفع الألماس انجليزي
                            .btnNew.Text = "New"
                            .btnSave.Text = "Save"
                            .btnEdit.Text = "Edit"
                            .btnDelete.Text = "Delete"
                            .lbl.Text = "Country"
                            .colCountry.HeaderText = "Country"
                            .Text = "Add Country"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With CountryMade
                            .btnNew.Text = "جديد"
                            .btnSave.Text = "حفظ"
                            .btnEdit.Text = "تعديل"
                            .btnDelete.Text = "حذف"
                            .lbl.Text = "بلد الصنع"
                            .colCountry.HeaderText = "بلد الصنع"
                            .Text = "إضافة مصادر"
                        End With
                    End If
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Case "FRMPAYINSTALLMENT"
                    If frmLogin.rbtnEn.Checked = True Then
                        With frmPayInstallment  'بيان الدفع انجليزي
                            .gbInvoicePay.Text = "Payment Details"
                            .btnSave.Text = "Save"
                            .lblPayDate.Text = "Pay Date"
                            .lblCashier.Text = "Cashier"
                            .lblBank.Text = "Bank"
                            .lblCash.Text = "Cash"
                            .lblPayMethod.Text = "Pay By"
                            .gbInvoiceData.Text = "Invoice Data"
                            .lblInvNo.Text = "Invoice No"
                            .lblCID.Text = "CID"
                            .lblCustomerName.Text = "Customer Name"
                            .lblPrice.Text = "Invoice Price"
                            .lblCashPaid.Text = "Cash-Paid"
                            .lblBankPaid.Text = "Bank-Paid"
                            .lblPaid.Text = "Total-Paid"
                            .lblRemianing.Text = "Remaining"
                            .colInvoiceNo.HeaderText = "Invoice No"
                            .colInvoiceType.HeaderText = "Type"
                            .colPayPrice.HeaderText = "Pay Amount"
                            .colCash.HeaderText = "Cash"
                            .colKNET.HeaderText = "Bank"
                            .colPayMethodAr.Visible = False
                            .colPayMethodEn.Visible = True
                            .colPayDateTime.HeaderText = "Date & Time"
                            .colCashier.HeaderText = "Cashier"
                            .Text = "Installment Pay"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With frmPayInstallment
                            .gbInvoicePay.Text = "تفاصيل الدفع"
                            .btnSave.Text = "حفظ"
                            .lblPayDate.Text = "تاريخ الدفع"
                            .lblCashier.Text = "الكاشير"
                            .lblBank.Text = "بنكي"
                            .lblCash.Text = "كاش"
                            .lblPayMethod.Text = "الطريقة"
                            .gbInvoiceData.Text = "تفاصيل الفاتورة"
                            .lblInvNo.Text = "رقم الفاتورة"
                            .lblCID.Text = "الرقم المدني"
                            .lblCustomerName.Text = "اسم العميل"
                            .lblPrice.Text = "مبلغ الفاتورة"
                            .lblCashPaid.Text = "مدفوع-كاش"
                            .lblBankPaid.Text = "مدفوع-بنكي"
                            .lblPaid.Text = "إجمالي المدفوع"
                            .lblRemianing.Text = "المتبقي"
                            .colInvoiceNo.HeaderText = "رقم الفاتورة"
                            .colInvoiceType.HeaderText = "النوع"
                            .colPayPrice.HeaderText = "المدفوع"
                            .colCash.HeaderText = "كاش"
                            .colKNET.HeaderText = "بنكي"
                            .colPayMethodAr.Visible = True
                            .colPayMethodEn.Visible = False
                            .colPayDateTime.HeaderText = "التاريخ والوقت"
                            .colCashier.HeaderText = "الكاشير"
                            .Text = "الدفع الآجل"
                        End With
                    End If

                Case "DIAMONDINVOICEPAY"
                    If frmLogin.rbtnEn.Checked = True Then
                        With DiamondInvoicePay  'بيان الدفع الألماس انجليزي
                            .Text = "Payment"
                            .gbInvoiceData.Text = "Invoice Statement"
                            .btnSave.Text = "Save"
                            .btnPrint.Text = "Print"
                            .lblInvNo.Text = "Invoice Number"
                            .lblPrice.Text = "Total Bill"
                            .lblRemianing.Text = "Remaining Amount"
                            .lblBank.Text = "Bank"
                            .lblCash.Text = "Cash"
                            .gbInvoiceData.Text = "Invoice Data"
                            .chkAutoClose.Text = "Auto Close"
                            .chkEngInvoice.Text = "English Invoice"
                            .ChkWholeSale.Text = "Wholesale Invoice"
                            .gbInvoicePay.Text = "Payment Statement"
                            .rbtnCash.Text = "Cash"
                            .rbtnInstallment.Text = "Credit"
                            .lblPayMethod.Text = "Pay With"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With DiamondInvoicePay
                            .Text = "بيانات الدفع"
                            .btnSave.Text = "حفظ"
                            .btnPrint.Text = "طباعة"
                            .lblInvNo.Text = "رقم الفاتورة"
                            .lblPrice.Text = "الإجمالي"
                            .lblRemianing.Text = "المتبقي"
                            .lblBank.Text = "بنكي"
                            .lblCash.Text = "كاش"
                            .gbInvoiceData.Text = "بيان الفاتورة"
                            .chkAutoClose.Text = "إغلاق تلقائي"
                            .chkEngInvoice.Text = "فاتورة إنجليزي"
                            .ChkWholeSale.Text = "فاتورة جملة"
                            .gbInvoicePay.Text = "بيانات الدفع"
                            .rbtnCash.Text = "نقدا"
                            .rbtnInstallment.Text = "آجل"
                            .lblPayMethod.Text = "طريقة الدفع"
                        End With
                    End If
                Case "DIAMONDINVOICE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With DiamondInvoice
                            .Text = "Diamond Invoice"
                            .btnSave.Text = "Save"
                            .btnPayPrint.Text = "Pay & Print"
                            .gbSelectItem.Text = "Select Item"
                            .lblCashier.Text = "Select Cashier"
                            .lblDiamondName.Text = "Type"
                            .lblBarCode.Text = "Barcode"
                            .lblDate.Text = "Invoice Date"
                            .gbItemData.Text = "Item Details"
                            .lblDiamondColor.Text = "D-Color"
                            .lblDiamondWeight.Text = "D-Carat"
                            .lblDiamondClarity.Text = "D-Clarity"
                            .lblDiamondCut.Text = "D-Cut"
                            .lblQty.Text = "Quantity"
                            .lblItemNo.Text = "Item No."
                            .lblGoldCarat.Text = "Metal-Karat"
                            .lblGoldWeight.Text = "Metal-Wt"
                            .lblStoneWeight.Text = "CS.Wt."
                            .lblStoneName.Text = "CS.Name"
                            .lblStoneColor.Text = "CS.Color"
                            .lblStoneClarity.Text = "CS.Clarity"
                            .lblStoneCut.Text = "CS.Cut"
                            .lblGoldGramPrice.Text = "Metal-Price/gm"
                            .lblCost.Text = "Cost"
                            .lblPrice.Text = "Tag-Price"
                            .lblTotalWeight.Text = "Total Weight"
                            .lblImage.Text = "Photo"
                            .lblSoldItem.Text = "Sold Items"
                            .colDelete.HeaderText = "Del"
                            .lblNotes.Text = "Notes"
                            .lblTotalPrice.Text = "Total Invoice Value"
                            .coltest_119.HeaderText = "Barcode"
                            .colDIMO_Type.HeaderText = "Item Details"
                            .coltotal.HeaderText = "Price"
                            .colDIM_na9awa.HeaderText = "D-Clarity"
                            .colDIMO_mezan.HeaderText = "D-Carat"
                            .colDIMO_coler.HeaderText = "D-Color"
                            .coltest_117.HeaderText = "D-Cut"
                            .colsarual.HeaderText = "Item No."
                            .colval_gold.HeaderText = "Metal-Karat"
                            .colGOLD_mezan.HeaderText = "Metal-Wt"
                            .colDIMO_qult.HeaderText = "Quantity"
                            .coltest_13.HeaderText = "CS.Wt1"
                            .coltest_14.HeaderText = "CS.Name1"
                            .coltest_15.HeaderText = "CS.Color1"
                            .coltest_16.HeaderText = "CS.Wt2"
                            .coltest_17.HeaderText = "CS.Name2"
                            .coltest_18.HeaderText = "CS.Color2"
                            .coltest_19.HeaderText = "CS.Wt3"
                            .coltest_110.HeaderText = "CS.Name3"
                            .coltest_111.HeaderText = "CS.Color3"
                            .coltest_116.HeaderText = "Total Weight"
                            .colnotes.HeaderText = "Notes"
                            .colGramPrice.HeaderText = "Metal-Price/gm"
                            .colSoldItem.HeaderText = "Sold Items"
                            .colCut1.HeaderText = "CS.Cut1"
                            .colClarity1.HeaderText = "CS.Clarity1"
                            .colCut2.HeaderText = "CS.Cut2"
                            .colClarity2.HeaderText = "CS.Clarity2"
                            .colCut3.HeaderText = "CS.Cut3"
                            .colClarity3.HeaderText = "CS.Clarity3"
                            .colDelete.HeaderText = "Del"
                            .LBLCertificateNo.Text = "Certificate No."
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With DiamondInvoice
                            .Text = "فاتورة ألماس"
                            .btnSave.Text = "حفظ"
                            .btnPayPrint.Text = "دفع وطباعة"
                            .gbSelectItem.Text = "اختر صنفا"
                            .lblCashier.Text = "اختر الكاشير"
                            .lblDiamondName.Text = "النوع"
                            .lblBarCode.Text = "باركود"
                            .lblDate.Text = "تاريخ الفاتورة"
                            .lblPrice.Text = "السعر الإجمالي"
                            .gbItemData.Text = "تفاصيل الصنف"
                            .lblDiamondColor.Text = "لون الألماس"
                            .lblDiamondWeight.Text = "قيراط الألماس"
                            .lblDiamondClarity.Text = "النقاوة"
                            .lblDiamondCut.Text = "القص"
                            .lblQty.Text = "العدد"
                            .lblItemNo.Text = "رقم القطعة"
                            .lblGoldCarat.Text = "عيار المعدن"
                            .lblGoldWeight.Text = "وزن المعدن"
                            .lblStoneWeight.Text = "وزن الحجر"
                            .lblStoneName.Text = "نوع الحجر"
                            .lblStoneColor.Text = "لون الحجر"
                            .lblStoneClarity.Text = "نقاوة الحجر"
                            .lblStoneCut.Text = "قصة الحجر"
                            .lblGoldGramPrice.Text = "سعر الجرام"
                            .lblCost.Text = "التكلفة"
                            .lblPrice.Text = "إجمالي السعر"
                            .lblTotalWeight.Text = "الوزن الكلي"
                            .lblImage.Text = "الصورة"
                            .lblSoldItem.Text = "القطع المباعة"
                            .colDelete.HeaderText = "حذف"
                            .lblNotes.Text = "ملاحظات"
                            .lblTotalPrice.Text = "إجمالي سعر الفاتورة"
                            .coltest_119.HeaderText = "الباركود"
                            .colDIMO_Type.HeaderText = "الصنف"
                            .coltotal.HeaderText = "السعر"
                            .colDIM_na9awa.HeaderText = "النقاوه"
                            .colDIMO_mezan.HeaderText = "وزن الالماس"
                            .colDIMO_coler.HeaderText = "لون الاماس"
                            .coltest_117.HeaderText = "قصة الالماس"
                            .colsarual.HeaderText = "رقم القطعه"
                            .colval_gold.HeaderText = "العيار"
                            .colGOLD_mezan.HeaderText = "وزن المعدن"
                            .colDIMO_qult.HeaderText = "العدد"
                            .coltest_13.HeaderText = "وزن الحجر1"
                            .coltest_14.HeaderText = "نوع الحجر 1"
                            .coltest_15.HeaderText = "لون الحجر1"
                            .coltest_16.HeaderText = "وزن الحجر2"
                            .coltest_17.HeaderText = "نوع الحجر2"
                            .coltest_18.HeaderText = "لون الحجر2"
                            .coltest_19.HeaderText = "وزن الحجر3"
                            .coltest_110.HeaderText = "نوع الحجر3"
                            .coltest_111.HeaderText = "لون الحجر3"
                            .coltest_116.HeaderText = "الوزن الكلي"
                            .colnotes.HeaderText = "ملاحظات"
                            .colGramPrice.HeaderText = "سعر الجرام"
                            .colSoldItem.HeaderText = "القطعه المباعه"
                            .colCut1.HeaderText = "قصة الحجر1"
                            .colClarity1.HeaderText = "نقاوة الحجر1"
                            .colCut2.HeaderText = "قصة الحجر2"
                            .colClarity2.HeaderText = "نقاوة الحجر2"
                            .colCut3.HeaderText = "قصة الحجر3"
                            .colClarity3.HeaderText = "نقاوة الحجر3"
                            .colDelete.HeaderText = "حذف"
                            .LBLCertificateNo.Text = "رقم الشهاده"
                        End With
                    End If
                Case "DIAMONDEDITADDITEM"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With DiamondEditAddItem
                            .Text = "Diamond Invoice Add Item"
                            .btnSave.Text = "Save"
                            .gbSelectItem.Text = "Select Item"
                            .lblDiamondName.Text = "Type"
                            .lblBarCode.Text = "Barcode"
                            .gbItemData.Text = "Item Details"
                            .lblDiamondColor.Text = "D-Color"
                            .lblDiamondWeight.Text = "D-Carat"
                            .lblDiamondClarity.Text = "D-Clarity"
                            .lblDiamondCut.Text = "D-Cut"
                            .lblQty.Text = "Quantity"
                            .lblItemNo.Text = "Item No."
                            .lblGoldCarat.Text = "Gold-Karat"
                            .lblGoldWeight.Text = "Gold-Wt"
                            .lblStoneWeight.Text = "CS.Wt."
                            .lblStoneName.Text = "CS.Name"
                            .lblStoneColor.Text = "CS.Color"
                            .lblStoneClarity.Text = "CS.Clarity"
                            .lblStoneCut.Text = "CS.Cut"
                            .lblGoldGramPrice.Text = "Gold-Price/gm"
                            .lblCost.Text = "Cost"
                            .lblPrice.Text = "Tag-Price"
                            .lblTotalWeight.Text = "Total Weight"
                            .lblImage.Text = "Photo"
                            .lblSoldItem.Text = "Sold Items"
                            .lblNotes.Text = "Notes"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With DiamondEditAddItem
                            .Text = "فاتورة ألماس / إضافة صنف"
                            .btnSave.Text = "حفظ"
                            .gbSelectItem.Text = "اختر صنفا"
                            .lblDiamondName.Text = "النوع"
                            .lblBarCode.Text = "باركود"
                            .lblPrice.Text = "السعر الإجمالي"
                            .gbItemData.Text = "تفاصيل الصنف"
                            .lblDiamondColor.Text = "لون الألماس"
                            .lblDiamondWeight.Text = "قيراط الألماس"
                            .lblDiamondClarity.Text = "النقاوة"
                            .lblDiamondCut.Text = "القص"
                            .lblQty.Text = "العدد"
                            .lblItemNo.Text = "رقم القطعة"
                            .lblGoldCarat.Text = "عيار الذهب"
                            .lblGoldWeight.Text = "وزن الذهب"
                            .lblStoneWeight.Text = "وزن الحجر"
                            .lblStoneName.Text = "نوع الحجر"
                            .lblStoneColor.Text = "لون الحجر"
                            .lblStoneClarity.Text = "نقاوة الحجر"
                            .lblStoneCut.Text = "قصة الحجر"
                            .lblGoldGramPrice.Text = "سعر الجرام"
                            .lblCost.Text = "التكلفة"
                            .lblPrice.Text = "إجمالي السعر"
                            .lblTotalWeight.Text = "الوزن الكلي"
                            .lblImage.Text = "الصورة"
                            .lblSoldItem.Text = "القطع المباعة"
                            .lblNotes.Text = "ملاحظات"
                        End With
                    End If

                Case "DIAMONDADDITEM"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With DiamondAddItem
                            .Text = "Diamond Add Item"
                            .gbSelectItem.Text = "Select Item"
                            .btnSave.Text = "Save"
                            .btnAdd.Text = "Add Item"
                            .btnUpdate.Text = "Edit"
                            .lblDiamondName.Text = "Type"
                            .lblImage.Text = "Image"
                            .lblTotalWeight.Text = "Total Weight"
                            .lblInvNo.Text = "Invoice No."
                            .lblBarCode.Text = "Barcode"
                            .gbItemData.Text = "Item Details"
                            .lblDiamondColor.Text = "D-Color"
                            .lblDiamondWeight.Text = "D-Carat"
                            .lblDiamondClarity.Text = "D-Clarity"
                            .lblDiamondCut.Text = "D-Cut"
                            .lblQty.Text = "Quantity"
                            .lblItemNo.Text = "Item No."
                            .lblGoldCarat.Text = "Gold-Karat"
                            .lblGoldWeight.Text = "Gold-Wt"
                            .lblStoneWeight.Text = "C Stone. Wt."
                            .lblStoneName.Text = "C Stone. Name"
                            .lblStoneColor.Text = "C Stone. Color"
                            .lblGoldGramPrice.Text = "Gold-Price/gm"
                            .lblCost.Text = "Cost"
                            .lblPrice.Text = "Tag-Price"
                            .lblNotes.Text = "Notes"
                            .lblTotalPrice.Text = "Total Invoice Value"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With DiamondAddItem
                            .Text = "فاتورة ألماس"
                            .btnSave.Text = "حفظ"
                            .btnAdd.Text = "إضافة"
                            .btnUpdate.Text = "تعديل"
                            .lblImage.Text = "الصورة"
                            .lblTotalWeight.Text = "الوزن الكلي"
                            .lblInvNo.Text = "رقم الفاتورة"
                            .gbSelectItem.Text = "اختر صنفا"
                            .lblDiamondName.Text = "النوع"
                            .lblBarCode.Text = "باركود"
                            .lblPrice.Text = "السعر الإجمالي"
                            .gbItemData.Text = "تفاصيل الصنف"
                            .lblDiamondColor.Text = "لون الألماس"
                            .lblDiamondWeight.Text = "قيراط الألماس"
                            .lblDiamondClarity.Text = "النقاوة"
                            .lblDiamondCut.Text = "القص"
                            .lblQty.Text = "العدد"
                            .lblItemNo.Text = "رقم القطعة"
                            .lblGoldCarat.Text = "عيار الذهب"
                            .lblGoldWeight.Text = "وزن الذهب"
                            .lblStoneWeight.Text = "وزن الحجر"
                            .lblStoneName.Text = "نوع الحجر"
                            .lblStoneColor.Text = "لون الحجر"
                            .lblGoldGramPrice.Text = "سعر الجرام"
                            .lblCost.Text = "التكلفة"
                            .lblPrice.Text = "إجمالي السعر"
                            .lblNotes.Text = "ملاحظات"
                            .lblTotalPrice.Text = "إجمالي سعر الفاتورة"
                        End With
                    End If
                Case "GOLDINVOICE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With GoldInvoice
                            .Text = "Gold Invoice"
                            .btnPayPrint.Text = "Pay & Print Invoice"
                            .lblInvoiceDate.Text = "invoice Date"
                            .lblCashier.Text = "Cashier Name"
                            .lblBarCode.Text = "Barcode"
                            .lblNote.Text = "Seller notes on the Invoice"
                            .lblItem.Text = "Select Item"
                            .lblMetalWeight.Text = "G.Weight"
                            .lblPricePerGram.Text = "Gram Price"
                            .lblMetalPrice.Text = "G.Price"
                            .lblKarat.Text = "Karat"
                            .lblMakeCharge.Text = "M.C."
                            .lblStoneWeight.Text = "Stone Weight"
                            .lblStonePrice.Text = "Stone Price"
                            .lblStoneName.Text = "Stone Name"
                            .lblStoneColor.Text = "Stone Color"
                            .lblQty.Text = "Quantity"
                            .lblInvoiceTitle.Text = "Invoice NO"
                            .lblTotalPriceTitle.Text = "Total Price"
                            .lblTotalPrice.Text = "Sell Price"
                            .btnSave.Text = "Save"
                            .gbData.Text = "Enter Invoice Information"
                            .colItemName.HeaderText = "Item Name"
                            .labItemNmeInInvoce.Text = "Item Description"
                            .colGramPrice.HeaderText = "Gram Price"
                            .colGoldWeight.HeaderText = "G.Weight"
                            .colGoledKarat.HeaderText = "Karat"
                            .colGoledPrice.HeaderText = "G.Price"
                            .colGoledMakeCharge.HeaderText = "M.C."
                            .colStonName1.HeaderText = "C.S.Name1"
                            .colStonWeight1.HeaderText = "C.S.Wt1"
                            .colStonColor1.HeaderText = "C.S.Col1"
                            .colStonPrice1.HeaderText = "C.S.Price1"
                            .colStonName2.HeaderText = "C.S.Name2"
                            .colStonWeight2.HeaderText = "C.S.Wt2"
                            .colStonColor2.HeaderText = "C.S.Col2"
                            .colStonPrice2.HeaderText = "C.S.Price2"
                            .colStonName3.HeaderText = "C.S.Name3"
                            .colStonWeight3.HeaderText = "C.S.Wt3"
                            .colStonColor3.HeaderText = "C.S.Col3"
                            .colStonPrice3.HeaderText = "C.S.Price3"
                            .colTotalGoledPrice.HeaderText = "Total Price"
                            .colDelete.HeaderText = "Del"
                            .colModify.HeaderText = "Modify"
                            .colGoledPiecesQuantity.HeaderText = "Pieces Quantity"
                            .lblTaxAm.Text = "Tax Amount"
                            .btnGoldCh.Text = "Gold Exch"
                            .LabItem_Des.Text = "Item Des"
                            .lblbayKarat.Text = "Karat"
                            .Bay_mazanLabel.Text = "G.Weight"
                            .lblNetCaret.Text = "Net Karat"
                            .lblNetWeight.Text = "Net Weight"
                            .lblQunt.Text = "Quantity"
                            .Bay_gram_priceLabel.Text = "Price Per Gram"
                            .LinkLabel1.Text = "Price"
                            .lblGoldPurPrice.Text = "Tax Amount"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With GoldInvoice
                            .Text = "فاتورة بيع ذهب"
                            .btnPayPrint.Text = "دفع وطباعة الفاتورة"
                            .lblInvoiceDate.Text = "تاريخ الفاتورة"
                            .lblCashier.Text = "اسم الكاشير"
                            .lblBarCode.Text = "أدخل الباركود"
                            .lblNote.Text = "ملاحظات البائع"
                            .lblItem.Text = "اختر الصنف"
                            .lblMetalWeight.Text = "وزن الذهب"
                            .lblPricePerGram.Text = "سعر الغرام"
                            .lblMetalPrice.Text = "سعر الذهب"
                            .lblKarat.Text = "العيار"
                            .lblMakeCharge.Text = "المصنعية"
                            .lblStoneWeight.Text = "وزن الفص"
                            .lblStonePrice.Text = "سعر الفص"
                            .lblStoneName.Text = "نوع الفص"
                            .lblStoneColor.Text = "لون الفص"
                            .lblQty.Text = "العدد"
                            .lblInvoiceTitle.Text = "رقم الفاتورة"
                            .lblTotalPriceTitle.Text = "إجمالي مبلغ الفاتورة"
                            .lblTotalPrice.Text = "سعر البيع"
                            .btnSave.Text = "حفظ"
                            .gbData.Text = "أدخل بيانات الفاتورة"
                            .colItemName.HeaderText = "اسم الصنف"
                            .colItemID.HeaderText = "باركود"
                            .colGramPrice.HeaderText = "سعر الجرام"
                            .colGoldWeight.HeaderText = "و.الذهب"
                            .colGoledKarat.HeaderText = "العيار"
                            .colGoledPrice.HeaderText = "سعرالذهب"
                            .colGoledMakeCharge.HeaderText = "مصنعية"
                            .colStonName1.HeaderText = "نوع فص1"
                            .colStonWeight1.HeaderText = "و.فص1"
                            .colStonColor1.HeaderText = "لون فص1"
                            .colStonPrice1.HeaderText = "سعر فص1"
                            .colStonName2.HeaderText = "نوع فص2"
                            .colStonWeight2.HeaderText = "و.فص2"
                            .colStonColor2.HeaderText = "لون فص2"
                            .colStonPrice2.HeaderText = "سعر فص2"
                            .colStonName3.HeaderText = "نوع فص3"
                            .colStonWeight3.HeaderText = "و.فص3"
                            .colStonColor3.HeaderText = "لون فص3"
                            .colStonPrice3.HeaderText = "سعر فص3"
                            .colTotalGoledPrice.HeaderText = "إجمالي السعر"
                            .colDelete.HeaderText = "حذف"
                            .colModify.HeaderText = "تعديل"
                            .colGoledPiecesQuantity.HeaderText = "عدد القطع"
                            .colInvocDateTime.HeaderText = "التاريخ"
                            .labItemNmeInInvoce.Text = "وصف الصنف بالفاتوره"
                            .lblTaxAm.Text = "مبلغ الضريبه"
                            .btnGoldCh.Text = "تبديل ذهب"
                            .LabItem_Des.Text = "وصف الصنف"
                            .lblbayKarat.Text = "العيار"
                            .Bay_mazanLabel.Text = "الوزن"
                            .lblNetCaret.Text = "عيار الصافي"
                            .lblNetWeight.Text = "وزن الصافي"
                            .lblQunt.Text = "العدد"
                            .Bay_gram_priceLabel.Text = "حساب سعر الجرام"
                            .LinkLabel1.Text = "حساب السعر"
                            .lblGoldPurPrice.Text = "اجمالي المبلغ"
                        End With
                    End If
                Case "FRMGOLDSELLEDITREMOVE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With FrmGoldSellEditRemove
                            .lblNote.Text = "Note"
                            .Text = "Gold Invoice"
                            .btnView.Text = "View invoice"
                            .btndelete.Text = "DEL"
                            .btnprint.Text = "Print Invoice"
                            .lblInvoiceDate.Text = "Invoice Date"
                            .lblCashier.Text = "Cashier Name"
                            .lblBarCode.Text = "Barcode"
                            .lblNote.Text = "Seller notes on the Invoice"
                            .lblItem.Text = "Select Item"
                            .lblMetalWeight.Text = "G.Weight"
                            .lblPricePerGram.Text = "Gram Price"
                            .lblMetalPrice.Text = "G.Price"
                            .lblKarat.Text = "Karat"
                            .lblMakeCharge.Text = "M.C."
                            .lblStoneWeight.Text = "Stone Weight"
                            .lblStonePrice.Text = "Stone Price"
                            .lblStoneName.Text = "Stone Name"
                            .lblStoneColor.Text = "Stone Color"
                            .lblQty.Text = "Quantity"
                            .lblInvoiceNo.Text = "Invoice NO"
                            .lblInvoicePrice.Text = "Total Price"
                            .lblTotalPrice.Text = "Sell Price"
                            .btnSave.Text = "Save"
                            .gbData.Text = "Enter Invoice Information"
                            .colItemTotalPrice.HeaderText = "Item Total Price"
                            .colItemName.HeaderText = "Item Name"
                            .labItemNmeInInvoce.Text = "Item Description"
                            .colGramPrice.HeaderText = "Gram Price"
                            .colGoldWeight.HeaderText = "G.Weight"
                            .colGoledKarat.HeaderText = "Karat"
                            .colGoledPrice.HeaderText = "G.Price"
                            .colGoledMakeCharge.HeaderText = "M.C."
                            .colStonName1.HeaderText = "C.S.Name1"
                            .colStonWeight1.HeaderText = "C.S.Wt1"
                            .colStonColor1.HeaderText = "C.S.Col1"
                            .colStonPrice1.HeaderText = "C.S.Price1"
                            .colStonName2.HeaderText = "C.S.Name2"
                            .colStonWeight2.HeaderText = "C.S.Wt2"
                            .colStonColor2.HeaderText = "C.S.Col2"
                            .colStonPrice2.HeaderText = "C.S.Price2"
                            .colStonName3.HeaderText = "C.S.Name3"
                            .colStonWeight3.HeaderText = "C.S.Wt3"
                            .colStonColor3.HeaderText = "C.S.Col3"
                            .colStonPrice3.HeaderText = "C.S.Price3"
                            .colTotalGoledPrice.HeaderText = "Total Price"
                            .colDelete.HeaderText = "Del"
                            .colModify.HeaderText = "Modify"
                            .colItemID.HeaderText = "Barcood"
                            .colItemTotalPrice.HeaderText = "Item Total Price"
                            .colGoledPiecesQuantity.HeaderText = "Pieces Quantity"
                            .colInvocDateTime.HeaderText = "Invoc Date And Time"
                            .lblCash.Text = "Cash"
                            .lblBank.Text = "Bank"
                            .Label2.Text = "Other Payments"
                            .lblPayMethod1.Text = "payment Method"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With FrmGoldSellEditRemove
                            .lblNote.Text = "ملاحظات"
                            .Text = "فاتورة بيع ذهب"
                            .btnView.Text = "عرض الفاتوره"
                            .btndelete.Text = "حزف"
                            .btnprint.Text = "طباعة الفاتورة"
                            .lblInvoiceDate.Text = "تاريخ الفاتورة"
                            .lblCashier.Text = "اسم الكاشير"
                            .lblBarCode.Text = "أدخل الباركود"
                            .lblNote.Text = "ملاحظات البائع"
                            .lblItem.Text = "اختر الصنف"
                            .lblMetalWeight.Text = "وزن الذهب"
                            .lblPricePerGram.Text = "سعر الغرام"
                            .lblMetalPrice.Text = "سعر الذهب"
                            .lblKarat.Text = "العيار"
                            .lblMakeCharge.Text = "المصنعية"
                            .lblStoneWeight.Text = "وزن الفص"
                            .lblStonePrice.Text = "سعر الفص"
                            .lblStoneName.Text = "نوع الفص"
                            .lblStoneColor.Text = "لون الفص"
                            .lblQty.Text = "العدد"
                            .lblInvoiceNo.Text = "رقم الفاتورة"
                            .lblInvoicePrice.Text = "إجمالي مبلغ الفاتورة"
                            .lblTotalPrice.Text = "سعر البيع"
                            .btnSave.Text = "حفظ"
                            .gbData.Text = "أدخل بيانات الفاتورة"
                            .colItemName.HeaderText = "اسم الصنف"
                            .labItemNmeInInvoce.Text = "اسم الصنف بالفاتوره"
                            .colGramPrice.HeaderText = "سعر الجرام"
                            .colGoldWeight.HeaderText = "الوزن"
                            .colGoledKarat.HeaderText = "العيار"
                            .colGoledPrice.HeaderText = "سعر الجرام"
                            .colGoledMakeCharge.HeaderText = "المصنعيه"
                            .colStonName1.HeaderText = "حجر1"
                            .colStonWeight1.HeaderText = "وزن حجر1"
                            .colStonColor1.HeaderText = "لون حجر1"
                            .colStonPrice1.HeaderText = "سعر حجر1"
                            .colStonName2.HeaderText = "حجر1"
                            .colStonWeight2.HeaderText = "وزن حجر2"
                            .colStonColor2.HeaderText = "لون حجر2"
                            .colStonPrice2.HeaderText = "سعر حجر2"
                            .colStonName3.HeaderText = "حجر3"
                            .colStonWeight3.HeaderText = "وزن حجر3"
                            .colStonColor3.HeaderText = "لون حجر3"
                            .colStonPrice3.HeaderText = "سعر حجر3"
                            .colTotalGoledPrice.HeaderText = "اجمالي السعر"
                            .colDelete.HeaderText = "حزف"
                            .colModify.HeaderText = "تعديل"
                            .colGoledPiecesQuantity.HeaderText = "العدد"
                            .colItemID.HeaderText = "باركود"
                            .colItemTotalPrice.HeaderText = "اجمالي سعر الصنف"
                            .colInvocDateTime.HeaderText = "تاريخ ووقت الفاتوره"
                            .lblCash.Text = "كاش"
                            .lblBank.Text = "بنكي"
                            .Label2.Text = "الطريقه"
                            .lblPayMethod1.Text = "عمليات دفع اخري"
                        End With
                    End If
                Case "SILVERSELLEDITREMOVE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With SilverSellEditRemove
                            .lblNote.Text = "Note"
                            .Text = "Silver invoice"
                            .btnView.Text = "View invoice"
                            .btnDeleteInvoice.Text = "DEL"
                            .btnPayPrint.Text = "Print Invoice"
                            .lblInvoiceDate.Text = "Invoice Date"
                            .lblCashier.Text = "Cashier Name"
                            .lblBarCode.Text = "Barcode"
                            .lblNote.Text = "Seller notes on the Invoice"
                            .lblItem.Text = "Select Item"
                            .lblMetalWeight.Text = "S.Weight"
                            .lblPricePerGram.Text = "Gram Price"
                            .lblMetalPrice.Text = "G.Price"
                            .lblKarat.Text = "Karat"
                            .lblMakeCharge.Text = "M.C."
                            .lblStoneWeight.Text = "C.S.Weight"
                            .lblStonePrice.Text = "C.S.Price"
                            .lblStoneName.Text = "C.S.Name"
                            .lblStoneColor.Text = "C.S.Color"
                            .lblQty.Text = "Quantity"
                            .lblInvoiceNo.Text = "Invoice NO"
                            .lblInvoicePrice.Text = "Total Price"
                            .lblTotalPrice.Text = "Sell Price"
                            .btnSave.Text = "Save"
                            .gbData.Text = "Enter Invoice Information"
                            .colItemTotalPrice.HeaderText = "Item Total Price"
                            .colItemName.HeaderText = "Item Name"
                            .labItemNmeInInvoce.Text = "Item Description"
                            .colGramPrice.HeaderText = "Gram Price"
                            .colGoldWeight.HeaderText = "S.Weight"
                            .colGoledKarat.HeaderText = "Karat"
                            .colGoledPrice.HeaderText = "S.Price"
                            .colGoledMakeCharge.HeaderText = "M.C."
                            .colStonName1.HeaderText = "C.S.Name1"
                            .colStonWeight1.HeaderText = "C.S.Wt1"
                            .colStonColor1.HeaderText = "C.S.Col1"
                            .colStonPrice1.HeaderText = "C.S.Price1"
                            .colStonName2.HeaderText = "C.S.Name2"
                            .colStonWeight2.HeaderText = "C.S.Wt2"
                            .colStonColor2.HeaderText = "C.S.Col2"
                            .colStonPrice2.HeaderText = "C.S.Price2"
                            .colStonName3.HeaderText = "C.S.Name3"
                            .colStonWeight3.HeaderText = "C.S.Wt3"
                            .colStonColor3.HeaderText = "C.S.Col3"
                            .colStonPrice3.HeaderText = "C.S.Price3"
                            .colTotalGoledPrice.HeaderText = "Total Price"
                            .colDelete.HeaderText = "Del"
                            .colModify.HeaderText = "Modify"
                            .colItemID.HeaderText = "Barcood"
                            .colItemTotalPrice.HeaderText = "Item Total Price"
                            .colGoledPiecesQuantity.HeaderText = "Pieces Quantity"
                            .colInvocDateTime.HeaderText = "Invoc Date And Time"
                            .lblCash.Text = "Cash"
                            .lblBank.Text = "Bank"
                            .Label2.Text = "Other Payments"
                            .lblPayMethod1.Text = "payment Method"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With SilverSellEditRemove
                            .lblNote.Text = "ملاحظات"
                            .Text = "فاتورة بيع فضه"
                            .btnView.Text = "عرض الفاتوره"
                            .btnDeleteInvoice.Text = "حزف الفاتوره"
                            .btnPayPrint.Text = "طباعة الفاتورة"
                            .lblInvoiceDate.Text = "تاريخ الفاتورة"
                            .lblCashier.Text = "اسم الكاشير"
                            .lblBarCode.Text = "أدخل الباركود"
                            .lblNote.Text = "ملاحظات البائع"
                            .lblItem.Text = "اختر الصنف"
                            .lblMetalWeight.Text = "وزن الفضه"
                            .lblPricePerGram.Text = "سعر الغرام"
                            .lblMetalPrice.Text = "سعر الفضه"
                            .lblKarat.Text = "العيار"
                            .lblMakeCharge.Text = "المصنعية"
                            .lblStoneWeight.Text = "وزن الفص"
                            .lblStonePrice.Text = "سعر الفص"
                            .lblStoneName.Text = "نوع الفص"
                            .lblStoneColor.Text = "لون الفص"
                            .lblQty.Text = "العدد"
                            .lblInvoiceNo.Text = "رقم الفاتورة"
                            .lblInvoicePrice.Text = "إجمالي مبلغ الفاتورة"
                            .lblTotalPrice.Text = "سعر البيع"
                            .btnSave.Text = "حفظ"
                            .gbData.Text = "أدخل بيانات الفاتورة"
                            .colItemName.HeaderText = "اسم الصنف"
                            .labItemNmeInInvoce.Text = "اسم الصنف بالفاتوره"
                            .colGramPrice.HeaderText = "سعر الجرام"
                            .colGoldWeight.HeaderText = "الوزن"
                            .colGoledKarat.HeaderText = "العيار"
                            .colGoledPrice.HeaderText = "سعر الجرام"
                            .colGoledMakeCharge.HeaderText = "المصنعيه"
                            .colStonName1.HeaderText = "حجر1"
                            .colStonWeight1.HeaderText = "وزن حجر1"
                            .colStonColor1.HeaderText = "لون حجر1"
                            .colStonPrice1.HeaderText = "سعر حجر1"
                            .colStonName2.HeaderText = "حجر1"
                            .colStonWeight2.HeaderText = "وزن حجر2"
                            .colStonColor2.HeaderText = "لون حجر2"
                            .colStonPrice2.HeaderText = "سعر حجر2"
                            .colStonName3.HeaderText = "حجر3"
                            .colStonWeight3.HeaderText = "وزن حجر3"
                            .colStonColor3.HeaderText = "لون حجر3"
                            .colStonPrice3.HeaderText = "سعر حجر3"
                            .colTotalGoledPrice.HeaderText = "اجمالي السعر"
                            .colDelete.HeaderText = "حزف"
                            .colModify.HeaderText = "تعديل"
                            .colGoledPiecesQuantity.HeaderText = "العدد"
                            .colItemID.HeaderText = "باركود"
                            .colItemTotalPrice.HeaderText = "اجمالي سعر الصنف"
                            .colInvocDateTime.HeaderText = "تاريخ ووقت الفاتوره"
                            .lblCash.Text = "كاش"
                            .lblBank.Text = "بنكي"
                            .Label2.Text = "الطريقه"
                            .lblPayMethod1.Text = "عمليات دفع اخري"
                        End With
                    End If
                Case "SILVERINVOICE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With SilverInvoice
                            .Text = "Silver Invoice"
                            .btnPayPrint.Text = "Pay & Print Invoice"
                            .lblInvoiceDate.Text = "invoice Date"
                            .lblCashier.Text = "Cashier Name"
                            .lblBarCode.Text = "Barcode"
                            .lblNote.Text = "Seller notes on the Invoice"
                            .lblItem.Text = "Select Item"
                            .lblMetalWeight.Text = "S.Weight"
                            .lblPricePerGram.Text = "Gram Price"
                            .lblMetalPrice.Text = "S.Price"
                            .lblKarat.Text = "Karat"
                            .lblMakeCharge.Text = "M.C."
                            .lblStoneWeight.Text = "C.S.Weight"
                            .lblStonePrice.Text = "C.S.Price"
                            .lblStoneName.Text = "C.S.Name"
                            .lblStoneColor.Text = "C.S.Color"
                            .lblQty.Text = "Quantity"
                            .lblInvoiceTitle.Text = "Invoice NO"
                            .lblTotalPriceTitle.Text = "Total Price"
                            .lblTotalPrice.Text = "Sell Price"
                            .btnSave.Text = "Save"
                            .gbData.Text = "Enter Invoice Information"
                            .colItemName.HeaderText = "Item Name"
                            .labItemNmeInInvoce.Text = "Item Description"
                            .colGramPrice.HeaderText = "Gram Price"
                            .colGoldWeight.HeaderText = "S.Weight"
                            .colGoledKarat.HeaderText = "Karat"
                            .colGoledPrice.HeaderText = "S.Price"
                            .colGoledMakeCharge.HeaderText = "M.C."
                            .colStonName1.HeaderText = "C.S.Name1"
                            .colStonWeight1.HeaderText = "C.S.Wt1"
                            .colStonColor1.HeaderText = "C.S.Col1"
                            .colStonPrice1.HeaderText = "C.S.Price1"
                            .colStonName2.HeaderText = "C.S.Name2"
                            .colStonWeight2.HeaderText = "C.S.Wt2"
                            .colStonColor2.HeaderText = "C.S.Col2"
                            .colStonPrice2.HeaderText = "C.S.Price2"
                            .colStonName3.HeaderText = "C.S.Name3"
                            .colStonWeight3.HeaderText = "C.S.Wt3"
                            .colStonColor3.HeaderText = "C.S.Col3"
                            .colStonPrice3.HeaderText = "C.S.Price3"
                            .colTotalGoledPrice.HeaderText = "Total Price"
                            .colDelete.HeaderText = "Del"
                            .colModify.HeaderText = "Modify"
                            .colGoledPiecesQuantity.HeaderText = "Pieces Quantity"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With SilverInvoice
                            .Text = "فاتورة بيع فضه"
                            .btnPayPrint.Text = "دفع وطباعة الفاتورة"
                            .lblInvoiceDate.Text = "تاريخ الفاتورة"
                            .lblCashier.Text = "اسم الكاشير"
                            .lblBarCode.Text = "أدخل الباركود"
                            .lblNote.Text = "ملاحظات البائع"
                            .lblItem.Text = "اختر الصنف"
                            .lblMetalWeight.Text = "وزن الفضه"
                            .lblPricePerGram.Text = "سعر الغرام"
                            .lblMetalPrice.Text = "سعر الفضه"
                            .lblKarat.Text = "العيار"
                            .lblMakeCharge.Text = "المصنعية"
                            .lblStoneWeight.Text = "وزن الفص"
                            .lblStonePrice.Text = "سعر الفص"
                            .lblStoneName.Text = "نوع الفص"
                            .lblStoneColor.Text = "لون الفص"
                            .lblQty.Text = "العدد"
                            .lblInvoiceTitle.Text = "رقم الفاتورة"
                            .lblTotalPriceTitle.Text = "إجمالي مبلغ الفاتورة"
                            .lblTotalPrice.Text = "سعر البيع"
                            .btnSave.Text = "حفظ"
                            .gbData.Text = "أدخل بيانات الفاتورة"
                            .colItemName.HeaderText = "اسم الصنف"
                            .colItemID.HeaderText = "باركود"
                            .colGramPrice.HeaderText = "سعر الجرام"
                            .colGoldWeight.HeaderText = "و.الفضه"
                            .colGoledKarat.HeaderText = "العيار"
                            .colGoledPrice.HeaderText = "سعرالفضه"
                            .colGoledMakeCharge.HeaderText = "مصنعية"
                            .colStonName1.HeaderText = "نوع فص1"
                            .colStonWeight1.HeaderText = "و.فص1"
                            .colStonColor1.HeaderText = "لون فص1"
                            .colStonPrice1.HeaderText = "سعر فص1"
                            .colStonName2.HeaderText = "نوع فص2"
                            .colStonWeight2.HeaderText = "و.فص2"
                            .colStonColor2.HeaderText = "لون فص2"
                            .colStonPrice2.HeaderText = "سعر فص2"
                            .colStonName3.HeaderText = "نوع فص3"
                            .colStonWeight3.HeaderText = "و.فص3"
                            .colStonColor3.HeaderText = "لون فص3"
                            .colStonPrice3.HeaderText = "سعر فص3"
                            .colTotalGoledPrice.HeaderText = "إجمالي السعر"
                            .colDelete.HeaderText = "حذف"
                            .colModify.HeaderText = "تعديل"
                            .colGoledPiecesQuantity.HeaderText = "عدد القطع"
                            .colInvocDateTime.HeaderText = "التاريخ"
                            .labItemNmeInInvoce.Text = "وصف الصنف بالفاتوره"
                        End With
                    End If
                Case "AUCTIONINVOICE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With AuctionInvoice
                            .gbInvoice.Text = "Invoice Data"
                            .lblCashier.Text = "Cashier"
                            .lblBarCode.Text = "BarCode"
                            .lblItemName.Text = "Category"
                            .lblBrand.Text = "Brand"
                            .lblItemStatus.Text = "Item Condition"
                            .lblModel.Text = "Model"
                            .lblReceiveDate.Text = "Receive Date"
                            .lblGuaranteeDate.Text = "Guarantee Date"
                            .lblGuaranteeStatus.Text = "Guarantee Status"
                            .lblSerialNo.Text = "Serial No."
                            .lblDetails.Text = "Details"
                            .lblNote.Text = "Notes"
                            .lblItemPicture.Text = "Photo"
                            .lblTotalPrice.Text = "Total Price"
                            .lblCash.Text = "Cash"
                            .lblKNET.Text = "K-NET"
                            .lblLink.Text = "Link"
                            .btnPayPrint.Text = "Pay & Print"
                            .Text = "Sell/Auctions"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With AuctionInvoice
                            .gbInvoice.Text = "بيانات الفاتورة"
                            .lblCashier.Text = "الكاشير"
                            .lblBarCode.Text = "الباركود"
                            .lblItemName.Text = "النوع"
                            .lblBrand.Text = "الماركة"
                            .lblItemStatus.Text = "حالة السلعة"
                            .lblModel.Text = "الموديل"
                            .lblReceiveDate.Text = "تاريخ الاستلام"
                            .lblGuaranteeDate.Text = "تاريخ الضمان"
                            .lblGuaranteeStatus.Text = "حالة الضمان"
                            .lblSerialNo.Text = "السيريال"
                            .lblDetails.Text = "التفاصيل"
                            .lblNote.Text = "ملاحظات"
                            .lblItemPicture.Text = "الصورة"
                            .lblTotalPrice.Text = "سعر البيع"
                            .lblCash.Text = "كاش"
                            .lblKNET.Text = "كي نت"
                            .lblLink.Text = "رابط"
                            .btnPayPrint.Text = "دفع وطباعة الفاتورة"
                            .Text = "بيع/مزادات"
                        End With
                    End If
                Case "MIN_SALES"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With min_Sales
                            .btnGold.Text = "Gold"
                            .btnSilver.Text = "Silver"
                            .btnDiamond.Text = "Diamonds"
                            .btnAuction.Text = "Auctions"
                            .btnClock.Text = "Watches & Brands & Stone"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With min_Sales
                            .btnGold.Text = "ذهب"
                            .btnSilver.Text = "فضة"
                            .btnDiamond.Text = "ألماس"
                            .btnAuction.Text = "مزادات"
                            .btnClock.Text = "ساعات وماركات واحجار"
                        End With
                    End If
                Case "MIN_BUY"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With min_Buy
                            .btnGold.Text = "Gold"
                            .btnSilver.Text = "Silver"
                            .btnDiamond.Text = "Diamonds"
                            .btnAccessories.Text = "Watches & Brands & Stone"
                            .btnCompanies.Text = "Companies"
                            .btnWorkShops.Text = "WorkShops"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With min_Buy
                            .btnGold.Text = "ذهب"
                            .btnSilver.Text = "فضة"
                            .btnDiamond.Text = "ألماس"
                            .btnAccessories.Text = "ساعات وماركات واحجار "
                            .btnCompanies.Text = "شركات"
                            .btnWorkShops.Text = "ورش التصنيع"
                        End With
                    End If
                Case "MIN_STOCK"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With min_Stock
                            .btnGold.Text = "Gold"
                            .btnSilver.Text = "Silver"
                            .btnDiamond.Text = "Diamonds"
                            '.btnAuction.Text = "Auctions"
                            '.btnClock.Text = "Watches"
                            '.btnAccessories.Text = "Precious Jewelry"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي

                        With min_Stock
                            .btnGold.Text = "ذهب"
                            .btnSilver.Text = "فضة"
                            .btnDiamond.Text = "ألماس"
                            '.btnAuction.Text = "مزادات"
                            '.btnClock.Text = "ساعات"
                            '.btnAccessories.Text = "مجوهرات ثمينة"
                        End With
                    End If

                Case "MIN_BARCODE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With min_BarCode
                            .btnGold.Text = "Gold"
                            .btnSilver.Text = "Silver"
                            .btnDiamond.Text = "Diamonds"
                            .btnAuction.Text = "Auction"
                            .btnAccessories.Text = "Watches & Brands & Stone"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With min_BarCode
                            .btnGold.Text = "ذهب"
                            .btnSilver.Text = "فضة"
                            .btnDiamond.Text = "ألماس"
                            .btnAuction.Text = "مزادات"
                            .btnAccessories.Text = "ساعات وماركات واحجار"
                        End With
                    End If

                Case "MIN_ITEMS"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With min_Items
                            .btnGold.Text = "Gold"
                            .btnSilver.Text = "Silver"
                            .btnDiamond.Text = "Diamonds"
                            .btnAuction.Text = "Auctions"
                            .btnClock.Text = "Watches & Brands & Stone"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With min_Items
                            .btnGold.Text = "ذهب"
                            .btnSilver.Text = "فضة"
                            .btnDiamond.Text = "ألماس"
                            .btnAuction.Text = "مزادات"
                            .btnClock.Text = "ساعات وماركات واحجار"
                        End With
                    End If

                Case "GOLDINVOICEPAY"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With GoldInvoicePay
                            .Text = "Payment"
                            .btnSave.Text = "Save"
                            .btnPrint.Text = "Print"
                            .lblInvoiceNo.Text = "Invoice Number"
                            .lblPrice.Text = "Total Bill"
                            .lblRemaining.Text = "Remaining Amount"
                            .lblKNET.Text = "Bank"
                            .lblCash.Text = "Gold Exchange"
                            '.BtnAddReceipt.Text = "Payment Receipt"
                            .gbInvoiceDetails.Text = "Invoice Details"
                            .chkAutoClose.Text = "Auto Close"
                            '.chkEngInvoice.Text = "English Invoice"
                            .gbPayDetails.Text = "Payment Statement"
                            .rbCash.Text = "Gold Exchange"
                            .rbCredit.Text = "Credit"
                            '.lblPayMethod.Text = "Pay With"
                            .cmbPayMethod.Items.Clear()
                            .cmbPayMethod.Items.Add("K-NET")
                            .cmbPayMethod.Items.Add("Master Card")
                            .cmbPayMethod.Items.Add("Visa")
                            .cmbPayMethod.Items.Add("Link")
                            .lblPayMethod1.Text = "Other payment"
                            .RadAcc.Text = "Accountant Copy"
                            .RadCastm.Text = "Customer Copy"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With GoldInvoicePay
                            .Text = "بيانات الدفع"
                            .btnSave.Text = "حفظ"
                            .btnPrint.Text = "طباعة"
                            .lblInvoiceNo.Text = "رقم الفاتورة"
                            .lblPrice.Text = "إجمالي الفاتورة"
                            .lblRemaining.Text = "باقي المبلغ"
                            .lblKNET.Text = "بنكي"
                            .lblCash.Text = "تبديل ذهب"
                            '.BtnAddReceipt.Text = "صورة ايصال الدفع"
                            .gbInvoiceDetails.Text = "بيان الفاتورة"
                            .chkAutoClose.Text = "إغلاق تلقائي"
                            '.chkEngInvoice.Text = "فاتورة إنجليزي"
                            .gbPayDetails.Text = "بيانات الدفع"
                            .rbCash.Text = "نقدي"
                            .rbCredit.Text = "أجل"
                            .cmbPayMethod.Items.Clear()
                            .cmbPayMethod.Items.Add("كي-نت")
                            .cmbPayMethod.Items.Add("ماستر")
                            .cmbPayMethod.Items.Add("فيزا")
                            .cmbPayMethod.Items.Add("رابط")
                            .lblPayMethod1.Text = "عمليات دفع اخري"
                            .RadAcc.Text = "نسخة المحاسبه"
                            .RadCastm.Text = "نسخة العميل"
                        End With
                    End If

                Case "FRMEXCELIMPORT"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With frmExcelImport
                            .Text = "Import From Excel"
                            .gbLoad.Text = "File Path"
                            .lblFileName.Text = "File Name"
                            .lblSheetName.Text = "Sheet Name"
                            .btnSave.Text = "Save"
                            .ChkDuplicate.Text = "Del Duplicate Barcodes"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With frmExcelImport
                            .Text = "استيراد من إكسل"
                            .btnSave.Text = "حفظ"
                            .gbLoad.Text = "مسار الملف"
                            .lblFileName.Text = "اسم الملف"
                            .lblSheetName.Text = "اسم الورقة"
                            .btnSave.Text = "حفظ"
                            .ChkDuplicate.Text = "حزف الباركود المكرر"
                        End With
                    End If

                Case "DIAMONDADDITEMDETAILS"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With DiamondAddItemDetails
                            .LabDateDiamItem.Text = "Date Created"
                            .labSupplier.Text = "Supplier"
                            .LabUser.Text = "User Created"
                            .btnNew.Text = "New"
                            .btnSave.Text = "Save"
                            .btnPrintBarCode.Text = "Print Barcode"
                            .btnExcelImport.Text = "Excel Import"
                            .btnEdit.Text = "Edit"
                            .lblItemName.Text = "Item Name"
                            .DIM_na9awaLabel.Text = "D.Clarity"
                            .Ext_colerLabel.Text = "D.Color"
                            .lblItemNo.Text = "Item No."
                            .lblCut.Text = "D.Cut"
                            .lblPrice.Text = "Tag/Label Price"
                            .DIMO_mezanLabel.Text = "D.Carat"
                            .cmbMetalType.Items.Add("Gold Weight")
                            .cmbMetalType.Items.Add("Silver Weight")
                            .lblGoldKarat.Text = "Metal Karat"
                            .lblCost.Text = "Cost"
                            .lblCode.Text = "Certificate No."
                            .lblQty.Text = "Qty"
                            .lblBarCode.Text = "BarCode"
                            .colQty.HeaderText = "Quantity"
                            .colSW1.HeaderText = "CS.Wt1"
                            .colSN1.HeaderText = "CS.Nm1"
                            .colSC1.HeaderText = "CS.Clr 1"
                            .colSW2.HeaderText = "CS.Wt2"
                            .colSN2.HeaderText = "CS.Nm2"
                            .colSC2.HeaderText = "CS.Clr2"
                            .colSW3.HeaderText = "CS.Wt3"
                            .colSN3.HeaderText = "CS.Nm3"
                            .colSC3.HeaderText = "CS.Clr3"
                            .colDelete.HeaderText = "Del"
                            .colUser.HeaderText = "User Name"
                            .ColCertificateNo.HeaderText = "Certificate No."
                            .colSupplier.HeaderText = "Supplier"
                            .colID.HeaderText = "No."
                            .colItemName.HeaderText = "Item Name"
                            .colCalrity.HeaderText = "D.Clarity"
                            .colColor.HeaderText = "D.Color"
                            .colDWeight.HeaderText = "D.Carat"
                            .colDCut.HeaderText = "D.Cut"
                            .colItemNo.HeaderText = "Item No."
                            .colGWeight.HeaderText = "Metal-Wt"
                            .colKarat.HeaderText = "Metal-Karat"
                            .colPrice.HeaderText = "Tag Price"
                            .colCost.HeaderText = "Cost"
                            .colSC1.HeaderText = "CS Clr1"
                            .colSN1.HeaderText = "CS Type1"
                            .colSW1.HeaderText = "CS Wt1"
                            .colSC2.HeaderText = "CS Clr2"
                            .colSN2.HeaderText = "CS Type2"
                            .colSW2.HeaderText = "CS Wt2"
                            .colSC3.HeaderText = "CS Clr3"
                            .colSN3.HeaderText = "CS Type3"
                            .colSW3.HeaderText = "CS Wt3"
                            .colQty.HeaderText = "Qty"
                            .colItemNote.HeaderText = "Item Note"
                            .colTotalWeight.HeaderText = "Total Wt"
                            .colBarCodeString.HeaderText = "BarCode"
                            .btnPhoto.Text = "Item Photo"
                            .btnDocumentsImage.Text = "Documents Photo"
                            .lblSW.Text = "CS.Weight"
                            .lblSN.Text = "CS.Name"
                            .lblSC.Text = "CS.Color"
                            .lblStoneCut.Text = "CS. Cut"
                            .lblStoneClarity.Text = "CS. Clarity"
                            .lbl1.Text = "1"
                            .lbl2.Text = "2"
                            .lbl3.Text = "3"
                            .lblTotalWeight.Text = "Total Weight"
                            .lblCostToSeller.Text = "Cost To Seller"
                            .TaxExemptCheckBox.Text = "Exempt"
                            .cmbStoneWeightType1.Items.Clear()
                            .cmbStoneWeightType1.Items.Add("ct")
                            .cmbStoneWeightType1.Items.Add("gm")
                            .cmbStoneWeightType2.Items.Clear()
                            .cmbStoneWeightType2.Items.Add("ct")
                            .cmbStoneWeightType2.Items.Add("gm")
                            .cmbStoneWeightType3.Items.Clear()
                            .cmbStoneWeightType3.Items.Add("ct")
                            .cmbStoneWeightType3.Items.Add("gm")
                            .Text = "Add Diamond Item Details"
                            .LabtemNote.Text = "Item Note"
                            .ChkBar.Text = "BarCode"
                            .ChkCertificateNo.Text = "Certificate No."
                            .chkItemNO.Text = "Item No."
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With DiamondAddItemDetails
                            .labSupplier.Text = "المورد"
                            .LabDateDiamItem.Text = "تاريخ الاضافه"
                            .LabUser.Text = "اسم المستخدم"
                            .btnNew.Text = "جديد"
                            .btnSave.Text = "حفظ"
                            .btnPrintBarCode.Text = "طباعة الباركود"
                            .btnExcelImport.Text = "إضافة إكسل"
                            .btnEdit.Text = "تعديل"
                            .lblItemName.Text = "اسم الصنف"
                            .DIM_na9awaLabel.Text = "نقاوة الألماس"
                            .Ext_colerLabel.Text = "لون الألماس"
                            .lblItemNo.Text = "رقم القطعة"
                            .lblCut.Text = "قصة الألماس"
                            .lblPrice.Text = "سعر البيع"
                            .DIMO_mezanLabel.Text = "وزن الألماس"
                            .cmbMetalType.Items.Add("وزن الذهب")
                            .cmbMetalType.Items.Add("وزن الفضه")
                            .lblGoldKarat.Text = "عيار المعدن"
                            .lblCost.Text = "تكلفة الشراء"
                            .lblCode.Text = "رقم الشهاده"
                            .lblBarCode.Text = "باركود"
                            .lblQty.Text = "العدد"
                            .colID.HeaderText = "الرقم"
                            .colQty.HeaderText = "العدد"
                            .colItemName.HeaderText = "اسم الصنف"
                            .colCalrity.HeaderText = "نقاوة الألماس"
                            .colColor.HeaderText = "لون الألماس"
                            .colDWeight.HeaderText = "وزن الألماس"
                            .colDCut.HeaderText = "قصة الألماس"
                            .colItemNo.HeaderText = "رقم القطعة"
                            .colGWeight.HeaderText = "وزن المعدن"
                            .colKarat.HeaderText = "عيار المعدن"
                            .colPrice.HeaderText = "سعر البيع"
                            .colCost.HeaderText = "تكلفة الشراء"
                            .colSW1.HeaderText = "وزن حجر 1"
                            .colSN1.HeaderText = "نوع حجر 1"
                            .colSC1.HeaderText = "لون حجر 1"
                            .colSW2.HeaderText = "وزن حجر 2"
                            .colSN2.HeaderText = "نوع حجر 2"
                            .colSC2.HeaderText = "لون حجر 2"
                            .colSW3.HeaderText = "وزن حجر 3"
                            .colSN3.HeaderText = "نوع حجر 3"
                            .colSC3.HeaderText = "لون حجر 3"
                            .colItemNote.HeaderText = "ملاحظات"
                            .colDelete.HeaderText = "حذف "
                            .colBarCodeString.HeaderText = "باركود"
                            .colUser.HeaderText = "اسم المستخدم"
                            .ColCertificateNo.HeaderText = "رقم الشهاده"
                            .colSupplier.HeaderText = "المورد"
                            .btnPhoto.Text = "صورة القطعة"
                            .btnDocumentsImage.Text = "صورة الشهادات"
                            .lblSW.Text = "وزن الحجر"
                            .lblSN.Text = "نوع الحجر"
                            .lblSC.Text = "لون الحجر"
                            .lbl1.Text = "1"
                            .lbl2.Text = "2"
                            .lbl3.Text = "3"
                            .lblTotalWeight.Text = "وزن كلي"
                            .colTotalWeight.HeaderText = "وزن كلي"
                            .cmbStoneWeightType1.Items.Clear()
                            .cmbStoneWeightType1.Items.Add("ق")
                            .cmbStoneWeightType1.Items.Add("جم")
                            .cmbStoneWeightType2.Items.Clear()
                            .cmbStoneWeightType2.Items.Add("ق")
                            .cmbStoneWeightType2.Items.Add("جم")
                            .cmbStoneWeightType3.Items.Clear()
                            .cmbStoneWeightType3.Items.Add("ق")
                            .cmbStoneWeightType3.Items.Add("جم")
                            .Text = "إضافة صنف ألماس جديد"
                            .LabtemNote.Text = "ملاحظات"
                            .ChkBar.Text = "باركود"
                            .ChkCertificateNo.Text = "رقم الشهاده"
                            .chkItemNO.Text = "رقم القطعه"
                        End With
                    End If
                Case "FRMMAIN"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With frmMain
                            .txtTotalAmoun.Text = "Total Amoun"
                            .txtCachAmount.Text = "Cach Amount"
                            .txtBankAmount.Text = "Bank Amount"
                            .txtMakeCharge.Text = "Make Charge"
                            .BtnSalesDetails.Text = "Financial Analysis System"
                            .wholesaleReport.Text = "Wholesale Report"
                            .wholesaleInvView.Text = "View Bills"
                            .lblTechSupportEnd.Text = "Tech Support End Date"
                            .lblTechSupportEnd.Left = 3
                            .dtEndDate.Left = .lblTechSupportEnd.Left + .lblTechSupportEnd.Width + 5
                            .btnSell.Text = "Sales screen"
                            .btnBarCode.Text = "Barcode"
                            .btnItem.Text = "Item"
                            .btnKarat.Text = "Item Transfers"
                            .btnExpense.Text = "Expenses"
                            .btnReport.Text = "Reports"
                            .btnStock.Text = "Inventory"
                            .btnBuy.Text = "Purchases"
                            .btnBulkSell.Text = "WholeSale"
                            .btnBackup.Text = "Backup"
                            .btnUpdate.Text = "Update"
                            .lblUser.Text = "User Name"
                            .mnuSettings.Text = "System Settings"
                            .mnuSettingsMain.Text = "Main Settings"
                            .tsSettingsMainCompanyData.Text = "Company Details"
                            .tsSettingsMainCountryOfOrigin.Text = "Manufacturing Source"
                            .tsSettingsMainGramPrice.Text = "Carat Prices"
                            .mnuSettingsDefinition.Text = "Definitions"
                            .tsSettingsDefinitionStoneName.Text = "Stone Name"
                            .tsSettingsDefinitionStoneColor.Text = "Stone Color"
                            .tsSettingsDefinitionDiamondCut.Text = "Diamond Cut"
                            .tsSettingsDefinitionAddItemCategory.Text = "Add Categories"
                            .tsSettingsDefinitionBrands.Text = "Add Brands"
                            .tsSettingsDefinitionItemName.Text = "Add Item Names"
                            .mnuSettingsLanguage.Text = "Select Language"
                            .tsSettingsLanguageArabic.Text = "العربية"
                            .tsSettingsLanguageEnglish.Text = "English"
                            .tsSettingsProgrammer.Text = "Programmer Settings"
                            .mnuReport.Text = "Reports"
                            .mnuReportSell.Text = "Daily Sales Reports"
                            .mnuReportSellView.Text = "Review Bills"
                            .tsReportSellViewGold.Text = "Gold"
                            .tsReportSellViewDiamond.Text = "Diamonds"
                            .tsReportSellViewSilver.Text = "Silver"
                            .tsReportSellViewAuction.Text = "Auctions"
                            .tsReportSellViewAccessories.Text = "Watches & Brands & Stone"
                            .mnuReportSellDetailed.Text = "Multiple Detailed Search"
                            .tsReportSellDetailedGold.Text = "Gold"
                            .tsReportSellDetailedSilver.Text = "Silver"
                            .tsReportSellDetailedDiamond.Text = "Diamond"
                            '.mnuReportWeight.Text = "Report Weight"
                            .tsReportSellDetailedSilver.Text = "Silver"
                            .tsReportSellDetailedAuction.Text = "Auctions"
                            .tsReportSellDetailedAccessories.Text = "Watches & Brands & Stone"
                            .mnuReportSellShort.Text = "Short Multiple Search"
                            .tsReportSellShortGold.Text = "Gold"
                            .tsReportSellShortSilver.Text = "Silver"
                            .tsReportSellShortDiamond.Text = "Diamond"
                            .tsReportSellShortAuction.Text = "Auctions"
                            .tsReportSellShortAccessories.Text = "Watches & Brands & Stone"
                            .mnuReportItemByCarat.Text = "Item Sale By Carat"
                            .tsReportItemByCaratGold.Text = "Gold"
                            .tsReportItemByCaratSilver.Text = "Silver"
                            .mnuReportSellViewDeleted.Text = "Deleted Invoices"
                            .tsReportSellViewGoldDeleted.Text = "Gold"
                            .tsReportSellViewSilverDeleted.Text = "Silver"
                            .mnuReportItems.Text = "Items Reports"
                            .tsReportCustomers.Text = "Registered Customers"
                            .tsReportExpenses.Text = "Exprenses Report"
                            .mnuReportBuy.Text = "Purchase Reports"
                            .mnuReportBuyDetailed.Text = "Detailed Report"
                            .tsReportBuyDetailedGold.Text = "Gold"
                            .tsReportBuyDetailedSilver.Text = "Silver"
                            .tsReportBuyDetailedDiamond.Text = "Diamond"
                            .tsReportBuyDetailedAuction.Text = "Auctions"
                            .tsReportBuyDetailedAccessories.Text = "Watches & Brands & Stone"
                            .mnuReportBuyShort.Text = "Summary Report"
                            .tsReportBuyShortGold.Text = "Gold"
                            .tsReportBuyShortSilver.Text = "Silver"
                            .tsReportBuyShortDiamond.Text = "Diamond"
                            .tsReportBuyShortAccessories.Text = "Watches & Brands & Stone"
                            .mnuReportBuyView.Text = "View Bills"
                            .tsReportBuyViewGold.Text = "Gold"
                            .tsReportBuyViewSilver.Text = "Silver"
                            .tsReportBuyViewDiamond.Text = "Diamond"
                            .tsReportBuyViewAccessories.Text = "Watches & Brands & Stone"
                            .tsReportCivilIDPrint.Text = "Print Civil ID"
                            .mnuUserManagement.Text = "User Management"
                            .tsUserManagementUser.Text = "Add User"
                            .tsUserManagementCashier.Text = "Add Cashier"
                            .mnuTransactionsSell.Text = "Sale"
                            .mnuTransactions.Text = "Transactions"
                            .tsTransactionsSellGold.Text = "Edit/Delete Gold"
                            .tsTransactionsSellSilver.Text = "Edit/Delete Silver"
                            .tsTransactionsSellDiamond.Text = "Edit/Delete Diamonds"
                            .tsTransactionsSellAuction.Text = "Edit/Delete Auctions"
                            .tsTransactionsSellAccessories.Text = "Edit/Delete Accessories"
                            '.tsTransactionsAddGold.Text = "Receive issued / received Gold"
                            .tsGoldVoucherReceive.Text = "Gold Disbursement Voucher"
                            .tsTransactionsPaymentVoucher.Text = "Bond issued/received cash"
                            '.tsTransactionsReceiptVoucher.Text = "Voucher Cash Receipt"
                            .mnuTransactionsPayInstallment.Text = "Installment Pay"
                            .tsTransactionsPayInstallmentGoldSilver.Text = "Gold/Silver"
                            .tsTransactionsPayInstallmentDiamond.Text = "Diamond"
                            .tsTransactionsPayInstallmentAccessories.Text = "Watches & Brands & Stone"
                            '.mnuExpenses.Text = "Expenses"
                            '.mnuExpensesReceiptVoucher.Text = "Catch Receipt"
                            '.tsExpensesReceiptVoucherView.Text = "Revision"
                            '.tsExpensesReceiptVoucherCreateNew.Text = "New Construction"
                            '.mnuExpensesReports.Text = "Reports"
                            '.tsExpensesReportsReceiptVoucher.Text = "Catch Receipt"
                            '.tsExpensesReportsPaymentVoucher.Text = "Receipt"
                            '.tsExpensesReportsBalance.Text = "Arbitrage"
                            .mnuTransactionsBuy.Text = "Buy"
                            .tsTransactionsBuyGold.Text = "Edit/Delete Gold"
                            '.tsGoldVoucherReceive.Text = "Bond issued/received Gold"
                            .tsGoldVoucher.Text = "Gold Receipt Voucher"
                            '.mnuExpensesPaymentVoucher.Text = "Receipt"
                            '.tsExpensesPaymentVoucherView.Text = "Revision"
                            '.tsExpensesPaymentVoucherCreateNew.Text = "Create New"
                            .mnuReportItemsAll.Text = "All Registered Items"
                            .tsReportItemsAllGold.Text = "Gold"
                            .tsReportItemsAllSilver.Text = "Silver"
                            .tsReportItemsAllDiamond.Text = "Diamonds"
                            .tsReportItemsAllAccessories.Text = "Watches & Brands & Stone"
                            .mnuReportItemsSold.Text = "Sold Items"
                            .tsReportItemsSoldGold.Text = "Gold"
                            .tsReportItemsSoldSilver.Text = "Silver"
                            .tsReportItemsSoldDiamond.Text = "Diamonds"
                            .tsReportItemsSoldAccessories.Text = "Watches & Brands & Stone"
                            .mnuReportItemsAvailable.Text = "Available Items"
                            .tsReportItemsAvailableGold.Text = "Gold"
                            .tsReportItemsAvailableSilver.Text = "Silver"
                            .tsReportItemsAvailableDiamond.Text = "Diamonds"
                            .tsReportItemsAvailableAccessories.Text = "Watches & Brands & Stone"
                            .mnuReportProfit.Text = "Sales Profits"
                            .tsReportProfitGold.Text = "Gold"
                            .tsReportProfitSilver.Text = "Silver"
                            .tsReportProfitDiamond.Text = "Diamonds"
                            .lbl24KBUY.Text = "24 K"
                            .lbl22KBUY.Text = "22 K"
                            .lbl21KBUY.Text = "21 K"
                            .lbl18KBUY.Text = "18 K"
                            .lblSilver925KBUY.Text = "925 K Silver"
                            .LIB_OUNCEBUY.Text = "Ounce"
                            .LabSellOunceUsd.Text = "Ounce Usd"
                            .LabOunceBuyUsd.Text = "Ounce Usd"
                            '''''''''''''''''''''''''''''''''''''''''
                            .lbl24K.Text = "24 K"
                            .lbl22K.Text = "22 K"
                            .lbl21K.Text = "21 K"
                            .lbl18K.Text = "18 K"
                            .lblSilver925K.Text = "925 K Silver"
                            .LIB_OUNCE.Text = "Ounce"
                            ''''''''''''''''''''''''''''''''''''''''''
                            .btnRefresh.Text = "Refresh"
                            .mnuLicense.Text = "Request a license key"
                            .tsLicenseGet.Text = "Request key"
                            .Text = AppTitle
                            .ExpReportSellDetailed.Text = "Multiple Detailed Search"
                            .ExpReportSellView.Text = "Review Bills"
                            .ExpensesToolStripMenuItem.Text = "Edit/Delete Expenses"
                            .SelectColorToolStripMenuItem.Text = "Color Settings"
                            If PriceCurrency = "" Then
                                .lblCurrencySale.Text = "Price Sale"
                                .lblCurrencyBuy.Text = "Price Buy"
                            ElseIf PriceCurrency = "QAR" Then
                                .lblCurrencySale.Text = "Qatari Riyal"
                                .lblCurrencyBuy.Text = "Qatari Riyal"
                            ElseIf PriceCurrency = "TUR" Then
                                .lblCurrencySale.Text = "Turkish lira"
                                .lblCurrencyBuy.Text = "Turkish lira"
                            ElseIf PriceCurrency = "EMR" Then
                            .lblCurrencySale.Text = "AED"
                            .lblCurrencyBuy.Text = "AED"
                            ElseIf PriceCurrency = "EGP" Then
                                .lblCurrencySale.Text = "Egyptian Pound"
                                .lblCurrencyBuy.Text = "Egyptian Pound"
                            End If
                            .ToolStripBondCash.Text = "Bond Cash"
                            .ToolStripBondShowCash.Text = "Review Bond Cash"
                            .ToolStripBondShowDetelsCash.Text = "Bond Multiple Detailed Search Cash"
                        .ToolStripBondGold.Text = "Gold Issue Voucher"
                        .ToolStripBondShowGold.Text = "Review Bond Gold"
                            .ToolStripBondShowDetelsGold.Text = "Bond Multiple Detailed Search Gold"
                            .ToolStripBondShowCashComp.Text = "Companies"
                            .ToolStripBondShowCashCompPersonal.Text = "Personal"
                            .GoldVoucherReceiveCreateNew.Text = "Create New"
                            .انشاءجديدToolStripMenuItem1.Text = "Create New"
                            .GoldVoucherReceiveEdite.Text = "Edit/Delete previous"
                            .حزفتعديلسابقToolStripMenuItem.Text = "Edit/Delete previous"
                            '.ReportGoldWeight.Text = "Gold "
                            '.ReportGoldWeightSold.Text = "weights Sold"
                            '.ReportGoldWeightAvailable.Text = "Weight Available"
                            '.ReportGoldWeightEnter.Text = "Weight Enter"
                            '.ReportSilverWeight.Text = "Silver "
                            '.ReportSilverWeightSold.Text = "weights Sold"
                            '.ReportSilverWeightAvailable.Text = "Weight Available"
                            '.ReportSilverWeightEnter.Text = "Weight Enter"
                        End With
                    Else  ' عربي
                        With frmMain
                            .txtTotalAmoun.Text = "اجمالي المبيعات"
                            .txtCachAmount.Text = "اجمالي الكاش"
                            .txtBankAmount.Text = "اجمالي البنكي"
                            .txtMakeCharge.Text = "اجمالي المصنعيات"
                            .BtnSalesDetails.Text = "التحليل المالي للنظام"
                            .wholesaleReport.Text = "تقارير الجمله"
                            .wholesaleInvView.Text = "مراجعة الفواتير"
                            .lblTechSupportEnd.Text = "تاريخ انتهاء الدعم الفني"
                            .dtEndDate.Left = 3
                            .lblTechSupportEnd.Left = .dtEndDate.Left + .dtEndDate.Width + 5
                            .btnSell.Text = "شاشة البيع"
                            .mnuReportItemByCarat.Text = "بيان حركة الصنف"
                            .btnBarCode.Text = "باركود"
                            .btnItem.Text = "الاصناف"
                            .btnKarat.Text = "التحويلات"
                            .btnReport.Text = "تقارير"
                            .btnExpense.Text = "مصروفات"
                            .btnStock.Text = "المخزون"
                            .btnBuy.Text = "مشتريات"
                            .btnBulkSell.Text = "مبيعات الجملة"
                            .btnBackup.Text = "نسخ احتياطي"
                            .btnUpdate.Text = "تحديث"
                            .lblUser.Text = "اسم المستخدم"
                            .tsReportItemByCaratGold.Text = "ذهب"
                            .tsReportItemByCaratSilver.Text = "فضة"
                            .mnuSettings.Text = "إعدادات البرنامج"
                            .mnuSettingsMain.Text = "الإعدادات الرئيسة"
                            .tsSettingsMainCompanyData.Text = "بيانات الشركة"
                            .tsSettingsMainCountryOfOrigin.Text = "مصادر التصنيع"
                            .tsSettingsMainGramPrice.Text = "أسعار الجرام"
                            .mnuSettingsDefinition.Text = "تعريفات"
                            .tsSettingsDefinitionStoneName.Text = "أنواع الأحجار"
                            .tsSettingsDefinitionStoneColor.Text = "ألوان الأحجار"
                            .tsSettingsDefinitionDiamondCut.Text = "قصة الألماس"
                            .tsSettingsDefinitionAddItemCategory.Text = "إضافة صنف -مزادات وساعات"
                            .tsSettingsDefinitionBrands.Text = "إضافة ماركة"
                            .tsSettingsDefinitionItemName.Text = "إضافة أسماء الأصناف"
                            .mnuSettingsLanguage.Text = "اختيار اللغة"
                            .tsSettingsLanguageArabic.Text = "العربية"
                            .tsSettingsLanguageEnglish.Text = "English"
                            .tsSettingsProgrammer.Text = "إعدادات المبرمج"
                            .mnuReport.Text = "التقارير"
                            .mnuReportSell.Text = "تقارير المبيعات اليومية"
                            .mnuReportSellView.Text = "مراجعة الفواتير"
                            .tsReportSellViewGold.Text = "ذهب"
                            .tsReportSellViewDiamond.Text = "ألماس"
                            .tsReportSellViewSilver.Text = "فضة"
                            .tsReportSellViewAuction.Text = "مزادات"
                            .tsReportSellViewAccessories.Text = "ساعات وماركات واحجار"
                            .mnuReportSellDetailed.Text = "بحث متعدد تفصيلي"
                            .tsReportSellDetailedGold.Text = "ذهب"
                            .tsReportSellDetailedDiamond.Text = "ألماس"
                            '.tsReportSellDetailedDiamondPortrait.Text = "ألماس عمودي"
                            .tsReportSellDetailedSilver.Text = "فضة"
                            .mnuReportSellShort.Text = "بحث متعدد مختصر"
                            .tsReportSellShortGold.Text = "ذهب"
                            .tsReportSellShortSilver.Text = "فضة"
                            .tsReportSellShortDiamond.Text = "ألماس"
                            .mnuReportSellViewDeleted.Text = "فواتير محذوفة"
                            .tsReportSellViewGoldDeleted.Text = "ذهب"
                            .tsReportSellViewSilverDeleted.Text = "فضة"
                            .mnuReportItems.Text = "تقارير الاصناف"
                            .mnuReportItemsAll.Text = "طباعة الاصناف"
                            .tsReportCustomers.Text = "عرض العملاء المسجلين"
                            .tsReportExpenses.Text = "تقرير المصروفات"
                            .mnuReportBuy.Text = "تقرير المشتريات"
                            .mnuReportBuyDetailed.Text = "بحث متعدد تفصيلي"
                            .mnuReportBuyShort.Text = "بحث متعدد مختصر"
                            .mnuReportBuyView.Text = "عرض الفواتير"
                            .tsReportBuyViewGold.Text = "ذهب"
                            .tsReportBuyViewSilver.Text = "فضة"
                            .tsReportBuyViewDiamond.Text = "ألماس"
                            .tsReportBuyViewAccessories.Text = "ساعات وماركات واحجار"
                            .tsReportCivilIDPrint.Text = "طباعة البطاقة المدنية"
                            .mnuUserManagement.Text = "إدارة المستخدمين"
                            .tsUserManagementUser.Text = "إضافة مستخدم"
                            .tsUserManagementCashier.Text = "إضافة كاشير"
                            .mnuTransactionsSell.Text = "بيع"
                            .mnuTransactions.Text = "المعاملات"
                            .tsTransactionsSellGold.Text = "حذف/تعديل ذهب"
                            .tsTransactionsSellSilver.Text = "حذف/تعديل فضة"
                            .tsTransactionsSellDiamond.Text = "حذف/تعديل ألماس"
                            .tsTransactionsSellAuction.Text = "حذف/تعديل مزادات"
                            .tsTransactionsSellAccessories.Text = "حذف/تعديل ساعات وماركات واحجار"
                            '.tsTransactionsAddGold.Text = "سند صرف/قبض ذهب"
                            '.tsTransactionsAddGold.Text = "سند قبض ذهب"
                            .tsTransactionsPaymentVoucher.Text = "سند صرف/قبض نقدي"
                            '.tsTransactionsReceiptVoucher.Text = "سند قبض نقدي"
                            .mnuTransactionsPayInstallment.Text = "دفع آجل"
                            .tsTransactionsPayInstallmentGoldSilver.Text = "ذهب/فضة"
                            .tsTransactionsPayInstallmentDiamond.Text = "ألماس"
                            .tsTransactionsPayInstallmentAccessories.Text = "ساعات وماركات واحجار"
                            .mnuTransactionsBuy.Text = "شراء"
                            .tsTransactionsBuyGold.Text = "حذف/تعديل ذهب"
                            .tsGoldVoucherReceive.Text = "سند صرف ذهب"
                            .tsGoldVoucher.Text = "سند قبض ذهب"
                            .tsReportItemsAllGold.Text = "ذهب"
                            .tsReportItemsAllSilver.Text = "فضة"
                            .tsReportItemsAllDiamond.Text = "ألماس"
                            .mnuReportItemsSold.Text = "الأصناف المباعة"
                            .tsReportItemsSoldGold.Text = "ذهب"
                            .tsReportItemsSoldSilver.Text = "فضة"
                            .tsReportItemsSoldDiamond.Text = "ألماس"
                            .mnuReportItemsAvailable.Text = "الأصناف المتوفرة"
                            .tsReportItemsAvailableGold.Text = "ذهب"
                            .tsReportItemsAvailableSilver.Text = "فضة"
                            .tsReportItemsAvailableDiamond.Text = "ألماس"
                            .mnuReportProfit.Text = "أرباح المبيعات"
                            .tsReportProfitGold.Text = "ذهب"
                            .tsReportProfitSilver.Text = "فضة"
                            .tsReportProfitDiamond.Text = "ألماس"
                            .lbl24KBUY.Text = "عيار 24"
                            .lbl22KBUY.Text = "عيار 22"
                            .lbl21KBUY.Text = "عيار 21"
                            .lbl18KBUY.Text = "عيار 18"
                            .LIB_OUNCEBUY.Text = "ألاونصة"
                            .LabOunceBuyUsd.Text = "ألاونصةدولار"
                            .LabSellOunceUsd.Text = "ألاونصةدولار"
                            .lblSilver925KBUY.Text = "فضة عيار 925"
                            '''''''''''''''''''''''''''''''''''''''''''''
                            .lbl24K.Text = "عيار 24"
                            .lbl22K.Text = "عيار 22"
                            .lbl21K.Text = "عيار 21"
                            .lbl18K.Text = "عيار 18"
                            .LIB_OUNCEBUY.Text = "ألاونصة"
                            .LIB_OUNCE.Text = "ألاونصة"
                            .lblSilver925K.Text = "فضة عيار 925"
                            .ExpReportSellDetailed.Text = "بحث متعدد تفصيلي"
                            .ExpReportSellView.Text = "مراجعة الفواتير"
                            .SelectColorToolStripMenuItem.Text = "ضبط الالوان"
                            '''''''''''''''''''''''''''''''''''''''''''''
                            .mnuLicense.Text = "طلب مفتاح الترخيص"
                            .tsLicenseGet.Text = "كود التفعيل"
                            .ExpensesToolStripMenuItem.Text = "تعديل/حزف المصروفات"
                            If PriceCurrency = "" Then
                                .lblCurrencySale.Text = "سعر البيع"
                                .lblCurrencyBuy.Text = "سعر الشراء"
                            ElseIf PriceCurrency = "QAR" Then
                                .lblCurrencySale.Text = "ريال قطري"
                                .lblCurrencyBuy.Text = "ريال قطري"
                            ElseIf PriceCurrency = "TUR" Then
                                .lblCurrencySale.Text = "ليرة تركية"
                                .lblCurrencyBuy.Text = "ليرة تركية"
                            ElseIf PriceCurrency = "EMR" Then
                                .lblCurrencySale.Text = "درهم إماراتي"
                                .lblCurrencyBuy.Text = "درهم إماراتي"
                            ElseIf PriceCurrency = "EGP" Then
                                .lblCurrencySale.Text = "جنيه مصري"
                                .lblCurrencyBuy.Text = "جنيه مصري"
                            End If
                            .btnRefresh.Text = "تحديث"
                            .Text = AppTitle
                            .ToolStripBondCash.Text = "سند قبض / صرف نقدي"
                            .ToolStripBondShowCash.Text = "مراجعة السندات"
                            .ToolStripBondShowDetelsCash.Text = "بحث متعدد تفصيلي سند قبض / صرف نقدي"
                        .ToolStripBondGold.Text = "سند صرف ذهب"
                        .ToolStripBondShowGold.Text = "مراجعة السندات"
                            .ToolStripBondShowDetelsGold.Text = "بحث متعدد تفصيلي سند قبض / صرف ذهب"
                            .ToolStripBondShowCashComp.Text = "شركات"
                            .ToolStripBondShowCashCompPersonal.Text = "شخصي"
                            .GoldVoucherReceiveCreateNew.Text = "انشاء جديد"
                            .انشاءجديدToolStripMenuItem1.Text = "انشاء جديد"
                            .GoldVoucherReceiveEdite.Text = "تعديل / حزف سابق"
                            .حزفتعديلسابقToolStripMenuItem.Text = "تعديل / حزف سابق"
                            '.ReportGoldWeight.Text = "ذهب "
                            '.ReportGoldWeightSold.Text = "الوزن المباع"
                            '.ReportGoldWeightAvailable.Text = "الوزن المتوفر"
                            '.ReportGoldWeightEnter.Text = "الوزن المدخل"
                            '.ReportSilverWeight.Text = "فضه "
                            '.ReportSilverWeightSold.Text = "الوزن المباع"
                            '.ReportSilverWeightAvailable.Text = "الوزن المتوفر"
                            '.ReportSilverWeightEnter.Text = "الوزن المدخل"
                        End With
                    End If
                Case "REPORTGOLDBUYDETAILED"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportGoldBuyDetailed
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .lblFromDate.Text = "From Date"
                            .lblToDate.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Customer Name")
                            .cmbSearch.Items.Add("Civil ID")
                            .cmbSearch.Items.Add("Phone No.")
                            .cmbSearch.Items.Add("Carat")
                            .Text = "Detailed Purchase Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportGoldBuyDetailed
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .lblFromDate.Text = "من تاريخ"
                            .lblToDate.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم العميل")
                            .cmbSearch.Items.Add("الرقم المدني")
                            .cmbSearch.Items.Add("رقم الهاتف")
                            .cmbSearch.Items.Add("العيار")
                            .Text = "تقرير مشتريات تفصيلي"
                        End With
                    End If

                Case "CIVILIDPRINT"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With CivilIDPrint
                            .RightToLeft = 0
                            .lblCID.Text = "CID No."
                            .lblPrintSelection.Text = "Print Option"
                            .btnView.Text = "View"
                            .btnPrint.Text = "Print"
                            .cmbPrintSelection.Items.Clear()
                            .cmbPrintSelection.Items.Add("Front & Back")
                            .cmbPrintSelection.Items.Add("Front Only")
                            .cmbPrintSelection.Items.Add("Back Only")
                            .Text = "Print Civil ID"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With CivilIDPrint
                            .lblCID.Text = "الرقم المدني"
                            .lblPrintSelection.Text = "المطلوب طباعته"
                            .btnView.Text = "عرض"
                            .btnPrint.Text = "طباعة"
                            .cmbPrintSelection.Items.Clear()
                            .cmbPrintSelection.Items.Add("الوجه والظهر")
                            .cmbPrintSelection.Items.Add("الوجه فقط")
                            .cmbPrintSelection.Items.Add("الظهر فقط")
                            .Text = "طباعة البطاقة المدنية"
                        End With
                    End If

                Case "SETGOLEDPRICE"
                    'SetGoledPrice
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With SetGoledPrice
                            .Lab18kBuy.Text = "Karat 18"
                            .Lab21kBuy.Text = "Karat 21"
                            .Lab22kBuy.Text = "Karat 22"
                            .Lab24kBuy.Text = "Karat 24"
                            .Lab925kBuy.Text = "Karat SILVER  925"
                            .LabOncBuy.Text = "Oue Ounce"
                            .Lab18kSale.Text = "Karat 18"
                            .Lab21kSale.Text = "Karat 21"
                            .Lab22Sale.Text = "Karat 22"
                            .Lab24Sale.Text = "Karat 24"
                            .Lab925kSale.Text = "Karat SILVER  925"
                            .LabOncSale.Text = "Oue Ounce"
                            .TEXOnceSellUsd.Text = "Oue Ounce Usd"
                            .Label1.Text = "Oue Ounce Usd"
                            .LabBuyDiff.Text = "Purchase price difference"
                            .LabSaleDiff.Text = "Selling price difference"
                            .Text = "Set Goled Price"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With SetGoledPrice
                            .Lab18kBuy.Text = "عيار 18"
                            .Lab21kBuy.Text = "عيار 21"
                            .Lab22kBuy.Text = "عيار 22"
                            .Lab24kBuy.Text = "عيار 24"
                            .Lab925kBuy.Text = " فضه عيار 925"
                            .LabOncBuy.Text = "الاونصه"
                            .Lab18kSale.Text = "عيار 18"
                            .Lab21kSale.Text = "عيار 21"
                            .Lab22Sale.Text = "عيار 22"
                            .Lab24Sale.Text = "عيار 24"
                            .Lab925kSale.Text = "فضه عيار 925"
                            .LabOncSale.Text = "الاونصه"
                            .Label1.Text = "الاونصه بالدولار"
                            .Label2.Text = "الاونصه بالدولار"
                            .LabBuyDiff.Text = "فرق سعر الشراء"
                            .LabSaleDiff.Text = "فرق سعر البيع"
                            .Text = "ضبط الاسعار"
                        End With
                    End If

                Case "REPORTGOLDBYCARAT"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportGoldByKarat
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .Label5.Text = "From Date"
                            .Label6.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Carat")
                            .cmbSearch.Items.Add("Weight")
                            .Text = "Gold Sales by Carat Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportGoldByKarat
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .Label5.Text = "من تاريخ"
                            .Label6.Text = "إلى تاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("العيار")
                            .cmbSearch.Items.Add("الوزن")
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .Text = "تقرير بيع الذهب حسب العيار"
                        End With
                    End If

                Case "REPORTGOLDITEMALL"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportGoldItemAll
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .lblFromDate.Text = "From Date"
                            .lblToDate.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Item Name")
                            .cmbSearch.Items.Add("Gold Carat")
                            .cmbSearch.Items.Add("Make Charge")
                            .cmbSearch.Items.Add("Item Weight")
                            .cmbSearch.Items.Add("Item Cost")
                            .cmbSearch.Items.Add("Stone Name")
                            .cmbSearch.Items.Add("BarCode")
                            .cmbSearch.Items.Add("Supplier")
                            .cmbSearch.Items.Add("Country Of Origin")
                            .cmbSearch.Items.Add("User")
                            .Text = "Registered Gold Items Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportGoldItemAll
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .lblFromDate.Text = "من تاريخ"
                            .lblToDate.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم الصنف")
                            .cmbSearch.Items.Add("العيار")
                            .cmbSearch.Items.Add("المصنعية")
                            .cmbSearch.Items.Add("الوزن")
                            .cmbSearch.Items.Add("التكلفة")
                            .cmbSearch.Items.Add("نوع الفصوص")
                            .cmbSearch.Items.Add("الباركود")
                            .cmbSearch.Items.Add("المورد")
                            .cmbSearch.Items.Add("بلد المنشأ")
                            .cmbSearch.Items.Add("المستخدم")
                            .Text = "تقرير الأصناف المسجلة ذهب"
                        End With
                    End If
                Case "REPORTSILVERITEMALL"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportGoldItemAll
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .lblFromDate.Text = "From Date"
                            .lblToDate.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Item Name")
                            .cmbSearch.Items.Add("Gold Carat")
                            .cmbSearch.Items.Add("Make Charge")
                            .cmbSearch.Items.Add("Item Weight")
                            .cmbSearch.Items.Add("Item Cost")
                            .cmbSearch.Items.Add("Stone Name")
                            .cmbSearch.Items.Add("BarCode")
                            .cmbSearch.Items.Add("Supplier")
                            .cmbSearch.Items.Add("Country Of Origin")
                            .cmbSearch.Items.Add("User")
                            .Text = "Registered Silver Items Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportGoldItemAll
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .lblFromDate.Text = "من تاريخ"
                            .lblToDate.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم الصنف")
                            .cmbSearch.Items.Add("العيار")
                            .cmbSearch.Items.Add("المصنعية")
                            .cmbSearch.Items.Add("الوزن")
                            .cmbSearch.Items.Add("التكلفة")
                            .cmbSearch.Items.Add("نوع الفصوص")
                            .cmbSearch.Items.Add("الباركود")
                            .cmbSearch.Items.Add("المورد")
                            .cmbSearch.Items.Add("بلد المنشأ")
                            .cmbSearch.Items.Add("المستخدم")
                            .Text = "تقرير الأصناف المسجلة فضة"
                        End With
                    End If
                Case "REPORTDIAMONDITEMALL"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportDiamondItemAll
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .Label5.Text = "From Date"
                            .Label6.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Item Name")
                            .cmbSearch.Items.Add("D.Clarity")
                            .cmbSearch.Items.Add("D.Weight")
                            .cmbSearch.Items.Add("D.Cut")
                            .cmbSearch.Items.Add("G.Carat")
                            .cmbSearch.Items.Add("Cost")
                            .cmbSearch.Items.Add("Item No.")
                            .cmbSearch.Items.Add("BarCode")
                            .cmbSearch.Items.Add("User")
                            .Text = "Registered Diamond Items Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportDiamondItemAll
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .Label5.Text = "من تاريخ"
                            .Label6.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم الصنف")
                            .cmbSearch.Items.Add("النقاوة")
                            .cmbSearch.Items.Add("القيراط")
                            .cmbSearch.Items.Add("القص")
                            .cmbSearch.Items.Add("عيار الذهب")
                            .cmbSearch.Items.Add("التكلفة")
                            .cmbSearch.Items.Add("رقم القطعة")
                            .cmbSearch.Items.Add("الباركود")
                            .cmbSearch.Items.Add("المستخدم")
                            .Text = "تقرير الأصناف المسجلة ألماس"
                        End With
                    End If

                Case "REPORTGOLDITEMSOLD"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportGoldItemSold
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .Label5.Text = "From Date"
                            .Label6.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Item Name")
                            .cmbSearch.Items.Add("Gold Carat")
                            .cmbSearch.Items.Add("Make Charge")
                            .cmbSearch.Items.Add("Item Weight")
                            .cmbSearch.Items.Add("Item Cost")
                            .cmbSearch.Items.Add("Stone Name")
                            .cmbSearch.Items.Add("BarCode")
                            .cmbSearch.Items.Add("Supplier")
                            .cmbSearch.Items.Add("Country Of Origin")
                            .cmbSearch.Items.Add("User")
                            .Text = "Sold Gold Items Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportGoldItemSold
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .Label5.Text = "من تاريخ"
                            .Label6.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم الصنف")
                            .cmbSearch.Items.Add("العيار")
                            .cmbSearch.Items.Add("المصنعية")
                            .cmbSearch.Items.Add("الوزن")
                            .cmbSearch.Items.Add("التكلفة")
                            .cmbSearch.Items.Add("نوع الفصوص")
                            .cmbSearch.Items.Add("الباركود")
                            .cmbSearch.Items.Add("المورد")
                            .cmbSearch.Items.Add("بلد المنشأ")
                            .cmbSearch.Items.Add("المستخدم")
                            .Text = "تقرير الأصناف المباعة ذهب"
                        End With
                    End If
                Case "REPORTSILVERITEMSOLD"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportGoldItemSold
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .Label5.Text = "From Date"
                            .Label6.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Item Name")
                            .cmbSearch.Items.Add("Gold Carat")
                            .cmbSearch.Items.Add("Make Charge")
                            .cmbSearch.Items.Add("Item Weight")
                            .cmbSearch.Items.Add("Item Cost")
                            .cmbSearch.Items.Add("Stone Name")
                            .cmbSearch.Items.Add("BarCode")
                            .cmbSearch.Items.Add("Supplier")
                            .cmbSearch.Items.Add("Country Of Origin")
                            .cmbSearch.Items.Add("User")
                            .Text = "Sold Silver Items Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportGoldItemSold
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .Label5.Text = "من تاريخ"
                            .Label6.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم الصنف")
                            .cmbSearch.Items.Add("العيار")
                            .cmbSearch.Items.Add("المصنعية")
                            .cmbSearch.Items.Add("الوزن")
                            .cmbSearch.Items.Add("التكلفة")
                            .cmbSearch.Items.Add("نوع الفصوص")
                            .cmbSearch.Items.Add("الباركود")
                            .cmbSearch.Items.Add("المورد")
                            .cmbSearch.Items.Add("بلد المنشأ")
                            .cmbSearch.Items.Add("المستخدم")
                            .Text = "تقرير الأصناف المباعة فضة"
                        End With
                    End If
                Case "REPORTDIAMONDITEMSOLD"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportDiamondItemSold
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .Label5.Text = "From Date"
                            .Label6.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Item Name")
                            .cmbSearch.Items.Add("D.Clarity")
                            .cmbSearch.Items.Add("D.Weight")
                            .cmbSearch.Items.Add("D.Cut")
                            .cmbSearch.Items.Add("G.Carat")
                            .cmbSearch.Items.Add("Cost")
                            .cmbSearch.Items.Add("Item No.")
                            .cmbSearch.Items.Add("BarCode")
                            .cmbSearch.Items.Add("User")
                            .Text = "Sold Diamond Items Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportDiamondItemSold
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .Label5.Text = "من تاريخ"
                            .Label6.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم الصنف")
                            .cmbSearch.Items.Add("النقاوة")
                            .cmbSearch.Items.Add("القيراط")
                            .cmbSearch.Items.Add("القص")
                            .cmbSearch.Items.Add("عيار الذهب")
                            .cmbSearch.Items.Add("التكلفة")
                            .cmbSearch.Items.Add("رقم القطعة")
                            .cmbSearch.Items.Add("الباركود")
                            .cmbSearch.Items.Add("المستخدم")
                            .Text = "تقرير الأصناف المباعة ألماس"
                        End With
                    End If

                Case "REPORTGOLDITEMAVAILABLE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportGoldItemAvailable
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .lblFromDate.Text = "From Date"
                            .lblToDate.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Item Name")
                            .cmbSearch.Items.Add("Gold Carat")
                            .cmbSearch.Items.Add("Make Charge")
                            .cmbSearch.Items.Add("Item Weight")
                            .cmbSearch.Items.Add("Item Cost")
                            .cmbSearch.Items.Add("Stone Name")
                            .cmbSearch.Items.Add("BarCode")
                            .cmbSearch.Items.Add("Supplier")
                            .cmbSearch.Items.Add("Country Of Origin")
                            .cmbSearch.Items.Add("User")
                            .Text = "Available Gold Items Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportGoldItemAvailable
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .lblFromDate.Text = "من تاريخ"
                            .lblToDate.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم الصنف")
                            .cmbSearch.Items.Add("العيار")
                            .cmbSearch.Items.Add("المصنعية")
                            .cmbSearch.Items.Add("الوزن")
                            .cmbSearch.Items.Add("التكلفة")
                            .cmbSearch.Items.Add("نوع الفصوص")
                            .cmbSearch.Items.Add("الباركود")
                            .cmbSearch.Items.Add("المورد")
                            .cmbSearch.Items.Add("بلد المنشأ")
                            .cmbSearch.Items.Add("المستخدم")
                            .Text = "تقرير الأصناف المتوفرة ذهب"
                        End With
                    End If
                Case "REPORTGOLDPROFIT"
                If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                    With ReportGoldProfit
                        .RightToLeft = 0
                        .btnViewAll.Text = "View All"
                        .btnPreview.Text = "Preview"
                        .btnCancelPreview.Text = "Cancel Preview"
                        .btnPrint.Text = "Print Report"
                        '.lblSearchType.Text = "Search Criteria"
                        '.lblSearchText.Text = "Value"
                        .btnSearch.Text = "View"
                        .lblFromDate.Text = "From Date"
                        .lblToDate.Text = "To Date"
                        .btnDate.Text = "View Report By Date"
                        .cmbSearch.Items.Clear()
                        .cmbSearch.Items.Add("Item Name")
                        .cmbSearch.Items.Add("Carat")
                        .cmbSearch.Items.Add("BarCode")
                        .cmbSearch.Items.Add("Invoice No.")
                        .cmbSearch.Items.Add("Supplier")
                        .cmbSearch.Items.Add("Cashier")
                        .Text = "Sale Profit Report"
                    End With
                ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                    With ReportGoldProfit
                        .btnViewAll.Text = "عرض الكل"
                        .btnPreview.Text = "معاينة"
                        .btnCancelPreview.Text = "إلغاء المعاينة"
                        .btnPrint.Text = "طباعة تقرير"
                        '.lblSearchType.Text = "طريقة البحث"
                        '.lblSearchText.Text = "القيمة"
                        .btnSearch.Text = "عرض"
                        .lblFromDate.Text = "من تاريخ"
                        .lblToDate.Text = "إلى تاريخ"
                        .btnDate.Text = "عرض التقرير حسب التاريخ"
                        .cmbSearch.Items.Clear()
                        .cmbSearch.Items.Add("اسم الصنف")
                        .cmbSearch.Items.Add("العيار")
                        .cmbSearch.Items.Add("الباركود")
                        .cmbSearch.Items.Add("رقم الفاتورة")
                        .cmbSearch.Items.Add("المورد")
                        .cmbSearch.Items.Add("الكاشير")
                        .Text = "تقرير أرباح المبيعات"
                    End With
                End If

            Case "REPORTSILVERPROFIT"
                If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                    With ReportSilverProfit
                        .RightToLeft = 0
                        .btnViewAll.Text = "View All"
                        .btnPreview.Text = "Preview"
                        .btnCancelPreview.Text = "Cancel Preview"
                        .btnPrint.Text = "Print Report"
                        '.lblSearchType.Text = "Search Criteria"
                        '.lblSearchText.Text = "Value"
                        .btnSearch.Text = "View"
                        .lblFromDate.Text = "From Date"
                        .lblToDate.Text = "To Date"
                        .btnDate.Text = "View Report By Date"
                        .cmbSearch.Items.Clear()
                        .cmbSearch.Items.Add("Item Name")
                        .cmbSearch.Items.Add("Carat")
                        .cmbSearch.Items.Add("BarCode")
                        .cmbSearch.Items.Add("Invoice No.")
                        .cmbSearch.Items.Add("Supplier")
                        .cmbSearch.Items.Add("Cashier")
                        .Text = "Sale Profit Report"
                    End With
                ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                    With ReportSilverProfit
                        .btnViewAll.Text = "عرض الكل"
                        .btnPreview.Text = "معاينة"
                        .btnCancelPreview.Text = "إلغاء المعاينة"
                        .btnPrint.Text = "طباعة تقرير"
                        '.lblSearchType.Text = "طريقة البحث"
                        '.lblSearchText.Text = "القيمة"
                        .btnSearch.Text = "عرض"
                        .lblFromDate.Text = "من تاريخ"
                        .lblToDate.Text = "إلى تاريخ"
                        .btnDate.Text = "عرض التقرير حسب التاريخ"
                        .cmbSearch.Items.Clear()
                        .cmbSearch.Items.Add("اسم الصنف")
                        .cmbSearch.Items.Add("العيار")
                        .cmbSearch.Items.Add("الباركود")
                        .cmbSearch.Items.Add("رقم الفاتورة")
                        .cmbSearch.Items.Add("المورد")
                        .cmbSearch.Items.Add("الكاشير")
                        .Text = "تقرير أرباح المبيعات"
                    End With
                End If








































            Case "REPORTSILVERPROFIT"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportGoldProfit
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                        '.lblSearchType.Text = "Search Criteria"
                        '.lblSearchText.Text = "Value"
                        .btnSearch.Text = "View"
                            .lblFromDate.Text = "From Date"
                            .lblToDate.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Item Name")
                            .cmbSearch.Items.Add("Carat")
                            .cmbSearch.Items.Add("BarCode")
                            .cmbSearch.Items.Add("Invoice No.")
                            .cmbSearch.Items.Add("Supplier")
                            .Text = "Sale Profit Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportGoldProfit
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                        '.lblSearchType.Text = "طريقة البحث"
                        '.lblSearchText.Text = "القيمة"
                        .btnSearch.Text = "عرض"
                            .lblFromDate.Text = "من تاريخ"
                            .lblToDate.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم الصنف")
                            .cmbSearch.Items.Add("العيار")
                            .cmbSearch.Items.Add("الباركود")
                            .cmbSearch.Items.Add("رقم الفاتورة")
                            .cmbSearch.Items.Add("المورد")
                            .Text = "تقرير أرباح المبيعات"
                        End With
                    End If
                Case "REPORTSILVERITEMAVAILABLE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportGoldItemAvailable
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .lblFromDate.Text = "From Date"
                            .lblToDate.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Item Name")
                            .cmbSearch.Items.Add("Gold Carat")
                            .cmbSearch.Items.Add("Make Charge")
                            .cmbSearch.Items.Add("Item Weight")
                            .cmbSearch.Items.Add("Item Cost")
                            .cmbSearch.Items.Add("Stone Name")
                            .cmbSearch.Items.Add("BarCode")
                            .cmbSearch.Items.Add("Supplier")
                            .cmbSearch.Items.Add("Country Of Origin")
                            .cmbSearch.Items.Add("User")
                            .Text = "Available Silver Items Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportGoldItemAvailable
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .lblFromDate.Text = "من تاريخ"
                            .lblToDate.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم الصنف")
                            .cmbSearch.Items.Add("العيار")
                            .cmbSearch.Items.Add("المصنعية")
                            .cmbSearch.Items.Add("الوزن")
                            .cmbSearch.Items.Add("التكلفة")
                            .cmbSearch.Items.Add("نوع الفصوص")
                            .cmbSearch.Items.Add("الباركود")
                            .cmbSearch.Items.Add("المورد")
                            .cmbSearch.Items.Add("بلد المنشأ")
                            .cmbSearch.Items.Add("المستخدم")
                            .Text = "تقرير الأصناف المتوفرة فضة"
                        End With
                    End If
                Case "REPORTDIAMONDITEMAVAILABLE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportDiamondItemAvailable
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .lblFromDate.Text = "From Date"
                            .lblToDate.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Item Name")
                            .cmbSearch.Items.Add("D.Clarity")
                            .cmbSearch.Items.Add("D.Weight")
                            .cmbSearch.Items.Add("D.Cut")
                            .cmbSearch.Items.Add("G.Carat")
                            .cmbSearch.Items.Add("Cost")
                            .cmbSearch.Items.Add("Item No.")
                            .cmbSearch.Items.Add("BarCode")
                            .cmbSearch.Items.Add("User")
                            .Text = "Available Diamond Items Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportDiamondItemAvailable
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .lblFromDate.Text = "من تاريخ"
                            .lblToDate.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم الصنف")
                            .cmbSearch.Items.Add("النقاوة")
                            .cmbSearch.Items.Add("القيراط")
                            .cmbSearch.Items.Add("القص")
                            .cmbSearch.Items.Add("عيار الذهب")
                            .cmbSearch.Items.Add("التكلفة")
                            .cmbSearch.Items.Add("رقم القطعة")
                            .cmbSearch.Items.Add("الباركود")
                            .cmbSearch.Items.Add("المستخدم")
                            .Text = "تقرير الأصناف المتوفرة ألماس"
                        End With
                    End If
                Case "REPORTGOLDBUYSHORT"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportGoldBuyShort
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .Label5.Text = "From Date"
                            .Label6.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Customer Name")
                            .cmbSearch.Items.Add("Civil ID")
                            .cmbSearch.Items.Add("Phone No.")
                            .cmbSearch.Items.Add("Invoice No.")
                            .cmbSearch.Items.Add("Cashier")
                            .Text = "Short Purchase Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportGoldBuyShort
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .Label5.Text = "من تاريخ"
                            .Label6.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم العميل")
                            .cmbSearch.Items.Add("الرقم المدني")
                            .cmbSearch.Items.Add("رقم الهاتف")
                            .cmbSearch.Items.Add("رقم الفاتورة")
                            .cmbSearch.Items.Add("الكاشير")
                            .Text = "تقرير مشتريات مختصر"
                        End With
                    End If

                Case "REPORTGOLDSELLSHORT"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportGoldSellShort
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .lblFromDate.Text = "From Date"
                            .lblToDate.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Customer Name")
                            .cmbSearch.Items.Add("Civil ID")
                            .cmbSearch.Items.Add("Phone No.")
                            .cmbSearch.Items.Add("Invoice No.")
                            .Text = "Short Sell Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportGoldSellShort
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .lblFromDate.Text = "من تاريخ"
                            .lblToDate.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم العميل")
                            .cmbSearch.Items.Add("الرقم المدني")
                            .cmbSearch.Items.Add("رقم الهاتف")
                            .cmbSearch.Items.Add("رقم الفاتورة")
                            .Text = "تقرير مبيعات مختصر"
                        End With
                    End If
                Case "REPORTDIAMONDSELLDETAILEDPORTRAIT"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportDiamondSellDetailedPortrait
                            .RightToLeft = 0
                            .RightToLeft = 0
                            .ChBoxBayDate.Text = "With Date Select"
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .lblFromDate.Text = "From Date"
                            .lblToDate.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Customer Name")
                            .cmbSearch.Items.Add("Civil ID")
                            .cmbSearch.Items.Add("Phone No.")
                            .cmbSearch.Items.Add("Type")
                            .cmbSearch.Items.Add("Item No.")
                            .cmbSearch.Items.Add("BarCode")
                            .cmbSearch.Items.Add("Cashier")
                            .cmbSearch.Items.Add("Invoice No.")
                            .cmbSearch.Items.Add("Certificate No.")
                            .Text = "Detailed Sell Report"

                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportDiamondSellDetailedPortrait
                            .ChBoxBayDate.Text = "تقيد التاريخ"
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .lblFromDate.Text = "من تاريخ"
                            .lblToDate.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم العميل")
                            .cmbSearch.Items.Add("الرقم المدني")
                            .cmbSearch.Items.Add("رقم الهاتف")
                            .cmbSearch.Items.Add("النوع")
                            .cmbSearch.Items.Add("رقم القطعة")
                            .cmbSearch.Items.Add("الباركود")
                            .cmbSearch.Items.Add("الكاشير")
                            .cmbSearch.Items.Add("رقم الفاتورة")
                            .cmbSearch.Items.Add("رقم الشهاده")
                            .Text = "تقرير مبيعات تفصيلي"
                        End With
                    End If
                Case "REPORTVIEWDETAILS"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportViewDetails
                            .RightToLeft = 0
                            .RightToLeft = 0
                            .ChBoxBayDate.Text = "With Date Select"
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View With entered value"
                            .lblFromDate.Text = "From Date"
                            .lblToDate.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .Text = "Detailed bond report"
                            .GrBoxSelectFilter.Text = "View Report By."
                            .RadAllData.Text = "Preview All"
                            .RadOnlyCastom.Text = "Castomer Name"
                            .RadOnlyComp.Text = "company/workshop"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportViewDetails
                            .ChBoxBayDate.Text = "تقيد التاريخ"
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض حسب القيمه المدخله"
                            .lblFromDate.Text = "من تاريخ"
                            .lblToDate.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .Text = "تقرير السندات التفصيلي"
                            .RadAllData.Text = "عرض الكل"
                            .RadOnlyCastom.Text = "اسم العميل"
                            .RadOnlyComp.Text = "اسم الورشه/الشركه"
                            .GrBoxSelectFilter.Text = "عرض التقرير حسب"
                        End With
                    End If
                Case "REPORTDIAMONDSELLSHORT"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With ReportDiamondSellShort
                            .RightToLeft = 0
                            .btnViewAll.Text = "View All"
                            .btnPreview.Text = "Preview"
                            .btnCancelPreview.Text = "Cancel Preview"
                            .btnPrint.Text = "Print Report"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Value"
                            .btnSearch.Text = "View"
                            .lblFromDate.Text = "From Date"
                            .lblToDate.Text = "To Date"
                            .btnDate.Text = "View Report By Date"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("Customer Name")
                            .cmbSearch.Items.Add("Civil ID")
                            .cmbSearch.Items.Add("Phone No.")
                            .cmbSearch.Items.Add("Gold Weight")
                            .cmbSearch.Items.Add("Diamond Weight")
                            .cmbSearch.Items.Add("Price")
                            .cmbSearch.Items.Add("Cash")
                            .cmbSearch.Items.Add("K-NET")
                            .cmbSearch.Items.Add("Invoice No.")
                            .cmbSearch.Items.Add("Cashier")
                            .Text = "Short Sales Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With ReportDiamondSellShort
                            .btnViewAll.Text = "عرض الكل"
                            .btnPreview.Text = "معاينة"
                            .btnCancelPreview.Text = "إلغاء المعاينة"
                            .btnPrint.Text = "طباعة تقرير"
                            .lblSearchType.Text = "طريقة البحث"
                            .lblSearchText.Text = "القيمة"
                            .btnSearch.Text = "عرض"
                            .lblFromDate.Text = "من تاريخ"
                            .lblToDate.Text = "إلى تاريخ"
                            .btnDate.Text = "عرض التقرير حسب التاريخ"
                            .cmbSearch.Items.Clear()
                            .cmbSearch.Items.Add("اسم العميل")
                            .cmbSearch.Items.Add("الرقم المدني")
                            .cmbSearch.Items.Add("رقم الهاتف")
                            .cmbSearch.Items.Add("وزن الذهب")
                            .cmbSearch.Items.Add("قيراط الألماس")
                            .cmbSearch.Items.Add("إجمالي السعر")
                            .cmbSearch.Items.Add("الكاش")
                            .cmbSearch.Items.Add("الكي-نت")
                            .cmbSearch.Items.Add("رقم الفاتورة")
                            .cmbSearch.Items.Add("الكاشير")
                            .Text = "تقرير مبيعات مختصر"
                        End With
                    End If
                Case "GOLDADDITEMDETAILS"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With GoldAddItemDetails
                            .btnNew.Text = "Add New"
                            .btnSave.Text = "Save Item"
                            .btnBarCode.Text = "Print" & vbCrLf & "Barcode"
                            .btnExcelImport.Text = "Import Excel"
                            .btnEdit.Text = "Edit"
                            .gbItemData.Text = "Item Details"
                            .CheItemRepeat.Text = "Repeat Item Details"
                            .gbItemData.RightToLeft = 0
                            .cmbKarat.RightToLeft = 0
                            .txtMetalWeight.RightToLeft = 0
                            .txtMakeCharge.RightToLeft = 0
                            .txtStoneWeight1.RightToLeft = 0
                            .txtStoneWeight2.RightToLeft = 0
                            .txtStoneWeight3.RightToLeft = 0
                            .txtStonePrice1.RightToLeft = 0
                            .txtStonePrice2.RightToLeft = 0
                            .txtStonePrice3.RightToLeft = 0
                            .txtQty.RightToLeft = 0
                            .txtCostPerGram.RightToLeft = 0
                            .txtCostPerItem.RightToLeft = 0
                            .txtCode.RightToLeft = 0
                            .txtBarCode.RightToLeft = 0
                            .lblKarat.Text = "Karat"
                            .lblItemName.Text = "Item Name"
                            .lblMetalWeight.Text = "Weight"
                            .lblMakeCharge.Text = "M.C./Gram"
                            .lblCountry.Text = "Country"
                            .lblCostPerGram.Text = "Cost/Gram"
                            .lblStoneWeight.Text = "S.Weight1"
                            .lblPhoto.Text = "Add Photo"
                            .lblStoneName.Text = "S.Type1"
                            .lblSupplier.Text = "Supplier"
                            .lblCode.Text = "Code"
                            .lblCostPerItem.Text = "Purchase Item"
                            .lblQty.Text = "Quantity"
                            .lblStonePrice.Text = "Stone Price"
                            .lblStoneColor.Text = "StoneColor"
                            .lblBarCode.Text = "BarCode"
                            .colBarCode.HeaderText = "BarCode"
                            .colStonePrice1.HeaderText = "S.Price1"
                            .colStoneColor1.HeaderText = "S.Color1"
                            .colStoneWeight2.HeaderText = "S.Weight2"
                            .colStoneName2.HeaderText = "S.Type2"
                            .colStonePrice2.HeaderText = "S.Price2"
                            .colStoneColor2.HeaderText = "S.Color2"
                            .colStoneWeight3.HeaderText = "S.Weight3"
                            .colStoneName3.HeaderText = "S.Type3"
                            .colStonePrice3.HeaderText = "S.Price3"
                            .colStoneColor3.HeaderText = "S.Color3"
                            .colQty.HeaderText = "Qty"
                            .colDelete.HeaderText = "Del"
                            .Text = "Add Gold Details"
                            .lblNetCaret.Text = "Net Karat"
                            .lblNetWeight.Text = "Net Weight"
                            .LabDateDiamItem.Text = "Date Created"
                            .LabUser.Text = "User Created"
                            .chkItemNO.Text = "Search Item ON."
                            .ChkBar.Text = "Search Barcood"
                            .LabtemNote.Text = "Item Note"
                            .lblDataSave.Text = "Repeat Data"
                            '''''''''''''''gred
                            .colBarCode.HeaderText = "Barcood"
                            .colGram_valu.HeaderText = "Caret"
                            .colGoldCart999.HeaderText = "Net Karat"
                            .colFO_name.HeaderText = "Item Name"
                            .colFO_gram.HeaderText = "Weight"
                            .colGoldWeight999.HeaderText = "Net Weight"
                            .colFO_gramMade.HeaderText = "Make Charge/Gram"
                            .colFO_desp.HeaderText = "M.C./Gram"
                            .colFO_made.HeaderText = "Country"
                            .colFO_GramPrice.HeaderText = "Supplier"
                            .colFO_ItemNo.HeaderText = "Code"
                            .colFO_totalPrice.HeaderText = "Purchase Item"
                            .colQty.HeaderText = "Qty"
                            .coldate_care.HeaderText = "Date Created"
                            .colLastEditDate.HeaderText = "Date Editing"
                            ''''''''''''''''''''''''''''''''''''''''
                            .colFO_price.HeaderText = "S.Type1"
                            .colFO_extras.HeaderText = "S.Weight1"
                            .colStonePrice1.HeaderText = "S.Price1"
                            .colStoneColor1.HeaderText = "S.Color1"
                            '''''''''''''''''''''''''''''''''''''''''
                            .colStoneName2.HeaderText = "S.Type2"
                            .colStoneWeight2.HeaderText = "S.Weight2"
                            .colStonePrice2.HeaderText = "S.Price2"
                            .colStoneColor2.HeaderText = "S.Color2"
                            '''''''''''''''''''''''''''''''''''''''''
                            .colStoneName3.HeaderText = "S.Type3"
                            .colStoneWeight3.HeaderText = "S.Weight3"
                            .colStonePrice3.HeaderText = "S.Price3"
                            .colStoneColor3.HeaderText = "S.Color3"
                            .ChkBar.Text = "Barcood"
                            .chkItemNO.Text = "ItemNo."
                            .lblPurInvNumber.Text = "Pur Inv Number"
                            .lblMultiItem.Text = "Multi Item"
                            .colPurInvNumber.HeaderText = "Pur Inv Number"
                            .colcbklblMultiItem.HeaderText = "Multi Item"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With GoldAddItemDetails
                            '.btnSupplier.Text = "اضافة مورد"
                            .btnNew.Text = "جديد"
                            .btnSave.Text = "حفظ"
                            .btnBarCode.Text = "طباعة" & vbCrLf & "الباركود"
                            .btnExcelImport.Text = "إضافة إكسل"
                            .btnEdit.Text = "تعديل"
                            .gbItemData.Text = "بيانات الصنف"
                            .CheItemRepeat.Text = "   تكرار بيانات صنف"
                            .gbItemData.RightToLeft = 1
                            .cmbKarat.RightToLeft = 0
                            .txtMetalWeight.RightToLeft = 0
                            .txtMakeCharge.RightToLeft = 0
                            .txtStoneWeight1.RightToLeft = 0
                            .txtStoneWeight2.RightToLeft = 0
                            .txtStoneWeight3.RightToLeft = 0
                            .txtStonePrice1.RightToLeft = 0
                            .txtStonePrice2.RightToLeft = 0
                            .txtStonePrice3.RightToLeft = 0
                            .txtQty.RightToLeft = 0
                            .txtCostPerGram.RightToLeft = 0
                            .txtCostPerItem.RightToLeft = 0
                            .txtCode.RightToLeft = 0
                            .txtBarCode.RightToLeft = 0
                            .lblKarat.Text = "العيار"
                            .lblItemName.Text = "اسم الصنف"
                            .lblSupplier.Text = "المورد"
                            .lblMetalWeight.Text = "الوزن"
                            .lblMakeCharge.Text = "مصنعية/للجرام"
                            .lblCountry.Text = "بلد المنشأ"
                            .lblCostPerGram.Text = "تكلفة الشراء/للجرام"
                            .lblCode.Text = "رمز القطعة"
                            .lblStoneWeight.Text = "وزن الفص"
                            .lblStoneName.Text = "نوع الفص"
                            .lblPhoto.Text = "أضف صورة"
                            .lblCode.Text = "رمز القطعة"
                            .lblCostPerItem.Text = "سعرالشراءالقطعة"
                            .lblQty.Text = "عدد القطع"
                            .lblStonePrice.Text = "سعر الفص"
                            .lblStoneColor.Text = "لون الفص"
                            .lblBarCode.Text = "الباركود"
                            .colDelete.HeaderText = "حذف"
                            .colFO_name.HeaderText = "اسم   الصنف"
                            .colFO_desp.HeaderText = "تكلفة الشراء / جرام"
                            .colFO_price.HeaderText = "نوع فص1"
                            .colFO_GramPrice.HeaderText = "المورد"
                            .colFO_gram.HeaderText = "الوزن"
                            .colFO_gramMade.HeaderText = "مصنعيه/للجرام"
                            .colFO_made.HeaderText = "بلد المنشأ"
                            .colFO_extras.HeaderText = "وزن فص1"
                            .colFO_totalPrice.HeaderText = "سعر شراء القطعة"
                            .colGram_valu.HeaderText = "العيار"
                            .colFO_ItemNo.HeaderText = "رقم القطعه"
                            .colStoneColor1.HeaderText = "لون فص1"
                            .colStonePrice1.HeaderText = "سعر فص1"
                            .colStoneWeight2.HeaderText = "وزن فص2"
                            .colStoneName2.HeaderText = "نوع فص1"
                            .colStoneColor2.HeaderText = "لون فص1"
                            .colStonePrice2.HeaderText = "سعر فص2"
                            .colStoneWeight3.HeaderText = "وزن فص3"
                            .colStoneColor3.HeaderText = "لون فص3"
                            .colStonePrice3.HeaderText = "سعر فص3"
                            .colStoneName3.HeaderText = "نوع فص3"
                            .colGoldCart999.HeaderText = "عيار الرمله"
                            .colGoldWeight999.HeaderText = "وزن الرمله"
                            .coldate_care.HeaderText = "تاريخ الادخال"
                            .colLastEditDate.HeaderText = "تاريخ   التعديل"
                            .colQty.HeaderText = "العدد"
                            .colBarCode.HeaderText = "الباركود"
                            .Text = "أضف بيانات أصناف الذهب"
                            .lblNetCaret.Text = "عيار الرمله"
                            .ChkBar.Text = "باركود"
                            .chkItemNO.Text = "رقم القطعه"
                            .lblPurInvNumber.Text = "رقم فاتورة الشراء"
                            .lblMultiItem.Text = "صنف مجمع"
                            .colPurInvNumber.HeaderText = "رقم فاتورة الشراء"
                            .colcbklblMultiItem.HeaderText = "صنف مجمع"
                        End With
                    End If
                '''''''''''''''''''شاشة الفضة
                Case "SILVERADDITEMDETAILS"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With GoldAddItemDetails
                            .btnNew.Text = "Add New"
                            .btnSave.Text = "Save Item"
                            .btnBarCode.Text = "Barcode" & vbCrLf & "Printing"
                            .btnExcelImport.Text = "Gram Price"
                            .btnEdit.Text = "Edit"
                            .gbItemData.Text = "Item Details"
                            .gbItemData.RightToLeft = 0
                            .cmbKarat.RightToLeft = 0
                            .txtMetalWeight.RightToLeft = 0
                            .txtMakeCharge.RightToLeft = 0
                            .txtStoneWeight1.RightToLeft = 0
                            .txtStoneWeight2.RightToLeft = 0
                            .txtStoneWeight3.RightToLeft = 0
                            .txtStonePrice1.RightToLeft = 0
                            .txtStonePrice2.RightToLeft = 0
                            .txtStonePrice3.RightToLeft = 0
                            .txtQty.RightToLeft = 0
                            .txtCostPerGram.RightToLeft = 0
                            .txtCostPerItem.RightToLeft = 0
                            .txtCode.RightToLeft = 0
                            .txtBarCode.RightToLeft = 0
                            .lblKarat.Text = "Karat"
                            .lblItemName.Text = "Item Name"
                            .lblMetalWeight.Text = "Silver Weight"
                            .lblMakeCharge.Text = "Make Charge/Gram"
                            .lblCountry.Text = "Country"
                            .lblCostPerGram.Text = "Purchase Cost/Gram"
                            .lblStoneWeight.Text = "Stone Weight"
                            .lblPhoto.Text = "Add Photo"
                            .lblStoneName.Text = "Stone Type"
                            .lblSupplier.Text = "Supplier"
                            .lblCode.Text = "Code"
                            .lblCostPerItem.Text = "Purchase Cost/Piece"
                            .lblQty.Text = "Quantity"
                            .lblStonePrice.Text = "Stone Price"
                            .lblStoneColor.Text = "StoneColor"
                            .lblBarCode.Text = "BarCode"
                            .colBarCode.HeaderText = "BarCode"
                            .lblStoneName.Text = "S.Type1"
                            .colStonePrice1.HeaderText = "S.Price1"
                            .colStoneColor1.HeaderText = "S.Color1"
                            .colStoneWeight2.HeaderText = "S.Weight2"
                            .colStoneName2.HeaderText = "S.Type2"
                            .colStonePrice2.HeaderText = "S.Price2"
                            .colStoneColor2.HeaderText = "S.Color2"
                            .colStoneWeight3.HeaderText = "S.Weight3"
                            .colStoneName3.HeaderText = "S.Type3"
                            .colStonePrice3.HeaderText = "S.Price3"
                            .colStoneColor3.HeaderText = "S.Color3"
                            .colQty.HeaderText = "Qty"
                            .colDelete.HeaderText = "Del"
                            .Text = "Add Silver Details"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With GoldAddItemDetails
                            .btnNew.Text = "جديد"
                            .btnSave.Text = "حفظ"
                            .btnBarCode.Text = "طباعة" & vbCrLf & "الباركود"
                            .btnExcelImport.Text = "أضف العيار"
                            .btnEdit.Text = "تعديل"
                            .gbItemData.Text = "بيانات الصنف"
                            .gbItemData.RightToLeft = 1
                            .cmbKarat.RightToLeft = 0
                            .txtMetalWeight.RightToLeft = 0
                            .txtMakeCharge.RightToLeft = 0
                            .txtStoneWeight1.RightToLeft = 0
                            .txtStoneWeight2.RightToLeft = 0
                            .txtStoneWeight3.RightToLeft = 0
                            .txtStonePrice1.RightToLeft = 0
                            .txtStonePrice2.RightToLeft = 0
                            .txtStonePrice3.RightToLeft = 0
                            .txtQty.RightToLeft = 0
                            .txtCostPerGram.RightToLeft = 0
                            .txtCostPerItem.RightToLeft = 0
                            .txtCode.RightToLeft = 0
                            .txtBarCode.RightToLeft = 0
                            .lblKarat.Text = "العيار"
                            .lblItemName.Text = "اسم الصنف"
                            .lblSupplier.Text = "المورد"
                            .lblMetalWeight.Text = "وزن الفضة"
                            .lblMakeCharge.Text = "مصنعية البيع/جرام"
                            .lblCountry.Text = "بلد المنشأ"
                            .lblCostPerGram.Text = "تكلفة الشراء/جرام"
                            .lblCode.Text = "رمز القطعة"
                            .lblStoneWeight.Text = "وزن الفص"
                            .lblStoneName.Text = "نوع الفص"
                            .lblPhoto.Text = "أضف صورة"
                            .lblCode.Text = "رمز القطعة"
                            .lblCostPerItem.Text = "سعر شراء القطعة"
                            .lblQty.Text = "العدد"
                            .lblStonePrice.Text = "سعر الفص"
                            .lblStoneColor.Text = "لون الفص"
                            .lblBarCode.Text = "الباركود"
                            .colBarCode.HeaderText = "الباركود"
                            .colStonePrice1.HeaderText = "سعر فص1"
                            .colStoneColor1.HeaderText = "لون فص1"
                            .colStoneWeight2.HeaderText = "وزن فص2"
                            .colStoneName2.HeaderText = "نوع فص2"
                            .colStonePrice2.HeaderText = "سعر فص2"
                            .colStoneColor2.HeaderText = "لون فص2"
                            .colStoneWeight3.HeaderText = "و.فص3"
                            .colStoneName3.HeaderText = "نوع فص3"
                            .colStonePrice3.HeaderText = "سعر فص3"
                            .colStoneColor3.HeaderText = "لون فص3"
                            .colQty.HeaderText = "العدد"
                            .colDelete.HeaderText = "حذف"
                            .Text = "أضف بيانات أصناف الفضة"
                        End With
                    End If

                Case "AUCTIONADDITEMDETAILS"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With AuctionAddItemDetails
                            .btnNew.Text = "Add New"
                            .btnEdit.Text = "Edit"
                            .btnAddItemName.Text = "Add Category"
                            .btnBrand.Text = "Add Brand"
                            .btnGuaranteeStatus.Text = "Guarantee Status"
                            .btnItemStatus.Text = "Item Condition"
                            .gbItemData.RightToLeft = 0
                            .lblItemName.Text = "Category"
                            .lblBrand.Text = "Brand"
                            .lblModel.Text = "Model"
                            .lblSerialNo.Text = "Serial No."
                            .lblItemStatus.Text = "Item Condition"
                            .lblReceiveDate.Text = "Receive Date"
                            .lblGuaranteeStatus.Text = "Guarantee Status"
                            .lblGuaranteeDate.Text = "Guarantee Date"
                            .lblDetails.Text = "Details"
                            .lblPrice.Text = "Price"
                            .lblReceiver.Text = "Receiver"
                            .lblPhoto.Text = "Photo"
                            .btnSave.Text = "Save"
                            .lblSearchType.Text = "Search Criteria"
                            .lblSearchText.Text = "Search Value"
                            .btnSearch.Text = "Search"
                            .btnPrint.Text = "Print"
                            .grid.Columns("Auction_ID").HeaderText = "BarCode"
                            .grid.Columns("NameType").HeaderText = "Category"
                            .grid.Columns("Brand").HeaderText = "Brand"
                            .grid.Columns("Model").HeaderText = "Model"
                            .grid.Columns("SerialNo").HeaderText = "SerailNo"
                            .grid.Columns("ItemNewUsed").HeaderText = "Condition"
                            .grid.Columns("GuaranteeStatus").HeaderText = "G. Status"
                            .grid.Columns("GuaranteeDate").HeaderText = "G. Date"
                            .grid.Columns("ReceiveDate").HeaderText = "Receive Date"
                            .grid.Columns("Details").HeaderText = "Details"
                            .grid.Columns("Price").HeaderText = "Price"
                            .grid.Columns("Castomerid").HeaderText = "CID"
                            .grid.Columns("Delete").HeaderText = "Del"
                            .Text = "Add Item Details/Auctions"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With AuctionAddItemDetails
                            .btnNew.Text = "صنف جديد"
                            .btnEdit.Text = "تعديل"
                            .btnAddItemName.Text = "إضافة نوع"
                            .btnBrand.Text = "إضافة ماركة"
                            .btnGuaranteeStatus.Text = "حالة الضمان"
                            .btnItemStatus.Text = "حالة السلعة"
                            .gbItemData.RightToLeft = 0
                            .lblItemName.Text = "النوع"
                            .lblBrand.Text = "الماركة"
                            .lblModel.Text = "الموديل"
                            .lblSerialNo.Text = "رقم السيريال"
                            .lblItemStatus.Text = "حالة السلعة"
                            .lblReceiveDate.Text = "تاريخ الاستلام"
                            .lblGuaranteeStatus.Text = "حالة الضمان"
                            .lblGuaranteeDate.Text = "تاريخ الضمان"
                            .lblDetails.Text = "تفاصيل"
                            .lblPrice.Text = "السعر"
                            .lblReceiver.Text = "المستلم"
                            .lblPhoto.Text = "الصورة"
                            .btnSave.Text = "حفظ"
                            .lblSearchType.Text = "معيار البحث"
                            .lblSearchText.Text = "قيمة البحث"
                            .btnSearch.Text = "بحث"
                            .btnPrint.Text = "طباعة"
                            .grid.Columns("Auction_ID").HeaderText = "باركود"
                            .grid.Columns("NameType").HeaderText = "الصنف"
                            .grid.Columns("Brand").HeaderText = "الماركة"
                            .grid.Columns("Model").HeaderText = "الموديل"
                            .grid.Columns("SerialNo").HeaderText = "السيريال"
                            .grid.Columns("ItemNewUsed").HeaderText = "الحالة"
                            .grid.Columns("GuaranteeStatus").HeaderText = "حالة الضمان"
                            .grid.Columns("GuaranteeDate").HeaderText = "تاريخ الضمان"
                            .grid.Columns("ReceiveDate").HeaderText = "تاريخ الاستلام"
                            .grid.Columns("Details").HeaderText = "تفاصيل"
                            .grid.Columns("Price").HeaderText = "السعر"
                            .grid.Columns("Castomerid").HeaderText = "رقم مدني"
                            .grid.Columns("Delete").HeaderText = "حذف"
                            .Text = "إضافة صنف/مزادات"
                        End With
                    End If

                Case "GOLDBARCODE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With GoldBarCode
                            .btnPrint.Text = "Print"
                            .Label1.Text = "ShowRoom Name"
                            .Label79.Text = "Barcode Qty"
                            .Label28.Text = "Printer Selection"
                            .Label80.Text = "Golden SAP"
                            .Label84.Text = "SAP"
                            .gbPrintRange.Text = "Print Range"
                            .lblPrintRangeEnd.Text = "Stop At"
                            .chkPrintRange.Text = "Print Range"
                            .btnSave.Text = "Save Settings"
                            .GroupBox1.Text = "Right Side Barcode"
                            .GroupBox2.Text = "Left Side Barcode"
                            .Label2.Text = "Item"
                            .Label4.Text = "Item"
                            .gbRight.Text = "Adjust Settings of the Right Side"
                            .gbLeft.Text = "Adjust Settings of the Left Side"
                            .gbLeftValue.Text = "Values"
                            .gbLeftText.Text = "Text"
                            .gbRightValue.Text = "Values"
                            .gbRightText.Text = "Text"
                            .Label31.Text = "Weight"
                            .Label32.Text = "Country"
                            .Label33.Text = "Make"
                            .Label32.Text = "Country"
                            .Label34.Text = "Country"
                            .Label35.Text = "Make"
                            .Label37.Text = "Karat"
                            .Label39.Text = "Karat"
                            .Label41.Text = "Stones"
                            .Label43.Text = "Barcode"
                            .Label45.Text = "Supplier"
                            .Label47.Text = "Barcode No"
                            .Label49.Text = "Shop"
                            .Label51.Text = "Weight"
                            .Label53.Text = "Stones"
                            .Label55.Text = "Weight"
                            .Label57.Text = "Make"
                            .Label59.Text = "Make"
                            .Label61.Text = "Karat"
                            .Label63.Text = "Karat"
                            .Label65.Text = "Stones"
                            .Label67.Text = "Barcode"
                            .Label69.Text = "Supplier"
                            .Label71.Text = "Barcode No"
                            .Label73.Text = "Shop"
                            .Label75.Text = "Weight"
                            .Label77.Text = "Stones"
                            .Label3.Text = "Code"
                            .Label5.Text = "Code"
                            .Label6.Text = "Code"
                            .Label7.Text = "Code"
                            .Label25.Text = "Shop Font"
                            .Label27.Text = "Country Font"
                            .Label29.Text = "BarCode Font"
                            .Label26.Text = "Writing Font"
                            .Text = "Barcode Printing"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With GoldBarCode
                            .btnPrint.Text = "طباعة"
                            .Label1.Text = "اسم المعرض"
                            .Label79.Text = "عدد الملصقات"
                            .Label28.Text = "تحديد الطابعة"
                            .Label80.Text = "جولدن ساب"
                            .Label84.Text = "ساب"
                            .gbPrintRange.Text = "طباعة متتابعة"
                            .lblPrintRangeEnd.Text = "ينتهي عند"
                            .chkPrintRange.Text = "طباعة متتابعة"
                            .btnSave.Text = "حفظ الإعدادات"
                            .GroupBox1.Text = "باركود الجهة اليمنى"
                            .GroupBox2.Text = "باركود الجهة اليسرى"
                            .GroupBox1.RightToLeft = 1
                            .GroupBox2.RightToLeft = 1
                            .Label2.Text = "الصنف"
                            .Label4.Text = "الصنف"
                            .gbRight.Text = "ضبط إعدادات الجهة اليمنى للباركود"
                            .gbLeft.Text = "ضبط إعدادات الجهة اليسرى للباركود"
                            .gbRight.RightToLeft = 1
                            .gbLeft.RightToLeft = 1
                            .txtBarCodeRight.RightToLeft = 0
                            .txtBarCodeLeft.RightToLeft = 0
                            .cmbRightItem.RightToLeft = 0
                            .cmbLeftItem.RightToLeft = 0
                            .gbLeftValue.Text = "القيم"
                            .gbLeftText.Text = "النصوص"
                            .gbRightValue.Text = "القيم"
                            .gbRightText.Text = "النصوص"
                            .Label31.Text = "نص الوزن"
                            .Label32.Text = "بلد المنشأ"
                            .Label33.Text = "نص المصنعية"
                            .Label34.Text = "بلد المنشأ"
                            .Label35.Text = "رقم المصنعية"
                            .Label37.Text = "رقم العيار"
                            .Label39.Text = "نص العيار"
                            .Label41.Text = "نص الفص"
                            .Label43.Text = "خط الباركود"
                            .Label45.Text = "المورد"
                            .Label47.Text = "رقم الباركود"
                            .Label49.Text = "اسم المعرض"
                            .Label51.Text = "رقم الوزن"
                            .Label53.Text = "رقم الفص"
                            .Label55.Text = "نص الوزن"
                            .Label57.Text = "نص المصنعية"
                            .Label59.Text = "رقم المصنعية"
                            .Label61.Text = "رقم العيار"
                            .Label63.Text = "نص العيار"
                            .Label65.Text = "رقم الفص"
                            .Label67.Text = "خط الباركود"
                            .Label69.Text = "المورد"
                            .Label71.Text = "رقم الباركود"
                            .Label73.Text = "اسم المعرض"
                            .Label75.Text = "رقم الوزن"
                            .Label77.Text = "نص الفص"
                            .Label3.Text = "الرمز"
                            .Label5.Text = "الرمز"
                            .Label6.Text = "الرمز"
                            .Label7.Text = "الرمز"
                            .Label25.Text = "خط المعرض"
                            .Label27.Text = "خط بلد المنشأ"
                            .Label29.Text = "خط الباركود"
                            .Label26.Text = "خط الكتابة"
                            .Text = "طباعة الباركود"
                        End With
                    End If

                Case "SILVERBARCODE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With GoldBarCode
                            .btnPrint.Text = "Print"
                            .Label1.Text = "ShowRoom Name"
                            .Label79.Text = "Barcode Qty"
                            .Label28.Text = "Printer Selection"
                            .Label80.Text = "Golden SAP"
                            .Label84.Text = "SAP"
                            .gbPrintRange.Text = "Print Range"
                            .lblPrintRangeEnd.Text = "Stop At"
                            .chkPrintRange.Text = "Print Range"
                            .btnSave.Text = "Save Settings"
                            .GroupBox1.Text = "Right Side Barcode"
                            .GroupBox2.Text = "Left Side Barcode"
                            .Label2.Text = "Item"
                            .Label4.Text = "Item"
                            .gbRight.Text = "Adjust Settings of the Right Side"
                            .gbLeft.Text = "Adjust Settings of the Left Side"
                            .gbLeftValue.Text = "Values"
                            .gbLeftText.Text = "Text"
                            .gbRightValue.Text = "Values"
                            .gbRightText.Text = "Text"
                            .Label31.Text = "Weight"
                            .Label33.Text = "Price"
                            .Label35.Text = "Price"
                            .Label37.Text = "Karat"
                            .Label39.Text = "Karat"
                            .Label41.Text = "Stones"
                            .Label43.Text = "Barcode"
                            .Label45.Text = "Supplier"
                            .Label47.Text = "Barcode No"
                            .Label49.Text = "Shop"
                            .Label51.Text = "Weight"
                            .Label53.Text = "Stones"
                            .Label55.Text = "Weight"
                            .Label57.Text = "Price"
                            .Label59.Text = "Price"
                            .Label61.Text = "Karat"
                            .Label63.Text = "Karat"
                            .Label65.Text = "Stones"
                            .Label67.Text = "Barcode"
                            .Label69.Text = "Supplier"
                            .Label71.Text = "Barcode No"
                            .Label73.Text = "Shop"
                            .Label75.Text = "Weight"
                            .Label77.Text = "Stones"
                            .Label3.Text = "Code"
                            .Label5.Text = "Code"
                            .Label6.Text = "Code"
                            .Label7.Text = "Code"
                            .Label25.Text = "Shop Font"
                            .Label27.Text = "Country Font"
                            .Label29.Text = "BarCode Font"
                            .Label26.Text = "Writing Font"
                            .Text = "Barcode Printing"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With GoldBarCode
                            .btnPrint.Text = "طباعة"
                            .Label1.Text = "اسم المعرض"
                            .Label79.Text = "عدد الملصقات"
                            .Label28.Text = "تحديد الطابعة"
                            .Label80.Text = "جولدن ساب"
                            .Label84.Text = "ساب"
                            .gbPrintRange.Text = "طباعة متتابعة"
                            .lblPrintRangeEnd.Text = "ينتهي عند"
                            .chkPrintRange.Text = "طباعة متتابعة"
                            .btnSave.Text = "حفظ الإعدادات"
                            .GroupBox1.Text = "باركود الجهة اليمنى"
                            .GroupBox2.Text = "باركود الجهة اليسرى"
                            .GroupBox1.RightToLeft = 1
                            .GroupBox2.RightToLeft = 1
                            .Label2.Text = "الصنف"
                            .Label4.Text = "الصنف"
                            .gbRight.Text = "ضبط إعدادات الجهة اليمنى للباركود"
                            .gbLeft.Text = "ضبط إعدادات الجهة اليسرى للباركود"
                            .gbRight.RightToLeft = 1
                            .gbLeft.RightToLeft = 1
                            .gbLeftValue.Text = "القيم"
                            .gbLeftText.Text = "النصوص"
                            .gbRightValue.Text = "القيم"
                            .gbRightText.Text = "النصوص"
                            .Label31.Text = "نص الوزن"
                            .Label33.Text = "نص السعر"
                            .Label35.Text = "رقم السعر"
                            .Label37.Text = "رقم العيار"
                            .Label39.Text = "نص العيار"
                            .Label41.Text = "نص الفص"
                            .Label43.Text = "خط الباركود"
                            .Label45.Text = "المورد"
                            .Label47.Text = "رقم الباركود"
                            .Label49.Text = "اسم المعرض"
                            .Label51.Text = "رقم الوزن"
                            .Label53.Text = "رقم الفص"
                            .Label55.Text = "نص الوزن"
                            .Label57.Text = "نص السعر"
                            .Label59.Text = "رقم السعر"
                            .Label61.Text = "رقم العيار"
                            .Label63.Text = "نص العيار"
                            .Label65.Text = "رقم الفص"
                            .Label67.Text = "خط الباركود"
                            .Label69.Text = "المورد"
                            .Label71.Text = "رقم الباركود"
                            .Label73.Text = "اسم المعرض"
                            .Label75.Text = "رقم الوزن"
                            .Label77.Text = "نص الفص"
                            .Label3.Text = "الرمز"
                            .Label5.Text = "الرمز"
                            .Label6.Text = "الرمز"
                            .Label7.Text = "الرمز"
                            .Label25.Text = "خط المعرض"
                            .Label27.Text = "خط بلد المنشأ"
                            .Label29.Text = "خط الباركود"
                            .Label26.Text = "خط الكتابة"
                            .Text = "طباعة الباركود"
                        End With
                    End If
                Case "AUCTIONBARCODE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With AuctionBarCode
                            .btnPrint.Text = "Print"
                            .Label79.Text = "Barcode Qty"
                            .Label28.Text = "Printer Selection"
                            .Label80.Text = "Web Barcode"
                            .Label82.Text = "Web Text"
                            .Label84.Text = "Sabayiks"
                            .btnSave.Text = "Save Settings"
                            .GroupBox1.Text = "Right Side Barcode"
                            .GroupBox2.Text = "Left Side Barcode"
                            .Label2.Text = "Item"
                            .Label4.Text = "Item"
                            .GroupBox3.Text = "Adjust Settings of the Right Side"
                            .GroupBox4.Text = "Adjust Settings of the Left Side"
                            .GroupBox5.Text = "Values"
                            .GroupBox6.Text = "Text"
                            .GroupBox7.Text = "Values"
                            .GroupBox8.Text = "Text"
                            .Label31.Text = "Model"
                            .Label33.Text = "Serial"
                            .Label35.Text = "Serial"
                            .Label37.Text = "Receive"
                            .Label39.Text = "Receive"
                            .Label41.Text = "Guarantee"
                            .Label43.Text = "BarCode"
                            .Label45.Text = "Price"
                            .Label47.Text = "BarCode No."
                            .Label49.Text = "ShowRoom"
                            .Label51.Text = "Model"
                            .Label53.Text = "Guarantee"
                            .Label55.Text = "Model"
                            .Label57.Text = "Serial"
                            .Label59.Text = "Serial"
                            .Label61.Text = "Receive"
                            .Label63.Text = "Receive"
                            .Label65.Text = "Guarantee"
                            .Label67.Text = "BarCode"
                            .Label69.Text = "Price"
                            .Label71.Text = "BarCode No."
                            .Label73.Text = "ShowRoom"
                            .Label75.Text = "Model"
                            .Label77.Text = "Guarantee"
                            .Text = "Barcode Printing"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With AuctionBarCode
                            .btnPrint.Text = "طباعة"
                            .Label79.Text = "عدد الملصقات"
                            .Label28.Text = "تحديد الطابعة"
                            .Label80.Text = "باركود ويب"
                            .Label82.Text = "نص الويب"
                            .Label84.Text = "سبائك"
                            .btnSave.Text = "حفظ الإعدادات"
                            .GroupBox1.Text = "باركود الجهة اليمنى"
                            .GroupBox2.Text = "باركود الجهة اليسرى"
                            .GroupBox1.RightToLeft = 1
                            .GroupBox2.RightToLeft = 1
                            .Label2.Text = "الصنف"
                            .Label4.Text = "الصنف"
                            .GroupBox3.Text = "ضبط إعدادات الجهة اليمنى للباركود"
                            .GroupBox4.Text = "ضبط إعدادات الجهة اليسرى للباركود"
                            .GroupBox3.RightToLeft = 1
                            .GroupBox4.RightToLeft = 1
                            .GroupBox5.Text = "القيم"
                            .GroupBox6.Text = "النصوص"
                            .GroupBox7.Text = "القيم"
                            .GroupBox8.Text = "النصوص"
                            .Label31.Text = "نص الموديل"
                            .Label33.Text = "نص السيريال"
                            .Label35.Text = "رقم السيريال"
                            .Label37.Text = "رقم الاستلام"
                            .Label39.Text = "نص الاستلام"
                            .Label41.Text = "نص الضمان"
                            .Label43.Text = "خط الباركود"
                            .Label45.Text = "بلد المنشأ"
                            .Label47.Text = "رقم الباركود"
                            .Label49.Text = "اسم المعرض"
                            .Label51.Text = "رقم الموديل"
                            .Label53.Text = "رقم الضمان"
                            .Label55.Text = "نص الموديل"
                            .Label57.Text = "نص السيريال"
                            .Label59.Text = "رقم السيريال"
                            .Label61.Text = "رقم الاستلام"
                            .Label63.Text = "نص الاستلام"
                            .Label65.Text = "رقم الضمان"
                            .Label67.Text = "خط الباركود"
                            .Label69.Text = "بلد المنشأ"
                            .Label71.Text = "رقم الباركود"
                            .Label73.Text = "اسم المعرض"
                            .Label75.Text = "رقم الموديل"
                            .Label77.Text = "نص الضمان"
                            .Text = "طباعة الباركود"
                        End With
                    End If

                Case "ACCESSORIESBARCODE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With AccessoriesBarCode
                            .btnPrint.Text = "Print"
                            .Label79.Text = "Barcode Qty"
                            .Label28.Text = "Printer Selection"
                            .Label80.Text = "Web Barcode"
                            .Label82.Text = "Web Text"
                            .Label84.Text = "Sabayiks"
                            .btnSave.Text = "Save Settings"
                            .GroupBox1.Text = "Right Side Barcode"
                            .GroupBox2.Text = "Left Side Barcode"
                            .Label2.Text = "Item"
                            .Label4.Text = "Item"
                            .GroupBox3.Text = "Adjust Settings of the Right Side"
                            .GroupBox4.Text = "Adjust Settings of the Left Side"
                            .GroupBox5.Text = "Values"
                            .GroupBox6.Text = "Text"
                            .GroupBox7.Text = "Values"
                            .GroupBox8.Text = "Text"
                            .Label31.Text = "Name Text"
                            .Label33.Text = "Brand Text"
                            .Label35.Text = "Brand Value"
                            .Label37.Text = "Item No Value"
                            .Label39.Text = "Item No Text"
                            .Label41.Text = "Serial Text"
                            .Label43.Text = "BarCode"
                            .Label45.Text = "Price"
                            .Label47.Text = "BarCode No"
                            .Label49.Text = "ShowRoom Name"
                            .Label51.Text = "Name Value"
                            .Label53.Text = "Model Value"
                            .Label55.Text = "Name Text"
                            .Label57.Text = "Brand Text"
                            .Label59.Text = "Brand Value"
                            .Label61.Text = "ItemNo Value"
                            .Label63.Text = "ItemNo Text"
                            .Label65.Text = "Model Value"
                            .Label67.Text = "BarCode"
                            .Label69.Text = "Price"
                            .Label71.Text = "BarCode No"
                            .Label73.Text = "ShowRoom Name"
                            .Label75.Text = "Name Value"
                            .Label77.Text = "Serail Text"
                            .Text = "Barcode Printing"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With AccessoriesBarCode
                            .btnPrint.Text = "طباعة"
                            .Label79.Text = "عدد الملصقات"
                            .Label28.Text = "تحديد الطابعة"
                            .Label80.Text = "باركود ويب"
                            .Label82.Text = "نص الويب"
                            .Label84.Text = "سبائك"
                            .btnSave.Text = "حفظ الإعدادات"
                            .GroupBox1.Text = "باركود الجهة اليمنى"
                            .GroupBox2.Text = "باركود الجهة اليسرى"
                            .GroupBox1.RightToLeft = 1
                            .GroupBox2.RightToLeft = 1
                            .Label2.Text = "الصنف"
                            .Label4.Text = "الصنف"
                            .GroupBox3.Text = "ضبط إعدادات الجهة اليمنى للباركود"
                            .GroupBox4.Text = "ضبط إعدادات الجهة اليسرى للباركود"
                            .GroupBox3.RightToLeft = 1
                            .GroupBox4.RightToLeft = 1
                            .GroupBox5.Text = "القيم"
                            .GroupBox6.Text = "النصوص"
                            .GroupBox7.Text = "القيم"
                            .GroupBox8.Text = "النصوص"
                            .Label31.Text = "نص النوع"
                            .Label33.Text = "نص الماركة"
                            .Label35.Text = "قيمة الماركة"
                            .Label37.Text = "قيمة رقم القطعة"
                            .Label39.Text = "نص رقم القطعة"
                            .Label41.Text = "نص الموديل"
                            .Label43.Text = "خط الباركود"
                            .Label45.Text = "السعر"
                            .Label47.Text = "رقم الباركود"
                            .Label49.Text = "اسم المعرض"
                            .Label51.Text = "قيمة النوع"
                            .Label53.Text = "قيمة السيريال"
                            .Label55.Text = "نص النوع"
                            .Label57.Text = "نص الماركة"
                            .Label59.Text = "قيمة الماركة"
                            .Label61.Text = "قيمة رقم القطعة"
                            .Label63.Text = "نص رقم القطعة"
                            .Label65.Text = "قيمة الموديل"
                            .Label67.Text = "خط الباركود"
                            .Label69.Text = "السعر"
                            .Label71.Text = "رقم الباركود"
                            .Label73.Text = "اسم المعرض"
                            .Label75.Text = "قيمة النوع"
                            .Label77.Text = "نص السيريال"
                            .Text = "طباعة الباركود"
                        End With
                    End If
                Case "FRMUSERS"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With frmUsers
                            .btnNew.Text = "New"
                            .btnSave.Text = "Save"
                            .btnDelete.Text = "Delete"
                            .btnModify.Text = "Modify"
                            .gbPrivilage.Text = "ALL Permissions"
                            .chkSell.Text = "Sale"
                            .chkBarCode.Text = "Barcode"
                            .chkModify.Text = "Adjustment"
                            .chkGramPrice.Text = "Gold Carat symbols"
                            .chkSalary.Text = "Expenses"
                            .chkWholeSaleBuy.Text = "WholeSale purchases"
                            .chkUsers.Text = "Users"
                            .chkCashier.Text = "Staff Management"
                            .chkWholesale.Text = "WholeSale Sales"
                            .chkReports.Text = "Reports"
                            .chkExpenses.Text = "Salaries"
                            .chkStock.Text = "Inventory"
                            .chkItem.Text = "Items"
                            .lblUserName.Text = "User Name"
                            .chkLimitStock.Text = "Associate Item With User"
                            .lblPassword.Text = "Password"
                            .btnAllPrivilage.Text = "User Permissions"
                            .chkModifyInvoce.Text = "Modify Item invoice"
                            .chkDelItem.Text = "Del Item"
                            .chkItemSelectInvo.Text = "Item Select In invoice"
                            .Text = "User Management"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With frmUsers
                            .btnNew.Text = "جديد"
                            .btnSave.Text = "حفظ"
                            .btnDelete.Text = "حذف"
                            .btnModify.Text = "تعديل"
                            .gbPrivilage.Text = "صلاحيات المستخدمين"
                            .btnAllPrivilage.Text = "كل الصلاحيات"
                            .chkSell.Text = "البيع"
                            .chkBarCode.Text = "الباركود"
                            .chkModify.Text = "التعديلات"
                            .chkGramPrice.Text = "رموز عيار الذهب"
                            .chkSalary.Text = "المصروفات"
                            .chkWholeSaleBuy.Text = "مشتريات الجملة"
                            .chkUsers.Text = "المستخدمين"
                            .chkCashier.Text = "ادارة الموظفين"
                            .chkWholesale.Text = "مبيعات الجملة"
                            .chkReports.Text = "التقارير"
                            .chkExpenses.Text = "الرواتب"
                            .chkStock.Text = "المخزون"
                            .chkItem.Text = "الأصناف"
                            .chkLimitStock.Text = "تقيد الاصناف بالمستخدم"
                            .lblUserName.Text = "اسم المستخدم"
                            .lblPassword.Text = "كلمة المرور"
                            .chkModifyInvoce.Text = "تعديل الصنف بالفاتوره"
                            .chkDelItem.Text = "حزف الصنف"
                            .chkItemSelectInvo.Text = "اختيار الصنف بالفاتوره"
                            .Text = "إدارة المستخدمين"
                        End With
                    End If
                Case "EXPENSES"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With Expenses
                            .btnItemNew.Text = "New"
                            '.btnItemEdit.Text = "Edit"
                            .btnItemSave.Text = "Save"
                            .lblCategory.Text = "Category"
                            .lblDate.Text = "Date"
                            .lblCash.Text = "Cash"
                            .lblKNET.Text = "Pay Method"
                            .LabBank.Text = "Bank"
                            .lblDescription.Text = "Description"
                            .labExpInvNo.Text = "Receipt Number"
                            .Text = "Expenses"
                            .LabSndNo.Text = "Receipt No."
                            .LabCasher.Text = "Cashier"
                            '.BtnPrent.Text = "Prent"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With Expenses
                            .btnItemNew.Text = "جديد"
                            .btnItemSave.Text = "حفظ"
                            .lblCategory.Text = "التصنيف"
                            .lblDate.Text = "التاريخ"
                            .lblCash.Text = "المبلغ كاش"
                            .LabBank.Text = "بنكي"
                            .lblKNET.Text = "طريقة الدفع"
                            .lblDescription.Text = "الوصف"
                            .labExpInvNo.Text = "رقم الايصال"
                            .Text = "المصروفات"
                            .LabSndNo.Text = "رقم سند الصرف"
                            .LabCasher.Text = "الكاشير"
                            '.BtnPrent.Text = "طباعه"
                        End With
                    End If
                Case "FRMEDITDELETE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With FrmEditDelete
                            .btnSave.Text = "Save"
                            .btnView.Text = "View"
                            .lblCategory.Text = "Category"
                            .btnDeleteInvoice.Text = "Delete"
                            .btnPrint.Text = "Print"
                            .labDate.Text = "Date"
                            .labCash.Text = "Cash"
                            .LabPayMethod.Text = "Pay Method"
                            .LabBank.Text = "Bank"
                            .lblDescription.Text = "Description"
                            .Text = "Modify/Delete Expenses"
                            .LabSndNo.Text = "Receipt No."
                            .LabCasher.Text = "Cashier"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With FrmEditDelete
                            .btnSave.Text = "حفظ"
                            .btnView.Text = "عرض"
                            .lblCategory.Text = "التصنيف"
                            .btnDeleteInvoice.Text = "التاريخ"
                            .btnPrint.Text = "طباعه"
                            .labDate.Text = "حزف"
                            .labCash.Text = "كاش"
                            .LabPayMethod.Text = "طريقة الدفع"
                            .LabBank.Text = "بنكي"
                            .lblDescription.Text = "الوصف"
                            .Text = "تعديل/حزف المصروفات"
                            .LabSndNo.Text = "رقم سند الصرف"
                            .LabCasher.Text = "الكاشير"
                        End With
                    End If
                Case "GOLDBUYPAY"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With GoldBuyPersonPay
                            .btnSave.Text = "Save"
                            .btnPrint.Text = "Print"
                            .lblInvoiceNo.Text = "Invoice Number"
                            .lblPrice.Text = "Total Bill"
                            .lblRemaining.Text = "Remaining amount"
                            .lblKNET.Text = "K-NET"
                            .lblCash.Text = "Cash"
                            .rbCash.Text = "Cash"
                            .rbCredit.Text = "Credit"
                            .gbInvoiceDetails.Text = "Invoice Statement"
                            .gbPayDetails.Text = "Payment Details"
                            .Text = "Payment Statement"
                            .RadCastm.Text = "Castomer Copy"
                            .RadAcc.Text = "ACC Copy"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With GoldBuyPersonPay
                            .btnSave.Text = "حفظ"
                            .btnPrint.Text = "طباعة"
                            .lblInvoiceNo.Text = "رقم الفاتورة"
                            .lblPrice.Text = "المبلغ"
                            .lblRemaining.Text = "المتبقي"
                            .lblKNET.Text = "كي نت"
                            .lblCash.Text = "كاش"
                            .rbCash.Text = "نقدا"
                            .rbCredit.Text = "آجل"
                            .gbInvoiceDetails.Text = "بيان الفاتورة"
                            .gbPayDetails.Text = "بيانات الدفع"
                            .Text = "بيان فاتورة شراء"
                            .RadCastm.Text = "نسخة العميل"
                            .RadAcc.Text = "نسخة المحاسب"
                        End With
                    End If

                Case "DIAMONDBUYPAY"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With DiamondBuyPay
                            .btnSave.Text = "Save"
                            .btnPrint.Text = "Print"
                            .Label5.Text = "Invoice Number"
                            .Label4.Text = "Total Bill"
                            .Label6.Text = "Remaining amount"
                            .Label7.Text = "K-NET"
                            .Label8.Text = "Cash"
                            .rbCash.Text = "Cash"
                            .rbPostPone.Text = "Credit"
                            .GroupBox1.Text = "Payment Statement"
                            .Text = "Payment Statement"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With DiamondBuyPay
                            .btnSave.Text = "حفظ"
                            .btnPrint.Text = "طباعة"
                            .Label5.Text = "رقم الفاتورة"
                            .Label4.Text = "إجمالي الفاتورة"
                            .Label6.Text = "باقي المبلغ"
                            .Label7.Text = "كي نت"
                            .Label8.Text = "نقدي"
                            .rbCash.Text = "نقدا"
                            .rbPostPone.Text = "أجل"
                            .GroupBox1.Text = "بيانات الدفع"
                            .Text = "بيانات الدفع"
                        End With
                    End If

                Case "GOLDSELLEDITREMOVE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With GoldSellEditRemove
                            .lblInvoiceNo.Text = "Invoice No."
                            .btnView.Text = "Show Invoice"
                            .btnAddItem.Text = "Add Item"
                            .btnDeleteInvoice.Text = "Delete" & vbCrLf & "Invoice"
                            .btnPrint.Text = "Print"
                            .btnSave.Text = "Save"
                            .gbSave.Text = "Invoice Edit"
                            .gbSave.RightToLeft = 0
                            .lblInvoicePrice.Text = "Total Price"
                            .lblReturn.Text = "Return"
                            .lblCash.Text = "Cash Paid"
                            .lblBank.Text = "Bank Paid"
                            .lblPayMethod.Text = "Pay By"
                            .lblNote.Text = "Invoice Note"
                            .colitem_name.HeaderText = "Item Name"
                            .colitem_GramPrice.HeaderText = "Gram Price"
                            .colitem_gram.HeaderText = "Gold Weight"
                            .colitem_gramMade.HeaderText = "M.C."
                            .colStoneName1.HeaderText = "CS Name1"
                            .colStoneColor1.HeaderText = "CS Color1"
                            .colStoneWeight1.HeaderText = "CS Wt1"
                            .colStonePrice1.HeaderText = "CS Price1"
                            .colStoneName2.HeaderText = "CS Name2"
                            .colStoneColor2.HeaderText = "CS Color2"
                            .colStoneWeight2.HeaderText = "CS Wt2"
                            .colStonePrice2.HeaderText = "CS Price2"
                            .colStoneName3.HeaderText = "CS Name3"
                            .colStoneColor3.HeaderText = "CS Color3"
                            .colStoneWeight3.HeaderText = "CS Wt3"
                            .colStonePrice3.HeaderText = "CS Price3"
                            .colitem_totalPrice.HeaderText = "Total Price"
                            .colInvoiceNo.HeaderText = "Invoice No."
                            .colNotes.HeaderText = "Notes"
                            .Delete.HeaderText = "Del"
                            .Text = "Delete/Edit Gold/Silver"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With GoldSellEditRemove
                            .btnView.Text = "عرض الفاتورة"
                            .btnPrint.Text = "طباعة"
                            .btnSave.Text = "حفظ"
                            .btnDeleteInvoice.Text = "حذف الفاتورة"
                            .gbSave.Text = "تعديل الفاتورة"
                            .gbSave.RightToLeft = 1
                            .txtPriceReturn.RightToLeft = 0
                            .txtPriceRequired.RightToLeft = 0
                            .txtKnet.RightToLeft = 0
                            .txtCash.RightToLeft = 0
                            .lblInvoicePrice.Text = "مبلغ الفاتورة"
                            .lblReturn.Text = "أرجع للعميل"
                            .lblCash.Text = "المدفوع كاش"
                            .lblBank.Text = "المدفوع بنكي"
                            .lblPayMethod.Text = "طريقة الدفع"
                            .colitem_name.HeaderText = "اسم الصنف"
                            .colitem_GramPrice.HeaderText = "سعر الجرام"
                            .colitem_gram.HeaderText = "وزن الذهب"
                            .colitem_gramMade.HeaderText = "المصنعية"
                            .colStoneName1.HeaderText = "فص1"
                            .colStoneColor1.HeaderText = "لون فص1"
                            .colStoneWeight1.HeaderText = "و.فص1"
                            .colStonePrice1.HeaderText = "سعر فص1"
                            .colStoneName2.HeaderText = "فص2"
                            .colStoneColor2.HeaderText = "لون فص2"
                            .colStoneWeight2.HeaderText = "و.فص2"
                            .colStonePrice2.HeaderText = "سعر فص2"
                            .colStoneName3.HeaderText = "فص3"
                            .colStoneColor3.HeaderText = "لون فص3"
                            .colStoneWeight3.HeaderText = "و.فص3"
                            .colStonePrice3.HeaderText = "سعر فص3"
                            .colitem_totalPrice.HeaderText = "إجمالي المبلغ"
                            .colInvoiceNo.HeaderText = "رقم الفاتورة"
                            .colNotes.HeaderText = "ملاحظات البائع"
                            .Delete.HeaderText = "حذف"
                            .Text = "تعديل/حذف فواتير ذهب وفضة"
                            .grid.RightToLeft = 0
                        End With
                    End If

                Case "DIAMONDSELLEDITREMOVE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With DiamondSellEditRemove
                            .btnView.Text = "View"
                            .btnPrint.Text = "Print"
                            .btnSave.Text = "Save"
                            .lblInvoiceNo.Text = "Invoice No."
                            .btnDeleteInvoice.Text = "Del Invoice"
                            .btnAddItem.Text = "Add Item"
                            .gbInvoiceData.Text = "Invoice Edit"
                            .lblPriceRequired.Text = "Total Invoice Price"
                            .lblPriceReturn.Text = "Return"
                            .lblCash.Text = "Cash Paid"
                            .lblKnet.Text = "Bank Paid"
                            .lblPayMethod.Text = "Pay Method"
                            .lblDate.Text = "Invoice Date"
                            .lblCashier.Text = "Cashier"
                            .Text = "Delete/Edit Diamond Sell Invoices"
                            .rbtnCash.Text = "Cash"
                            .rbtnInstallment.Text = "Installment"
                            .colDIMO_Type.HeaderText = "Type"
                            .colDIM_na9awa.HeaderText = "Clarity"
                            .colDIMO_mezan.HeaderText = "D.Wt"
                            .coltotal.HeaderText = "Price"
                            .colDIMO_coler.HeaderText = "D.Color"
                            .colDIMO_qult.HeaderText = "Qty"
                            .colsarual.HeaderText = "Item No."
                            .colval_gold.HeaderText = "Karat"
                            .colGOLD_mezan.HeaderText = "G.Wt"
                            .coltest_13.HeaderText = "CS1 Wt"
                            .coltest_14.HeaderText = "CS1 Name"
                            .coltest_15.HeaderText = "CS1 Color"
                            .coltest_16.HeaderText = "CS2 Wt"
                            .coltest_17.HeaderText = "CS2 Name"
                            .coltest_18.HeaderText = "CS2 Color"
                            .coltest_19.HeaderText = "CS3 Wt"
                            .coltest_110.HeaderText = "CS3 Name"
                            .coltest_111.HeaderText = "CS3 Color"
                            .coltest_116.HeaderText = "Total Weight"
                            .coltest_117.HeaderText = "D.Cut"
                            .coltest_119.HeaderText = "BarCode"
                            .colnotes.HeaderText = "Notes"
                            .colGramPrice.HeaderText = "Gram Price"
                            .colSoldItem.HeaderText = "Sold Items"
                            .colCut1.HeaderText = "CS1 Cut"
                            .colClarity1.HeaderText = "CS1 Clarity"
                            .colCut2.HeaderText = "CS2 Cut"
                            .colClarity2.HeaderText = "CS2 Clarity"
                            .colCut3.HeaderText = "CS3 Cut"
                            .colClarity3.HeaderText = "CS3 Clarity"
                            .colDelete.HeaderText = "Del"

                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With DiamondSellEditRemove
                            .btnView.Text = "عرض"
                            .btnPrint.Text = "طباعة"
                            .btnSave.Text = "حفظ"
                            .lblInvoiceNo.Text = "رقم الفاتورة"
                            .btnDeleteInvoice.Text = "حذف الفاتورة"
                            .btnAddItem.Text = "إضافة صنف"
                            .gbInvoiceData.Text = "تعديل الفاتورة"
                            .txtPriceReturn.RightToLeft = 0
                            .txtPriceRequired.RightToLeft = 0
                            .txtKnet.RightToLeft = 0
                            .txtCash.RightToLeft = 0
                            .lblPriceRequired.Text = "مبلغ الفاتورة"
                            .lblPriceReturn.Text = "أرجع للعميل"
                            .lblCash.Text = "المدفوع كاش"
                            .lblKnet.Text = "المدفوع بنكي"
                            .gbInvoiceData.RightToLeft = 1
                            .lblPayMethod.Text = "طريقة الدفع"
                            .lblDate.Text = "تاريخ الفاتورة"
                            .lblCashier.Text = "الكاشير"
                            .Text = "تعديل/حذف ألماس"
                            .rbtnCash.Text = "نقدي"
                            .rbtnInstallment.Text = "آجل"
                            .colDIMO_Type.HeaderText = "النوع"
                            .colDIM_na9awa.HeaderText = "النقاوة"
                            .colDIMO_mezan.HeaderText = "وزن الألماس"
                            .colDIMO_coler.HeaderText = "لون الألماس"
                            .colDIMO_qult.HeaderText = "العدد"
                            .colsarual.HeaderText = "رقم القطعة"
                            .colval_gold.HeaderText = "القيراط"
                            .coltotal.HeaderText = "السعر"
                            .colGOLD_mezan.HeaderText = "وزن الذهب"
                            .coltest_13.HeaderText = "وزن حجر1"
                            .coltest_14.HeaderText = "نوع حجر1"
                            .coltest_15.HeaderText = "لون حجر1"
                            .coltest_16.HeaderText = "وزن حجر2"
                            .coltest_17.HeaderText = "نوع حجر2"
                            .coltest_18.HeaderText = "لون حجر2"
                            .coltest_19.HeaderText = "وزن حجر3"
                            .coltest_110.HeaderText = "نوع حجر3"
                            .coltest_111.HeaderText = "لون حجر3"
                            .coltest_116.HeaderText = "الوزن الكلي"
                            .coltest_117.HeaderText = "قصة الألماس"
                            .coltest_119.HeaderText = "الباركود"
                            .colnotes.HeaderText = "ملاحظات"
                            .colGramPrice.HeaderText = "سعر الجرام"
                            .colSoldItem.HeaderText = "القطع المباعة"
                            .colCut1.HeaderText = "قصة الحجر1"
                            .colClarity1.HeaderText = "نقاوة الحجر1"
                            .colCut2.HeaderText = "قصة الحجر2"
                            .colClarity2.HeaderText = "نقاوة الحجر2"
                            .colCut3.HeaderText = "قصة الحجر3"
                            .colClarity3.HeaderText = "نقاوة الحجر3"
                            .colDelete.HeaderText = "حذف"

                        End With
                    End If

                Case "GOLDBUYPERSON"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With GoldBuyPerson
                            .LabItem_Des.Text = "Item Description"
                            .btnSave.Text = "Save"
                            .cmbKarat.Text = "Choose Carat"
                            .btnPayPrint.Text = "Pay/Print"
                            .Label2.Text = "Karat"
                            .Bay_mazanLabel.Text = "Weight"
                            .Bay_gram_priceLabel.Text = "Price Per Gram"
                            .LinkLabel1.Text = "Price"
                            .Bay_total_priceLabel.Text = "Total Purchase Price"
                            .colGoldWeight999.HeaderText = "Net Weight"
                            .colGoldCaret999.HeaderText = "Net Karat"
                            .colItem_Des.HeaderText = "Item Description"
                            .colQunt.HeaderText = "Qunt"
                            .colbay_mazan.HeaderText = "Weight"
                            .colbay_gram_price.HeaderText = "Price Per Gram"
                            .colbay_val.HeaderText = "Karat"
                            .colTotalPrice.HeaderText = "Total Purchase Price"
                            .colDelete.HeaderText = "Del"
                            .Text = "Gold Purchases"
                            .lblCashier.Text = "Casher"
                            .lblDate.Text = "Date"
                            .lblNetCaret.Text = "Net Karat"
                            .lblNetWeight.Text = "Net Weight"
                            .lblQunt.Text = "Qunt"
                            .lblNote.Text = "Note"
                            .LblAddToItem.Text = "Add To Gold Items"
                            .RightToLeft = 0
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With GoldBuyPerson
                            .LabItem_Des.Text = "وصف الصنف"
                            .btnSave.Text = "حفظ"
                            .cmbKarat.Text = "اختر عيار"
                            .btnPayPrint.Text = "دفع/طباعة"
                            .Label2.Text = "العيار"
                            .Bay_mazanLabel.Text = "الوزن"
                            .Bay_gram_priceLabel.Text = "حساب سعر الغرام"
                            .LinkLabel1.Text = "حساب السعر"
                            .Bay_total_priceLabel.Text = "إجمالي سعر الشراء"
                            .colGoldWeight999.HeaderText = "وزن الرمله"
                            .colGoldCaret999.HeaderText = "عيار الرمله"
                            .colItem_Des.HeaderText = "وصف الصنف"
                            .colQunt.HeaderText = "العدد"
                            .colbay_mazan.HeaderText = "الوزن"
                            .colbay_gram_price.HeaderText = "سعر الغرام"
                            .colbay_val.HeaderText = "العيار"
                            .colTotalPrice.HeaderText = "إجمالي السعر"
                            .colDelete.HeaderText = "حذف"
                            .Text = "مشتريات"
                            .lblCashier.Text = "الكاشير"
                            .lblDate.Text = "التريخ"
                            .lblNetCaret.Text = "عيار الرمله"
                            .lblNetWeight.Text = "وزن الرمله"
                            .lblQunt.Text = "العدد"
                            .lblNote.Text = "ملاحظات"
                            .LblAddToItem.Text = "اضف الي الاصناف"
                            .RightToLeft = 0
                        End With
                    End If
                Case "DIAMONDBUYPERSON"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With DiamondBuyPerson
                            .btnAddCustomer.Text = "Add New Customer"
                            .Label1.Text = "Civil ID"
                            .LabCasher.Text = "Casher"
                            .Label14.Text = "Name"
                            .Label15.Text = "Phone"
                            .Label16.Text = "Address"
                            .Label17.Text = "Nationality"
                            .btnView.Text = "View"
                            .GroupBox1.Text = "Customer Data"
                            .GroupBox1.RightToLeft = 0
                            .btnSave.Text = "Save"
                            .btnDelete.Text = "Delete"
                            .btnFirst.Text = "First Item"
                            .btnLast.Text = "Last Item"
                            .btnNext.Text = "Next Item"
                            .btnPrevious.Text = "Previous Item"
                            .btnPayPrint.Text = "Pay/Print"
                            .lblItemName.Text = "Item Name"
                            .lblClarity.Text = "Clarity"
                            .lblCarat.Text = "Carat"
                            .lblColor.Text = "Color"
                            .lblCut.Text = "Cut"
                            .lblSerialNo.Text = "Item No."
                            .lblGoldWeight.Text = "Gold Weight"
                            .lblGoldCarat.Text = "Gold Carat"
                            .lblPrice.Text = "Price"
                            .lblTotalPrice.Text = "Total Price"
                            .lblNotes.Text = "Notes"
                            .inv_id.HeaderText = "Inv. No."
                            .DIMO_dep.HeaderText = "Item Name"
                            .DIM_na9awa.HeaderText = "Clarity"
                            .ext_coler.HeaderText = "Color"
                            .DIMO_mezan.HeaderText = "Carat"
                            .test_11.HeaderText = "Cut"
                            .sarual.HeaderText = "Item No."
                            .GOLD_mezan.HeaderText = "Gold Weight"
                            .val_gold.HeaderText = "Gold Carat"
                            .test_12.HeaderText = "Price"
                            .Text = "Diamond Purchases"

                            .RightToLeft = 0
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With DiamondBuyPerson
                            .btnAddCustomer.Text = "إضافة عميل جديد"
                            .Label1.Text = "الرقم المدني"
                            .Label14.Text = "الاسم"
                            .Label15.Text = "الهاتف"
                            .Label16.Text = "العنوان"
                            .LabCasher.Text = "الكاشير"
                            .Label17.Text = "الجنسية"
                            .btnView.Text = "عرض"
                            .GroupBox1.Text = "             بيانات العميل"
                            .GroupBox1.RightToLeft = 1
                            .btnSave.Text = "حفظ"
                            .btnDelete.Text = "حذف"
                            .btnFirst.Text = "أول صنف"
                            .btnLast.Text = "آخر صنف"
                            .btnNext.Text = "التالي"
                            .btnPrevious.Text = "السابق"
                            .btnPayPrint.Text = "دفع/طباعة"
                            .lblItemName.Text = "اسم الصنف"
                            .lblClarity.Text = "النقاوة"
                            .lblColor.Text = "اللون"
                            .lblCarat.Text = "القيراط"
                            .lblCut.Text = "القص"
                            .lblSerialNo.Text = "رقم القطعة"
                            .lblGoldWeight.Text = "و. ذهب"
                            .lblGoldCarat.Text = "عيار ذهب"
                            .lblPrice.Text = "السعر"
                            .lblTotalPrice.Text = "إجمالي السعر"
                            .lblNotes.Text = "ملاحظات"
                            .inv_id.HeaderText = "رقم الفاتورة"
                            .DIMO_dep.HeaderText = "اسم الصنف"
                            .DIM_na9awa.HeaderText = "النقاوة"
                            .ext_coler.HeaderText = "اللون"
                            .DIMO_mezan.HeaderText = "قيراط"
                            .test_11.HeaderText = "قص"
                            .sarual.HeaderText = "رقم القطعة"
                            .GOLD_mezan.HeaderText = "وزن. ذهب"
                            .val_gold.HeaderText = "عيار. ذهب"
                            .test_12.HeaderText = "السعر"
                            .Text = "مشتريات ألماس"
                            .RightToLeft = 0
                        End With
                    End If

                Case "COMPANYDETAILS"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With CompanyDetails
                            .RightToLeft = 0
                            .gb.Text = "Company Details"
                            .gb.RightToLeft = 0
                            .btnSave.Text = "Save"
                            .Co_shonameLabel.Text = "Showroom Name"
                            .Co_nameLabel.Text = "Company Name"
                            .Co_adressLabel.Text = "Address"
                            .Co_nompLabel.Text = "Phone"
                            .Co_fasxLabel.Text = "Fax"
                            .Co_depLabel.Text = "E-Mail"
                            .lnkLogo.Text = "Company Logo"
                            .Text = "Company Details"
                            .GroRptDetels.Text = "Report Header and Footer"
                            .BtnHeaderReport.Text = "Header Report"
                            .BtnFooterReport.Text = "Footer Report"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With CompanyDetails
                            .RightToLeft = 0
                            .gb.Text = "بيانات الشركة"
                            .gb.RightToLeft = 1
                            .Comp_note11TextBox.RightToLeft = 0
                            .Comp_faxTextBox.RightToLeft = 0
                            .Comp_emailTextBox.RightToLeft = 0
                            .btnSave.Text = "حفظ"
                            .Co_shonameLabel.Text = "اســــم المعرض"
                            .Co_nameLabel.Text = "اســــم الشركة"
                            .Co_adressLabel.Text = "العـــنــــوان"
                            .Co_nompLabel.Text = "الهـــاتـــــف"
                            .Co_fasxLabel.Text = "الفـــــاكـــس"
                            .Co_depLabel.Text = "البريد الإلكتروني"
                            .lnkLogo.Text = "لوقو الشركة"
                            .Text = "بيانات الشركة"
                            .GroRptDetels.Text = "رأس وتزييل التقارير"
                            .BtnHeaderReport.Text = "رأس التقرير"
                            .BtnFooterReport.Text = "تزييل التقرير"
                        End With
                    End If


                Case "GOLDVIEWBUYINVOICE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With GoldViewBuyInvoice
                            .RightToLeft = 0
                            .btnView.Text = "View Invoice"
                            .btnPrint.Text = "Print"
                            .Text = "Buy Invoice Review Gold"
                            .RadAcc.Text = "Accounting Copy"
                            .RadCastm.Text = "Customer Copy"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With GoldViewBuyInvoice
                            .RightToLeft = 0
                            .btnView.Text = "عرض الفاتورة"
                            .btnPrint.Text = "طباعة"
                            .Text = "مراجعة فواتير الشراء ذهب"
                            .RadAcc.Text = "نسخة المحل"
                            .RadCastm.Text = "نسخة العميل"
                        End With
                    End If
            'سند استلام ذهب
                Case "FRMGOLDVOUCHERRESERVE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With FrmGoldVoucherReserve
                            .RightToLeft = 0
                            .Text = "Gold Bond"
                            .LabSndName.Text = "Bond Type"
                            .LabComName.Text = "Supplier/Company/Workshop"
                            .LabCasher.Text = "Cashier"
                            .BtnAdd.Text = "Add"
                            .BtnSave.Text = "Save and print"
                            .LblKart.Text = "Gold Carat"
                            .Bay_mazanLabel.Text = "Weight"
                            .lblNetCaret.Text = "Net Caret"
                            .lblNetWeight.Text = "Net Weight"
                            .lblQuntt.Text = "Quantity"
                            .LabDate.Text = "Date"
                            .lblGramPrice.Text = "G-Price"
                            .lblGoldPrice.Text = "Gold Price"
                            .lblMakeCharge.Text = "M.C"
                            .lblTMakeCharge.Text = "Total M.C"
                            .lblTotalPrice.Text = "Total Price"
                            .ChkAutocalculation.Text = "Aut Calculation"
                            .LabDescription.Text = "Description"
                            .Grid.Columns("colDelete").HeaderText = "Del"
                            .Grid.Columns("colComGoldype").HeaderText = "Bond Type"
                            .Grid.Columns("colCob_Comp_nam").HeaderText = "Supplier/Company/Workshop"
                            .Grid.Columns("colComCasher").HeaderText = "Cashier"
                            .Grid.Columns("colcmbKarat").HeaderText = "Weight"
                            .Grid.Columns("coltxtWeight").HeaderText = "Weight"
                            .Grid.Columns("colComBxGoCaret999").HeaderText = "Net Caret"
                            .Grid.Columns("colTXTGoCaret999").HeaderText = "Net Weight"
                            .Grid.Columns("coltxtQuntt").HeaderText = "Quantity"
                            .Grid.Columns("coldtExpensesDate").HeaderText = "Date"
                            .Grid.Columns("coltxtGramPrice").HeaderText = "G-Price"
                            .Grid.Columns("coltxtGoldPrice").HeaderText = "Gold Price"
                            .Grid.Columns("coltxtMakeCharge").HeaderText = "M.C"
                            .Grid.Columns("coltxtTMakeCharge").HeaderText = "Total M.C"
                            .Grid.Columns("coltxtTotalPrice").HeaderText = "Total Price"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With FrmGoldVoucherReserve
                            .RightToLeft = 0
                            .Text = "سندات الذهب"
                            .LabSndName.Text = "نوع السند"
                            .LabComName.Text = "المورد/الشركه/الورشه"
                            .LabCasher.Text = "كاشير"
                            .BtnAdd.Text = "اضافه"
                            .BtnSave.Text = "حفظ وطباعه"
                            .LblKart.Text = "العيار القائم"
                            .Bay_mazanLabel.Text = "الوزن القائم"
                            .lblNetCaret.Text = "عيار الرمله"
                            .lblNetWeight.Text = "وزن الرمله"
                            .lblQuntt.Text = "العدد"
                            .LabDate.Text = "التاريخ"
                            .lblGramPrice.Text = "سعر الجرام"
                            .lblGoldPrice.Text = "سعر الذهب"
                            .lblMakeCharge.Text = "المصنعيه"
                            .lblTMakeCharge.Text = "اجمالي المصنعيه"
                            .lblTotalPrice.Text = "اجمالي السعر"
                            .ChkAutocalculation.Text = "حساب تلقائي"
                            .LabDescription.Text = "الــــــوصـــــف"
                            .Grid.Columns("colDelete").HeaderText = "حزف"
                            .Grid.Columns("colComGoldype").HeaderText = "نوع السند"
                            .Grid.Columns("colCob_Comp_nam").HeaderText = "المورد/الشركه/الورشه"
                            .Grid.Columns("colComCasher").HeaderText = "كاشير"
                            .Grid.Columns("colcmbKarat").HeaderText = "العيار القائم"
                            .Grid.Columns("coltxtWeight").HeaderText = "الوزن القائم"
                            .Grid.Columns("colComBxGoCaret999").HeaderText = "عيار الرمله"
                            .Grid.Columns("colTXTGoCaret999").HeaderText = "وزن الرمله"
                            .Grid.Columns("coltxtQuntt").HeaderText = "العدد"
                            .Grid.Columns("coldtExpensesDate").HeaderText = "التاريخ"
                            .Grid.Columns("coltxtGramPrice").HeaderText = "سعر الجرام"
                            .Grid.Columns("coltxtGoldPrice").HeaderText = "سعر الذهب"
                            .Grid.Columns("coltxtMakeCharge").HeaderText = "المصنعيه"
                            .Grid.Columns("coltxtTMakeCharge").HeaderText = "اجمالي المصنعيه"
                            .Grid.Columns("coltxtTotalPrice").HeaderText = "اجمالي السعر"
                        End With
                    End If

                Case "DIAMONDVIEWBUYINVOICE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With DiamondViewBuyInvoice
                            .RightToLeft = 0
                            .btnView.Text = "View Invoice"
                            .btnPrint.Text = "Print"
                            .Text = "Buy Invoice Review Diamond"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With DiamondViewBuyInvoice
                            .RightToLeft = 0
                            .btnView.Text = "عرض الفاتورة"
                            .btnPrint.Text = "طباعة"
                            .Text = "مراجعة فواتير شراء ألماس"
                        End With
                    End If

                Case "SILVERVIEWSELLINVOICE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With SilverViewSellInvoice
                            .RightToLeft = 0
                            .lblInvoiceNo.Text = "Invoice No."
                            .chkEngInvoice.Text = "English Invoice"
                            .btnView.Text = "Show Invoice"
                            .btnPrint.Text = "Print"
                            .RadAcc.Text = "Accounting Copy"
                            .RadCastm.Text = "Customer Copy"
                            .Text = "Invoice Review Silver"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With SilverViewSellInvoice
                            .RightToLeft = 0
                            .lblInvoiceNo.Text = "رقم الفاتورة"
                            .chkEngInvoice.Text = "فاتورة إنجليزي"
                            .btnView.Text = "عرض الفاتورة"
                            .btnPrint.Text = "طباعة"
                            .RadAcc.Text = "نسخة المحل"
                            .RadCastm.Text = "نسخة العميل"
                            .Text = "مراجعة فواتير بيع الفضه"
                        End With
                    End If


                Case "GOLDVIEWSELLINVOICE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With GoldViewSellInvoice
                            .RightToLeft = 0
                            .lblInvoiceNo.Text = "Invoice No."
                            .chkEngInvoice.Text = "English Invoice"
                            .btnView.Text = "Show Invoice"
                            .btnPrint.Text = "Print"
                            .RadAcc.Text = "AccountingCopy"
                            .RadCastm.Text = "CustomerCopy"
                            .Text = "Invoice Review"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With GoldViewSellInvoice
                            .RightToLeft = 0
                            .lblInvoiceNo.Text = "رقم الفاتورة"
                            .chkEngInvoice.Text = "فاتورة إنجليزي"
                            .btnView.Text = "عرض الفاتورة"
                            .btnPrint.Text = "طباعة"
                            .RadAcc.Text = "نسخة المحاسب"
                            .RadCastm.Text = "نسخة العميل"
                            .Text = "مراجعة الفواتير"
                        End With
                    End If

                Case "DIAMONDVIEWSELLINVOICE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With DiamondViewSellInvoice
                            .RightToLeft = 0
                            .lblInvoiceNo.Text = "Inv. No."
                            .btnView.Text = "Show Invoice"
                            .btnPrint.Text = "Print"
                            .chkEngInvoice.Text = "English Invoice"
                            .Text = "Invoice Review"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With DiamondViewSellInvoice
                            .RightToLeft = 0
                            .lblInvoiceNo.Text = "رقم الفاتورة"
                            .btnView.Text = "عرض الفاتورة"
                            .btnPrint.Text = "طباعة"
                            .chkEngInvoice.Text = "فاتورة إنجليزي"
                            .Text = "مراجعة الفواتير"
                        End With
                    End If

                Case "COUNTRYMADE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With CountryMade
                            .RightToLeft = 0
                            .btnNew.Text = "New"
                            .btnSave.Text = "Save"
                            .btnEdit.Text = "Modify"
                            .btnDelete.Text = "Delete"
                            .grid.Columns(1).HeaderText = "Manufacturing Country"
                            .Text = "Country Of Origin"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With CountryMade
                            .RightToLeft = 0
                            .btnNew.Text = "جديد"
                            .btnSave.Text = "حفظ"
                            .btnEdit.Text = "تعديل"
                            .btnDelete.Text = "حذف"
                            .grid.Columns(1).HeaderText = "بلد الصنع"
                            .Text = "بلد الصنع"
                        End With
                    End If

                Case "GRAMPRICE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With GramPrice
                            .RightToLeft = 0
                            .Button5.Text = "New"
                            .Button4.Text = "Save"
                            .Button6.Text = "Delete"
                            .Gram_valDataGridView.Columns(1).HeaderText = "Type"
                            .Gram_valDataGridView.Columns(2).HeaderText = "Price"
                            .Text = "Price Per Gram"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With GramPrice
                            .RightToLeft = 0
                            .Button5.Text = "جديد"
                            .Button4.Text = "حفظ"
                            .Button6.Text = "حذف"
                            .Gram_valDataGridView.Columns(1).HeaderText = "النوع"
                            .Gram_valDataGridView.Columns(2).HeaderText = "السعر"
                            .Text = "سعر الجرام"
                        End With

                    End If
                'باركود
                Case "BARCODE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With Barcode
                            .RightToLeft = 0
                            .btnDefault.Text = "Restore default barcode settings"
                            .Text = "Barcod Print"
                            .btnPrint.Text = "Barcode printing"
                            .btnSave.Text = "Save"
                            .txtQunt.Text = "Stickers"
                            .chkPrintRange.Text = "Repeat printing"
                            .lblSelectPrinet.Text = "Select Printer"
                            .lblShopName.Text = "Shop Name"
                            .FontSetGro.Text = "Font settings"
                            .lblTextFont.Text = "Font Writing"
                            .lblBarcodFont.Text = "Font Barcod"
                            .lblShopFont.Text = "Font Shop"
                            .lblCountryFont.Text = "Font Country"
                            .btnImge.Text = "Select Logo"
                            .txtShroom.Text = "Shop Name Settings"
                            .gbRight.Text = "Adjust Barcode Settings Right Side"
                            .gbRightText.Text = "Barcod Text"
                            .gbRightValue.Text = "Barcod Values"
                            .gbLeft.Text = "Adjust Barcode Settings Left Side"
                            .gbLeftText.Text = "Barcod Text"
                            .gbLeftValue.Text = "Barcod Values"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With Barcode
                            .RightToLeft = 0
                            .Text = "طباعة الباركود"
                            .btnDefault.Text = "استعادة الضبط الافتراضي للباركود"
                            .btnPrint.Text = "طباعة الباركود"
                            .btnSave.Text = "حفظ"
                            .txtQunt.Text = "عدد المصلقات"
                            .chkPrintRange.Text = "طباعه متتاليه"
                            .lblSelectPrinet.Text = "تحديد الطابعه"
                            .lblShopName.Text = "اسم المعرض"
                            .FontSetGro.Text = "ضبط الخط"
                            .lblTextFont.Text = "خط الكتابه"
                            .lblBarcodFont.Text = "خط الباركود"
                            .lblShopFont.Text = "خط المعرض"
                            .lblCountryFont.Text = "خط بلد المنشأ"
                            .btnImge.Text = "اختيار اللوقو"
                            .txtShroom.Text = "اعدادات اسم المعرض"
                            .gbRight.Text = "ضبط اعدادات الباركود الجه اليمني"
                            .gbRightText.Text = "نصوص الباركود"
                            .gbRightValue.Text = "ارقام الباركود"
                            .gbLeft.Text = "ضبط اعدادات الباركود الجه اليسري"
                            .gbLeftText.Text = "نصوص الباركود"
                            .gbLeftValue.Text = "ارقام الباركود"

                        End With

                    End If

                Case "DIAMONDBARCODE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With DiamondBarCode
                            .RightToLeft = 0
                            .Label61.Text = "ShowRoom Name"
                            .Label60.Text = "BarCode Printer"
                            .btnSave.Text = "Save Settings"
                            .btnPrint.Text = "Print BarCode"
                            .Label34.Text = "Qty."
                            .Label64.Text = "Enter BarCode"
                            .Label63.Text = "Enter BarCode"
                            .Label62.Text = "Select Item"
                            .Label59.Text = "GOLD SAP"
                            .Label1.Text = "Tech.Support"
                            .Label57.Text = "Tel.1"
                            .Label58.Text = "Tel.2"
                            .gbLeft.Text = "Left BarCode"
                            .gbLeftValue.Text = "BarCode Values"
                            .Label46.Text = "BarCode"
                            .Label2.Text = "BarCode No."
                            .Label50.Text = "Price"
                            .Label52.Text = "Gold Kt"
                            .Label49.Text = "D.Color"
                            .Label48.Text = "D.Wt"
                            .Label47.Text = "D.Clarity"
                            .Label53.Text = "Gold Wt"
                            .Label51.Text = "Item No."
                            .gbLeftText.Text = "BarCode Texts"
                            .Label55.Text = "D.Cut"
                            .Label54.Text = "Item Name"
                            .Label56.Text = "ShowRoom Name"
                            .SET1.Text = "Price"
                            .Label11.Text = "Gold Kt"
                            .Label6.Text = "D.Color"
                            .Label7.Text = "D.Wt"
                            .Label5.Text = "D.Clarity"
                            .Label10.Text = "Gold Wt"
                            .Label8.Text = "Item No."
                            .Label4.Text = "Name"
                            .Label82.Text = "Code"
                            .gbRight.Text = "Right BarCode"
                            .gbRightValue.Text = "BarCode Values"
                            .Label3.Text = "BarCode"
                            .Label35.Text = "BarCode No."
                            .Label39.Text = "Price"
                            .Label41.Text = "G.Carat"
                            .Label38.Text = "D.Color"
                            .Label37.Text = "D.Weight"
                            .Label36.Text = "D.Clarity"
                            .Label42.Text = "G.Weight"
                            .Label40.Text = "Item No."
                            .Label83.Text = "Code"
                            .gbRightText.Text = "BarCode Texts"
                            .Label44.Text = "D.Cut"
                            .Label43.Text = "Item Name"
                            .Label45.Text = "ShowRoom Name"
                            .Label15.Text = "Price"
                            .Label17.Text = "G.Carat"
                            .Label18.Text = "D.Color"
                            .Label19.Text = "D.Weight"
                            .Label20.Text = "D.Clarity"
                            .Label16.Text = "G.Weight"
                            .Label14.Text = "Item No."
                            .Label68.Text = "Stone Name1"
                            .Label69.Text = "Stone Weight1"
                            .lblCut1Left.Text = "Stone Cut1"
                            .Label12.Text = "Stone Name2"
                            .Label9.Text = "Stone Weight2"
                            .lblCut2Left.Text = "Stone Cut2"
                            .Label22.Text = "Stone Name3"
                            .Label13.Text = "Stone Weight3"
                            .lblCut3Left.Text = "Stone Cut3"
                            .Label66.Text = "Stone Name1"
                            .Label67.Text = "Stone Weight1"
                            .lblCut1Right.Text = "Stone Cut1"
                            .lblCut2Right.Text = "Stone Cut2"
                            .lblCut3Right.Text = "Stone Cut3"
                            .Label24.Text = "Stone Name2"
                            .Label23.Text = "Stone Weight2"
                            .Label26.Text = "Stone Name3"
                            .Label25.Text = "Stone Weight3"
                            .Label71.Text = "Stone Name1"
                            .Label70.Text = "Stone Weight1"
                            .Label30.Text = "Stone Name2"
                            .Label29.Text = "Stone Weight2"
                            .Label28.Text = "Stone Name3"
                            .Label27.Text = "Stone Weight3"
                            .Label73.Text = "Stone Name1"
                            .Label72.Text = "Stone Weight1"
                            .Label32.Text = "Stone Name2"
                            .Label31.Text = "Stone Weight2"
                            .Label74.Text = "Stone Name3"
                            .Label33.Text = "Stone Weight3"
                            .Label21.Text = "Name"
                            .Label65.Text = "Select Item"
                            .Label75.Text = "Stone Font"
                            .Label76.Text = "BarCode Font"
                            .Label77.Text = "ShowRoom Font"
                            .Label78.Text = "Other Font"
                            .Label84.Text = "Code Font"
                            .Label1.Text = "Tech Font"
                            .Label57.Text = "No1."
                            .Label58.Text = "No2."
                            .lblTotalStoneWeightLeft.Text = "Tot Stone Wt"
                            .lblTotalStoneWeightRight.Text = "Tot Stone Wt"
                            .gbPrintRange.Text = "Print Range"
                            .lblPrintRangeEnd.Text = "End At"
                            .chkPrintRange.Text = "Print Range"
                            .Text = "Diamond BarCode"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With DiamondBarCode
                            .RightToLeft = 0
                            .Label61.Text = "اسم المعرض"
                            .Label60.Text = "طابعة الباركود"
                            .btnSave.Text = "حفظ الإعدادات"
                            .btnPrint.Text = "طباعة الباركود"
                            .Label34.Text = "العدد"
                            .Label64.Text = "أدخل باركود"
                            .Label63.Text = "أدخل باركود"
                            .Label62.Text = "حدد صنف"
                            .Label59.Text = "GOLD SAP"
                            .Label1.Text = "الدعم الفني"
                            .Label57.Text = "تليفون1"
                            .Label58.Text = "تليفون2"
                            .gbLeft.Text = "باركود الجهة اليسرى"
                            .gbLeftValue.Text = "قيم الباركود"
                            .Label46.Text = "الباركود"
                            .Label2.Text = "رقم الباركود"
                            .Label50.Text = "السعر"
                            .Label52.Text = "العيار"
                            .Label49.Text = "اللون"
                            .Label48.Text = "القيراط"
                            .Label47.Text = "النقاوة"
                            .Label53.Text = "وزن الذهب"
                            .Label51.Text = "رقم القطعة"
                            .gbLeftText.Text = "نصوص الباركود"
                            .Label55.Text = "القص"
                            .Label54.Text = "اسم الصنف"
                            .Label56.Text = "اسم المعرض"
                            .SET1.Text = "السعر"
                            .Label11.Text = "العيار"
                            .Label6.Text = "اللون"
                            .Label7.Text = "القيراط"
                            .Label5.Text = "النقاوة"
                            .Label10.Text = "وزن الذهب"
                            .Label8.Text = "رقم القطعة"
                            .Label4.Text = "الاسم"
                            .gbRight.Text = "باركود الجهة اليمنى"
                            .gbRightValue.Text = "قيم الباركود"
                            .Label3.Text = "الباركود"
                            .Label35.Text = "رقم الباركود"
                            .Label39.Text = "السعر"
                            .Label41.Text = "العيار"
                            .Label38.Text = "اللون"
                            .Label37.Text = "القيراط"
                            .Label36.Text = "النقاوة"
                            .Label42.Text = "وزن الذهب"
                            .Label40.Text = "رقم القطعة"
                            .gbRightText.Text = "نصوص الباركود"
                            .Label44.Text = "القص"
                            .Label43.Text = "اسم الصنف"
                            .Label45.Text = "اسم المعرض"
                            .Label15.Text = "السعر"
                            .Label17.Text = "العيار"
                            .Label18.Text = "اللون"
                            .Label19.Text = "القيراط"
                            .Label20.Text = "النقاوة"
                            .Label16.Text = "وزن الذهب"
                            .Label14.Text = "رقم القطعة"
                            .Label21.Text = "الاسم"
                            .Label68.Text = "اسم الحجر1"
                            .Label69.Text = "وزن الحجر1"
                            .Label12.Text = "اسم الحجر2"
                            .Label9.Text = "وزن الحجر2"
                            .Label22.Text = "اسم الحجر3"
                            .Label13.Text = "وزن الحجر3"
                            .Label66.Text = "اسم الحجر1"
                            .Label67.Text = "وزن الحجر1"
                            .Label24.Text = "اسم الحجر2"
                            .Label23.Text = "وزن الحجر2"
                            .Label26.Text = "اسم الحجر3"
                            .Label25.Text = "وزن الحجر3"
                            .Label71.Text = "اسم الحجر1"
                            .Label70.Text = "وزن الحجر1"
                            .Label30.Text = "اسم الحجر2"
                            .Label29.Text = "وزن الحجر2"
                            .Label28.Text = "اسم الحجر3"
                            .Label27.Text = "وزن الحجر3"
                            .Label73.Text = "اسم الحجر1"
                            .Label72.Text = "وزن الحجر1"
                            .Label32.Text = "اسم الحجر2"
                            .Label31.Text = "وزن الحجر2"
                            .Label74.Text = "اسم الحجر3"
                            .Label33.Text = "وزن الحجر3"
                            .lblTotalStoneWeightLeft.Text = "وزن إجمالي للفصوص"
                            .lblTotalStoneWeightRight.Text = "وزن إجمالي للفصوص"
                            .Text = "باركود الألماس"
                        End With
                    End If

                Case "GOLDBUYEDITREMOVE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With GoldBuyEditRemove
                            .RightToLeft = 0
                            .lblInvoiceNo.Text = "Invoice No."
                            .btnView.Text = "View Invoice"
                            .btnPrint.Text = "Print"
                            .gbData.Text = "Pay Details"
                            .btnSave.Text = "Save"
                            .btnDeleteInvoice.Text = "Delete" & vbCrLf & "Invoice"
                            .lblTotalWeight.Text = "Total Weight in Invoice"
                            .tbtReturnedWeight.Text = "Returned Weight"
                            .lblRequired.Text = "Customer To Pay"
                            .lblPrice.Text = "Invoice Price"
                            .lblPriceNew.Text = "Price After Returning"
                            .lblCash.Text = "Cash Pay"
                            .lblBank.Text = "Bank Pay"
                            .lblDate.Text = "Invoice Date"
                            .lblCashier.Text = "Cashier"
                            .grid.Columns("colCID").HeaderText = "Civil ID"
                            .grid.Columns("colKarat").HeaderText = "Karat"
                            .grid.Columns("colWeight").HeaderText = "Weight"
                            .grid.Columns("colGramPrice").HeaderText = "Gram Price"
                            .grid.Columns("colPrice").HeaderText = "Total Price"
                            .grid.Columns("colInvoiceNo").HeaderText = "Invoice No."
                            .grid.Columns("colItemDescription").HeaderText = "Description"
                            .grid.Columns("Delete").HeaderText = "Del"
                            .Text = "Edit/Delete Gold/Silver Sell"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With GoldBuyEditRemove
                            .RightToLeft = 0
                            .lblInvoiceNo.Text = "رقم الفاتورة"
                            .btnView.Text = "عرض"
                            .btnPrint.Text = "طباعة"
                            .gbData.Text = "تفاصيل الدفع"
                            .btnSave.Text = "حفظ"
                            .btnDeleteInvoice.Text = "حذف" & vbCrLf & "الفاتورة"
                            .lblTotalWeight.Text = "إجمالي الوزن في الفاتورة"
                            .tbtReturnedWeight.Text = "الوزن المرتجع"
                            .lblRequired.Text = "مطلوب من العميل"
                            .lblPrice.Text = "قيمة الفاتورة الأصلية"
                            .lblPriceNew.Text = "قيمة الفاتورة بعد المرتجع"
                            .lblCash.Text = "المدفوع كاش"
                            .lblBank.Text = "المدفوع بنكي"
                            .lblDate.Text = "تاريخ الفاتروة"
                            .lblCashier.Text = "الكاشير"
                            .grid.Columns("colCID").HeaderText = "الرقم المدني"
                            .grid.Columns("colKarat").HeaderText = "العيار"
                            .grid.Columns("colWeight").HeaderText = "الوزن"
                            .grid.Columns("colGramPrice").HeaderText = "سعر الجرام"
                            .grid.Columns("colPrice").HeaderText = "إجمالي السعر"
                            .grid.Columns("colInvoiceNo").HeaderText = "رقم الفاتورة"
                            .grid.Columns("colItemDescription").HeaderText = "الوصف"
                            .grid.Columns("Delete").HeaderText = "حذف"
                            .Text = "تعديل/حذف مشتريات ذهب/فضة"
                        End With
                    End If
                Case "DELETEEDITGOLD"
                    If frmLogin.rbtnEn.Checked = True Then
                        With DeletEeditGold
                            .Text = "Delete & Edit Purchases Invoice"
                            .lblNote.Text = "Note"
                            .LinkLabel1.Text = "Price calculation"
                            .lblNetCaret.Text = "Pure karet"
                            .LblAddToItem.Text = "Add To Item"
                            .lblNetWeight.Text = "Pure Weight"
                            .lblQunt.Text = "Quantity"
                            .lblDate.Text = "Date"
                            .lblCashier.Text = "Cashier"
                            .LabItem_Des.Text = "Item Description"
                            .Label2.Text = "Karet"
                            .lblInvoiceNo.Text = "Invoice No."
                            .btnView.Text = "View Invoice"
                            .btnDeleteInvoice.Text = "Delete"
                            .btnSave.Text = "Save "
                            .btnPayPrint.Text = "Print"
                            .Bay_gram_priceLabel.Text = "Calculation Karet Price"
                            .lblInvoicePrice.Text = "Total Price"
                            .lblCash.Text = "Cash"
                            .lblBank.Text = "Bank"
                            .lblPayMethod.Text = "Pay Method"
                            .grid.Columns("colItemName").HeaderText = "Item Description"
                            .grid.Columns("colGramPrice").HeaderText = "Karet Price"
                            .grid.Columns("colGoldWeight").HeaderText = "Gold Weight"
                            .grid.Columns("colGoledKarat").HeaderText = "Gold Karet"
                            .grid.Columns("colGoldNetWeight").HeaderText = "Gold Pure Weight"
                            .grid.Columns("colGoledNetKarat").HeaderText = "Gold Pure Karet"
                            .grid.Columns("colGoledPrice").HeaderText = "Total Goled Price"
                            .grid.Columns("colGoledPiecesQuantity").HeaderText = "Item Quantity"
                            .grid.Columns("colModify").HeaderText = "Edit"
                            .grid.Columns("colDelete").HeaderText = "Delete"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then
                        With DeletEeditGold
                            .Text = "حذف & تعديل المشتريات"
                            .lblNote.Text = "ملاحظات"
                            .LinkLabel1.Text = "حساب السعر"
                            .lblNetCaret.Text = "العيار الصافي"
                            .LblAddToItem.Text = "اضف الي الاصناف"
                            .lblNetWeight.Text = "الوزن الصافي"
                            .lblQunt.Text = "العدد"
                            .lblDate.Text = "التاريخ"
                            .lblCashier.Text = "كاشير"
                            .LabItem_Des.Text = "وصف الصنف"
                            .Label2.Text = "العيار"
                            .lblInvoiceNo.Text = "رقم الفاتوره"
                            .btnView.Text = "عرض الفاتوره"
                            .btnDeleteInvoice.Text = "حذف"
                            .btnSave.Text = "حفظ "
                            .btnPayPrint.Text = "طباعه"
                            .Bay_gram_priceLabel.Text = "حساب سعر الجرام"
                            .lblInvoicePrice.Text = "مبلغ الفاتورة"
                            .lblCash.Text = "كاش"
                            .lblBank.Text = "بنكي"
                            .lblPayMethod.Text = "الطريقه"
                            .grid.Columns("colItemName").HeaderText = "وصف الصنف"
                            .grid.Columns("colGramPrice").HeaderText = "سعر الجرام"
                            .grid.Columns("colGoldWeight").HeaderText = "وزن الذهب"
                            .grid.Columns("colGoledKarat").HeaderText = "العيار"
                            .grid.Columns("colGoldNetWeight").HeaderText = "الوزن الصافي"
                            .grid.Columns("colGoledNetKarat").HeaderText = "العيار الصافي"
                            .grid.Columns("colGoledPrice").HeaderText = "اجمالي السعر"
                            .grid.Columns("colGoledPiecesQuantity").HeaderText = "العدد"
                            .grid.Columns("colModify").HeaderText = "تعديل"
                            .grid.Columns("colDelete").HeaderText = "حذف"
                        End With
                    End If
                Case "CASHIER"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With Cashier
                            .RightToLeft = 0
                            .btnNew.Text = "New"
                            .btnSave.Text = "Save"
                            .lblCashierName.Text = "Cashier Name"
                            .lblAddress.Text = "Address"
                            .lblCID.Text = "CID No."
                            .lnkSignature.Text = "Signature From Imge"
                            .lnkSignature2.Text = "Signature From Pad"
                            .colcacher_name.HeaderText = "Cashier Name"
                            .btnDel.Text = "Delet"
                            .coladr.HeaderText = "Address"
                            .colsvil_id.HeaderText = "CID No."
                            .Text = "Add/Edit Cashier"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With Cashier
                            .RightToLeft = 0
                            .btnNew.Text = "جديد"
                            .btnSave.Text = "حفظ"
                            .lblCashierName.Text = "اسم الكاشير"
                            .lblAddress.Text = "العنوان"
                            .lblCID.Text = "الرقم المدني"
                            .lnkSignature.Text = "التوقيع من صوره"
                            .lnkSignature2.Text = "التوقيع من جهاز التوقيع"
                            .colcacher_name.HeaderText = "اسم الكاشير"
                            .coladr.HeaderText = "العنوان"
                            .colsvil_id.HeaderText = "الرقم المدني"
                            .btnDel.Text = "حذف"
                            .Text = "إضافة/تعديل كاشير"
                        End With
                    End If
                Case "FRMUSERS"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With frmUsers
                            .RightToLeft = 0
                            .btnNew.Text = "New"
                            .btnSave.Text = "Save"
                            .btnDelete.Text = "Delete"
                            .lblUserName.Text = "User Name"
                            .lblPassword.Text = "Password"
                            .gbPrivilage.Text = "User Privilages"
                            .btnAllPrivilage.Text = "select & Unselect Al"
                            .chkUsers.Text = "Users"
                            .chkCashier.Text = "Cashiers"
                            .chkWholesale.Text = "WholeSale"
                            .chkReports.Text = "Reports"
                            .chkExpenses.Text = "Expenses"
                            .chkStock.Text = "Stock"
                            .chkSell.Text = "Sell"
                            .chkBarCode.Text = "BarCode"
                            .chkModify.Text = "Modify"
                            .chkGramPrice.Text = "Gram Price"
                            .chkSalary.Text = "Salary"
                            .chkWholeSaleBuy.Text = "WholeSale Buy"
                            .Text = "Add/Edit Users"
                            .chkInvPayInstallment.Text = "Pay Installment"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With frmUsers
                            .RightToLeft = 0
                            .btnNew.Text = "جديد"
                            .btnSave.Text = "حفظ"
                            .btnDelete.Text = "حذف"
                            .lblUserName.Text = "اسم المستخدم"
                            .lblPassword.Text = "كلمة المرور"
                            .gbPrivilage.Text = "صلاحيات المستخدم"
                            .btnAllPrivilage.Text = "تحديد & الغاء تحديد الكل"
                            .chkUsers.Text = "المستخدمين"
                            .chkCashier.Text = "الكاشيرات"
                            .chkWholesale.Text = "مبيعات الجملة"
                            .chkReports.Text = "تقارير"
                            .chkExpenses.Text = "مصروفات"
                            .chkStock.Text = "مخزون"
                            .chkSell.Text = "بيع"
                            .chkBarCode.Text = "باركود"
                            .chkModify.Text = "تعديل"
                            .chkGramPrice.Text = "سعر الجرام"
                            .chkSalary.Text = "رواتب"
                            .chkWholeSaleBuy.Text = "مشاريات جملة"
                            .Text = "إضافة/تعديل المستخدمين"
                            .chkInvPayInstallment.Text = "الدفع الأجل"
                        End With
                    End If
                Case "ACCESSORIES_ADDITEMS"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With Accessories_AddItems
                            .Chk.Text = "Sort by smallest barcode value"
                            .Text = "Accessories/Add Items"
                            .btnItemNew.Text = "Add New"
                            .btnItemEdit.Text = "Edit"
                            .btnBarCode.Text = "BarCode Print"
                            .btnItemSave.Text = "Save"
                            .Accessories_NAMELabel.Text = "Item Name"
                            .Accessories_BRANDLabel.Text = "Item Brand"
                            .lblModelNo.Text = "Model No"
                            .lblItemNo.Text = "Item No"
                            .lblCode.Text = "Code"
                            .Accessories_CATLabel.Text = "Category"
                            .Accessories_DEPLabel.Text = "Department"
                            .lblModelYear.Text = "Model Year"
                            .lblCost.Text = "Cost"
                            .lblPrice.Text = "Tag Price"
                            .Accessories_DESCLabel.Text = "Description"
                            .btnItemPhoto.Text = "Add Item Photo"
                            .colAccessoriesID.HeaderText = "BarCode"
                            .colAccessories_NAME.HeaderText = "Item Name"
                            .colAccessories_BRAND.HeaderText = "Brand"
                            .colAccessories_DESC.HeaderText = "Description"
                            .colAccessories_CAT.HeaderText = "Category"
                            .colAccessories_DEP.HeaderText = "Department"
                            .colAccessories_model_no.HeaderText = "Model No"
                            .colAccessories_nom.HeaderText = "Item No"
                            .colAccessories_Cost.HeaderText = "Cost"
                            .colAccessories_Price.HeaderText = "Price"
                            .colDelete.HeaderText = "Del"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With Accessories_AddItems
                            .Chk.Text = "ترتيب حسب اصغر قيمة باركود"
                            .Text = "إضافة أصناف/ساعات"
                            .btnItemNew.Text = "إضافة جديد"
                            .btnItemEdit.Text = "تعديل سابق"
                            .btnBarCode.Text = "طباعة باركود"
                            .btnItemSave.Text = "حفظ"
                            .Accessories_NAMELabel.Text = "اسم الصنف"
                            .Accessories_BRANDLabel.Text = "الماركة"
                            .lblModelNo.Text = "رقم الموديل"
                            .lblItemNo.Text = "رقم القطعة"
                            .lblCode.Text = "الرمز"
                            .Accessories_CATLabel.Text = "الفئة"
                            .Accessories_DEPLabel.Text = "القسم"
                            .lblModelYear.Text = "سنة الموديل"
                            .lblCost.Text = "تكلفة الشراء"
                            .lblPrice.Text = "سعر البيع"
                            .Accessories_DESCLabel.Text = "الوصف"
                            .btnItemPhoto.Text = "إضافة صورة"
                            .colAccessoriesID.HeaderText = "الباركود"
                            .colAccessories_NAME.HeaderText = "اسم الصنف"
                            .colAccessories_BRAND.HeaderText = "الماركة"
                            .colAccessories_DESC.HeaderText = "الوصف"
                            .colAccessories_CAT.HeaderText = "الفئة"
                            .colAccessories_DEP.HeaderText = "القسم"
                            .colAccessories_model_no.HeaderText = "رقم الموديل"
                            .colAccessories_nom.HeaderText = "رقم القطعة"
                            .colAccessories_Cost.HeaderText = "تكلفة الشراء"
                            .colAccessories_Price.HeaderText = "سعر البيع"
                            .colDelete.HeaderText = "حذف"
                        End With
                    End If

                Case "ACCESSORIES_INVOICE"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With Accessories_Invoice
                            .lblPrice.Text = "Price"
                            .lblAttachment.Text = "lblAttachment"
                            .lblCost.Text = "Cost"
                            .lblModelYear.Text = "G-Year"
                            .lblDepartment.Text = "Department"
                            .lblCategory.Text = "Condition"
                            .lblSupplier.Text = "Supplier"
                            .lblCode.Text = "Serial Number."
                            .lblBraned.Text = "Brand"
                            .Text = "Accessories Sell Invoice"
                            .gbInvoice.Text = "Invoice Data"
                            .lblCashier.Text = "Cashier"
                            .lblBarCode.Text = "BarCode"
                            .lblItem.Text = "Item Name"
                            .lblModelNo.Text = "Model No"
                            .lblItemNo.Text = "Item No"
                            .lblQty.Text = "Quantity"
                            .lblTotalPrice.Text = "Price"
                            .lblNote.Text = "Description"
                            .btnSave.Text = "Save"
                            .btnPayPrint.Text = "Pay/Print Invoice"
                            .lblTotalPrice.Text = "Invoice Total"
                            .colCivilID.HeaderText = "CivilID"
                            .colBarcod.HeaderText = "Barcod"
                            .colItemName.HeaderText = "Item Name"
                            .colBrand.HeaderText = "Brand"
                            .colModelNo.HeaderText = "Model No."
                            .colItemNo.HeaderText = "Item No."
                            .colItemCode.HeaderText = "Item Code"
                            .colSupplier.HeaderText = "Supplier"
                            .colDescription.HeaderText = "Description"
                            .colCashier.HeaderText = "Cashier"
                            .colCategory.HeaderText = "Category"
                            .colDepartment.HeaderText = "Department"
                            .colYear.HeaderText = "Year"
                            .colCost.HeaderText = "Cost"
                            .colQty.HeaderText = "Qty"
                            .colAttachment.HeaderText = "Attachment"
                            .colPrice.HeaderText = "Price"
                            .colUser.HeaderText = "User"
                            .colDateTime.HeaderText = "DateTime"
                            .colDate.HeaderText = "Date"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With Accessories_Invoice
                            .lblPrice.Text = "السعر"
                            .lblAttachment.Text = "المرفقات"
                            .lblCost.Text = "التكلفه"
                            .lblModelYear.Text = "سنةالضمان"
                            .lblDepartment.Text = "القسم"
                            .lblCategory.Text = "الحاله"
                            .lblSupplier.Text = "المورد"
                            .lblCode.Text = "رقم السريال"
                            .lblBraned.Text = "الماركه"
                            .Text = "بيع ساعات/اكسسوارات"
                            .gbInvoice.Text = "بيانات الفاتورة"
                            .lblCashier.Text = "كاشير"
                            .lblBarCode.Text = "باركود"
                            .lblItem.Text = "اسم الصنف"
                            .lblModelNo.Text = "رقم الموديل"
                            .lblItemNo.Text = "رقم القطعة"
                            .lblQty.Text = "العدد"
                            .lblTotalPrice.Text = "سعر الوحدة"
                            .lblNote.Text = "وصف الصنف/الملاحظات"
                            .btnSave.Text = "حفظ"
                            .btnPayPrint.Text = "دفع/طباعة الفاتورة"
                            .lblTotalPrice.Text = "إجمالي الفاتورة"
                            .colCivilID.HeaderText = "الرقم المدني"
                            .colBarcod.HeaderText = "الباركود"
                            .colItemName.HeaderText = "اسم الصنف"
                            .colBrand.HeaderText = "الماركه"
                            .colModelNo.HeaderText = "رقم الموديل"
                            .colItemNo.HeaderText = "رقم الصنف"
                            .colItemCode.HeaderText = "كود الصنف"
                            .colSupplier.HeaderText = "المورد"
                            .colDescription.HeaderText = "الوصف"
                            .colCashier.HeaderText = "الكاشير"
                            .colCategory.HeaderText = "الفئه"
                            .colDepartment.HeaderText = "القسم"
                            .colYear.HeaderText = "سنة الضمان"
                            .colCost.HeaderText = "التكلفه"
                            .colQty.HeaderText = "العدد"
                            .colAttachment.HeaderText = "المرفقات"
                            .colPrice.HeaderText = "السعر"
                            .colUser.HeaderText = "اسم المستخدم"
                            .colDateTime.HeaderText = "الوقت"
                            .colDate.HeaderText = "التاريخ"
                        End With
                    End If
                Case "ACCESSORIES_INVOICEPAY"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With Accessories_InvoicePay
                            .Text = "Payment"
                            .btnSave.Text = "Save"
                            .btnPrint.Text = "Print"
                            .lblInvoiceNo.Text = "Invoice Number"
                            .lblPrice.Text = "Total Bill"
                            .lblRemaining.Text = "Remaining Amount"
                            .lblKNET.Text = "Bank"
                            .lblCash.Text = "Cash"
                            .gbInvoiceDetails.Text = "Invoice Details"
                            .gbPayDetails.Text = "Payment Statement"
                            .rbCash.Text = "Cash"
                            .rbCredit.Text = "Credit"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With Accessories_InvoicePay
                            .Text = "بيانات الدفع"
                            .btnSave.Text = "حفظ"
                            .btnPrint.Text = "طباعة"
                            .lblInvoiceNo.Text = "رقم الفاتورة"
                            .lblPrice.Text = "إجمالي الفاتورة"
                            .lblRemaining.Text = "باقي المبلغ"
                            .lblKNET.Text = "بنكي"
                            .lblCash.Text = "نقدي"
                            .gbInvoiceDetails.Text = "بيان الفاتورة"
                            .gbPayDetails.Text = "بيانات الدفع"
                            .rbCash.Text = "نقدي"
                            .rbCredit.Text = "آجل"
                        End With
                    End If
                Case "FRMSNDGOLD"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With FrmSndGold
                            .colModify.Text = "Edit"
                            .colCob_Comp_nam.HeaderText = "Company / Supplier Name"
                            .colcmbKarat.HeaderText = "Karat"
                            .coltxtWeight.HeaderText = "Weight"
                            .colComBxGoCaret999.HeaderText = "Net Karat"
                            .colTXTGoCaret999.HeaderText = "Net Weight"
                            .coltxtQuntt.HeaderText = "Quantity"
                            .coldtExpensesDate.HeaderText = "Date"
                            .coltxtGramPrice.HeaderText = "Gram Price"
                            .coltxtGoldPrice.HeaderText = "Gold Price"
                            .coltxtMakeCharge.HeaderText = "Making Charge"
                            .coltxtTMakeCharge.HeaderText = "Total Making Charge"
                            .coltxtTotalPrice.HeaderText = "Total Price"
                            .lblEdit.Text = "Edit"
                            .LabSndName.Text = "Voucher Type"
                            .LabComName.Text = "Company / Supplier Name"
                            .LabCasher.Text = "Cashier"
                            .BtnAdd.Text = "Add Item"
                            .BtnSave.Text = "Save & Print"
                            .LblKart.Text = "Karat"
                            .lblNetCaret.Text = "Net Karat"
                            .lblQuntt.Text = "Quantity"
                            .LabDate.Text = "Date"
                            .LabDescription.Text = "Description"
                            .lblGramPrice.Text = "Gram Price"
                            .lblGoldPrice.Text = "Gold Price"
                            .lblMakeCharge.Text = "Making Charge"
                            .lblTMakeCharge.Text = "Total Making Charge"
                            .lblTotalPrice.Text = "Total Price"
                            .ChkAutocalculation.Text = "Auto Calculation"
                            .Bay_mazanLabel.Text = "Weight"
                            .lblNetWeight.Text = "Net Weight"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With FrmSndGold
                            .colModify.Text = "تعديل"
                            .colCob_Comp_nam.HeaderText = "اسم الشركه/المورد"
                            .colcmbKarat.HeaderText = "العيار القائم"
                            .coltxtWeight.HeaderText = "الوزن القائم"
                            .colComBxGoCaret999.HeaderText = "عيار الرمله"
                            .colTXTGoCaret999.HeaderText = "وزن الرمله"
                            .coltxtQuntt.HeaderText = "العدد"
                            .coldtExpensesDate.HeaderText = "التاريخ"
                            .coltxtGramPrice.HeaderText = "سعر الجرام"
                            .coltxtGoldPrice.HeaderText = "سعر الذهب"
                            .coltxtMakeCharge.HeaderText = "المصنعيه"
                            .coltxtTMakeCharge.HeaderText = "اجمالي المصنعيه"
                            .coltxtTotalPrice.HeaderText = "اجمالي السعر"
                            .lblEdit.Text = "تعديل"
                            .LabSndName.Text = "نوع السند"
                            .LabComName.Text = "اسم الشركه/المورد"
                            .LabCasher.Text = "الكاشير"
                            .BtnAdd.Text = "اضافة صنف"
                            .BtnSave.Text = "حفظ وطباعه"
                            .LblKart.Text = "العيار"
                            .lblNetCaret.Text = "العيار الصافي"
                            .lblQuntt.Text = "العدد"
                            .LabDate.Text = "التاريخ"
                            .LabDescription.Text = "الــوصـــف"
                            .lblGramPrice.Text = "سعر الجرام"
                            .lblGoldPrice.Text = "سعر الذهب"
                            .lblMakeCharge.Text = "المصنعيه"
                            .lblTMakeCharge.Text = "اجمالي المصنعيه"
                            .lblTotalPrice.Text = "اجمالي السعر"
                            .ChkAutocalculation.Text = "حساب تلقائي"
                            .Bay_mazanLabel.Text = "الوزن"
                            .lblNetWeight.Text = "وزن الرمله"

                        End With
                    End If
                Case "ACCESSORIESBUY"
                    If frmLogin.rbtnEn.Checked = True Then 'إنجليزي
                        With AccessoriesBuy
                            .Text = "AccessoriesBuy"
                            .btnSave.Text = "Save"
                            .lblItemName.Text = "Item Name"
                            .lblBrand.Text = "Item Brand"
                            .lblModel.Text = "Model No"
                            .lblSerialNo.Text = "Item No"
                            .lblItemStatus.Text = "Item Condition"
                            .LABILYearOfWarr.Text = "G-Year"
                            .lblDetails.Text = "Notes"
                            .LAIBELAttachments.Text = "Attachments"
                            .lblReceiveDate.Text = "Receive Date"
                            .lblGuaranteeStatus.Text = "Category"
                            .lblGuaranteeDate.Text = "Department"
                            .lblReceiver.Text = "Receiver"
                            .lblPrice.Text = "Price"
                            .LibltemNO.Text = "Item No"
                        End With
                    ElseIf frmLogin.rbtnAr.Checked = True Then ' عربي
                        With AccessoriesBuy
                            .Text = "شراء ساعات / ماركات"
                            .btnSave.Text = "حفظ"
                            .lblItemName.Text = "النوع"
                            .lblBrand.Text = "الماركه"
                            .lblModel.Text = "رقم الموديل"
                            .lblSerialNo.Text = "السريال"
                            .lblItemStatus.Text = "حالة السلعه"
                            .LABILYearOfWarr.Text = "سنة الضمان"
                            .lblDetails.Text = "الملاحظات"
                            .LAIBELAttachments.Text = "المرفقات"
                            .lblReceiveDate.Text = "تاريخ الشراء"
                            .lblGuaranteeStatus.Text = "الفئه"
                            .lblGuaranteeDate.Text = "القسم"
                            .lblReceiver.Text = "المستلم"
                            .lblPrice.Text = "السعر"
                            .LibltemNO.Text = "رقم القطعه"
                        End With

                    End If
            End Select
    End Sub
End Module