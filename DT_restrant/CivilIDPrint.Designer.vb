<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CivilIDPrint
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CivilIDPrint))
        Me.CastomerDETELSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_restrantDataSet = New DT_restrant.DT_restrantDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbPrintSelection = New System.Windows.Forms.ComboBox()
        Me.lblPrintSelection = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtCID = New System.Windows.Forms.TextBox()
        Me.lblCID = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CastomerDETELSTableAdapter = New DT_restrant.DT_restrantDataSetTableAdapters.CastomerDETELSTableAdapter()
        CType(Me.CastomerDETELSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CastomerDETELSBindingSource
        '
        Me.CastomerDETELSBindingSource.DataMember = "CastomerDETELS"
        Me.CastomerDETELSBindingSource.DataSource = Me.DT_restrantDataSet
        '
        'DT_restrantDataSet
        '
        Me.DT_restrantDataSet.DataSetName = "DT_restrantDataSet"
        Me.DT_restrantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.cmbPrintSelection)
        Me.Panel1.Controls.Add(Me.lblPrintSelection)
        Me.Panel1.Controls.Add(Me.btnView)
        Me.Panel1.Controls.Add(Me.txtCID)
        Me.Panel1.Controls.Add(Me.lblCID)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Location = New System.Drawing.Point(5, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 79)
        Me.Panel1.TabIndex = 0
        '
        'cmbPrintSelection
        '
        Me.cmbPrintSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPrintSelection.FormattingEnabled = True
        Me.cmbPrintSelection.Items.AddRange(New Object() {"الوجه والظهر", "الوجه فقط", "الظهر فقط"})
        Me.cmbPrintSelection.Location = New System.Drawing.Point(488, 43)
        Me.cmbPrintSelection.Name = "cmbPrintSelection"
        Me.cmbPrintSelection.Size = New System.Drawing.Size(158, 27)
        Me.cmbPrintSelection.TabIndex = 1
        '
        'lblPrintSelection
        '
        Me.lblPrintSelection.AutoSize = True
        Me.lblPrintSelection.Location = New System.Drawing.Point(652, 46)
        Me.lblPrintSelection.Name = "lblPrintSelection"
        Me.lblPrintSelection.Size = New System.Drawing.Size(101, 19)
        Me.lblPrintSelection.TabIndex = 97
        Me.lblPrintSelection.Text = "المطلوب طباعته"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnView.Image = Global.DT_restrant.My.Resources.Resources.PersonalPhoto
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnView.Location = New System.Drawing.Point(347, 9)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(134, 61)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "عرض"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.UseVisualStyleBackColor = False
        '
        'txtCID
        '
        Me.txtCID.Location = New System.Drawing.Point(488, 9)
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(158, 27)
        Me.txtCID.TabIndex = 0
        Me.txtCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCID
        '
        Me.lblCID.AutoSize = True
        Me.lblCID.Location = New System.Drawing.Point(652, 13)
        Me.lblCID.Name = "lblCID"
        Me.lblCID.Size = New System.Drawing.Size(74, 19)
        Me.lblCID.TabIndex = 94
        Me.lblCID.Text = "الرقم المدني"
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Image = Global.DT_restrant.My.Resources.Resources.PrinterBig
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Location = New System.Drawing.Point(18, 9)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(134, 61)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "طباعة"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.Gray
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.CastomerDETELSBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "DT_restrant.rptCivilIDPrint.rdlc"
        Me.ReportViewer1.LocalReport.ReportPath = ""
        Me.ReportViewer1.Location = New System.Drawing.Point(5, 88)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowToolBar = False
        Me.ReportViewer1.Size = New System.Drawing.Size(785, 527)
        Me.ReportViewer1.TabIndex = 1
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'CastomerDETELSTableAdapter
        '
        Me.CastomerDETELSTableAdapter.ClearBeforeFill = True
        '
        'CivilIDPrint
        '
        Me.AcceptButton = Me.btnView
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(794, 621)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CivilIDPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "طباعة البطاقة المدنية"
        CType(Me.CastomerDETELSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_restrantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DT_restrantDataSet As DT_restrant.DT_restrantDataSet
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CastomerDETELSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CastomerDETELSTableAdapter As DT_restrant.DT_restrantDataSetTableAdapters.CastomerDETELSTableAdapter
    Friend WithEvents cmbPrintSelection As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrintSelection As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents txtCID As System.Windows.Forms.TextBox
    Friend WithEvents lblCID As System.Windows.Forms.Label
End Class
