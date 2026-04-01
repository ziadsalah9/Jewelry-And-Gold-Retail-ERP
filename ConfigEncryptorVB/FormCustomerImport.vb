Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Collections.Generic

Public Class FormCustomerImport

    Private connectionString As String = String.Empty
    Private databaseName As String = String.Empty
    Private connExcel As OleDbConnection
    Private dtExcel As New DataTable
    Private existingCustomerIds As New HashSet(Of String)

    Public Sub New(connString As String, dbName As String)
        InitializeComponent()
        connectionString = connString
        databaseName = dbName
        Me.Text = "استيراد بيانات العملاء من Excel - " & dbName
    End Sub

    Private Sub FormCustomerImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadExistingCustomerIds()
        LoadCustomers()
        lblStatus.Text = "اختر ملف Excel للاستيراد"
        lblStatus.ForeColor = Color.Blue
    End Sub

    Private Sub LoadExistingCustomerIds()
        Try
            existingCustomerIds.Clear()
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                ' استخدام CastomerCAIVELid (الرقم المدني) للتحقق من التكرار
                Dim query As String = "SELECT CastomerCAIVELid FROM CastomerDETELS WHERE CastomerCAIVELid IS NOT NULL AND CastomerCAIVELid <> ''"
                Using cmd As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim customerId As String = reader(0).ToString().Trim()
                            If Not String.IsNullOrEmpty(customerId) Then
                                existingCustomerIds.Add(customerId)
                            End If
                        End While
                    End Using
                End Using
            End Using
            lblStatus.Text = "تم تحميل " & existingCustomerIds.Count & " عميل موجود"
            lblStatus.ForeColor = Color.Green
        Catch ex As Exception
            lblStatus.Text = "خطأ في تحميل العملاء الموجودين: " & ex.Message
            lblStatus.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel Files (*.xls)|*.xls|All Files (*.*)|*.*"
            ofd.Title = "اختر ملف Excel"
            ofd.CheckFileExists = True

            If ofd.ShowDialog() = DialogResult.OK Then
                txtFilePath.Text = ofd.FileName
                GetSheets(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub GetSheets(filePath As String)
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim charToTrim As Char() = {"$"c, "'"c}
            connExcel = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & filePath & ";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1';")

            connExcel.Open()
            Dim dataSet As DataTable = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            cmbSheet.Items.Clear()

            For i As Integer = 0 To dataSet.Rows.Count - 1
                Dim sheetName As String = dataSet.Rows(i)("TABLE_NAME").ToString().Trim(charToTrim)
                cmbSheet.Items.Add(sheetName)
            Next

            If cmbSheet.Items.Count > 0 Then
                cmbSheet.SelectedIndex = 0
            End If

            connExcel.Close()
            lblStatus.Text = "تم تحميل " & cmbSheet.Items.Count & " ورقة عمل"
            lblStatus.ForeColor = Color.Green

        Catch ex As Exception
            MessageBox.Show("خطأ في فتح ملف Excel: " & vbCrLf & ex.Message & vbCrLf & vbCrLf & 
                          "تأكد من:" & vbCrLf & 
                          "1. الملف غير مفتوح في Excel" & vbCrLf & 
                          "2. تثبيت Microsoft Access Database Engine", 
                          "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblStatus.Text = "خطأ في فتح الملف"
            lblStatus.ForeColor = Color.Red
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmbSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSheet.SelectedIndexChanged
        If cmbSheet.SelectedItem IsNot Nothing Then
            GetData()
        End If
    End Sub

    Private Sub GetData()
        If String.IsNullOrEmpty(txtFilePath.Text) OrElse Not File.Exists(txtFilePath.Text) Then
            MessageBox.Show("الرجاء اختيار ملف Excel أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbSheet.SelectedItem Is Nothing Then
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            dgvPreview.Rows.Clear()
            dtExcel.Clear()

            If connExcel Is Nothing OrElse connExcel.State = ConnectionState.Closed Then
                connExcel = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & txtFilePath.Text & ";Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1';")
                connExcel.Open()
            End If

            Dim sheetName As String = cmbSheet.SelectedItem.ToString()
            Dim query As String = "SELECT * FROM [" & sheetName & "$]"

            Using adapter As New OleDbDataAdapter(query, connExcel)
                adapter.Fill(dtExcel)
            End Using

            ' عرض البيانات في DataGridView
            If dtExcel.Rows.Count > 0 Then
                ' إضافة الأعمدة
                dgvPreview.Columns.Clear()
                For Each column As DataColumn In dtExcel.Columns
                    dgvPreview.Columns.Add(column.ColumnName, column.ColumnName)
                Next

                ' إضافة الصفوف
                For Each row As DataRow In dtExcel.Rows
                    Dim rowValues As New List(Of Object)()
                    For Each column As DataColumn In dtExcel.Columns
                        Dim value As Object = row(column)
                        If value Is DBNull.Value OrElse value Is Nothing Then
                            rowValues.Add("")
                        Else
                            rowValues.Add(value.ToString().Trim())
                        End If
                    Next
                    dgvPreview.Rows.Add(rowValues.ToArray())
                Next

                ' تحديد عرض الأعمدة
                For Each column As DataGridViewColumn In dgvPreview.Columns
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                Next

                lblStatus.Text = "تم تحميل " & dtExcel.Rows.Count & " صف من البيانات"
                lblStatus.ForeColor = Color.Green
            Else
                lblStatus.Text = "لا توجد بيانات في الورقة المحددة"
                lblStatus.ForeColor = Color.Orange
            End If

        Catch ex As Exception
            MessageBox.Show("خطأ في قراءة البيانات من Excel: " & vbCrLf & ex.Message, 
                          "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblStatus.Text = "خطأ في قراءة البيانات"
            lblStatus.ForeColor = Color.Red
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub AddLog(message As String, Optional logType As String = "INFO")
        Dim timestamp As String = DateTime.Now.ToString("HH:mm:ss")
        Dim prefix As String = ""
        Dim color As Color = Color.Black

        Select Case logType.ToUpper()
            Case "SUCCESS"
                prefix = "✓"
                color = Color.Green
            Case "ERROR"
                prefix = "✗"
                color = Color.Red
            Case "WARNING"
                prefix = "⚠"
                color = Color.Orange
            Case "SKIP"
                prefix = "⊘"
                color = Color.Gray
            Case Else
                prefix = "ℹ"
                color = Color.Blue
        End Select

        rtbLog.SelectionStart = rtbLog.TextLength
        rtbLog.SelectionLength = 0
        rtbLog.SelectionColor = color
        rtbLog.AppendText("[" & timestamp & "] " & prefix & " " & message & vbCrLf)
        rtbLog.SelectionColor = rtbLog.ForeColor
        rtbLog.ScrollToCaret()
        Application.DoEvents()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        If dtExcel Is Nothing OrElse dtExcel.Rows.Count = 0 Then
            MessageBox.Show("لا توجد بيانات للاستيراد", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            btnImport.Enabled = False
            rtbLog.Clear()

            Dim successCount As Integer = 0
            Dim skipCount As Integer = 0
            Dim errorCount As Integer = 0

            AddLog("بدء عملية الاستيراد...", "INFO")
            AddLog("عدد الصفوف في Excel: " & dtExcel.Rows.Count, "INFO")

            ' تحديث قائمة العملاء الموجودين
            LoadExistingCustomerIds()
            AddLog("تم تحميل " & existingCustomerIds.Count & " عميل موجود من قاعدة البيانات", "INFO")

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' البحث عن أعمدة Excel
                Dim customerIdCol As Integer = -1
                Dim customerNameCol As Integer = -1
                Dim customerAddrCol As Integer = -1
                Dim customerTelCol As Integer = -1
                Dim customerNACol As Integer = -1
                Dim customerNameEnCol As Integer = -1

                ' البحث عن الأعمدة بالاسم
                For i As Integer = 0 To dtExcel.Columns.Count - 1
                    Dim colName As String = dtExcel.Columns(i).ColumnName.Trim().ToUpper()
                    If colName.Contains("CASTOMERID") OrElse colName.Contains("CUSTOMERID") Then
                        customerIdCol = i
                    ElseIf colName.Contains("CASTOMERNAME") OrElse colName.Contains("CUSTOMERNAME") Then
                        If Not colName.Contains("EN") Then
                            customerNameCol = i
                        End If
                    ElseIf colName.Contains("CASTOMERADR") OrElse colName.Contains("CUSTOMERADR") OrElse colName.Contains("ADDRESS") Then
                        customerAddrCol = i
                    ElseIf colName.Contains("CASTOMERTE") OrElse colName.Contains("CUSTOMERTE") OrElse colName.Contains("TELEPHONE") OrElse colName.Contains("PHONE") Then
                        customerTelCol = i
                    ElseIf colName.Contains("CASTOMERNA") OrElse colName.Contains("CUSTOMERNA") OrElse colName.Contains("NATIONALITY") Then
                        customerNACol = i
                    ElseIf colName.Contains("CASTOMERNAMEEN") OrElse colName.Contains("CUSTOMERNAMEEN") Then
                        customerNameEnCol = i
                    End If
                Next

                ' إذا لم يتم العثور على الأعمدة، استخدم الفهرس (افتراضي)
                If customerIdCol = -1 Then customerIdCol = 0
                If customerNameCol = -1 Then customerNameCol = 1
                If customerAddrCol = -1 Then customerAddrCol = 2
                If customerTelCol = -1 Then customerTelCol = 3
                If customerNACol = -1 Then customerNACol = 4
                If customerNameEnCol = -1 AndAlso dtExcel.Columns.Count > 5 Then customerNameEnCol = 5

                AddLog("تم تحديد الأعمدة: ID=" & customerIdCol & ", Name=" & customerNameCol & ", Addr=" & customerAddrCol & ", Tel=" & customerTelCol & ", NA=" & customerNACol & ", NameEn=" & customerNameEnCol, "INFO")

                ' معالجة كل صف
                Dim rowIndex As Integer = 0
                For Each row As DataRow In dtExcel.Rows
                    rowIndex += 1
                    Try
                        ' قراءة البيانات
                        Dim customerIdStr As String = If(row(customerIdCol) IsNot DBNull.Value, row(customerIdCol).ToString().Trim(), "")
                        Dim customerName As String = If(customerNameCol >= 0 AndAlso customerNameCol < row.ItemArray.Length AndAlso row(customerNameCol) IsNot DBNull.Value, 
                                                       row(customerNameCol).ToString().Trim(), "")
                        Dim customerAddr As String = If(customerAddrCol >= 0 AndAlso customerAddrCol < row.ItemArray.Length AndAlso row(customerAddrCol) IsNot DBNull.Value, 
                                                        row(customerAddrCol).ToString().Trim(), "")
                        Dim customerTel As String = If(customerTelCol >= 0 AndAlso customerTelCol < row.ItemArray.Length AndAlso row(customerTelCol) IsNot DBNull.Value, 
                                                       row(customerTelCol).ToString().Trim(), "")
                        Dim customerNA As String = If(customerNACol >= 0 AndAlso customerNACol < row.ItemArray.Length AndAlso row(customerNACol) IsNot DBNull.Value, 
                                                      row(customerNACol).ToString().Trim(), "")
                        Dim customerNameEn As String = If(customerNameEnCol >= 0 AndAlso customerNameEnCol < row.ItemArray.Length AndAlso row(customerNameEnCol) IsNot DBNull.Value, 
                                                          row(customerNameEnCol).ToString().Trim(), "")

                        AddLog("معالجة صف #" & rowIndex & " - ID: " & customerIdStr & ", Name: " & customerName, "INFO")

                        ' التحقق من البيانات الأساسية
                        If String.IsNullOrEmpty(customerIdStr) OrElse String.IsNullOrEmpty(customerName) Then
                            skipCount += 1
                            AddLog("  → تم تخطي صف #" & rowIndex & " - بيانات ناقصة (ID أو Name فارغ)", "SKIP")
                            Continue For
                        End If

                        ' التحقق من التكرار باستخدام الرقم المدني
                        If existingCustomerIds.Contains(customerIdStr) Then
                            skipCount += 1
                            AddLog("  → تم تخطي صف #" & rowIndex & " - عميل موجود مسبقاً (الرقم المدني: " & customerIdStr & ")", "SKIP")
                            Continue For
                        End If

                        ' إدراج البيانات - CastomerID هو Identity Column، لا ندرجه
                        Dim insertQuery As String = "INSERT INTO CastomerDETELS " &
                                                   "(CastomerCAIVELid, CastomerNAme, CastomerADr, CastomerTE, CastomerNA, CastomerNameEn) " &
                                                   "VALUES (@CastomerCAIVELid, @CastomerNAme, @CastomerADr, @CastomerTE, @CastomerNA, @CastomerNameEn)"

                        Using cmd As New SqlCommand(insertQuery, connection)
                            cmd.Parameters.AddWithValue("@CastomerCAIVELid", customerIdStr)
                            cmd.Parameters.AddWithValue("@CastomerNAme", If(String.IsNullOrEmpty(customerName), "", customerName))
                            cmd.Parameters.AddWithValue("@CastomerADr", If(String.IsNullOrEmpty(customerAddr), "", customerAddr))
                            cmd.Parameters.AddWithValue("@CastomerTE", If(String.IsNullOrEmpty(customerTel), "", customerTel))
                            cmd.Parameters.AddWithValue("@CastomerNA", If(String.IsNullOrEmpty(customerNA), "", customerNA))
                            cmd.Parameters.AddWithValue("@CastomerNameEn", If(String.IsNullOrEmpty(customerNameEn), "", customerNameEn))

                            cmd.ExecuteNonQuery()
                            successCount += 1
                            existingCustomerIds.Add(customerIdStr)
                            AddLog("  → ✓ تم إدراج صف #" & rowIndex & " بنجاح - الرقم المدني: " & customerIdStr & ", Name: " & customerName, "SUCCESS")
                        End Using

                    Catch ex As Exception
                        errorCount += 1
                        AddLog("  → ✗ خطأ في صف #" & rowIndex & ": " & ex.Message, "ERROR")
                        If ex.InnerException IsNot Nothing Then
                            AddLog("     التفاصيل: " & ex.InnerException.Message, "ERROR")
                        End If
                    End Try
                Next
            End Using

            ' عرض النتائج في السجل
            AddLog("", "INFO")
            AddLog("═══════════════════════════════════════════════════", "INFO")
            AddLog("ملخص عملية الاستيراد:", "INFO")
            AddLog("  ✓ تم إدراج: " & successCount & " عميل", "SUCCESS")
            AddLog("  ⊘ تم تخطي: " & skipCount & " عميل", "SKIP")
            AddLog("  ✗ أخطاء: " & errorCount & " صف", If(errorCount > 0, "ERROR", "INFO"))
            AddLog("═══════════════════════════════════════════════════", "INFO")

            ' عرض النتائج في MessageBox
            Dim message As String = "تم الانتهاء من الاستيراد:" & vbCrLf &
                                   "✓ تم إدراج: " & successCount & " عميل" & vbCrLf &
                                   "⊘ تم تخطي: " & skipCount & " عميل (متكرر أو بيانات ناقصة)" & vbCrLf &
                                   "✗ أخطاء: " & errorCount & " صف" & vbCrLf & vbCrLf &
                                   "راجع سجل الاستيراد للتفاصيل الكاملة"

            MessageBox.Show(message, "نتيجة الاستيراد", MessageBoxButtons.OK, 
                          If(errorCount > 0, MessageBoxIcon.Warning, MessageBoxIcon.Information))

            lblStatus.Text = "تم إدراج " & successCount & " عميل جديد"
            lblStatus.ForeColor = Color.Green

            ' تحديث العرض
            GetData()
            
            ' تحديث قائمة العملاء إذا كان التبويب مفتوح
            If tabMain.SelectedTab Is tabCustomers Then
                LoadCustomers()
            End If

        Catch ex As Exception
            MessageBox.Show("خطأ في الاستيراد: " & vbCrLf & ex.Message, "خطأ", 
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblStatus.Text = "فشل الاستيراد"
            lblStatus.ForeColor = Color.Red
        Finally
            Me.Cursor = Cursors.Default
            btnImport.Enabled = True
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If connExcel IsNot Nothing AndAlso connExcel.State = ConnectionState.Open Then
            connExcel.Close()
        End If
        Me.Close()
    End Sub

    Private Sub FormCustomerImport_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If connExcel IsNot Nothing AndAlso connExcel.State = ConnectionState.Open Then
            connExcel.Close()
        End If
    End Sub

    Private Sub LoadCustomers(Optional searchText As String = "")
        Try
            Me.Cursor = Cursors.WaitCursor
            dgvCustomers.Rows.Clear()

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT CastomerID, CastomerCAIVELid, CastomerNAme, CastomerADr, CastomerTE, CastomerNA, CastomerNameEn " &
                                      "FROM CastomerDETELS"

                ' إضافة شرط البحث إذا كان موجوداً
                If Not String.IsNullOrWhiteSpace(searchText) Then
                    query &= " WHERE (CastomerCAIVELid LIKE @SearchText OR CastomerNAme LIKE @SearchText OR CastomerNameEn LIKE @SearchText)"
                End If

                query &= " ORDER BY CastomerID DESC"

                Using cmd As New SqlCommand(query, connection)
                    If Not String.IsNullOrWhiteSpace(searchText) Then
                        cmd.Parameters.AddWithValue("@SearchText", "%" & searchText.Trim() & "%")
                    End If

                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)

                        ' إضافة الأعمدة إذا لم تكن موجودة
                        If dgvCustomers.Columns.Count = 0 Then
                            dgvCustomers.Columns.Add("CastomerID", "رقم العميل")
                            dgvCustomers.Columns.Add("CastomerCAIVELid", "الرقم المدني")
                            dgvCustomers.Columns.Add("CastomerNAme", "الاسم")
                            dgvCustomers.Columns.Add("CastomerADr", "العنوان")
                            dgvCustomers.Columns.Add("CastomerTE", "الهاتف")
                            dgvCustomers.Columns.Add("CastomerNA", "الجنسية")
                            dgvCustomers.Columns.Add("CastomerNameEn", "الاسم بالإنجليزية")
                        End If

                        ' إضافة البيانات
                        For Each row As DataRow In dt.Rows
                            dgvCustomers.Rows.Add(
                                If(row("CastomerID") IsNot DBNull.Value, row("CastomerID").ToString(), ""),
                                If(row("CastomerCAIVELid") IsNot DBNull.Value, row("CastomerCAIVELid").ToString(), ""),
                                If(row("CastomerNAme") IsNot DBNull.Value, row("CastomerNAme").ToString(), ""),
                                If(row("CastomerADr") IsNot DBNull.Value, row("CastomerADr").ToString(), ""),
                                If(row("CastomerTE") IsNot DBNull.Value, row("CastomerTE").ToString(), ""),
                                If(row("CastomerNA") IsNot DBNull.Value, row("CastomerNA").ToString(), ""),
                                If(row("CastomerNameEn") IsNot DBNull.Value, row("CastomerNameEn").ToString(), "")
                            )
                        Next

                        ' تحديد عرض الأعمدة
                        For Each column As DataGridViewColumn In dgvCustomers.Columns
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        Next

                        lblStatus.Text = "تم تحميل " & dt.Rows.Count & " عميل"
                        lblStatus.ForeColor = Color.Green
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("خطأ في تحميل العملاء: " & vbCrLf & ex.Message, "خطأ", 
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblStatus.Text = "خطأ في تحميل العملاء"
            lblStatus.ForeColor = Color.Red
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.Trim()
        LoadCustomers(searchText)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadCustomers()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub tabMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMain.SelectedIndexChanged
        If tabMain.SelectedTab Is tabCustomers Then
            ' عند التبديل إلى تبويب العملاء، قم بتحميل البيانات
            If dgvCustomers.Rows.Count = 0 Then
                LoadCustomers()
            End If
        End If
    End Sub

    Private Sub btnClearLog_Click(sender As Object, e As EventArgs) Handles btnClearLog.Click
        rtbLog.Clear()
        AddLog("تم مسح السجل", "INFO")
    End Sub

End Class

