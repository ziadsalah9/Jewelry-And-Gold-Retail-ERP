Imports System
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Text
Imports System.Collections.Generic

Public Class FormEditability

    Private results As New StringBuilder()

    Public Sub New(connectionString As String, invoiceId As String, isBuyInvoice As Boolean)
        InitializeComponent()
        CheckEditability(connectionString, invoiceId, isBuyInvoice)
    End Sub

    Private Sub CheckEditability(connectionString As String, invoiceId As String, isBuyInvoice As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            results.Clear()
            results.AppendLine("═══════════════════════════════════════════════════════════")
            results.AppendLine("         التحقق من إمكانية تعديل الفاتورة رقم: " & invoiceId)
            results.AppendLine("═══════════════════════════════════════════════════════════")
            results.AppendLine()

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim canEdit As Boolean = True
                Dim issues As New List(Of String)()
                Dim warnings As New List(Of String)()

                If isBuyInvoice Then
                    CheckBuyInvoiceEditability(connection, invoiceId, canEdit, issues, warnings)
                Else
                    CheckSellInvoiceEditability(connection, invoiceId, canEdit, issues, warnings)
                End If

                results.AppendLine()
                results.AppendLine("═══════════════════════════════════════════════════════════")
                results.AppendLine("                      النتيجة النهائية")
                results.AppendLine("═══════════════════════════════════════════════════════════")
                results.AppendLine()

                If canEdit AndAlso issues.Count = 0 Then
                    results.AppendLine("✅ يمكن تعديل الفاتورة - جميع الشروط متحققة")
                    txtResults.ForeColor = Color.Green
                Else
                    results.AppendLine("❌ لا يمكن تعديل الفاتورة - توجد مشاكل:")
                    results.AppendLine()
                    For Each issue As String In issues
                        results.AppendLine("  • " & issue)
                    Next
                    txtResults.ForeColor = Color.Red
                End If

                If warnings.Count > 0 Then
                    results.AppendLine()
                    results.AppendLine("⚠️ تحذيرات:")
                    For Each warning As String In warnings
                        results.AppendLine("  • " & warning)
                    Next
                End If

                txtResults.Text = results.ToString()

            End Using

        Catch ex As Exception
            txtResults.Text = "خطأ في التحقق: " & ex.Message
            txtResults.ForeColor = Color.Red
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CheckBuyInvoiceEditability(connection As SqlConnection, invoiceId As String, ByRef canEdit As Boolean, issues As List(Of String), warnings As List(Of String))
        results.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        results.AppendLine("        التحقق من فاتورة شراء الذهب رقم: " & invoiceId)
        results.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        results.AppendLine()

        ' 1. التحقق من وجود الفاتورة ونشاطها (نفس طريقة البرنامج الأصلي)
        results.AppendLine("1. التحقق من وجود الفاتورة...")
        Try
            ' البرنامج الأصلي: SELECT * FROM Buy_Gold WHERE inv_id = N'...' AND Inv_Actv = '1'
            Dim buyGoldQuery As String = "SELECT [B_gold_id], [castomer_id], [bay_val], [bay_mazan], [bay_gram_price], [bay_total_price], [inv_id], [Item_Des] " &
                                         "FROM [Buy_Gold] WHERE [inv_id] = N'" & invoiceId & "' AND [Inv_Actv] = '1'"
            Using cmd As New SqlCommand(buyGoldQuery, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    Dim rowCount As Integer = 0
                    While reader.Read()
                        rowCount += 1
                    End While
                    
                    If rowCount = 0 Then
                        results.AppendLine("   ❌ الفاتورة غير موجودة أو محذوفة")
                        issues.Add("الفاتورة غير موجودة في Buy_Gold أو INV_Actv = 0")
                        canEdit = False
                    Else
                        results.AppendLine("   ✅ الفاتورة موجودة ونشطة")
                        results.AppendLine("      عدد القطع: " & rowCount)
                    End If
                End Using
            End Using
        Catch ex As Exception
            results.AppendLine("   ❌❌❌ خطأ في الخطوة 1 (Buy_Gold) ❌❌❌")
            results.AppendLine("   📝 الفاتورة: " & invoiceId)
            results.AppendLine("   📝 نوع الخطأ: " & ex.GetType().Name)
            results.AppendLine("   📝 رسالة الخطأ: " & ex.Message)
            results.AppendLine("   ⚠️ سيتم الاستمرار في باقي الأجزاء...")
            issues.Add("خطأ في الوصول لجدول Buy_Gold: " & ex.Message)
            canEdit = False
        End Try

        ' 2. التحقق من bay_goled_mony (نفس طريقة البرنامج الأصلي)
        results.AppendLine()
        results.AppendLine("2. التحقق من سجل الدفع (bay_goled_mony)...")
        Try
            ' البرنامج الأصلي: SELECT * FROM bay_goled_mony WHERE saryal = N'...' AND Inv_Actv = '1'
            Dim bayQuery As String = "SELECT [bay_id], [cach], [kenet], [arabik], [English], [date], [TIME_INV], [Cashier], [INV_Actv] " &
                                    "FROM [bay_goled_mony] WHERE [saryal] = N'" & invoiceId & "'"
            Using cmd As New SqlCommand(bayQuery, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim invActv As String = reader("INV_Actv").ToString()
                        Dim cashier As String = If(IsDBNull(reader("Cashier")), "", reader("Cashier").ToString())
                        
                        If invActv = "0" Then
                            results.AppendLine("   ❌ سجل الدفع محذوف (INV_Actv = 0)")
                            issues.Add("سجل الدفع محذوف (INV_Actv = 0) في bay_goled_mony")
                            canEdit = False
                        Else
                            results.AppendLine("   ✅ سجل الدفع موجود ونشط (INV_Actv = 1)")
                        End If
                        
                        ' عرض كود الكاشير مع تحذير إذا كان كبيراً
                        If Not String.IsNullOrEmpty(cashier) Then
                            If cashier.Length > 5 Then
                                results.AppendLine("   ⚠️ كود الكاشير يبدو خاطئاً: " & cashier & " (طول: " & cashier.Length & ")")
                                warnings.Add("كود الكاشير يبدو أنه رقم مدني: " & cashier)
                            Else
                                results.AppendLine("   📝 كود الكاشير: " & cashier)
                            End If
                        End If
                    Else
                        results.AppendLine("   ❌ لا يوجد سجل دفع للفاتورة")
                        issues.Add("سجل الدفع غير موجود في bay_goled_mony")
                        canEdit = False
                    End If
                End Using
            End Using
        Catch ex As Exception
            results.AppendLine("   ❌❌❌ خطأ في الخطوة 2 (bay_goled_mony) ❌❌❌")
            results.AppendLine("   📝 الفاتورة: " & invoiceId)
            results.AppendLine("   📝 نوع الخطأ: " & ex.GetType().Name)
            results.AppendLine("   📝 رسالة الخطأ: " & ex.Message)
            results.AppendLine("   ⚠️ سيتم الاستمرار في باقي الأجزاء...")
            issues.Add("خطأ في الوصول لجدول bay_goled_mony: " & ex.Message)
            canEdit = False
        End Try

        ' 3. التحقق من إمكانية التحميل (البرنامج الأصلي لا يستخدم View!)
        results.AppendLine()
        results.AppendLine("3. التحقق من إمكانية التحميل في شاشة التعديل...")
        results.AppendLine("   📝 ملاحظة: البرنامج الأصلي (GoldBuyEditRemove) يستعلم مباشرة من الجداول")
        results.AppendLine("   📝 لا يستخدم View ReportGoldBuyInvoice في التحميل")
        ' التحقق البسيط: إذا كانت الفاتورة موجودة ونشطة في Buy_Gold، يمكن تحميلها
        If canEdit Then
            results.AppendLine("   ✅ الفاتورة قابلة للتحميل في شاشة التعديل")
        End If

        ' 4. التحقق من بيانات العميل (استعلامات منفصلة بدون JOIN)
        results.AppendLine()
        results.AppendLine("4. التحقق من بيانات العميل...")
        Try
            ' أولاً: نحصل على castomer_id من Buy_Gold
            Dim customerId As String = ""
            Dim getCustomerIdQuery As String = "SELECT TOP 1 [castomer_id] FROM [Buy_Gold] " &
                                              "WHERE [inv_id] = N'" & invoiceId & "' AND [INV_Actv] = 1"
            
            Using cmd As New SqlCommand(getCustomerIdQuery, connection)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    customerId = result.ToString()
                End If
            End Using
            
            If String.IsNullOrEmpty(customerId) Then
                results.AppendLine("   ⚠️ كود العميل فارغ")
                warnings.Add("كود العميل فارغ - يجب إدخاله عند التعديل")
            Else
                results.AppendLine("   📝 كود العميل: " & customerId)
                
                ' التحقق من طول كود العميل
                If customerId.Length > 5 And customerId.Length <= 12 Then
                    results.AppendLine("   💡 يبدو أنه رقم مدني (طول: " & customerId.Length & ")")
                End If
                
                ' ثانياً: نستعلم عن بيانات العميل بدون JOIN
                Dim customerQuery As String = "SELECT [CastomerCAIVELid], [CastomerNAme] " &
                                              "FROM [CastomerDETELS] " &
                                              "WHERE [CastomerCAIVELid] = N'" & customerId & "'"
                
                Using cmd2 As New SqlCommand(customerQuery, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        If reader.Read() Then
                            results.AppendLine("   ✅ العميل: " & reader("CastomerNAme").ToString() & " (" & customerId & ")")
                        Else
                            results.AppendLine("   ⚠️ العميل رقم " & customerId & " غير موجود في CastomerDETELS")
                            warnings.Add("العميل غير موجود - يجب إضافته قبل التعديل")
                        End If
                    End Using
                End Using
            End If
        Catch ex As Exception
            results.AppendLine("   ❌❌❌ خطأ في الخطوة 4 (بيانات العميل) ❌❌❌")
            results.AppendLine("   📝 الفاتورة: " & invoiceId)
            results.AppendLine("   📝 نوع الخطأ: " & ex.GetType().Name)
            results.AppendLine("   📝 رسالة الخطأ: " & ex.Message)
            results.AppendLine("   ⚠️ سيتم الاستمرار في باقي الأجزاء...")
            warnings.Add("خطأ في الوصول لبيانات العميل: " & ex.Message)
        End Try

        ' 5. التحقق من الكاشير (استعلامات منفصلة بدون JOIN)
        results.AppendLine()
        results.AppendLine("5. التحقق من الكاشير...")
        Try
            ' أولاً: نحصل على Cashier من bay_goled_mony
            Dim cashierId As String = ""
            Dim getCashierQuery As String = "SELECT [Cashier] FROM [bay_goled_mony] WHERE [saryal] = N'" & invoiceId & "'"
            
            Using cmd As New SqlCommand(getCashierQuery, connection)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    cashierId = result.ToString()
                End If
            End Using
            
            If String.IsNullOrEmpty(cashierId) Then
                results.AppendLine("   ⚠️ الكاشير غير محدد")
                warnings.Add("الكاشير غير محدد")
            Else
                results.AppendLine("   📝 كود الكاشير: " & cashierId)
                
                ' التحقق من طول كود الكاشير
                If cashierId.Length > 5 Then
                    results.AppendLine("   ⚠️⚠️⚠️ تحذير: كود الكاشير يبدو خاطئاً!")
                    results.AppendLine("   📝 الطول: " & cashierId.Length & " رقم (يبدو أنه رقم مدني!)")
                    results.AppendLine("   💡 كود الكاشير العادي: 1-5 أرقام فقط")
                    results.AppendLine("   🔧 الحل المقترح: UPDATE bay_goled_mony SET Cashier = '1' WHERE saryal = N'" & invoiceId & "'")
                    warnings.Add("كود الكاشير خاطئ (رقم مدني؟): " & cashierId)
                Else
                    ' ثانياً: نستعلم عن بيانات الكاشير بدون JOIN
                    Dim cacherQuery As String = "SELECT [cacher_name] FROM [cacher] WHERE [cacherID] = N'" & cashierId & "'"
                    
                    Using cmd2 As New SqlCommand(cacherQuery, connection)
                        Dim cacherName As Object = cmd2.ExecuteScalar()
                        If IsDBNull(cacherName) OrElse cacherName Is Nothing Then
                            results.AppendLine("   ⚠️ الكاشير رقم " & cashierId & " غير موجود في جدول الكاشيرات")
                            warnings.Add("الكاشير غير موجود")
                        Else
                            results.AppendLine("   ✅ الكاشير: " & cacherName.ToString())
                        End If
                    End Using
                End If
            End If
        Catch ex As Exception
            results.AppendLine("   ❌❌❌ خطأ في الخطوة 5 (بيانات الكاشير) ❌❌❌")
            results.AppendLine("   📝 الفاتورة: " & invoiceId)
            results.AppendLine("   📝 نوع الخطأ: " & ex.GetType().Name)
            results.AppendLine("   📝 رسالة الخطأ: " & ex.Message)
            results.AppendLine("   ⚠️ سيتم الاستمرار في باقي الأجزاء...")
            warnings.Add("خطأ في الوصول لبيانات الكاشير: " & ex.Message)
        End Try

        ' 6. التحقق من صحة المبالغ
        results.AppendLine()
        results.AppendLine("6. التحقق من صحة حسابات الفاتورة...")
        Try
            Dim sumQuery As String = "SELECT SUM(bay_total_price) as TotalItems FROM Buy_Gold WHERE inv_id = N'" & invoiceId & "' AND INV_Actv = 1"
            Using cmd As New SqlCommand(sumQuery, connection)
                Dim totalItems As Object = cmd.ExecuteScalar()
                If Not IsDBNull(totalItems) AndAlso Not IsNothing(totalItems) Then
                    results.AppendLine("   • مجموع أسعار القطع: " & totalItems.ToString())
                    Dim bayTotal As Decimal = 0
                    Dim bayTotalQuery As String = "SELECT total_price FROM bay_goled_mony WHERE saryal = N'" & invoiceId & "'"
                    Using cmd2 As New SqlCommand(bayTotalQuery, connection)
                        Dim result As Object = cmd2.ExecuteScalar()
                        If Not IsDBNull(result) Then bayTotal = Val(result.ToString())
                    End Using
                    
                    If Math.Abs(Val(totalItems.ToString()) - bayTotal) > 0.01 Then
                        warnings.Add("مجموع أسعار القطع (" & totalItems.ToString() & ") لا يساوي المبلغ في bay_goled_mony (" & bayTotal & ")")
                    Else
                        results.AppendLine("   ✅ المبالغ متطابقة بين Buy_Gold و bay_goled_mony")
                    End If
                End If
            End Using
        Catch ex As Exception
            results.AppendLine("   ❌❌❌ خطأ في الخطوة 6 (حسابات الفاتورة) ❌❌❌")
            results.AppendLine("   📝 الفاتورة: " & invoiceId)
            results.AppendLine("   📝 نوع الخطأ: " & ex.GetType().Name)
            results.AppendLine("   📝 رسالة الخطأ: " & ex.Message)
            results.AppendLine("   ⚠️ سيتم الاستمرار في باقي الأجزاء...")
        End Try

        ' 7. التحقق من المبالغ المدفوعة
        results.AppendLine()
        results.AppendLine("7. التحقق من المبالغ المدفوعة...")
        Try
            Dim paymentQuery As String = "SELECT total_price, cach, kenet FROM bay_goled_mony WHERE saryal = N'" & invoiceId & "'"
            Using cmd As New SqlCommand(paymentQuery, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim totalPrice As Decimal = Val(reader("total_price").ToString())
                        Dim cash As Decimal = Val(reader("cach").ToString())
                        Dim knet As Decimal = Val(reader("kenet").ToString())
                        Dim totalPaid As Decimal = cash + knet
                        
                        results.AppendLine("   • المطلوب: " & totalPrice.ToString())
                        results.AppendLine("   • المدفوع: " & totalPaid.ToString() & " (نقدي: " & cash & " + كي نت: " & knet & ")")
                        
                        If cash < 0 OrElse knet < 0 Then
                            issues.Add("يوجد مبالغ سالبة في الفاتورة")
                            results.AppendLine("   ❌ يوجد مبالغ سالبة!")
                        End If
                        
                        If Math.Abs(totalPaid - totalPrice) > 0.01 Then
                            warnings.Add("المبلغ المدفوع (" & totalPaid & ") لا يساوي المبلغ المطلوب (" & totalPrice & ")")
                            results.AppendLine("   ⚠️ المبالغ غير متطابقة - الفرق: " & Math.Abs(totalPaid - totalPrice))
                        Else
                            results.AppendLine("   ✅ المبالغ متطابقة")
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            results.AppendLine("   ❌❌❌ خطأ في الخطوة 7 (المبالغ المدفوعة) ❌❌❌")
            results.AppendLine("   📝 الفاتورة: " & invoiceId)
            results.AppendLine("   📝 نوع الخطأ: " & ex.GetType().Name)
            results.AppendLine("   📝 رسالة الخطأ: " & ex.Message)
            results.AppendLine("   ⚠️ سيتم الاستمرار في باقي الأجزاء...")
        End Try

        ' 8. معلومات إضافية
        results.AppendLine()
        results.AppendLine("8. معلومات إضافية...")
        Try
            Dim detailsQuery As String = "SELECT date, TIME_INV FROM bay_goled_mony WHERE saryal = N'" & invoiceId & "'"
            Using cmd As New SqlCommand(detailsQuery, connection)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        results.AppendLine("   • التاريخ: " & reader("date").ToString())
                        results.AppendLine("   • الوقت: " & reader("TIME_INV").ToString())
                    End If
                End Using
            End Using
        Catch ex As Exception
            results.AppendLine("   ❌ خطأ في الحصول على المعلومات الإضافية: " & ex.Message)
        End Try
    End Sub

    Private Sub CheckSellInvoiceEditability(connection As SqlConnection, invoiceId As String, ByRef canEdit As Boolean, issues As List(Of String), warnings As List(Of String))
        results.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        results.AppendLine("         التحقق من فاتورة بيع الذهب رقم: " & invoiceId)
        results.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
        results.AppendLine()

        ' 1. التحقق من وجود الفاتورة ونشاطها في BAY
        results.AppendLine("1. التحقق من سجل الفاتورة (BAY)...")
        Dim bayQuery As String = "SELECT Active, TOTAL_mony, CACH, KENT FROM BAY WHERE BAY_SARYAL = N'" & invoiceId & "'"
        Using cmd As New SqlCommand(bayQuery, connection)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim active As Object = reader("Active")
                    If active.ToString() = "0" Then
                        results.AppendLine("   ❌ الفاتورة محذوفة (Active = 0)")
                        issues.Add("الفاتورة محذوفة (Active = 0) في BAY - يجب تفعيلها")
                        canEdit = False
                    Else
                        results.AppendLine("   ✅ سجل الفاتورة موجود ونشط (Active = 1)")
                        results.AppendLine("      المبلغ الإجمالي: " & reader("TOTAL_mony").ToString())
                    End If
                Else
                    results.AppendLine("   ❌ الفاتورة غير موجودة في جدول BAY")
                    issues.Add("الفاتورة غير موجودة في BAY")
                    canEdit = False
                End If
            End Using
        End Using

        ' 2. التحقق من تفاصيل الفاتورة في selInvoceDetels
        results.AppendLine()
        results.AppendLine("2. التحقق من تفاصيل الأصناف (selInvoceDetels)...")
        Dim detailsQuery As String = "SELECT COUNT(*), SUM(CASE WHEN Active = 1 THEN 1 ELSE 0 END) as ActiveCount FROM selInvoceDetels WHERE invoc_time = N'" & invoiceId & "'"
        Using cmd As New SqlCommand(detailsQuery, connection)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim totalCount As Integer = Convert.ToInt32(reader(0))
                    Dim activeCount As Integer = If(IsDBNull(reader("ActiveCount")), 0, Convert.ToInt32(reader("ActiveCount")))
                    
                    If totalCount = 0 Then
                        results.AppendLine("   ❌ لا توجد أصناف في الفاتورة")
                        issues.Add("الفاتورة فارغة - لا توجد أصناف")
                        canEdit = False
                    ElseIf activeCount = 0 Then
                        results.AppendLine("   ❌ جميع الأصناف محذوفة (Active = 0)")
                        results.AppendLine("      إجمالي الأصناف: " & totalCount & " | النشطة: " & activeCount)
                        issues.Add("جميع الأصناف محذوفة (Active = 0)")
                        canEdit = False
                    Else
                        results.AppendLine("   ✅ الأصناف موجودة ونشطة")
                        results.AppendLine("      إجمالي الأصناف: " & totalCount & " | النشطة: " & activeCount)
                        If activeCount < totalCount Then
                            warnings.Add("يوجد " & (totalCount - activeCount) & " صنف محذوف")
                        End If
                    End If
                End If
            End Using
        End Using

        ' 3. التحقق من إمكانية التحميل من View
        results.AppendLine()
        results.AppendLine("3. التحقق من إمكانية التحميل في شاشة التعديل...")
        Dim viewQuery As String = "SELECT COUNT(*) FROM [BAY] bay INNER JOIN [selInvoceDetels] sid ON bay.BAY_SARYAL = sid.invoc_time " &
                                  "WHERE bay.BAY_SARYAL = N'" & invoiceId & "' AND bay.Active = 1 AND sid.Active = 1"
        Using cmd As New SqlCommand(viewQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                results.AppendLine("   ❌ لا يمكن تحميل الفاتورة في شاشة التعديل")
                results.AppendLine("      السبب: BAY.Active != 1 أو selInvoceDetels.Active != 1")
                issues.Add("الفاتورة غير قابلة للتحميل")
                canEdit = False
            Else
                results.AppendLine("   ✅ الفاتورة قابلة للتحميل (" & count & " سجل)")
            End If
        End Using

        ' 4. التحقق من بيانات العميل
        results.AppendLine()
        results.AppendLine("4. التحقق من بيانات العميل...")
        Dim customerQuery As String = "SELECT DISTINCT sid.Castomerid, c.CastomerNAme FROM selInvoceDetels sid " &
                                      "LEFT JOIN CastomerDETELS c ON sid.Castomerid = c.CastomerCAIVELid " &
                                      "WHERE sid.invoc_time = N'" & invoiceId & "' AND sid.Active = 1"
        Using cmd As New SqlCommand(customerQuery, connection)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim customerId As Object = reader("Castomerid")
                    Dim customerName As Object = reader("CastomerNAme")
                    
                    If IsDBNull(customerId) OrElse String.IsNullOrEmpty(customerId.ToString()) Then
                        results.AppendLine("   ⚠️ كود العميل فارغ")
                        warnings.Add("كود العميل فارغ")
                    ElseIf IsDBNull(customerName) Then
                        results.AppendLine("   ⚠️ العميل رقم " & customerId.ToString() & " غير موجود في CastomerDETELS")
                        warnings.Add("العميل غير موجود في قاعدة البيانات")
                    Else
                        results.AppendLine("   ✅ العميل: " & customerName.ToString() & " (" & customerId.ToString() & ")")
                    End If
                Else
                    results.AppendLine("   ⚠️ لا توجد بيانات للعميل")
                End If
            End Using
        End Using

        ' 5. التحقق من الكاشير
        results.AppendLine()
        results.AppendLine("5. التحقق من الكاشير...")
        Dim cacherQuery As String = "SELECT DISTINCT sid.cacher, c.cacher_name FROM selInvoceDetels sid " &
                                    "LEFT JOIN cacher c ON sid.cacher = c.svil_id " &
                                    "WHERE sid.invoc_time = N'" & invoiceId & "' AND sid.Active = 1"
        Using cmd As New SqlCommand(cacherQuery, connection)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim cacherId As Object = reader("cacher")
                    Dim cacherName As Object = reader("cacher_name")
                    
                    If IsDBNull(cacherId) Then
                        results.AppendLine("   ⚠️ الكاشير غير محدد")
                        warnings.Add("الكاشير غير محدد")
                    ElseIf IsDBNull(cacherName) Then
                        results.AppendLine("   ⚠️ الكاشير رقم " & cacherId.ToString() & " غير موجود")
                        warnings.Add("الكاشير غير موجود في جدول الكاشيرات")
                    Else
                        results.AppendLine("   ✅ الكاشير: " & cacherName.ToString())
                    End If
                End If
            End Using
        End Using

        ' 6. التحقق من FO_min (الأصناف المباعة)
        results.AppendLine()
        results.AppendLine("6. التحقق من الأصناف في المخزون (FO_min)...")
        Dim itemsQuery As String = "SELECT sid.itemID, fm.FO_name, fm.Item_Actv FROM selInvoceDetels sid " &
                                   "LEFT JOIN FO_min fm ON sid.itemID = fm.BarCode " &
                                   "WHERE sid.invoc_time = N'" & invoiceId & "' AND sid.Active = 1"
        Using cmd As New SqlCommand(itemsQuery, connection)
            Dim missingItems As Integer = 0
            Dim deletedItems As Integer = 0
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim itemId As String = reader("itemID").ToString()
                    Dim itemName As Object = reader("FO_name")
                    Dim itemActv As Object = reader("Item_Actv")
                    
                    If IsDBNull(itemName) Then
                        results.AppendLine("   ⚠️ الصنف " & itemId & " غير موجود في FO_min")
                        missingItems += 1
                    ElseIf Not IsDBNull(itemActv) AndAlso itemActv.ToString() = "0" Then
                        results.AppendLine("   ⚠️ الصنف " & itemId & " محذوف من المخزون (Item_Actv = 0)")
                        deletedItems += 1
                    End If
                End While
            End Using
            If missingItems > 0 Then
                warnings.Add(missingItems & " صنف غير موجود في FO_min")
            End If
            If deletedItems > 0 Then
                warnings.Add(deletedItems & " صنف محذوف من المخزون")
            End If
            If missingItems = 0 AndAlso deletedItems = 0 Then
                results.AppendLine("   ✅ جميع الأصناف موجودة ونشطة في FO_min")
            End If
        End Using

        ' 6.2 التحقق من الأصناف المباعة مسبقاً (حسب Settings)
        results.AppendLine()
        results.AppendLine("6.2. التحقق من الأصناف المباعة مسبقاً...")
        Dim settingsCheck As String = "SELECT SET_INVARCHR151 FROM Settings"
        Dim itemSoldCheck As String = "0"
        Using cmd As New SqlCommand(settingsCheck, connection)
            Dim result As Object = cmd.ExecuteScalar()
            If Not IsDBNull(result) Then itemSoldCheck = result.ToString()
        End Using
        
        If itemSoldCheck = "1" Then
            results.AppendLine("   • وضع منع البيع المزدوج: مُفعّل (SET_INVARCHR151 = 1)")
            Dim duplicateQuery As String = "SELECT sid1.itemID, COUNT(*) as SoldCount FROM selInvoceDetels sid1 " &
                                          "WHERE sid1.itemID IN (SELECT itemID FROM selInvoceDetels WHERE invoc_time = N'" & invoiceId & "' AND Active = 1) " &
                                          "AND sid1.Active = 1 " &
                                          "GROUP BY sid1.itemID HAVING COUNT(*) > 1"
            Using cmd As New SqlCommand(duplicateQuery, connection)
                Dim duplicateCount As Integer = 0
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        results.AppendLine("   ⚠️ الصنف " & reader("itemID").ToString() & " مباع " & reader("SoldCount").ToString() & " مرات")
                        duplicateCount += 1
                    End While
                End Using
                If duplicateCount > 0 Then
                    warnings.Add(duplicateCount & " صنف مباع أكثر من مرة - قد يسبب مشكلة")
                Else
                    results.AppendLine("   ✅ لا توجد أصناف مباعة أكثر من مرة")
                End If
            End Using
        Else
            results.AppendLine("   • وضع منع البيع المزدوج: غير مُفعّل")
        End If

        ' 7. التحقق من إمكانية التحميل من invoce_report (المستخدم في FrmGoldSellEditRemove)
        results.AppendLine()
        results.AppendLine("7. التحقق من إمكانية التحميل (invoce_report)...")
        Dim reportQuery As String = "SELECT COUNT(*) FROM invoce_report WHERE invoc_time = N'" & invoiceId & "' AND Active = 1"
        Using cmd As New SqlCommand(reportQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                results.AppendLine("   ❌ الفاتورة لا تظهر في invoce_report")
                results.AppendLine("      السبب: Active != 1")
                issues.Add("الفاتورة غير قابلة للتحميل في FrmGoldSellEditRemove")
                canEdit = False
            Else
                results.AppendLine("   ✅ الفاتورة قابلة للتحميل (" & count & " سجل)")
            End If
        End Using

        ' 8. معلومات إضافية
        results.AppendLine()
        results.AppendLine("8. معلومات إضافية عن الفاتورة...")
        Dim infoQuery As String = "SELECT TOTAL_mony, CACH, KENT, PayMethod, PayMethod1, PayMethod2, Bank1, Bank2 FROM BAY WHERE BAY_SARYAL = N'" & invoiceId & "'"
        Using cmd As New SqlCommand(infoQuery, connection)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    results.AppendLine("   • المبلغ الإجمالي: " & reader("TOTAL_mony").ToString())
                    results.AppendLine("   • نقدي: " & reader("CACH").ToString())
                    results.AppendLine("   • كي نت: " & reader("KENT").ToString())
                    results.AppendLine("   • طريقة الدفع الأساسية: " & reader("PayMethod").ToString())
                    
                    Dim totalPaid As Decimal = Val(reader("CACH").ToString()) + Val(reader("KENT").ToString())
                    If Not IsDBNull(reader("Bank1")) Then totalPaid += Val(reader("Bank1").ToString())
                    If Not IsDBNull(reader("Bank2")) Then totalPaid += Val(reader("Bank2").ToString())
                    
                    results.AppendLine("   • إجمالي المدفوع: " & totalPaid.ToString())
                    
                    If totalPaid <> Val(reader("TOTAL_mony").ToString()) Then
                        warnings.Add("المبلغ المدفوع (" & totalPaid & ") لا يساوي المبلغ الإجمالي (" & reader("TOTAL_mony").ToString() & ")")
                    End If
                End If
            End Using
        End Using
        
        ' 9. التحقق من صلاحية المبالغ
        results.AppendLine()
        results.AppendLine("9. التحقق من صحة حسابات الفاتورة...")
        Dim sumQuery As String = "SELECT SUM(item_totalPrice) as TotalItems FROM selInvoceDetels WHERE invoc_time = N'" & invoiceId & "' AND Active = 1"
        Using cmd As New SqlCommand(sumQuery, connection)
            Dim totalItems As Object = cmd.ExecuteScalar()
            If Not IsDBNull(totalItems) AndAlso Not IsNothing(totalItems) Then
                results.AppendLine("   • مجموع أسعار الأصناف: " & totalItems.ToString())
                Dim bayTotal As Decimal = 0
                Dim bayTotalQuery As String = "SELECT TOTAL_mony FROM BAY WHERE BAY_SARYAL = N'" & invoiceId & "'"
                Using cmd2 As New SqlCommand(bayTotalQuery, connection)
                    Dim result As Object = cmd2.ExecuteScalar()
                    If Not IsDBNull(result) Then bayTotal = Val(result.ToString())
                End Using
                
                If Math.Abs(Val(totalItems.ToString()) - bayTotal) > 0.01 Then
                    warnings.Add("مجموع أسعار الأصناف (" & totalItems.ToString() & ") لا يساوي المبلغ في BAY (" & bayTotal & ")")
                Else
                    results.AppendLine("   ✅ المبالغ متطابقة بين selInvoceDetels و BAY")
                End If
            End If
        End Using
    End Sub

End Class

