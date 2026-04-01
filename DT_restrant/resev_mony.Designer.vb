<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resev_mony
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
        Dim Rsev_mony_idLabel As System.Windows.Forms.Label
        Dim Mony_fromLabel As System.Windows.Forms.Label
        Dim Date_resevLabel As System.Windows.Forms.Label
        Dim For_wontLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim User_idLabel As System.Windows.Forms.Label
        Dim KachLabel As System.Windows.Forms.Label
        Dim Total_moneLabel As System.Windows.Forms.Label
        Dim KentLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(resev_mony))
        Me.Resev_monyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.Resev_monyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rsev_mony_idTextBox = New System.Windows.Forms.TextBox()
        Me.Mony_fromTextBox = New System.Windows.Forms.TextBox()
        Me.Date_resevDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.For_wontTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.User_idTextBox = New System.Windows.Forms.TextBox()
        Me.KachTextBox = New System.Windows.Forms.TextBox()
        Me.Total_moneTextBox = New System.Windows.Forms.TextBox()
        Me.KentTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Resev_monyTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.resev_monyTableAdapter()
        Me.TableAdapterManager = New DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Rsev_mony_idLabel = New System.Windows.Forms.Label()
        Mony_fromLabel = New System.Windows.Forms.Label()
        Date_resevLabel = New System.Windows.Forms.Label()
        For_wontLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        User_idLabel = New System.Windows.Forms.Label()
        KachLabel = New System.Windows.Forms.Label()
        Total_moneLabel = New System.Windows.Forms.Label()
        KentLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.Resev_monyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Resev_monyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rsev_mony_idLabel
        '
        Rsev_mony_idLabel.AutoSize = True
        Rsev_mony_idLabel.Location = New System.Drawing.Point(686, 71)
        Rsev_mony_idLabel.Name = "Rsev_mony_idLabel"
        Rsev_mony_idLabel.Size = New System.Drawing.Size(72, 13)
        Rsev_mony_idLabel.TabIndex = 2
        Rsev_mony_idLabel.Text = "rsev mony id:"
        '
        'Mony_fromLabel
        '
        Mony_fromLabel.AutoSize = True
        Mony_fromLabel.Location = New System.Drawing.Point(686, 97)
        Mony_fromLabel.Name = "Mony_fromLabel"
        Mony_fromLabel.Size = New System.Drawing.Size(62, 13)
        Mony_fromLabel.TabIndex = 4
        Mony_fromLabel.Text = "mony from:"
        '
        'Date_resevLabel
        '
        Date_resevLabel.AutoSize = True
        Date_resevLabel.Location = New System.Drawing.Point(686, 124)
        Date_resevLabel.Name = "Date_resevLabel"
        Date_resevLabel.Size = New System.Drawing.Size(63, 13)
        Date_resevLabel.TabIndex = 6
        Date_resevLabel.Text = "date resev:"
        '
        'For_wontLabel
        '
        For_wontLabel.AutoSize = True
        For_wontLabel.Location = New System.Drawing.Point(686, 149)
        For_wontLabel.Name = "For_wontLabel"
        For_wontLabel.Size = New System.Drawing.Size(52, 13)
        For_wontLabel.TabIndex = 8
        For_wontLabel.Text = "for wont:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(686, 175)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(33, 13)
        NoteLabel.TabIndex = 10
        NoteLabel.Text = "note:"
        '
        'User_idLabel
        '
        User_idLabel.AutoSize = True
        User_idLabel.Location = New System.Drawing.Point(686, 201)
        User_idLabel.Name = "User_idLabel"
        User_idLabel.Size = New System.Drawing.Size(43, 13)
        User_idLabel.TabIndex = 12
        User_idLabel.Text = "user id:"
        '
        'KachLabel
        '
        KachLabel.AutoSize = True
        KachLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KachLabel.Location = New System.Drawing.Point(408, 212)
        KachLabel.Name = "KachLabel"
        KachLabel.Size = New System.Drawing.Size(38, 22)
        KachLabel.TabIndex = 14
        KachLabel.Text = "كاش"
        '
        'Total_moneLabel
        '
        Total_moneLabel.AutoSize = True
        Total_moneLabel.Location = New System.Drawing.Point(861, 272)
        Total_moneLabel.Name = "Total_moneLabel"
        Total_moneLabel.Size = New System.Drawing.Size(71, 13)
        Total_moneLabel.TabIndex = 16
        Total_moneLabel.Text = "اجمالي المبلغ"
        '
        'KentLabel
        '
        KentLabel.AutoSize = True
        KentLabel.BackColor = System.Drawing.Color.Transparent
        KentLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        KentLabel.Location = New System.Drawing.Point(590, 212)
        KentLabel.Name = "KentLabel"
        KentLabel.Size = New System.Drawing.Size(50, 22)
        KentLabel.TabIndex = 18
        KentLabel.Text = "كي نت"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(802, 239)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 36
        DateLabel.Text = "date:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label1.Location = New System.Drawing.Point(572, 47)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(68, 22)
        Label1.TabIndex = 39
        Label1.Text = "من شركة"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label2.Location = New System.Drawing.Point(598, 102)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(42, 22)
        Label2.TabIndex = 40
        Label2.Text = "الاسم"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label3.Location = New System.Drawing.Point(205, 13)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(64, 22)
        Label3.TabIndex = 41
        Label3.Text = "ملاحظات"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label4.Location = New System.Drawing.Point(563, 153)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(77, 22)
        Label4.TabIndex = 42
        Label4.Text = "تاريخ اليوم"
        '
        'Resev_monyBindingSource
        '
        Me.Resev_monyBindingSource.DataMember = "resev_mony"
        Me.Resev_monyBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Resev_monyDataGridView
        '
        Me.Resev_monyDataGridView.AutoGenerateColumns = False
        Me.Resev_monyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Resev_monyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Resev_monyDataGridView.DataSource = Me.Resev_monyBindingSource
        Me.Resev_monyDataGridView.Location = New System.Drawing.Point(818, 318)
        Me.Resev_monyDataGridView.Name = "Resev_monyDataGridView"
        Me.Resev_monyDataGridView.Size = New System.Drawing.Size(55, 37)
        Me.Resev_monyDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "rsev_mony_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "rsev_mony_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "mony_from"
        Me.DataGridViewTextBoxColumn2.HeaderText = "mony_from"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "date_resev"
        Me.DataGridViewTextBoxColumn3.HeaderText = "date_resev"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "for_wont"
        Me.DataGridViewTextBoxColumn4.HeaderText = "for_wont"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn5.HeaderText = "note"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "user_id"
        Me.DataGridViewTextBoxColumn6.HeaderText = "user_id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "kach"
        Me.DataGridViewTextBoxColumn7.HeaderText = "kach"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "total_mone"
        Me.DataGridViewTextBoxColumn8.HeaderText = "total_mone"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "kent"
        Me.DataGridViewTextBoxColumn9.HeaderText = "kent"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Rsev_mony_idTextBox
        '
        Me.Rsev_mony_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Resev_monyBindingSource, "rsev_mony_id", True))
        Me.Rsev_mony_idTextBox.Location = New System.Drawing.Point(764, 68)
        Me.Rsev_mony_idTextBox.Name = "Rsev_mony_idTextBox"
        Me.Rsev_mony_idTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Rsev_mony_idTextBox.TabIndex = 3
        '
        'Mony_fromTextBox
        '
        Me.Mony_fromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Resev_monyBindingSource, "mony_from", True))
        Me.Mony_fromTextBox.Location = New System.Drawing.Point(764, 94)
        Me.Mony_fromTextBox.Name = "Mony_fromTextBox"
        Me.Mony_fromTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Mony_fromTextBox.TabIndex = 5
        '
        'Date_resevDateTimePicker
        '
        Me.Date_resevDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Resev_monyBindingSource, "date_resev", True))
        Me.Date_resevDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_resevDateTimePicker.Location = New System.Drawing.Point(764, 120)
        Me.Date_resevDateTimePicker.Name = "Date_resevDateTimePicker"
        Me.Date_resevDateTimePicker.Size = New System.Drawing.Size(46, 20)
        Me.Date_resevDateTimePicker.TabIndex = 7
        '
        'For_wontTextBox
        '
        Me.For_wontTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Resev_monyBindingSource, "for_wont", True))
        Me.For_wontTextBox.Location = New System.Drawing.Point(764, 146)
        Me.For_wontTextBox.Name = "For_wontTextBox"
        Me.For_wontTextBox.Size = New System.Drawing.Size(46, 20)
        Me.For_wontTextBox.TabIndex = 9
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Resev_monyBindingSource, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(764, 172)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(46, 20)
        Me.NoteTextBox.TabIndex = 11
        '
        'User_idTextBox
        '
        Me.User_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Resev_monyBindingSource, "user_id", True))
        Me.User_idTextBox.Location = New System.Drawing.Point(764, 198)
        Me.User_idTextBox.Name = "User_idTextBox"
        Me.User_idTextBox.Size = New System.Drawing.Size(46, 20)
        Me.User_idTextBox.TabIndex = 13
        '
        'KachTextBox
        '
        Me.KachTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Resev_monyBindingSource, "kach", True))
        Me.KachTextBox.Location = New System.Drawing.Point(764, 221)
        Me.KachTextBox.Name = "KachTextBox"
        Me.KachTextBox.Size = New System.Drawing.Size(10, 20)
        Me.KachTextBox.TabIndex = 15
        '
        'Total_moneTextBox
        '
        Me.Total_moneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Resev_monyBindingSource, "total_mone", True))
        Me.Total_moneTextBox.Location = New System.Drawing.Point(719, 228)
        Me.Total_moneTextBox.Name = "Total_moneTextBox"
        Me.Total_moneTextBox.Size = New System.Drawing.Size(10, 20)
        Me.Total_moneTextBox.TabIndex = 17
        '
        'KentTextBox
        '
        Me.KentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Resev_monyBindingSource, "kent", True))
        Me.KentTextBox.Location = New System.Drawing.Point(764, 243)
        Me.KentTextBox.Name = "KentTextBox"
        Me.KentTextBox.Size = New System.Drawing.Size(10, 20)
        Me.KentTextBox.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(293, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 29)
        Me.TextBox1.TabIndex = 30
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(293, 95)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(256, 29)
        Me.TextBox2.TabIndex = 31
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(11, 38)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(261, 206)
        Me.TextBox3.TabIndex = 32
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(731, 8)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(176, 34)
        Me.TextBox4.TabIndex = 33
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(293, 205)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(109, 29)
        Me.TextBox5.TabIndex = 34
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(679, 269)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(176, 20)
        Me.TextBox6.TabIndex = 35
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(467, 205)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(82, 29)
        Me.TextBox7.TabIndex = 36
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Resev_monyBindingSource, "date", True))
        Me.DateTextBox.Location = New System.Drawing.Point(841, 236)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DateTextBox.TabIndex = 37
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(293, 146)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(256, 29)
        Me.DateTimePicker1.TabIndex = 38
        '
        'Resev_monyTableAdapter
        '
        Me.Resev_monyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BAY_from_comp_bayTableAdapter = Nothing

        Me.TableAdapterManager.bay_goled_monyTableAdapter = Nothing
        Me.TableAdapterManager.bay_monyTableAdapter = Nothing
        Me.TableAdapterManager.BAYTableAdapter = Nothing
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
        Me.TableAdapterManager.dimon_bayTableAdapter = Nothing
        Me.TableAdapterManager.dimon_catTableAdapter = Nothing
        Me.TableAdapterManager.DIMON_detelsTableAdapter = Nothing
        Me.TableAdapterManager.dimon_invceTableAdapter = Nothing

        Me.TableAdapterManager.FO_minTableAdapter = Nothing
        Me.TableAdapterManager.Gram_valTableAdapter = Nothing
        Me.TableAdapterManager.ID_orderTableAdapter = Nothing
        Me.TableAdapterManager.inv_startTableAdapter = Nothing
        Me.TableAdapterManager.licensTableAdapter = Nothing
        Me.TableAdapterManager.loc_nameTableAdapter = Nothing
        Me.TableAdapterManager.ORDERTableAdapter = Nothing
        Me.TableAdapterManager.resev_goldTableAdapter = Nothing
        Me.TableAdapterManager.resev_monyTableAdapter = Me.Resev_monyTableAdapter
        Me.TableAdapterManager.selInvoceDetelsTableAdapter = Nothing
        Me.TableAdapterManager.send_monyTableAdapter = Nothing
        Me.TableAdapterManager.sent_goldTableAdapter = Nothing
        Me.TableAdapterManager.SettingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userTableAdapter = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(KentLabel)
        Me.GroupBox1.Controls.Add(KachLabel)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 254)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات القبض"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Image = Global.DT_restrant.My.Resources.Resources.Scroll
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(12, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 39)
        Me.Button4.TabIndex = 44
        Me.Button4.Text = "طباعة"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Image = Global.DT_restrant.My.Resources.Resources.DiskError
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(182, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 39)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "حذف"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Image = Global.DT_restrant.My.Resources.Resources.DiskInfo
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(351, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 39)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "جديد"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = Global.DT_restrant.My.Resources.Resources.DiskOk
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(531, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 39)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "حفظ"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'resev_mony
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(670, 308)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Rsev_mony_idLabel)
        Me.Controls.Add(Me.Rsev_mony_idTextBox)
        Me.Controls.Add(Mony_fromLabel)
        Me.Controls.Add(Me.Mony_fromTextBox)
        Me.Controls.Add(Date_resevLabel)
        Me.Controls.Add(Me.Date_resevDateTimePicker)
        Me.Controls.Add(For_wontLabel)
        Me.Controls.Add(Me.For_wontTextBox)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(User_idLabel)
        Me.Controls.Add(Me.User_idTextBox)
        Me.Controls.Add(Me.KachTextBox)
        Me.Controls.Add(Total_moneLabel)
        Me.Controls.Add(Me.Total_moneTextBox)
        Me.Controls.Add(Me.KentTextBox)
        Me.Controls.Add(Me.Resev_monyDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "resev_mony"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "سند قبض"
        CType(Me.Resev_monyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Resev_monyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents Resev_monyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Resev_monyTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.resev_monyTableAdapter
    Friend WithEvents TableAdapterManager As DT_restrant.DT_restrantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Resev_monyDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rsev_mony_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mony_fromTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_resevDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents For_wontTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents User_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KachTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_moneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
