Imports System
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Text

Public Class FormChangeInvoiceNumber

    Private connectionString As String = String.Empty
    
    Public Sub New(connString As String)
        InitializeComponent()
        connectionString = connString
    End Sub

    Private Sub FormChangeInvoiceNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "تغيير رقم الفاتورة - Change Invoice Number"
        radSellInvoice.Checked = True
        numInvoiceCount.Value = 100
        
        ' تحميل القائمة تلقائياً
        LoadInvoicesList()
        
        ' إضافة حدث للقائمة
        AddHandler lstInvoices.SelectedIndexChanged, AddressOf lstInvoices_SelectedIndexChanged
        AddHandler radSellInvoice.CheckedChanged, AddressOf InvoiceType_CheckedChanged
        AddHandler radBuyInvoice.CheckedChanged, AddressOf InvoiceType_CheckedChanged
        AddHandler radDiamondSell.CheckedChanged, AddressOf InvoiceType_CheckedChanged
        AddHandler radDiamondBuy.CheckedChanged, AddressOf InvoiceType_CheckedChanged
    End Sub
    
    Private Sub InvoiceType_CheckedChanged(sender As Object, e As EventArgs)
        ' إعادة تحميل القائمة عند تغيير نوع الفاتورة
        LoadInvoicesList()
        txtOldInvoiceNo.Clear()
        txtNewInvoiceNo.Clear()
        txtInvoiceDetails.Clear()
        btnSave.Enabled = False
    End Sub
    
    Private Sub btnLoadInvoices_Click(sender As Object, e As EventArgs) Handles btnLoadInvoices.Click
        LoadInvoicesList()
    End Sub
    
    Private Sub LoadInvoicesList()
        Try
            Me.Cursor = Cursors.WaitCursor
            lstInvoices.Items.Clear()
            
            Dim invoiceType As String = GetInvoiceType()
            Dim count As Integer = Convert.ToInt32(numInvoiceCount.Value)
            
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                
                Dim query As String = ""
                Select Case invoiceType
                    Case "GoldBuy"
                        ' فواتير شراء الذهب - آخر X فاتورة من bay_goled_mony
                        query = "SELECT TOP " & count & " [saryal] " &
                               "FROM [bay_goled_mony] " &
                               "WHERE [saryal] IS NOT NULL AND [saryal] <> '' AND [INV_Actv] = 1 " &
                               "GROUP BY [saryal] " &
                               "ORDER BY MAX([bay_id]) DESC"
                    Case "GoldSell"
                        ' فواتير بيع الذهب - آخر X فاتورة من BAY
                        query = "SELECT TOP " & count & " [BAY_SARYAL] " &
                               "FROM [BAY] " &
                               "WHERE [BAY_SARYAL] IS NOT NULL AND [BAY_SARYAL] <> '' AND [Active] = 1 " &
                               "GROUP BY [BAY_SARYAL] " &
                               "ORDER BY MAX([BAY_ID]) DESC"
                    Case "DiamondBuy"
                        ' فواتير شراء الألماس - آخر X فاتورة من Bay_Diamond_mony
                        query = "SELECT TOP " & count & " [saryal] " &
                               "FROM [Bay_Diamond_mony] " &
                               "WHERE [saryal] IS NOT NULL AND [saryal] <> '' AND [Active] = 1 " &
                               "GROUP BY [saryal] " &
                               "ORDER BY MAX([bay_id]) DESC"
                    Case "DiamondSell"
                        ' فواتير بيع الألماس - آخر X فاتورة من dimon_bay
                        query = "SELECT TOP " & count & " [BAY_SARYAL] " &
                               "FROM [dimon_bay] " &
                               "WHERE [BAY_SARYAL] IS NOT NULL AND [BAY_SARYAL] <> '' AND [Item_Actv] = 1 " &
                               "GROUP BY [BAY_SARYAL] " &
                               "ORDER BY MAX([BAY_ID]) DESC"
                End Select
                
                Using cmd As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim invoiceNo As String = reader(0).ToString()
                            lstInvoices.Items.Add(invoiceNo)
                        End While
                    End Using
                End Using
            End Using
            
            If lstInvoices.Items.Count > 0 Then
                grpInvoiceList.Text = "📋 قائمة الفواتير (" & lstInvoices.Items.Count & ") - Invoices"
            Else
                grpInvoiceList.Text = "📋 قائمة الفواتير - Invoices"
            End If
            
        Catch ex As Exception
            MessageBox.Show("خطأ في تحميل القائمة: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    
    Private Sub lstInvoices_SelectedIndexChanged(sender As Object, e As EventArgs)
        If lstInvoices.SelectedItem IsNot Nothing Then
            txtOldInvoiceNo.Text = lstInvoices.SelectedItem.ToString()
            ' تحميل بيانات الفاتورة تلقائياً
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrWhiteSpace(txtOldInvoiceNo.Text) Then
            MessageBox.Show("اختر فاتورة من القائمة أو أدخل رقم الفاتورة" & vbCrLf & 
                          "Select invoice from list or enter invoice number", 
                          "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            Dim oldInvoiceNo As String = txtOldInvoiceNo.Text.Trim()
            Dim invoiceType As String = GetInvoiceType()

            LoadInvoiceDetails(oldInvoiceNo, invoiceType)
            
            ' تمكين حقل الرقم الجديد
            txtNewInvoiceNo.Enabled = True
            txtNewInvoiceNo.Focus()

        Catch ex As Exception
            MessageBox.Show("خطأ في البحث: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GetInvoiceType() As String
        If radDiamondBuy.Checked Then
            Return "DiamondBuy"
        ElseIf radDiamondSell.Checked Then
            Return "DiamondSell"
        ElseIf radBuyInvoice.Checked Then
            Return "GoldBuy"
        Else
            Return "GoldSell"
        End If
    End Function

    Private Sub LoadInvoiceDetails(invoiceNo As String, invoiceType As String)
        Dim details As New StringBuilder()
        details.AppendLine("═══════════════════════════════════════════════════════════")
        details.AppendLine("         تفاصيل الفاتورة - Invoice Details")
        details.AppendLine("═══════════════════════════════════════════════════════════")
        details.AppendLine("📝 رقم الفاتورة المطلوب: " & invoiceNo)
        Dim typeName As String = ""
        Select Case invoiceType
            Case "GoldBuy"
                typeName = "شراء ذهب - Gold Buy"
            Case "GoldSell"
                typeName = "بيع ذهب - Gold Sell"
            Case "DiamondBuy"
                typeName = "شراء ألماس - Diamond Buy"
            Case "DiamondSell"
                typeName = "بيع ألماس - Diamond Sell"
        End Select
        details.AppendLine("📝 نوع الفاتورة: " & typeName)
        details.AppendLine()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Select Case invoiceType
                    Case "GoldBuy"
                        LoadBuyInvoiceDetails(connection, invoiceNo, details)
                    Case "GoldSell"
                        LoadSellInvoiceDetails(connection, invoiceNo, details)
                    Case "DiamondBuy"
                        LoadDiamondBuyInvoiceDetails(connection, invoiceNo, details)
                    Case "DiamondSell"
                        LoadDiamondSellInvoiceDetails(connection, invoiceNo, details)
                End Select
            End Using
        Catch ex As Exception
            details.AppendLine()
            details.AppendLine("═══════════════════════════════════════════════════════════")
            details.AppendLine("❌❌❌ خطأ عام في تحميل البيانات ❌❌❌")
            details.AppendLine("═══════════════════════════════════════════════════════════")
            details.AppendLine("📝 نوع الخطأ: " & ex.GetType().Name)
            details.AppendLine("📝 رسالة الخطأ: " & ex.Message)
            details.AppendLine("📝 Stack Trace: " & ex.StackTrace)
        End Try

        txtInvoiceDetails.Text = details.ToString()

        ' تمكين الحفظ فقط إذا لم يكن هناك خطأ كبير
        If txtInvoiceDetails.Text.Contains("❌❌❌") Then
            btnSave.Enabled = False
            details.AppendLine()
            details.AppendLine("⚠️⚠️⚠️ لا يمكن الحفظ - يوجد أخطاء! ⚠️⚠️⚠️")
            txtInvoiceDetails.Text = details.ToString()
        ElseIf txtInvoiceDetails.Text.Contains("❌") Then
            btnSave.Enabled = False
        Else
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub LoadBuyInvoiceDetails(connection As SqlConnection, invoiceNo As String, details As StringBuilder)
        ' تعريف المتغيرات في البداية
        Dim cashierCode As String = ""
        Dim customerId As String = ""
        
        ' 1. بيانات الفاتورة من bay_goled_mony
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("📋 بيانات الفاتورة (bay_goled_mony):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        Try
            Dim bayQuery As String = "SELECT [bay_id], [saryal], [total_price], [cach], [kenet], " &
                                    "[date], [TIME_INV], [INV_Actv], [Cashier], [PayMethod] " &
                                    "FROM [bay_goled_mony] WHERE [saryal] = N'" & invoiceNo & "'"
            Using cmd As New SqlCommand(bayQuery, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        details.AppendLine("  ✅ تم تحميل بيانات الفاتورة بنجاح")
                        details.AppendLine("  • رقم الفاتورة: " & reader("saryal").ToString())
                        details.AppendLine("  • المبلغ الإجمالي: " & reader("total_price").ToString())
                        details.AppendLine("  • نقدي: " & reader("cach").ToString())
                        details.AppendLine("  • كي نت: " & reader("kenet").ToString())
                        details.AppendLine("  • التاريخ: " & reader("date").ToString())
                        details.AppendLine("  • الوقت: " & reader("TIME_INV").ToString())
                        cashierCode = If(IsDBNull(reader("Cashier")), "", reader("Cashier").ToString())
                        details.AppendLine("  • كود الكاشير: " & cashierCode)
                        details.AppendLine("  • الحالة: " & If(reader("INV_Actv").ToString() = "1", "نشطة ✓", "محذوفة ✗"))
                    Else
                        details.AppendLine("  ❌ الفاتورة غير موجودة في bay_goled_mony")
                        details.AppendLine("  ⚠️ سيتم الاستمرار في باقي الأجزاء...")
                    End If
                End Using
            End Using
        Catch ex As Exception
            details.AppendLine("  ❌❌❌ خطأ في الخطوة 1 (bay_goled_mony) ❌❌❌")
            details.AppendLine("  📝 الفاتورة: " & invoiceNo)
            details.AppendLine("  📝 نوع الخطأ: " & ex.GetType().Name)
            details.AppendLine("  📝 رسالة الخطأ: " & ex.Message)
            details.AppendLine("  📝 الاستعلام: SELECT * FROM bay_goled_mony WHERE saryal = N'" & invoiceNo & "'")
            details.AppendLine("  ⚠️ سيتم الاستمرار في باقي الأجزاء...")
        End Try

        details.AppendLine()

        ' 1.1 بيانات العميل (استعلام منفصل بدون JOIN لتجنب overflow)
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("👤 بيانات العميل (Customer):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        ' أولاً: نحصل على castomer_id من Buy_Gold
        Try
            Dim getCustomerIdQuery As String = "SELECT TOP 1 [castomer_id] FROM [Buy_Gold] " &
                                              "WHERE [inv_id] = N'" & invoiceNo & "' AND [INV_Actv] = 1"
            
            Using cmd As New SqlCommand(getCustomerIdQuery, connection)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    customerId = result.ToString()
                    details.AppendLine("  ✅ تم الحصول على كود العميل: " & customerId)
                End If
            End Using
        Catch ex As Exception
            details.AppendLine("  ❌❌❌ خطأ في الخطوة 1.1 (Get Customer ID) ❌❌❌")
            details.AppendLine("  📝 الفاتورة: " & invoiceNo)
            details.AppendLine("  📝 الخطأ: " & ex.Message)
            details.AppendLine("  📝 الاستعلام: SELECT castomer_id FROM Buy_Gold WHERE inv_id = N'" & invoiceNo & "'")
            details.AppendLine("  ⚠️ لن يتم عرض بيانات العميل")
        End Try
        
        ' ثانياً: نستعلم عن بيانات العميل بدون JOIN
        If Not String.IsNullOrEmpty(customerId) Then
            Try
                Dim customerQuery As String = "SELECT [CastomerCAIVELid], [CastomerNAme], [CastomerNameEn], " &
                                              "[CastomerTE], [CastomerADr], [CastomerNA] " &
                                              "FROM [CastomerDETELS] " &
                                              "WHERE [CastomerCAIVELid] = N'" & customerId & "'"
                
                Using cmd As New SqlCommand(customerQuery, connection)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            details.AppendLine("  ✅ تم تحميل بيانات العميل بنجاح")
                            details.AppendLine("  • الرقم المدني: " & reader("CastomerCAIVELid").ToString())
                            details.AppendLine("  • الاسم (عربي): " & If(IsDBNull(reader("CastomerNAme")), "N/A", reader("CastomerNAme").ToString()))
                            details.AppendLine("  • الاسم (English): " & If(IsDBNull(reader("CastomerNameEn")), "N/A", reader("CastomerNameEn").ToString()))
                            details.AppendLine("  • الهاتف: " & If(IsDBNull(reader("CastomerTE")), "N/A", reader("CastomerTE").ToString()))
                            details.AppendLine("  • العنوان: " & If(IsDBNull(reader("CastomerADr")), "N/A", reader("CastomerADr").ToString()))
                            details.AppendLine("  • الجنسية: " & If(IsDBNull(reader("CastomerNA")), "N/A", reader("CastomerNA").ToString()))
                        Else
                            details.AppendLine("  ⚠️ العميل رقم " & customerId & " غير موجود في CastomerDETELS")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                details.AppendLine("  ❌❌❌ خطأ في الخطوة 1.2 (بيانات العميل) ❌❌❌")
                details.AppendLine("  📝 الفاتورة: " & invoiceNo)
                details.AppendLine("  📝 كود العميل: " & customerId)
                details.AppendLine("  📝 نوع الخطأ: " & ex.GetType().Name)
                details.AppendLine("  📝 رسالة الخطأ: " & ex.Message)
                details.AppendLine("  📝 الاستعلام: SELECT * FROM CastomerDETELS WHERE CastomerCAIVELid = N'" & customerId & "'")
                details.AppendLine("  ⚠️ سيتم الاستمرار في باقي الأجزاء...")
            End Try
        Else
            details.AppendLine("  ⚠️ لا يوجد كود عميل في الفاتورة")
        End If

        details.AppendLine()

        ' 1.2 بيانات الكاشير
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("💼 بيانات الكاشير (Cashier):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        If Not String.IsNullOrEmpty(cashierCode) Then
            ' التحقق من أن كود الكاشير معقول (ليس رقم مدني)
            If cashierCode.Length > 5 Then
                details.AppendLine("  ⚠️⚠️⚠️ تحذير: كود الكاشير يبدو خاطئاً! ⚠️⚠️⚠️")
                details.AppendLine("  📝 كود الكاشير في الفاتورة: " & cashierCode)
                details.AppendLine("  📝 الطول: " & cashierCode.Length & " رقم (يبدو أنه رقم مدني!)")
                details.AppendLine("  💡 كود الكاشير العادي: 1-5 أرقام فقط (مثل: 1, 001, 12345)")
                details.AppendLine("  💡 الحل: صحح البيانات في bay_goled_mony.Cashier")
                details.AppendLine()
                details.AppendLine("  🔧 استعلام تصحيح مقترح:")
                details.AppendLine("     UPDATE bay_goled_mony SET Cashier = '1' WHERE saryal = N'" & invoiceNo & "'")
            Else
                Try
                    Dim cashierQuery As String = "SELECT svil_id, cacher_name, cacherID " &
                                                 "FROM cacher WHERE cacherID = N'" & cashierCode & "'"
                    
                    Using cmd As New SqlCommand(cashierQuery, connection)
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                details.AppendLine("  ✅ تم تحميل بيانات الكاشير بنجاح")
                                details.AppendLine("  • كود الكاشير: " & reader("svil_id").ToString())
                                details.AppendLine("  • اسم الكاشير: " & reader("cacher_name").ToString())
                                details.AppendLine("  • رقم الكاشير: " & reader("cacherID").ToString())
                            Else
                                details.AppendLine("  ⚠️ الكاشير رقم " & cashierCode & " غير موجود في قاعدة البيانات")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    details.AppendLine("  ❌❌❌ خطأ في الخطوة 1.3 (بيانات الكاشير) ❌❌❌")
                    details.AppendLine("  📝 الفاتورة: " & invoiceNo)
                    details.AppendLine("  📝 كود الكاشير: " & cashierCode)
                    details.AppendLine("  📝 نوع الخطأ: " & ex.GetType().Name)
                    details.AppendLine("  📝 رسالة الخطأ: " & ex.Message)
                    details.AppendLine("  📝 الاستعلام: SELECT * FROM cacher WHERE cacherID = N'" & cashierCode & "'")
                    details.AppendLine("  ⚠️ سيتم الاستمرار في باقي الأجزاء...")
                End Try
            End If
        Else
            details.AppendLine("  ⚠️ لا يوجد كود كاشير")
        End If

        details.AppendLine()

        ' 2. تفاصيل القطع من Buy_Gold
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("📦 تفاصيل القطع (Buy_Gold):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        Try
            Dim itemsQuery As String = "SELECT [B_gold_id], [castomer_id], [bay_val], [bay_mazan], " &
                                       "[bay_gram_price], [bay_total_price], [Item_Des], [INV_Actv] " &
                                       "FROM [Buy_Gold] WHERE [inv_id] = N'" & invoiceNo & "'"
            
            Dim itemCount As Integer = 0
            Using cmd As New SqlCommand(itemsQuery, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        itemCount += 1
                        details.AppendLine()
                        details.AppendLine("  القطعة #" & itemCount & ":")
                        details.AppendLine("    - كود العميل: " & reader("castomer_id").ToString())
                        details.AppendLine("    - العيار: " & reader("bay_val").ToString())
                        details.AppendLine("    - الوزن: " & reader("bay_mazan").ToString())
                        details.AppendLine("    - سعر الجرام: " & reader("bay_gram_price").ToString())
                        details.AppendLine("    - السعر الإجمالي: " & reader("bay_total_price").ToString())
                        details.AppendLine("    - الوصف: " & reader("Item_Des").ToString())
                        details.AppendLine("    - الحالة: " & If(reader("INV_Actv").ToString() = "1", "نشطة ✓", "محذوفة ✗"))
                    End While
                End Using
            End Using

            details.AppendLine()
            details.AppendLine("  ✅ تم تحميل تفاصيل القطع بنجاح")
            details.AppendLine("  📊 إجمالي القطع: " & itemCount)
            details.AppendLine()
        Catch ex As Exception
            details.AppendLine()
            details.AppendLine("  ❌❌❌ خطأ في الخطوة 2 (تفاصيل القطع من Buy_Gold) ❌❌❌")
            details.AppendLine("  📝 الفاتورة: " & invoiceNo)
            details.AppendLine("  📝 نوع الخطأ: " & ex.GetType().Name)
            details.AppendLine("  📝 رسالة الخطأ: " & ex.Message)
            details.AppendLine("  📝 الاستعلام: SELECT * FROM Buy_Gold WHERE inv_id = N'" & invoiceNo & "'")
            details.AppendLine("  ⚠️ لم يتم عرض تفاصيل القطع")
            details.AppendLine()
        End Try
    End Sub

    Private Sub LoadSellInvoiceDetails(connection As SqlConnection, invoiceNo As String, details As StringBuilder)
        ' 1. بيانات الفاتورة من BAY
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("📋 بيانات الفاتورة (BAY):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        Dim bayQuery As String = "SELECT [BAY_ID], [BAY_SARYAL], [TOTAL_mony], [CACH], [KENT], " &
                                "[Active], [PayMethod], [MaxID] " &
                                "FROM [BAY] WHERE [BAY_SARYAL] = N'" & invoiceNo & "'"
        
        Using cmd As New SqlCommand(bayQuery, connection)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    details.AppendLine("  • رقم الفاتورة: " & reader("BAY_SARYAL").ToString())
                    details.AppendLine("  • المبلغ الإجمالي: " & reader("TOTAL_mony").ToString())
                    details.AppendLine("  • نقدي: " & reader("CACH").ToString())
                    details.AppendLine("  • كي نت: " & reader("KENT").ToString())
                    details.AppendLine("  • طريقة الدفع: " & reader("PayMethod").ToString())
                    details.AppendLine("  • MaxID: " & If(IsDBNull(reader("MaxID")), "N/A", reader("MaxID").ToString()))
                    details.AppendLine("  • الحالة: " & If(reader("Active").ToString() = "True", "نشطة ✓", "محذوفة ✗"))
                Else
                    details.AppendLine("  ❌ الفاتورة غير موجودة في BAY")
                    Return
                End If
            End Using
        End Using

        details.AppendLine()

        ' 1.1 بيانات العميل (استعلام منفصل بدون JOIN لتجنب overflow)
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("👤 بيانات العميل (Customer):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        ' أولاً: نحصل على Castomerid من selInvoceDetels
        Dim sellCustomerId As String = ""
        Dim getCustomerIdQuery As String = "SELECT TOP 1 [Castomerid] FROM [selInvoceDetels] " &
                                          "WHERE [invoc_time] = N'" & invoiceNo & "' AND [Active] = 1"
        
        Using cmd As New SqlCommand(getCustomerIdQuery, connection)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                sellCustomerId = result.ToString()
            End If
        End Using
        
        ' ثانياً: نستعلم عن بيانات العميل بدون JOIN
        If Not String.IsNullOrEmpty(sellCustomerId) Then
            Dim customerQuery As String = "SELECT [CastomerCAIVELid], [CastomerNAme], [CastomerNameEn], " &
                                          "[CastomerTE], [CastomerADr], [CastomerNA] " &
                                          "FROM [CastomerDETELS] " &
                                          "WHERE [CastomerCAIVELid] = N'" & sellCustomerId & "'"
            
            Using cmd As New SqlCommand(customerQuery, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        details.AppendLine("  • الرقم المدني: " & reader("CastomerCAIVELid").ToString())
                        details.AppendLine("  • الاسم (عربي): " & If(IsDBNull(reader("CastomerNAme")), "N/A", reader("CastomerNAme").ToString()))
                        details.AppendLine("  • الاسم (English): " & If(IsDBNull(reader("CastomerNameEn")), "N/A", reader("CastomerNameEn").ToString()))
                        details.AppendLine("  • الهاتف: " & If(IsDBNull(reader("CastomerTE")), "N/A", reader("CastomerTE").ToString()))
                        details.AppendLine("  • العنوان: " & If(IsDBNull(reader("CastomerADr")), "N/A", reader("CastomerADr").ToString()))
                        details.AppendLine("  • الجنسية: " & If(IsDBNull(reader("CastomerNA")), "N/A", reader("CastomerNA").ToString()))
                    Else
                        details.AppendLine("  ⚠️ العميل رقم " & sellCustomerId & " غير موجود في CastomerDETELS")
                    End If
                End Using
            End Using
        Else
            details.AppendLine("  ⚠️ لا يوجد كود عميل في الفاتورة")
        End If

        details.AppendLine()

        ' 1.2 بيانات الكاشير (استعلام منفصل بدون JOIN لتجنب overflow)
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("💼 بيانات الكاشير (Cashier):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        ' أولاً: نحصل على cacher من selInvoceDetels
        Dim sellCacherId As String = ""
        Dim getCacherIdQuery As String = "SELECT TOP 1 [cacher] FROM [selInvoceDetels] " &
                                        "WHERE [invoc_time] = N'" & invoiceNo & "' AND [Active] = 1"
        
        Using cmd As New SqlCommand(getCacherIdQuery, connection)
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                sellCacherId = result.ToString()
            End If
        End Using
        
        ' ثانياً: نستعلم عن بيانات الكاشير بدون JOIN
        If Not String.IsNullOrEmpty(sellCacherId) Then
            Dim cashierQuery As String = "SELECT [svil_id], [cacher_name], [cacherID] " &
                                         "FROM [cacher] " &
                                         "WHERE [svil_id] = N'" & sellCacherId & "'"
            
            Using cmd As New SqlCommand(cashierQuery, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        details.AppendLine("  • كود الكاشير: " & reader("svil_id").ToString())
                        details.AppendLine("  • اسم الكاشير: " & reader("cacher_name").ToString())
                        details.AppendLine("  • رقم الكاشير: " & If(IsDBNull(reader("cacherID")), "N/A", reader("cacherID").ToString()))
                    Else
                        details.AppendLine("  ⚠️ الكاشير رقم " & sellCacherId & " غير موجود في cacher")
                    End If
                End Using
            End Using
        Else
            details.AppendLine("  ⚠️ لا يوجد كود كاشير في الفاتورة")
        End If

        details.AppendLine()

        ' 2. تفاصيل الأصناف من selInvoceDetels
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("📦 تفاصيل الأصناف (selInvoceDetels):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        Dim itemsQuery As String = "SELECT [ID], [itemID], [item_name], [item_totalPrice], " &
                                   "[item_gram], [item_GramPrice], [Active], [date] " &
                                   "FROM [selInvoceDetels] WHERE [invoc_time] = N'" & invoiceNo & "'"
        
        Dim itemCount As Integer = 0
        Using cmd As New SqlCommand(itemsQuery, connection)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    itemCount += 1
                    details.AppendLine()
                    details.AppendLine("  الصنف #" & itemCount & ":")
                    details.AppendLine("    - الباركود: " & reader("itemID").ToString())
                    details.AppendLine("    - الاسم: " & reader("item_name").ToString())
                    details.AppendLine("    - الوزن: " & reader("item_gram").ToString())
                    details.AppendLine("    - سعر الجرام: " & reader("item_GramPrice").ToString())
                    details.AppendLine("    - السعر الإجمالي: " & reader("item_totalPrice").ToString())
                    details.AppendLine("    - التاريخ: " & reader("date").ToString())
                    details.AppendLine("    - الحالة: " & If(reader("Active").ToString() = "1", "نشطة ✓", "محذوفة ✗"))
                End While
            End Using
        End Using

        details.AppendLine()
        details.AppendLine("  📊 إجمالي الأصناف: " & itemCount)
        details.AppendLine()
    End Sub

    Private Sub LoadDiamondBuyInvoiceDetails(connection As SqlConnection, invoiceNo As String, details As StringBuilder)
        ' 1. بيانات الفاتورة من Bay_Diamond_mony
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("📋 بيانات الفاتورة (Bay_Diamond_mony):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        Try
            Dim bayQuery As String = "SELECT [bay_id], [saryal], [total_price], [cach], [kenet], " &
                                    "[date], [Active], [PayMethod] " &
                                    "FROM [Bay_Diamond_mony] WHERE [saryal] = N'" & invoiceNo & "'"
            Using cmd As New SqlCommand(bayQuery, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        details.AppendLine("  ✅ تم تحميل بيانات الفاتورة بنجاح")
                        details.AppendLine("  • رقم الفاتورة: " & reader("saryal").ToString())
                        details.AppendLine("  • المبلغ الإجمالي: " & reader("total_price").ToString())
                        details.AppendLine("  • نقدي: " & reader("cach").ToString())
                        details.AppendLine("  • كي نت: " & reader("kenet").ToString())
                        details.AppendLine("  • التاريخ: " & If(IsDBNull(reader("date")), "N/A", reader("date").ToString()))
                        details.AppendLine("  • الحالة: " & If(reader("Active").ToString() = "1", "نشطة ✓", "محذوفة ✗"))
                    Else
                        details.AppendLine("  ❌ الفاتورة غير موجودة في Bay_Diamond_mony")
                    End If
                End Using
            End Using
        Catch ex As Exception
            details.AppendLine("  ❌❌❌ خطأ في تحميل بيانات الفاتورة ❌❌❌")
            details.AppendLine("  📝 الخطأ: " & ex.Message)
        End Try

        details.AppendLine()

        ' 2. بيانات العميل
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("👤 بيانات العميل (Customer):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        Dim customerId As String = ""
        Try
            Dim getCustomerIdQuery As String = "SELECT TOP 1 [castomer_id] FROM [Buy_Diamond] " &
                                              "WHERE [inv_id] = N'" & invoiceNo & "' AND [Active] = 1"
            
            Using cmd As New SqlCommand(getCustomerIdQuery, connection)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    customerId = result.ToString()
                End If
            End Using
        Catch ex As Exception
            details.AppendLine("  ❌ خطأ في الحصول على كود العميل: " & ex.Message)
        End Try
        
        If Not String.IsNullOrEmpty(customerId) Then
            Try
                Dim customerQuery As String = "SELECT [CastomerCAIVELid], [CastomerNAme], [CastomerNameEn], " &
                                              "[CastomerTE], [CastomerADr], [CastomerNA] " &
                                              "FROM [CastomerDETELS] " &
                                              "WHERE [CastomerCAIVELid] = N'" & customerId & "'"
                
                Using cmd As New SqlCommand(customerQuery, connection)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            details.AppendLine("  ✅ تم تحميل بيانات العميل بنجاح")
                            details.AppendLine("  • الرقم المدني: " & reader("CastomerCAIVELid").ToString())
                            details.AppendLine("  • الاسم (عربي): " & If(IsDBNull(reader("CastomerNAme")), "N/A", reader("CastomerNAme").ToString()))
                            details.AppendLine("  • الاسم (English): " & If(IsDBNull(reader("CastomerNameEn")), "N/A", reader("CastomerNameEn").ToString()))
                        Else
                            details.AppendLine("  ⚠️ العميل غير موجود")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                details.AppendLine("  ❌ خطأ في تحميل بيانات العميل: " & ex.Message)
            End Try
        Else
            details.AppendLine("  ⚠️ لا يوجد كود عميل في الفاتورة")
        End If

        details.AppendLine()

        ' 3. تفاصيل القطع من Buy_Diamond
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("📦 تفاصيل القطع (Buy_Diamond):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        Try
            Dim itemsQuery As String = "SELECT [B_Diamond_id], [castomer_id], [val_gold], [GOLD_mezan], " &
                                       "[bay_total_price], [DIMO_dep], [DIM_na9awa], [DIMO_mezan], [Active] " &
                                       "FROM [Buy_Diamond] WHERE [inv_id] = N'" & invoiceNo & "'"
            
            Dim itemCount As Integer = 0
            Using cmd As New SqlCommand(itemsQuery, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        itemCount += 1
                        details.AppendLine()
                        details.AppendLine("  القطعة #" & itemCount & ":")
                        details.AppendLine("    - الوصف: " & reader("DIMO_dep").ToString())
                        details.AppendLine("    - النقاوة: " & reader("DIM_na9awa").ToString())
                        details.AppendLine("    - الوزن: " & reader("DIMO_mezan").ToString())
                        details.AppendLine("    - السعر الإجمالي: " & reader("bay_total_price").ToString())
                        details.AppendLine("    - الحالة: " & If(reader("Active").ToString() = "1", "نشطة ✓", "محذوفة ✗"))
                    End While
                End Using
            End Using

            details.AppendLine()
            details.AppendLine("  ✅ تم تحميل تفاصيل القطع بنجاح")
            details.AppendLine("  📊 إجمالي القطع: " & itemCount)
            details.AppendLine()
        Catch ex As Exception
            details.AppendLine("  ❌❌❌ خطأ في تحميل تفاصيل القطع ❌❌❌")
            details.AppendLine("  📝 الخطأ: " & ex.Message)
            details.AppendLine()
        End Try
    End Sub

    Private Sub LoadDiamondSellInvoiceDetails(connection As SqlConnection, invoiceNo As String, details As StringBuilder)
        ' 1. بيانات الفاتورة من dimon_bay
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("📋 بيانات الفاتورة (dimon_bay):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        Try
            Dim bayQuery As String = "SELECT [BAY_ID], [BAY_SARYAL], [TOTAL_mony], [CACH], [KENT], " &
                                    "[Item_Actv], [PayMethod], [staytes] " &
                                    "FROM [dimon_bay] WHERE [BAY_SARYAL] = N'" & invoiceNo & "'"
            
            Using cmd As New SqlCommand(bayQuery, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        details.AppendLine("  ✅ تم تحميل بيانات الفاتورة بنجاح")
                        details.AppendLine("  • رقم الفاتورة: " & reader("BAY_SARYAL").ToString())
                        details.AppendLine("  • المبلغ الإجمالي: " & reader("TOTAL_mony").ToString())
                        details.AppendLine("  • نقدي: " & reader("CACH").ToString())
                        details.AppendLine("  • كي نت: " & reader("KENT").ToString())
                        details.AppendLine("  • الحالة: " & If(reader("Item_Actv").ToString() = "1", "نشطة ✓", "محذوفة ✗"))
                    Else
                        details.AppendLine("  ❌ الفاتورة غير موجودة في dimon_bay")
                    End If
                End Using
            End Using
        Catch ex As Exception
            details.AppendLine("  ❌❌❌ خطأ في تحميل بيانات الفاتورة ❌❌❌")
            details.AppendLine("  📝 الخطأ: " & ex.Message)
        End Try

        details.AppendLine()

        ' 2. بيانات العميل
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("👤 بيانات العميل (Customer):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        Dim customerId As String = ""
        Try
            Dim getCustomerIdQuery As String = "SELECT TOP 1 [castomr_id] FROM [dimon_invce] " &
                                              "WHERE [descont] = N'" & invoiceNo & "' AND [Item_Actv] = 1"
            
            Using cmd As New SqlCommand(getCustomerIdQuery, connection)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    customerId = result.ToString()
                End If
            End Using
        Catch ex As Exception
            details.AppendLine("  ❌ خطأ في الحصول على كود العميل: " & ex.Message)
        End Try
        
        If Not String.IsNullOrEmpty(customerId) Then
            Try
                Dim customerQuery As String = "SELECT [CastomerCAIVELid], [CastomerNAme], [CastomerNameEn], " &
                                              "[CastomerTE], [CastomerADr], [CastomerNA] " &
                                              "FROM [CastomerDETELS] " &
                                              "WHERE [CastomerCAIVELid] = N'" & customerId & "'"
                
                Using cmd As New SqlCommand(customerQuery, connection)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            details.AppendLine("  ✅ تم تحميل بيانات العميل بنجاح")
                            details.AppendLine("  • الرقم المدني: " & reader("CastomerCAIVELid").ToString())
                            details.AppendLine("  • الاسم (عربي): " & If(IsDBNull(reader("CastomerNAme")), "N/A", reader("CastomerNAme").ToString()))
                            details.AppendLine("  • الاسم (English): " & If(IsDBNull(reader("CastomerNameEn")), "N/A", reader("CastomerNameEn").ToString()))
                        Else
                            details.AppendLine("  ⚠️ العميل غير موجود")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                details.AppendLine("  ❌ خطأ في تحميل بيانات العميل: " & ex.Message)
            End Try
        Else
            details.AppendLine("  ⚠️ لا يوجد كود عميل في الفاتورة")
        End If

        details.AppendLine()

        ' 3. تفاصيل الأصناف من dimon_invce
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        details.AppendLine("📦 تفاصيل الأصناف (dimon_invce):")
        details.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        
        Try
            Dim itemsQuery As String = "SELECT [dim_inv_id], [dimo_id], [castomr_id], [total], " &
                                       "[DIMO_Type], [DIM_na9awa], [DIMO_mezan], [Item_Actv] " &
                                       "FROM [dimon_invce] WHERE [descont] = N'" & invoiceNo & "'"
            
            Dim itemCount As Integer = 0
            Using cmd As New SqlCommand(itemsQuery, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        itemCount += 1
                        details.AppendLine()
                        details.AppendLine("  الصنف #" & itemCount & ":")
                        details.AppendLine("    - النوع: " & reader("DIMO_Type").ToString())
                        details.AppendLine("    - النقاوة: " & reader("DIM_na9awa").ToString())
                        details.AppendLine("    - الوزن: " & reader("DIMO_mezan").ToString())
                        details.AppendLine("    - السعر الإجمالي: " & reader("total").ToString())
                        details.AppendLine("    - الحالة: " & If(reader("Item_Actv").ToString() = "1", "نشطة ✓", "محذوفة ✗"))
                    End While
                End Using
            End Using

            details.AppendLine()
            details.AppendLine("  ✅ تم تحميل تفاصيل الأصناف بنجاح")
            details.AppendLine("  📊 إجمالي الأصناف: " & itemCount)
            details.AppendLine()
        Catch ex As Exception
            details.AppendLine("  ❌❌❌ خطأ في تحميل تفاصيل الأصناف ❌❌❌")
            details.AppendLine("  📝 الخطأ: " & ex.Message)
            details.AppendLine()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtOldInvoiceNo.Text) Then
            MessageBox.Show("أدخل رقم الفاتورة القديم" & vbCrLf & "Enter Old Invoice Number", 
                          "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtNewInvoiceNo.Text) Then
            MessageBox.Show("أدخل رقم الفاتورة الجديد" & vbCrLf & "Enter New Invoice Number", 
                          "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim oldInvoiceNo As String = txtOldInvoiceNo.Text.Trim()
        Dim newInvoiceNo As String = txtNewInvoiceNo.Text.Trim()

        If oldInvoiceNo = newInvoiceNo Then
            MessageBox.Show("رقم الفاتورة القديم والجديد متطابقان!" & vbCrLf & 
                          "Old and New Invoice Numbers are the same!", 
                          "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 1. عرض التحذير
        Dim warningMsg As String = "⚠️⚠️⚠️ تحذير هام - Important Warning ⚠️⚠️⚠️" & vbCrLf & vbCrLf &
                                   "سيتم تغيير رقم الفاتورة من:" & vbCrLf &
                                   "Invoice Number will change from:" & vbCrLf & vbCrLf &
                                   "  القديم / Old: " & oldInvoiceNo & vbCrLf &
                                   "  الجديد / New: " & newInvoiceNo & vbCrLf & vbCrLf &
                                   "سيتم تحديث جميع الجداول المرتبطة تلقائياً" & vbCrLf &
                                   "All related tables will be updated automatically" & vbCrLf & vbCrLf &
                                   "هل أنت متأكد؟" & vbCrLf &
                                   "Are you sure?"

        Dim result As DialogResult = MessageBox.Show(warningMsg, "تأكيد التغيير - Confirm Change", 
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result <> DialogResult.Yes Then
            Return
        End If

        ' 2. طلب كلمة التأكيد
        Dim confirmWord As String = InputBox("لتأكيد العملية، أدخل كلمة التأكيد:" & vbCrLf & 
                                            "To confirm, enter the confirmation word:" & vbCrLf & vbCrLf &
                                            "EDIT", 
                                            "تأكيد - Confirmation")

        If confirmWord.Trim().ToUpper() <> "EDIT" Then
            MessageBox.Show("تم إلغاء العملية - كلمة التأكيد خاطئة" & vbCrLf & 
                          "Operation cancelled - Wrong confirmation word", 
                          "إلغاء", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' 3. تنفيذ التغيير
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim invoiceType As String = GetInvoiceType()
            
            ChangeInvoiceNumber(oldInvoiceNo, newInvoiceNo, invoiceType)

            MessageBox.Show("✅ تم تغيير رقم الفاتورة بنجاح!" & vbCrLf & 
                          "✅ Invoice Number Changed Successfully!" & vbCrLf & vbCrLf &
                          "من / From: " & oldInvoiceNo & vbCrLf &
                          "إلى / To: " & newInvoiceNo, 
                          "نجح", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' مسح الحقول
            txtOldInvoiceNo.Clear()
            txtNewInvoiceNo.Clear()
            txtInvoiceDetails.Clear()
            btnSave.Enabled = False

        Catch ex As Exception
            MessageBox.Show("❌ خطأ في تغيير رقم الفاتورة:" & vbCrLf & 
                          "❌ Error Changing Invoice Number:" & vbCrLf & vbCrLf &
                          ex.Message, 
                          "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ChangeInvoiceNumber(oldInvoiceNo As String, newInvoiceNo As String, invoiceType As String)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using transaction As SqlTransaction = connection.BeginTransaction()
                Try
                    Select Case invoiceType
                        Case "GoldBuy"
                            ' فاتورة شراء ذهب

                            Dim numericID As String = newInvoiceNo

                            ' 1. تحديث bay_goled_mony (رقم الفاتورة و ID_MAX)
                            Dim updateBayQuery As String = "UPDATE [bay_goled_mony] SET [saryal] = N'" & newInvoiceNo & "', " &
                                                          "[ID_MAX] = N'" & numericID & "' " &
                                                          "WHERE [saryal] = N'" & oldInvoiceNo & "'"
                            Using cmd As New SqlCommand(updateBayQuery, connection, transaction)
                                cmd.ExecuteNonQuery()
                            End Using

                            ' 2. تحديث Buy_Gold
                            Dim updateBuyQuery As String = "UPDATE [Buy_Gold] SET [inv_id] = N'" & newInvoiceNo & "' " &
                                                          "WHERE [inv_id] = N'" & oldInvoiceNo & "'"
                            Using cmd As New SqlCommand(updateBuyQuery, connection, transaction)
                                cmd.ExecuteNonQuery()
                            End Using

                        Case "GoldSell"
                            ' فاتورة بيع ذهب

                            Dim numericID As String = newInvoiceNo

                            ' 1. تحديث BAY (رقم الفاتورة و MaxID)
                            Dim updateBAYQuery As String = "UPDATE [BAY] SET [BAY_SARYAL] = N'" & newInvoiceNo & "', " &
                                                          "[MaxID] = N'" & numericID & "' " &
                                                          "WHERE [BAY_SARYAL] = N'" & oldInvoiceNo & "'"
                            Using cmd As New SqlCommand(updateBAYQuery, connection, transaction)
                                cmd.ExecuteNonQuery()
                            End Using

                            ' 2. تحديث selInvoceDetels
                            Dim updateSelQuery As String = "UPDATE [selInvoceDetels] SET [invoc_time] = N'" & newInvoiceNo & "' " &
                                                          "WHERE [invoc_time] = N'" & oldInvoiceNo & "'"
                            Using cmd As New SqlCommand(updateSelQuery, connection, transaction)
                                cmd.ExecuteNonQuery()
                            End Using

                        Case "DiamondBuy"
                            ' فاتورة شراء ألماس
                            ' 1. تحديث Bay_Diamond_mony
                            Dim updateDiamondBayQuery As String = "UPDATE [Bay_Diamond_mony] SET [saryal] = N'" & newInvoiceNo & "' " &
                                                                  "WHERE [saryal] = N'" & oldInvoiceNo & "'"
                            Using cmd As New SqlCommand(updateDiamondBayQuery, connection, transaction)
                                cmd.ExecuteNonQuery()
                            End Using

                            ' 2. تحديث Buy_Diamond
                            Dim updateDiamondBuyQuery As String = "UPDATE [Buy_Diamond] SET [inv_id] = N'" & newInvoiceNo & "' " &
                                                                  "WHERE [inv_id] = N'" & oldInvoiceNo & "'"
                            Using cmd As New SqlCommand(updateDiamondBuyQuery, connection, transaction)
                                cmd.ExecuteNonQuery()
                            End Using

                        Case "DiamondSell"
                            ' فاتورة بيع ألماس
                            Dim numericID As String = newInvoiceNo

                            ' 1. تحديث dimon_bay (رقم الفاتورة و MaxID)
                            Dim updateDiamondBayQuery As String = "UPDATE [dimon_bay] SET [BAY_SARYAL] = N'" & newInvoiceNo & "', " &
                                                                  "[MaxID] = N'" & numericID & "' " &
                                                                  "WHERE [BAY_SARYAL] = N'" & oldInvoiceNo & "'"
                            Using cmd As New SqlCommand(updateDiamondBayQuery, connection, transaction)
                                cmd.ExecuteNonQuery()
                            End Using

                            ' 2. تحديث dimon_invce (descont)
                            Dim updateDiamondInvQuery As String = "UPDATE [dimon_invce] SET [descont] = N'" & newInvoiceNo & "' " &
                                                                   "WHERE [descont] = N'" & oldInvoiceNo & "'"
                            Using cmd As New SqlCommand(updateDiamondInvQuery, connection, transaction)
                                cmd.ExecuteNonQuery()
                            End Using
                    End Select

                    ' Commit Transaction
                    transaction.Commit()

                Catch ex As Exception
                    ' Rollback on error
                    transaction.Rollback()
                    Throw New Exception("فشل تحديث قاعدة البيانات: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOldInvoiceNo.Clear()
        txtNewInvoiceNo.Clear()
        txtInvoiceDetails.Clear()
        btnSave.Enabled = False
        lstInvoices.ClearSelected()
        txtNewInvoiceNo.Enabled = False
    End Sub

End Class

