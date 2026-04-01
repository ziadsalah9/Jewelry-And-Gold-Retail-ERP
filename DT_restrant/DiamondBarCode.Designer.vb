<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiamondBarCode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Print_nameLabel As System.Windows.Forms.Label
        Dim Program_nameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiamondBarCode))
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.DIMON_BARICOOD_LEFTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DIMON_BARICOOD_LEFTTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.DIMON_BARICOOD_LEFTTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.CONFI_barcood_dimonTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.CONFI_barcood_dimonTableAdapter()
        Me.DIMON_BARICOOD_RIGHTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DIMON_BARICOOD_RIGHTTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.DIMON_BARICOOD_RIGHTTableAdapter()
        Me.CONFI_barcood_dimonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Size_idTextBox = New System.Windows.Forms.TextBox()
        Me.DIMOND_ID_leftTextBox = New System.Windows.Forms.TextBox()
        Me.DIMO_dep_leftTextBox = New System.Windows.Forms.TextBox()
        Me.DIM_na9awa_leftTextBox = New System.Windows.Forms.TextBox()
        Me.DIMO_mezan_leftTextBox = New System.Windows.Forms.TextBox()
        Me.Ext_coler_leftTextBox = New System.Windows.Forms.TextBox()
        Me.Qult_leftTextBox = New System.Windows.Forms.TextBox()
        Me.Sarual_leftTextBox = New System.Windows.Forms.TextBox()
        Me.Val_gold_leftTextBox = New System.Windows.Forms.TextBox()
        Me.GOLD_mezan_leftTextBox = New System.Windows.Forms.TextBox()
        Me.Test_1_leftTextBox = New System.Windows.Forms.TextBox()
        Me.DIMOND_ID_rightTextBox = New System.Windows.Forms.TextBox()
        Me.DIMO_dep_rightTextBox = New System.Windows.Forms.TextBox()
        Me.DIM_na9awa_rightTextBox = New System.Windows.Forms.TextBox()
        Me.DIMO_mezan_rightTextBox = New System.Windows.Forms.TextBox()
        Me.Ext_coler_rightTextBox = New System.Windows.Forms.TextBox()
        Me.Qult_rightTextBox = New System.Windows.Forms.TextBox()
        Me.Sarual_rightTextBox = New System.Windows.Forms.TextBox()
        Me.Val_gold_rightTextBox = New System.Windows.Forms.TextBox()
        Me.GOLD_mezan_rightTextBox = New System.Windows.Forms.TextBox()
        Me.Print_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Program_nameTextBox = New System.Windows.Forms.TextBox()
        Me.TelTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.Note2TextBox = New System.Windows.Forms.TextBox()
        Me.DIMOND_ID_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.DIMO_dep_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.DIM_na9awa_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.DIMO_mezan_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Ext_coler_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Qult_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Sarual_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Val_gold_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.GOLD_mezan_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_1_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.DIMOND_ID_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.DIMO_dep_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.DIM_na9awa_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.DIMO_mezan_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Ext_coler_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Qult_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Sarual_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Val_gold_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.GOLD_mezan_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_1_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.gbRight = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbRightText = New System.Windows.Forms.GroupBox()
        Me.RightTextLRStoneWeight3 = New System.Windows.Forms.TextBox()
        Me.RightTextUDStoneWeight3 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.RightTextLRStoneName3 = New System.Windows.Forms.TextBox()
        Me.RightTextUDStoneName3 = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.RightTextLRStoneWeight2 = New System.Windows.Forms.TextBox()
        Me.RightTextUDStoneWeight2 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.RightTextLRStoneName2 = New System.Windows.Forms.TextBox()
        Me.RightTextUDStoneName2 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.RightTextLRStoneWeight1 = New System.Windows.Forms.TextBox()
        Me.RightTextUDStoneWeight1 = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.RightTextLRStoneName1 = New System.Windows.Forms.TextBox()
        Me.RightTextUDStoneName1 = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Note1upTextBox = New System.Windows.Forms.TextBox()
        Me.Note21upTextBox = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.pbHRightText = New System.Windows.Forms.PictureBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pbVRightText = New System.Windows.Forms.PictureBox()
        Me.Test_111_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_112_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_113_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_114_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_115_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_116_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_11_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_117_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_118_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_11_rightTextBox = New System.Windows.Forms.TextBox()
        Me.Test_119_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Test_111_left1upTextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_16_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_15_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_14_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_13_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_12_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_11_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.gbRightValue = New System.Windows.Forms.GroupBox()
        Me.TotalStoneWeight_RightupTextBox = New System.Windows.Forms.TextBox()
        Me.TotalStoneWeight_Right1upTextBox = New System.Windows.Forms.TextBox()
        Me.lblTotalStoneWeightRight = New System.Windows.Forms.Label()
        Me.lblCut3Right = New System.Windows.Forms.Label()
        Me.Cut3_Right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Cut3_RightupTextBox = New System.Windows.Forms.TextBox()
        Me.lblCut2Right = New System.Windows.Forms.Label()
        Me.Cut2_Right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Cut2_RightupTextBox = New System.Windows.Forms.TextBox()
        Me.Cut1_RightupTextBox = New System.Windows.Forms.TextBox()
        Me.Cut1_Right1upTextBox = New System.Windows.Forms.TextBox()
        Me.lblCut1Right = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Code_Right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Code_RightupTextBox = New System.Windows.Forms.TextBox()
        Me.RightValueUDStoneWeight3 = New System.Windows.Forms.TextBox()
        Me.RightValueLRStoneWeight3 = New System.Windows.Forms.TextBox()
        Me.RightValueUDStoneName3 = New System.Windows.Forms.TextBox()
        Me.RightValueLRStoneName3 = New System.Windows.Forms.TextBox()
        Me.RightValueUDStoneWeight2 = New System.Windows.Forms.TextBox()
        Me.RightValueLRStoneWeight2 = New System.Windows.Forms.TextBox()
        Me.RightValueUDStoneName2 = New System.Windows.Forms.TextBox()
        Me.RightValueLRStoneName2 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.RightValueUDStoneWeight1 = New System.Windows.Forms.TextBox()
        Me.RightValueLRStoneWeight1 = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.RightValueUDStoneName1 = New System.Windows.Forms.TextBox()
        Me.RightValueLRStoneName1 = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbHRightValue = New System.Windows.Forms.PictureBox()
        Me.pbVRightValue = New System.Windows.Forms.PictureBox()
        Me.Test_12_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.gbLeft = New System.Windows.Forms.GroupBox()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.gbLeftText = New System.Windows.Forms.GroupBox()
        Me.LeftTextLRStoneWeight3 = New System.Windows.Forms.TextBox()
        Me.LeftTextUDStoneWeight3 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.LeftTextLRStoneName3 = New System.Windows.Forms.TextBox()
        Me.LeftTextUDStoneName3 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LeftTextLRStoneWeight2 = New System.Windows.Forms.TextBox()
        Me.LeftTextUDStoneWeight2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LeftTextLRStoneName2 = New System.Windows.Forms.TextBox()
        Me.LeftTextUDStoneName2 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.LeftTextLRStoneWeight1 = New System.Windows.Forms.TextBox()
        Me.LeftTextUDStoneWeight1 = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.LeftTextLRStoneName1 = New System.Windows.Forms.TextBox()
        Me.LeftTextUDStoneName1 = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.pbHLeftText = New System.Windows.Forms.PictureBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.pbVLeftText = New System.Windows.Forms.PictureBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Note2TextBox1 = New System.Windows.Forms.TextBox()
        Me.NoteTextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_12_leftTextBox = New System.Windows.Forms.TextBox()
        Me.Test_1_rightTextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_119_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_13_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_14_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_15_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_16_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_17_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_18_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_19_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_110_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_112_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_113_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_114_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_115_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_116_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_117_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Test_118_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SET1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbLeftValue = New System.Windows.Forms.GroupBox()
        Me.TotalStoneWeight_LeftupTextBox = New System.Windows.Forms.TextBox()
        Me.TotalStoneWeight_Left1upTextBox = New System.Windows.Forms.TextBox()
        Me.lblTotalStoneWeightLeft = New System.Windows.Forms.Label()
        Me.lblCut3Left = New System.Windows.Forms.Label()
        Me.Cut3_Left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Cut3_LeftupTextBox = New System.Windows.Forms.TextBox()
        Me.lblCut2Left = New System.Windows.Forms.Label()
        Me.Cut2_Left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Cut2_LeftupTextBox = New System.Windows.Forms.TextBox()
        Me.Cut1_LeftupTextBox = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Cut1_Left1upTextBox = New System.Windows.Forms.TextBox()
        Me.Code_Left1upTextBox = New System.Windows.Forms.TextBox()
        Me.lblCut1Left = New System.Windows.Forms.Label()
        Me.Code_LeftupTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LeftValueUDStoneWeight3 = New System.Windows.Forms.TextBox()
        Me.LeftValueLRStoneWeight3 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LeftValueUDStoneName3 = New System.Windows.Forms.TextBox()
        Me.LeftValueLRStoneName3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LeftValueUDStoneWeight2 = New System.Windows.Forms.TextBox()
        Me.LeftValueLRStoneWeight2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LeftValueUDStoneName2 = New System.Windows.Forms.TextBox()
        Me.LeftValueLRStoneName2 = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.LeftValueUDStoneWeight1 = New System.Windows.Forms.TextBox()
        Me.LeftValueLRStoneWeight1 = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.LeftValueUDStoneName1 = New System.Windows.Forms.TextBox()
        Me.LeftValueLRStoneName1 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbHLeftValue = New System.Windows.Forms.PictureBox()
        Me.pbVLeftValue = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cmbCompanyName = New System.Windows.Forms.ComboBox()
        Me.CompinformBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Comp_informTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.comp_informTableAdapter()
        Me.cmbPrinterName = New System.Windows.Forms.ComboBox()
        Me.cmbLeftItem = New System.Windows.Forms.ComboBox()
        Me.DIMONBARICOODFORSELECTLEFTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbRightItem = New System.Windows.Forms.ComboBox()
        Me.DIMONBARICOODSELECTRIGHTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DIMON_BARICOOD_FOR_SELECT_LEFTTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.DIMON_BARICOOD_FOR_SELECT_LEFTTableAdapter()
        Me.DIMON_BARICOOD_SELECT_RIGHTTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.DIMON_BARICOOD_SELECT_RIGHTTableAdapter()
        Me.DIMOND_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DIMON_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.DIM_na9awaTextBox = New System.Windows.Forms.TextBox()
        Me.DIMO_mezanTextBox = New System.Windows.Forms.TextBox()
        Me.Ext_colerTextBox = New System.Windows.Forms.TextBox()
        Me.QultTextBox = New System.Windows.Forms.TextBox()
        Me.SarualTextBox = New System.Windows.Forms.TextBox()
        Me.Val_goldTextBox = New System.Windows.Forms.TextBox()
        Me.GOLD_mezanTextBox = New System.Windows.Forms.TextBox()
        Me.Test_1TextBox = New System.Windows.Forms.TextBox()
        Me.Test_11TextBox = New System.Windows.Forms.TextBox()
        Me.Test_12TextBox = New System.Windows.Forms.TextBox()
        Me.Test_13TextBox = New System.Windows.Forms.TextBox()
        Me.Test_14TextBox = New System.Windows.Forms.TextBox()
        Me.Test_15TextBox = New System.Windows.Forms.TextBox()
        Me.Test_16TextBox = New System.Windows.Forms.TextBox()
        Me.Test_17TextBox = New System.Windows.Forms.TextBox()
        Me.Test_18TextBox = New System.Windows.Forms.TextBox()
        Me.Test_19TextBox = New System.Windows.Forms.TextBox()
        Me.Test_110TextBox = New System.Windows.Forms.TextBox()
        Me.Test_111TextBox = New System.Windows.Forms.TextBox()
        Me.Test_112TextBox = New System.Windows.Forms.TextBox()
        Me.Test_113TextBox = New System.Windows.Forms.TextBox()
        Me.Test_114TextBox = New System.Windows.Forms.TextBox()
        Me.Test_115TextBox = New System.Windows.Forms.TextBox()
        Me.Test_116TextBox = New System.Windows.Forms.TextBox()
        Me.Test_117TextBox = New System.Windows.Forms.TextBox()
        Me.Test_118TextBox = New System.Windows.Forms.TextBox()
        Me.Test_119TextBox = New System.Windows.Forms.TextBox()
        Me.DIMOND_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.DIMON_NAMETextBox1 = New System.Windows.Forms.TextBox()
        Me.DIM_na9awaTextBox1 = New System.Windows.Forms.TextBox()
        Me.DIMO_mezanTextBox1 = New System.Windows.Forms.TextBox()
        Me.Ext_colerTextBox1 = New System.Windows.Forms.TextBox()
        Me.QultTextBox1 = New System.Windows.Forms.TextBox()
        Me.SarualTextBox1 = New System.Windows.Forms.TextBox()
        Me.Val_goldTextBox1 = New System.Windows.Forms.TextBox()
        Me.GOLD_mezanTextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_1TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_11TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_12TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_14TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_15TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_16TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_17TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_19TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_110TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_111TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_112TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_113TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_114TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_115TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_116TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_117TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_118TextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_119TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Test_111_left1upTextBox = New System.Windows.Forms.TextBox()
        Me.SettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SettingsTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter()
        Me.SET_INVARCHR115TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR116TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR117TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR118TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR119TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR120TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR121TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR122TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR123TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR124TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR125TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR126TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR127TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR127Text = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR126Text = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR125Text = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR124Text = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR123Text = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR122Text = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR121Text = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR120Text = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR119Text = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR118Text = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR117Text = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR116Text = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR115Text = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR113TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR113Text = New System.Windows.Forms.TextBox()
        Me.Test_17_left1upTextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_18_left1upTextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_19_left1upTextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_110_left1upTextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_112_left1upTextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_113_left1upTextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_114_left1upTextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_115_left1upTextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_116_left1upTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Test_17_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Program_nameTextBox2 = New System.Windows.Forms.TextBox()
        Me.Tel1upTextBox = New System.Windows.Forms.TextBox()
        Me.Program_name1upTextBox = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Test_110_right1upTextBox = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.TelTextBox1 = New System.Windows.Forms.TextBox()
        Me.Test_119_rightTextBox = New System.Windows.Forms.TextBox()
        Me.Test_118_rightTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtBarCodeLeft = New System.Windows.Forms.TextBox()
        Me.txtBarCodeRight = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.SET1TextBox = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.IsDiamond3CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.IsDiamond2CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.IsDiamond1CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Clarity3TextBox1 = New System.Windows.Forms.TextBox()
        Me.Cut3TextBox1 = New System.Windows.Forms.TextBox()
        Me.Clarity2TextBox1 = New System.Windows.Forms.TextBox()
        Me.Cut2TextBox1 = New System.Windows.Forms.TextBox()
        Me.Clarity1TextBox1 = New System.Windows.Forms.TextBox()
        Me.Cut1TextBox1 = New System.Windows.Forms.TextBox()
        Me.IsDiamond3CheckBox = New System.Windows.Forms.CheckBox()
        Me.IsDiamond2CheckBox = New System.Windows.Forms.CheckBox()
        Me.IsDiamond1CheckBox = New System.Windows.Forms.CheckBox()
        Me.Clarity3TextBox = New System.Windows.Forms.TextBox()
        Me.Cut3TextBox = New System.Windows.Forms.TextBox()
        Me.Clarity2TextBox = New System.Windows.Forms.TextBox()
        Me.Cut2TextBox = New System.Windows.Forms.TextBox()
        Me.Clarity1TextBox = New System.Windows.Forms.TextBox()
        Me.Cut1TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR18TextBox = New System.Windows.Forms.TextBox()
        Me.Test_18TextBox1 = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR145TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR130TextBox = New System.Windows.Forms.TextBox()
        Me.Test_13TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtStoneStyle = New System.Windows.Forms.TextBox()
        Me.txtStoneSize = New System.Windows.Forms.TextBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.txtBarCodeStyle = New System.Windows.Forms.TextBox()
        Me.txtBarCodeSize = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.txtCompanyStyle = New System.Windows.Forms.TextBox()
        Me.txtCompanySize = New System.Windows.Forms.TextBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.txtFontStyle = New System.Windows.Forms.TextBox()
        Me.txtFontSize = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.lblPrintRangeEnd = New System.Windows.Forms.Label()
        Me.cmbPrintRange = New System.Windows.Forms.ComboBox()
        Me.chkPrintRange = New System.Windows.Forms.CheckBox()
        Me.SET_INVARCHR110TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR111TextBox = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.btnDefaults = New System.Windows.Forms.Button()
        Me.gbPrintRange = New System.Windows.Forms.GroupBox()
        Me.gbGeneral = New System.Windows.Forms.GroupBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.SET_INVARCHR172TextBox = New System.Windows.Forms.TextBox()
        Me.SET_INVARCHR171TextBox = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Print_nameLabel = New System.Windows.Forms.Label()
        Program_nameLabel = New System.Windows.Forms.Label()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIMON_BARICOOD_LEFTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIMON_BARICOOD_RIGHTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONFI_barcood_dimonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRight.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbRightText.SuspendLayout()
        CType(Me.pbHRightText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVRightText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRightValue.SuspendLayout()
        CType(Me.pbHRightValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVRightValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLeft.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.gbLeftText.SuspendLayout()
        CType(Me.pbHLeftText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVLeftText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLeftValue.SuspendLayout()
        CType(Me.pbHLeftValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVLeftValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompinformBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIMONBARICOODFORSELECTLEFTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DIMONBARICOODSELECTRIGHTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.gbPrintRange.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'Print_nameLabel
        '
        Print_nameLabel.Location = New System.Drawing.Point(0, 0)
        Print_nameLabel.Name = "Print_nameLabel"
        Print_nameLabel.Size = New System.Drawing.Size(100, 23)
        Print_nameLabel.TabIndex = 447
        '
        'Program_nameLabel
        '
        Program_nameLabel.Location = New System.Drawing.Point(0, 0)
        Program_nameLabel.Name = "Program_nameLabel"
        Program_nameLabel.Size = New System.Drawing.Size(100, 23)
        Program_nameLabel.TabIndex = 448
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DIMON_BARICOOD_LEFTBindingSource
        '
        Me.DIMON_BARICOOD_LEFTBindingSource.DataMember = "DIMON_BARICOOD_LEFT"
        Me.DIMON_BARICOOD_LEFTBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DIMON_BARICOOD_LEFTTableAdapter
        '
        Me.DIMON_BARICOOD_LEFTTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.CONFI_barcood_dimonTableAdapter = Me.CONFI_barcood_dimonTableAdapter
        Me.TableAdapterManager.CONFI_barcoodTableAdapter = Nothing
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
        'CONFI_barcood_dimonTableAdapter
        '
        Me.CONFI_barcood_dimonTableAdapter.ClearBeforeFill = True
        '
        'DIMON_BARICOOD_RIGHTBindingSource
        '
        Me.DIMON_BARICOOD_RIGHTBindingSource.DataMember = "DIMON_BARICOOD_RIGHT"
        Me.DIMON_BARICOOD_RIGHTBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DIMON_BARICOOD_RIGHTTableAdapter
        '
        Me.DIMON_BARICOOD_RIGHTTableAdapter.ClearBeforeFill = True
        '
        'CONFI_barcood_dimonBindingSource
        '
        Me.CONFI_barcood_dimonBindingSource.DataMember = "CONFI_barcood_dimon"
        Me.CONFI_barcood_dimonBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'Size_idTextBox
        '
        Me.Size_idTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Size_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "size_id", True))
        Me.Size_idTextBox.Location = New System.Drawing.Point(-442, 126)
        Me.Size_idTextBox.Name = "Size_idTextBox"
        Me.Size_idTextBox.Size = New System.Drawing.Size(38, 21)
        Me.Size_idTextBox.TabIndex = 5
        '
        'DIMOND_ID_leftTextBox
        '
        Me.DIMOND_ID_leftTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.DIMOND_ID_leftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIMOND_ID_left", True))
        Me.DIMOND_ID_leftTextBox.Location = New System.Drawing.Point(10, 91)
        Me.DIMOND_ID_leftTextBox.Name = "DIMOND_ID_leftTextBox"
        Me.DIMOND_ID_leftTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMOND_ID_leftTextBox.TabIndex = 0
        Me.DIMOND_ID_leftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIMO_dep_leftTextBox
        '
        Me.DIMO_dep_leftTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.DIMO_dep_leftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIMO_dep_left", True))
        Me.DIMO_dep_leftTextBox.Location = New System.Drawing.Point(10, 91)
        Me.DIMO_dep_leftTextBox.Name = "DIMO_dep_leftTextBox"
        Me.DIMO_dep_leftTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMO_dep_leftTextBox.TabIndex = 2
        Me.DIMO_dep_leftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIM_na9awa_leftTextBox
        '
        Me.DIM_na9awa_leftTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.DIM_na9awa_leftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIM_na9awa_left", True))
        Me.DIM_na9awa_leftTextBox.Location = New System.Drawing.Point(10, 217)
        Me.DIM_na9awa_leftTextBox.Name = "DIM_na9awa_leftTextBox"
        Me.DIM_na9awa_leftTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIM_na9awa_leftTextBox.TabIndex = 12
        Me.DIM_na9awa_leftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIMO_mezan_leftTextBox
        '
        Me.DIMO_mezan_leftTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.DIMO_mezan_leftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIMO_mezan_left", True))
        Me.DIMO_mezan_leftTextBox.Location = New System.Drawing.Point(10, 196)
        Me.DIMO_mezan_leftTextBox.Name = "DIMO_mezan_leftTextBox"
        Me.DIMO_mezan_leftTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMO_mezan_leftTextBox.TabIndex = 10
        Me.DIMO_mezan_leftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ext_coler_leftTextBox
        '
        Me.Ext_coler_leftTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Ext_coler_leftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "ext_coler_left", True))
        Me.Ext_coler_leftTextBox.Location = New System.Drawing.Point(10, 175)
        Me.Ext_coler_leftTextBox.Name = "Ext_coler_leftTextBox"
        Me.Ext_coler_leftTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Ext_coler_leftTextBox.TabIndex = 8
        Me.Ext_coler_leftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Qult_leftTextBox
        '
        Me.Qult_leftTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Qult_leftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "qult_left", True))
        Me.Qult_leftTextBox.Location = New System.Drawing.Point(10, 133)
        Me.Qult_leftTextBox.Name = "Qult_leftTextBox"
        Me.Qult_leftTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Qult_leftTextBox.TabIndex = 4
        Me.Qult_leftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sarual_leftTextBox
        '
        Me.Sarual_leftTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Sarual_leftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "sarual_left", True))
        Me.Sarual_leftTextBox.Location = New System.Drawing.Point(10, 469)
        Me.Sarual_leftTextBox.Name = "Sarual_leftTextBox"
        Me.Sarual_leftTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Sarual_leftTextBox.TabIndex = 16
        Me.Sarual_leftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Val_gold_leftTextBox
        '
        Me.Val_gold_leftTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Val_gold_leftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "val_gold_left", True))
        Me.Val_gold_leftTextBox.Location = New System.Drawing.Point(10, 154)
        Me.Val_gold_leftTextBox.Name = "Val_gold_leftTextBox"
        Me.Val_gold_leftTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Val_gold_leftTextBox.TabIndex = 6
        Me.Val_gold_leftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GOLD_mezan_leftTextBox
        '
        Me.GOLD_mezan_leftTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.GOLD_mezan_leftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "GOLD_mezan_left", True))
        Me.GOLD_mezan_leftTextBox.Location = New System.Drawing.Point(10, 238)
        Me.GOLD_mezan_leftTextBox.Name = "GOLD_mezan_leftTextBox"
        Me.GOLD_mezan_leftTextBox.Size = New System.Drawing.Size(35, 21)
        Me.GOLD_mezan_leftTextBox.TabIndex = 14
        Me.GOLD_mezan_leftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_1_leftTextBox
        '
        Me.Test_1_leftTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Test_1_leftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_1_left", True))
        Me.Test_1_leftTextBox.Location = New System.Drawing.Point(10, 112)
        Me.Test_1_leftTextBox.Name = "Test_1_leftTextBox"
        Me.Test_1_leftTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_1_leftTextBox.TabIndex = 2
        Me.Test_1_leftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIMOND_ID_rightTextBox
        '
        Me.DIMOND_ID_rightTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.DIMOND_ID_rightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIMOND_ID_right", True))
        Me.DIMOND_ID_rightTextBox.Location = New System.Drawing.Point(41, 58)
        Me.DIMOND_ID_rightTextBox.Name = "DIMOND_ID_rightTextBox"
        Me.DIMOND_ID_rightTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMOND_ID_rightTextBox.TabIndex = 0
        Me.DIMOND_ID_rightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIMO_dep_rightTextBox
        '
        Me.DIMO_dep_rightTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.DIMO_dep_rightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIMO_dep_right", True))
        Me.DIMO_dep_rightTextBox.Location = New System.Drawing.Point(44, 77)
        Me.DIMO_dep_rightTextBox.Name = "DIMO_dep_rightTextBox"
        Me.DIMO_dep_rightTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMO_dep_rightTextBox.TabIndex = 2
        Me.DIMO_dep_rightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIM_na9awa_rightTextBox
        '
        Me.DIM_na9awa_rightTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.DIM_na9awa_rightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIM_na9awa_right", True))
        Me.DIM_na9awa_rightTextBox.Location = New System.Drawing.Point(41, 184)
        Me.DIM_na9awa_rightTextBox.Name = "DIM_na9awa_rightTextBox"
        Me.DIM_na9awa_rightTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIM_na9awa_rightTextBox.TabIndex = 12
        Me.DIM_na9awa_rightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIMO_mezan_rightTextBox
        '
        Me.DIMO_mezan_rightTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.DIMO_mezan_rightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIMO_mezan_right", True))
        Me.DIMO_mezan_rightTextBox.Location = New System.Drawing.Point(41, 163)
        Me.DIMO_mezan_rightTextBox.Name = "DIMO_mezan_rightTextBox"
        Me.DIMO_mezan_rightTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMO_mezan_rightTextBox.TabIndex = 10
        Me.DIMO_mezan_rightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ext_coler_rightTextBox
        '
        Me.Ext_coler_rightTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Ext_coler_rightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "ext_coler_right", True))
        Me.Ext_coler_rightTextBox.Location = New System.Drawing.Point(41, 142)
        Me.Ext_coler_rightTextBox.Name = "Ext_coler_rightTextBox"
        Me.Ext_coler_rightTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Ext_coler_rightTextBox.TabIndex = 8
        Me.Ext_coler_rightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Qult_rightTextBox
        '
        Me.Qult_rightTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Qult_rightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "qult_right", True))
        Me.Qult_rightTextBox.Location = New System.Drawing.Point(41, 100)
        Me.Qult_rightTextBox.Name = "Qult_rightTextBox"
        Me.Qult_rightTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Qult_rightTextBox.TabIndex = 4
        Me.Qult_rightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sarual_rightTextBox
        '
        Me.Sarual_rightTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Sarual_rightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "sarual_right", True))
        Me.Sarual_rightTextBox.Location = New System.Drawing.Point(41, 436)
        Me.Sarual_rightTextBox.Name = "Sarual_rightTextBox"
        Me.Sarual_rightTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Sarual_rightTextBox.TabIndex = 16
        Me.Sarual_rightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Val_gold_rightTextBox
        '
        Me.Val_gold_rightTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Val_gold_rightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "val_gold_right", True))
        Me.Val_gold_rightTextBox.Location = New System.Drawing.Point(41, 121)
        Me.Val_gold_rightTextBox.Name = "Val_gold_rightTextBox"
        Me.Val_gold_rightTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Val_gold_rightTextBox.TabIndex = 6
        Me.Val_gold_rightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GOLD_mezan_rightTextBox
        '
        Me.GOLD_mezan_rightTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.GOLD_mezan_rightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "GOLD_mezan_right", True))
        Me.GOLD_mezan_rightTextBox.Location = New System.Drawing.Point(41, 205)
        Me.GOLD_mezan_rightTextBox.Name = "GOLD_mezan_rightTextBox"
        Me.GOLD_mezan_rightTextBox.Size = New System.Drawing.Size(35, 21)
        Me.GOLD_mezan_rightTextBox.TabIndex = 14
        Me.GOLD_mezan_rightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Print_nameTextBox
        '
        Me.Print_nameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Print_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "print_name", True))
        Me.Print_nameTextBox.Location = New System.Drawing.Point(-442, 84)
        Me.Print_nameTextBox.Name = "Print_nameTextBox"
        Me.Print_nameTextBox.Size = New System.Drawing.Size(38, 21)
        Me.Print_nameTextBox.TabIndex = 123
        '
        'Program_nameTextBox
        '
        Me.Program_nameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Program_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "program_name", True))
        Me.Program_nameTextBox.Location = New System.Drawing.Point(-404, 42)
        Me.Program_nameTextBox.Name = "Program_nameTextBox"
        Me.Program_nameTextBox.Size = New System.Drawing.Size(38, 21)
        Me.Program_nameTextBox.TabIndex = 125
        '
        'TelTextBox
        '
        Me.TelTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "tel", True))
        Me.TelTextBox.Location = New System.Drawing.Point(-366, 84)
        Me.TelTextBox.Name = "TelTextBox"
        Me.TelTextBox.Size = New System.Drawing.Size(38, 21)
        Me.TelTextBox.TabIndex = 127
        '
        'NoteTextBox
        '
        Me.NoteTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(-480, 21)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(38, 21)
        Me.NoteTextBox.TabIndex = 129
        '
        'Note2TextBox
        '
        Me.Note2TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Note2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "note2", True))
        Me.Note2TextBox.Location = New System.Drawing.Point(-290, 105)
        Me.Note2TextBox.Name = "Note2TextBox"
        Me.Note2TextBox.Size = New System.Drawing.Size(38, 21)
        Me.Note2TextBox.TabIndex = 131
        '
        'DIMOND_ID_left1upTextBox
        '
        Me.DIMOND_ID_left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.DIMOND_ID_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIMOND_ID_left1up", True))
        Me.DIMOND_ID_left1upTextBox.Location = New System.Drawing.Point(49, 91)
        Me.DIMOND_ID_left1upTextBox.Name = "DIMOND_ID_left1upTextBox"
        Me.DIMOND_ID_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMOND_ID_left1upTextBox.TabIndex = 1
        Me.DIMOND_ID_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIMO_dep_left1upTextBox
        '
        Me.DIMO_dep_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.DIMO_dep_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIMO_dep_left1up", True))
        Me.DIMO_dep_left1upTextBox.Location = New System.Drawing.Point(49, 91)
        Me.DIMO_dep_left1upTextBox.Name = "DIMO_dep_left1upTextBox"
        Me.DIMO_dep_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMO_dep_left1upTextBox.TabIndex = 3
        Me.DIMO_dep_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIM_na9awa_left1upTextBox
        '
        Me.DIM_na9awa_left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.DIM_na9awa_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIM_na9awa_left1up", True))
        Me.DIM_na9awa_left1upTextBox.Location = New System.Drawing.Point(49, 217)
        Me.DIM_na9awa_left1upTextBox.Name = "DIM_na9awa_left1upTextBox"
        Me.DIM_na9awa_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIM_na9awa_left1upTextBox.TabIndex = 13
        Me.DIM_na9awa_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIMO_mezan_left1upTextBox
        '
        Me.DIMO_mezan_left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.DIMO_mezan_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIMO_mezan_left1up", True))
        Me.DIMO_mezan_left1upTextBox.Location = New System.Drawing.Point(49, 196)
        Me.DIMO_mezan_left1upTextBox.Name = "DIMO_mezan_left1upTextBox"
        Me.DIMO_mezan_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMO_mezan_left1upTextBox.TabIndex = 11
        Me.DIMO_mezan_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ext_coler_left1upTextBox
        '
        Me.Ext_coler_left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Ext_coler_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "ext_coler_left1up", True))
        Me.Ext_coler_left1upTextBox.Location = New System.Drawing.Point(49, 175)
        Me.Ext_coler_left1upTextBox.Name = "Ext_coler_left1upTextBox"
        Me.Ext_coler_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Ext_coler_left1upTextBox.TabIndex = 9
        Me.Ext_coler_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Qult_left1upTextBox
        '
        Me.Qult_left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Qult_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "qult_left1up", True))
        Me.Qult_left1upTextBox.Location = New System.Drawing.Point(49, 133)
        Me.Qult_left1upTextBox.Name = "Qult_left1upTextBox"
        Me.Qult_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Qult_left1upTextBox.TabIndex = 5
        Me.Qult_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sarual_left1upTextBox
        '
        Me.Sarual_left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Sarual_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "sarual_left1up", True))
        Me.Sarual_left1upTextBox.Location = New System.Drawing.Point(49, 469)
        Me.Sarual_left1upTextBox.Name = "Sarual_left1upTextBox"
        Me.Sarual_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Sarual_left1upTextBox.TabIndex = 17
        Me.Sarual_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Val_gold_left1upTextBox
        '
        Me.Val_gold_left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Val_gold_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "val_gold_left1up", True))
        Me.Val_gold_left1upTextBox.Location = New System.Drawing.Point(49, 154)
        Me.Val_gold_left1upTextBox.Name = "Val_gold_left1upTextBox"
        Me.Val_gold_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Val_gold_left1upTextBox.TabIndex = 7
        Me.Val_gold_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GOLD_mezan_left1upTextBox
        '
        Me.GOLD_mezan_left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.GOLD_mezan_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "GOLD_mezan_left1up", True))
        Me.GOLD_mezan_left1upTextBox.Location = New System.Drawing.Point(49, 238)
        Me.GOLD_mezan_left1upTextBox.Name = "GOLD_mezan_left1upTextBox"
        Me.GOLD_mezan_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.GOLD_mezan_left1upTextBox.TabIndex = 15
        Me.GOLD_mezan_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_1_left1upTextBox
        '
        Me.Test_1_left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Test_1_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_1_left1up", True))
        Me.Test_1_left1upTextBox.Location = New System.Drawing.Point(49, 112)
        Me.Test_1_left1upTextBox.Name = "Test_1_left1upTextBox"
        Me.Test_1_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_1_left1upTextBox.TabIndex = 3
        Me.Test_1_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIMOND_ID_right1upTextBox
        '
        Me.DIMOND_ID_right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.DIMOND_ID_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIMOND_ID_right1up", True))
        Me.DIMOND_ID_right1upTextBox.Location = New System.Drawing.Point(6, 58)
        Me.DIMOND_ID_right1upTextBox.Name = "DIMOND_ID_right1upTextBox"
        Me.DIMOND_ID_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMOND_ID_right1upTextBox.TabIndex = 1
        Me.DIMOND_ID_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIMO_dep_right1upTextBox
        '
        Me.DIMO_dep_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.DIMO_dep_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIMO_dep_right1up", True))
        Me.DIMO_dep_right1upTextBox.Location = New System.Drawing.Point(9, 77)
        Me.DIMO_dep_right1upTextBox.Name = "DIMO_dep_right1upTextBox"
        Me.DIMO_dep_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMO_dep_right1upTextBox.TabIndex = 3
        Me.DIMO_dep_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIM_na9awa_right1upTextBox
        '
        Me.DIM_na9awa_right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.DIM_na9awa_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIM_na9awa_right1up", True))
        Me.DIM_na9awa_right1upTextBox.Location = New System.Drawing.Point(6, 184)
        Me.DIM_na9awa_right1upTextBox.Name = "DIM_na9awa_right1upTextBox"
        Me.DIM_na9awa_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIM_na9awa_right1upTextBox.TabIndex = 13
        Me.DIM_na9awa_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DIMO_mezan_right1upTextBox
        '
        Me.DIMO_mezan_right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.DIMO_mezan_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "DIMO_mezan_right1up", True))
        Me.DIMO_mezan_right1upTextBox.Location = New System.Drawing.Point(6, 163)
        Me.DIMO_mezan_right1upTextBox.Name = "DIMO_mezan_right1upTextBox"
        Me.DIMO_mezan_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMO_mezan_right1upTextBox.TabIndex = 11
        Me.DIMO_mezan_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ext_coler_right1upTextBox
        '
        Me.Ext_coler_right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Ext_coler_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "ext_coler_right1up", True))
        Me.Ext_coler_right1upTextBox.Location = New System.Drawing.Point(6, 142)
        Me.Ext_coler_right1upTextBox.Name = "Ext_coler_right1upTextBox"
        Me.Ext_coler_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Ext_coler_right1upTextBox.TabIndex = 9
        Me.Ext_coler_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Qult_right1upTextBox
        '
        Me.Qult_right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Qult_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "qult_right1up", True))
        Me.Qult_right1upTextBox.Location = New System.Drawing.Point(6, 100)
        Me.Qult_right1upTextBox.Name = "Qult_right1upTextBox"
        Me.Qult_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Qult_right1upTextBox.TabIndex = 5
        Me.Qult_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sarual_right1upTextBox
        '
        Me.Sarual_right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Sarual_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "sarual_right1up", True))
        Me.Sarual_right1upTextBox.Location = New System.Drawing.Point(6, 436)
        Me.Sarual_right1upTextBox.Name = "Sarual_right1upTextBox"
        Me.Sarual_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Sarual_right1upTextBox.TabIndex = 17
        Me.Sarual_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Val_gold_right1upTextBox
        '
        Me.Val_gold_right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Val_gold_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "val_gold_right1up", True))
        Me.Val_gold_right1upTextBox.Location = New System.Drawing.Point(6, 121)
        Me.Val_gold_right1upTextBox.Name = "Val_gold_right1upTextBox"
        Me.Val_gold_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Val_gold_right1upTextBox.TabIndex = 7
        Me.Val_gold_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GOLD_mezan_right1upTextBox
        '
        Me.GOLD_mezan_right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.GOLD_mezan_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "GOLD_mezan_right1up", True))
        Me.GOLD_mezan_right1upTextBox.Location = New System.Drawing.Point(6, 205)
        Me.GOLD_mezan_right1upTextBox.Name = "GOLD_mezan_right1upTextBox"
        Me.GOLD_mezan_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.GOLD_mezan_right1upTextBox.TabIndex = 15
        Me.GOLD_mezan_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_1_right1upTextBox
        '
        Me.Test_1_right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Test_1_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_1_right1up", True))
        Me.Test_1_right1upTextBox.Location = New System.Drawing.Point(6, 79)
        Me.Test_1_right1upTextBox.Name = "Test_1_right1upTextBox"
        Me.Test_1_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_1_right1upTextBox.TabIndex = 3
        Me.Test_1_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbRight
        '
        Me.gbRight.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.gbRight.Controls.Add(Me.Panel2)
        Me.gbRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbRight.Location = New System.Drawing.Point(583, 134)
        Me.gbRight.Name = "gbRight"
        Me.gbRight.Size = New System.Drawing.Size(403, 468)
        Me.gbRight.TabIndex = 11
        Me.gbRight.TabStop = False
        Me.gbRight.Text = "باركود الجهة اليمنى"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.gbRightText)
        Me.Panel2.Controls.Add(Me.gbRightValue)
        Me.Panel2.Location = New System.Drawing.Point(3, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(399, 454)
        Me.Panel2.TabIndex = 2
        '
        'gbRightText
        '
        Me.gbRightText.BackColor = System.Drawing.Color.AntiqueWhite
        Me.gbRightText.Controls.Add(Me.RightTextLRStoneWeight3)
        Me.gbRightText.Controls.Add(Me.RightTextUDStoneWeight3)
        Me.gbRightText.Controls.Add(Me.Label33)
        Me.gbRightText.Controls.Add(Me.RightTextLRStoneName3)
        Me.gbRightText.Controls.Add(Me.RightTextUDStoneName3)
        Me.gbRightText.Controls.Add(Me.Label74)
        Me.gbRightText.Controls.Add(Me.RightTextLRStoneWeight2)
        Me.gbRightText.Controls.Add(Me.RightTextUDStoneWeight2)
        Me.gbRightText.Controls.Add(Me.Label31)
        Me.gbRightText.Controls.Add(Me.RightTextLRStoneName2)
        Me.gbRightText.Controls.Add(Me.RightTextUDStoneName2)
        Me.gbRightText.Controls.Add(Me.Label32)
        Me.gbRightText.Controls.Add(Me.RightTextLRStoneWeight1)
        Me.gbRightText.Controls.Add(Me.RightTextUDStoneWeight1)
        Me.gbRightText.Controls.Add(Me.Label72)
        Me.gbRightText.Controls.Add(Me.RightTextLRStoneName1)
        Me.gbRightText.Controls.Add(Me.RightTextUDStoneName1)
        Me.gbRightText.Controls.Add(Me.Label73)
        Me.gbRightText.Controls.Add(Me.Label45)
        Me.gbRightText.Controls.Add(Me.Label44)
        Me.gbRightText.Controls.Add(Me.Note1upTextBox)
        Me.gbRightText.Controls.Add(Me.Note21upTextBox)
        Me.gbRightText.Controls.Add(Me.Label43)
        Me.gbRightText.Controls.Add(Me.pbHRightText)
        Me.gbRightText.Controls.Add(Me.Label18)
        Me.gbRightText.Controls.Add(Me.pbVRightText)
        Me.gbRightText.Controls.Add(Me.Test_111_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_112_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_113_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_114_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_115_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_116_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_11_left1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_117_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_118_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_11_rightTextBox)
        Me.gbRightText.Controls.Add(Me.Test_119_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Label14)
        Me.gbRightText.Controls.Add(Me.Label15)
        Me.gbRightText.Controls.Add(Me.Label16)
        Me.gbRightText.Controls.Add(Me.Label17)
        Me.gbRightText.Controls.Add(Me.Label19)
        Me.gbRightText.Controls.Add(Me.Label20)
        Me.gbRightText.Controls.Add(Me.Label21)
        Me.gbRightText.Controls.Add(Me.Test_111_left1upTextBox1)
        Me.gbRightText.Controls.Add(Me.DIMO_dep_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_16_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_15_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_14_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_13_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.Test_12_right1upTextBox)
        Me.gbRightText.Controls.Add(Me.DIMO_dep_rightTextBox)
        Me.gbRightText.Controls.Add(Me.Test_11_right1upTextBox)
        Me.gbRightText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbRightText.Location = New System.Drawing.Point(199, 2)
        Me.gbRightText.Name = "gbRightText"
        Me.gbRightText.Size = New System.Drawing.Size(194, 534)
        Me.gbRightText.TabIndex = 1
        Me.gbRightText.TabStop = False
        Me.gbRightText.Text = "نصوص الباركود"
        '
        'RightTextLRStoneWeight3
        '
        Me.RightTextLRStoneWeight3.BackColor = System.Drawing.Color.FloralWhite
        Me.RightTextLRStoneWeight3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_131_right", True))
        Me.RightTextLRStoneWeight3.Location = New System.Drawing.Point(44, 392)
        Me.RightTextLRStoneWeight3.Name = "RightTextLRStoneWeight3"
        Me.RightTextLRStoneWeight3.Size = New System.Drawing.Size(35, 21)
        Me.RightTextLRStoneWeight3.TabIndex = 454
        Me.RightTextLRStoneWeight3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightTextUDStoneWeight3
        '
        Me.RightTextUDStoneWeight3.BackColor = System.Drawing.Color.FloralWhite
        Me.RightTextUDStoneWeight3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_131_right1up", True))
        Me.RightTextUDStoneWeight3.Location = New System.Drawing.Point(9, 392)
        Me.RightTextUDStoneWeight3.Name = "RightTextUDStoneWeight3"
        Me.RightTextUDStoneWeight3.Size = New System.Drawing.Size(35, 21)
        Me.RightTextUDStoneWeight3.TabIndex = 455
        Me.RightTextUDStoneWeight3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(88, 392)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(95, 21)
        Me.Label33.TabIndex = 456
        Me.Label33.Text = "وزن الحجر3"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RightTextLRStoneName3
        '
        Me.RightTextLRStoneName3.BackColor = System.Drawing.Color.FloralWhite
        Me.RightTextLRStoneName3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_130_right", True))
        Me.RightTextLRStoneName3.Location = New System.Drawing.Point(44, 371)
        Me.RightTextLRStoneName3.Name = "RightTextLRStoneName3"
        Me.RightTextLRStoneName3.Size = New System.Drawing.Size(35, 21)
        Me.RightTextLRStoneName3.TabIndex = 451
        Me.RightTextLRStoneName3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightTextUDStoneName3
        '
        Me.RightTextUDStoneName3.BackColor = System.Drawing.Color.FloralWhite
        Me.RightTextUDStoneName3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_130_right1up", True))
        Me.RightTextUDStoneName3.Location = New System.Drawing.Point(9, 371)
        Me.RightTextUDStoneName3.Name = "RightTextUDStoneName3"
        Me.RightTextUDStoneName3.Size = New System.Drawing.Size(35, 21)
        Me.RightTextUDStoneName3.TabIndex = 452
        Me.RightTextUDStoneName3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label74
        '
        Me.Label74.Location = New System.Drawing.Point(88, 371)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(95, 21)
        Me.Label74.TabIndex = 453
        Me.Label74.Text = "نوع الحجر3"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RightTextLRStoneWeight2
        '
        Me.RightTextLRStoneWeight2.BackColor = System.Drawing.Color.FloralWhite
        Me.RightTextLRStoneWeight2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_127_right", True))
        Me.RightTextLRStoneWeight2.Location = New System.Drawing.Point(44, 329)
        Me.RightTextLRStoneWeight2.Name = "RightTextLRStoneWeight2"
        Me.RightTextLRStoneWeight2.Size = New System.Drawing.Size(35, 21)
        Me.RightTextLRStoneWeight2.TabIndex = 448
        Me.RightTextLRStoneWeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightTextUDStoneWeight2
        '
        Me.RightTextUDStoneWeight2.BackColor = System.Drawing.Color.FloralWhite
        Me.RightTextUDStoneWeight2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_127_right1up", True))
        Me.RightTextUDStoneWeight2.Location = New System.Drawing.Point(9, 329)
        Me.RightTextUDStoneWeight2.Name = "RightTextUDStoneWeight2"
        Me.RightTextUDStoneWeight2.Size = New System.Drawing.Size(35, 21)
        Me.RightTextUDStoneWeight2.TabIndex = 449
        Me.RightTextUDStoneWeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(88, 329)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(95, 21)
        Me.Label31.TabIndex = 450
        Me.Label31.Text = "وزن الحجر2"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RightTextLRStoneName2
        '
        Me.RightTextLRStoneName2.BackColor = System.Drawing.Color.FloralWhite
        Me.RightTextLRStoneName2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_126_right", True))
        Me.RightTextLRStoneName2.Location = New System.Drawing.Point(44, 308)
        Me.RightTextLRStoneName2.Name = "RightTextLRStoneName2"
        Me.RightTextLRStoneName2.Size = New System.Drawing.Size(35, 21)
        Me.RightTextLRStoneName2.TabIndex = 445
        Me.RightTextLRStoneName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightTextUDStoneName2
        '
        Me.RightTextUDStoneName2.BackColor = System.Drawing.Color.FloralWhite
        Me.RightTextUDStoneName2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_126_right1up", True))
        Me.RightTextUDStoneName2.Location = New System.Drawing.Point(9, 308)
        Me.RightTextUDStoneName2.Name = "RightTextUDStoneName2"
        Me.RightTextUDStoneName2.Size = New System.Drawing.Size(35, 21)
        Me.RightTextUDStoneName2.TabIndex = 446
        Me.RightTextUDStoneName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(88, 308)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(95, 21)
        Me.Label32.TabIndex = 447
        Me.Label32.Text = "نوع الحجر2"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RightTextLRStoneWeight1
        '
        Me.RightTextLRStoneWeight1.BackColor = System.Drawing.Color.FloralWhite
        Me.RightTextLRStoneWeight1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_123_right", True))
        Me.RightTextLRStoneWeight1.Location = New System.Drawing.Point(44, 266)
        Me.RightTextLRStoneWeight1.Name = "RightTextLRStoneWeight1"
        Me.RightTextLRStoneWeight1.Size = New System.Drawing.Size(35, 21)
        Me.RightTextLRStoneWeight1.TabIndex = 442
        Me.RightTextLRStoneWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightTextUDStoneWeight1
        '
        Me.RightTextUDStoneWeight1.BackColor = System.Drawing.Color.FloralWhite
        Me.RightTextUDStoneWeight1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_123_right1up", True))
        Me.RightTextUDStoneWeight1.Location = New System.Drawing.Point(9, 266)
        Me.RightTextUDStoneWeight1.Name = "RightTextUDStoneWeight1"
        Me.RightTextUDStoneWeight1.Size = New System.Drawing.Size(35, 21)
        Me.RightTextUDStoneWeight1.TabIndex = 443
        Me.RightTextUDStoneWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(88, 267)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(95, 21)
        Me.Label72.TabIndex = 444
        Me.Label72.Text = "وزن الحجر1"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RightTextLRStoneName1
        '
        Me.RightTextLRStoneName1.BackColor = System.Drawing.Color.FloralWhite
        Me.RightTextLRStoneName1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_122_right", True))
        Me.RightTextLRStoneName1.Location = New System.Drawing.Point(44, 245)
        Me.RightTextLRStoneName1.Name = "RightTextLRStoneName1"
        Me.RightTextLRStoneName1.Size = New System.Drawing.Size(35, 21)
        Me.RightTextLRStoneName1.TabIndex = 439
        Me.RightTextLRStoneName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightTextUDStoneName1
        '
        Me.RightTextUDStoneName1.BackColor = System.Drawing.Color.FloralWhite
        Me.RightTextUDStoneName1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_122_right1up", True))
        Me.RightTextUDStoneName1.Location = New System.Drawing.Point(9, 245)
        Me.RightTextUDStoneName1.Name = "RightTextUDStoneName1"
        Me.RightTextUDStoneName1.Size = New System.Drawing.Size(35, 21)
        Me.RightTextUDStoneName1.TabIndex = 440
        Me.RightTextUDStoneName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(88, 246)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(95, 21)
        Me.Label73.TabIndex = 441
        Me.Label73.Text = "نوع الحجر1"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label45
        '
        Me.Label45.Location = New System.Drawing.Point(88, 99)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(95, 21)
        Me.Label45.TabIndex = 431
        Me.Label45.Text = "اسم المعرض"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Me.Label44.Location = New System.Drawing.Point(88, 57)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(95, 21)
        Me.Label44.TabIndex = 430
        Me.Label44.Text = "القص"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Note1upTextBox
        '
        Me.Note1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Note1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "note1up", True))
        Me.Note1upTextBox.Location = New System.Drawing.Point(44, 98)
        Me.Note1upTextBox.Name = "Note1upTextBox"
        Me.Note1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Note1upTextBox.TabIndex = 4
        Me.Note1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Note21upTextBox
        '
        Me.Note21upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Note21upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "note21up", True))
        Me.Note21upTextBox.Location = New System.Drawing.Point(9, 98)
        Me.Note21upTextBox.Name = "Note21upTextBox"
        Me.Note21upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Note21upTextBox.TabIndex = 5
        Me.Note21upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(88, 78)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(95, 21)
        Me.Label43.TabIndex = 429
        Me.Label43.Text = "اسم الصنف"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbHRightText
        '
        Me.pbHRightText.BackColor = System.Drawing.Color.White
        Me.pbHRightText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbHRightText.Image = Global.DT_restrant.My.Resources.Resources.ArrowLeftRight
        Me.pbHRightText.Location = New System.Drawing.Point(9, 16)
        Me.pbHRightText.Name = "pbHRightText"
        Me.pbHRightText.Size = New System.Drawing.Size(35, 35)
        Me.pbHRightText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHRightText.TabIndex = 419
        Me.pbHRightText.TabStop = False
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(88, 162)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 21)
        Me.Label18.TabIndex = 401
        Me.Label18.Text = "اللون"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbVRightText
        '
        Me.pbVRightText.BackColor = System.Drawing.Color.White
        Me.pbVRightText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbVRightText.Image = Global.DT_restrant.My.Resources.Resources.ArrowUpDown
        Me.pbVRightText.Location = New System.Drawing.Point(44, 16)
        Me.pbVRightText.Name = "pbVRightText"
        Me.pbVRightText.Size = New System.Drawing.Size(35, 35)
        Me.pbVRightText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbVRightText.TabIndex = 418
        Me.pbVRightText.TabStop = False
        '
        'Test_111_right1upTextBox
        '
        Me.Test_111_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_111_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_111_right1up", True))
        Me.Test_111_right1upTextBox.Location = New System.Drawing.Point(9, 476)
        Me.Test_111_right1upTextBox.Name = "Test_111_right1upTextBox"
        Me.Test_111_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_111_right1upTextBox.TabIndex = 21
        Me.Test_111_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_112_right1upTextBox
        '
        Me.Test_112_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_112_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_112_right1up", True))
        Me.Test_112_right1upTextBox.Location = New System.Drawing.Point(44, 476)
        Me.Test_112_right1upTextBox.Name = "Test_112_right1upTextBox"
        Me.Test_112_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_112_right1upTextBox.TabIndex = 20
        Me.Test_112_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_113_right1upTextBox
        '
        Me.Test_113_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_113_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_113_right1up", True))
        Me.Test_113_right1upTextBox.Location = New System.Drawing.Point(9, 455)
        Me.Test_113_right1upTextBox.Name = "Test_113_right1upTextBox"
        Me.Test_113_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_113_right1upTextBox.TabIndex = 19
        Me.Test_113_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_114_right1upTextBox
        '
        Me.Test_114_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_114_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_114_right1up", True))
        Me.Test_114_right1upTextBox.Location = New System.Drawing.Point(44, 455)
        Me.Test_114_right1upTextBox.Name = "Test_114_right1upTextBox"
        Me.Test_114_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_114_right1upTextBox.TabIndex = 18
        Me.Test_114_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_115_right1upTextBox
        '
        Me.Test_115_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_115_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_115_right1up", True))
        Me.Test_115_right1upTextBox.Location = New System.Drawing.Point(9, 119)
        Me.Test_115_right1upTextBox.Name = "Test_115_right1upTextBox"
        Me.Test_115_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_115_right1upTextBox.TabIndex = 7
        Me.Test_115_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_116_right1upTextBox
        '
        Me.Test_116_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_116_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_116_right1up", True))
        Me.Test_116_right1upTextBox.Location = New System.Drawing.Point(9, 224)
        Me.Test_116_right1upTextBox.Name = "Test_116_right1upTextBox"
        Me.Test_116_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_116_right1upTextBox.TabIndex = 17
        Me.Test_116_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_11_left1upTextBox
        '
        Me.Test_11_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_11_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_11_left1up", True))
        Me.Test_11_left1upTextBox.Location = New System.Drawing.Point(44, 56)
        Me.Test_11_left1upTextBox.Name = "Test_11_left1upTextBox"
        Me.Test_11_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_11_left1upTextBox.TabIndex = 0
        Me.Test_11_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_117_right1upTextBox
        '
        Me.Test_117_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_117_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_117_right1up", True))
        Me.Test_117_right1upTextBox.Location = New System.Drawing.Point(9, 140)
        Me.Test_117_right1upTextBox.Name = "Test_117_right1upTextBox"
        Me.Test_117_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_117_right1upTextBox.TabIndex = 9
        Me.Test_117_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_118_right1upTextBox
        '
        Me.Test_118_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_118_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_118_right1up", True))
        Me.Test_118_right1upTextBox.Location = New System.Drawing.Point(9, 182)
        Me.Test_118_right1upTextBox.Name = "Test_118_right1upTextBox"
        Me.Test_118_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_118_right1upTextBox.TabIndex = 13
        Me.Test_118_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_11_rightTextBox
        '
        Me.Test_11_rightTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_11_rightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_11_right", True))
        Me.Test_11_rightTextBox.Location = New System.Drawing.Point(9, 56)
        Me.Test_11_rightTextBox.Name = "Test_11_rightTextBox"
        Me.Test_11_rightTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_11_rightTextBox.TabIndex = 1
        Me.Test_11_rightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_119_right1upTextBox
        '
        Me.Test_119_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_119_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_119_right1up", True))
        Me.Test_119_right1upTextBox.Location = New System.Drawing.Point(9, 203)
        Me.Test_119_right1upTextBox.Name = "Test_119_right1upTextBox"
        Me.Test_119_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_119_right1upTextBox.TabIndex = 15
        Me.Test_119_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(88, 455)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 21)
        Me.Label14.TabIndex = 405
        Me.Label14.Text = "رقم القطعة"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(88, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 21)
        Me.Label15.TabIndex = 404
        Me.Label15.Text = "السعر"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(88, 225)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 21)
        Me.Label16.TabIndex = 403
        Me.Label16.Text = "وزن الذهب"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(88, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 21)
        Me.Label17.TabIndex = 402
        Me.Label17.Text = "عيار الذهب"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(88, 183)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 21)
        Me.Label19.TabIndex = 400
        Me.Label19.Text = "القيراط"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(88, 204)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 21)
        Me.Label20.TabIndex = 399
        Me.Label20.Text = "النقاوة"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(88, 476)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 21)
        Me.Label21.TabIndex = 398
        Me.Label21.Text = "الاسم"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Test_111_left1upTextBox1
        '
        Me.Test_111_left1upTextBox1.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_111_left1upTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_111_left1up", True))
        Me.Test_111_left1upTextBox1.Location = New System.Drawing.Point(9, 161)
        Me.Test_111_left1upTextBox1.Name = "Test_111_left1upTextBox1"
        Me.Test_111_left1upTextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_111_left1upTextBox1.TabIndex = 11
        Me.Test_111_left1upTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_16_right1upTextBox
        '
        Me.Test_16_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_16_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_16_right1up", True))
        Me.Test_16_right1upTextBox.Location = New System.Drawing.Point(44, 119)
        Me.Test_16_right1upTextBox.Name = "Test_16_right1upTextBox"
        Me.Test_16_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_16_right1upTextBox.TabIndex = 6
        Me.Test_16_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_15_right1upTextBox
        '
        Me.Test_15_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_15_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_15_right1up", True))
        Me.Test_15_right1upTextBox.Location = New System.Drawing.Point(44, 224)
        Me.Test_15_right1upTextBox.Name = "Test_15_right1upTextBox"
        Me.Test_15_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_15_right1upTextBox.TabIndex = 16
        Me.Test_15_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_14_right1upTextBox
        '
        Me.Test_14_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_14_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_14_right1up", True))
        Me.Test_14_right1upTextBox.Location = New System.Drawing.Point(44, 140)
        Me.Test_14_right1upTextBox.Name = "Test_14_right1upTextBox"
        Me.Test_14_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_14_right1upTextBox.TabIndex = 8
        Me.Test_14_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_13_right1upTextBox
        '
        Me.Test_13_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_13_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_13_right1up", True))
        Me.Test_13_right1upTextBox.Location = New System.Drawing.Point(44, 161)
        Me.Test_13_right1upTextBox.Name = "Test_13_right1upTextBox"
        Me.Test_13_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_13_right1upTextBox.TabIndex = 10
        Me.Test_13_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_12_right1upTextBox
        '
        Me.Test_12_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_12_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_12_right1up", True))
        Me.Test_12_right1upTextBox.Location = New System.Drawing.Point(44, 182)
        Me.Test_12_right1upTextBox.Name = "Test_12_right1upTextBox"
        Me.Test_12_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_12_right1upTextBox.TabIndex = 12
        Me.Test_12_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_11_right1upTextBox
        '
        Me.Test_11_right1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_11_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_11_right1up", True))
        Me.Test_11_right1upTextBox.Location = New System.Drawing.Point(44, 203)
        Me.Test_11_right1upTextBox.Name = "Test_11_right1upTextBox"
        Me.Test_11_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_11_right1upTextBox.TabIndex = 14
        Me.Test_11_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbRightValue
        '
        Me.gbRightValue.BackColor = System.Drawing.Color.Ivory
        Me.gbRightValue.Controls.Add(Me.TotalStoneWeight_RightupTextBox)
        Me.gbRightValue.Controls.Add(Me.TotalStoneWeight_Right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.lblTotalStoneWeightRight)
        Me.gbRightValue.Controls.Add(Me.lblCut3Right)
        Me.gbRightValue.Controls.Add(Me.Cut3_Right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.Cut3_RightupTextBox)
        Me.gbRightValue.Controls.Add(Me.lblCut2Right)
        Me.gbRightValue.Controls.Add(Me.Cut2_Right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.Cut2_RightupTextBox)
        Me.gbRightValue.Controls.Add(Me.Cut1_RightupTextBox)
        Me.gbRightValue.Controls.Add(Me.Cut1_Right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.lblCut1Right)
        Me.gbRightValue.Controls.Add(Me.Label83)
        Me.gbRightValue.Controls.Add(Me.Code_Right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.Code_RightupTextBox)
        Me.gbRightValue.Controls.Add(Me.RightValueUDStoneWeight3)
        Me.gbRightValue.Controls.Add(Me.RightValueLRStoneWeight3)
        Me.gbRightValue.Controls.Add(Me.RightValueUDStoneName3)
        Me.gbRightValue.Controls.Add(Me.RightValueLRStoneName3)
        Me.gbRightValue.Controls.Add(Me.RightValueUDStoneWeight2)
        Me.gbRightValue.Controls.Add(Me.RightValueLRStoneWeight2)
        Me.gbRightValue.Controls.Add(Me.RightValueUDStoneName2)
        Me.gbRightValue.Controls.Add(Me.RightValueLRStoneName2)
        Me.gbRightValue.Controls.Add(Me.Label27)
        Me.gbRightValue.Controls.Add(Me.Label28)
        Me.gbRightValue.Controls.Add(Me.Label29)
        Me.gbRightValue.Controls.Add(Me.Label30)
        Me.gbRightValue.Controls.Add(Me.Label70)
        Me.gbRightValue.Controls.Add(Me.RightValueUDStoneWeight1)
        Me.gbRightValue.Controls.Add(Me.RightValueLRStoneWeight1)
        Me.gbRightValue.Controls.Add(Me.Label71)
        Me.gbRightValue.Controls.Add(Me.RightValueUDStoneName1)
        Me.gbRightValue.Controls.Add(Me.RightValueLRStoneName1)
        Me.gbRightValue.Controls.Add(Me.Label42)
        Me.gbRightValue.Controls.Add(Me.Label41)
        Me.gbRightValue.Controls.Add(Me.Label40)
        Me.gbRightValue.Controls.Add(Me.Label39)
        Me.gbRightValue.Controls.Add(Me.Label38)
        Me.gbRightValue.Controls.Add(Me.Label37)
        Me.gbRightValue.Controls.Add(Me.Label36)
        Me.gbRightValue.Controls.Add(Me.Label35)
        Me.gbRightValue.Controls.Add(Me.Label3)
        Me.gbRightValue.Controls.Add(Me.pbHRightValue)
        Me.gbRightValue.Controls.Add(Me.pbVRightValue)
        Me.gbRightValue.Controls.Add(Me.Test_12_left1upTextBox)
        Me.gbRightValue.Controls.Add(Me.Test_1_right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.GOLD_mezan_right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.Val_gold_right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.Sarual_right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.Qult_right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.Ext_coler_right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.DIMO_mezan_right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.DIM_na9awa_right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.DIMOND_ID_right1upTextBox)
        Me.gbRightValue.Controls.Add(Me.DIMOND_ID_rightTextBox)
        Me.gbRightValue.Controls.Add(Me.DIM_na9awa_rightTextBox)
        Me.gbRightValue.Controls.Add(Me.DIMO_mezan_rightTextBox)
        Me.gbRightValue.Controls.Add(Me.Ext_coler_rightTextBox)
        Me.gbRightValue.Controls.Add(Me.Qult_rightTextBox)
        Me.gbRightValue.Controls.Add(Me.Sarual_rightTextBox)
        Me.gbRightValue.Controls.Add(Me.Val_gold_rightTextBox)
        Me.gbRightValue.Controls.Add(Me.GOLD_mezan_rightTextBox)
        Me.gbRightValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbRightValue.Location = New System.Drawing.Point(5, 2)
        Me.gbRightValue.Name = "gbRightValue"
        Me.gbRightValue.Size = New System.Drawing.Size(194, 535)
        Me.gbRightValue.TabIndex = 0
        Me.gbRightValue.TabStop = False
        Me.gbRightValue.Text = "قيم الباركود"
        '
        'TotalStoneWeight_RightupTextBox
        '
        Me.TotalStoneWeight_RightupTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.TotalStoneWeight_RightupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "TotalStoneWeight_Rightup", True))
        Me.TotalStoneWeight_RightupTextBox.Location = New System.Drawing.Point(41, 415)
        Me.TotalStoneWeight_RightupTextBox.Name = "TotalStoneWeight_RightupTextBox"
        Me.TotalStoneWeight_RightupTextBox.Size = New System.Drawing.Size(35, 21)
        Me.TotalStoneWeight_RightupTextBox.TabIndex = 475
        Me.TotalStoneWeight_RightupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalStoneWeight_Right1upTextBox
        '
        Me.TotalStoneWeight_Right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.TotalStoneWeight_Right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "TotalStoneWeight_Right1up", True))
        Me.TotalStoneWeight_Right1upTextBox.Location = New System.Drawing.Point(6, 415)
        Me.TotalStoneWeight_Right1upTextBox.Name = "TotalStoneWeight_Right1upTextBox"
        Me.TotalStoneWeight_Right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.TotalStoneWeight_Right1upTextBox.TabIndex = 476
        Me.TotalStoneWeight_Right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalStoneWeightRight
        '
        Me.lblTotalStoneWeightRight.Location = New System.Drawing.Point(89, 415)
        Me.lblTotalStoneWeightRight.Name = "lblTotalStoneWeightRight"
        Me.lblTotalStoneWeightRight.Size = New System.Drawing.Size(95, 21)
        Me.lblTotalStoneWeightRight.TabIndex = 477
        Me.lblTotalStoneWeightRight.Text = "وزن إجمالي للفصوص"
        Me.lblTotalStoneWeightRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCut3Right
        '
        Me.lblCut3Right.Location = New System.Drawing.Point(87, 394)
        Me.lblCut3Right.Name = "lblCut3Right"
        Me.lblCut3Right.Size = New System.Drawing.Size(95, 21)
        Me.lblCut3Right.TabIndex = 474
        Me.lblCut3Right.Text = "قصة الحجر3"
        Me.lblCut3Right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cut3_Right1upTextBox
        '
        Me.Cut3_Right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Cut3_Right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Cut3_Right1up", True))
        Me.Cut3_Right1upTextBox.Location = New System.Drawing.Point(6, 394)
        Me.Cut3_Right1upTextBox.Name = "Cut3_Right1upTextBox"
        Me.Cut3_Right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut3_Right1upTextBox.TabIndex = 473
        Me.Cut3_Right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cut3_RightupTextBox
        '
        Me.Cut3_RightupTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Cut3_RightupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Cut3_Rightup", True))
        Me.Cut3_RightupTextBox.Location = New System.Drawing.Point(41, 394)
        Me.Cut3_RightupTextBox.Name = "Cut3_RightupTextBox"
        Me.Cut3_RightupTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut3_RightupTextBox.TabIndex = 472
        Me.Cut3_RightupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCut2Right
        '
        Me.lblCut2Right.Location = New System.Drawing.Point(88, 331)
        Me.lblCut2Right.Name = "lblCut2Right"
        Me.lblCut2Right.Size = New System.Drawing.Size(95, 21)
        Me.lblCut2Right.TabIndex = 471
        Me.lblCut2Right.Text = "قصة الحجر2"
        Me.lblCut2Right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cut2_Right1upTextBox
        '
        Me.Cut2_Right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Cut2_Right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Cut2_Right1up", True))
        Me.Cut2_Right1upTextBox.Location = New System.Drawing.Point(6, 331)
        Me.Cut2_Right1upTextBox.Name = "Cut2_Right1upTextBox"
        Me.Cut2_Right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut2_Right1upTextBox.TabIndex = 470
        Me.Cut2_Right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cut2_RightupTextBox
        '
        Me.Cut2_RightupTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Cut2_RightupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Cut2_Rightup", True))
        Me.Cut2_RightupTextBox.Location = New System.Drawing.Point(41, 331)
        Me.Cut2_RightupTextBox.Name = "Cut2_RightupTextBox"
        Me.Cut2_RightupTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut2_RightupTextBox.TabIndex = 469
        Me.Cut2_RightupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cut1_RightupTextBox
        '
        Me.Cut1_RightupTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Cut1_RightupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Cut1_Rightup", True))
        Me.Cut1_RightupTextBox.Location = New System.Drawing.Point(41, 268)
        Me.Cut1_RightupTextBox.Name = "Cut1_RightupTextBox"
        Me.Cut1_RightupTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut1_RightupTextBox.TabIndex = 466
        Me.Cut1_RightupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cut1_Right1upTextBox
        '
        Me.Cut1_Right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Cut1_Right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Cut1_Right1up", True))
        Me.Cut1_Right1upTextBox.Location = New System.Drawing.Point(6, 268)
        Me.Cut1_Right1upTextBox.Name = "Cut1_Right1upTextBox"
        Me.Cut1_Right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut1_Right1upTextBox.TabIndex = 467
        Me.Cut1_Right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCut1Right
        '
        Me.lblCut1Right.Location = New System.Drawing.Point(87, 268)
        Me.lblCut1Right.Name = "lblCut1Right"
        Me.lblCut1Right.Size = New System.Drawing.Size(95, 21)
        Me.lblCut1Right.TabIndex = 468
        Me.lblCut1Right.Text = "قصة الحجر1"
        Me.lblCut1Right.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label83
        '
        Me.Label83.Location = New System.Drawing.Point(87, 457)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(95, 21)
        Me.Label83.TabIndex = 465
        Me.Label83.Text = "الرمز"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Code_Right1upTextBox
        '
        Me.Code_Right1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Code_Right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Code_Right1up", True))
        Me.Code_Right1upTextBox.Location = New System.Drawing.Point(6, 457)
        Me.Code_Right1upTextBox.Name = "Code_Right1upTextBox"
        Me.Code_Right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Code_Right1upTextBox.TabIndex = 464
        Me.Code_Right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Code_RightupTextBox
        '
        Me.Code_RightupTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Code_RightupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Code_Rightup", True))
        Me.Code_RightupTextBox.Location = New System.Drawing.Point(41, 457)
        Me.Code_RightupTextBox.Name = "Code_RightupTextBox"
        Me.Code_RightupTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Code_RightupTextBox.TabIndex = 463
        Me.Code_RightupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightValueUDStoneWeight3
        '
        Me.RightValueUDStoneWeight3.BackColor = System.Drawing.Color.PeachPuff
        Me.RightValueUDStoneWeight3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_129_right1up", True))
        Me.RightValueUDStoneWeight3.Location = New System.Drawing.Point(6, 373)
        Me.RightValueUDStoneWeight3.Name = "RightValueUDStoneWeight3"
        Me.RightValueUDStoneWeight3.Size = New System.Drawing.Size(35, 21)
        Me.RightValueUDStoneWeight3.TabIndex = 462
        Me.RightValueUDStoneWeight3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightValueLRStoneWeight3
        '
        Me.RightValueLRStoneWeight3.BackColor = System.Drawing.Color.PeachPuff
        Me.RightValueLRStoneWeight3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_129_right", True))
        Me.RightValueLRStoneWeight3.Location = New System.Drawing.Point(41, 373)
        Me.RightValueLRStoneWeight3.Name = "RightValueLRStoneWeight3"
        Me.RightValueLRStoneWeight3.Size = New System.Drawing.Size(35, 21)
        Me.RightValueLRStoneWeight3.TabIndex = 461
        Me.RightValueLRStoneWeight3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightValueUDStoneName3
        '
        Me.RightValueUDStoneName3.BackColor = System.Drawing.Color.PeachPuff
        Me.RightValueUDStoneName3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_128_right1up", True))
        Me.RightValueUDStoneName3.Location = New System.Drawing.Point(6, 352)
        Me.RightValueUDStoneName3.Name = "RightValueUDStoneName3"
        Me.RightValueUDStoneName3.Size = New System.Drawing.Size(35, 21)
        Me.RightValueUDStoneName3.TabIndex = 460
        Me.RightValueUDStoneName3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightValueLRStoneName3
        '
        Me.RightValueLRStoneName3.BackColor = System.Drawing.Color.PeachPuff
        Me.RightValueLRStoneName3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_128_right", True))
        Me.RightValueLRStoneName3.Location = New System.Drawing.Point(41, 352)
        Me.RightValueLRStoneName3.Name = "RightValueLRStoneName3"
        Me.RightValueLRStoneName3.Size = New System.Drawing.Size(35, 21)
        Me.RightValueLRStoneName3.TabIndex = 459
        Me.RightValueLRStoneName3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightValueUDStoneWeight2
        '
        Me.RightValueUDStoneWeight2.BackColor = System.Drawing.Color.PeachPuff
        Me.RightValueUDStoneWeight2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_125_right1up", True))
        Me.RightValueUDStoneWeight2.Location = New System.Drawing.Point(6, 310)
        Me.RightValueUDStoneWeight2.Name = "RightValueUDStoneWeight2"
        Me.RightValueUDStoneWeight2.Size = New System.Drawing.Size(35, 21)
        Me.RightValueUDStoneWeight2.TabIndex = 458
        Me.RightValueUDStoneWeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightValueLRStoneWeight2
        '
        Me.RightValueLRStoneWeight2.BackColor = System.Drawing.Color.PeachPuff
        Me.RightValueLRStoneWeight2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_125_right", True))
        Me.RightValueLRStoneWeight2.Location = New System.Drawing.Point(41, 310)
        Me.RightValueLRStoneWeight2.Name = "RightValueLRStoneWeight2"
        Me.RightValueLRStoneWeight2.Size = New System.Drawing.Size(35, 21)
        Me.RightValueLRStoneWeight2.TabIndex = 457
        Me.RightValueLRStoneWeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightValueUDStoneName2
        '
        Me.RightValueUDStoneName2.BackColor = System.Drawing.Color.PeachPuff
        Me.RightValueUDStoneName2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_124_right1up", True))
        Me.RightValueUDStoneName2.Location = New System.Drawing.Point(6, 289)
        Me.RightValueUDStoneName2.Name = "RightValueUDStoneName2"
        Me.RightValueUDStoneName2.Size = New System.Drawing.Size(35, 21)
        Me.RightValueUDStoneName2.TabIndex = 456
        Me.RightValueUDStoneName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightValueLRStoneName2
        '
        Me.RightValueLRStoneName2.BackColor = System.Drawing.Color.PeachPuff
        Me.RightValueLRStoneName2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_124_right", True))
        Me.RightValueLRStoneName2.Location = New System.Drawing.Point(41, 289)
        Me.RightValueLRStoneName2.Name = "RightValueLRStoneName2"
        Me.RightValueLRStoneName2.Size = New System.Drawing.Size(35, 21)
        Me.RightValueLRStoneName2.TabIndex = 455
        Me.RightValueLRStoneName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(87, 373)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(95, 21)
        Me.Label27.TabIndex = 454
        Me.Label27.Text = "وزن الحجر3"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(87, 352)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(95, 21)
        Me.Label28.TabIndex = 453
        Me.Label28.Text = "نوع الحجر3"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(87, 310)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(95, 21)
        Me.Label29.TabIndex = 452
        Me.Label29.Text = "وزن الحجر2"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(87, 289)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(95, 21)
        Me.Label30.TabIndex = 451
        Me.Label30.Text = "نوع الحجر2"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label70
        '
        Me.Label70.Location = New System.Drawing.Point(87, 247)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(95, 21)
        Me.Label70.TabIndex = 444
        Me.Label70.Text = "وزن الحجر1"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RightValueUDStoneWeight1
        '
        Me.RightValueUDStoneWeight1.BackColor = System.Drawing.Color.PeachPuff
        Me.RightValueUDStoneWeight1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_121_right1up", True))
        Me.RightValueUDStoneWeight1.Location = New System.Drawing.Point(6, 247)
        Me.RightValueUDStoneWeight1.Name = "RightValueUDStoneWeight1"
        Me.RightValueUDStoneWeight1.Size = New System.Drawing.Size(35, 21)
        Me.RightValueUDStoneWeight1.TabIndex = 443
        Me.RightValueUDStoneWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightValueLRStoneWeight1
        '
        Me.RightValueLRStoneWeight1.BackColor = System.Drawing.Color.PeachPuff
        Me.RightValueLRStoneWeight1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_121_right", True))
        Me.RightValueLRStoneWeight1.Location = New System.Drawing.Point(41, 247)
        Me.RightValueLRStoneWeight1.Name = "RightValueLRStoneWeight1"
        Me.RightValueLRStoneWeight1.Size = New System.Drawing.Size(35, 21)
        Me.RightValueLRStoneWeight1.TabIndex = 442
        Me.RightValueLRStoneWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(87, 226)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(95, 21)
        Me.Label71.TabIndex = 441
        Me.Label71.Text = "نوع الحجر1"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RightValueUDStoneName1
        '
        Me.RightValueUDStoneName1.BackColor = System.Drawing.Color.PeachPuff
        Me.RightValueUDStoneName1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_120_right1up", True))
        Me.RightValueUDStoneName1.Location = New System.Drawing.Point(6, 226)
        Me.RightValueUDStoneName1.Name = "RightValueUDStoneName1"
        Me.RightValueUDStoneName1.Size = New System.Drawing.Size(35, 21)
        Me.RightValueUDStoneName1.TabIndex = 440
        Me.RightValueUDStoneName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightValueLRStoneName1
        '
        Me.RightValueLRStoneName1.BackColor = System.Drawing.Color.PeachPuff
        Me.RightValueLRStoneName1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_120_right", True))
        Me.RightValueLRStoneName1.Location = New System.Drawing.Point(41, 226)
        Me.RightValueLRStoneName1.Name = "RightValueLRStoneName1"
        Me.RightValueLRStoneName1.Size = New System.Drawing.Size(35, 21)
        Me.RightValueLRStoneName1.TabIndex = 439
        Me.RightValueLRStoneName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(87, 205)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(95, 21)
        Me.Label42.TabIndex = 428
        Me.Label42.Text = "وزن الذهب"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(87, 121)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(95, 21)
        Me.Label41.TabIndex = 427
        Me.Label41.Text = "عيار الذهب"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(87, 436)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(95, 21)
        Me.Label40.TabIndex = 426
        Me.Label40.Text = "رقم القطعة"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(87, 100)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(95, 21)
        Me.Label39.TabIndex = 425
        Me.Label39.Text = "السعر"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(87, 142)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(95, 21)
        Me.Label38.TabIndex = 424
        Me.Label38.Text = "اللون"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(87, 163)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(95, 21)
        Me.Label37.TabIndex = 423
        Me.Label37.Text = "القيراط"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(87, 184)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(95, 21)
        Me.Label36.TabIndex = 422
        Me.Label36.Text = "النقاوة"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(87, 79)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(95, 21)
        Me.Label35.TabIndex = 421
        Me.Label35.Text = "رقم الباركود"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(87, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 21)
        Me.Label3.TabIndex = 420
        Me.Label3.Text = "الباركود"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbHRightValue
        '
        Me.pbHRightValue.BackColor = System.Drawing.Color.White
        Me.pbHRightValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbHRightValue.Image = Global.DT_restrant.My.Resources.Resources.ArrowLeftRight
        Me.pbHRightValue.Location = New System.Drawing.Point(41, 17)
        Me.pbHRightValue.Name = "pbHRightValue"
        Me.pbHRightValue.Size = New System.Drawing.Size(34, 35)
        Me.pbHRightValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHRightValue.TabIndex = 419
        Me.pbHRightValue.TabStop = False
        '
        'pbVRightValue
        '
        Me.pbVRightValue.BackColor = System.Drawing.Color.White
        Me.pbVRightValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbVRightValue.Image = Global.DT_restrant.My.Resources.Resources.ArrowUpDown
        Me.pbVRightValue.Location = New System.Drawing.Point(6, 17)
        Me.pbVRightValue.Name = "pbVRightValue"
        Me.pbVRightValue.Size = New System.Drawing.Size(35, 35)
        Me.pbVRightValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbVRightValue.TabIndex = 418
        Me.pbVRightValue.TabStop = False
        '
        'Test_12_left1upTextBox
        '
        Me.Test_12_left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Test_12_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_12_left1up", True))
        Me.Test_12_left1upTextBox.Location = New System.Drawing.Point(41, 79)
        Me.Test_12_left1upTextBox.Name = "Test_12_left1upTextBox"
        Me.Test_12_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_12_left1upTextBox.TabIndex = 2
        Me.Test_12_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbLeft
        '
        Me.gbLeft.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.gbLeft.Controls.Add(Me.pnlLeft)
        Me.gbLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbLeft.Location = New System.Drawing.Point(9, 134)
        Me.gbLeft.Name = "gbLeft"
        Me.gbLeft.Size = New System.Drawing.Size(403, 468)
        Me.gbLeft.TabIndex = 10
        Me.gbLeft.TabStop = False
        Me.gbLeft.Text = "باركود الجهة اليسرى"
        '
        'pnlLeft
        '
        Me.pnlLeft.AutoScroll = True
        Me.pnlLeft.Controls.Add(Me.gbLeftText)
        Me.pnlLeft.Controls.Add(Me.gbLeftValue)
        Me.pnlLeft.Location = New System.Drawing.Point(3, 14)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(398, 454)
        Me.pnlLeft.TabIndex = 467
        '
        'gbLeftText
        '
        Me.gbLeftText.BackColor = System.Drawing.Color.AntiqueWhite
        Me.gbLeftText.Controls.Add(Me.LeftTextLRStoneWeight3)
        Me.gbLeftText.Controls.Add(Me.LeftTextUDStoneWeight3)
        Me.gbLeftText.Controls.Add(Me.Label25)
        Me.gbLeftText.Controls.Add(Me.LeftTextLRStoneName3)
        Me.gbLeftText.Controls.Add(Me.LeftTextUDStoneName3)
        Me.gbLeftText.Controls.Add(Me.Label26)
        Me.gbLeftText.Controls.Add(Me.LeftTextLRStoneWeight2)
        Me.gbLeftText.Controls.Add(Me.LeftTextUDStoneWeight2)
        Me.gbLeftText.Controls.Add(Me.Label23)
        Me.gbLeftText.Controls.Add(Me.LeftTextLRStoneName2)
        Me.gbLeftText.Controls.Add(Me.LeftTextUDStoneName2)
        Me.gbLeftText.Controls.Add(Me.Label24)
        Me.gbLeftText.Controls.Add(Me.LeftTextLRStoneWeight1)
        Me.gbLeftText.Controls.Add(Me.LeftTextUDStoneWeight1)
        Me.gbLeftText.Controls.Add(Me.Label67)
        Me.gbLeftText.Controls.Add(Me.LeftTextLRStoneName1)
        Me.gbLeftText.Controls.Add(Me.LeftTextUDStoneName1)
        Me.gbLeftText.Controls.Add(Me.Label66)
        Me.gbLeftText.Controls.Add(Me.pbHLeftText)
        Me.gbLeftText.Controls.Add(Me.Label56)
        Me.gbLeftText.Controls.Add(Me.pbVLeftText)
        Me.gbLeftText.Controls.Add(Me.Label55)
        Me.gbLeftText.Controls.Add(Me.Label54)
        Me.gbLeftText.Controls.Add(Me.Note2TextBox1)
        Me.gbLeftText.Controls.Add(Me.NoteTextBox1)
        Me.gbLeftText.Controls.Add(Me.Test_12_leftTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_1_rightTextBox1)
        Me.gbLeftText.Controls.Add(Me.DIMO_dep_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.DIMO_dep_leftTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_119_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_13_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_14_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_15_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_16_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_17_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_18_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_19_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_110_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_112_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_113_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_114_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_115_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_116_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_117_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Test_118_left1upTextBox)
        Me.gbLeftText.Controls.Add(Me.Label4)
        Me.gbLeftText.Controls.Add(Me.Label5)
        Me.gbLeftText.Controls.Add(Me.Label7)
        Me.gbLeftText.Controls.Add(Me.Label6)
        Me.gbLeftText.Controls.Add(Me.Label11)
        Me.gbLeftText.Controls.Add(Me.Label10)
        Me.gbLeftText.Controls.Add(Me.SET1)
        Me.gbLeftText.Controls.Add(Me.Label8)
        Me.gbLeftText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbLeftText.Location = New System.Drawing.Point(197, 4)
        Me.gbLeftText.Name = "gbLeftText"
        Me.gbLeftText.Size = New System.Drawing.Size(194, 534)
        Me.gbLeftText.TabIndex = 1
        Me.gbLeftText.TabStop = False
        Me.gbLeftText.Text = "نصوص الباركود"
        '
        'LeftTextLRStoneWeight3
        '
        Me.LeftTextLRStoneWeight3.BackColor = System.Drawing.Color.FloralWhite
        Me.LeftTextLRStoneWeight3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_131_left", True))
        Me.LeftTextLRStoneWeight3.Location = New System.Drawing.Point(10, 406)
        Me.LeftTextLRStoneWeight3.Name = "LeftTextLRStoneWeight3"
        Me.LeftTextLRStoneWeight3.Size = New System.Drawing.Size(35, 21)
        Me.LeftTextLRStoneWeight3.TabIndex = 448
        Me.LeftTextLRStoneWeight3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LeftTextUDStoneWeight3
        '
        Me.LeftTextUDStoneWeight3.BackColor = System.Drawing.Color.FloralWhite
        Me.LeftTextUDStoneWeight3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_131_left1up", True))
        Me.LeftTextUDStoneWeight3.Location = New System.Drawing.Point(49, 406)
        Me.LeftTextUDStoneWeight3.Name = "LeftTextUDStoneWeight3"
        Me.LeftTextUDStoneWeight3.Size = New System.Drawing.Size(35, 21)
        Me.LeftTextUDStoneWeight3.TabIndex = 449
        Me.LeftTextUDStoneWeight3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(87, 409)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(95, 21)
        Me.Label25.TabIndex = 450
        Me.Label25.Text = "وزن الحجر3"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LeftTextLRStoneName3
        '
        Me.LeftTextLRStoneName3.BackColor = System.Drawing.Color.FloralWhite
        Me.LeftTextLRStoneName3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_130_left", True))
        Me.LeftTextLRStoneName3.Location = New System.Drawing.Point(10, 385)
        Me.LeftTextLRStoneName3.Name = "LeftTextLRStoneName3"
        Me.LeftTextLRStoneName3.Size = New System.Drawing.Size(35, 21)
        Me.LeftTextLRStoneName3.TabIndex = 445
        Me.LeftTextLRStoneName3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LeftTextUDStoneName3
        '
        Me.LeftTextUDStoneName3.BackColor = System.Drawing.Color.FloralWhite
        Me.LeftTextUDStoneName3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_130_left1up", True))
        Me.LeftTextUDStoneName3.Location = New System.Drawing.Point(49, 385)
        Me.LeftTextUDStoneName3.Name = "LeftTextUDStoneName3"
        Me.LeftTextUDStoneName3.Size = New System.Drawing.Size(35, 21)
        Me.LeftTextUDStoneName3.TabIndex = 446
        Me.LeftTextUDStoneName3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(87, 385)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(95, 21)
        Me.Label26.TabIndex = 447
        Me.Label26.Text = "نوع الحجر3"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LeftTextLRStoneWeight2
        '
        Me.LeftTextLRStoneWeight2.BackColor = System.Drawing.Color.FloralWhite
        Me.LeftTextLRStoneWeight2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_127_left", True))
        Me.LeftTextLRStoneWeight2.Location = New System.Drawing.Point(10, 347)
        Me.LeftTextLRStoneWeight2.Name = "LeftTextLRStoneWeight2"
        Me.LeftTextLRStoneWeight2.Size = New System.Drawing.Size(35, 21)
        Me.LeftTextLRStoneWeight2.TabIndex = 442
        Me.LeftTextLRStoneWeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LeftTextUDStoneWeight2
        '
        Me.LeftTextUDStoneWeight2.BackColor = System.Drawing.Color.FloralWhite
        Me.LeftTextUDStoneWeight2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_127_left1up", True))
        Me.LeftTextUDStoneWeight2.Location = New System.Drawing.Point(49, 347)
        Me.LeftTextUDStoneWeight2.Name = "LeftTextUDStoneWeight2"
        Me.LeftTextUDStoneWeight2.Size = New System.Drawing.Size(35, 21)
        Me.LeftTextUDStoneWeight2.TabIndex = 443
        Me.LeftTextUDStoneWeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(87, 347)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(95, 21)
        Me.Label23.TabIndex = 444
        Me.Label23.Text = "وزن الحجر2"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LeftTextLRStoneName2
        '
        Me.LeftTextLRStoneName2.BackColor = System.Drawing.Color.FloralWhite
        Me.LeftTextLRStoneName2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_126_left", True))
        Me.LeftTextLRStoneName2.Location = New System.Drawing.Point(10, 326)
        Me.LeftTextLRStoneName2.Name = "LeftTextLRStoneName2"
        Me.LeftTextLRStoneName2.Size = New System.Drawing.Size(35, 21)
        Me.LeftTextLRStoneName2.TabIndex = 439
        Me.LeftTextLRStoneName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LeftTextUDStoneName2
        '
        Me.LeftTextUDStoneName2.BackColor = System.Drawing.Color.FloralWhite
        Me.LeftTextUDStoneName2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_126_left1up", True))
        Me.LeftTextUDStoneName2.Location = New System.Drawing.Point(49, 326)
        Me.LeftTextUDStoneName2.Name = "LeftTextUDStoneName2"
        Me.LeftTextUDStoneName2.Size = New System.Drawing.Size(35, 21)
        Me.LeftTextUDStoneName2.TabIndex = 440
        Me.LeftTextUDStoneName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(87, 326)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 21)
        Me.Label24.TabIndex = 441
        Me.Label24.Text = "نوع الحجر2"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LeftTextLRStoneWeight1
        '
        Me.LeftTextLRStoneWeight1.BackColor = System.Drawing.Color.FloralWhite
        Me.LeftTextLRStoneWeight1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_123_left", True))
        Me.LeftTextLRStoneWeight1.Location = New System.Drawing.Point(10, 280)
        Me.LeftTextLRStoneWeight1.Name = "LeftTextLRStoneWeight1"
        Me.LeftTextLRStoneWeight1.Size = New System.Drawing.Size(35, 21)
        Me.LeftTextLRStoneWeight1.TabIndex = 436
        Me.LeftTextLRStoneWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LeftTextUDStoneWeight1
        '
        Me.LeftTextUDStoneWeight1.BackColor = System.Drawing.Color.FloralWhite
        Me.LeftTextUDStoneWeight1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_123_left1up", True))
        Me.LeftTextUDStoneWeight1.Location = New System.Drawing.Point(49, 280)
        Me.LeftTextUDStoneWeight1.Name = "LeftTextUDStoneWeight1"
        Me.LeftTextUDStoneWeight1.Size = New System.Drawing.Size(35, 21)
        Me.LeftTextUDStoneWeight1.TabIndex = 437
        Me.LeftTextUDStoneWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label67
        '
        Me.Label67.Location = New System.Drawing.Point(87, 280)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(95, 21)
        Me.Label67.TabIndex = 438
        Me.Label67.Text = "وزن الحجر1"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LeftTextLRStoneName1
        '
        Me.LeftTextLRStoneName1.BackColor = System.Drawing.Color.FloralWhite
        Me.LeftTextLRStoneName1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_122_left", True))
        Me.LeftTextLRStoneName1.Location = New System.Drawing.Point(10, 259)
        Me.LeftTextLRStoneName1.Name = "LeftTextLRStoneName1"
        Me.LeftTextLRStoneName1.Size = New System.Drawing.Size(35, 21)
        Me.LeftTextLRStoneName1.TabIndex = 433
        Me.LeftTextLRStoneName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LeftTextUDStoneName1
        '
        Me.LeftTextUDStoneName1.BackColor = System.Drawing.Color.FloralWhite
        Me.LeftTextUDStoneName1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_122_left1up", True))
        Me.LeftTextUDStoneName1.Location = New System.Drawing.Point(49, 259)
        Me.LeftTextUDStoneName1.Name = "LeftTextUDStoneName1"
        Me.LeftTextUDStoneName1.Size = New System.Drawing.Size(35, 21)
        Me.LeftTextUDStoneName1.TabIndex = 434
        Me.LeftTextUDStoneName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label66
        '
        Me.Label66.Location = New System.Drawing.Point(87, 259)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(95, 21)
        Me.Label66.TabIndex = 435
        Me.Label66.Text = "نوع الحجر1"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbHLeftText
        '
        Me.pbHLeftText.BackColor = System.Drawing.Color.White
        Me.pbHLeftText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbHLeftText.Image = Global.DT_restrant.My.Resources.Resources.ArrowLeftRight
        Me.pbHLeftText.Location = New System.Drawing.Point(10, 20)
        Me.pbHLeftText.Name = "pbHLeftText"
        Me.pbHLeftText.Size = New System.Drawing.Size(35, 35)
        Me.pbHLeftText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHLeftText.TabIndex = 421
        Me.pbHLeftText.TabStop = False
        '
        'Label56
        '
        Me.Label56.Location = New System.Drawing.Point(87, 112)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(95, 21)
        Me.Label56.TabIndex = 432
        Me.Label56.Text = "اسم المعرض"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbVLeftText
        '
        Me.pbVLeftText.BackColor = System.Drawing.Color.White
        Me.pbVLeftText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbVLeftText.Image = Global.DT_restrant.My.Resources.Resources.ArrowUpDown
        Me.pbVLeftText.Location = New System.Drawing.Point(49, 20)
        Me.pbVLeftText.Name = "pbVLeftText"
        Me.pbVLeftText.Size = New System.Drawing.Size(35, 35)
        Me.pbVLeftText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbVLeftText.TabIndex = 420
        Me.pbVLeftText.TabStop = False
        '
        'Label55
        '
        Me.Label55.Location = New System.Drawing.Point(87, 70)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(95, 21)
        Me.Label55.TabIndex = 432
        Me.Label55.Text = "القص"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label54
        '
        Me.Label54.Location = New System.Drawing.Point(87, 91)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(95, 21)
        Me.Label54.TabIndex = 432
        Me.Label54.Text = "اسم الصنف"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Note2TextBox1
        '
        Me.Note2TextBox1.BackColor = System.Drawing.Color.FloralWhite
        Me.Note2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "note2", True))
        Me.Note2TextBox1.Location = New System.Drawing.Point(49, 112)
        Me.Note2TextBox1.Name = "Note2TextBox1"
        Me.Note2TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Note2TextBox1.TabIndex = 5
        Me.Note2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NoteTextBox1
        '
        Me.NoteTextBox1.BackColor = System.Drawing.Color.FloralWhite
        Me.NoteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "note", True))
        Me.NoteTextBox1.Location = New System.Drawing.Point(10, 112)
        Me.NoteTextBox1.Name = "NoteTextBox1"
        Me.NoteTextBox1.Size = New System.Drawing.Size(35, 21)
        Me.NoteTextBox1.TabIndex = 4
        Me.NoteTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_12_leftTextBox
        '
        Me.Test_12_leftTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_12_leftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_12_left", True))
        Me.Test_12_leftTextBox.Location = New System.Drawing.Point(10, 70)
        Me.Test_12_leftTextBox.Name = "Test_12_leftTextBox"
        Me.Test_12_leftTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_12_leftTextBox.TabIndex = 0
        Me.Test_12_leftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_1_rightTextBox1
        '
        Me.Test_1_rightTextBox1.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_1_rightTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_1_right", True))
        Me.Test_1_rightTextBox1.Location = New System.Drawing.Point(49, 70)
        Me.Test_1_rightTextBox1.Name = "Test_1_rightTextBox1"
        Me.Test_1_rightTextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_1_rightTextBox1.TabIndex = 1
        Me.Test_1_rightTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_119_left1upTextBox
        '
        Me.Test_119_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_119_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_119_left1up", True))
        Me.Test_119_left1upTextBox.Location = New System.Drawing.Point(49, 469)
        Me.Test_119_left1upTextBox.Name = "Test_119_left1upTextBox"
        Me.Test_119_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_119_left1upTextBox.TabIndex = 19
        Me.Test_119_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_13_left1upTextBox
        '
        Me.Test_13_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_13_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_13_left1up", True))
        Me.Test_13_left1upTextBox.Location = New System.Drawing.Point(10, 490)
        Me.Test_13_left1upTextBox.Name = "Test_13_left1upTextBox"
        Me.Test_13_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_13_left1upTextBox.TabIndex = 20
        Me.Test_13_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_14_left1upTextBox
        '
        Me.Test_14_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_14_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_14_left1up", True))
        Me.Test_14_left1upTextBox.Location = New System.Drawing.Point(10, 217)
        Me.Test_14_left1upTextBox.Name = "Test_14_left1upTextBox"
        Me.Test_14_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_14_left1upTextBox.TabIndex = 14
        Me.Test_14_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_15_left1upTextBox
        '
        Me.Test_15_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_15_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_15_left1up", True))
        Me.Test_15_left1upTextBox.Location = New System.Drawing.Point(10, 196)
        Me.Test_15_left1upTextBox.Name = "Test_15_left1upTextBox"
        Me.Test_15_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_15_left1upTextBox.TabIndex = 12
        Me.Test_15_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_16_left1upTextBox
        '
        Me.Test_16_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_16_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_16_left1up", True))
        Me.Test_16_left1upTextBox.Location = New System.Drawing.Point(10, 175)
        Me.Test_16_left1upTextBox.Name = "Test_16_left1upTextBox"
        Me.Test_16_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_16_left1upTextBox.TabIndex = 10
        Me.Test_16_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_17_left1upTextBox
        '
        Me.Test_17_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_17_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_17_left1up", True))
        Me.Test_17_left1upTextBox.Location = New System.Drawing.Point(10, 154)
        Me.Test_17_left1upTextBox.Name = "Test_17_left1upTextBox"
        Me.Test_17_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_17_left1upTextBox.TabIndex = 8
        Me.Test_17_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_18_left1upTextBox
        '
        Me.Test_18_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_18_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_18_left1up", True))
        Me.Test_18_left1upTextBox.Location = New System.Drawing.Point(10, 238)
        Me.Test_18_left1upTextBox.Name = "Test_18_left1upTextBox"
        Me.Test_18_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_18_left1upTextBox.TabIndex = 16
        Me.Test_18_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_19_left1upTextBox
        '
        Me.Test_19_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_19_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_19_left1up", True))
        Me.Test_19_left1upTextBox.Location = New System.Drawing.Point(10, 133)
        Me.Test_19_left1upTextBox.Name = "Test_19_left1upTextBox"
        Me.Test_19_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_19_left1upTextBox.TabIndex = 6
        Me.Test_19_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_110_left1upTextBox
        '
        Me.Test_110_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_110_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_110_left1up", True))
        Me.Test_110_left1upTextBox.Location = New System.Drawing.Point(10, 469)
        Me.Test_110_left1upTextBox.Name = "Test_110_left1upTextBox"
        Me.Test_110_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_110_left1upTextBox.TabIndex = 18
        Me.Test_110_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_112_left1upTextBox
        '
        Me.Test_112_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_112_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_112_left1up", True))
        Me.Test_112_left1upTextBox.Location = New System.Drawing.Point(49, 490)
        Me.Test_112_left1upTextBox.Name = "Test_112_left1upTextBox"
        Me.Test_112_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_112_left1upTextBox.TabIndex = 21
        Me.Test_112_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_113_left1upTextBox
        '
        Me.Test_113_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_113_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_113_left1up", True))
        Me.Test_113_left1upTextBox.Location = New System.Drawing.Point(49, 217)
        Me.Test_113_left1upTextBox.Name = "Test_113_left1upTextBox"
        Me.Test_113_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_113_left1upTextBox.TabIndex = 15
        Me.Test_113_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_114_left1upTextBox
        '
        Me.Test_114_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_114_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_114_left1up", True))
        Me.Test_114_left1upTextBox.Location = New System.Drawing.Point(49, 196)
        Me.Test_114_left1upTextBox.Name = "Test_114_left1upTextBox"
        Me.Test_114_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_114_left1upTextBox.TabIndex = 13
        Me.Test_114_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_115_left1upTextBox
        '
        Me.Test_115_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_115_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_115_left1up", True))
        Me.Test_115_left1upTextBox.Location = New System.Drawing.Point(49, 175)
        Me.Test_115_left1upTextBox.Name = "Test_115_left1upTextBox"
        Me.Test_115_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_115_left1upTextBox.TabIndex = 11
        Me.Test_115_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_116_left1upTextBox
        '
        Me.Test_116_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_116_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_116_left1up", True))
        Me.Test_116_left1upTextBox.Location = New System.Drawing.Point(49, 154)
        Me.Test_116_left1upTextBox.Name = "Test_116_left1upTextBox"
        Me.Test_116_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_116_left1upTextBox.TabIndex = 9
        Me.Test_116_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_117_left1upTextBox
        '
        Me.Test_117_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_117_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_117_left1up", True))
        Me.Test_117_left1upTextBox.Location = New System.Drawing.Point(49, 238)
        Me.Test_117_left1upTextBox.Name = "Test_117_left1upTextBox"
        Me.Test_117_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_117_left1upTextBox.TabIndex = 17
        Me.Test_117_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_118_left1upTextBox
        '
        Me.Test_118_left1upTextBox.BackColor = System.Drawing.Color.FloralWhite
        Me.Test_118_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_118_left1up", True))
        Me.Test_118_left1upTextBox.Location = New System.Drawing.Point(49, 133)
        Me.Test_118_left1upTextBox.Name = "Test_118_left1upTextBox"
        Me.Test_118_left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_118_left1upTextBox.TabIndex = 7
        Me.Test_118_left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(87, 490)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 21)
        Me.Label4.TabIndex = 322
        Me.Label4.Text = "الاسم"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(87, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 21)
        Me.Label5.TabIndex = 323
        Me.Label5.Text = "النقاوة"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(87, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 21)
        Me.Label7.TabIndex = 324
        Me.Label7.Text = "القيراط"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(87, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 21)
        Me.Label6.TabIndex = 325
        Me.Label6.Text = "اللون"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(87, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 21)
        Me.Label11.TabIndex = 326
        Me.Label11.Text = "عيار الذهب"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(87, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 21)
        Me.Label10.TabIndex = 327
        Me.Label10.Text = "وزن الذهب"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SET1
        '
        Me.SET1.Location = New System.Drawing.Point(87, 133)
        Me.SET1.Name = "SET1"
        Me.SET1.Size = New System.Drawing.Size(95, 21)
        Me.SET1.TabIndex = 328
        Me.SET1.Text = "السعر"
        Me.SET1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(87, 469)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 21)
        Me.Label8.TabIndex = 329
        Me.Label8.Text = "رقم القطعة"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbLeftValue
        '
        Me.gbLeftValue.BackColor = System.Drawing.Color.Ivory
        Me.gbLeftValue.Controls.Add(Me.TotalStoneWeight_LeftupTextBox)
        Me.gbLeftValue.Controls.Add(Me.TotalStoneWeight_Left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.lblTotalStoneWeightLeft)
        Me.gbLeftValue.Controls.Add(Me.lblCut3Left)
        Me.gbLeftValue.Controls.Add(Me.Cut3_Left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.Cut3_LeftupTextBox)
        Me.gbLeftValue.Controls.Add(Me.lblCut2Left)
        Me.gbLeftValue.Controls.Add(Me.Cut2_Left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.Cut2_LeftupTextBox)
        Me.gbLeftValue.Controls.Add(Me.Cut1_LeftupTextBox)
        Me.gbLeftValue.Controls.Add(Me.Label82)
        Me.gbLeftValue.Controls.Add(Me.Cut1_Left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.Code_Left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.lblCut1Left)
        Me.gbLeftValue.Controls.Add(Me.Code_LeftupTextBox)
        Me.gbLeftValue.Controls.Add(Me.Label13)
        Me.gbLeftValue.Controls.Add(Me.LeftValueUDStoneWeight3)
        Me.gbLeftValue.Controls.Add(Me.LeftValueLRStoneWeight3)
        Me.gbLeftValue.Controls.Add(Me.Label22)
        Me.gbLeftValue.Controls.Add(Me.LeftValueUDStoneName3)
        Me.gbLeftValue.Controls.Add(Me.LeftValueLRStoneName3)
        Me.gbLeftValue.Controls.Add(Me.Label9)
        Me.gbLeftValue.Controls.Add(Me.LeftValueUDStoneWeight2)
        Me.gbLeftValue.Controls.Add(Me.LeftValueLRStoneWeight2)
        Me.gbLeftValue.Controls.Add(Me.Label12)
        Me.gbLeftValue.Controls.Add(Me.LeftValueUDStoneName2)
        Me.gbLeftValue.Controls.Add(Me.LeftValueLRStoneName2)
        Me.gbLeftValue.Controls.Add(Me.Label69)
        Me.gbLeftValue.Controls.Add(Me.LeftValueUDStoneWeight1)
        Me.gbLeftValue.Controls.Add(Me.LeftValueLRStoneWeight1)
        Me.gbLeftValue.Controls.Add(Me.Label68)
        Me.gbLeftValue.Controls.Add(Me.LeftValueUDStoneName1)
        Me.gbLeftValue.Controls.Add(Me.LeftValueLRStoneName1)
        Me.gbLeftValue.Controls.Add(Me.Label53)
        Me.gbLeftValue.Controls.Add(Me.Label52)
        Me.gbLeftValue.Controls.Add(Me.Label51)
        Me.gbLeftValue.Controls.Add(Me.Label50)
        Me.gbLeftValue.Controls.Add(Me.Label49)
        Me.gbLeftValue.Controls.Add(Me.Label48)
        Me.gbLeftValue.Controls.Add(Me.Label47)
        Me.gbLeftValue.Controls.Add(Me.Label46)
        Me.gbLeftValue.Controls.Add(Me.Label2)
        Me.gbLeftValue.Controls.Add(Me.pbHLeftValue)
        Me.gbLeftValue.Controls.Add(Me.pbVLeftValue)
        Me.gbLeftValue.Controls.Add(Me.Test_1_left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.GOLD_mezan_left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.Val_gold_left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.Sarual_left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.Qult_left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.Ext_coler_left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.DIMO_mezan_left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.DIM_na9awa_left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.DIMOND_ID_left1upTextBox)
        Me.gbLeftValue.Controls.Add(Me.DIMOND_ID_leftTextBox)
        Me.gbLeftValue.Controls.Add(Me.DIM_na9awa_leftTextBox)
        Me.gbLeftValue.Controls.Add(Me.DIMO_mezan_leftTextBox)
        Me.gbLeftValue.Controls.Add(Me.Ext_coler_leftTextBox)
        Me.gbLeftValue.Controls.Add(Me.Qult_leftTextBox)
        Me.gbLeftValue.Controls.Add(Me.Sarual_leftTextBox)
        Me.gbLeftValue.Controls.Add(Me.Val_gold_leftTextBox)
        Me.gbLeftValue.Controls.Add(Me.GOLD_mezan_leftTextBox)
        Me.gbLeftValue.Controls.Add(Me.Test_1_leftTextBox)
        Me.gbLeftValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbLeftValue.Location = New System.Drawing.Point(1, 3)
        Me.gbLeftValue.Name = "gbLeftValue"
        Me.gbLeftValue.Size = New System.Drawing.Size(194, 535)
        Me.gbLeftValue.TabIndex = 0
        Me.gbLeftValue.TabStop = False
        Me.gbLeftValue.Text = "قيم الباركود"
        '
        'TotalStoneWeight_LeftupTextBox
        '
        Me.TotalStoneWeight_LeftupTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.TotalStoneWeight_LeftupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "TotalStoneWeight_Leftup", True))
        Me.TotalStoneWeight_LeftupTextBox.Location = New System.Drawing.Point(10, 448)
        Me.TotalStoneWeight_LeftupTextBox.Name = "TotalStoneWeight_LeftupTextBox"
        Me.TotalStoneWeight_LeftupTextBox.Size = New System.Drawing.Size(35, 21)
        Me.TotalStoneWeight_LeftupTextBox.TabIndex = 460
        Me.TotalStoneWeight_LeftupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalStoneWeight_Left1upTextBox
        '
        Me.TotalStoneWeight_Left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.TotalStoneWeight_Left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "TotalStoneWeight_Left1up", True))
        Me.TotalStoneWeight_Left1upTextBox.Location = New System.Drawing.Point(49, 448)
        Me.TotalStoneWeight_Left1upTextBox.Name = "TotalStoneWeight_Left1upTextBox"
        Me.TotalStoneWeight_Left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.TotalStoneWeight_Left1upTextBox.TabIndex = 461
        Me.TotalStoneWeight_Left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalStoneWeightLeft
        '
        Me.lblTotalStoneWeightLeft.Location = New System.Drawing.Point(89, 448)
        Me.lblTotalStoneWeightLeft.Name = "lblTotalStoneWeightLeft"
        Me.lblTotalStoneWeightLeft.Size = New System.Drawing.Size(95, 21)
        Me.lblTotalStoneWeightLeft.TabIndex = 462
        Me.lblTotalStoneWeightLeft.Text = "وزن إجمالي للفصوص"
        Me.lblTotalStoneWeightLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCut3Left
        '
        Me.lblCut3Left.Location = New System.Drawing.Point(89, 427)
        Me.lblCut3Left.Name = "lblCut3Left"
        Me.lblCut3Left.Size = New System.Drawing.Size(95, 21)
        Me.lblCut3Left.TabIndex = 459
        Me.lblCut3Left.Text = "قصة الحجر3"
        Me.lblCut3Left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cut3_Left1upTextBox
        '
        Me.Cut3_Left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Cut3_Left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Cut3_Left1up", True))
        Me.Cut3_Left1upTextBox.Location = New System.Drawing.Point(49, 427)
        Me.Cut3_Left1upTextBox.Name = "Cut3_Left1upTextBox"
        Me.Cut3_Left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut3_Left1upTextBox.TabIndex = 458
        Me.Cut3_Left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cut3_LeftupTextBox
        '
        Me.Cut3_LeftupTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Cut3_LeftupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Cut3_Leftup", True))
        Me.Cut3_LeftupTextBox.Location = New System.Drawing.Point(10, 427)
        Me.Cut3_LeftupTextBox.Name = "Cut3_LeftupTextBox"
        Me.Cut3_LeftupTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut3_LeftupTextBox.TabIndex = 457
        Me.Cut3_LeftupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCut2Left
        '
        Me.lblCut2Left.Location = New System.Drawing.Point(89, 364)
        Me.lblCut2Left.Name = "lblCut2Left"
        Me.lblCut2Left.Size = New System.Drawing.Size(95, 21)
        Me.lblCut2Left.TabIndex = 456
        Me.lblCut2Left.Text = "قصة الحجر2"
        Me.lblCut2Left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cut2_Left1upTextBox
        '
        Me.Cut2_Left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Cut2_Left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Cut2_Left1up", True))
        Me.Cut2_Left1upTextBox.Location = New System.Drawing.Point(49, 364)
        Me.Cut2_Left1upTextBox.Name = "Cut2_Left1upTextBox"
        Me.Cut2_Left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut2_Left1upTextBox.TabIndex = 455
        Me.Cut2_Left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cut2_LeftupTextBox
        '
        Me.Cut2_LeftupTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Cut2_LeftupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Cut2_Leftup", True))
        Me.Cut2_LeftupTextBox.Location = New System.Drawing.Point(10, 364)
        Me.Cut2_LeftupTextBox.Name = "Cut2_LeftupTextBox"
        Me.Cut2_LeftupTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut2_LeftupTextBox.TabIndex = 454
        Me.Cut2_LeftupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cut1_LeftupTextBox
        '
        Me.Cut1_LeftupTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Cut1_LeftupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Cut1_Leftup", True))
        Me.Cut1_LeftupTextBox.Location = New System.Drawing.Point(10, 301)
        Me.Cut1_LeftupTextBox.Name = "Cut1_LeftupTextBox"
        Me.Cut1_LeftupTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut1_LeftupTextBox.TabIndex = 451
        Me.Cut1_LeftupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label82
        '
        Me.Label82.Location = New System.Drawing.Point(89, 490)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(95, 21)
        Me.Label82.TabIndex = 453
        Me.Label82.Text = "الرمز"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cut1_Left1upTextBox
        '
        Me.Cut1_Left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Cut1_Left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Cut1_Left1up", True))
        Me.Cut1_Left1upTextBox.Location = New System.Drawing.Point(49, 301)
        Me.Cut1_Left1upTextBox.Name = "Cut1_Left1upTextBox"
        Me.Cut1_Left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut1_Left1upTextBox.TabIndex = 452
        Me.Cut1_Left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Code_Left1upTextBox
        '
        Me.Code_Left1upTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Code_Left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Code_Left1up", True))
        Me.Code_Left1upTextBox.Location = New System.Drawing.Point(49, 490)
        Me.Code_Left1upTextBox.Name = "Code_Left1upTextBox"
        Me.Code_Left1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Code_Left1upTextBox.TabIndex = 452
        Me.Code_Left1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCut1Left
        '
        Me.lblCut1Left.Location = New System.Drawing.Point(89, 301)
        Me.lblCut1Left.Name = "lblCut1Left"
        Me.lblCut1Left.Size = New System.Drawing.Size(95, 21)
        Me.lblCut1Left.TabIndex = 453
        Me.lblCut1Left.Text = "قصة الحجر1"
        Me.lblCut1Left.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Code_LeftupTextBox
        '
        Me.Code_LeftupTextBox.BackColor = System.Drawing.Color.PeachPuff
        Me.Code_LeftupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "Code_Leftup", True))
        Me.Code_LeftupTextBox.Location = New System.Drawing.Point(10, 490)
        Me.Code_LeftupTextBox.Name = "Code_LeftupTextBox"
        Me.Code_LeftupTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Code_LeftupTextBox.TabIndex = 451
        Me.Code_LeftupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(89, 406)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 21)
        Me.Label13.TabIndex = 450
        Me.Label13.Text = "وزن الحجر3"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LeftValueUDStoneWeight3
        '
        Me.LeftValueUDStoneWeight3.BackColor = System.Drawing.Color.PeachPuff
        Me.LeftValueUDStoneWeight3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_129_left1up", True))
        Me.LeftValueUDStoneWeight3.Location = New System.Drawing.Point(49, 406)
        Me.LeftValueUDStoneWeight3.Name = "LeftValueUDStoneWeight3"
        Me.LeftValueUDStoneWeight3.Size = New System.Drawing.Size(35, 21)
        Me.LeftValueUDStoneWeight3.TabIndex = 449
        Me.LeftValueUDStoneWeight3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LeftValueLRStoneWeight3
        '
        Me.LeftValueLRStoneWeight3.BackColor = System.Drawing.Color.PeachPuff
        Me.LeftValueLRStoneWeight3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_129_left", True))
        Me.LeftValueLRStoneWeight3.Location = New System.Drawing.Point(10, 406)
        Me.LeftValueLRStoneWeight3.Name = "LeftValueLRStoneWeight3"
        Me.LeftValueLRStoneWeight3.Size = New System.Drawing.Size(35, 21)
        Me.LeftValueLRStoneWeight3.TabIndex = 448
        Me.LeftValueLRStoneWeight3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(89, 385)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(95, 21)
        Me.Label22.TabIndex = 447
        Me.Label22.Text = "نوع الحجر3"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LeftValueUDStoneName3
        '
        Me.LeftValueUDStoneName3.BackColor = System.Drawing.Color.PeachPuff
        Me.LeftValueUDStoneName3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_128_left1up", True))
        Me.LeftValueUDStoneName3.Location = New System.Drawing.Point(49, 385)
        Me.LeftValueUDStoneName3.Name = "LeftValueUDStoneName3"
        Me.LeftValueUDStoneName3.Size = New System.Drawing.Size(35, 21)
        Me.LeftValueUDStoneName3.TabIndex = 446
        Me.LeftValueUDStoneName3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LeftValueLRStoneName3
        '
        Me.LeftValueLRStoneName3.BackColor = System.Drawing.Color.PeachPuff
        Me.LeftValueLRStoneName3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_128_left", True))
        Me.LeftValueLRStoneName3.Location = New System.Drawing.Point(10, 385)
        Me.LeftValueLRStoneName3.Name = "LeftValueLRStoneName3"
        Me.LeftValueLRStoneName3.Size = New System.Drawing.Size(35, 21)
        Me.LeftValueLRStoneName3.TabIndex = 445
        Me.LeftValueLRStoneName3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(89, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 21)
        Me.Label9.TabIndex = 444
        Me.Label9.Text = "وزن الحجر2"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LeftValueUDStoneWeight2
        '
        Me.LeftValueUDStoneWeight2.BackColor = System.Drawing.Color.PeachPuff
        Me.LeftValueUDStoneWeight2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_125_left1up", True))
        Me.LeftValueUDStoneWeight2.Location = New System.Drawing.Point(49, 343)
        Me.LeftValueUDStoneWeight2.Name = "LeftValueUDStoneWeight2"
        Me.LeftValueUDStoneWeight2.Size = New System.Drawing.Size(35, 21)
        Me.LeftValueUDStoneWeight2.TabIndex = 443
        Me.LeftValueUDStoneWeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LeftValueLRStoneWeight2
        '
        Me.LeftValueLRStoneWeight2.BackColor = System.Drawing.Color.PeachPuff
        Me.LeftValueLRStoneWeight2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_125_left", True))
        Me.LeftValueLRStoneWeight2.Location = New System.Drawing.Point(10, 343)
        Me.LeftValueLRStoneWeight2.Name = "LeftValueLRStoneWeight2"
        Me.LeftValueLRStoneWeight2.Size = New System.Drawing.Size(35, 21)
        Me.LeftValueLRStoneWeight2.TabIndex = 442
        Me.LeftValueLRStoneWeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(89, 322)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 21)
        Me.Label12.TabIndex = 441
        Me.Label12.Text = "نوع الحجر2"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LeftValueUDStoneName2
        '
        Me.LeftValueUDStoneName2.BackColor = System.Drawing.Color.PeachPuff
        Me.LeftValueUDStoneName2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_124_left1up", True))
        Me.LeftValueUDStoneName2.Location = New System.Drawing.Point(49, 322)
        Me.LeftValueUDStoneName2.Name = "LeftValueUDStoneName2"
        Me.LeftValueUDStoneName2.Size = New System.Drawing.Size(35, 21)
        Me.LeftValueUDStoneName2.TabIndex = 440
        Me.LeftValueUDStoneName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LeftValueLRStoneName2
        '
        Me.LeftValueLRStoneName2.BackColor = System.Drawing.Color.PeachPuff
        Me.LeftValueLRStoneName2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_124_left", True))
        Me.LeftValueLRStoneName2.Location = New System.Drawing.Point(10, 322)
        Me.LeftValueLRStoneName2.Name = "LeftValueLRStoneName2"
        Me.LeftValueLRStoneName2.Size = New System.Drawing.Size(35, 21)
        Me.LeftValueLRStoneName2.TabIndex = 439
        Me.LeftValueLRStoneName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(89, 280)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(95, 21)
        Me.Label69.TabIndex = 438
        Me.Label69.Text = "وزن الحجر1"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LeftValueUDStoneWeight1
        '
        Me.LeftValueUDStoneWeight1.BackColor = System.Drawing.Color.PeachPuff
        Me.LeftValueUDStoneWeight1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_121_left1up", True))
        Me.LeftValueUDStoneWeight1.Location = New System.Drawing.Point(49, 280)
        Me.LeftValueUDStoneWeight1.Name = "LeftValueUDStoneWeight1"
        Me.LeftValueUDStoneWeight1.Size = New System.Drawing.Size(35, 21)
        Me.LeftValueUDStoneWeight1.TabIndex = 437
        Me.LeftValueUDStoneWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LeftValueLRStoneWeight1
        '
        Me.LeftValueLRStoneWeight1.BackColor = System.Drawing.Color.PeachPuff
        Me.LeftValueLRStoneWeight1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_121_left", True))
        Me.LeftValueLRStoneWeight1.Location = New System.Drawing.Point(10, 280)
        Me.LeftValueLRStoneWeight1.Name = "LeftValueLRStoneWeight1"
        Me.LeftValueLRStoneWeight1.Size = New System.Drawing.Size(35, 21)
        Me.LeftValueLRStoneWeight1.TabIndex = 436
        Me.LeftValueLRStoneWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label68
        '
        Me.Label68.Location = New System.Drawing.Point(89, 259)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(95, 21)
        Me.Label68.TabIndex = 435
        Me.Label68.Text = "نوع الحجر1"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LeftValueUDStoneName1
        '
        Me.LeftValueUDStoneName1.BackColor = System.Drawing.Color.PeachPuff
        Me.LeftValueUDStoneName1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_120_left1up", True))
        Me.LeftValueUDStoneName1.Location = New System.Drawing.Point(49, 259)
        Me.LeftValueUDStoneName1.Name = "LeftValueUDStoneName1"
        Me.LeftValueUDStoneName1.Size = New System.Drawing.Size(35, 21)
        Me.LeftValueUDStoneName1.TabIndex = 434
        Me.LeftValueUDStoneName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LeftValueLRStoneName1
        '
        Me.LeftValueLRStoneName1.BackColor = System.Drawing.Color.PeachPuff
        Me.LeftValueLRStoneName1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_120_left", True))
        Me.LeftValueLRStoneName1.Location = New System.Drawing.Point(10, 259)
        Me.LeftValueLRStoneName1.Name = "LeftValueLRStoneName1"
        Me.LeftValueLRStoneName1.Size = New System.Drawing.Size(35, 21)
        Me.LeftValueLRStoneName1.TabIndex = 433
        Me.LeftValueLRStoneName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(89, 238)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(95, 21)
        Me.Label53.TabIndex = 432
        Me.Label53.Text = "وزن الذهب"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label52
        '
        Me.Label52.Location = New System.Drawing.Point(89, 154)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(95, 21)
        Me.Label52.TabIndex = 432
        Me.Label52.Text = "عيار الذهب"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(89, 469)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(95, 21)
        Me.Label51.TabIndex = 432
        Me.Label51.Text = "رقم القطعة"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label50
        '
        Me.Label50.Location = New System.Drawing.Point(89, 133)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(95, 21)
        Me.Label50.TabIndex = 432
        Me.Label50.Text = "السعر"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(89, 175)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(95, 21)
        Me.Label49.TabIndex = 432
        Me.Label49.Text = "اللون"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label48
        '
        Me.Label48.Location = New System.Drawing.Point(89, 196)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(95, 21)
        Me.Label48.TabIndex = 432
        Me.Label48.Text = "القيراط"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label47
        '
        Me.Label47.Location = New System.Drawing.Point(89, 217)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(95, 21)
        Me.Label47.TabIndex = 432
        Me.Label47.Text = "النقاوة"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(89, 91)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(95, 21)
        Me.Label46.TabIndex = 432
        Me.Label46.Text = "الباركود"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(89, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 422
        Me.Label2.Text = "رقم الباركود"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbHLeftValue
        '
        Me.pbHLeftValue.BackColor = System.Drawing.Color.White
        Me.pbHLeftValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbHLeftValue.Image = Global.DT_restrant.My.Resources.Resources.ArrowLeftRight
        Me.pbHLeftValue.Location = New System.Drawing.Point(10, 20)
        Me.pbHLeftValue.Name = "pbHLeftValue"
        Me.pbHLeftValue.Size = New System.Drawing.Size(35, 35)
        Me.pbHLeftValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHLeftValue.TabIndex = 417
        Me.pbHLeftValue.TabStop = False
        '
        'pbVLeftValue
        '
        Me.pbVLeftValue.BackColor = System.Drawing.Color.White
        Me.pbVLeftValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbVLeftValue.Image = Global.DT_restrant.My.Resources.Resources.ArrowUpDown
        Me.pbVLeftValue.Location = New System.Drawing.Point(49, 20)
        Me.pbVLeftValue.Name = "pbVLeftValue"
        Me.pbVLeftValue.Size = New System.Drawing.Size(35, 35)
        Me.pbVLeftValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbVLeftValue.TabIndex = 416
        Me.pbVLeftValue.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSave.ForeColor = System.Drawing.Color.Maroon
        Me.btnSave.Image = Global.DT_restrant.My.Resources.Resources.DiskOk
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(760, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 75)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cmbCompanyName
        '
        Me.cmbCompanyName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbCompanyName.DataSource = Me.CompinformBindingSource
        Me.cmbCompanyName.DisplayMember = "comp_note1"
        Me.cmbCompanyName.FormattingEnabled = True
        Me.cmbCompanyName.Location = New System.Drawing.Point(9, 45)
        Me.cmbCompanyName.Name = "cmbCompanyName"
        Me.cmbCompanyName.Size = New System.Drawing.Size(195, 21)
        Me.cmbCompanyName.TabIndex = 0
        Me.cmbCompanyName.ValueMember = "comp_note1"
        '
        'CompinformBindingSource
        '
        Me.CompinformBindingSource.DataMember = "comp_inform"
        Me.CompinformBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.GhostWhite
        Me.btnPrint.ForeColor = System.Drawing.Color.Maroon
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(873, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(107, 75)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Comp_informTableAdapter
        '
        Me.Comp_informTableAdapter.ClearBeforeFill = True
        '
        'cmbPrinterName
        '
        Me.cmbPrinterName.FormattingEnabled = True
        Me.cmbPrinterName.Location = New System.Drawing.Point(210, 45)
        Me.cmbPrinterName.Name = "cmbPrinterName"
        Me.cmbPrinterName.Size = New System.Drawing.Size(195, 21)
        Me.cmbPrinterName.TabIndex = 1
        '
        'cmbLeftItem
        '
        Me.cmbLeftItem.DataSource = Me.DIMONBARICOODFORSELECTLEFTBindingSource
        Me.cmbLeftItem.DisplayMember = "DIMON_NAME"
        Me.cmbLeftItem.FormattingEnabled = True
        Me.cmbLeftItem.Location = New System.Drawing.Point(157, 104)
        Me.cmbLeftItem.Name = "cmbLeftItem"
        Me.cmbLeftItem.Size = New System.Drawing.Size(257, 21)
        Me.cmbLeftItem.TabIndex = 7
        Me.cmbLeftItem.ValueMember = "test_119"
        '
        'DIMONBARICOODFORSELECTLEFTBindingSource
        '
        Me.DIMONBARICOODFORSELECTLEFTBindingSource.DataMember = "DIMON_BARICOOD_FOR_SELECT_LEFT"
        Me.DIMONBARICOODFORSELECTLEFTBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'cmbRightItem
        '
        Me.cmbRightItem.DataSource = Me.DIMONBARICOODSELECTRIGHTBindingSource
        Me.cmbRightItem.DisplayMember = "DIMON_NAME"
        Me.cmbRightItem.FormattingEnabled = True
        Me.cmbRightItem.Location = New System.Drawing.Point(582, 104)
        Me.cmbRightItem.Name = "cmbRightItem"
        Me.cmbRightItem.Size = New System.Drawing.Size(257, 21)
        Me.cmbRightItem.TabIndex = 6
        Me.cmbRightItem.ValueMember = "test_119"
        '
        'DIMONBARICOODSELECTRIGHTBindingSource
        '
        Me.DIMONBARICOODSELECTRIGHTBindingSource.DataMember = "DIMON_BARICOOD_SELECT_RIGHT"
        Me.DIMONBARICOODSELECTRIGHTBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DIMON_BARICOOD_FOR_SELECT_LEFTTableAdapter
        '
        Me.DIMON_BARICOOD_FOR_SELECT_LEFTTableAdapter.ClearBeforeFill = True
        '
        'DIMON_BARICOOD_SELECT_RIGHTTableAdapter
        '
        Me.DIMON_BARICOOD_SELECT_RIGHTTableAdapter.ClearBeforeFill = True
        '
        'DIMOND_IDTextBox
        '
        Me.DIMOND_IDTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIMOND_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "DIMOND_ID", True))
        Me.DIMOND_IDTextBox.Location = New System.Drawing.Point(-92, 168)
        Me.DIMOND_IDTextBox.Name = "DIMOND_IDTextBox"
        Me.DIMOND_IDTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMOND_IDTextBox.TabIndex = 186
        '
        'DIMON_NAMETextBox
        '
        Me.DIMON_NAMETextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIMON_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "DIMON_NAME", True))
        Me.DIMON_NAMETextBox.Location = New System.Drawing.Point(-92, 147)
        Me.DIMON_NAMETextBox.Name = "DIMON_NAMETextBox"
        Me.DIMON_NAMETextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMON_NAMETextBox.TabIndex = 188
        '
        'DIM_na9awaTextBox
        '
        Me.DIM_na9awaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIM_na9awaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "DIM_na9awa", True))
        Me.DIM_na9awaTextBox.Location = New System.Drawing.Point(-92, 126)
        Me.DIM_na9awaTextBox.Name = "DIM_na9awaTextBox"
        Me.DIM_na9awaTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIM_na9awaTextBox.TabIndex = 190
        '
        'DIMO_mezanTextBox
        '
        Me.DIMO_mezanTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIMO_mezanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "DIMO_mezan", True))
        Me.DIMO_mezanTextBox.Location = New System.Drawing.Point(-92, 21)
        Me.DIMO_mezanTextBox.Name = "DIMO_mezanTextBox"
        Me.DIMO_mezanTextBox.Size = New System.Drawing.Size(35, 21)
        Me.DIMO_mezanTextBox.TabIndex = 192
        '
        'Ext_colerTextBox
        '
        Me.Ext_colerTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ext_colerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "ext_coler", True))
        Me.Ext_colerTextBox.Location = New System.Drawing.Point(-92, 189)
        Me.Ext_colerTextBox.Name = "Ext_colerTextBox"
        Me.Ext_colerTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Ext_colerTextBox.TabIndex = 194
        '
        'QultTextBox
        '
        Me.QultTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QultTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "qult", True))
        Me.QultTextBox.Location = New System.Drawing.Point(-92, 105)
        Me.QultTextBox.Name = "QultTextBox"
        Me.QultTextBox.Size = New System.Drawing.Size(35, 21)
        Me.QultTextBox.TabIndex = 196
        '
        'SarualTextBox
        '
        Me.SarualTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SarualTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "sarual", True))
        Me.SarualTextBox.Location = New System.Drawing.Point(-92, 84)
        Me.SarualTextBox.Name = "SarualTextBox"
        Me.SarualTextBox.Size = New System.Drawing.Size(35, 21)
        Me.SarualTextBox.TabIndex = 198
        '
        'Val_goldTextBox
        '
        Me.Val_goldTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Val_goldTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "val_gold", True))
        Me.Val_goldTextBox.Location = New System.Drawing.Point(-92, 63)
        Me.Val_goldTextBox.Name = "Val_goldTextBox"
        Me.Val_goldTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Val_goldTextBox.TabIndex = 200
        '
        'GOLD_mezanTextBox
        '
        Me.GOLD_mezanTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GOLD_mezanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "GOLD_mezan", True))
        Me.GOLD_mezanTextBox.Location = New System.Drawing.Point(-92, 42)
        Me.GOLD_mezanTextBox.Name = "GOLD_mezanTextBox"
        Me.GOLD_mezanTextBox.Size = New System.Drawing.Size(35, 21)
        Me.GOLD_mezanTextBox.TabIndex = 202
        '
        'Test_1TextBox
        '
        Me.Test_1TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_1", True))
        Me.Test_1TextBox.Location = New System.Drawing.Point(-44, 21)
        Me.Test_1TextBox.Name = "Test_1TextBox"
        Me.Test_1TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_1TextBox.TabIndex = 204
        '
        'Test_11TextBox
        '
        Me.Test_11TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_11TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_11", True))
        Me.Test_11TextBox.Location = New System.Drawing.Point(-44, 42)
        Me.Test_11TextBox.Name = "Test_11TextBox"
        Me.Test_11TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_11TextBox.TabIndex = 206
        '
        'Test_12TextBox
        '
        Me.Test_12TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_12TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_12", True))
        Me.Test_12TextBox.Location = New System.Drawing.Point(-44, 63)
        Me.Test_12TextBox.Name = "Test_12TextBox"
        Me.Test_12TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_12TextBox.TabIndex = 208
        '
        'Test_13TextBox
        '
        Me.Test_13TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_13TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_13", True))
        Me.Test_13TextBox.Location = New System.Drawing.Point(-44, 84)
        Me.Test_13TextBox.Name = "Test_13TextBox"
        Me.Test_13TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_13TextBox.TabIndex = 210
        '
        'Test_14TextBox
        '
        Me.Test_14TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_14TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_14", True))
        Me.Test_14TextBox.Location = New System.Drawing.Point(-44, 105)
        Me.Test_14TextBox.Name = "Test_14TextBox"
        Me.Test_14TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_14TextBox.TabIndex = 212
        '
        'Test_15TextBox
        '
        Me.Test_15TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_15TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_15", True))
        Me.Test_15TextBox.Location = New System.Drawing.Point(-44, 126)
        Me.Test_15TextBox.Name = "Test_15TextBox"
        Me.Test_15TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_15TextBox.TabIndex = 214
        '
        'Test_16TextBox
        '
        Me.Test_16TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_16TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_16", True))
        Me.Test_16TextBox.Location = New System.Drawing.Point(-44, 147)
        Me.Test_16TextBox.Name = "Test_16TextBox"
        Me.Test_16TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_16TextBox.TabIndex = 216
        '
        'Test_17TextBox
        '
        Me.Test_17TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_17TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_17", True))
        Me.Test_17TextBox.Location = New System.Drawing.Point(-44, 168)
        Me.Test_17TextBox.Name = "Test_17TextBox"
        Me.Test_17TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_17TextBox.TabIndex = 218
        '
        'Test_18TextBox
        '
        Me.Test_18TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_18TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_18", True))
        Me.Test_18TextBox.Location = New System.Drawing.Point(-44, 189)
        Me.Test_18TextBox.Name = "Test_18TextBox"
        Me.Test_18TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_18TextBox.TabIndex = 220
        '
        'Test_19TextBox
        '
        Me.Test_19TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_19TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_19", True))
        Me.Test_19TextBox.Location = New System.Drawing.Point(-44, 210)
        Me.Test_19TextBox.Name = "Test_19TextBox"
        Me.Test_19TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_19TextBox.TabIndex = 222
        '
        'Test_110TextBox
        '
        Me.Test_110TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_110TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_110", True))
        Me.Test_110TextBox.Location = New System.Drawing.Point(-44, 231)
        Me.Test_110TextBox.Name = "Test_110TextBox"
        Me.Test_110TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_110TextBox.TabIndex = 224
        '
        'Test_111TextBox
        '
        Me.Test_111TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_111TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_111", True))
        Me.Test_111TextBox.Location = New System.Drawing.Point(-44, 252)
        Me.Test_111TextBox.Name = "Test_111TextBox"
        Me.Test_111TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_111TextBox.TabIndex = 226
        '
        'Test_112TextBox
        '
        Me.Test_112TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_112TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_112", True))
        Me.Test_112TextBox.Location = New System.Drawing.Point(-44, 273)
        Me.Test_112TextBox.Name = "Test_112TextBox"
        Me.Test_112TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_112TextBox.TabIndex = 228
        '
        'Test_113TextBox
        '
        Me.Test_113TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_113TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_113", True))
        Me.Test_113TextBox.Location = New System.Drawing.Point(-44, 294)
        Me.Test_113TextBox.Name = "Test_113TextBox"
        Me.Test_113TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_113TextBox.TabIndex = 230
        '
        'Test_114TextBox
        '
        Me.Test_114TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_114TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_114", True))
        Me.Test_114TextBox.Location = New System.Drawing.Point(-44, 315)
        Me.Test_114TextBox.Name = "Test_114TextBox"
        Me.Test_114TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_114TextBox.TabIndex = 232
        '
        'Test_115TextBox
        '
        Me.Test_115TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_115TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_115", True))
        Me.Test_115TextBox.Location = New System.Drawing.Point(-44, 336)
        Me.Test_115TextBox.Name = "Test_115TextBox"
        Me.Test_115TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_115TextBox.TabIndex = 234
        '
        'Test_116TextBox
        '
        Me.Test_116TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_116TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_116", True))
        Me.Test_116TextBox.Location = New System.Drawing.Point(-44, 357)
        Me.Test_116TextBox.Name = "Test_116TextBox"
        Me.Test_116TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_116TextBox.TabIndex = 236
        '
        'Test_117TextBox
        '
        Me.Test_117TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_117TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_117", True))
        Me.Test_117TextBox.Location = New System.Drawing.Point(-44, 378)
        Me.Test_117TextBox.Name = "Test_117TextBox"
        Me.Test_117TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_117TextBox.TabIndex = 238
        '
        'Test_118TextBox
        '
        Me.Test_118TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_118TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_118", True))
        Me.Test_118TextBox.Location = New System.Drawing.Point(-44, 399)
        Me.Test_118TextBox.Name = "Test_118TextBox"
        Me.Test_118TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_118TextBox.TabIndex = 240
        '
        'Test_119TextBox
        '
        Me.Test_119TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_119TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "test_119", True))
        Me.Test_119TextBox.Location = New System.Drawing.Point(-44, 420)
        Me.Test_119TextBox.Name = "Test_119TextBox"
        Me.Test_119TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_119TextBox.TabIndex = 242
        '
        'DIMOND_IDTextBox1
        '
        Me.DIMOND_IDTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIMOND_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "DIMOND_ID", True))
        Me.DIMOND_IDTextBox1.Location = New System.Drawing.Point(-204, 42)
        Me.DIMOND_IDTextBox1.Name = "DIMOND_IDTextBox1"
        Me.DIMOND_IDTextBox1.Size = New System.Drawing.Size(35, 21)
        Me.DIMOND_IDTextBox1.TabIndex = 245
        '
        'DIMON_NAMETextBox1
        '
        Me.DIMON_NAMETextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIMON_NAMETextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "DIMON_NAME", True))
        Me.DIMON_NAMETextBox1.Location = New System.Drawing.Point(-204, 21)
        Me.DIMON_NAMETextBox1.Name = "DIMON_NAMETextBox1"
        Me.DIMON_NAMETextBox1.Size = New System.Drawing.Size(35, 21)
        Me.DIMON_NAMETextBox1.TabIndex = 247
        '
        'DIM_na9awaTextBox1
        '
        Me.DIM_na9awaTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIM_na9awaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "DIM_na9awa", True))
        Me.DIM_na9awaTextBox1.Location = New System.Drawing.Point(-204, 84)
        Me.DIM_na9awaTextBox1.Name = "DIM_na9awaTextBox1"
        Me.DIM_na9awaTextBox1.Size = New System.Drawing.Size(35, 21)
        Me.DIM_na9awaTextBox1.TabIndex = 249
        '
        'DIMO_mezanTextBox1
        '
        Me.DIMO_mezanTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DIMO_mezanTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "DIMO_mezan", True))
        Me.DIMO_mezanTextBox1.Location = New System.Drawing.Point(-204, 105)
        Me.DIMO_mezanTextBox1.Name = "DIMO_mezanTextBox1"
        Me.DIMO_mezanTextBox1.Size = New System.Drawing.Size(35, 21)
        Me.DIMO_mezanTextBox1.TabIndex = 251
        '
        'Ext_colerTextBox1
        '
        Me.Ext_colerTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ext_colerTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "ext_coler", True))
        Me.Ext_colerTextBox1.Location = New System.Drawing.Point(-204, 126)
        Me.Ext_colerTextBox1.Name = "Ext_colerTextBox1"
        Me.Ext_colerTextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Ext_colerTextBox1.TabIndex = 253
        '
        'QultTextBox1
        '
        Me.QultTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QultTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "qult", True))
        Me.QultTextBox1.Location = New System.Drawing.Point(-204, 147)
        Me.QultTextBox1.Name = "QultTextBox1"
        Me.QultTextBox1.Size = New System.Drawing.Size(35, 21)
        Me.QultTextBox1.TabIndex = 255
        '
        'SarualTextBox1
        '
        Me.SarualTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SarualTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "sarual", True))
        Me.SarualTextBox1.Location = New System.Drawing.Point(-204, 168)
        Me.SarualTextBox1.Name = "SarualTextBox1"
        Me.SarualTextBox1.Size = New System.Drawing.Size(35, 21)
        Me.SarualTextBox1.TabIndex = 257
        '
        'Val_goldTextBox1
        '
        Me.Val_goldTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Val_goldTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "val_gold", True))
        Me.Val_goldTextBox1.Location = New System.Drawing.Point(-204, 189)
        Me.Val_goldTextBox1.Name = "Val_goldTextBox1"
        Me.Val_goldTextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Val_goldTextBox1.TabIndex = 259
        '
        'GOLD_mezanTextBox1
        '
        Me.GOLD_mezanTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GOLD_mezanTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "GOLD_mezan", True))
        Me.GOLD_mezanTextBox1.Location = New System.Drawing.Point(-204, 63)
        Me.GOLD_mezanTextBox1.Name = "GOLD_mezanTextBox1"
        Me.GOLD_mezanTextBox1.Size = New System.Drawing.Size(35, 21)
        Me.GOLD_mezanTextBox1.TabIndex = 261
        '
        'Test_1TextBox1
        '
        Me.Test_1TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_1", True))
        Me.Test_1TextBox1.Location = New System.Drawing.Point(-156, 21)
        Me.Test_1TextBox1.Name = "Test_1TextBox1"
        Me.Test_1TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_1TextBox1.TabIndex = 263
        '
        'Test_11TextBox1
        '
        Me.Test_11TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_11TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_11", True))
        Me.Test_11TextBox1.Location = New System.Drawing.Point(-156, 42)
        Me.Test_11TextBox1.Name = "Test_11TextBox1"
        Me.Test_11TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_11TextBox1.TabIndex = 265
        '
        'Test_12TextBox1
        '
        Me.Test_12TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_12TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_12", True))
        Me.Test_12TextBox1.Location = New System.Drawing.Point(-156, 63)
        Me.Test_12TextBox1.Name = "Test_12TextBox1"
        Me.Test_12TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_12TextBox1.TabIndex = 267
        '
        'Test_14TextBox1
        '
        Me.Test_14TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_14TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_14", True))
        Me.Test_14TextBox1.Location = New System.Drawing.Point(-156, 105)
        Me.Test_14TextBox1.Name = "Test_14TextBox1"
        Me.Test_14TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_14TextBox1.TabIndex = 271
        '
        'Test_15TextBox1
        '
        Me.Test_15TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_15TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_15", True))
        Me.Test_15TextBox1.Location = New System.Drawing.Point(-156, 126)
        Me.Test_15TextBox1.Name = "Test_15TextBox1"
        Me.Test_15TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_15TextBox1.TabIndex = 273
        '
        'Test_16TextBox1
        '
        Me.Test_16TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_16TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_16", True))
        Me.Test_16TextBox1.Location = New System.Drawing.Point(-156, 147)
        Me.Test_16TextBox1.Name = "Test_16TextBox1"
        Me.Test_16TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_16TextBox1.TabIndex = 275
        '
        'Test_17TextBox1
        '
        Me.Test_17TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_17TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_17", True))
        Me.Test_17TextBox1.Location = New System.Drawing.Point(-156, 168)
        Me.Test_17TextBox1.Name = "Test_17TextBox1"
        Me.Test_17TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_17TextBox1.TabIndex = 277
        '
        'Test_19TextBox1
        '
        Me.Test_19TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_19TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_19", True))
        Me.Test_19TextBox1.Location = New System.Drawing.Point(-156, 210)
        Me.Test_19TextBox1.Name = "Test_19TextBox1"
        Me.Test_19TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_19TextBox1.TabIndex = 281
        '
        'Test_110TextBox1
        '
        Me.Test_110TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_110TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_110", True))
        Me.Test_110TextBox1.Location = New System.Drawing.Point(-156, 231)
        Me.Test_110TextBox1.Name = "Test_110TextBox1"
        Me.Test_110TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_110TextBox1.TabIndex = 283
        '
        'Test_111TextBox1
        '
        Me.Test_111TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_111TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_111", True))
        Me.Test_111TextBox1.Location = New System.Drawing.Point(-156, 252)
        Me.Test_111TextBox1.Name = "Test_111TextBox1"
        Me.Test_111TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_111TextBox1.TabIndex = 285
        '
        'Test_112TextBox1
        '
        Me.Test_112TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_112TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_112", True))
        Me.Test_112TextBox1.Location = New System.Drawing.Point(-156, 273)
        Me.Test_112TextBox1.Name = "Test_112TextBox1"
        Me.Test_112TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_112TextBox1.TabIndex = 287
        '
        'Test_113TextBox1
        '
        Me.Test_113TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_113TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_113", True))
        Me.Test_113TextBox1.Location = New System.Drawing.Point(-156, 294)
        Me.Test_113TextBox1.Name = "Test_113TextBox1"
        Me.Test_113TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_113TextBox1.TabIndex = 289
        '
        'Test_114TextBox1
        '
        Me.Test_114TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_114TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_114", True))
        Me.Test_114TextBox1.Location = New System.Drawing.Point(-156, 315)
        Me.Test_114TextBox1.Name = "Test_114TextBox1"
        Me.Test_114TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_114TextBox1.TabIndex = 291
        '
        'Test_115TextBox1
        '
        Me.Test_115TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_115TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_115", True))
        Me.Test_115TextBox1.Location = New System.Drawing.Point(-156, 336)
        Me.Test_115TextBox1.Name = "Test_115TextBox1"
        Me.Test_115TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_115TextBox1.TabIndex = 293
        '
        'Test_116TextBox1
        '
        Me.Test_116TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_116TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_116", True))
        Me.Test_116TextBox1.Location = New System.Drawing.Point(-156, 357)
        Me.Test_116TextBox1.Name = "Test_116TextBox1"
        Me.Test_116TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_116TextBox1.TabIndex = 295
        '
        'Test_117TextBox1
        '
        Me.Test_117TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_117TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_117", True))
        Me.Test_117TextBox1.Location = New System.Drawing.Point(-156, 378)
        Me.Test_117TextBox1.Name = "Test_117TextBox1"
        Me.Test_117TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_117TextBox1.TabIndex = 297
        '
        'Test_118TextBox1
        '
        Me.Test_118TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_118TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_118", True))
        Me.Test_118TextBox1.Location = New System.Drawing.Point(-156, 399)
        Me.Test_118TextBox1.Name = "Test_118TextBox1"
        Me.Test_118TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_118TextBox1.TabIndex = 299
        '
        'Test_119TextBox1
        '
        Me.Test_119TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_119TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_119", True))
        Me.Test_119TextBox1.Location = New System.Drawing.Point(-156, 420)
        Me.Test_119TextBox1.Name = "Test_119TextBox1"
        Me.Test_119TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_119TextBox1.TabIndex = 301
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
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(661, 45)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(52, 21)
        Me.txtQty.TabIndex = 2
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_111_left1upTextBox
        '
        Me.Test_111_left1upTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_111_left1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_111_left1up", True))
        Me.Test_111_left1upTextBox.Location = New System.Drawing.Point(-366, 21)
        Me.Test_111_left1upTextBox.Name = "Test_111_left1upTextBox"
        Me.Test_111_left1upTextBox.Size = New System.Drawing.Size(38, 21)
        Me.Test_111_left1upTextBox.TabIndex = 313
        '
        'SettingsBindingSource
        '
        Me.SettingsBindingSource.DataMember = "Settings"
        Me.SettingsBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'SettingsTableAdapter
        '
        Me.SettingsTableAdapter.ClearBeforeFill = True
        '
        'SET_INVARCHR115TextBox
        '
        Me.SET_INVARCHR115TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR115TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR115", True))
        Me.SET_INVARCHR115TextBox.Location = New System.Drawing.Point(-480, 126)
        Me.SET_INVARCHR115TextBox.Name = "SET_INVARCHR115TextBox"
        Me.SET_INVARCHR115TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR115TextBox.TabIndex = 339
        '
        'SET_INVARCHR116TextBox
        '
        Me.SET_INVARCHR116TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR116TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR116", True))
        Me.SET_INVARCHR116TextBox.Location = New System.Drawing.Point(-442, 147)
        Me.SET_INVARCHR116TextBox.Name = "SET_INVARCHR116TextBox"
        Me.SET_INVARCHR116TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR116TextBox.TabIndex = 340
        '
        'SET_INVARCHR117TextBox
        '
        Me.SET_INVARCHR117TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR117TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR117", True))
        Me.SET_INVARCHR117TextBox.Location = New System.Drawing.Point(-404, 168)
        Me.SET_INVARCHR117TextBox.Name = "SET_INVARCHR117TextBox"
        Me.SET_INVARCHR117TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR117TextBox.TabIndex = 341
        '
        'SET_INVARCHR118TextBox
        '
        Me.SET_INVARCHR118TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR118TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR118", True))
        Me.SET_INVARCHR118TextBox.Location = New System.Drawing.Point(-366, 168)
        Me.SET_INVARCHR118TextBox.Name = "SET_INVARCHR118TextBox"
        Me.SET_INVARCHR118TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR118TextBox.TabIndex = 342
        '
        'SET_INVARCHR119TextBox
        '
        Me.SET_INVARCHR119TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR119TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR119", True))
        Me.SET_INVARCHR119TextBox.Location = New System.Drawing.Point(-404, 63)
        Me.SET_INVARCHR119TextBox.Name = "SET_INVARCHR119TextBox"
        Me.SET_INVARCHR119TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR119TextBox.TabIndex = 343
        '
        'SET_INVARCHR120TextBox
        '
        Me.SET_INVARCHR120TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR120TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR120", True))
        Me.SET_INVARCHR120TextBox.Location = New System.Drawing.Point(-480, 147)
        Me.SET_INVARCHR120TextBox.Name = "SET_INVARCHR120TextBox"
        Me.SET_INVARCHR120TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR120TextBox.TabIndex = 344
        '
        'SET_INVARCHR121TextBox
        '
        Me.SET_INVARCHR121TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR121TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR121", True))
        Me.SET_INVARCHR121TextBox.Location = New System.Drawing.Point(-480, 168)
        Me.SET_INVARCHR121TextBox.Name = "SET_INVARCHR121TextBox"
        Me.SET_INVARCHR121TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR121TextBox.TabIndex = 345
        '
        'SET_INVARCHR122TextBox
        '
        Me.SET_INVARCHR122TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR122TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR122", True))
        Me.SET_INVARCHR122TextBox.Location = New System.Drawing.Point(-480, 42)
        Me.SET_INVARCHR122TextBox.Name = "SET_INVARCHR122TextBox"
        Me.SET_INVARCHR122TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR122TextBox.TabIndex = 346
        '
        'SET_INVARCHR123TextBox
        '
        Me.SET_INVARCHR123TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR123TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR123", True))
        Me.SET_INVARCHR123TextBox.Location = New System.Drawing.Point(-442, 105)
        Me.SET_INVARCHR123TextBox.Name = "SET_INVARCHR123TextBox"
        Me.SET_INVARCHR123TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR123TextBox.TabIndex = 347
        '
        'SET_INVARCHR124TextBox
        '
        Me.SET_INVARCHR124TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR124TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR124", True))
        Me.SET_INVARCHR124TextBox.Location = New System.Drawing.Point(-290, 126)
        Me.SET_INVARCHR124TextBox.Name = "SET_INVARCHR124TextBox"
        Me.SET_INVARCHR124TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR124TextBox.TabIndex = 348
        '
        'SET_INVARCHR125TextBox
        '
        Me.SET_INVARCHR125TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR125TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR125", True))
        Me.SET_INVARCHR125TextBox.Location = New System.Drawing.Point(-366, 105)
        Me.SET_INVARCHR125TextBox.Name = "SET_INVARCHR125TextBox"
        Me.SET_INVARCHR125TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR125TextBox.TabIndex = 349
        '
        'SET_INVARCHR126TextBox
        '
        Me.SET_INVARCHR126TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR126TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR126", True))
        Me.SET_INVARCHR126TextBox.Location = New System.Drawing.Point(7, 327)
        Me.SET_INVARCHR126TextBox.Name = "SET_INVARCHR126TextBox"
        Me.SET_INVARCHR126TextBox.Size = New System.Drawing.Size(75, 21)
        Me.SET_INVARCHR126TextBox.TabIndex = 350
        Me.SET_INVARCHR126TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SET_INVARCHR127TextBox
        '
        Me.SET_INVARCHR127TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR127TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR127", True))
        Me.SET_INVARCHR127TextBox.Location = New System.Drawing.Point(7, 348)
        Me.SET_INVARCHR127TextBox.Name = "SET_INVARCHR127TextBox"
        Me.SET_INVARCHR127TextBox.Size = New System.Drawing.Size(75, 21)
        Me.SET_INVARCHR127TextBox.TabIndex = 351
        Me.SET_INVARCHR127TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SET_INVARCHR127Text
        '
        Me.SET_INVARCHR127Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR127Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR127", True))
        Me.SET_INVARCHR127Text.Location = New System.Drawing.Point(-328, 84)
        Me.SET_INVARCHR127Text.Name = "SET_INVARCHR127Text"
        Me.SET_INVARCHR127Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR127Text.TabIndex = 377
        '
        'SET_INVARCHR126Text
        '
        Me.SET_INVARCHR126Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR126Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR126", True))
        Me.SET_INVARCHR126Text.Location = New System.Drawing.Point(-328, 126)
        Me.SET_INVARCHR126Text.Name = "SET_INVARCHR126Text"
        Me.SET_INVARCHR126Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR126Text.TabIndex = 376
        '
        'SET_INVARCHR125Text
        '
        Me.SET_INVARCHR125Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR125Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR125", True))
        Me.SET_INVARCHR125Text.Location = New System.Drawing.Point(-290, 84)
        Me.SET_INVARCHR125Text.Name = "SET_INVARCHR125Text"
        Me.SET_INVARCHR125Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR125Text.TabIndex = 374
        '
        'SET_INVARCHR124Text
        '
        Me.SET_INVARCHR124Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR124Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR124", True))
        Me.SET_INVARCHR124Text.Location = New System.Drawing.Point(-290, 168)
        Me.SET_INVARCHR124Text.Name = "SET_INVARCHR124Text"
        Me.SET_INVARCHR124Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR124Text.TabIndex = 372
        '
        'SET_INVARCHR123Text
        '
        Me.SET_INVARCHR123Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR123Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR123", True))
        Me.SET_INVARCHR123Text.Location = New System.Drawing.Point(-480, 84)
        Me.SET_INVARCHR123Text.Name = "SET_INVARCHR123Text"
        Me.SET_INVARCHR123Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR123Text.TabIndex = 370
        '
        'SET_INVARCHR122Text
        '
        Me.SET_INVARCHR122Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR122Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR122", True))
        Me.SET_INVARCHR122Text.Location = New System.Drawing.Point(-480, 105)
        Me.SET_INVARCHR122Text.Name = "SET_INVARCHR122Text"
        Me.SET_INVARCHR122Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR122Text.TabIndex = 368
        '
        'SET_INVARCHR121Text
        '
        Me.SET_INVARCHR121Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR121Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR121", True))
        Me.SET_INVARCHR121Text.Location = New System.Drawing.Point(-328, 147)
        Me.SET_INVARCHR121Text.Name = "SET_INVARCHR121Text"
        Me.SET_INVARCHR121Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR121Text.TabIndex = 366
        '
        'SET_INVARCHR120Text
        '
        Me.SET_INVARCHR120Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR120Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR120", True))
        Me.SET_INVARCHR120Text.Location = New System.Drawing.Point(-290, 147)
        Me.SET_INVARCHR120Text.Name = "SET_INVARCHR120Text"
        Me.SET_INVARCHR120Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR120Text.TabIndex = 363
        '
        'SET_INVARCHR119Text
        '
        Me.SET_INVARCHR119Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR119Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR119", True))
        Me.SET_INVARCHR119Text.Location = New System.Drawing.Point(-442, 168)
        Me.SET_INVARCHR119Text.Name = "SET_INVARCHR119Text"
        Me.SET_INVARCHR119Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR119Text.TabIndex = 362
        '
        'SET_INVARCHR118Text
        '
        Me.SET_INVARCHR118Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR118Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR118", True))
        Me.SET_INVARCHR118Text.Location = New System.Drawing.Point(-328, 168)
        Me.SET_INVARCHR118Text.Name = "SET_INVARCHR118Text"
        Me.SET_INVARCHR118Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR118Text.TabIndex = 360
        '
        'SET_INVARCHR117Text
        '
        Me.SET_INVARCHR117Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR117Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR117", True))
        Me.SET_INVARCHR117Text.Location = New System.Drawing.Point(-366, 147)
        Me.SET_INVARCHR117Text.Name = "SET_INVARCHR117Text"
        Me.SET_INVARCHR117Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR117Text.TabIndex = 358
        '
        'SET_INVARCHR116Text
        '
        Me.SET_INVARCHR116Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR116Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR116", True))
        Me.SET_INVARCHR116Text.Location = New System.Drawing.Point(-442, 63)
        Me.SET_INVARCHR116Text.Name = "SET_INVARCHR116Text"
        Me.SET_INVARCHR116Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR116Text.TabIndex = 356
        '
        'SET_INVARCHR115Text
        '
        Me.SET_INVARCHR115Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR115Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR115", True))
        Me.SET_INVARCHR115Text.Location = New System.Drawing.Point(-404, 147)
        Me.SET_INVARCHR115Text.Name = "SET_INVARCHR115Text"
        Me.SET_INVARCHR115Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR115Text.TabIndex = 354
        '
        'SET_INVARCHR113TextBox
        '
        Me.SET_INVARCHR113TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR113TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR113", True))
        Me.SET_INVARCHR113TextBox.Location = New System.Drawing.Point(-404, 84)
        Me.SET_INVARCHR113TextBox.Name = "SET_INVARCHR113TextBox"
        Me.SET_INVARCHR113TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR113TextBox.TabIndex = 378
        '
        'SET_INVARCHR113Text
        '
        Me.SET_INVARCHR113Text.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR113Text.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR113", True))
        Me.SET_INVARCHR113Text.Location = New System.Drawing.Point(-366, 126)
        Me.SET_INVARCHR113Text.Name = "SET_INVARCHR113Text"
        Me.SET_INVARCHR113Text.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR113Text.TabIndex = 380
        '
        'Test_17_left1upTextBox1
        '
        Me.Test_17_left1upTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_17_left1upTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_17_left1up", True))
        Me.Test_17_left1upTextBox1.Location = New System.Drawing.Point(-442, 21)
        Me.Test_17_left1upTextBox1.Name = "Test_17_left1upTextBox1"
        Me.Test_17_left1upTextBox1.Size = New System.Drawing.Size(38, 21)
        Me.Test_17_left1upTextBox1.TabIndex = 388
        '
        'Test_18_left1upTextBox1
        '
        Me.Test_18_left1upTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_18_left1upTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_18_left1up", True))
        Me.Test_18_left1upTextBox1.Location = New System.Drawing.Point(-404, 21)
        Me.Test_18_left1upTextBox1.Name = "Test_18_left1upTextBox1"
        Me.Test_18_left1upTextBox1.Size = New System.Drawing.Size(38, 21)
        Me.Test_18_left1upTextBox1.TabIndex = 389
        '
        'Test_19_left1upTextBox1
        '
        Me.Test_19_left1upTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_19_left1upTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_19_left1up", True))
        Me.Test_19_left1upTextBox1.Location = New System.Drawing.Point(-366, 42)
        Me.Test_19_left1upTextBox1.Name = "Test_19_left1upTextBox1"
        Me.Test_19_left1upTextBox1.Size = New System.Drawing.Size(38, 21)
        Me.Test_19_left1upTextBox1.TabIndex = 390
        '
        'Test_110_left1upTextBox1
        '
        Me.Test_110_left1upTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_110_left1upTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_110_left1up", True))
        Me.Test_110_left1upTextBox1.Location = New System.Drawing.Point(-366, 63)
        Me.Test_110_left1upTextBox1.Name = "Test_110_left1upTextBox1"
        Me.Test_110_left1upTextBox1.Size = New System.Drawing.Size(38, 21)
        Me.Test_110_left1upTextBox1.TabIndex = 391
        '
        'Test_112_left1upTextBox1
        '
        Me.Test_112_left1upTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_112_left1upTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_112_left1up", True))
        Me.Test_112_left1upTextBox1.Location = New System.Drawing.Point(-328, 63)
        Me.Test_112_left1upTextBox1.Name = "Test_112_left1upTextBox1"
        Me.Test_112_left1upTextBox1.Size = New System.Drawing.Size(38, 21)
        Me.Test_112_left1upTextBox1.TabIndex = 393
        '
        'Test_113_left1upTextBox1
        '
        Me.Test_113_left1upTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_113_left1upTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_113_left1up", True))
        Me.Test_113_left1upTextBox1.Location = New System.Drawing.Point(-328, 21)
        Me.Test_113_left1upTextBox1.Name = "Test_113_left1upTextBox1"
        Me.Test_113_left1upTextBox1.Size = New System.Drawing.Size(38, 21)
        Me.Test_113_left1upTextBox1.TabIndex = 394
        '
        'Test_114_left1upTextBox1
        '
        Me.Test_114_left1upTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_114_left1upTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_114_left1up", True))
        Me.Test_114_left1upTextBox1.Location = New System.Drawing.Point(-290, 42)
        Me.Test_114_left1upTextBox1.Name = "Test_114_left1upTextBox1"
        Me.Test_114_left1upTextBox1.Size = New System.Drawing.Size(38, 21)
        Me.Test_114_left1upTextBox1.TabIndex = 395
        '
        'Test_115_left1upTextBox1
        '
        Me.Test_115_left1upTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_115_left1upTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_115_left1up", True))
        Me.Test_115_left1upTextBox1.Location = New System.Drawing.Point(-328, 42)
        Me.Test_115_left1upTextBox1.Name = "Test_115_left1upTextBox1"
        Me.Test_115_left1upTextBox1.Size = New System.Drawing.Size(38, 21)
        Me.Test_115_left1upTextBox1.TabIndex = 396
        '
        'Test_116_left1upTextBox1
        '
        Me.Test_116_left1upTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_116_left1upTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_116_left1up", True))
        Me.Test_116_left1upTextBox1.Location = New System.Drawing.Point(-290, 63)
        Me.Test_116_left1upTextBox1.Name = "Test_116_left1upTextBox1"
        Me.Test_116_left1upTextBox1.Size = New System.Drawing.Size(38, 21)
        Me.Test_116_left1upTextBox1.TabIndex = 397
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(661, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(52, 24)
        Me.Label34.TabIndex = 415
        Me.Label34.Text = "العدد"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Test_17_right1upTextBox
        '
        Me.Test_17_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_17_right1up", True))
        Me.Test_17_right1upTextBox.Location = New System.Drawing.Point(47, 261)
        Me.Test_17_right1upTextBox.Name = "Test_17_right1upTextBox"
        Me.Test_17_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_17_right1upTextBox.TabIndex = 7
        Me.Test_17_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Program_nameTextBox2
        '
        Me.Program_nameTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "program_name", True))
        Me.Program_nameTextBox2.Location = New System.Drawing.Point(8, 282)
        Me.Program_nameTextBox2.Name = "Program_nameTextBox2"
        Me.Program_nameTextBox2.Size = New System.Drawing.Size(35, 21)
        Me.Program_nameTextBox2.TabIndex = 4
        Me.Program_nameTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tel1upTextBox
        '
        Me.Tel1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "tel1up", True))
        Me.Tel1upTextBox.Location = New System.Drawing.Point(47, 282)
        Me.Tel1upTextBox.Name = "Tel1upTextBox"
        Me.Tel1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Tel1upTextBox.TabIndex = 5
        Me.Tel1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Program_name1upTextBox
        '
        Me.Program_name1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "program_name1up", True))
        Me.Program_name1upTextBox.Location = New System.Drawing.Point(47, 219)
        Me.Program_name1upTextBox.Name = "Program_name1upTextBox"
        Me.Program_name1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Program_name1upTextBox.TabIndex = 1
        Me.Program_name1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(89, 220)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(56, 19)
        Me.Label59.TabIndex = 443
        Me.Label59.Text = "SAP"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Test_110_right1upTextBox
        '
        Me.Test_110_right1upTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_110_right1up", True))
        Me.Test_110_right1upTextBox.Location = New System.Drawing.Point(8, 219)
        Me.Test_110_right1upTextBox.Name = "Test_110_right1upTextBox"
        Me.Test_110_right1upTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_110_right1upTextBox.TabIndex = 0
        Me.Test_110_right1upTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label58
        '
        Me.Label58.Location = New System.Drawing.Point(87, 283)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(56, 19)
        Me.Label58.TabIndex = 440
        Me.Label58.Text = "الرقم يمين"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(87, 262)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(56, 19)
        Me.Label57.TabIndex = 437
        Me.Label57.Text = "الرقم يسار"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TelTextBox1
        '
        Me.TelTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "tel", True))
        Me.TelTextBox1.Location = New System.Drawing.Point(8, 261)
        Me.TelTextBox1.Name = "TelTextBox1"
        Me.TelTextBox1.Size = New System.Drawing.Size(35, 21)
        Me.TelTextBox1.TabIndex = 6
        Me.TelTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_119_rightTextBox
        '
        Me.Test_119_rightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_119_right", True))
        Me.Test_119_rightTextBox.Location = New System.Drawing.Point(8, 240)
        Me.Test_119_rightTextBox.Name = "Test_119_rightTextBox"
        Me.Test_119_rightTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_119_rightTextBox.TabIndex = 2
        Me.Test_119_rightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Test_118_rightTextBox
        '
        Me.Test_118_rightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONFI_barcood_dimonBindingSource, "test_118_right", True))
        Me.Test_118_rightTextBox.Location = New System.Drawing.Point(47, 240)
        Me.Test_118_rightTextBox.Name = "Test_118_rightTextBox"
        Me.Test_118_rightTextBox.Size = New System.Drawing.Size(35, 21)
        Me.Test_118_rightTextBox.TabIndex = 3
        Me.Test_118_rightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(87, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 432
        Me.Label1.Text = "الدعم الفني"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label60
        '
        Me.Label60.Location = New System.Drawing.Point(210, 18)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(195, 21)
        Me.Label60.TabIndex = 436
        Me.Label60.Text = "حدد طابعة الباركود"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label61
        '
        Me.Label61.Location = New System.Drawing.Point(9, 18)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(195, 21)
        Me.Label61.TabIndex = 437
        Me.Label61.Text = "اختر اسم المعرض"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBarCodeLeft
        '
        Me.txtBarCodeLeft.Location = New System.Drawing.Point(9, 104)
        Me.txtBarCodeLeft.Name = "txtBarCodeLeft"
        Me.txtBarCodeLeft.Size = New System.Drawing.Size(136, 21)
        Me.txtBarCodeLeft.TabIndex = 8
        Me.txtBarCodeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBarCodeRight
        '
        Me.txtBarCodeRight.Location = New System.Drawing.Point(851, 104)
        Me.txtBarCodeRight.Name = "txtBarCodeRight"
        Me.txtBarCodeRight.Size = New System.Drawing.Size(135, 21)
        Me.txtBarCodeRight.TabIndex = 5
        Me.txtBarCodeRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label62
        '
        Me.Label62.Location = New System.Drawing.Point(582, 82)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(257, 19)
        Me.Label62.TabIndex = 440
        Me.Label62.Text = "اختر اسم الصنف"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label64
        '
        Me.Label64.Location = New System.Drawing.Point(9, 82)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(136, 19)
        Me.Label64.TabIndex = 442
        Me.Label64.Text = "أدخل الباركود"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(851, 82)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(135, 19)
        Me.Label63.TabIndex = 443
        Me.Label63.Text = "أدخل الباركود"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SET1TextBox
        '
        Me.SET1TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET1", True))
        Me.SET1TextBox.Location = New System.Drawing.Point(-404, 126)
        Me.SET1TextBox.Name = "SET1TextBox"
        Me.SET1TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET1TextBox.TabIndex = 444
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(157, 82)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(257, 19)
        Me.Label65.TabIndex = 440
        Me.Label65.Text = "اختر اسم الصنف"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.IsDiamond3CheckBox1)
        Me.pnl.Controls.Add(Me.IsDiamond2CheckBox1)
        Me.pnl.Controls.Add(Me.IsDiamond1CheckBox1)
        Me.pnl.Controls.Add(Me.Clarity3TextBox1)
        Me.pnl.Controls.Add(Me.Cut3TextBox1)
        Me.pnl.Controls.Add(Me.Clarity2TextBox1)
        Me.pnl.Controls.Add(Me.Cut2TextBox1)
        Me.pnl.Controls.Add(Me.Clarity1TextBox1)
        Me.pnl.Controls.Add(Me.Cut1TextBox1)
        Me.pnl.Controls.Add(Me.IsDiamond3CheckBox)
        Me.pnl.Controls.Add(Me.IsDiamond2CheckBox)
        Me.pnl.Controls.Add(Me.IsDiamond1CheckBox)
        Me.pnl.Controls.Add(Me.Clarity3TextBox)
        Me.pnl.Controls.Add(Me.Cut3TextBox)
        Me.pnl.Controls.Add(Me.Clarity2TextBox)
        Me.pnl.Controls.Add(Me.Cut2TextBox)
        Me.pnl.Controls.Add(Me.Clarity1TextBox)
        Me.pnl.Controls.Add(Me.Cut1TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR18TextBox)
        Me.pnl.Controls.Add(Me.Test_18TextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR145TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR130TextBox)
        Me.pnl.Controls.Add(Me.Test_13TextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR115TextBox)
        Me.pnl.Controls.Add(Me.Test_1TextBox1)
        Me.pnl.Controls.Add(Me.Test_111_left1upTextBox)
        Me.pnl.Controls.Add(Me.DIMOND_IDTextBox1)
        Me.pnl.Controls.Add(Me.Test_1TextBox)
        Me.pnl.Controls.Add(Me.Test_11TextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR116TextBox)
        Me.pnl.Controls.Add(Me.DIMON_NAMETextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR117TextBox)
        Me.pnl.Controls.Add(Me.Test_12TextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR118TextBox)
        Me.pnl.Controls.Add(Me.Test_11TextBox)
        Me.pnl.Controls.Add(Me.Test_13TextBox)
        Me.pnl.Controls.Add(Me.DIM_na9awaTextBox1)
        Me.pnl.Controls.Add(Me.DIMOND_IDTextBox)
        Me.pnl.Controls.Add(Me.DIMO_mezanTextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR119TextBox)
        Me.pnl.Controls.Add(Me.Ext_colerTextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR120TextBox)
        Me.pnl.Controls.Add(Me.QultTextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR121TextBox)
        Me.pnl.Controls.Add(Me.Test_12TextBox)
        Me.pnl.Controls.Add(Me.Test_19TextBox1)
        Me.pnl.Controls.Add(Me.SarualTextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR115Text)
        Me.pnl.Controls.Add(Me.Val_goldTextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR116Text)
        Me.pnl.Controls.Add(Me.GOLD_mezanTextBox1)
        Me.pnl.Controls.Add(Me.DIMON_NAMETextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR117Text)
        Me.pnl.Controls.Add(Me.Test_115TextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR118Text)
        Me.pnl.Controls.Add(Me.Test_116TextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR119Text)
        Me.pnl.Controls.Add(Me.SET_INVARCHR120Text)
        Me.pnl.Controls.Add(Me.Test_117TextBox1)
        Me.pnl.Controls.Add(Me.Test_14TextBox)
        Me.pnl.Controls.Add(Me.Test_110TextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR121Text)
        Me.pnl.Controls.Add(Me.Test_18TextBox)
        Me.pnl.Controls.Add(Me.DIM_na9awaTextBox)
        Me.pnl.Controls.Add(Me.Test_17TextBox)
        Me.pnl.Controls.Add(Me.Test_16TextBox)
        Me.pnl.Controls.Add(Me.DIMO_mezanTextBox)
        Me.pnl.Controls.Add(Me.Test_15TextBox)
        Me.pnl.Controls.Add(Me.Ext_colerTextBox)
        Me.pnl.Controls.Add(Me.NoteTextBox)
        Me.pnl.Controls.Add(Me.QultTextBox)
        Me.pnl.Controls.Add(Me.Test_111TextBox1)
        Me.pnl.Controls.Add(Me.Note2TextBox)
        Me.pnl.Controls.Add(Me.SarualTextBox)
        Me.pnl.Controls.Add(Me.TelTextBox)
        Me.pnl.Controls.Add(Me.Val_goldTextBox)
        Me.pnl.Controls.Add(Me.Test_19TextBox)
        Me.pnl.Controls.Add(Me.GOLD_mezanTextBox)
        Me.pnl.Controls.Add(Me.Test_112TextBox1)
        Me.pnl.Controls.Add(Me.Size_idTextBox)
        Me.pnl.Controls.Add(Me.Test_113TextBox1)
        Me.pnl.Controls.Add(Me.SET1TextBox)
        Me.pnl.Controls.Add(Me.Test_114TextBox1)
        Me.pnl.Controls.Add(Me.Program_nameTextBox)
        Me.pnl.Controls.Add(Me.Print_nameTextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR122TextBox)
        Me.pnl.Controls.Add(Me.Test_14TextBox1)
        Me.pnl.Controls.Add(Me.SET_INVARCHR123TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR124TextBox)
        Me.pnl.Controls.Add(Me.Test_110TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR125TextBox)
        Me.pnl.Controls.Add(Me.Test_111TextBox)
        Me.pnl.Controls.Add(Me.Test_15TextBox1)
        Me.pnl.Controls.Add(Me.Test_112TextBox)
        Me.pnl.Controls.Add(Me.Test_112_left1upTextBox1)
        Me.pnl.Controls.Add(Me.Test_17_left1upTextBox1)
        Me.pnl.Controls.Add(Me.Test_113TextBox)
        Me.pnl.Controls.Add(Me.Test_18_left1upTextBox1)
        Me.pnl.Controls.Add(Me.Test_19_left1upTextBox1)
        Me.pnl.Controls.Add(Me.Test_110_left1upTextBox1)
        Me.pnl.Controls.Add(Me.Test_114TextBox)
        Me.pnl.Controls.Add(Me.Test_113_left1upTextBox1)
        Me.pnl.Controls.Add(Me.Test_114_left1upTextBox1)
        Me.pnl.Controls.Add(Me.Test_16TextBox1)
        Me.pnl.Controls.Add(Me.Test_115TextBox)
        Me.pnl.Controls.Add(Me.Test_115_left1upTextBox1)
        Me.pnl.Controls.Add(Me.Test_119TextBox1)
        Me.pnl.Controls.Add(Me.Test_116_left1upTextBox1)
        Me.pnl.Controls.Add(Me.Test_118TextBox1)
        Me.pnl.Controls.Add(Me.Test_116TextBox)
        Me.pnl.Controls.Add(Me.Test_17TextBox1)
        Me.pnl.Controls.Add(Me.Test_117TextBox)
        Me.pnl.Controls.Add(Me.Test_118TextBox)
        Me.pnl.Controls.Add(Me.Test_119TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR122Text)
        Me.pnl.Controls.Add(Me.SET_INVARCHR113Text)
        Me.pnl.Controls.Add(Me.SET_INVARCHR123Text)
        Me.pnl.Controls.Add(Me.SET_INVARCHR127Text)
        Me.pnl.Controls.Add(Me.SET_INVARCHR124Text)
        Me.pnl.Controls.Add(Me.SET_INVARCHR126Text)
        Me.pnl.Controls.Add(Me.SET_INVARCHR113TextBox)
        Me.pnl.Controls.Add(Me.SET_INVARCHR125Text)
        Me.pnl.Location = New System.Drawing.Point(1081, 18)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(32, 24)
        Me.pnl.TabIndex = 449
        '
        'IsDiamond3CheckBox1
        '
        Me.IsDiamond3CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IsDiamond3CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DIMON_BARICOOD_RIGHTBindingSource, "IsDiamond3", True))
        Me.IsDiamond3CheckBox1.Location = New System.Drawing.Point(-204, 384)
        Me.IsDiamond3CheckBox1.Name = "IsDiamond3CheckBox1"
        Me.IsDiamond3CheckBox1.Size = New System.Drawing.Size(35, 24)
        Me.IsDiamond3CheckBox1.TabIndex = 468
        Me.IsDiamond3CheckBox1.Text = "CheckBox1"
        Me.IsDiamond3CheckBox1.UseVisualStyleBackColor = True
        '
        'IsDiamond2CheckBox1
        '
        Me.IsDiamond2CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IsDiamond2CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DIMON_BARICOOD_RIGHTBindingSource, "IsDiamond2", True))
        Me.IsDiamond2CheckBox1.Location = New System.Drawing.Point(-204, 360)
        Me.IsDiamond2CheckBox1.Name = "IsDiamond2CheckBox1"
        Me.IsDiamond2CheckBox1.Size = New System.Drawing.Size(35, 24)
        Me.IsDiamond2CheckBox1.TabIndex = 467
        Me.IsDiamond2CheckBox1.Text = "CheckBox1"
        Me.IsDiamond2CheckBox1.UseVisualStyleBackColor = True
        '
        'IsDiamond1CheckBox1
        '
        Me.IsDiamond1CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IsDiamond1CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DIMON_BARICOOD_RIGHTBindingSource, "IsDiamond1", True))
        Me.IsDiamond1CheckBox1.Location = New System.Drawing.Point(-204, 336)
        Me.IsDiamond1CheckBox1.Name = "IsDiamond1CheckBox1"
        Me.IsDiamond1CheckBox1.Size = New System.Drawing.Size(35, 24)
        Me.IsDiamond1CheckBox1.TabIndex = 466
        Me.IsDiamond1CheckBox1.Text = "CheckBox1"
        Me.IsDiamond1CheckBox1.UseVisualStyleBackColor = True
        '
        'Clarity3TextBox1
        '
        Me.Clarity3TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clarity3TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "Clarity3", True))
        Me.Clarity3TextBox1.Location = New System.Drawing.Point(-204, 315)
        Me.Clarity3TextBox1.Name = "Clarity3TextBox1"
        Me.Clarity3TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Clarity3TextBox1.TabIndex = 465
        '
        'Cut3TextBox1
        '
        Me.Cut3TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cut3TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "Cut3", True))
        Me.Cut3TextBox1.Location = New System.Drawing.Point(-204, 294)
        Me.Cut3TextBox1.Name = "Cut3TextBox1"
        Me.Cut3TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Cut3TextBox1.TabIndex = 464
        '
        'Clarity2TextBox1
        '
        Me.Clarity2TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clarity2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "Clarity2", True))
        Me.Clarity2TextBox1.Location = New System.Drawing.Point(-204, 273)
        Me.Clarity2TextBox1.Name = "Clarity2TextBox1"
        Me.Clarity2TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Clarity2TextBox1.TabIndex = 463
        '
        'Cut2TextBox1
        '
        Me.Cut2TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cut2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "Cut2", True))
        Me.Cut2TextBox1.Location = New System.Drawing.Point(-204, 252)
        Me.Cut2TextBox1.Name = "Cut2TextBox1"
        Me.Cut2TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Cut2TextBox1.TabIndex = 462
        '
        'Clarity1TextBox1
        '
        Me.Clarity1TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clarity1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "Clarity1", True))
        Me.Clarity1TextBox1.Location = New System.Drawing.Point(-204, 231)
        Me.Clarity1TextBox1.Name = "Clarity1TextBox1"
        Me.Clarity1TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Clarity1TextBox1.TabIndex = 461
        '
        'Cut1TextBox1
        '
        Me.Cut1TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cut1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "Cut1", True))
        Me.Cut1TextBox1.Location = New System.Drawing.Point(-204, 210)
        Me.Cut1TextBox1.Name = "Cut1TextBox1"
        Me.Cut1TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Cut1TextBox1.TabIndex = 460
        '
        'IsDiamond3CheckBox
        '
        Me.IsDiamond3CheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IsDiamond3CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DIMON_BARICOOD_LEFTBindingSource, "IsDiamond3", True))
        Me.IsDiamond3CheckBox.Location = New System.Drawing.Point(-92, 384)
        Me.IsDiamond3CheckBox.Name = "IsDiamond3CheckBox"
        Me.IsDiamond3CheckBox.Size = New System.Drawing.Size(35, 24)
        Me.IsDiamond3CheckBox.TabIndex = 459
        Me.IsDiamond3CheckBox.Text = "CheckBox1"
        Me.IsDiamond3CheckBox.UseVisualStyleBackColor = True
        '
        'IsDiamond2CheckBox
        '
        Me.IsDiamond2CheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IsDiamond2CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DIMON_BARICOOD_LEFTBindingSource, "IsDiamond2", True))
        Me.IsDiamond2CheckBox.Location = New System.Drawing.Point(-92, 360)
        Me.IsDiamond2CheckBox.Name = "IsDiamond2CheckBox"
        Me.IsDiamond2CheckBox.Size = New System.Drawing.Size(35, 24)
        Me.IsDiamond2CheckBox.TabIndex = 458
        Me.IsDiamond2CheckBox.Text = "CheckBox1"
        Me.IsDiamond2CheckBox.UseVisualStyleBackColor = True
        '
        'IsDiamond1CheckBox
        '
        Me.IsDiamond1CheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IsDiamond1CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DIMON_BARICOOD_LEFTBindingSource, "IsDiamond1", True))
        Me.IsDiamond1CheckBox.Location = New System.Drawing.Point(-92, 336)
        Me.IsDiamond1CheckBox.Name = "IsDiamond1CheckBox"
        Me.IsDiamond1CheckBox.Size = New System.Drawing.Size(35, 24)
        Me.IsDiamond1CheckBox.TabIndex = 457
        Me.IsDiamond1CheckBox.Text = "CheckBox1"
        Me.IsDiamond1CheckBox.UseVisualStyleBackColor = True
        '
        'Clarity3TextBox
        '
        Me.Clarity3TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clarity3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "Clarity3", True))
        Me.Clarity3TextBox.Location = New System.Drawing.Point(-92, 315)
        Me.Clarity3TextBox.Name = "Clarity3TextBox"
        Me.Clarity3TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Clarity3TextBox.TabIndex = 456
        '
        'Cut3TextBox
        '
        Me.Cut3TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cut3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "Cut3", True))
        Me.Cut3TextBox.Location = New System.Drawing.Point(-92, 294)
        Me.Cut3TextBox.Name = "Cut3TextBox"
        Me.Cut3TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut3TextBox.TabIndex = 455
        '
        'Clarity2TextBox
        '
        Me.Clarity2TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clarity2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "Clarity2", True))
        Me.Clarity2TextBox.Location = New System.Drawing.Point(-92, 273)
        Me.Clarity2TextBox.Name = "Clarity2TextBox"
        Me.Clarity2TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Clarity2TextBox.TabIndex = 454
        '
        'Cut2TextBox
        '
        Me.Cut2TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cut2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "Cut2", True))
        Me.Cut2TextBox.Location = New System.Drawing.Point(-92, 252)
        Me.Cut2TextBox.Name = "Cut2TextBox"
        Me.Cut2TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut2TextBox.TabIndex = 453
        '
        'Clarity1TextBox
        '
        Me.Clarity1TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Clarity1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "Clarity1", True))
        Me.Clarity1TextBox.Location = New System.Drawing.Point(-92, 231)
        Me.Clarity1TextBox.Name = "Clarity1TextBox"
        Me.Clarity1TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Clarity1TextBox.TabIndex = 452
        '
        'Cut1TextBox
        '
        Me.Cut1TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cut1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_LEFTBindingSource, "Cut1", True))
        Me.Cut1TextBox.Location = New System.Drawing.Point(-92, 210)
        Me.Cut1TextBox.Name = "Cut1TextBox"
        Me.Cut1TextBox.Size = New System.Drawing.Size(35, 21)
        Me.Cut1TextBox.TabIndex = 451
        '
        'SET_INVARCHR18TextBox
        '
        Me.SET_INVARCHR18TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR18TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR18", True))
        Me.SET_INVARCHR18TextBox.Location = New System.Drawing.Point(-290, 21)
        Me.SET_INVARCHR18TextBox.Name = "SET_INVARCHR18TextBox"
        Me.SET_INVARCHR18TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR18TextBox.TabIndex = 450
        '
        'Test_18TextBox1
        '
        Me.Test_18TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_18TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_18", True))
        Me.Test_18TextBox1.Location = New System.Drawing.Point(-156, 189)
        Me.Test_18TextBox1.Name = "Test_18TextBox1"
        Me.Test_18TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_18TextBox1.TabIndex = 449
        '
        'SET_INVARCHR145TextBox
        '
        Me.SET_INVARCHR145TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR145TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR145", True))
        Me.SET_INVARCHR145TextBox.Location = New System.Drawing.Point(-480, 63)
        Me.SET_INVARCHR145TextBox.Name = "SET_INVARCHR145TextBox"
        Me.SET_INVARCHR145TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR145TextBox.TabIndex = 448
        '
        'SET_INVARCHR130TextBox
        '
        Me.SET_INVARCHR130TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR130TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR130", True))
        Me.SET_INVARCHR130TextBox.Location = New System.Drawing.Point(-442, 42)
        Me.SET_INVARCHR130TextBox.Name = "SET_INVARCHR130TextBox"
        Me.SET_INVARCHR130TextBox.Size = New System.Drawing.Size(38, 21)
        Me.SET_INVARCHR130TextBox.TabIndex = 447
        '
        'Test_13TextBox1
        '
        Me.Test_13TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Test_13TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DIMON_BARICOOD_RIGHTBindingSource, "test_13", True))
        Me.Test_13TextBox1.Location = New System.Drawing.Point(-156, 84)
        Me.Test_13TextBox1.Name = "Test_13TextBox1"
        Me.Test_13TextBox1.Size = New System.Drawing.Size(35, 21)
        Me.Test_13TextBox1.TabIndex = 446
        '
        'txtStoneStyle
        '
        Me.txtStoneStyle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR131", True))
        Me.txtStoneStyle.Location = New System.Drawing.Point(8, 90)
        Me.txtStoneStyle.Name = "txtStoneStyle"
        Me.txtStoneStyle.Size = New System.Drawing.Size(35, 21)
        Me.txtStoneStyle.TabIndex = 450
        Me.txtStoneStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStoneSize
        '
        Me.txtStoneSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR114", True))
        Me.txtStoneSize.Location = New System.Drawing.Point(47, 90)
        Me.txtStoneSize.Name = "txtStoneSize"
        Me.txtStoneSize.Size = New System.Drawing.Size(35, 21)
        Me.txtStoneSize.TabIndex = 451
        Me.txtStoneSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label75
        '
        Me.Label75.Location = New System.Drawing.Point(87, 91)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(56, 19)
        Me.Label75.TabIndex = 452
        Me.Label75.Text = "خط الحجر"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBarCodeStyle
        '
        Me.txtBarCodeStyle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR135", True))
        Me.txtBarCodeStyle.Location = New System.Drawing.Point(8, 132)
        Me.txtBarCodeStyle.Name = "txtBarCodeStyle"
        Me.txtBarCodeStyle.Size = New System.Drawing.Size(35, 21)
        Me.txtBarCodeStyle.TabIndex = 453
        Me.txtBarCodeStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBarCodeSize
        '
        Me.txtBarCodeSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR134", True))
        Me.txtBarCodeSize.Location = New System.Drawing.Point(47, 132)
        Me.txtBarCodeSize.Name = "txtBarCodeSize"
        Me.txtBarCodeSize.Size = New System.Drawing.Size(35, 21)
        Me.txtBarCodeSize.TabIndex = 454
        Me.txtBarCodeSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label76
        '
        Me.Label76.Location = New System.Drawing.Point(87, 133)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(56, 19)
        Me.Label76.TabIndex = 455
        Me.Label76.Text = "خط الباركود"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCompanyStyle
        '
        Me.txtCompanyStyle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR133", True))
        Me.txtCompanyStyle.Location = New System.Drawing.Point(8, 111)
        Me.txtCompanyStyle.Name = "txtCompanyStyle"
        Me.txtCompanyStyle.Size = New System.Drawing.Size(35, 21)
        Me.txtCompanyStyle.TabIndex = 456
        Me.txtCompanyStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCompanySize
        '
        Me.txtCompanySize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR132", True))
        Me.txtCompanySize.Location = New System.Drawing.Point(47, 111)
        Me.txtCompanySize.Name = "txtCompanySize"
        Me.txtCompanySize.Size = New System.Drawing.Size(35, 21)
        Me.txtCompanySize.TabIndex = 457
        Me.txtCompanySize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label77
        '
        Me.Label77.Location = New System.Drawing.Point(87, 112)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(56, 19)
        Me.Label77.TabIndex = 458
        Me.Label77.Text = "خط المعرض"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFontStyle
        '
        Me.txtFontStyle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR137", True))
        Me.txtFontStyle.Location = New System.Drawing.Point(8, 153)
        Me.txtFontStyle.Name = "txtFontStyle"
        Me.txtFontStyle.Size = New System.Drawing.Size(35, 21)
        Me.txtFontStyle.TabIndex = 459
        Me.txtFontStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFontSize
        '
        Me.txtFontSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR136", True))
        Me.txtFontSize.Location = New System.Drawing.Point(47, 153)
        Me.txtFontSize.Name = "txtFontSize"
        Me.txtFontSize.Size = New System.Drawing.Size(35, 21)
        Me.txtFontSize.TabIndex = 460
        Me.txtFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label78
        '
        Me.Label78.Location = New System.Drawing.Point(87, 154)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(56, 19)
        Me.Label78.TabIndex = 461
        Me.Label78.Text = "خط الكتابة"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label79
        '
        Me.Label79.Location = New System.Drawing.Point(8, 68)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(35, 19)
        Me.Label79.TabIndex = 452
        Me.Label79.Text = "نمط"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label80
        '
        Me.Label80.Location = New System.Drawing.Point(47, 68)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(35, 19)
        Me.Label80.TabIndex = 452
        Me.Label80.Text = "رقم"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrintRangeEnd
        '
        Me.lblPrintRangeEnd.Location = New System.Drawing.Point(11, 13)
        Me.lblPrintRangeEnd.Name = "lblPrintRangeEnd"
        Me.lblPrintRangeEnd.Size = New System.Drawing.Size(141, 19)
        Me.lblPrintRangeEnd.TabIndex = 464
        Me.lblPrintRangeEnd.Text = "ينتهي عند"
        Me.lblPrintRangeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbPrintRange
        '
        Me.cmbPrintRange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbPrintRange.Enabled = False
        Me.cmbPrintRange.FormattingEnabled = True
        Me.cmbPrintRange.Location = New System.Drawing.Point(11, 35)
        Me.cmbPrintRange.Name = "cmbPrintRange"
        Me.cmbPrintRange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbPrintRange.Size = New System.Drawing.Size(141, 21)
        Me.cmbPrintRange.TabIndex = 462
        '
        'chkPrintRange
        '
        Me.chkPrintRange.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkPrintRange.Location = New System.Drawing.Point(158, 37)
        Me.chkPrintRange.Name = "chkPrintRange"
        Me.chkPrintRange.Size = New System.Drawing.Size(72, 18)
        Me.chkPrintRange.TabIndex = 463
        Me.chkPrintRange.Text = "طباعة متتابعة"
        Me.chkPrintRange.UseVisualStyleBackColor = True
        '
        'SET_INVARCHR110TextBox
        '
        Me.SET_INVARCHR110TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR110TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR110", True))
        Me.SET_INVARCHR110TextBox.Location = New System.Drawing.Point(47, 174)
        Me.SET_INVARCHR110TextBox.Name = "SET_INVARCHR110TextBox"
        Me.SET_INVARCHR110TextBox.Size = New System.Drawing.Size(35, 21)
        Me.SET_INVARCHR110TextBox.TabIndex = 451
        Me.SET_INVARCHR110TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SET_INVARCHR111TextBox
        '
        Me.SET_INVARCHR111TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR111TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR111", True))
        Me.SET_INVARCHR111TextBox.Location = New System.Drawing.Point(8, 174)
        Me.SET_INVARCHR111TextBox.Name = "SET_INVARCHR111TextBox"
        Me.SET_INVARCHR111TextBox.Size = New System.Drawing.Size(35, 21)
        Me.SET_INVARCHR111TextBox.TabIndex = 452
        Me.SET_INVARCHR111TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label84
        '
        Me.Label84.Location = New System.Drawing.Point(87, 175)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(56, 19)
        Me.Label84.TabIndex = 465
        Me.Label84.Text = "خط الرمز"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDefaults
        '
        Me.btnDefaults.BackColor = System.Drawing.Color.GhostWhite
        Me.btnDefaults.ForeColor = System.Drawing.Color.Maroon
        Me.btnDefaults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDefaults.Location = New System.Drawing.Point(7, 20)
        Me.btnDefaults.Name = "btnDefaults"
        Me.btnDefaults.Size = New System.Drawing.Size(148, 35)
        Me.btnDefaults.TabIndex = 466
        Me.btnDefaults.Text = "افتراضيات"
        Me.btnDefaults.UseVisualStyleBackColor = False
        '
        'gbPrintRange
        '
        Me.gbPrintRange.Controls.Add(Me.chkPrintRange)
        Me.gbPrintRange.Controls.Add(Me.lblPrintRangeEnd)
        Me.gbPrintRange.Controls.Add(Me.cmbPrintRange)
        Me.gbPrintRange.Location = New System.Drawing.Point(411, 5)
        Me.gbPrintRange.Name = "gbPrintRange"
        Me.gbPrintRange.Size = New System.Drawing.Size(239, 74)
        Me.gbPrintRange.TabIndex = 467
        Me.gbPrintRange.TabStop = False
        Me.gbPrintRange.Text = "طباعة متتابعة"
        '
        'gbGeneral
        '
        Me.gbGeneral.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.gbGeneral.Controls.Add(Me.Label86)
        Me.gbGeneral.Controls.Add(Me.SET_INVARCHR172TextBox)
        Me.gbGeneral.Controls.Add(Me.SET_INVARCHR171TextBox)
        Me.gbGeneral.Controls.Add(Me.btnDefaults)
        Me.gbGeneral.Controls.Add(Me.Program_nameTextBox2)
        Me.gbGeneral.Controls.Add(Me.Label75)
        Me.gbGeneral.Controls.Add(Me.Test_17_right1upTextBox)
        Me.gbGeneral.Controls.Add(Me.Label79)
        Me.gbGeneral.Controls.Add(Me.Tel1upTextBox)
        Me.gbGeneral.Controls.Add(Me.Label80)
        Me.gbGeneral.Controls.Add(Me.txtStoneSize)
        Me.gbGeneral.Controls.Add(Me.txtStoneStyle)
        Me.gbGeneral.Controls.Add(Me.TelTextBox1)
        Me.gbGeneral.Controls.Add(Me.Label76)
        Me.gbGeneral.Controls.Add(Me.Label84)
        Me.gbGeneral.Controls.Add(Me.txtBarCodeSize)
        Me.gbGeneral.Controls.Add(Me.Program_name1upTextBox)
        Me.gbGeneral.Controls.Add(Me.txtBarCodeStyle)
        Me.gbGeneral.Controls.Add(Me.Test_119_rightTextBox)
        Me.gbGeneral.Controls.Add(Me.Label77)
        Me.gbGeneral.Controls.Add(Me.Test_110_right1upTextBox)
        Me.gbGeneral.Controls.Add(Me.txtCompanySize)
        Me.gbGeneral.Controls.Add(Me.Test_118_rightTextBox)
        Me.gbGeneral.Controls.Add(Me.Label1)
        Me.gbGeneral.Controls.Add(Me.SET_INVARCHR111TextBox)
        Me.gbGeneral.Controls.Add(Me.txtCompanyStyle)
        Me.gbGeneral.Controls.Add(Me.Label59)
        Me.gbGeneral.Controls.Add(Me.Label78)
        Me.gbGeneral.Controls.Add(Me.Label85)
        Me.gbGeneral.Controls.Add(Me.Label58)
        Me.gbGeneral.Controls.Add(Me.txtFontSize)
        Me.gbGeneral.Controls.Add(Me.SET_INVARCHR110TextBox)
        Me.gbGeneral.Controls.Add(Me.txtFontStyle)
        Me.gbGeneral.Controls.Add(Me.Label81)
        Me.gbGeneral.Controls.Add(Me.Label57)
        Me.gbGeneral.Controls.Add(Me.SET_INVARCHR126TextBox)
        Me.gbGeneral.Controls.Add(Me.SET_INVARCHR127TextBox)
        Me.gbGeneral.Location = New System.Drawing.Point(415, 134)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(162, 468)
        Me.gbGeneral.TabIndex = 468
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "قيم الخط"
        '
        'Label86
        '
        Me.Label86.Location = New System.Drawing.Point(87, 196)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(56, 19)
        Me.Label86.TabIndex = 469
        Me.Label86.Text = "خط الأرقام"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SET_INVARCHR172TextBox
        '
        Me.SET_INVARCHR172TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR172TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR172", True))
        Me.SET_INVARCHR172TextBox.Location = New System.Drawing.Point(8, 195)
        Me.SET_INVARCHR172TextBox.Name = "SET_INVARCHR172TextBox"
        Me.SET_INVARCHR172TextBox.Size = New System.Drawing.Size(35, 21)
        Me.SET_INVARCHR172TextBox.TabIndex = 468
        Me.SET_INVARCHR172TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SET_INVARCHR171TextBox
        '
        Me.SET_INVARCHR171TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SET_INVARCHR171TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SettingsBindingSource, "SET_INVARCHR171", True))
        Me.SET_INVARCHR171TextBox.Location = New System.Drawing.Point(47, 195)
        Me.SET_INVARCHR171TextBox.Name = "SET_INVARCHR171TextBox"
        Me.SET_INVARCHR171TextBox.Size = New System.Drawing.Size(35, 21)
        Me.SET_INVARCHR171TextBox.TabIndex = 467
        Me.SET_INVARCHR171TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label85
        '
        Me.Label85.Location = New System.Drawing.Point(87, 350)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(56, 19)
        Me.Label85.TabIndex = 440
        Me.Label85.Text = "الرقم يمين"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label81
        '
        Me.Label81.Location = New System.Drawing.Point(87, 329)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(56, 19)
        Me.Label81.TabIndex = 437
        Me.Label81.Text = "الرقم يسار"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DiamondBarCode
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(994, 606)
        Me.Controls.Add(Me.gbGeneral)
        Me.Controls.Add(Me.gbPrintRange)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.Label65)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.txtBarCodeRight)
        Me.Controls.Add(Me.txtBarCodeLeft)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.cmbRightItem)
        Me.Controls.Add(Me.cmbLeftItem)
        Me.Controls.Add(Me.cmbPrinterName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbCompanyName)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.gbLeft)
        Me.Controls.Add(Me.gbRight)
        Me.Controls.Add(Print_nameLabel)
        Me.Controls.Add(Program_nameLabel)
        Me.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DiamondBarCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "باركود ألماس"
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIMON_BARICOOD_LEFTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIMON_BARICOOD_RIGHTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONFI_barcood_dimonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRight.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.gbRightText.ResumeLayout(False)
        Me.gbRightText.PerformLayout()
        CType(Me.pbHRightText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVRightText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRightValue.ResumeLayout(False)
        Me.gbRightValue.PerformLayout()
        CType(Me.pbHRightValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVRightValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLeft.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.gbLeftText.ResumeLayout(False)
        Me.gbLeftText.PerformLayout()
        CType(Me.pbHLeftText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVLeftText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLeftValue.ResumeLayout(False)
        Me.gbLeftValue.PerformLayout()
        CType(Me.pbHLeftValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVLeftValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompinformBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIMONBARICOODFORSELECTLEFTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DIMONBARICOODSELECTRIGHTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnl.PerformLayout()
        Me.gbPrintRange.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        Me.gbGeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents DIMON_BARICOOD_LEFTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIMON_BARICOOD_LEFTTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.DIMON_BARICOOD_LEFTTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DIMON_BARICOOD_RIGHTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIMON_BARICOOD_RIGHTTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.DIMON_BARICOOD_RIGHTTableAdapter
    Friend WithEvents CONFI_barcood_dimonTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.CONFI_barcood_dimonTableAdapter
    Friend WithEvents CONFI_barcood_dimonBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Size_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMOND_ID_leftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMO_dep_leftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIM_na9awa_leftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMO_mezan_leftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ext_coler_leftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Qult_leftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sarual_leftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Val_gold_leftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GOLD_mezan_leftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_1_leftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMOND_ID_rightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMO_dep_rightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIM_na9awa_rightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMO_mezan_rightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ext_coler_rightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Qult_rightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sarual_rightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Val_gold_rightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GOLD_mezan_rightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Print_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Program_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Note2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMOND_ID_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMO_dep_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIM_na9awa_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMO_mezan_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ext_coler_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Qult_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sarual_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Val_gold_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GOLD_mezan_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_1_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMOND_ID_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMO_dep_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIM_na9awa_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMO_mezan_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ext_coler_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Qult_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sarual_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Val_gold_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GOLD_mezan_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_1_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gbRight As System.Windows.Forms.GroupBox
    Friend WithEvents gbLeft As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cmbCompanyName As System.Windows.Forms.ComboBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents CompinformBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Comp_informTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.comp_informTableAdapter
    Friend WithEvents cmbPrinterName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLeftItem As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRightItem As System.Windows.Forms.ComboBox
    Friend WithEvents DIMONBARICOODFORSELECTLEFTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIMON_BARICOOD_FOR_SELECT_LEFTTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.DIMON_BARICOOD_FOR_SELECT_LEFTTableAdapter
    Friend WithEvents DIMONBARICOODSELECTRIGHTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DIMON_BARICOOD_SELECT_RIGHTTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.DIMON_BARICOOD_SELECT_RIGHTTableAdapter
    Friend WithEvents DIMOND_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMON_NAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIM_na9awaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMO_mezanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ext_colerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QultTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SarualTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Val_goldTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GOLD_mezanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_11TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_12TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_13TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_14TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_15TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_16TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_17TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_18TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_19TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_110TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_111TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_112TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_113TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_114TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_115TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_116TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_117TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_118TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_119TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DIMOND_IDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DIMON_NAMETextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DIM_na9awaTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DIMO_mezanTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Ext_colerTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents QultTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SarualTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Val_goldTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GOLD_mezanTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_1TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_11TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_12TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_14TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_15TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_16TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_17TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_19TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_110TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_111TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_112TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_113TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_114TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_115TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_116TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_117TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_118TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_119TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Test_1_rightTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_11_rightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_12_leftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_12_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_11_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Note2TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NoteTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Note21upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Note1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_13_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_14_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_15_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_16_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_17_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_18_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_110_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_111_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_112_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_113_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_114_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_115_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_116_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_117_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_118_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_119_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SET1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SettingsTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents SET_INVARCHR115TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR116TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR117TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR118TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR119TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR120TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR121TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR122TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR123TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR124TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR125TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR126TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR127TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_19_left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR127Text As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR126Text As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR125Text As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR124Text As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR123Text As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR122Text As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR121Text As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR120Text As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR119Text As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR118Text As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR117Text As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR116Text As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR115Text As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR113TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR113Text As System.Windows.Forms.TextBox
    Friend WithEvents Test_11_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_12_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_13_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_14_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_15_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_16_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_17_left1upTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_18_left1upTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_19_left1upTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_110_left1upTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_111_left1upTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_112_left1upTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_113_left1upTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_114_left1upTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_115_left1upTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_116_left1upTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Test_119_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_118_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_117_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_116_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_115_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_114_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_113_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_112_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_111_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents pbVLeftValue As System.Windows.Forms.PictureBox
    Friend WithEvents pbHLeftValue As System.Windows.Forms.PictureBox
    Friend WithEvents pbHRightValue As System.Windows.Forms.PictureBox
    Friend WithEvents pbVRightValue As System.Windows.Forms.PictureBox
    Friend WithEvents pbHRightText As System.Windows.Forms.PictureBox
    Friend WithEvents pbVRightText As System.Windows.Forms.PictureBox
    Friend WithEvents pbHLeftText As System.Windows.Forms.PictureBox
    Friend WithEvents pbVLeftText As System.Windows.Forms.PictureBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbRightText As System.Windows.Forms.GroupBox
    Friend WithEvents gbRightValue As System.Windows.Forms.GroupBox
    Friend WithEvents gbLeftText As System.Windows.Forms.GroupBox
    Friend WithEvents gbLeftValue As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Test_110_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents TelTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Test_119_rightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Test_118_rightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Program_nameTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Tel1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Program_name1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txtBarCodeLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtBarCodeRight As System.Windows.Forms.TextBox
    Friend WithEvents Test_17_right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents SET1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents LeftTextLRStoneWeight1 As System.Windows.Forms.TextBox
    Friend WithEvents LeftTextUDStoneWeight1 As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents LeftTextLRStoneName1 As System.Windows.Forms.TextBox
    Friend WithEvents LeftTextUDStoneName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents LeftValueUDStoneWeight1 As System.Windows.Forms.TextBox
    Friend WithEvents LeftValueLRStoneWeight1 As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents LeftValueUDStoneName1 As System.Windows.Forms.TextBox
    Friend WithEvents LeftValueLRStoneName1 As System.Windows.Forms.TextBox
    Friend WithEvents RightTextLRStoneWeight1 As System.Windows.Forms.TextBox
    Friend WithEvents RightTextUDStoneWeight1 As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents RightTextLRStoneName1 As System.Windows.Forms.TextBox
    Friend WithEvents RightTextUDStoneName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents RightValueUDStoneWeight1 As System.Windows.Forms.TextBox
    Friend WithEvents RightValueLRStoneWeight1 As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents RightValueUDStoneName1 As System.Windows.Forms.TextBox
    Friend WithEvents RightValueLRStoneName1 As System.Windows.Forms.TextBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Test_13TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR145TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR130TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LeftValueUDStoneWeight3 As TextBox
    Friend WithEvents LeftValueLRStoneWeight3 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents LeftValueUDStoneName3 As TextBox
    Friend WithEvents LeftValueLRStoneName3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LeftValueUDStoneWeight2 As TextBox
    Friend WithEvents LeftValueLRStoneWeight2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LeftValueUDStoneName2 As TextBox
    Friend WithEvents LeftValueLRStoneName2 As TextBox
    Friend WithEvents LeftTextLRStoneWeight3 As TextBox
    Friend WithEvents LeftTextUDStoneWeight3 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents LeftTextLRStoneName3 As TextBox
    Friend WithEvents LeftTextUDStoneName3 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents LeftTextLRStoneWeight2 As TextBox
    Friend WithEvents LeftTextUDStoneWeight2 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents LeftTextLRStoneName2 As TextBox
    Friend WithEvents LeftTextUDStoneName2 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents RightTextLRStoneWeight3 As TextBox
    Friend WithEvents RightTextUDStoneWeight3 As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents RightTextLRStoneName3 As TextBox
    Friend WithEvents RightTextUDStoneName3 As TextBox
    Friend WithEvents Label74 As Label
    Friend WithEvents RightTextLRStoneWeight2 As TextBox
    Friend WithEvents RightTextUDStoneWeight2 As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents RightTextLRStoneName2 As TextBox
    Friend WithEvents RightTextUDStoneName2 As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents RightValueUDStoneWeight3 As TextBox
    Friend WithEvents RightValueLRStoneWeight3 As TextBox
    Friend WithEvents RightValueUDStoneName3 As TextBox
    Friend WithEvents RightValueLRStoneName3 As TextBox
    Friend WithEvents RightValueUDStoneWeight2 As TextBox
    Friend WithEvents RightValueLRStoneWeight2 As TextBox
    Friend WithEvents RightValueUDStoneName2 As TextBox
    Friend WithEvents RightValueLRStoneName2 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Test_18TextBox1 As TextBox
    Friend WithEvents txtStoneStyle As TextBox
    Friend WithEvents txtStoneSize As TextBox
    Friend WithEvents Label75 As Label
    Friend WithEvents txtBarCodeStyle As TextBox
    Friend WithEvents txtBarCodeSize As TextBox
    Friend WithEvents Label76 As Label
    Friend WithEvents txtCompanyStyle As TextBox
    Friend WithEvents txtCompanySize As TextBox
    Friend WithEvents Label77 As Label
    Friend WithEvents txtFontStyle As TextBox
    Friend WithEvents txtFontSize As TextBox
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents lblPrintRangeEnd As System.Windows.Forms.Label
    Friend WithEvents cmbPrintRange As System.Windows.Forms.ComboBox
    Friend WithEvents chkPrintRange As System.Windows.Forms.CheckBox
    Friend WithEvents SET_INVARCHR18TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Code_Right1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Code_RightupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Code_Left1upTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Code_LeftupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR111TextBox As System.Windows.Forms.TextBox
    Friend WithEvents SET_INVARCHR110TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents btnDefaults As System.Windows.Forms.Button
    Friend WithEvents gbPrintRange As GroupBox
    Friend WithEvents gbGeneral As GroupBox
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Cut1_LeftupTextBox As TextBox
    Friend WithEvents Cut1_Left1upTextBox As TextBox
    Friend WithEvents lblCut1Left As Label
    Friend WithEvents lblCut3Left As Label
    Friend WithEvents Cut3_Left1upTextBox As TextBox
    Friend WithEvents Cut3_LeftupTextBox As TextBox
    Friend WithEvents lblCut2Left As Label
    Friend WithEvents Cut2_Left1upTextBox As TextBox
    Friend WithEvents Cut2_LeftupTextBox As TextBox
    Friend WithEvents lblCut3Right As Label
    Friend WithEvents Cut3_Right1upTextBox As TextBox
    Friend WithEvents Cut3_RightupTextBox As TextBox
    Friend WithEvents lblCut2Right As Label
    Friend WithEvents Cut2_Right1upTextBox As TextBox
    Friend WithEvents Cut2_RightupTextBox As TextBox
    Friend WithEvents Cut1_RightupTextBox As TextBox
    Friend WithEvents Cut1_Right1upTextBox As TextBox
    Friend WithEvents lblCut1Right As Label
    Friend WithEvents Clarity3TextBox1 As TextBox
    Friend WithEvents Cut3TextBox1 As TextBox
    Friend WithEvents Clarity2TextBox1 As TextBox
    Friend WithEvents Cut2TextBox1 As TextBox
    Friend WithEvents Clarity1TextBox1 As TextBox
    Friend WithEvents Cut1TextBox1 As TextBox
    Friend WithEvents IsDiamond3CheckBox As CheckBox
    Friend WithEvents IsDiamond2CheckBox As CheckBox
    Friend WithEvents IsDiamond1CheckBox As CheckBox
    Friend WithEvents Clarity3TextBox As TextBox
    Friend WithEvents Cut3TextBox As TextBox
    Friend WithEvents Clarity2TextBox As TextBox
    Friend WithEvents Cut2TextBox As TextBox
    Friend WithEvents Clarity1TextBox As TextBox
    Friend WithEvents Cut1TextBox As TextBox
    Friend WithEvents IsDiamond3CheckBox1 As CheckBox
    Friend WithEvents IsDiamond2CheckBox1 As CheckBox
    Friend WithEvents IsDiamond1CheckBox1 As CheckBox
    Friend WithEvents TotalStoneWeight_LeftupTextBox As TextBox
    Friend WithEvents TotalStoneWeight_Left1upTextBox As TextBox
    Friend WithEvents lblTotalStoneWeightLeft As Label
    Friend WithEvents TotalStoneWeight_RightupTextBox As TextBox
    Friend WithEvents TotalStoneWeight_Right1upTextBox As TextBox
    Friend WithEvents lblTotalStoneWeightRight As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents SET_INVARCHR172TextBox As TextBox
    Friend WithEvents SET_INVARCHR171TextBox As TextBox
End Class
