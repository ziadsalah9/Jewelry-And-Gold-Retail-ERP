<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoldBarCode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GoldBarCode))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cmbRightItem = New System.Windows.Forms.ComboBox()
        Me.Print_Parcood1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.Print_Parcood1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Print_Parcood1TableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Print_Parcood1TableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.Print_Parcood2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Print_Parcood2TableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.Print_Parcood2TableAdapter()
        Me.Print_Parcood2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbLeftItem = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Gram_valuTextBox1 = New System.Windows.Forms.TextBox()
        Me.FO_totalPriceTextBox1 = New System.Windows.Forms.TextBox()
        Me.FO_GramPriceTextBox1 = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.FO_priceTextBox1 = New System.Windows.Forms.TextBox()
        Me.FO_extrasTextBox1 = New System.Windows.Forms.TextBox()
        Me.FO_madeTextBox1 = New System.Windows.Forms.TextBox()
        Me.FO_gramMadeTextBox1 = New System.Windows.Forms.TextBox()
        Me.FO_gramTextBox1 = New System.Windows.Forms.TextBox()
        Me.FO_despTextBox1 = New System.Windows.Forms.TextBox()
        Me.FO_nameTextBox1 = New System.Windows.Forms.TextBox()
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Gram_valuTextBox = New System.Windows.Forms.TextBox()
        Me.FO_totalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.FO_GramPriceTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.FO_priceTextBox = New System.Windows.Forms.TextBox()
        Me.FO_extrasTextBox = New System.Windows.Forms.TextBox()
        Me.FO_madeTextBox = New System.Windows.Forms.TextBox()
        Me.FO_gramMadeTextBox = New System.Windows.Forms.TextBox()
        Me.FO_gramTextBox = New System.Windows.Forms.TextBox()
        Me.FO_despTextBox = New System.Windows.Forms.TextBox()
        Me.FO_nameTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.cmbCompany = New System.Windows.Forms.ComboBox()
        Me.CompinformBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompdetelsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Comp_detelsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.comp_detelsTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBarCodeRight = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBarCodeLeft = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.cmbPrinter = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.gbRight = New System.Windows.Forms.GroupBox()
        Me.gbRightText = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.L_Stone3Text_UTextBox = New System.Windows.Forms.TextBox()
        Me.CONFI_barcoodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_Stone3Text_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.L_Stone2Text_UTextBox = New System.Windows.Forms.TextBox()
        Me.L_Stone2Text_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.L_CodeText_UTextBox = New System.Windows.Forms.TextBox()
        Me.L_CodeText_DTextBox = New System.Windows.Forms.TextBox()
        Me.L_FO_CountryTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.L_FO_CountryTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.pbHRightText = New System.Windows.Forms.PictureBox()
        Me.L_IDTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.L_IDTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.pbVRightText = New System.Windows.Forms.PictureBox()
        Me.L_FO_madeTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.L_FO_madeTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.L_font_IDTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.L_font_IDTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.L_ComboBox3_UTextBox = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.L_ComboBox3_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.L_W_UTextBox = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.L_W_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.L_M_UTextBox = New System.Windows.Forms.TextBox()
        Me.L_S_DTextBox = New System.Windows.Forms.TextBox()
        Me.L_M_DTextBox = New System.Windows.Forms.TextBox()
        Me.L_S_UTextBox = New System.Windows.Forms.TextBox()
        Me.L_C_UTextBox = New System.Windows.Forms.TextBox()
        Me.L_C_DTextBox = New System.Windows.Forms.TextBox()
        Me.gbRightValue = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.L_Stone3Value_UTextBox = New System.Windows.Forms.TextBox()
        Me.L_Stone3Value_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.L_Stone2Value_UTextBox = New System.Windows.Forms.TextBox()
        Me.L_Stone2Value_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.L_CodeValue_UTextBox = New System.Windows.Forms.TextBox()
        Me.L_CodeValue_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.L_FO_gramTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.pbHRightValue = New System.Windows.Forms.PictureBox()
        Me.L_FO_gramTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.L_FO_gramMadeTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.L_FO_gramMadeTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.pbVRightValue = New System.Windows.Forms.PictureBox()
        Me.L_Gram_valuTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.L_Gram_valuTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.L_FO_extrasTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.L_FO_extrasTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.CONFI_barcoodTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.CONFI_barcoodTableAdapter()
        Me.CONFI_barcoodDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.print_set = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn75 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn76 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn77 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn78 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn79 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn80 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn81 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.print = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSAP_U = New System.Windows.Forms.TextBox()
        Me.txtSAP_D = New System.Windows.Forms.TextBox()
        Me.txtGOLDENSAP_U = New System.Windows.Forms.TextBox()
        Me.txtGOLDENSAP_D = New System.Windows.Forms.TextBox()
        Me.Tel_uTextBox = New System.Windows.Forms.TextBox()
        Me.Tel_dTextBox = New System.Windows.Forms.TextBox()
        Me.Print_setTextBox = New System.Windows.Forms.TextBox()
        Me.gbLeft = New System.Windows.Forms.GroupBox()
        Me.gbLeftText = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.R_Stone3Text_UTextBox = New System.Windows.Forms.TextBox()
        Me.R_Stone3Text_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.R_Stone2Text_UTextBox = New System.Windows.Forms.TextBox()
        Me.R_Stone2Text_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.R_CodeText_UTextBox = New System.Windows.Forms.TextBox()
        Me.R_CodeText_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.R_FO_CountryTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.R_FO_CountryTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.R_M_DTextBox = New System.Windows.Forms.TextBox()
        Me.pbHLeftText = New System.Windows.Forms.PictureBox()
        Me.R_M_UTextBox = New System.Windows.Forms.TextBox()
        Me.pbVLeftText = New System.Windows.Forms.PictureBox()
        Me.R_W_DTextBox = New System.Windows.Forms.TextBox()
        Me.R_W_UTextBox = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.R_S_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.R_S_UTextBox = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.R_C_UTextBox = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.R_ComboBox3_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.R_C_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.R_ComboBox3_UTextBox = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.R_font_IDTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.R_font_IDTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.R_FO_madeTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.R_FO_madeTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.R_IDTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.R_IDTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.gbLeftValue = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.R_Stone3Value_UTextBox = New System.Windows.Forms.TextBox()
        Me.R_Stone3Value_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.R_Stone2Value_UTextBox = New System.Windows.Forms.TextBox()
        Me.R_Stone2Value_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.R_CodeValue_UTextBox = New System.Windows.Forms.TextBox()
        Me.R_CodeValue_DTextBox = New System.Windows.Forms.TextBox()
        Me.R_FO_gramTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.R_FO_gramMadeTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.pbHLeftValue = New System.Windows.Forms.PictureBox()
        Me.R_FO_gramMadeTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.R_Gram_valuTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.pbVLeftValue = New System.Windows.Forms.PictureBox()
        Me.R_Gram_valuTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.R_FO_gramTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.R_FO_extrasTextBox_UTextBox = New System.Windows.Forms.TextBox()
        Me.R_FO_extrasTextBox_DTextBox = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Comp_informTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.comp_informTableAdapter()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.StoneWeight3TextBox1 = New System.Windows.Forms.TextBox()
        Me.StoneName3TextBox1 = New System.Windows.Forms.TextBox()
        Me.StoneWeight2TextBox1 = New System.Windows.Forms.TextBox()
        Me.StoneName2TextBox1 = New System.Windows.Forms.TextBox()
        Me.StoneWeight3TextBox = New System.Windows.Forms.TextBox()
        Me.StoneName3TextBox = New System.Windows.Forms.TextBox()
        Me.StoneWeight2TextBox = New System.Windows.Forms.TextBox()
        Me.StoneName2TextBox = New System.Windows.Forms.TextBox()
        Me.BarCodeTextBox1 = New System.Windows.Forms.TextBox()
        Me.BarCodeTextBox = New System.Windows.Forms.TextBox()
        Me.FO_ItemNoTextBox1 = New System.Windows.Forms.TextBox()
        Me.FO_ItemNoTextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR17TextBox = New System.Windows.Forms.TextBox()
        Me.SettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SET_INVARCHR16TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR15TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR14TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR13TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR12TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR11TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR1TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR128TextBox = New System.Windows.Forms.TextBox()
        Me.SettingsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter()
        Me.chkPrintRange = New System.Windows.Forms.CheckBox()
        Me.cmbPrintRange = New System.Windows.Forms.ComboBox()
        Me.lblPrintRangeEnd = New System.Windows.Forms.Label()
        Me.gbFont = New System.Windows.Forms.GroupBox()
        Me.gbFontValue = New System.Windows.Forms.GroupBox()
        Me.btnDefaults = New System.Windows.Forms.Button()
        Me.CompanyTextFontStyleTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyTextFontValueTextBox = New System.Windows.Forms.TextBox()
        Me.DataTextFontStyleTextBox = New System.Windows.Forms.TextBox()
        Me.DataTextFontValueTextBox = New System.Windows.Forms.TextBox()
        Me.CountryFontStyleTextBox = New System.Windows.Forms.TextBox()
        Me.CountryFontValueTextBox = New System.Windows.Forms.TextBox()
        Me.BarCodeFontStyleTextBox = New System.Windows.Forms.TextBox()
        Me.BarCodeFontValueTextBox = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.gbPrintRange = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Print_Parcood1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Print_Parcood1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Print_Parcood2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Print_Parcood2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompinformBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompdetelsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbRight.SuspendLayout()
        Me.gbRightText.SuspendLayout()
        CType(Me.CONFI_barcoodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHRightText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVRightText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRightValue.SuspendLayout()
        CType(Me.pbHRightValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVRightValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONFI_barcoodDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLeft.SuspendLayout()
        Me.gbLeftText.SuspendLayout()
        CType(Me.pbHLeftText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVLeftText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLeftValue.SuspendLayout()
        CType(Me.pbHLeftValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVLeftValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFont.SuspendLayout()
        Me.gbFontValue.SuspendLayout()
        Me.gbPrintRange.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ReportViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ReportViewer1.DocumentMapWidth = 28
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DT_restrant.rptBarCode.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-111, 22)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowContextMenu = False
        Me.ReportViewer1.ShowCredentialPrompts = False
        Me.ReportViewer1.ShowDocumentMapButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowPageNavigationControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowProgress = False
        Me.ReportViewer1.ShowPromptAreaButton = False
        Me.ReportViewer1.ShowRefreshButton = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(20, 23)
        Me.ReportViewer1.TabIndex = 27
        '
        'cmbRightItem
        '
        Me.cmbRightItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbRightItem.DataSource = Me.Print_Parcood1BindingSource
        Me.cmbRightItem.DisplayMember = "FO_name"
        Me.cmbRightItem.FormattingEnabled = True
        Me.cmbRightItem.Location = New System.Drawing.Point(32, 16)
        Me.cmbRightItem.Name = "cmbRightItem"
        Me.cmbRightItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbRightItem.Size = New System.Drawing.Size(146, 23)
        Me.cmbRightItem.TabIndex = 0
        Me.cmbRightItem.ValueMember = "BarCode"
        '
        'Print_Parcood1BindingSource
        '
        Me.Print_Parcood1BindingSource.DataMember = "Print_Parcood1"
        Me.Print_Parcood1BindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Print_Parcood1DataGridView
        '
        Me.Print_Parcood1DataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Print_Parcood1DataGridView.AutoGenerateColumns = False
        Me.Print_Parcood1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Print_Parcood1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.Print_Parcood1DataGridView.DataSource = Me.Print_Parcood1BindingSource
        Me.Print_Parcood1DataGridView.Location = New System.Drawing.Point(-88, 174)
        Me.Print_Parcood1DataGridView.Name = "Print_Parcood1DataGridView"
        Me.Print_Parcood1DataGridView.Size = New System.Drawing.Size(20, 24)
        Me.Print_Parcood1DataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FO_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FO_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FO_desp"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FO_desp"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FO_gram"
        Me.DataGridViewTextBoxColumn4.HeaderText = "FO_gram"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FO_gramMade"
        Me.DataGridViewTextBoxColumn5.HeaderText = "FO_gramMade"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FO_made"
        Me.DataGridViewTextBoxColumn6.HeaderText = "FO_made"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FO_extras"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FO_extras"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FO_price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FO_price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "userID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "userID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FO_GramPrice"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FO_GramPrice"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "FO_totalPrice"
        Me.DataGridViewTextBoxColumn11.HeaderText = "FO_totalPrice"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Gram_valu"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Gram_valu"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Print_Parcood1TableAdapter
        '
        Me.Print_Parcood1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Accessories_BarcodeConfigTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_BAYTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_Buy_PayTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_BuyTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_CATTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_DEPTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_INVTableAdapter = Nothing
        Me.TableAdapterManager.Accessories_ITEMTableAdapter = Nothing
        Me.TableAdapterManager.ADS_SERVICESTableAdapter = Nothing
        Me.TableAdapterManager.Auction_AddItemDetailsTableAdapter = Nothing
        Me.TableAdapterManager.Auction_BarcodeConfigTableAdapter = Nothing
        Me.TableAdapterManager.Auction_BrandTableAdapter = Nothing
        Me.TableAdapterManager.Auction_GuaranteeStatusTableAdapter = Nothing
        Me.TableAdapterManager.Auction_ItemStatusTableAdapter = Nothing
        Me.TableAdapterManager.Auction_ItemTypeTableAdapter = Nothing
        Me.TableAdapterManager.AuctionInvoiceDetailsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Bay_Diamond_idTableAdapter = Nothing
        Me.TableAdapterManager.Bay_Diamond_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAY_from_comp_bayTableAdapter = Nothing
        Me.TableAdapterManager.bay_goled_monyTableAdapter = Nothing
        Me.TableAdapterManager.bay_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAYTableAdapter = Nothing
        Me.TableAdapterManager.BAYWholesaleTableAdapter = Nothing
        Me.TableAdapterManager.Buy_DiamondTableAdapter = Nothing
        Me.TableAdapterManager.Buy_GoldTableAdapter = Nothing
        Me.TableAdapterManager.cacherTableAdapter = Nothing
        Me.TableAdapterManager.CANTRYTableAdapter = Nothing
        Me.TableAdapterManager.CastomerDETELSTableAdapter = Nothing
        Me.TableAdapterManager.COMP_BAYTableAdapter = Nothing
        Me.TableAdapterManager.COMP_detels_for_bayTableAdapter = Nothing
        Me.TableAdapterManager.comp_detelsTableAdapter = Nothing
        Me.TableAdapterManager.comp_informTableAdapter = Nothing
        Me.TableAdapterManager.COMP_INVOCE_CACHETableAdapter = Nothing
        Me.TableAdapterManager.COMPANY_BAY_DETELSTableAdapter = Nothing
        Me.TableAdapterManager.CONFI_barcood_dimonTableAdapter = Nothing
        Me.TableAdapterManager.CONFI_barcoodTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CurrencyTypeTableAdapter = Nothing
        Me.TableAdapterManager.dimon_bayTableAdapter = Nothing
        Me.TableAdapterManager.dimon_catTableAdapter = Nothing
        Me.TableAdapterManager.DIMON_detelsTableAdapter = Nothing
        Me.TableAdapterManager.dimon_invceTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTypeTableAdapter = Nothing
        Me.TableAdapterManager.EXTR_NAMETableAdapter = Nothing
        Me.TableAdapterManager.FO_minTableAdapter = Nothing
        Me.TableAdapterManager.Gram_valTableAdapter = Nothing
        Me.TableAdapterManager.ID_orderTableAdapter = Nothing
        Me.TableAdapterManager.inv_startTableAdapter = Nothing
        Me.TableAdapterManager.Item_NameTableAdapter = Nothing
        Me.TableAdapterManager.LICENSE_TTableAdapter = Nothing
        Me.TableAdapterManager.licensTableAdapter = Nothing
        Me.TableAdapterManager.loc_nameTableAdapter = Nothing
        Me.TableAdapterManager.ORDERTableAdapter = Nothing
        Me.TableAdapterManager.PayInstallmentTableAdapter = Nothing
        Me.TableAdapterManager.PayMethodTableAdapter = Nothing
        Me.TableAdapterManager.ReportPathTableAdapter = Nothing
        Me.TableAdapterManager.resev_goldTableAdapter = Nothing
        Me.TableAdapterManager.resev_monyTableAdapter = Nothing
        Me.TableAdapterManager.selInvoceDetelsTableAdapter = Nothing
        Me.TableAdapterManager.send_monyTableAdapter = Nothing
        Me.TableAdapterManager.sent_goldTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Nothing
        Me.TableAdapterManager.SilverBAYTableAdapter = Nothing
        Me.TableAdapterManager.SilverInvoceDetelsTableAdapter = Nothing
        Me.TableAdapterManager.SilverItemTableAdapter = Nothing
        Me.TableAdapterManager.SndGoldTableAdapter = Nothing
        Me.TableAdapterManager.SndToCustomerTableAdapter = Nothing
        Me.TableAdapterManager.STOCKTAKETableAdapter = Nothing
        Me.TableAdapterManager.StoneColorTableAdapter = Nothing
        Me.TableAdapterManager.TBBondTypeTableAdapter = Nothing
        Me.TableAdapterManager.TBErrorDescriptionTableAdapter = Nothing
        Me.TableAdapterManager.TPCompanylicenseIDTableAdapter = Nothing
        Me.TableAdapterManager.TPSellBuyWholesaleTableAdapter = Nothing
        Me.TableAdapterManager.TpSetGoledPriceDiffTableAdapter = Nothing
        Me.TableAdapterManager.TPWhatsAppMessagesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'Print_Parcood2BindingSource
        '
        Me.Print_Parcood2BindingSource.DataMember = "Print_Parcood2"
        Me.Print_Parcood2BindingSource.DataSource = Me.DT_restrantDataSet
        '
        'Print_Parcood2TableAdapter
        '
        Me.Print_Parcood2TableAdapter.ClearBeforeFill = True
        '
        'Print_Parcood2DataGridView
        '
        Me.Print_Parcood2DataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Print_Parcood2DataGridView.AutoGenerateColumns = False
        Me.Print_Parcood2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Print_Parcood2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.Print_Parcood2DataGridView.DataSource = Me.Print_Parcood2BindingSource
        Me.Print_Parcood2DataGridView.Location = New System.Drawing.Point(-88, 246)
        Me.Print_Parcood2DataGridView.Name = "Print_Parcood2DataGridView"
        Me.Print_Parcood2DataGridView.Size = New System.Drawing.Size(20, 24)
        Me.Print_Parcood2DataGridView.TabIndex = 73
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FO_name"
        Me.DataGridViewTextBoxColumn14.HeaderText = "FO_name"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "FO_desp"
        Me.DataGridViewTextBoxColumn15.HeaderText = "FO_desp"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "FO_gram"
        Me.DataGridViewTextBoxColumn16.HeaderText = "FO_gram"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "FO_gramMade"
        Me.DataGridViewTextBoxColumn17.HeaderText = "FO_gramMade"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "FO_made"
        Me.DataGridViewTextBoxColumn18.HeaderText = "FO_made"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "FO_extras"
        Me.DataGridViewTextBoxColumn19.HeaderText = "FO_extras"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "FO_price"
        Me.DataGridViewTextBoxColumn20.HeaderText = "FO_price"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "userID"
        Me.DataGridViewTextBoxColumn21.HeaderText = "userID"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "FO_GramPrice"
        Me.DataGridViewTextBoxColumn22.HeaderText = "FO_GramPrice"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "FO_totalPrice"
        Me.DataGridViewTextBoxColumn23.HeaderText = "FO_totalPrice"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Gram_valu"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Gram_valu"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'cmbLeftItem
        '
        Me.cmbLeftItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbLeftItem.DataSource = Me.Print_Parcood2BindingSource
        Me.cmbLeftItem.DisplayMember = "FO_name"
        Me.cmbLeftItem.FormattingEnabled = True
        Me.cmbLeftItem.Location = New System.Drawing.Point(203, 16)
        Me.cmbLeftItem.Name = "cmbLeftItem"
        Me.cmbLeftItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbLeftItem.Size = New System.Drawing.Size(146, 23)
        Me.cmbLeftItem.TabIndex = 1
        Me.cmbLeftItem.ValueMember = "BarCode"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.Location = New System.Drawing.Point(-88, 294)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(20, 24)
        Me.NumericUpDown1.TabIndex = 26
        '
        'Gram_valuTextBox1
        '
        Me.Gram_valuTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gram_valuTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "Gram_valu", True))
        Me.Gram_valuTextBox1.Location = New System.Drawing.Point(-64, 389)
        Me.Gram_valuTextBox1.Name = "Gram_valuTextBox1"
        Me.Gram_valuTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.Gram_valuTextBox1.TabIndex = 96
        '
        'FO_totalPriceTextBox1
        '
        Me.FO_totalPriceTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_totalPriceTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "FO_totalPrice", True))
        Me.FO_totalPriceTextBox1.Location = New System.Drawing.Point(-64, 365)
        Me.FO_totalPriceTextBox1.Name = "FO_totalPriceTextBox1"
        Me.FO_totalPriceTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.FO_totalPriceTextBox1.TabIndex = 94
        '
        'FO_GramPriceTextBox1
        '
        Me.FO_GramPriceTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_GramPriceTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "FO_GramPrice", True))
        Me.FO_GramPriceTextBox1.Location = New System.Drawing.Point(-64, 341)
        Me.FO_GramPriceTextBox1.Name = "FO_GramPriceTextBox1"
        Me.FO_GramPriceTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.FO_GramPriceTextBox1.TabIndex = 92
        '
        'UserIDTextBox1
        '
        Me.UserIDTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "userID", True))
        Me.UserIDTextBox1.Location = New System.Drawing.Point(-64, 317)
        Me.UserIDTextBox1.Name = "UserIDTextBox1"
        Me.UserIDTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.UserIDTextBox1.TabIndex = 90
        '
        'FO_priceTextBox1
        '
        Me.FO_priceTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_priceTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "FO_price", True))
        Me.FO_priceTextBox1.Location = New System.Drawing.Point(-64, 198)
        Me.FO_priceTextBox1.Name = "FO_priceTextBox1"
        Me.FO_priceTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.FO_priceTextBox1.TabIndex = 88
        '
        'FO_extrasTextBox1
        '
        Me.FO_extrasTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_extrasTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "FO_extras", True))
        Me.FO_extrasTextBox1.Location = New System.Drawing.Point(-64, 174)
        Me.FO_extrasTextBox1.Name = "FO_extrasTextBox1"
        Me.FO_extrasTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.FO_extrasTextBox1.TabIndex = 86
        '
        'FO_madeTextBox1
        '
        Me.FO_madeTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_madeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "FO_made", True))
        Me.FO_madeTextBox1.Location = New System.Drawing.Point(-64, 150)
        Me.FO_madeTextBox1.Name = "FO_madeTextBox1"
        Me.FO_madeTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.FO_madeTextBox1.TabIndex = 84
        '
        'FO_gramMadeTextBox1
        '
        Me.FO_gramMadeTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_gramMadeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "FO_gramMade", True))
        Me.FO_gramMadeTextBox1.Location = New System.Drawing.Point(-64, 126)
        Me.FO_gramMadeTextBox1.Name = "FO_gramMadeTextBox1"
        Me.FO_gramMadeTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.FO_gramMadeTextBox1.TabIndex = 82
        '
        'FO_gramTextBox1
        '
        Me.FO_gramTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_gramTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "FO_gram", True))
        Me.FO_gramTextBox1.Location = New System.Drawing.Point(-64, 102)
        Me.FO_gramTextBox1.Name = "FO_gramTextBox1"
        Me.FO_gramTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.FO_gramTextBox1.TabIndex = 80
        '
        'FO_despTextBox1
        '
        Me.FO_despTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_despTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "FO_desp", True))
        Me.FO_despTextBox1.Location = New System.Drawing.Point(-64, 78)
        Me.FO_despTextBox1.Name = "FO_despTextBox1"
        Me.FO_despTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.FO_despTextBox1.TabIndex = 78
        '
        'FO_nameTextBox1
        '
        Me.FO_nameTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_nameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "FO_name", True))
        Me.FO_nameTextBox1.Location = New System.Drawing.Point(-64, 54)
        Me.FO_nameTextBox1.Name = "FO_nameTextBox1"
        Me.FO_nameTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.FO_nameTextBox1.TabIndex = 76
        '
        'IDTextBox1
        '
        Me.IDTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "ID", True))
        Me.IDTextBox1.Location = New System.Drawing.Point(-64, 30)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.IDTextBox1.TabIndex = 74
        '
        'Gram_valuTextBox
        '
        Me.Gram_valuTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gram_valuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "Gram_valu", True))
        Me.Gram_valuTextBox.Location = New System.Drawing.Point(-40, 390)
        Me.Gram_valuTextBox.Name = "Gram_valuTextBox"
        Me.Gram_valuTextBox.Size = New System.Drawing.Size(20, 24)
        Me.Gram_valuTextBox.TabIndex = 73
        '
        'FO_totalPriceTextBox
        '
        Me.FO_totalPriceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_totalPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "FO_totalPrice", True))
        Me.FO_totalPriceTextBox.Location = New System.Drawing.Point(-40, 366)
        Me.FO_totalPriceTextBox.Name = "FO_totalPriceTextBox"
        Me.FO_totalPriceTextBox.Size = New System.Drawing.Size(20, 24)
        Me.FO_totalPriceTextBox.TabIndex = 71
        '
        'FO_GramPriceTextBox
        '
        Me.FO_GramPriceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_GramPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "FO_GramPrice", True))
        Me.FO_GramPriceTextBox.Location = New System.Drawing.Point(-40, 342)
        Me.FO_GramPriceTextBox.Name = "FO_GramPriceTextBox"
        Me.FO_GramPriceTextBox.Size = New System.Drawing.Size(20, 24)
        Me.FO_GramPriceTextBox.TabIndex = 69
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "userID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(-40, 318)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(20, 24)
        Me.UserIDTextBox.TabIndex = 67
        '
        'FO_priceTextBox
        '
        Me.FO_priceTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_priceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "FO_price", True))
        Me.FO_priceTextBox.Location = New System.Drawing.Point(-40, 198)
        Me.FO_priceTextBox.Name = "FO_priceTextBox"
        Me.FO_priceTextBox.Size = New System.Drawing.Size(20, 24)
        Me.FO_priceTextBox.TabIndex = 65
        '
        'FO_extrasTextBox
        '
        Me.FO_extrasTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_extrasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "FO_extras", True))
        Me.FO_extrasTextBox.Location = New System.Drawing.Point(-40, 174)
        Me.FO_extrasTextBox.Name = "FO_extrasTextBox"
        Me.FO_extrasTextBox.Size = New System.Drawing.Size(20, 24)
        Me.FO_extrasTextBox.TabIndex = 63
        '
        'FO_madeTextBox
        '
        Me.FO_madeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_madeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "FO_made", True))
        Me.FO_madeTextBox.Location = New System.Drawing.Point(-40, 150)
        Me.FO_madeTextBox.Name = "FO_madeTextBox"
        Me.FO_madeTextBox.Size = New System.Drawing.Size(20, 24)
        Me.FO_madeTextBox.TabIndex = 61
        '
        'FO_gramMadeTextBox
        '
        Me.FO_gramMadeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_gramMadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "FO_gramMade", True))
        Me.FO_gramMadeTextBox.Location = New System.Drawing.Point(-40, 126)
        Me.FO_gramMadeTextBox.Name = "FO_gramMadeTextBox"
        Me.FO_gramMadeTextBox.Size = New System.Drawing.Size(20, 24)
        Me.FO_gramMadeTextBox.TabIndex = 59
        '
        'FO_gramTextBox
        '
        Me.FO_gramTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_gramTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "FO_gram", True))
        Me.FO_gramTextBox.Location = New System.Drawing.Point(-40, 102)
        Me.FO_gramTextBox.Name = "FO_gramTextBox"
        Me.FO_gramTextBox.Size = New System.Drawing.Size(20, 24)
        Me.FO_gramTextBox.TabIndex = 57
        '
        'FO_despTextBox
        '
        Me.FO_despTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_despTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "FO_desp", True))
        Me.FO_despTextBox.Location = New System.Drawing.Point(-40, 78)
        Me.FO_despTextBox.Name = "FO_despTextBox"
        Me.FO_despTextBox.Size = New System.Drawing.Size(20, 24)
        Me.FO_despTextBox.TabIndex = 55
        '
        'FO_nameTextBox
        '
        Me.FO_nameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "FO_name", True))
        Me.FO_nameTextBox.Location = New System.Drawing.Point(-40, 54)
        Me.FO_nameTextBox.Name = "FO_nameTextBox"
        Me.FO_nameTextBox.Size = New System.Drawing.Size(20, 24)
        Me.FO_nameTextBox.TabIndex = 53
        '
        'IDTextBox
        '
        Me.IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(-40, 30)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(20, 24)
        Me.IDTextBox.TabIndex = 51
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.ForeColor = System.Drawing.Color.Maroon
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(900, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(82, 73)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'cmbCompany
        '
        Me.cmbCompany.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbCompany.DataSource = Me.CompinformBindingSource
        Me.cmbCompany.DisplayMember = "comp_note1"
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Location = New System.Drawing.Point(27, 47)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(182, 23)
        Me.cmbCompany.TabIndex = 0
        Me.cmbCompany.ValueMember = "comp_adrs"
        '
        'CompinformBindingSource
        '
        Me.CompinformBindingSource.DataMember = "comp_inform"
        Me.CompinformBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'CompdetelsBindingSource
        '
        Me.CompdetelsBindingSource.DataMember = "comp_detels"
        Me.CompdetelsBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'Comp_detelsTableAdapter
        '
        Me.Comp_detelsTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(182, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "الصنف"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(356, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "الصنف"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBarCodeRight)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbRightItem)
        Me.GroupBox1.Location = New System.Drawing.Point(513, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 47)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "يمين"
        '
        'txtBarCodeRight
        '
        Me.txtBarCodeRight.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtBarCodeRight.Location = New System.Drawing.Point(268, 17)
        Me.txtBarCodeRight.Name = "txtBarCodeRight"
        Me.txtBarCodeRight.Size = New System.Drawing.Size(146, 21)
        Me.txtBarCodeRight.TabIndex = 1
        Me.txtBarCodeRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBarCodeLeft)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbLeftItem)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 47)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "يسار"
        '
        'txtBarCodeLeft
        '
        Me.txtBarCodeLeft.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtBarCodeLeft.Location = New System.Drawing.Point(15, 17)
        Me.txtBarCodeLeft.Name = "txtBarCodeLeft"
        Me.txtBarCodeLeft.Size = New System.Drawing.Size(146, 21)
        Me.txtBarCodeLeft.TabIndex = 0
        Me.txtBarCodeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(-88, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(20, 24)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "تعديل"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(-88, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(20, 24)
        Me.Button3.TabIndex = 109
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(-88, 222)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.RichTextBox1.TabIndex = 110
        Me.RichTextBox1.Text = ""
        '
        'cmbPrinter
        '
        Me.cmbPrinter.FormattingEnabled = True
        Me.cmbPrinter.Location = New System.Drawing.Point(248, 47)
        Me.cmbPrinter.Name = "cmbPrinter"
        Me.cmbPrinter.Size = New System.Drawing.Size(182, 23)
        Me.cmbPrinter.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Maroon
        Me.Button5.Location = New System.Drawing.Point(-88, 102)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(20, 24)
        Me.Button5.TabIndex = 113
        Me.Button5.Text = "تحديد طابعة الباركود"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'gbRight
        '
        Me.gbRight.BackColor = System.Drawing.Color.Silver
        Me.gbRight.Controls.Add(Me.gbRightText)
        Me.gbRight.Controls.Add(Me.gbRightValue)
        Me.gbRight.Location = New System.Drawing.Point(618, 144)
        Me.gbRight.Name = "gbRight"
        Me.gbRight.Size = New System.Drawing.Size(364, 460)
        Me.gbRight.TabIndex = 7
        Me.gbRight.TabStop = False
        Me.gbRight.Text = "ضبط إعدادات الجهة اليمني للباركود"
        '
        'gbRightText
        '
        Me.gbRightText.BackColor = System.Drawing.Color.DarkGray
        Me.gbRightText.Controls.Add(Me.Label14)
        Me.gbRightText.Controls.Add(Me.L_Stone3Text_UTextBox)
        Me.gbRightText.Controls.Add(Me.L_Stone3Text_DTextBox)
        Me.gbRightText.Controls.Add(Me.Label15)
        Me.gbRightText.Controls.Add(Me.L_Stone2Text_UTextBox)
        Me.gbRightText.Controls.Add(Me.L_Stone2Text_DTextBox)
        Me.gbRightText.Controls.Add(Me.Label7)
        Me.gbRightText.Controls.Add(Me.L_CodeText_UTextBox)
        Me.gbRightText.Controls.Add(Me.L_CodeText_DTextBox)
        Me.gbRightText.Controls.Add(Me.L_FO_CountryTextBox_UTextBox)
        Me.gbRightText.Controls.Add(Me.L_FO_CountryTextBox_DTextBox)
        Me.gbRightText.Controls.Add(Me.Label34)
        Me.gbRightText.Controls.Add(Me.pbHRightText)
        Me.gbRightText.Controls.Add(Me.L_IDTextBox_UTextBox)
        Me.gbRightText.Controls.Add(Me.L_IDTextBox_DTextBox)
        Me.gbRightText.Controls.Add(Me.pbVRightText)
        Me.gbRightText.Controls.Add(Me.L_FO_madeTextBox_UTextBox)
        Me.gbRightText.Controls.Add(Me.Label49)
        Me.gbRightText.Controls.Add(Me.L_FO_madeTextBox_DTextBox)
        Me.gbRightText.Controls.Add(Me.Label47)
        Me.gbRightText.Controls.Add(Me.L_font_IDTextBox_UTextBox)
        Me.gbRightText.Controls.Add(Me.Label45)
        Me.gbRightText.Controls.Add(Me.L_font_IDTextBox_DTextBox)
        Me.gbRightText.Controls.Add(Me.Label43)
        Me.gbRightText.Controls.Add(Me.L_ComboBox3_UTextBox)
        Me.gbRightText.Controls.Add(Me.Label41)
        Me.gbRightText.Controls.Add(Me.L_ComboBox3_DTextBox)
        Me.gbRightText.Controls.Add(Me.Label39)
        Me.gbRightText.Controls.Add(Me.L_W_UTextBox)
        Me.gbRightText.Controls.Add(Me.Label33)
        Me.gbRightText.Controls.Add(Me.L_W_DTextBox)
        Me.gbRightText.Controls.Add(Me.Label31)
        Me.gbRightText.Controls.Add(Me.L_M_UTextBox)
        Me.gbRightText.Controls.Add(Me.L_S_DTextBox)
        Me.gbRightText.Controls.Add(Me.L_M_DTextBox)
        Me.gbRightText.Controls.Add(Me.L_S_UTextBox)
        Me.gbRightText.Controls.Add(Me.L_C_UTextBox)
        Me.gbRightText.Controls.Add(Me.L_C_DTextBox)
        Me.gbRightText.Location = New System.Drawing.Point(185, 25)
        Me.gbRightText.Name = "gbRightText"
        Me.gbRightText.Size = New System.Drawing.Size(173, 429)
        Me.gbRightText.TabIndex = 1
        Me.gbRightText.TabStop = False
        Me.gbRightText.Text = "النصوص"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(93, 307)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 21)
        Me.Label14.TabIndex = 437
        Me.Label14.Text = "فص3"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Stone3Text_UTextBox
        '
        Me.L_Stone3Text_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_Stone3Text_U", True))
        Me.L_Stone3Text_UTextBox.Location = New System.Drawing.Point(51, 307)
        Me.L_Stone3Text_UTextBox.Name = "L_Stone3Text_UTextBox"
        Me.L_Stone3Text_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_Stone3Text_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_Stone3Text_UTextBox.TabIndex = 436
        Me.L_Stone3Text_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CONFI_barcoodBindingSource
        '
        Me.CONFI_barcoodBindingSource.DataMember = "CONFI_barcood"
        Me.CONFI_barcoodBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'L_Stone3Text_DTextBox
        '
        Me.L_Stone3Text_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_Stone3Text_D", True))
        Me.L_Stone3Text_DTextBox.Location = New System.Drawing.Point(10, 307)
        Me.L_Stone3Text_DTextBox.Name = "L_Stone3Text_DTextBox"
        Me.L_Stone3Text_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_Stone3Text_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_Stone3Text_DTextBox.TabIndex = 435
        Me.L_Stone3Text_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(93, 283)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 21)
        Me.Label15.TabIndex = 434
        Me.Label15.Text = "فص2"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Stone2Text_UTextBox
        '
        Me.L_Stone2Text_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_Stone2Text_U", True))
        Me.L_Stone2Text_UTextBox.Location = New System.Drawing.Point(51, 283)
        Me.L_Stone2Text_UTextBox.Name = "L_Stone2Text_UTextBox"
        Me.L_Stone2Text_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_Stone2Text_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_Stone2Text_UTextBox.TabIndex = 433
        Me.L_Stone2Text_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_Stone2Text_DTextBox
        '
        Me.L_Stone2Text_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_Stone2Text_D", True))
        Me.L_Stone2Text_DTextBox.Location = New System.Drawing.Point(10, 283)
        Me.L_Stone2Text_DTextBox.Name = "L_Stone2Text_DTextBox"
        Me.L_Stone2Text_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_Stone2Text_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_Stone2Text_DTextBox.TabIndex = 432
        Me.L_Stone2Text_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(92, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 21)
        Me.Label7.TabIndex = 428
        Me.Label7.Text = "الرمز"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_CodeText_UTextBox
        '
        Me.L_CodeText_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_CodeText_U", True))
        Me.L_CodeText_UTextBox.Location = New System.Drawing.Point(51, 331)
        Me.L_CodeText_UTextBox.Name = "L_CodeText_UTextBox"
        Me.L_CodeText_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_CodeText_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_CodeText_UTextBox.TabIndex = 19
        Me.L_CodeText_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_CodeText_DTextBox
        '
        Me.L_CodeText_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_CodeText_D", True))
        Me.L_CodeText_DTextBox.Location = New System.Drawing.Point(10, 331)
        Me.L_CodeText_DTextBox.Name = "L_CodeText_DTextBox"
        Me.L_CodeText_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_CodeText_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_CodeText_DTextBox.TabIndex = 18
        Me.L_CodeText_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_FO_CountryTextBox_UTextBox
        '
        Me.L_FO_CountryTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_FO_CountryTextBox_U", True))
        Me.L_FO_CountryTextBox_UTextBox.Location = New System.Drawing.Point(51, 67)
        Me.L_FO_CountryTextBox_UTextBox.Name = "L_FO_CountryTextBox_UTextBox"
        Me.L_FO_CountryTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_FO_CountryTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_FO_CountryTextBox_UTextBox.TabIndex = 1
        Me.L_FO_CountryTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_FO_CountryTextBox_DTextBox
        '
        Me.L_FO_CountryTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_FO_CountryTextBox_D", True))
        Me.L_FO_CountryTextBox_DTextBox.Location = New System.Drawing.Point(10, 67)
        Me.L_FO_CountryTextBox_DTextBox.Name = "L_FO_CountryTextBox_DTextBox"
        Me.L_FO_CountryTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_FO_CountryTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_FO_CountryTextBox_DTextBox.TabIndex = 0
        Me.L_FO_CountryTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(92, 69)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(80, 21)
        Me.Label34.TabIndex = 422
        Me.Label34.Text = "بلد المنشأ"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbHRightText
        '
        Me.pbHRightText.BackColor = System.Drawing.Color.White
        Me.pbHRightText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbHRightText.Image = Global.DT_restrant.My.Resources.Resources.ArrowLeftRight
        Me.pbHRightText.Location = New System.Drawing.Point(10, 20)
        Me.pbHRightText.Name = "pbHRightText"
        Me.pbHRightText.Size = New System.Drawing.Size(40, 40)
        Me.pbHRightText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHRightText.TabIndex = 419
        Me.pbHRightText.TabStop = False
        '
        'L_IDTextBox_UTextBox
        '
        Me.L_IDTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_IDTextBox_U", True))
        Me.L_IDTextBox_UTextBox.Location = New System.Drawing.Point(51, 115)
        Me.L_IDTextBox_UTextBox.Name = "L_IDTextBox_UTextBox"
        Me.L_IDTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_IDTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_IDTextBox_UTextBox.TabIndex = 5
        Me.L_IDTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_IDTextBox_DTextBox
        '
        Me.L_IDTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_IDTextBox_D", True))
        Me.L_IDTextBox_DTextBox.Location = New System.Drawing.Point(10, 115)
        Me.L_IDTextBox_DTextBox.Name = "L_IDTextBox_DTextBox"
        Me.L_IDTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_IDTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_IDTextBox_DTextBox.TabIndex = 4
        Me.L_IDTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbVRightText
        '
        Me.pbVRightText.BackColor = System.Drawing.Color.White
        Me.pbVRightText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbVRightText.Image = Global.DT_restrant.My.Resources.Resources.ArrowUpDown
        Me.pbVRightText.Location = New System.Drawing.Point(51, 20)
        Me.pbVRightText.Name = "pbVRightText"
        Me.pbVRightText.Size = New System.Drawing.Size(40, 40)
        Me.pbVRightText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbVRightText.TabIndex = 418
        Me.pbVRightText.TabStop = False
        '
        'L_FO_madeTextBox_UTextBox
        '
        Me.L_FO_madeTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_FO_madeTextBox_U", True))
        Me.L_FO_madeTextBox_UTextBox.Location = New System.Drawing.Point(51, 91)
        Me.L_FO_madeTextBox_UTextBox.Name = "L_FO_madeTextBox_UTextBox"
        Me.L_FO_madeTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_FO_madeTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_FO_madeTextBox_UTextBox.TabIndex = 3
        Me.L_FO_madeTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(92, 165)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(80, 21)
        Me.Label49.TabIndex = 67
        Me.Label49.Text = "Label49"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_FO_madeTextBox_DTextBox
        '
        Me.L_FO_madeTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_FO_madeTextBox_D", True))
        Me.L_FO_madeTextBox_DTextBox.Location = New System.Drawing.Point(10, 91)
        Me.L_FO_madeTextBox_DTextBox.Name = "L_FO_madeTextBox_DTextBox"
        Me.L_FO_madeTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_FO_madeTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_FO_madeTextBox_DTextBox.TabIndex = 2
        Me.L_FO_madeTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label47
        '
        Me.Label47.Location = New System.Drawing.Point(92, 141)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(80, 21)
        Me.Label47.TabIndex = 65
        Me.Label47.Text = "Label47"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_font_IDTextBox_UTextBox
        '
        Me.L_font_IDTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_font_IDTextBox_U", True))
        Me.L_font_IDTextBox_UTextBox.Location = New System.Drawing.Point(51, 139)
        Me.L_font_IDTextBox_UTextBox.Name = "L_font_IDTextBox_UTextBox"
        Me.L_font_IDTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_font_IDTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_font_IDTextBox_UTextBox.TabIndex = 7
        Me.L_font_IDTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(92, 93)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(80, 21)
        Me.Label45.TabIndex = 63
        Me.Label45.Text = "المورد"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_font_IDTextBox_DTextBox
        '
        Me.L_font_IDTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_font_IDTextBox_D", True))
        Me.L_font_IDTextBox_DTextBox.Location = New System.Drawing.Point(10, 139)
        Me.L_font_IDTextBox_DTextBox.Name = "L_font_IDTextBox_DTextBox"
        Me.L_font_IDTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_font_IDTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_font_IDTextBox_DTextBox.TabIndex = 6
        Me.L_font_IDTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(92, 117)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(80, 21)
        Me.Label43.TabIndex = 61
        Me.Label43.Text = "Label43"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_ComboBox3_UTextBox
        '
        Me.L_ComboBox3_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_ComboBox3_U", True))
        Me.L_ComboBox3_UTextBox.Location = New System.Drawing.Point(51, 163)
        Me.L_ComboBox3_UTextBox.Name = "L_ComboBox3_UTextBox"
        Me.L_ComboBox3_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_ComboBox3_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_ComboBox3_UTextBox.TabIndex = 9
        Me.L_ComboBox3_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(92, 261)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(80, 21)
        Me.Label41.TabIndex = 59
        Me.Label41.Text = "Label41"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_ComboBox3_DTextBox
        '
        Me.L_ComboBox3_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_ComboBox3_D", True))
        Me.L_ComboBox3_DTextBox.Location = New System.Drawing.Point(10, 163)
        Me.L_ComboBox3_DTextBox.Name = "L_ComboBox3_DTextBox"
        Me.L_ComboBox3_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_ComboBox3_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_ComboBox3_DTextBox.TabIndex = 8
        Me.L_ComboBox3_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(92, 237)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(80, 21)
        Me.Label39.TabIndex = 57
        Me.Label39.Text = "Label39"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_W_UTextBox
        '
        Me.L_W_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_الوزن_U", True))
        Me.L_W_UTextBox.Location = New System.Drawing.Point(51, 187)
        Me.L_W_UTextBox.Name = "L_W_UTextBox"
        Me.L_W_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_W_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_W_UTextBox.TabIndex = 11
        Me.L_W_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(92, 213)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(80, 21)
        Me.Label33.TabIndex = 51
        Me.Label33.Text = "Label33"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_W_DTextBox
        '
        Me.L_W_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_الوزن_D", True))
        Me.L_W_DTextBox.Location = New System.Drawing.Point(10, 187)
        Me.L_W_DTextBox.Name = "L_W_DTextBox"
        Me.L_W_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_W_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_W_DTextBox.TabIndex = 10
        Me.L_W_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(92, 189)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(80, 21)
        Me.Label31.TabIndex = 49
        Me.Label31.Text = "Label31"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_M_UTextBox
        '
        Me.L_M_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_المصنعيه_U", True))
        Me.L_M_UTextBox.Location = New System.Drawing.Point(51, 211)
        Me.L_M_UTextBox.Name = "L_M_UTextBox"
        Me.L_M_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_M_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_M_UTextBox.TabIndex = 13
        Me.L_M_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_S_DTextBox
        '
        Me.L_S_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_فصوص_D", True))
        Me.L_S_DTextBox.Location = New System.Drawing.Point(10, 259)
        Me.L_S_DTextBox.Name = "L_S_DTextBox"
        Me.L_S_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_S_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_S_DTextBox.TabIndex = 16
        Me.L_S_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_M_DTextBox
        '
        Me.L_M_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_المصنعيه_D", True))
        Me.L_M_DTextBox.Location = New System.Drawing.Point(10, 211)
        Me.L_M_DTextBox.Name = "L_M_DTextBox"
        Me.L_M_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_M_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_M_DTextBox.TabIndex = 12
        Me.L_M_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_S_UTextBox
        '
        Me.L_S_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_فصوص_U", True))
        Me.L_S_UTextBox.Location = New System.Drawing.Point(51, 259)
        Me.L_S_UTextBox.Name = "L_S_UTextBox"
        Me.L_S_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_S_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_S_UTextBox.TabIndex = 17
        Me.L_S_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_C_UTextBox
        '
        Me.L_C_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_العيار_U", True))
        Me.L_C_UTextBox.Location = New System.Drawing.Point(51, 235)
        Me.L_C_UTextBox.Name = "L_C_UTextBox"
        Me.L_C_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_C_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_C_UTextBox.TabIndex = 15
        Me.L_C_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_C_DTextBox
        '
        Me.L_C_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_العيار_D", True))
        Me.L_C_DTextBox.Location = New System.Drawing.Point(10, 235)
        Me.L_C_DTextBox.Name = "L_C_DTextBox"
        Me.L_C_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_C_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_C_DTextBox.TabIndex = 14
        Me.L_C_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbRightValue
        '
        Me.gbRightValue.BackColor = System.Drawing.Color.DarkGray
        Me.gbRightValue.Controls.Add(Me.Label12)
        Me.gbRightValue.Controls.Add(Me.L_Stone3Value_UTextBox)
        Me.gbRightValue.Controls.Add(Me.L_Stone3Value_DTextBox)
        Me.gbRightValue.Controls.Add(Me.Label13)
        Me.gbRightValue.Controls.Add(Me.L_Stone2Value_UTextBox)
        Me.gbRightValue.Controls.Add(Me.L_Stone2Value_DTextBox)
        Me.gbRightValue.Controls.Add(Me.Label6)
        Me.gbRightValue.Controls.Add(Me.L_CodeValue_UTextBox)
        Me.gbRightValue.Controls.Add(Me.L_CodeValue_DTextBox)
        Me.gbRightValue.Controls.Add(Me.Label51)
        Me.gbRightValue.Controls.Add(Me.L_FO_gramTextBox_UTextBox)
        Me.gbRightValue.Controls.Add(Me.pbHRightValue)
        Me.gbRightValue.Controls.Add(Me.L_FO_gramTextBox_DTextBox)
        Me.gbRightValue.Controls.Add(Me.Label53)
        Me.gbRightValue.Controls.Add(Me.L_FO_gramMadeTextBox_UTextBox)
        Me.gbRightValue.Controls.Add(Me.L_FO_gramMadeTextBox_DTextBox)
        Me.gbRightValue.Controls.Add(Me.pbVRightValue)
        Me.gbRightValue.Controls.Add(Me.L_Gram_valuTextBox_UTextBox)
        Me.gbRightValue.Controls.Add(Me.L_Gram_valuTextBox_DTextBox)
        Me.gbRightValue.Controls.Add(Me.L_FO_extrasTextBox_UTextBox)
        Me.gbRightValue.Controls.Add(Me.L_FO_extrasTextBox_DTextBox)
        Me.gbRightValue.Controls.Add(Me.Label35)
        Me.gbRightValue.Controls.Add(Me.Label37)
        Me.gbRightValue.Location = New System.Drawing.Point(7, 25)
        Me.gbRightValue.Name = "gbRightValue"
        Me.gbRightValue.Size = New System.Drawing.Size(173, 429)
        Me.gbRightValue.TabIndex = 0
        Me.gbRightValue.TabStop = False
        Me.gbRightValue.Text = "القيم"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(91, 308)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 21)
        Me.Label12.TabIndex = 434
        Me.Label12.Text = "فص3"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Stone3Value_UTextBox
        '
        Me.L_Stone3Value_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_Stone3Value_U", True))
        Me.L_Stone3Value_UTextBox.Location = New System.Drawing.Point(51, 308)
        Me.L_Stone3Value_UTextBox.Name = "L_Stone3Value_UTextBox"
        Me.L_Stone3Value_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_Stone3Value_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_Stone3Value_UTextBox.TabIndex = 433
        Me.L_Stone3Value_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_Stone3Value_DTextBox
        '
        Me.L_Stone3Value_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_Stone3Value_D", True))
        Me.L_Stone3Value_DTextBox.Location = New System.Drawing.Point(10, 308)
        Me.L_Stone3Value_DTextBox.Name = "L_Stone3Value_DTextBox"
        Me.L_Stone3Value_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_Stone3Value_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_Stone3Value_DTextBox.TabIndex = 432
        Me.L_Stone3Value_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(91, 284)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 21)
        Me.Label13.TabIndex = 431
        Me.Label13.Text = "فص2"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_Stone2Value_UTextBox
        '
        Me.L_Stone2Value_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_Stone2Value_U", True))
        Me.L_Stone2Value_UTextBox.Location = New System.Drawing.Point(51, 284)
        Me.L_Stone2Value_UTextBox.Name = "L_Stone2Value_UTextBox"
        Me.L_Stone2Value_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_Stone2Value_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_Stone2Value_UTextBox.TabIndex = 430
        Me.L_Stone2Value_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_Stone2Value_DTextBox
        '
        Me.L_Stone2Value_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_Stone2Value_D", True))
        Me.L_Stone2Value_DTextBox.Location = New System.Drawing.Point(10, 284)
        Me.L_Stone2Value_DTextBox.Name = "L_Stone2Value_DTextBox"
        Me.L_Stone2Value_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_Stone2Value_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_Stone2Value_DTextBox.TabIndex = 429
        Me.L_Stone2Value_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(91, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 21)
        Me.Label6.TabIndex = 425
        Me.Label6.Text = "الرمز"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_CodeValue_UTextBox
        '
        Me.L_CodeValue_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_CodeValue_U", True))
        Me.L_CodeValue_UTextBox.Location = New System.Drawing.Point(51, 332)
        Me.L_CodeValue_UTextBox.Name = "L_CodeValue_UTextBox"
        Me.L_CodeValue_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_CodeValue_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_CodeValue_UTextBox.TabIndex = 9
        Me.L_CodeValue_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_CodeValue_DTextBox
        '
        Me.L_CodeValue_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_CodeValue_D", True))
        Me.L_CodeValue_DTextBox.Location = New System.Drawing.Point(10, 332)
        Me.L_CodeValue_DTextBox.Name = "L_CodeValue_DTextBox"
        Me.L_CodeValue_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_CodeValue_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_CodeValue_DTextBox.TabIndex = 8
        Me.L_CodeValue_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(91, 190)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(80, 21)
        Me.Label51.TabIndex = 69
        Me.Label51.Text = "Label51"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_FO_gramTextBox_UTextBox
        '
        Me.L_FO_gramTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_FO_gramTextBox_U", True))
        Me.L_FO_gramTextBox_UTextBox.Location = New System.Drawing.Point(51, 188)
        Me.L_FO_gramTextBox_UTextBox.Name = "L_FO_gramTextBox_UTextBox"
        Me.L_FO_gramTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_FO_gramTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_FO_gramTextBox_UTextBox.TabIndex = 1
        Me.L_FO_gramTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbHRightValue
        '
        Me.pbHRightValue.BackColor = System.Drawing.Color.White
        Me.pbHRightValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbHRightValue.Image = Global.DT_restrant.My.Resources.Resources.ArrowLeftRight
        Me.pbHRightValue.Location = New System.Drawing.Point(10, 20)
        Me.pbHRightValue.Name = "pbHRightValue"
        Me.pbHRightValue.Size = New System.Drawing.Size(40, 40)
        Me.pbHRightValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHRightValue.TabIndex = 419
        Me.pbHRightValue.TabStop = False
        '
        'L_FO_gramTextBox_DTextBox
        '
        Me.L_FO_gramTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_FO_gramTextBox_D", True))
        Me.L_FO_gramTextBox_DTextBox.Location = New System.Drawing.Point(10, 188)
        Me.L_FO_gramTextBox_DTextBox.Name = "L_FO_gramTextBox_DTextBox"
        Me.L_FO_gramTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_FO_gramTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_FO_gramTextBox_DTextBox.TabIndex = 0
        Me.L_FO_gramTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(91, 262)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(80, 21)
        Me.Label53.TabIndex = 71
        Me.Label53.Text = "Label53"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_FO_gramMadeTextBox_UTextBox
        '
        Me.L_FO_gramMadeTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_FO_gramMadeTextBox_U", True))
        Me.L_FO_gramMadeTextBox_UTextBox.Location = New System.Drawing.Point(51, 212)
        Me.L_FO_gramMadeTextBox_UTextBox.Name = "L_FO_gramMadeTextBox_UTextBox"
        Me.L_FO_gramMadeTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_FO_gramMadeTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_FO_gramMadeTextBox_UTextBox.TabIndex = 3
        Me.L_FO_gramMadeTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_FO_gramMadeTextBox_DTextBox
        '
        Me.L_FO_gramMadeTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_FO_gramMadeTextBox_D", True))
        Me.L_FO_gramMadeTextBox_DTextBox.Location = New System.Drawing.Point(10, 212)
        Me.L_FO_gramMadeTextBox_DTextBox.Name = "L_FO_gramMadeTextBox_DTextBox"
        Me.L_FO_gramMadeTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_FO_gramMadeTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_FO_gramMadeTextBox_DTextBox.TabIndex = 2
        Me.L_FO_gramMadeTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbVRightValue
        '
        Me.pbVRightValue.BackColor = System.Drawing.Color.White
        Me.pbVRightValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbVRightValue.Image = Global.DT_restrant.My.Resources.Resources.ArrowUpDown
        Me.pbVRightValue.Location = New System.Drawing.Point(51, 20)
        Me.pbVRightValue.Name = "pbVRightValue"
        Me.pbVRightValue.Size = New System.Drawing.Size(40, 40)
        Me.pbVRightValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbVRightValue.TabIndex = 418
        Me.pbVRightValue.TabStop = False
        '
        'L_Gram_valuTextBox_UTextBox
        '
        Me.L_Gram_valuTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_Gram_valuTextBox_U", True))
        Me.L_Gram_valuTextBox_UTextBox.Location = New System.Drawing.Point(51, 236)
        Me.L_Gram_valuTextBox_UTextBox.Name = "L_Gram_valuTextBox_UTextBox"
        Me.L_Gram_valuTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_Gram_valuTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_Gram_valuTextBox_UTextBox.TabIndex = 5
        Me.L_Gram_valuTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_Gram_valuTextBox_DTextBox
        '
        Me.L_Gram_valuTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_Gram_valuTextBox_D", True))
        Me.L_Gram_valuTextBox_DTextBox.Location = New System.Drawing.Point(10, 236)
        Me.L_Gram_valuTextBox_DTextBox.Name = "L_Gram_valuTextBox_DTextBox"
        Me.L_Gram_valuTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_Gram_valuTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_Gram_valuTextBox_DTextBox.TabIndex = 4
        Me.L_Gram_valuTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_FO_extrasTextBox_UTextBox
        '
        Me.L_FO_extrasTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_FO_extrasTextBox_U", True))
        Me.L_FO_extrasTextBox_UTextBox.Location = New System.Drawing.Point(51, 260)
        Me.L_FO_extrasTextBox_UTextBox.Name = "L_FO_extrasTextBox_UTextBox"
        Me.L_FO_extrasTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_FO_extrasTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_FO_extrasTextBox_UTextBox.TabIndex = 7
        Me.L_FO_extrasTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_FO_extrasTextBox_DTextBox
        '
        Me.L_FO_extrasTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "L_FO_extrasTextBox_D", True))
        Me.L_FO_extrasTextBox_DTextBox.Location = New System.Drawing.Point(10, 260)
        Me.L_FO_extrasTextBox_DTextBox.Name = "L_FO_extrasTextBox_DTextBox"
        Me.L_FO_extrasTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.L_FO_extrasTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.L_FO_extrasTextBox_DTextBox.TabIndex = 6
        Me.L_FO_extrasTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(91, 214)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(80, 21)
        Me.Label35.TabIndex = 53
        Me.Label35.Text = "Label35"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(91, 238)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(80, 21)
        Me.Label37.TabIndex = 55
        Me.Label37.Text = "Label37"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CONFI_barcoodTableAdapter
        '
        Me.CONFI_barcoodTableAdapter.ClearBeforeFill = True
        '
        'CONFI_barcoodDataGridView
        '
        Me.CONFI_barcoodDataGridView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CONFI_barcoodDataGridView.AutoGenerateColumns = False
        Me.CONFI_barcoodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONFI_barcoodDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.print_set, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62, Me.DataGridViewTextBoxColumn63, Me.DataGridViewTextBoxColumn64, Me.DataGridViewTextBoxColumn65, Me.DataGridViewTextBoxColumn66, Me.DataGridViewTextBoxColumn67, Me.DataGridViewTextBoxColumn68, Me.DataGridViewTextBoxColumn69, Me.DataGridViewTextBoxColumn70, Me.DataGridViewTextBoxColumn71, Me.DataGridViewTextBoxColumn72, Me.DataGridViewTextBoxColumn73, Me.DataGridViewTextBoxColumn74, Me.DataGridViewTextBoxColumn75, Me.DataGridViewTextBoxColumn76, Me.DataGridViewTextBoxColumn77, Me.DataGridViewTextBoxColumn78, Me.DataGridViewTextBoxColumn79, Me.DataGridViewTextBoxColumn80, Me.DataGridViewTextBoxColumn81, Me.print})
        Me.CONFI_barcoodDataGridView.DataSource = Me.CONFI_barcoodBindingSource
        Me.CONFI_barcoodDataGridView.Location = New System.Drawing.Point(-88, 30)
        Me.CONFI_barcoodDataGridView.Name = "CONFI_barcoodDataGridView"
        Me.CONFI_barcoodDataGridView.Size = New System.Drawing.Size(20, 24)
        Me.CONFI_barcoodDataGridView.TabIndex = 113
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "size_id"
        Me.DataGridViewTextBoxColumn25.HeaderText = "size_id"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'print_set
        '
        Me.print_set.DataPropertyName = "print_set"
        Me.print_set.HeaderText = "print_set"
        Me.print_set.Name = "print_set"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "L_IDTextBox_U"
        Me.DataGridViewTextBoxColumn26.HeaderText = "L_IDTextBox_U"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "L_IDTextBox_D"
        Me.DataGridViewTextBoxColumn27.HeaderText = "L_IDTextBox_D"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "L_FO_madeTextBox_U"
        Me.DataGridViewTextBoxColumn28.HeaderText = "L_FO_madeTextBox_U"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "L_FO_madeTextBox_D"
        Me.DataGridViewTextBoxColumn29.HeaderText = "L_FO_madeTextBox_D"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "L_font_IDTextBox_U"
        Me.DataGridViewTextBoxColumn30.HeaderText = "L_font_IDTextBox_U"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "L_font_IDTextBox_D"
        Me.DataGridViewTextBoxColumn31.HeaderText = "L_font_IDTextBox_D"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "L_ComboBox3_U"
        Me.DataGridViewTextBoxColumn32.HeaderText = "L_ComboBox3_U"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "L_ComboBox3_D"
        Me.DataGridViewTextBoxColumn33.HeaderText = "L_ComboBox3_D"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "L_FO_gramTextBox_U"
        Me.DataGridViewTextBoxColumn34.HeaderText = "L_FO_gramTextBox_U"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "L_FO_gramTextBox_D"
        Me.DataGridViewTextBoxColumn35.HeaderText = "L_FO_gramTextBox_D"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "L_الوزن_U"
        Me.DataGridViewTextBoxColumn36.HeaderText = "L_الوزن_U"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "L_الوزن_D"
        Me.DataGridViewTextBoxColumn37.HeaderText = "L_الوزن_D"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "L_المصنعيه_U"
        Me.DataGridViewTextBoxColumn38.HeaderText = "L_المصنعيه_U"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "L_المصنعيه_D"
        Me.DataGridViewTextBoxColumn39.HeaderText = "L_المصنعيه_D"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "L_FO_gramMadeTextBox_U"
        Me.DataGridViewTextBoxColumn40.HeaderText = "L_FO_gramMadeTextBox_U"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "L_FO_gramMadeTextBox_D"
        Me.DataGridViewTextBoxColumn41.HeaderText = "L_FO_gramMadeTextBox_D"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "L_Gram_valuTextBox_U"
        Me.DataGridViewTextBoxColumn42.HeaderText = "L_Gram_valuTextBox_U"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "L_Gram_valuTextBox_D"
        Me.DataGridViewTextBoxColumn43.HeaderText = "L_Gram_valuTextBox_D"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "L_العيار_U"
        Me.DataGridViewTextBoxColumn44.HeaderText = "L_العيار_U"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "L_العيار_D"
        Me.DataGridViewTextBoxColumn45.HeaderText = "L_العيار_D"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "L_FO_extrasTextBox_U"
        Me.DataGridViewTextBoxColumn46.HeaderText = "L_FO_extrasTextBox_U"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "L_FO_extrasTextBox_D"
        Me.DataGridViewTextBoxColumn47.HeaderText = "L_FO_extrasTextBox_D"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "L_فصوص_U"
        Me.DataGridViewTextBoxColumn48.HeaderText = "L_فصوص_U"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "L_فصوص_D"
        Me.DataGridViewTextBoxColumn49.HeaderText = "L_فصوص_D"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "R_IDTextBox_U"
        Me.DataGridViewTextBoxColumn50.HeaderText = "R_IDTextBox_U"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "R_IDTextBox_D"
        Me.DataGridViewTextBoxColumn51.HeaderText = "R_IDTextBox_D"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "R_FO_madeTextBox_U"
        Me.DataGridViewTextBoxColumn52.HeaderText = "R_FO_madeTextBox_U"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "R_FO_madeTextBox_D"
        Me.DataGridViewTextBoxColumn53.HeaderText = "R_FO_madeTextBox_D"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "R_font_IDTextBox_U"
        Me.DataGridViewTextBoxColumn54.HeaderText = "R_font_IDTextBox_U"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "R_font_IDTextBox_D"
        Me.DataGridViewTextBoxColumn55.HeaderText = "R_font_IDTextBox_D"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "R_ComboBox3_U"
        Me.DataGridViewTextBoxColumn56.HeaderText = "R_ComboBox3_U"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "R_ComboBox3_D"
        Me.DataGridViewTextBoxColumn57.HeaderText = "R_ComboBox3_D"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "R_FO_gramTextBox_U"
        Me.DataGridViewTextBoxColumn58.HeaderText = "R_FO_gramTextBox_U"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "R_FO_gramTextBox_D"
        Me.DataGridViewTextBoxColumn59.HeaderText = "R_FO_gramTextBox_D"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "R_الوزن_U"
        Me.DataGridViewTextBoxColumn60.HeaderText = "R_الوزن_U"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "R_الوزن_D"
        Me.DataGridViewTextBoxColumn61.HeaderText = "R_الوزن_D"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "R_المصنعيه_U"
        Me.DataGridViewTextBoxColumn62.HeaderText = "R_المصنعيه_U"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "R_المصنعيه_D"
        Me.DataGridViewTextBoxColumn63.HeaderText = "R_المصنعيه_D"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "R_FO_gramMadeTextBox_U"
        Me.DataGridViewTextBoxColumn64.HeaderText = "R_FO_gramMadeTextBox_U"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "R_FO_gramMadeTextBox_D"
        Me.DataGridViewTextBoxColumn65.HeaderText = "R_FO_gramMadeTextBox_D"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "R_Gram_valuTextBox_U"
        Me.DataGridViewTextBoxColumn66.HeaderText = "R_Gram_valuTextBox_U"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "R_Gram_valuTextBox_D"
        Me.DataGridViewTextBoxColumn67.HeaderText = "R_Gram_valuTextBox_D"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.DataPropertyName = "R_العيار_U"
        Me.DataGridViewTextBoxColumn68.HeaderText = "R_العيار_U"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        '
        'DataGridViewTextBoxColumn69
        '
        Me.DataGridViewTextBoxColumn69.DataPropertyName = "R_العيار_D"
        Me.DataGridViewTextBoxColumn69.HeaderText = "R_العيار_D"
        Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
        '
        'DataGridViewTextBoxColumn70
        '
        Me.DataGridViewTextBoxColumn70.DataPropertyName = "R_FO_extrasTextBox_U"
        Me.DataGridViewTextBoxColumn70.HeaderText = "R_FO_extrasTextBox_U"
        Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
        '
        'DataGridViewTextBoxColumn71
        '
        Me.DataGridViewTextBoxColumn71.DataPropertyName = "R_FO_extrasTextBox_D"
        Me.DataGridViewTextBoxColumn71.HeaderText = "R_FO_extrasTextBox_D"
        Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
        '
        'DataGridViewTextBoxColumn72
        '
        Me.DataGridViewTextBoxColumn72.DataPropertyName = "R_فصوص_U"
        Me.DataGridViewTextBoxColumn72.HeaderText = "R_فصوص_U"
        Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
        '
        'DataGridViewTextBoxColumn73
        '
        Me.DataGridViewTextBoxColumn73.DataPropertyName = "R_فصوص_D"
        Me.DataGridViewTextBoxColumn73.HeaderText = "R_فصوص_D"
        Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
        '
        'DataGridViewTextBoxColumn74
        '
        Me.DataGridViewTextBoxColumn74.DataPropertyName = "سبايكu"
        Me.DataGridViewTextBoxColumn74.HeaderText = "سبايكu"
        Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
        '
        'DataGridViewTextBoxColumn75
        '
        Me.DataGridViewTextBoxColumn75.DataPropertyName = "سبايكd"
        Me.DataGridViewTextBoxColumn75.HeaderText = "سبايكd"
        Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
        '
        'DataGridViewTextBoxColumn76
        '
        Me.DataGridViewTextBoxColumn76.DataPropertyName = "ويبu"
        Me.DataGridViewTextBoxColumn76.HeaderText = "ويبu"
        Me.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76"
        '
        'DataGridViewTextBoxColumn77
        '
        Me.DataGridViewTextBoxColumn77.DataPropertyName = "ويبd"
        Me.DataGridViewTextBoxColumn77.HeaderText = "ويبd"
        Me.DataGridViewTextBoxColumn77.Name = "DataGridViewTextBoxColumn77"
        '
        'DataGridViewTextBoxColumn78
        '
        Me.DataGridViewTextBoxColumn78.DataPropertyName = "باركود_ويبu"
        Me.DataGridViewTextBoxColumn78.HeaderText = "باركود_ويبu"
        Me.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78"
        '
        'DataGridViewTextBoxColumn79
        '
        Me.DataGridViewTextBoxColumn79.DataPropertyName = "باركود_ويبd"
        Me.DataGridViewTextBoxColumn79.HeaderText = "باركود_ويبd"
        Me.DataGridViewTextBoxColumn79.Name = "DataGridViewTextBoxColumn79"
        '
        'DataGridViewTextBoxColumn80
        '
        Me.DataGridViewTextBoxColumn80.DataPropertyName = "tel_u"
        Me.DataGridViewTextBoxColumn80.HeaderText = "tel_u"
        Me.DataGridViewTextBoxColumn80.Name = "DataGridViewTextBoxColumn80"
        '
        'DataGridViewTextBoxColumn81
        '
        Me.DataGridViewTextBoxColumn81.DataPropertyName = "tel_d"
        Me.DataGridViewTextBoxColumn81.HeaderText = "tel_d"
        Me.DataGridViewTextBoxColumn81.Name = "DataGridViewTextBoxColumn81"
        '
        'print
        '
        Me.print.DataPropertyName = "print"
        Me.print.HeaderText = "print"
        Me.print.Name = "print"
        '
        'txtSAP_U
        '
        Me.txtSAP_U.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "سبايكu", True))
        Me.txtSAP_U.Location = New System.Drawing.Point(59, 160)
        Me.txtSAP_U.Name = "txtSAP_U"
        Me.txtSAP_U.Size = New System.Drawing.Size(40, 24)
        Me.txtSAP_U.TabIndex = 9
        Me.txtSAP_U.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSAP_D
        '
        Me.txtSAP_D.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "سبايكd", True))
        Me.txtSAP_D.Location = New System.Drawing.Point(18, 160)
        Me.txtSAP_D.Name = "txtSAP_D"
        Me.txtSAP_D.Size = New System.Drawing.Size(40, 24)
        Me.txtSAP_D.TabIndex = 8
        Me.txtSAP_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGOLDENSAP_U
        '
        Me.txtGOLDENSAP_U.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "باركود_ويبu", True))
        Me.txtGOLDENSAP_U.Location = New System.Drawing.Point(59, 184)
        Me.txtGOLDENSAP_U.Name = "txtGOLDENSAP_U"
        Me.txtGOLDENSAP_U.Size = New System.Drawing.Size(40, 24)
        Me.txtGOLDENSAP_U.TabIndex = 11
        Me.txtGOLDENSAP_U.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGOLDENSAP_D
        '
        Me.txtGOLDENSAP_D.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "باركود_ويبd", True))
        Me.txtGOLDENSAP_D.Location = New System.Drawing.Point(18, 184)
        Me.txtGOLDENSAP_D.Name = "txtGOLDENSAP_D"
        Me.txtGOLDENSAP_D.Size = New System.Drawing.Size(40, 24)
        Me.txtGOLDENSAP_D.TabIndex = 10
        Me.txtGOLDENSAP_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tel_uTextBox
        '
        Me.Tel_uTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tel_uTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "tel_u", True))
        Me.Tel_uTextBox.Location = New System.Drawing.Point(-88, 54)
        Me.Tel_uTextBox.Name = "Tel_uTextBox"
        Me.Tel_uTextBox.Size = New System.Drawing.Size(20, 24)
        Me.Tel_uTextBox.TabIndex = 144
        '
        'Tel_dTextBox
        '
        Me.Tel_dTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tel_dTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "tel_d", True))
        Me.Tel_dTextBox.Location = New System.Drawing.Point(-88, 78)
        Me.Tel_dTextBox.Name = "Tel_dTextBox"
        Me.Tel_dTextBox.Size = New System.Drawing.Size(20, 24)
        Me.Tel_dTextBox.TabIndex = 145
        '
        'Print_setTextBox
        '
        Me.Print_setTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Print_setTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "print_set", True))
        Me.Print_setTextBox.Location = New System.Drawing.Point(-88, 150)
        Me.Print_setTextBox.Name = "Print_setTextBox"
        Me.Print_setTextBox.Size = New System.Drawing.Size(20, 24)
        Me.Print_setTextBox.TabIndex = 146
        '
        'gbLeft
        '
        Me.gbLeft.BackColor = System.Drawing.Color.Gainsboro
        Me.gbLeft.Controls.Add(Me.gbLeftText)
        Me.gbLeft.Controls.Add(Me.gbLeftValue)
        Me.gbLeft.Location = New System.Drawing.Point(12, 144)
        Me.gbLeft.Name = "gbLeft"
        Me.gbLeft.Size = New System.Drawing.Size(369, 460)
        Me.gbLeft.TabIndex = 5
        Me.gbLeft.TabStop = False
        Me.gbLeft.Text = "ضبط إعدادات الجهة اليسرى للباركود"
        '
        'gbLeftText
        '
        Me.gbLeftText.BackColor = System.Drawing.Color.DarkGray
        Me.gbLeftText.Controls.Add(Me.Label11)
        Me.gbLeftText.Controls.Add(Me.R_Stone3Text_UTextBox)
        Me.gbLeftText.Controls.Add(Me.R_Stone3Text_DTextBox)
        Me.gbLeftText.Controls.Add(Me.Label10)
        Me.gbLeftText.Controls.Add(Me.R_Stone2Text_UTextBox)
        Me.gbLeftText.Controls.Add(Me.R_Stone2Text_DTextBox)
        Me.gbLeftText.Controls.Add(Me.Label5)
        Me.gbLeftText.Controls.Add(Me.R_CodeText_UTextBox)
        Me.gbLeftText.Controls.Add(Me.R_CodeText_DTextBox)
        Me.gbLeftText.Controls.Add(Me.Label32)
        Me.gbLeftText.Controls.Add(Me.R_FO_CountryTextBox_DTextBox)
        Me.gbLeftText.Controls.Add(Me.R_FO_CountryTextBox_UTextBox)
        Me.gbLeftText.Controls.Add(Me.Label77)
        Me.gbLeftText.Controls.Add(Me.R_M_DTextBox)
        Me.gbLeftText.Controls.Add(Me.pbHLeftText)
        Me.gbLeftText.Controls.Add(Me.R_M_UTextBox)
        Me.gbLeftText.Controls.Add(Me.pbVLeftText)
        Me.gbLeftText.Controls.Add(Me.R_W_DTextBox)
        Me.gbLeftText.Controls.Add(Me.R_W_UTextBox)
        Me.gbLeftText.Controls.Add(Me.Label73)
        Me.gbLeftText.Controls.Add(Me.R_S_DTextBox)
        Me.gbLeftText.Controls.Add(Me.Label71)
        Me.gbLeftText.Controls.Add(Me.R_S_UTextBox)
        Me.gbLeftText.Controls.Add(Me.Label69)
        Me.gbLeftText.Controls.Add(Me.R_C_UTextBox)
        Me.gbLeftText.Controls.Add(Me.Label67)
        Me.gbLeftText.Controls.Add(Me.R_ComboBox3_DTextBox)
        Me.gbLeftText.Controls.Add(Me.Label63)
        Me.gbLeftText.Controls.Add(Me.R_C_DTextBox)
        Me.gbLeftText.Controls.Add(Me.Label57)
        Me.gbLeftText.Controls.Add(Me.R_ComboBox3_UTextBox)
        Me.gbLeftText.Controls.Add(Me.Label55)
        Me.gbLeftText.Controls.Add(Me.R_font_IDTextBox_DTextBox)
        Me.gbLeftText.Controls.Add(Me.R_font_IDTextBox_UTextBox)
        Me.gbLeftText.Controls.Add(Me.R_FO_madeTextBox_DTextBox)
        Me.gbLeftText.Controls.Add(Me.R_FO_madeTextBox_UTextBox)
        Me.gbLeftText.Controls.Add(Me.R_IDTextBox_DTextBox)
        Me.gbLeftText.Controls.Add(Me.R_IDTextBox_UTextBox)
        Me.gbLeftText.Location = New System.Drawing.Point(185, 25)
        Me.gbLeftText.Name = "gbLeftText"
        Me.gbLeftText.Size = New System.Drawing.Size(179, 429)
        Me.gbLeftText.TabIndex = 1
        Me.gbLeftText.TabStop = False
        Me.gbLeftText.Text = "النصوص"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(93, 309)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 21)
        Me.Label11.TabIndex = 431
        Me.Label11.Text = "فص3"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_Stone3Text_UTextBox
        '
        Me.R_Stone3Text_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_Stone3Text_U", True))
        Me.R_Stone3Text_UTextBox.Location = New System.Drawing.Point(51, 308)
        Me.R_Stone3Text_UTextBox.Name = "R_Stone3Text_UTextBox"
        Me.R_Stone3Text_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_Stone3Text_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_Stone3Text_UTextBox.TabIndex = 430
        Me.R_Stone3Text_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_Stone3Text_DTextBox
        '
        Me.R_Stone3Text_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_Stone3Text_D", True))
        Me.R_Stone3Text_DTextBox.Location = New System.Drawing.Point(10, 308)
        Me.R_Stone3Text_DTextBox.Name = "R_Stone3Text_DTextBox"
        Me.R_Stone3Text_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_Stone3Text_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_Stone3Text_DTextBox.TabIndex = 429
        Me.R_Stone3Text_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(93, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 21)
        Me.Label10.TabIndex = 428
        Me.Label10.Text = "فص2"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_Stone2Text_UTextBox
        '
        Me.R_Stone2Text_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_Stone2Text_U", True))
        Me.R_Stone2Text_UTextBox.Location = New System.Drawing.Point(51, 284)
        Me.R_Stone2Text_UTextBox.Name = "R_Stone2Text_UTextBox"
        Me.R_Stone2Text_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_Stone2Text_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_Stone2Text_UTextBox.TabIndex = 427
        Me.R_Stone2Text_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_Stone2Text_DTextBox
        '
        Me.R_Stone2Text_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_Stone2Text_D", True))
        Me.R_Stone2Text_DTextBox.Location = New System.Drawing.Point(10, 284)
        Me.R_Stone2Text_DTextBox.Name = "R_Stone2Text_DTextBox"
        Me.R_Stone2Text_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_Stone2Text_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_Stone2Text_DTextBox.TabIndex = 426
        Me.R_Stone2Text_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(93, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 21)
        Me.Label5.TabIndex = 425
        Me.Label5.Text = "الرمز"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_CodeText_UTextBox
        '
        Me.R_CodeText_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_CodeText_U", True))
        Me.R_CodeText_UTextBox.Location = New System.Drawing.Point(51, 332)
        Me.R_CodeText_UTextBox.Name = "R_CodeText_UTextBox"
        Me.R_CodeText_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_CodeText_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_CodeText_UTextBox.TabIndex = 19
        Me.R_CodeText_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_CodeText_DTextBox
        '
        Me.R_CodeText_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_CodeText_D", True))
        Me.R_CodeText_DTextBox.Location = New System.Drawing.Point(10, 332)
        Me.R_CodeText_DTextBox.Name = "R_CodeText_DTextBox"
        Me.R_CodeText_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_CodeText_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_CodeText_DTextBox.TabIndex = 18
        Me.R_CodeText_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(93, 70)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label32.Size = New System.Drawing.Size(80, 21)
        Me.Label32.TabIndex = 422
        Me.Label32.Text = "بلد المنشأ"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_FO_CountryTextBox_DTextBox
        '
        Me.R_FO_CountryTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_FO_CountryTextBox_D1", True))
        Me.R_FO_CountryTextBox_DTextBox.Location = New System.Drawing.Point(10, 68)
        Me.R_FO_CountryTextBox_DTextBox.Name = "R_FO_CountryTextBox_DTextBox"
        Me.R_FO_CountryTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_FO_CountryTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_FO_CountryTextBox_DTextBox.TabIndex = 0
        Me.R_FO_CountryTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_FO_CountryTextBox_UTextBox
        '
        Me.R_FO_CountryTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_FO_CountryTextBox_U1", True))
        Me.R_FO_CountryTextBox_UTextBox.Location = New System.Drawing.Point(51, 68)
        Me.R_FO_CountryTextBox_UTextBox.Name = "R_FO_CountryTextBox_UTextBox"
        Me.R_FO_CountryTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_FO_CountryTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_FO_CountryTextBox_UTextBox.TabIndex = 1
        Me.R_FO_CountryTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label77
        '
        Me.Label77.Location = New System.Drawing.Point(93, 262)
        Me.Label77.Name = "Label77"
        Me.Label77.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label77.Size = New System.Drawing.Size(80, 21)
        Me.Label77.TabIndex = 192
        Me.Label77.Text = "فص1"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_M_DTextBox
        '
        Me.R_M_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_المصنعيه_D", True))
        Me.R_M_DTextBox.Location = New System.Drawing.Point(10, 212)
        Me.R_M_DTextBox.Name = "R_M_DTextBox"
        Me.R_M_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_M_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_M_DTextBox.TabIndex = 12
        Me.R_M_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbHLeftText
        '
        Me.pbHLeftText.BackColor = System.Drawing.Color.White
        Me.pbHLeftText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbHLeftText.Image = Global.DT_restrant.My.Resources.Resources.ArrowLeftRight
        Me.pbHLeftText.Location = New System.Drawing.Point(10, 20)
        Me.pbHLeftText.Name = "pbHLeftText"
        Me.pbHLeftText.Size = New System.Drawing.Size(40, 40)
        Me.pbHLeftText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHLeftText.TabIndex = 419
        Me.pbHLeftText.TabStop = False
        '
        'R_M_UTextBox
        '
        Me.R_M_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_المصنعيه_U", True))
        Me.R_M_UTextBox.Location = New System.Drawing.Point(51, 212)
        Me.R_M_UTextBox.Name = "R_M_UTextBox"
        Me.R_M_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_M_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_M_UTextBox.TabIndex = 13
        Me.R_M_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbVLeftText
        '
        Me.pbVLeftText.BackColor = System.Drawing.Color.White
        Me.pbVLeftText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbVLeftText.Image = Global.DT_restrant.My.Resources.Resources.ArrowUpDown
        Me.pbVLeftText.Location = New System.Drawing.Point(51, 20)
        Me.pbVLeftText.Name = "pbVLeftText"
        Me.pbVLeftText.Size = New System.Drawing.Size(40, 40)
        Me.pbVLeftText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbVLeftText.TabIndex = 418
        Me.pbVLeftText.TabStop = False
        '
        'R_W_DTextBox
        '
        Me.R_W_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_الوزن_D", True))
        Me.R_W_DTextBox.Location = New System.Drawing.Point(10, 188)
        Me.R_W_DTextBox.Name = "R_W_DTextBox"
        Me.R_W_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_W_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_W_DTextBox.TabIndex = 10
        Me.R_W_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_W_UTextBox
        '
        Me.R_W_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_الوزن_U", True))
        Me.R_W_UTextBox.Location = New System.Drawing.Point(51, 188)
        Me.R_W_UTextBox.Name = "R_W_UTextBox"
        Me.R_W_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_W_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_W_UTextBox.TabIndex = 11
        Me.R_W_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(93, 166)
        Me.Label73.Name = "Label73"
        Me.Label73.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label73.Size = New System.Drawing.Size(80, 21)
        Me.Label73.TabIndex = 188
        Me.Label73.Text = "المعرض"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_S_DTextBox
        '
        Me.R_S_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_فصوص_D", True))
        Me.R_S_DTextBox.Location = New System.Drawing.Point(10, 260)
        Me.R_S_DTextBox.Name = "R_S_DTextBox"
        Me.R_S_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_S_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_S_DTextBox.TabIndex = 16
        Me.R_S_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(93, 142)
        Me.Label71.Name = "Label71"
        Me.Label71.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label71.Size = New System.Drawing.Size(80, 21)
        Me.Label71.TabIndex = 186
        Me.Label71.Text = "رقم الباركود"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_S_UTextBox
        '
        Me.R_S_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_فصوص_U", True))
        Me.R_S_UTextBox.Location = New System.Drawing.Point(51, 260)
        Me.R_S_UTextBox.Name = "R_S_UTextBox"
        Me.R_S_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_S_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_S_UTextBox.TabIndex = 17
        Me.R_S_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(93, 94)
        Me.Label69.Name = "Label69"
        Me.Label69.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label69.Size = New System.Drawing.Size(80, 21)
        Me.Label69.TabIndex = 184
        Me.Label69.Text = "المورد"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_C_UTextBox
        '
        Me.R_C_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_العيار_U", True))
        Me.R_C_UTextBox.Location = New System.Drawing.Point(51, 236)
        Me.R_C_UTextBox.Name = "R_C_UTextBox"
        Me.R_C_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_C_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_C_UTextBox.TabIndex = 15
        Me.R_C_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label67
        '
        Me.Label67.Location = New System.Drawing.Point(93, 118)
        Me.Label67.Name = "Label67"
        Me.Label67.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label67.Size = New System.Drawing.Size(80, 21)
        Me.Label67.TabIndex = 182
        Me.Label67.Text = "باركود"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_ComboBox3_DTextBox
        '
        Me.R_ComboBox3_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_ComboBox3_D", True))
        Me.R_ComboBox3_DTextBox.Location = New System.Drawing.Point(10, 164)
        Me.R_ComboBox3_DTextBox.Name = "R_ComboBox3_DTextBox"
        Me.R_ComboBox3_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_ComboBox3_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_ComboBox3_DTextBox.TabIndex = 8
        Me.R_ComboBox3_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(93, 238)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(80, 21)
        Me.Label63.TabIndex = 178
        Me.Label63.Text = "Label63"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_C_DTextBox
        '
        Me.R_C_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_العيار_D", True))
        Me.R_C_DTextBox.Location = New System.Drawing.Point(10, 236)
        Me.R_C_DTextBox.Name = "R_C_DTextBox"
        Me.R_C_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_C_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_C_DTextBox.TabIndex = 14
        Me.R_C_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(93, 214)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(80, 21)
        Me.Label57.TabIndex = 172
        Me.Label57.Text = "Label57"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_ComboBox3_UTextBox
        '
        Me.R_ComboBox3_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_ComboBox3_U", True))
        Me.R_ComboBox3_UTextBox.Location = New System.Drawing.Point(51, 164)
        Me.R_ComboBox3_UTextBox.Name = "R_ComboBox3_UTextBox"
        Me.R_ComboBox3_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_ComboBox3_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_ComboBox3_UTextBox.TabIndex = 9
        Me.R_ComboBox3_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label55
        '
        Me.Label55.Location = New System.Drawing.Point(93, 190)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(80, 21)
        Me.Label55.TabIndex = 73
        Me.Label55.Text = "Label55"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_font_IDTextBox_DTextBox
        '
        Me.R_font_IDTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_font_IDTextBox_D", True))
        Me.R_font_IDTextBox_DTextBox.Location = New System.Drawing.Point(10, 140)
        Me.R_font_IDTextBox_DTextBox.Name = "R_font_IDTextBox_DTextBox"
        Me.R_font_IDTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_font_IDTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_font_IDTextBox_DTextBox.TabIndex = 6
        Me.R_font_IDTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_font_IDTextBox_UTextBox
        '
        Me.R_font_IDTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_font_IDTextBox_U", True))
        Me.R_font_IDTextBox_UTextBox.Location = New System.Drawing.Point(51, 140)
        Me.R_font_IDTextBox_UTextBox.Name = "R_font_IDTextBox_UTextBox"
        Me.R_font_IDTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_font_IDTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_font_IDTextBox_UTextBox.TabIndex = 7
        Me.R_font_IDTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_FO_madeTextBox_DTextBox
        '
        Me.R_FO_madeTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_FO_madeTextBox_D", True))
        Me.R_FO_madeTextBox_DTextBox.Location = New System.Drawing.Point(10, 92)
        Me.R_FO_madeTextBox_DTextBox.Name = "R_FO_madeTextBox_DTextBox"
        Me.R_FO_madeTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_FO_madeTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_FO_madeTextBox_DTextBox.TabIndex = 2
        Me.R_FO_madeTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_FO_madeTextBox_UTextBox
        '
        Me.R_FO_madeTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_FO_madeTextBox_U", True))
        Me.R_FO_madeTextBox_UTextBox.Location = New System.Drawing.Point(51, 92)
        Me.R_FO_madeTextBox_UTextBox.Name = "R_FO_madeTextBox_UTextBox"
        Me.R_FO_madeTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_FO_madeTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_FO_madeTextBox_UTextBox.TabIndex = 3
        Me.R_FO_madeTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_IDTextBox_DTextBox
        '
        Me.R_IDTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_IDTextBox_D", True))
        Me.R_IDTextBox_DTextBox.Location = New System.Drawing.Point(10, 116)
        Me.R_IDTextBox_DTextBox.Name = "R_IDTextBox_DTextBox"
        Me.R_IDTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_IDTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_IDTextBox_DTextBox.TabIndex = 4
        Me.R_IDTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_IDTextBox_UTextBox
        '
        Me.R_IDTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_IDTextBox_U", True))
        Me.R_IDTextBox_UTextBox.Location = New System.Drawing.Point(51, 116)
        Me.R_IDTextBox_UTextBox.Name = "R_IDTextBox_UTextBox"
        Me.R_IDTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_IDTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_IDTextBox_UTextBox.TabIndex = 5
        Me.R_IDTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbLeftValue
        '
        Me.gbLeftValue.BackColor = System.Drawing.Color.DarkGray
        Me.gbLeftValue.Controls.Add(Me.Label9)
        Me.gbLeftValue.Controls.Add(Me.R_Stone3Value_UTextBox)
        Me.gbLeftValue.Controls.Add(Me.R_Stone3Value_DTextBox)
        Me.gbLeftValue.Controls.Add(Me.Label8)
        Me.gbLeftValue.Controls.Add(Me.R_Stone2Value_UTextBox)
        Me.gbLeftValue.Controls.Add(Me.R_Stone2Value_DTextBox)
        Me.gbLeftValue.Controls.Add(Me.Label3)
        Me.gbLeftValue.Controls.Add(Me.R_CodeValue_UTextBox)
        Me.gbLeftValue.Controls.Add(Me.R_CodeValue_DTextBox)
        Me.gbLeftValue.Controls.Add(Me.R_FO_gramTextBox_UTextBox)
        Me.gbLeftValue.Controls.Add(Me.R_FO_gramMadeTextBox_UTextBox)
        Me.gbLeftValue.Controls.Add(Me.pbHLeftValue)
        Me.gbLeftValue.Controls.Add(Me.R_FO_gramMadeTextBox_DTextBox)
        Me.gbLeftValue.Controls.Add(Me.R_Gram_valuTextBox_UTextBox)
        Me.gbLeftValue.Controls.Add(Me.pbVLeftValue)
        Me.gbLeftValue.Controls.Add(Me.R_Gram_valuTextBox_DTextBox)
        Me.gbLeftValue.Controls.Add(Me.R_FO_gramTextBox_DTextBox)
        Me.gbLeftValue.Controls.Add(Me.Label75)
        Me.gbLeftValue.Controls.Add(Me.R_FO_extrasTextBox_UTextBox)
        Me.gbLeftValue.Controls.Add(Me.R_FO_extrasTextBox_DTextBox)
        Me.gbLeftValue.Controls.Add(Me.Label59)
        Me.gbLeftValue.Controls.Add(Me.Label61)
        Me.gbLeftValue.Controls.Add(Me.Label65)
        Me.gbLeftValue.Location = New System.Drawing.Point(6, 25)
        Me.gbLeftValue.Name = "gbLeftValue"
        Me.gbLeftValue.Size = New System.Drawing.Size(173, 429)
        Me.gbLeftValue.TabIndex = 0
        Me.gbLeftValue.TabStop = False
        Me.gbLeftValue.Text = "القيم"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(91, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 21)
        Me.Label9.TabIndex = 428
        Me.Label9.Text = "فص3"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_Stone3Value_UTextBox
        '
        Me.R_Stone3Value_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_Stone3Value_U", True))
        Me.R_Stone3Value_UTextBox.Location = New System.Drawing.Point(51, 308)
        Me.R_Stone3Value_UTextBox.Name = "R_Stone3Value_UTextBox"
        Me.R_Stone3Value_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_Stone3Value_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_Stone3Value_UTextBox.TabIndex = 427
        Me.R_Stone3Value_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_Stone3Value_DTextBox
        '
        Me.R_Stone3Value_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_Stone3Value_D", True))
        Me.R_Stone3Value_DTextBox.Location = New System.Drawing.Point(10, 308)
        Me.R_Stone3Value_DTextBox.Name = "R_Stone3Value_DTextBox"
        Me.R_Stone3Value_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_Stone3Value_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_Stone3Value_DTextBox.TabIndex = 426
        Me.R_Stone3Value_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(91, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 21)
        Me.Label8.TabIndex = 425
        Me.Label8.Text = "فص2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_Stone2Value_UTextBox
        '
        Me.R_Stone2Value_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_Stone2Value_U", True))
        Me.R_Stone2Value_UTextBox.Location = New System.Drawing.Point(51, 284)
        Me.R_Stone2Value_UTextBox.Name = "R_Stone2Value_UTextBox"
        Me.R_Stone2Value_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_Stone2Value_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_Stone2Value_UTextBox.TabIndex = 424
        Me.R_Stone2Value_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_Stone2Value_DTextBox
        '
        Me.R_Stone2Value_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_Stone2Value_D", True))
        Me.R_Stone2Value_DTextBox.Location = New System.Drawing.Point(10, 284)
        Me.R_Stone2Value_DTextBox.Name = "R_Stone2Value_DTextBox"
        Me.R_Stone2Value_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_Stone2Value_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_Stone2Value_DTextBox.TabIndex = 423
        Me.R_Stone2Value_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(91, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 21)
        Me.Label3.TabIndex = 422
        Me.Label3.Text = "الرمز"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_CodeValue_UTextBox
        '
        Me.R_CodeValue_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_CodeValue_U", True))
        Me.R_CodeValue_UTextBox.Location = New System.Drawing.Point(51, 332)
        Me.R_CodeValue_UTextBox.Name = "R_CodeValue_UTextBox"
        Me.R_CodeValue_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_CodeValue_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_CodeValue_UTextBox.TabIndex = 9
        Me.R_CodeValue_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_CodeValue_DTextBox
        '
        Me.R_CodeValue_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_CodeValue_D", True))
        Me.R_CodeValue_DTextBox.Location = New System.Drawing.Point(10, 332)
        Me.R_CodeValue_DTextBox.Name = "R_CodeValue_DTextBox"
        Me.R_CodeValue_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_CodeValue_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_CodeValue_DTextBox.TabIndex = 8
        Me.R_CodeValue_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_FO_gramTextBox_UTextBox
        '
        Me.R_FO_gramTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_FO_gramTextBox_U", True))
        Me.R_FO_gramTextBox_UTextBox.Location = New System.Drawing.Point(51, 188)
        Me.R_FO_gramTextBox_UTextBox.Name = "R_FO_gramTextBox_UTextBox"
        Me.R_FO_gramTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_FO_gramTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_FO_gramTextBox_UTextBox.TabIndex = 1
        Me.R_FO_gramTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_FO_gramMadeTextBox_UTextBox
        '
        Me.R_FO_gramMadeTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_FO_gramMadeTextBox_U", True))
        Me.R_FO_gramMadeTextBox_UTextBox.Location = New System.Drawing.Point(51, 212)
        Me.R_FO_gramMadeTextBox_UTextBox.Name = "R_FO_gramMadeTextBox_UTextBox"
        Me.R_FO_gramMadeTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_FO_gramMadeTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_FO_gramMadeTextBox_UTextBox.TabIndex = 3
        Me.R_FO_gramMadeTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbHLeftValue
        '
        Me.pbHLeftValue.BackColor = System.Drawing.Color.White
        Me.pbHLeftValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbHLeftValue.Image = Global.DT_restrant.My.Resources.Resources.ArrowLeftRight
        Me.pbHLeftValue.Location = New System.Drawing.Point(10, 20)
        Me.pbHLeftValue.Name = "pbHLeftValue"
        Me.pbHLeftValue.Size = New System.Drawing.Size(40, 40)
        Me.pbHLeftValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHLeftValue.TabIndex = 419
        Me.pbHLeftValue.TabStop = False
        '
        'R_FO_gramMadeTextBox_DTextBox
        '
        Me.R_FO_gramMadeTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_FO_gramMadeTextBox_D", True))
        Me.R_FO_gramMadeTextBox_DTextBox.Location = New System.Drawing.Point(10, 212)
        Me.R_FO_gramMadeTextBox_DTextBox.Name = "R_FO_gramMadeTextBox_DTextBox"
        Me.R_FO_gramMadeTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_FO_gramMadeTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_FO_gramMadeTextBox_DTextBox.TabIndex = 2
        Me.R_FO_gramMadeTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_Gram_valuTextBox_UTextBox
        '
        Me.R_Gram_valuTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_Gram_valuTextBox_U", True))
        Me.R_Gram_valuTextBox_UTextBox.Location = New System.Drawing.Point(51, 236)
        Me.R_Gram_valuTextBox_UTextBox.Name = "R_Gram_valuTextBox_UTextBox"
        Me.R_Gram_valuTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_Gram_valuTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_Gram_valuTextBox_UTextBox.TabIndex = 5
        Me.R_Gram_valuTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbVLeftValue
        '
        Me.pbVLeftValue.BackColor = System.Drawing.Color.White
        Me.pbVLeftValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbVLeftValue.Image = Global.DT_restrant.My.Resources.Resources.ArrowUpDown
        Me.pbVLeftValue.Location = New System.Drawing.Point(51, 20)
        Me.pbVLeftValue.Name = "pbVLeftValue"
        Me.pbVLeftValue.Size = New System.Drawing.Size(40, 40)
        Me.pbVLeftValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbVLeftValue.TabIndex = 418
        Me.pbVLeftValue.TabStop = False
        '
        'R_Gram_valuTextBox_DTextBox
        '
        Me.R_Gram_valuTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_Gram_valuTextBox_D", True))
        Me.R_Gram_valuTextBox_DTextBox.Location = New System.Drawing.Point(10, 236)
        Me.R_Gram_valuTextBox_DTextBox.Name = "R_Gram_valuTextBox_DTextBox"
        Me.R_Gram_valuTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_Gram_valuTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_Gram_valuTextBox_DTextBox.TabIndex = 4
        Me.R_Gram_valuTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_FO_gramTextBox_DTextBox
        '
        Me.R_FO_gramTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_FO_gramTextBox_D", True))
        Me.R_FO_gramTextBox_DTextBox.Location = New System.Drawing.Point(10, 188)
        Me.R_FO_gramTextBox_DTextBox.Name = "R_FO_gramTextBox_DTextBox"
        Me.R_FO_gramTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_FO_gramTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_FO_gramTextBox_DTextBox.TabIndex = 0
        Me.R_FO_gramTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label75
        '
        Me.Label75.Location = New System.Drawing.Point(91, 190)
        Me.Label75.Name = "Label75"
        Me.Label75.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label75.Size = New System.Drawing.Size(80, 21)
        Me.Label75.TabIndex = 190
        Me.Label75.Text = "الوزن"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'R_FO_extrasTextBox_UTextBox
        '
        Me.R_FO_extrasTextBox_UTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_FO_extrasTextBox_U", True))
        Me.R_FO_extrasTextBox_UTextBox.Location = New System.Drawing.Point(51, 260)
        Me.R_FO_extrasTextBox_UTextBox.Name = "R_FO_extrasTextBox_UTextBox"
        Me.R_FO_extrasTextBox_UTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_FO_extrasTextBox_UTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_FO_extrasTextBox_UTextBox.TabIndex = 7
        Me.R_FO_extrasTextBox_UTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_FO_extrasTextBox_DTextBox
        '
        Me.R_FO_extrasTextBox_DTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "R_FO_extrasTextBox_D", True))
        Me.R_FO_extrasTextBox_DTextBox.Location = New System.Drawing.Point(10, 260)
        Me.R_FO_extrasTextBox_DTextBox.Name = "R_FO_extrasTextBox_DTextBox"
        Me.R_FO_extrasTextBox_DTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.R_FO_extrasTextBox_DTextBox.Size = New System.Drawing.Size(40, 24)
        Me.R_FO_extrasTextBox_DTextBox.TabIndex = 6
        Me.R_FO_extrasTextBox_DTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(91, 214)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(80, 21)
        Me.Label59.TabIndex = 174
        Me.Label59.Text = "المصنعية"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label61
        '
        Me.Label61.Location = New System.Drawing.Point(91, 238)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(80, 21)
        Me.Label61.TabIndex = 176
        Me.Label61.Text = "العيار"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(91, 262)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(80, 21)
        Me.Label65.TabIndex = 180
        Me.Label65.Text = "فص1"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(719, 46)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(81, 24)
        Me.txtQty.TabIndex = 2
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.Maroon
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskOk
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(813, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 73)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(248, 20)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label28.Size = New System.Drawing.Size(182, 23)
        Me.Label28.TabIndex = 104
        Me.Label28.Text = "تحديد الطابعة"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Comp_informTableAdapter
        '
        Me.Comp_informTableAdapter.ClearBeforeFill = True
        '
        'Label79
        '
        Me.Label79.Location = New System.Drawing.Point(719, 23)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(81, 19)
        Me.Label79.TabIndex = 73
        Me.Label79.Text = "العدد"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label80
        '
        Me.Label80.Location = New System.Drawing.Point(104, 187)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(97, 19)
        Me.Label80.TabIndex = 176
        Me.Label80.Text = "Golden SAP"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label84
        '
        Me.Label84.Location = New System.Drawing.Point(104, 163)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(97, 19)
        Me.Label84.TabIndex = 180
        Me.Label84.Text = "SAP"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.StoneWeight3TextBox1)
        Me.pnl.Controls.Add(Me.StoneName3TextBox1)
        Me.pnl.Controls.Add(Me.StoneWeight2TextBox1)
        Me.pnl.Controls.Add(Me.StoneName2TextBox1)
        Me.pnl.Controls.Add(Me.StoneWeight3TextBox)
        Me.pnl.Controls.Add(Me.StoneName3TextBox)
        Me.pnl.Controls.Add(Me.StoneWeight2TextBox)
        Me.pnl.Controls.Add(Me.StoneName2TextBox)
        Me.pnl.Controls.Add(Me.BarCodeTextBox1)
        Me.pnl.Controls.Add(Me.BarCodeTextBox)
        Me.pnl.Controls.Add(Me.FO_ItemNoTextBox1)
        Me.pnl.Controls.Add(Me.FO_ItemNoTextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR17TextBox)
        Me.pnl.Controls.Add(Me.ListView1)
        Me.pnl.Controls.Add(Me.ListView2)
        Me.pnl.Controls.Add(Me.SET_INVARCHR16TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR15TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR14TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR13TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR12TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR11TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR1TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR128TextBox)
        Me.pnl.Controls.Add(Me.IDTextBox)
        Me.pnl.Controls.Add(Me.Gram_valuTextBox)
        Me.pnl.Controls.Add(Me.FO_totalPriceTextBox)
        Me.pnl.Controls.Add(Me.FO_GramPriceTextBox)
        Me.pnl.Controls.Add(Me.UserIDTextBox)
        Me.pnl.Controls.Add(Me.FO_priceTextBox)
        Me.pnl.Controls.Add(Me.FO_extrasTextBox)
        Me.pnl.Controls.Add(Me.FO_madeTextBox)
        Me.pnl.Controls.Add(Me.FO_gramMadeTextBox)
        Me.pnl.Controls.Add(Me.Print_setTextBox)
        Me.pnl.Controls.Add(Me.FO_gramTextBox)
        Me.pnl.Controls.Add(Me.FO_despTextBox)
        Me.pnl.Controls.Add(Me.FO_nameTextBox)
        Me.pnl.Controls.Add(Me.IDTextBox1)
        Me.pnl.Controls.Add(Me.Gram_valuTextBox1)
        Me.pnl.Controls.Add(Me.Tel_dTextBox)
        Me.pnl.Controls.Add(Me.FO_totalPriceTextBox1)
        Me.pnl.Controls.Add(Me.RichTextBox1)
        Me.pnl.Controls.Add(Me.FO_GramPriceTextBox1)
        Me.pnl.Controls.Add(Me.Button3)
        Me.pnl.Controls.Add(Me.Tel_uTextBox)
        Me.pnl.Controls.Add(Me.ReportViewer1)
        Me.pnl.Controls.Add(Me.Print_Parcood2DataGridView)
        Me.pnl.Controls.Add(Me.NumericUpDown1)
        Me.pnl.Controls.Add(Me.Button5)
        Me.pnl.Controls.Add(Me.UserIDTextBox1)
        Me.pnl.Controls.Add(Me.FO_priceTextBox1)
        Me.pnl.Controls.Add(Me.Button1)
        Me.pnl.Controls.Add(Me.FO_extrasTextBox1)
        Me.pnl.Controls.Add(Me.FO_madeTextBox1)
        Me.pnl.Controls.Add(Me.Print_Parcood1DataGridView)
        Me.pnl.Controls.Add(Me.FO_gramMadeTextBox1)
        Me.pnl.Controls.Add(Me.FO_gramTextBox1)
        Me.pnl.Controls.Add(Me.FO_despTextBox1)
        Me.pnl.Controls.Add(Me.FO_nameTextBox1)
        Me.pnl.Controls.Add(Me.CONFI_barcoodDataGridView)
        Me.pnl.Location = New System.Drawing.Point(1054, 5)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(62, 58)
        Me.pnl.TabIndex = 181
        '
        'StoneWeight3TextBox1
        '
        Me.StoneWeight3TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneWeight3TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "StoneWeight3", True))
        Me.StoneWeight3TextBox1.Location = New System.Drawing.Point(-64, 294)
        Me.StoneWeight3TextBox1.Name = "StoneWeight3TextBox1"
        Me.StoneWeight3TextBox1.Size = New System.Drawing.Size(20, 24)
        Me.StoneWeight3TextBox1.TabIndex = 203
        '
        'StoneName3TextBox1
        '
        Me.StoneName3TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneName3TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "StoneName3", True))
        Me.StoneName3TextBox1.Location = New System.Drawing.Point(-64, 270)
        Me.StoneName3TextBox1.Name = "StoneName3TextBox1"
        Me.StoneName3TextBox1.Size = New System.Drawing.Size(20, 24)
        Me.StoneName3TextBox1.TabIndex = 202
        '
        'StoneWeight2TextBox1
        '
        Me.StoneWeight2TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneWeight2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "StoneWeight2", True))
        Me.StoneWeight2TextBox1.Location = New System.Drawing.Point(-64, 246)
        Me.StoneWeight2TextBox1.Name = "StoneWeight2TextBox1"
        Me.StoneWeight2TextBox1.Size = New System.Drawing.Size(20, 24)
        Me.StoneWeight2TextBox1.TabIndex = 201
        '
        'StoneName2TextBox1
        '
        Me.StoneName2TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneName2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "StoneName2", True))
        Me.StoneName2TextBox1.Location = New System.Drawing.Point(-64, 222)
        Me.StoneName2TextBox1.Name = "StoneName2TextBox1"
        Me.StoneName2TextBox1.Size = New System.Drawing.Size(20, 24)
        Me.StoneName2TextBox1.TabIndex = 200
        '
        'StoneWeight3TextBox
        '
        Me.StoneWeight3TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneWeight3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "StoneWeight3", True))
        Me.StoneWeight3TextBox.Location = New System.Drawing.Point(-40, 294)
        Me.StoneWeight3TextBox.Name = "StoneWeight3TextBox"
        Me.StoneWeight3TextBox.Size = New System.Drawing.Size(20, 24)
        Me.StoneWeight3TextBox.TabIndex = 199
        '
        'StoneName3TextBox
        '
        Me.StoneName3TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneName3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "StoneName3", True))
        Me.StoneName3TextBox.Location = New System.Drawing.Point(-40, 270)
        Me.StoneName3TextBox.Name = "StoneName3TextBox"
        Me.StoneName3TextBox.Size = New System.Drawing.Size(20, 24)
        Me.StoneName3TextBox.TabIndex = 198
        '
        'StoneWeight2TextBox
        '
        Me.StoneWeight2TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneWeight2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "StoneWeight2", True))
        Me.StoneWeight2TextBox.Location = New System.Drawing.Point(-40, 246)
        Me.StoneWeight2TextBox.Name = "StoneWeight2TextBox"
        Me.StoneWeight2TextBox.Size = New System.Drawing.Size(20, 24)
        Me.StoneWeight2TextBox.TabIndex = 197
        '
        'StoneName2TextBox
        '
        Me.StoneName2TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StoneName2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "StoneName2", True))
        Me.StoneName2TextBox.Location = New System.Drawing.Point(-40, 222)
        Me.StoneName2TextBox.Name = "StoneName2TextBox"
        Me.StoneName2TextBox.Size = New System.Drawing.Size(20, 24)
        Me.StoneName2TextBox.TabIndex = 196
        '
        'BarCodeTextBox1
        '
        Me.BarCodeTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BarCodeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "BarCode", True))
        Me.BarCodeTextBox1.Location = New System.Drawing.Point(-64, 437)
        Me.BarCodeTextBox1.Name = "BarCodeTextBox1"
        Me.BarCodeTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.BarCodeTextBox1.TabIndex = 195
        '
        'BarCodeTextBox
        '
        Me.BarCodeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BarCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "BarCode", True))
        Me.BarCodeTextBox.Location = New System.Drawing.Point(-40, 438)
        Me.BarCodeTextBox.Name = "BarCodeTextBox"
        Me.BarCodeTextBox.Size = New System.Drawing.Size(20, 24)
        Me.BarCodeTextBox.TabIndex = 194
        '
        'FO_ItemNoTextBox1
        '
        Me.FO_ItemNoTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_ItemNoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood2BindingSource, "FO_ItemNo", True))
        Me.FO_ItemNoTextBox1.Location = New System.Drawing.Point(-64, 413)
        Me.FO_ItemNoTextBox1.Name = "FO_ItemNoTextBox1"
        Me.FO_ItemNoTextBox1.Size = New System.Drawing.Size(20, 24)
        Me.FO_ItemNoTextBox1.TabIndex = 193
        '
        'FO_ItemNoTextBox
        '
        Me.FO_ItemNoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FO_ItemNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Print_Parcood1BindingSource, "FO_ItemNo", True))
        Me.FO_ItemNoTextBox.Location = New System.Drawing.Point(-40, 414)
        Me.FO_ItemNoTextBox.Name = "FO_ItemNoTextBox"
        Me.FO_ItemNoTextBox.Size = New System.Drawing.Size(20, 24)
        Me.FO_ItemNoTextBox.TabIndex = 192
        '
        'SET_INVARCHR17TextBox
        '
        Me.SET_INVARCHR17TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR17TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR17", True))
        Me.SET_INVARCHR17TextBox.Location = New System.Drawing.Point(-112, 245)
        Me.SET_INVARCHR17TextBox.Name = "SET_INVARCHR17TextBox"
        Me.SET_INVARCHR17TextBox.Size = New System.Drawing.Size(20, 24)
        Me.SET_INVARCHR17TextBox.TabIndex = 155
        '
        'SettingsBindingSource
        '
        Me.SettingsBindingSource.DataMember = "Settings"
        Me.SettingsBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(-88, 270)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(20, 24)
        Me.ListView1.TabIndex = 190
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Tile
        '
        'ListView2
        '
        Me.ListView2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(-112, 269)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(20, 24)
        Me.ListView2.TabIndex = 191
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Tile
        '
        'SET_INVARCHR16TextBox
        '
        Me.SET_INVARCHR16TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR16TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR16", True))
        Me.SET_INVARCHR16TextBox.Location = New System.Drawing.Point(-112, 221)
        Me.SET_INVARCHR16TextBox.Name = "SET_INVARCHR16TextBox"
        Me.SET_INVARCHR16TextBox.Size = New System.Drawing.Size(20, 24)
        Me.SET_INVARCHR16TextBox.TabIndex = 154
        '
        'SET_INVARCHR15TextBox
        '
        Me.SET_INVARCHR15TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR15TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR15", True))
        Me.SET_INVARCHR15TextBox.Location = New System.Drawing.Point(-112, 197)
        Me.SET_INVARCHR15TextBox.Name = "SET_INVARCHR15TextBox"
        Me.SET_INVARCHR15TextBox.Size = New System.Drawing.Size(20, 24)
        Me.SET_INVARCHR15TextBox.TabIndex = 153
        '
        'SET_INVARCHR14TextBox
        '
        Me.SET_INVARCHR14TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR14TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR14", True))
        Me.SET_INVARCHR14TextBox.Location = New System.Drawing.Point(-112, 173)
        Me.SET_INVARCHR14TextBox.Name = "SET_INVARCHR14TextBox"
        Me.SET_INVARCHR14TextBox.Size = New System.Drawing.Size(20, 24)
        Me.SET_INVARCHR14TextBox.TabIndex = 152
        '
        'SET_INVARCHR13TextBox
        '
        Me.SET_INVARCHR13TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR13TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR13", True))
        Me.SET_INVARCHR13TextBox.Location = New System.Drawing.Point(-112, 149)
        Me.SET_INVARCHR13TextBox.Name = "SET_INVARCHR13TextBox"
        Me.SET_INVARCHR13TextBox.Size = New System.Drawing.Size(20, 24)
        Me.SET_INVARCHR13TextBox.TabIndex = 151
        '
        'SET_INVARCHR12TextBox
        '
        Me.SET_INVARCHR12TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR12TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR12", True))
        Me.SET_INVARCHR12TextBox.Location = New System.Drawing.Point(-112, 125)
        Me.SET_INVARCHR12TextBox.Name = "SET_INVARCHR12TextBox"
        Me.SET_INVARCHR12TextBox.Size = New System.Drawing.Size(20, 24)
        Me.SET_INVARCHR12TextBox.TabIndex = 150
        '
        'SET_INVARCHR11TextBox
        '
        Me.SET_INVARCHR11TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR11TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR11", True))
        Me.SET_INVARCHR11TextBox.Location = New System.Drawing.Point(-112, 101)
        Me.SET_INVARCHR11TextBox.Name = "SET_INVARCHR11TextBox"
        Me.SET_INVARCHR11TextBox.Size = New System.Drawing.Size(20, 24)
        Me.SET_INVARCHR11TextBox.TabIndex = 149
        '
        'SET_INVARCHR1TextBox
        '
        Me.SET_INVARCHR1TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR1", True))
        Me.SET_INVARCHR1TextBox.Location = New System.Drawing.Point(-112, 77)
        Me.SET_INVARCHR1TextBox.Name = "SET_INVARCHR1TextBox"
        Me.SET_INVARCHR1TextBox.Size = New System.Drawing.Size(20, 24)
        Me.SET_INVARCHR1TextBox.TabIndex = 148
        '
        'SET_INVARCHR128TextBox
        '
        Me.SET_INVARCHR128TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR128TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR128", True))
        Me.SET_INVARCHR128TextBox.Location = New System.Drawing.Point(-112, 53)
        Me.SET_INVARCHR128TextBox.Name = "SET_INVARCHR128TextBox"
        Me.SET_INVARCHR128TextBox.Size = New System.Drawing.Size(20, 24)
        Me.SET_INVARCHR128TextBox.TabIndex = 147
        '
        'SettingsTableAdapter
        '
        Me.SettingsTableAdapter.ClearBeforeFill = True
        '
        'chkPrintRange
        '
        Me.chkPrintRange.AutoSize = True
        Me.chkPrintRange.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkPrintRange.Location = New System.Drawing.Point(150, 42)
        Me.chkPrintRange.Name = "chkPrintRange"
        Me.chkPrintRange.Size = New System.Drawing.Size(96, 22)
        Me.chkPrintRange.TabIndex = 186
        Me.chkPrintRange.Text = "طباعة متتابعة"
        Me.chkPrintRange.UseVisualStyleBackColor = True
        '
        'cmbPrintRange
        '
        Me.cmbPrintRange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPrintRange.Enabled = False
        Me.cmbPrintRange.FormattingEnabled = True
        Me.cmbPrintRange.Location = New System.Drawing.Point(6, 42)
        Me.cmbPrintRange.Name = "cmbPrintRange"
        Me.cmbPrintRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbPrintRange.Size = New System.Drawing.Size(141, 23)
        Me.cmbPrintRange.TabIndex = 107
        '
        'lblPrintRangeEnd
        '
        Me.lblPrintRangeEnd.Location = New System.Drawing.Point(6, 20)
        Me.lblPrintRangeEnd.Name = "lblPrintRangeEnd"
        Me.lblPrintRangeEnd.Size = New System.Drawing.Size(141, 19)
        Me.lblPrintRangeEnd.TabIndex = 188
        Me.lblPrintRangeEnd.Text = "ينتهي عند"
        Me.lblPrintRangeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbFont
        '
        Me.gbFont.BackColor = System.Drawing.Color.Silver
        Me.gbFont.Controls.Add(Me.gbFontValue)
        Me.gbFont.Location = New System.Drawing.Point(383, 144)
        Me.gbFont.Name = "gbFont"
        Me.gbFont.Size = New System.Drawing.Size(234, 460)
        Me.gbFont.TabIndex = 6
        Me.gbFont.TabStop = False
        Me.gbFont.Text = "ضبط إعدادات حجم الخط"
        '
        'gbFontValue
        '
        Me.gbFontValue.BackColor = System.Drawing.Color.DarkGray
        Me.gbFontValue.Controls.Add(Me.btnDefaults)
        Me.gbFontValue.Controls.Add(Me.CompanyTextFontStyleTextBox)
        Me.gbFontValue.Controls.Add(Me.CompanyTextFontValueTextBox)
        Me.gbFontValue.Controls.Add(Me.Label80)
        Me.gbFontValue.Controls.Add(Me.Label84)
        Me.gbFontValue.Controls.Add(Me.DataTextFontStyleTextBox)
        Me.gbFontValue.Controls.Add(Me.DataTextFontValueTextBox)
        Me.gbFontValue.Controls.Add(Me.CountryFontStyleTextBox)
        Me.gbFontValue.Controls.Add(Me.CountryFontValueTextBox)
        Me.gbFontValue.Controls.Add(Me.BarCodeFontStyleTextBox)
        Me.gbFontValue.Controls.Add(Me.txtGOLDENSAP_D)
        Me.gbFontValue.Controls.Add(Me.BarCodeFontValueTextBox)
        Me.gbFontValue.Controls.Add(Me.txtGOLDENSAP_U)
        Me.gbFontValue.Controls.Add(Me.Label25)
        Me.gbFontValue.Controls.Add(Me.txtSAP_D)
        Me.gbFontValue.Controls.Add(Me.Label26)
        Me.gbFontValue.Controls.Add(Me.txtSAP_U)
        Me.gbFontValue.Controls.Add(Me.Label27)
        Me.gbFontValue.Controls.Add(Me.Label29)
        Me.gbFontValue.Location = New System.Drawing.Point(6, 25)
        Me.gbFontValue.Name = "gbFontValue"
        Me.gbFontValue.Size = New System.Drawing.Size(218, 429)
        Me.gbFontValue.TabIndex = 0
        Me.gbFontValue.TabStop = False
        Me.gbFontValue.Text = "القيم"
        '
        'btnDefaults
        '
        Me.btnDefaults.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefaults.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDefaults.ForeColor = System.Drawing.Color.Maroon
        Me.btnDefaults.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDefaults.Location = New System.Drawing.Point(18, 20)
        Me.btnDefaults.Name = "btnDefaults"
        Me.btnDefaults.Size = New System.Drawing.Size(183, 28)
        Me.btnDefaults.TabIndex = 0
        Me.btnDefaults.Text = "افتراضيات"
        Me.btnDefaults.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDefaults.UseVisualStyleBackColor = False
        '
        'CompanyTextFontStyleTextBox
        '
        Me.CompanyTextFontStyleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "CompanyTextFontStyle", True))
        Me.CompanyTextFontStyleTextBox.Location = New System.Drawing.Point(18, 64)
        Me.CompanyTextFontStyleTextBox.Name = "CompanyTextFontStyleTextBox"
        Me.CompanyTextFontStyleTextBox.Size = New System.Drawing.Size(40, 24)
        Me.CompanyTextFontStyleTextBox.TabIndex = 0
        Me.CompanyTextFontStyleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CompanyTextFontValueTextBox
        '
        Me.CompanyTextFontValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "CompanyTextFontValue", True))
        Me.CompanyTextFontValueTextBox.Location = New System.Drawing.Point(59, 64)
        Me.CompanyTextFontValueTextBox.Name = "CompanyTextFontValueTextBox"
        Me.CompanyTextFontValueTextBox.Size = New System.Drawing.Size(40, 24)
        Me.CompanyTextFontValueTextBox.TabIndex = 1
        Me.CompanyTextFontValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataTextFontStyleTextBox
        '
        Me.DataTextFontStyleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "DataTextFontStyle", True))
        Me.DataTextFontStyleTextBox.Location = New System.Drawing.Point(18, 136)
        Me.DataTextFontStyleTextBox.Name = "DataTextFontStyleTextBox"
        Me.DataTextFontStyleTextBox.Size = New System.Drawing.Size(40, 24)
        Me.DataTextFontStyleTextBox.TabIndex = 6
        Me.DataTextFontStyleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataTextFontValueTextBox
        '
        Me.DataTextFontValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "DataTextFontValue", True))
        Me.DataTextFontValueTextBox.Location = New System.Drawing.Point(59, 136)
        Me.DataTextFontValueTextBox.Name = "DataTextFontValueTextBox"
        Me.DataTextFontValueTextBox.Size = New System.Drawing.Size(40, 24)
        Me.DataTextFontValueTextBox.TabIndex = 7
        Me.DataTextFontValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CountryFontStyleTextBox
        '
        Me.CountryFontStyleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "CountryFontStyle", True))
        Me.CountryFontStyleTextBox.Location = New System.Drawing.Point(18, 88)
        Me.CountryFontStyleTextBox.Name = "CountryFontStyleTextBox"
        Me.CountryFontStyleTextBox.Size = New System.Drawing.Size(40, 24)
        Me.CountryFontStyleTextBox.TabIndex = 2
        Me.CountryFontStyleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CountryFontValueTextBox
        '
        Me.CountryFontValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "CountryFontValue", True))
        Me.CountryFontValueTextBox.Location = New System.Drawing.Point(59, 88)
        Me.CountryFontValueTextBox.Name = "CountryFontValueTextBox"
        Me.CountryFontValueTextBox.Size = New System.Drawing.Size(40, 24)
        Me.CountryFontValueTextBox.TabIndex = 3
        Me.CountryFontValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BarCodeFontStyleTextBox
        '
        Me.BarCodeFontStyleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "BarCodeFontStyle", True))
        Me.BarCodeFontStyleTextBox.Location = New System.Drawing.Point(18, 112)
        Me.BarCodeFontStyleTextBox.Name = "BarCodeFontStyleTextBox"
        Me.BarCodeFontStyleTextBox.Size = New System.Drawing.Size(40, 24)
        Me.BarCodeFontStyleTextBox.TabIndex = 4
        Me.BarCodeFontStyleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BarCodeFontValueTextBox
        '
        Me.BarCodeFontValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcoodBindingSource, "BarCodeFontValue", True))
        Me.BarCodeFontValueTextBox.Location = New System.Drawing.Point(59, 112)
        Me.BarCodeFontValueTextBox.Name = "BarCodeFontValueTextBox"
        Me.BarCodeFontValueTextBox.Size = New System.Drawing.Size(40, 24)
        Me.BarCodeFontValueTextBox.TabIndex = 5
        Me.BarCodeFontValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(104, 67)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(97, 19)
        Me.Label25.TabIndex = 69
        Me.Label25.Text = "خط المعرض"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(104, 139)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(97, 19)
        Me.Label26.TabIndex = 71
        Me.Label26.Text = "خط الكتابة"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(104, 91)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(97, 19)
        Me.Label27.TabIndex = 53
        Me.Label27.Text = "خط بلد المنشأ"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(104, 115)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(97, 19)
        Me.Label29.TabIndex = 55
        Me.Label29.Text = "خط الباركود"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbPrintRange
        '
        Me.gbPrintRange.Controls.Add(Me.chkPrintRange)
        Me.gbPrintRange.Controls.Add(Me.lblPrintRangeEnd)
        Me.gbPrintRange.Controls.Add(Me.cmbPrintRange)
        Me.gbPrintRange.Location = New System.Drawing.Point(461, 5)
        Me.gbPrintRange.Name = "gbPrintRange"
        Me.gbPrintRange.Size = New System.Drawing.Size(252, 78)
        Me.gbPrintRange.TabIndex = 189
        Me.gbPrintRange.TabStop = False
        Me.gbPrintRange.Text = "طباعة متتابعة"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(182, 23)
        Me.Label1.TabIndex = 190
        Me.Label1.Text = "اسم المعرض"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GoldBarCode
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(994, 611)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbPrintRange)
        Me.Controls.Add(Me.gbFont)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.gbLeft)
        Me.Controls.Add(Me.gbRight)
        Me.Controls.Add(Me.cmbPrinter)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbCompany)
        Me.Controls.Add(Me.btnPrint)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GoldBarCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "طباعة الباركود"
        CType(Me.Print_Parcood1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Print_Parcood1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Print_Parcood2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Print_Parcood2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompinformBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompdetelsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbRight.ResumeLayout(False)
        Me.gbRightText.ResumeLayout(False)
        Me.gbRightText.PerformLayout()
        CType(Me.CONFI_barcoodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHRightText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVRightText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRightValue.ResumeLayout(False)
        Me.gbRightValue.PerformLayout()
        CType(Me.pbHRightValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVRightValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONFI_barcoodDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLeft.ResumeLayout(False)
        Me.gbLeftText.ResumeLayout(False)
        Me.gbLeftText.PerformLayout()
        CType(Me.pbHLeftText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVLeftText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLeftValue.ResumeLayout(False)
        Me.gbLeftValue.PerformLayout()
        CType(Me.pbHLeftValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVLeftValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFont.ResumeLayout(False)
        Me.gbFontValue.ResumeLayout(False)
        Me.gbFontValue.PerformLayout()
        Me.gbPrintRange.ResumeLayout(False)
        Me.gbPrintRange.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbRightItem As System.Windows.Forms.ComboBox
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents Print_Parcood1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Print_Parcood1TableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Print_Parcood1TableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Print_Parcood1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Print_Parcood2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Print_Parcood2TableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.Print_Parcood2TableAdapter
    Friend WithEvents Print_Parcood2DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbLeftItem As System.Windows.Forms.ComboBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Gram_valuTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FO_totalPriceTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FO_GramPriceTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents UserIDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FO_priceTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FO_extrasTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FO_madeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FO_gramMadeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FO_gramTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FO_despTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FO_nameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Gram_valuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FO_totalPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FO_GramPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FO_priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FO_extrasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FO_madeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FO_gramMadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FO_gramTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FO_despTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FO_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents CompdetelsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Comp_detelsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.comp_detelsTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents cmbPrinter As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents gbRight As System.Windows.Forms.GroupBox
    Friend WithEvents CONFI_barcoodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONFI_barcoodTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.CONFI_barcoodTableAdapter
    Friend WithEvents L_S_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_S_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_FO_extrasTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_FO_extrasTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_C_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_C_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_Gram_valuTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_Gram_valuTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_FO_gramMadeTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_FO_gramMadeTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_M_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_M_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_W_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_W_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_FO_gramTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_FO_gramTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_ComboBox3_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_ComboBox3_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_font_IDTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_font_IDTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_FO_madeTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_FO_madeTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_IDTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_IDTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CONFI_barcoodDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn82 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSAP_U As System.Windows.Forms.TextBox
    Friend WithEvents txtSAP_D As System.Windows.Forms.TextBox
    Friend WithEvents txtGOLDENSAP_U As System.Windows.Forms.TextBox
    Friend WithEvents txtGOLDENSAP_D As System.Windows.Forms.TextBox
    Friend WithEvents Tel_uTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tel_dTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents print_set As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn73 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn74 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn75 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn76 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn77 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn78 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn79 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn80 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn81 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents print As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Print_setTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gbLeft As System.Windows.Forms.GroupBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents CompinformBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Comp_informTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.comp_informTableAdapter
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents txtBarCodeRight As System.Windows.Forms.TextBox
    Friend WithEvents txtBarCodeLeft As System.Windows.Forms.TextBox
    Friend WithEvents pbHLeftValue As System.Windows.Forms.PictureBox
    Friend WithEvents pbVLeftValue As System.Windows.Forms.PictureBox
    Friend WithEvents pbHRightText As System.Windows.Forms.PictureBox
    Friend WithEvents pbHRightValue As System.Windows.Forms.PictureBox
    Friend WithEvents pbVRightText As System.Windows.Forms.PictureBox
    Friend WithEvents pbVRightValue As System.Windows.Forms.PictureBox
    Friend WithEvents gbLeftValue As System.Windows.Forms.GroupBox
    Friend WithEvents pbHLeftText As System.Windows.Forms.PictureBox
    Friend WithEvents pbVLeftText As System.Windows.Forms.PictureBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents R_IDTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_IDTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_FO_madeTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_FO_madeTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_FO_extrasTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_FO_extrasTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_font_IDTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_font_IDTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_ComboBox3_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_C_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_ComboBox3_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_C_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_FO_gramTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_FO_gramTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_Gram_valuTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_S_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_Gram_valuTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_S_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_W_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_W_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_M_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_M_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_FO_gramMadeTextBox_DTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_FO_gramMadeTextBox_UTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gbLeftText As System.Windows.Forms.GroupBox
    Friend WithEvents gbRightText As System.Windows.Forms.GroupBox
    Friend WithEvents gbRightValue As System.Windows.Forms.GroupBox
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents L_FO_CountryTextBox_UTextBox As TextBox
    Friend WithEvents L_FO_CountryTextBox_DTextBox As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents R_FO_CountryTextBox_DTextBox As TextBox
    Friend WithEvents R_FO_CountryTextBox_UTextBox As TextBox
    Friend WithEvents pnl As Panel
    Friend WithEvents SettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SettingsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents SET_INVARCHR128TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR12TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR11TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR14TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR13TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR17TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR16TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR15TextBox As System.Windows.Forms.TextBox
    Friend WithEvents chkPrintRange As System.Windows.Forms.CheckBox
    Friend WithEvents cmbPrintRange As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrintRangeEnd As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbFont As System.Windows.Forms.GroupBox
    Friend WithEvents gbFontValue As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents BarCodeFontStyleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BarCodeFontValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyTextFontStyleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyTextFontValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataTextFontStyleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataTextFontValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryFontStyleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryFontValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnDefaults As System.Windows.Forms.Button
    Friend WithEvents R_CodeText_UTextBox As TextBox
    Friend WithEvents R_CodeText_DTextBox As TextBox
    Friend WithEvents R_CodeValue_UTextBox As TextBox
    Friend WithEvents R_CodeValue_DTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents L_CodeText_UTextBox As TextBox
    Friend WithEvents L_CodeText_DTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents L_CodeValue_UTextBox As TextBox
    Friend WithEvents L_CodeValue_DTextBox As TextBox
    Friend WithEvents FO_ItemNoTextBox1 As TextBox
    Friend WithEvents FO_ItemNoTextBox As TextBox
    Friend WithEvents gbPrintRange As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BarCodeTextBox1 As TextBox
    Friend WithEvents BarCodeTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents R_Stone3Value_UTextBox As TextBox
    Friend WithEvents R_Stone3Value_DTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents R_Stone2Value_UTextBox As TextBox
    Friend WithEvents R_Stone2Value_DTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents R_Stone3Text_UTextBox As TextBox
    Friend WithEvents R_Stone3Text_DTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents R_Stone2Text_UTextBox As TextBox
    Friend WithEvents R_Stone2Text_DTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents L_Stone3Text_UTextBox As TextBox
    Friend WithEvents L_Stone3Text_DTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents L_Stone2Text_UTextBox As TextBox
    Friend WithEvents L_Stone2Text_DTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents L_Stone3Value_UTextBox As TextBox
    Friend WithEvents L_Stone3Value_DTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents L_Stone2Value_UTextBox As TextBox
    Friend WithEvents L_Stone2Value_DTextBox As TextBox
    Friend WithEvents StoneWeight3TextBox1 As TextBox
    Friend WithEvents StoneName3TextBox1 As TextBox
    Friend WithEvents StoneWeight2TextBox1 As TextBox
    Friend WithEvents StoneName2TextBox1 As TextBox
    Friend WithEvents StoneWeight3TextBox As TextBox
    Friend WithEvents StoneName3TextBox As TextBox
    Friend WithEvents StoneWeight2TextBox As TextBox
    Friend WithEvents StoneName2TextBox As TextBox
End Class
