Imports System
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Text
Imports System.Collections.Generic

Public Class FormMissingData

    Private results As New StringBuilder()
    Private currentConnectionString As String = String.Empty
    Private currentInvoiceId As String = String.Empty
    Private currentIsBuyInvoice As Boolean = False
    Private currentIsDiamondInvoice As Boolean = False
    Private hasMissingDetails As Boolean = False

    Public Sub New(connectionString As String, invoiceId As String, isBuyInvoice As Boolean, Optional isDiamondInvoice As Boolean = False, Optional isDiamondBuyInvoice As Boolean = False)
        InitializeComponent()
        currentConnectionString = connectionString
        currentInvoiceId = invoiceId
        currentIsBuyInvoice = isBuyInvoice
        currentIsDiamondInvoice = isDiamondInvoice
        CheckMissingData(connectionString, invoiceId, isBuyInvoice, isDiamondInvoice, isDiamondBuyInvoice)
    End Sub

    Private Sub CheckMissingData(connectionString As String, invoiceId As String, isBuyInvoice As Boolean, isDiamondInvoice As Boolean, isDiamondBuyInvoice As Boolean)
        Try
            Me.Cursor = Cursors.WaitCursor
            results.Clear()
            results.AppendLine("جاري التحقق من البيانات الناقصة...")
            results.AppendLine("========================================")
            results.AppendLine()

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim missingDataList As New List(Of String)()
                hasMissingDetails = False ' إعادة تعيين قبل كل فحص

                If isDiamondBuyInvoice Then
                    CheckDiamondBuyInvoiceData(connection, invoiceId, missingDataList)
                ElseIf isDiamondInvoice Then
                    CheckDiamondInvoiceData(connection, invoiceId, missingDataList)
                ElseIf isBuyInvoice Then
                    CheckBuyInvoiceData(connection, invoiceId, missingDataList)
                Else
                    CheckSellInvoiceData(connection, invoiceId, missingDataList)
                End If

                results.AppendLine()
                results.AppendLine("========================================")

                If missingDataList.Count = 0 Then
                    results.AppendLine("✓ لا توجد بيانات ناقصة - جميع الجداول تحتوي على البيانات المطلوبة")
                    txtResults.ForeColor = Color.Green
                Else
                    results.AppendLine("✗ تم العثور على " & missingDataList.Count & " مشكلة:")
                    results.AppendLine()
                    For Each issue As String In missingDataList
                        results.AppendLine("• " & issue)
                    Next
                    txtResults.ForeColor = Color.Red
                End If

                txtResults.Text = results.ToString()

                ' إظهار زر نسخ التفاصيل إذا كانت فاتورة (بيع أو شراء) وليس لها تفاصيل
                If hasMissingDetails Then
                    btnCopyDetails.Visible = True
                Else
                    btnCopyDetails.Visible = False
                End If

            End Using

        Catch ex As Exception
            txtResults.Text = "خطأ في التحقق: " & ex.Message
            txtResults.ForeColor = Color.Red
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnCopyDetails_Click(sender As Object, e As EventArgs) Handles btnCopyDetails.Click
        Try
            Dim invoiceTypeText As String = ""
            If currentIsDiamondInvoice Then
                invoiceTypeText = "فاتورة بيع الألماس"
            ElseIf currentIsBuyInvoice Then
                invoiceTypeText = "فاتورة شراء الذهب"
            Else
                invoiceTypeText = "فاتورة بيع الذهب"
            End If

            Dim sourceInvoiceId As String = InputBox("أدخل رقم الفاتورة المصدر (" & invoiceTypeText & " التي سيتم نسخ التفاصيل منها):", "نسخ تفاصيل فاتورة أخرى", "")
            
            If String.IsNullOrWhiteSpace(sourceInvoiceId) Then
                MessageBox.Show("لم يتم إدخال رقم الفاتورة المصدر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using connection As New SqlConnection(currentConnectionString)
                connection.Open()

                If currentIsDiamondInvoice Then
                    ' نسخ تفاصيل فاتورة بيع الألماس من dimon_invce
                    CopyDiamondInvoiceDetails(connection, sourceInvoiceId)
                ElseIf currentIsBuyInvoice Then
                    ' نسخ تفاصيل فاتورة شراء الذهب من Buy_Gold
                    CopyGoldBuyInvoiceDetails(connection, sourceInvoiceId)
                Else
                    ' نسخ تفاصيل فاتورة بيع الذهب من selInvoceDetels
                    CopyGoldSellInvoiceDetails(connection, sourceInvoiceId)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CopyGoldSellInvoiceDetails(connection As SqlConnection, sourceInvoiceId As String)
        ' التحقق من وجود تفاصيل في الفاتورة المصدر
        Dim checkSourceQuery As String = "SELECT COUNT(*) FROM selInvoceDetels WHERE invoc_time = N'" & sourceInvoiceId & "'"
        Using cmd As New SqlCommand(checkSourceQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                MessageBox.Show("الفاتورة المصدر رقم " & sourceInvoiceId & " ليس لها تفاصيل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End Using

        ' التحقق من عدم وجود تفاصيل في الفاتورة الهدف
        Dim checkTargetQuery As String = "SELECT COUNT(*) FROM selInvoceDetels WHERE invoc_time = N'" & currentInvoiceId & "'"
        Using cmd As New SqlCommand(checkTargetQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                Dim result As DialogResult = MessageBox.Show("الفاتورة الهدف لديها تفاصيل بالفعل. هل تريد المتابعة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    Return
                End If
            End If
        End Using

        ' الحصول على جميع أسماء الأعمدة باستثناء ID (Identity column)
        Dim columnNames As New List(Of String)()
        Dim getColumnsQuery As String = "SELECT COLUMN_NAME, COLUMNPROPERTY(OBJECT_ID('selInvoceDetels'), COLUMN_NAME, 'IsIdentity') AS IsIdentity " &
            "FROM INFORMATION_SCHEMA.COLUMNS " &
            "WHERE TABLE_NAME = 'selInvoceDetels' " &
            "ORDER BY ORDINAL_POSITION"
        
        Using cmdCols As New SqlCommand(getColumnsQuery, connection)
            Using reader As SqlDataReader = cmdCols.ExecuteReader()
                While reader.Read()
                    Dim colName As String = reader("COLUMN_NAME").ToString()
                    Dim isIdentity As Object = reader("IsIdentity")
                    ' استبعاد الأعمدة Identity من INSERT
                    If IsDBNull(isIdentity) OrElse Convert.ToInt32(isIdentity) = 0 Then
                        columnNames.Add("[" & colName & "]")
                    End If
                End While
            End Using
        End Using

        ' نسخ التفاصيل مع استبدال invoc_time
        Dim columnsList As String = String.Join(", ", columnNames)
        Dim selectColumns As String = columnsList.Replace("[invoc_time]", "N'" & currentInvoiceId & "' AS [invoc_time]")
        
        Dim copyQuery As String = "INSERT INTO selInvoceDetels (" & columnsList & ") " &
            "SELECT " & selectColumns & " " &
            "FROM selInvoceDetels " &
            "WHERE invoc_time = N'" & sourceInvoiceId & "'"

        Using transaction As SqlTransaction = connection.BeginTransaction()
            Try
                Using cmd As New SqlCommand(copyQuery, connection, transaction)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    transaction.Commit()
                    MessageBox.Show("تم نسخ " & rowsAffected & " سجل بنجاح من الفاتورة " & sourceInvoiceId & " إلى الفاتورة " & currentInvoiceId, "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    
                    ' إعادة تحميل البيانات
                    CheckMissingData(currentConnectionString, currentInvoiceId, currentIsBuyInvoice, currentIsDiamondInvoice, False)
                End Using
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("خطأ في نسخ التفاصيل: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub CopyGoldBuyInvoiceDetails(connection As SqlConnection, sourceInvoiceId As String)
        ' التحقق من وجود تفاصيل في الفاتورة المصدر
        Dim checkSourceQuery As String = "SELECT COUNT(*) FROM Buy_Gold WHERE inv_id = N'" & sourceInvoiceId & "'"
        Using cmd As New SqlCommand(checkSourceQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                MessageBox.Show("الفاتورة المصدر رقم " & sourceInvoiceId & " ليس لها تفاصيل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End Using

        ' التحقق من عدم وجود تفاصيل في الفاتورة الهدف
        Dim checkTargetQuery As String = "SELECT COUNT(*) FROM Buy_Gold WHERE inv_id = N'" & currentInvoiceId & "'"
        Using cmd As New SqlCommand(checkTargetQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                Dim result As DialogResult = MessageBox.Show("الفاتورة الهدف لديها تفاصيل بالفعل. هل تريد المتابعة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    Return
                End If
            End If
        End Using

        ' الحصول على جميع أسماء الأعمدة باستثناء ID (Identity column)
        Dim columnNames As New List(Of String)()
        Dim getColumnsQuery As String = "SELECT COLUMN_NAME, COLUMNPROPERTY(OBJECT_ID('Buy_Gold'), COLUMN_NAME, 'IsIdentity') AS IsIdentity " &
            "FROM INFORMATION_SCHEMA.COLUMNS " &
            "WHERE TABLE_NAME = 'Buy_Gold' " &
            "ORDER BY ORDINAL_POSITION"
        
        Using cmdCols As New SqlCommand(getColumnsQuery, connection)
            Using reader As SqlDataReader = cmdCols.ExecuteReader()
                While reader.Read()
                    Dim colName As String = reader("COLUMN_NAME").ToString()
                    Dim isIdentity As Object = reader("IsIdentity")
                    ' استبعاد الأعمدة Identity من INSERT
                    If IsDBNull(isIdentity) OrElse Convert.ToInt32(isIdentity) = 0 Then
                        columnNames.Add("[" & colName & "]")
                    End If
                End While
            End Using
        End Using

        ' نسخ التفاصيل مع استبدال inv_id
        Dim columnsList As String = String.Join(", ", columnNames)
        Dim selectColumns As String = columnsList.Replace("[inv_id]", "N'" & currentInvoiceId & "' AS [inv_id]")
        
        Dim copyQuery As String = "INSERT INTO Buy_Gold (" & columnsList & ") " &
            "SELECT " & selectColumns & " " &
            "FROM Buy_Gold " &
            "WHERE inv_id = N'" & sourceInvoiceId & "'"

        Using transaction As SqlTransaction = connection.BeginTransaction()
            Try
                Using cmd As New SqlCommand(copyQuery, connection, transaction)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    transaction.Commit()
                    MessageBox.Show("تم نسخ " & rowsAffected & " سجل بنجاح من الفاتورة " & sourceInvoiceId & " إلى الفاتورة " & currentInvoiceId, "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    
                    ' إعادة تحميل البيانات
                    CheckMissingData(currentConnectionString, currentInvoiceId, currentIsBuyInvoice, currentIsDiamondInvoice, False)
                End Using
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("خطأ في نسخ التفاصيل: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub CopyDiamondInvoiceDetails(connection As SqlConnection, sourceInvoiceId As String)
        ' نسخ تفاصيل فاتورة بيع الألماس من dimon_bay و dimon_invce
        ' التحقق من وجود بيانات في الفاتورة المصدر (فاتورة بيع الألماس)
        Dim checkSourceBayQuery As String = "SELECT COUNT(*) FROM dimon_bay WHERE BAY_SARYAL = N'" & sourceInvoiceId & "' AND Item_Actv = 1"
        Dim checkSourceInvceQuery As String = "SELECT COUNT(*) FROM dimon_invce WHERE descont = N'" & sourceInvoiceId & "' AND Item_Actv = 1"
        
        Dim sourceBayCount As Integer = 0
        Dim sourceInvceCount As Integer = 0
        
        Using cmd As New SqlCommand(checkSourceBayQuery, connection)
            sourceBayCount = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        
        Using cmd As New SqlCommand(checkSourceInvceQuery, connection)
            sourceInvceCount = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        
        If sourceBayCount = 0 AndAlso sourceInvceCount = 0 Then
            MessageBox.Show("فاتورة بيع الألماس المصدر رقم " & sourceInvoiceId & " ليس لها بيانات في جدول dimon_bay أو dimon_invce", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' التحقق من عدم وجود بيانات في الفاتورة الهدف
        Dim checkTargetBayQuery As String = "SELECT COUNT(*) FROM dimon_bay WHERE BAY_SARYAL = N'" & currentInvoiceId & "' AND Item_Actv = 1"
        Dim checkTargetInvceQuery As String = "SELECT COUNT(*) FROM dimon_invce WHERE descont = N'" & currentInvoiceId & "' AND Item_Actv = 1"
        
        Dim targetBayCount As Integer = 0
        Dim targetInvceCount As Integer = 0
        
        Using cmd As New SqlCommand(checkTargetBayQuery, connection)
            targetBayCount = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        
        Using cmd As New SqlCommand(checkTargetInvceQuery, connection)
            targetInvceCount = Convert.ToInt32(cmd.ExecuteScalar())
        End Using
        
        If targetBayCount > 0 OrElse targetInvceCount > 0 Then
            Dim result As DialogResult = MessageBox.Show("الفاتورة الهدف لديها بيانات بالفعل. هل تريد المتابعة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If
        End If

        Using transaction As SqlTransaction = connection.BeginTransaction()
            Try
                Dim totalRowsAffected As Integer = 0
                Dim bayRowsAffected As Integer = 0
                Dim invceRowsAffected As Integer = 0

                ' نسخ بيانات dimon_bay إذا كانت موجودة
                If sourceBayCount > 0 Then
                    ' الحصول على جميع أسماء الأعمدة من dimon_bay باستثناء ID (Identity column)
                    Dim bayColumnNames As New List(Of String)()
                    Dim getBayColumnsQuery As String = "SELECT COLUMN_NAME, COLUMNPROPERTY(OBJECT_ID('dimon_bay'), COLUMN_NAME, 'IsIdentity') AS IsIdentity " &
                        "FROM INFORMATION_SCHEMA.COLUMNS " &
                        "WHERE TABLE_NAME = 'dimon_bay' " &
                        "ORDER BY ORDINAL_POSITION"
                    
                    Using cmdCols As New SqlCommand(getBayColumnsQuery, connection, transaction)
                        Using reader As SqlDataReader = cmdCols.ExecuteReader()
                            While reader.Read()
                                Dim colName As String = reader("COLUMN_NAME").ToString()
                                Dim isIdentity As Object = reader("IsIdentity")
                                ' استبعاد الأعمدة Identity من INSERT
                                If IsDBNull(isIdentity) OrElse Convert.ToInt32(isIdentity) = 0 Then
                                    bayColumnNames.Add("[" & colName & "]")
                                End If
                            End While
                        End Using
                    End Using

                    ' نسخ بيانات dimon_bay مع استبدال BAY_SARYAL
                    Dim bayColumnsList As String = String.Join(", ", bayColumnNames)
                    Dim baySelectColumns As String = bayColumnsList.Replace("[BAY_SARYAL]", "N'" & currentInvoiceId & "' AS [BAY_SARYAL]")
                    
                    Dim copyBayQuery As String = "INSERT INTO dimon_bay (" & bayColumnsList & ") " &
                        "SELECT " & baySelectColumns & " " &
                        "FROM dimon_bay " &
                        "WHERE BAY_SARYAL = N'" & sourceInvoiceId & "' AND Item_Actv = 1"

                    Using cmd As New SqlCommand(copyBayQuery, connection, transaction)
                        bayRowsAffected = cmd.ExecuteNonQuery()
                        totalRowsAffected += bayRowsAffected
                    End Using
                End If

                ' نسخ بيانات dimon_invce إذا كانت موجودة
                If sourceInvceCount > 0 Then
                    ' الحصول على جميع أسماء الأعمدة من dimon_invce باستثناء ID (Identity column)
                    Dim invceColumnNames As New List(Of String)()
                    Dim getInvceColumnsQuery As String = "SELECT COLUMN_NAME, COLUMNPROPERTY(OBJECT_ID('dimon_invce'), COLUMN_NAME, 'IsIdentity') AS IsIdentity " &
                        "FROM INFORMATION_SCHEMA.COLUMNS " &
                        "WHERE TABLE_NAME = 'dimon_invce' " &
                        "ORDER BY ORDINAL_POSITION"
                    
                    Using cmdCols As New SqlCommand(getInvceColumnsQuery, connection, transaction)
                        Using reader As SqlDataReader = cmdCols.ExecuteReader()
                            While reader.Read()
                                Dim colName As String = reader("COLUMN_NAME").ToString()
                                Dim isIdentity As Object = reader("IsIdentity")
                                ' استبعاد الأعمدة Identity من INSERT
                                If IsDBNull(isIdentity) OrElse Convert.ToInt32(isIdentity) = 0 Then
                                    invceColumnNames.Add("[" & colName & "]")
                                End If
                            End While
                        End Using
                    End Using

                    ' نسخ التفاصيل مع استبدال descont
                    Dim invceColumnsList As String = String.Join(", ", invceColumnNames)
                    Dim invceSelectColumns As String = invceColumnsList.Replace("[descont]", "N'" & currentInvoiceId & "' AS [descont]")
                    
                    Dim copyInvceQuery As String = "INSERT INTO dimon_invce (" & invceColumnsList & ") " &
                        "SELECT " & invceSelectColumns & " " &
                        "FROM dimon_invce " &
                        "WHERE descont = N'" & sourceInvoiceId & "' AND Item_Actv = 1"

                    Using cmd As New SqlCommand(copyInvceQuery, connection, transaction)
                        invceRowsAffected = cmd.ExecuteNonQuery()
                        totalRowsAffected += invceRowsAffected
                    End Using
                End If

                transaction.Commit()
                
                Dim message As String = "تم نسخ البيانات بنجاح من فاتورة بيع الألماس " & sourceInvoiceId & " إلى فاتورة بيع الألماس " & currentInvoiceId & vbCrLf & vbCrLf
                If bayRowsAffected > 0 Then
                    message &= "• dimon_bay: " & bayRowsAffected & " سجل" & vbCrLf
                End If
                If invceRowsAffected > 0 Then
                    message &= "• dimon_invce: " & invceRowsAffected & " سجل" & vbCrLf
                End If
                message &= vbCrLf & "المجموع: " & totalRowsAffected & " سجل"
                
                MessageBox.Show(message, "نجاح - نسخ تفاصيل فاتورة بيع الألماس", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
                ' إعادة تحميل البيانات
                CheckMissingData(currentConnectionString, currentInvoiceId, currentIsBuyInvoice, currentIsDiamondInvoice, False)
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("خطأ في نسخ تفاصيل فاتورة بيع الألماس: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub CheckBuyInvoiceData(connection As SqlConnection, invoiceId As String, missingDataList As List(Of String))
        results.AppendLine("التحقق من فاتورة الشراء رقم: " & invoiceId)
        results.AppendLine()

        Dim buyGoldQuery As String = "SELECT COUNT(*) FROM Buy_Gold WHERE inv_id = N'" & invoiceId & "'"
        Using cmd As New SqlCommand(buyGoldQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("Buy_Gold: لا توجد بيانات للفاتورة رقم " & invoiceId)
                hasMissingDetails = True
            Else
                results.AppendLine("✓ Buy_Gold: موجود (" & count & " سجل)")

                Dim castomerIds As New List(Of String)()
                Dim castomerIdQuery As String = "SELECT DISTINCT castomer_id FROM Buy_Gold WHERE inv_id = N'" & invoiceId & "'"
                Using cmd2 As New SqlCommand(castomerIdQuery, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        While reader.Read()
                            Dim castomerId As Object = reader("castomer_id")
                            If Not IsDBNull(castomerId) AndAlso castomerId IsNot Nothing Then
                                castomerIds.Add(castomerId.ToString())
                            End If
                        End While
                    End Using
                End Using

                results.AppendLine()
                results.AppendLine("--- معلومات العملاء ---")
                If castomerIds.Count = 0 Then
                    missingDataList.Add("Buy_Gold: كود العميل فارغ في الفاتورة")
                    results.AppendLine("✗ كود العميل: فارغ في الفاتورة")
                Else
                    For Each castomerId As String In castomerIds
                        Dim castomerQuery As String = "SELECT CastomerNAme, CastomerNA FROM CastomerDETELS WHERE CastomerCAIVELid = @CastomerId"
                        Using cmd3 As New SqlCommand(castomerQuery, connection)
                            cmd3.Parameters.AddWithValue("@CastomerId", castomerId)
                            Using reader As SqlDataReader = cmd3.ExecuteReader()
                                If reader.Read() Then
                                    Dim customerName As String = If(IsDBNull(reader("CastomerNAme")), "غير محدد", reader("CastomerNAme").ToString())
                                    Dim customerNationalId As String = If(IsDBNull(reader("CastomerNA")), "غير محدد", reader("CastomerNA").ToString())
                                    results.AppendLine("✓ العميل رقم " & castomerId & ": " & customerName & " - الرقم المدني: " & customerNationalId)
                                Else
                                    missingDataList.Add("CastomerDETELS: لا توجد بيانات للعميل رقم " & castomerId)
                                    results.AppendLine("✗ العميل رقم " & castomerId & ": غير موجود في جدول العملاء")
                                End If
                            End Using
                        End Using
                    Next
                End If
            End If
        End Using

        Dim bayGoledMonyQuery As String = "SELECT COUNT(*) FROM bay_goled_mony WHERE saryal = N'" & invoiceId & "'"
        Using cmd As New SqlCommand(bayGoledMonyQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("bay_goled_mony: لا توجد بيانات للفاتورة رقم " & invoiceId)
            Else
                results.AppendLine("✓ bay_goled_mony: موجود (" & count & " سجل)")

                Dim cashierIds As New List(Of String)()
                Dim cashierQuery As String = "SELECT DISTINCT Cashier FROM bay_goled_mony WHERE saryal = N'" & invoiceId & "' AND Cashier IS NOT NULL"
                Using cmd2 As New SqlCommand(cashierQuery, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        While reader.Read()
                            cashierIds.Add(reader("Cashier").ToString())
                        End While
                    End Using
                End Using

                results.AppendLine()
                results.AppendLine("--- معلومات الكاشيرات ---")
                Dim cashierIdsFromInvoice As New List(Of String)()
                Dim cashierQuery2 As String = "SELECT DISTINCT Cashier FROM bay_goled_mony WHERE saryal = N'" & invoiceId & "'"
                Using cmd2 As New SqlCommand(cashierQuery2, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        While reader.Read()
                            Dim cashierId As Object = reader("Cashier")
                            If IsDBNull(cashierId) OrElse cashierId Is Nothing OrElse String.IsNullOrWhiteSpace(cashierId.ToString()) Then
                                missingDataList.Add("bay_goled_mony: رقم الكاشير فارغ في الفاتورة")
                                results.AppendLine("✗ رقم الكاشير: فارغ في الفاتورة")
                            Else
                                cashierIdsFromInvoice.Add(cashierId.ToString())
                            End If
                        End While
                    End Using
                End Using

                For Each cashierId As String In cashierIdsFromInvoice
                    Dim cacherQuery As String = "SELECT cacher_name, full_name, svil_id FROM cacher WHERE svil_id = @CashierId"
                    Using cmd3 As New SqlCommand(cacherQuery, connection)
                        cmd3.Parameters.AddWithValue("@CashierId", cashierId)
                        Using reader As SqlDataReader = cmd3.ExecuteReader()
                            If reader.Read() Then
                                Dim cacherName As String = If(IsDBNull(reader("cacher_name")), "غير محدد", reader("cacher_name").ToString())
                                Dim fullName As String = If(IsDBNull(reader("full_name")), "غير محدد", reader("full_name").ToString())
                                results.AppendLine("✓ الكاشير رقم " & cashierId & ": " & cacherName & " - الاسم الكامل: " & fullName)
                            Else
                                missingDataList.Add("cacher: لا توجد بيانات للكاشير رقم " & cashierId & " (موجود في الفاتورة)")
                                results.AppendLine("✗ الكاشير رقم " & cashierId & ": غير موجود في جدول الكاشيرات (موجود في الفاتورة)")
                            End If
                        End Using
                    End Using
                Next

                Dim payMethodIds As New List(Of String)()
                Dim payMethodQuery As String = "SELECT DISTINCT PayMethod FROM bay_goled_mony WHERE saryal = N'" & invoiceId & "' AND PayMethod IS NOT NULL"
                Using cmd2 As New SqlCommand(payMethodQuery, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        While reader.Read()
                            payMethodIds.Add(reader("PayMethod").ToString())
                        End While
                    End Using
                End Using

                For Each payMethodId As String In payMethodIds
                    Dim payMethodCheckQuery As String = "SELECT COUNT(*) FROM PayMethod WHERE ID = @PayMethodId"
                    Using cmd3 As New SqlCommand(payMethodCheckQuery, connection)
                        cmd3.Parameters.AddWithValue("@PayMethodId", payMethodId)
                        Dim payMethodCount As Integer = Convert.ToInt32(cmd3.ExecuteScalar())
                        If payMethodCount = 0 Then
                            missingDataList.Add("PayMethod: لا توجد بيانات لطريقة الدفع رقم " & payMethodId)
                        End If
                    End Using
                Next
            End If
        End Using

        Dim settingsQuery As String = "SELECT COUNT(*) FROM Settings"
        Using cmd As New SqlCommand(settingsQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("Settings: لا توجد بيانات في جدول الإعدادات")
            Else
                results.AppendLine("✓ Settings: موجود")
            End If
        End Using

        Dim compInformQuery As String = "SELECT COUNT(*) FROM comp_inform"
        Using cmd As New SqlCommand(compInformQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("comp_inform: لا توجد بيانات في جدول معلومات الشركة")
            Else
                results.AppendLine("✓ comp_inform: موجود")
            End If
        End Using
    End Sub

    Private Sub CheckSellInvoiceData(connection As SqlConnection, invoiceId As String, missingDataList As List(Of String))
        results.AppendLine("التحقق من فاتورة البيع رقم: " & invoiceId)
        results.AppendLine()

        Dim bayQuery As String = "SELECT COUNT(*) FROM BAY WHERE BAY_SARYAL = N'" & invoiceId & "'"
        Using cmd As New SqlCommand(bayQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("BAY: لا توجد بيانات للفاتورة رقم " & invoiceId)
            Else
                results.AppendLine("✓ BAY: موجود (" & count & " سجل)")
            End If
        End Using

        Dim selInvoceDetelsQuery As String = "SELECT COUNT(*) FROM selInvoceDetels WHERE invoc_time = N'" & invoiceId & "'"
        Using cmd As New SqlCommand(selInvoceDetelsQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("selInvoceDetels: لا توجد بيانات للفاتورة رقم " & invoiceId)
                hasMissingDetails = True
            Else
                results.AppendLine("✓ selInvoceDetels: موجود (" & count & " سجل)")

                Dim castomerIds As New List(Of String)()
                Dim castomerIdQuery As String = "SELECT DISTINCT Castomerid FROM selInvoceDetels WHERE invoc_time = N'" & invoiceId & "'"
                Using cmd2 As New SqlCommand(castomerIdQuery, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        While reader.Read()
                            Dim castomerId As Object = reader("Castomerid")
                            If Not IsDBNull(castomerId) AndAlso castomerId IsNot Nothing Then
                                castomerIds.Add(castomerId.ToString())
                            End If
                        End While
                    End Using
                End Using

                results.AppendLine()
                results.AppendLine("--- معلومات العملاء ---")
                If castomerIds.Count = 0 Then
                    missingDataList.Add("selInvoceDetels: كود العميل فارغ في الفاتورة")
                    results.AppendLine("✗ كود العميل: فارغ في الفاتورة")
                Else
                    For Each castomerId As String In castomerIds
                        Dim castomerQuery As String = "SELECT CastomerNAme, CastomerNA FROM CastomerDETELS WHERE CastomerCAIVELid = @CastomerId"
                        Using cmd3 As New SqlCommand(castomerQuery, connection)
                            cmd3.Parameters.AddWithValue("@CastomerId", castomerId)
                            Using reader As SqlDataReader = cmd3.ExecuteReader()
                                If reader.Read() Then
                                    Dim customerName As String = If(IsDBNull(reader("CastomerNAme")), "غير محدد", reader("CastomerNAme").ToString())
                                    Dim customerNationalId As String = If(IsDBNull(reader("CastomerNA")), "غير محدد", reader("CastomerNA").ToString())
                                    results.AppendLine("✓ العميل رقم " & castomerId & ": " & customerName & " - الرقم المدني: " & customerNationalId)
                                Else
                                    missingDataList.Add("CastomerDETELS: لا توجد بيانات للعميل رقم " & castomerId)
                                    results.AppendLine("✗ العميل رقم " & castomerId & ": غير موجود في جدول العملاء")
                                End If
                            End Using
                        End Using
                    Next
                End If

                Dim itemIds As New List(Of String)()
                Dim itemIdQuery As String = "SELECT DISTINCT itemID FROM selInvoceDetels WHERE invoc_time = N'" & invoiceId & "' AND itemID IS NOT NULL"
                Using cmd2 As New SqlCommand(itemIdQuery, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        While reader.Read()
                            itemIds.Add(reader("itemID").ToString())
                        End While
                    End Using
                End Using

                For Each itemId As String In itemIds
                    Dim foMinQuery As String = "SELECT COUNT(*) FROM FO_min WHERE BarCode = @ItemId"
                    Using cmd3 As New SqlCommand(foMinQuery, connection)
                        cmd3.Parameters.AddWithValue("@ItemId", itemId)
                        Dim foMinCount As Integer = Convert.ToInt32(cmd3.ExecuteScalar())
                        If foMinCount = 0 Then
                            missingDataList.Add("FO_min: لا توجد بيانات للمنتج رقم " & itemId)
                        End If
                    End Using
                Next

                Dim cacherIds As New List(Of String)()
                Dim cacherQuery As String = "SELECT DISTINCT cacher FROM selInvoceDetels WHERE invoc_time = N'" & invoiceId & "' AND cacher IS NOT NULL"
                Using cmd2 As New SqlCommand(cacherQuery, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        While reader.Read()
                            cacherIds.Add(reader("cacher").ToString())
                        End While
                    End Using
                End Using

                results.AppendLine()
                results.AppendLine("--- معلومات الكاشيرات ---")
                Dim cacherIdsFromInvoice As New List(Of String)()
                Dim cacherQuery2 As String = "SELECT DISTINCT cacher FROM selInvoceDetels WHERE invoc_time = N'" & invoiceId & "'"
                Using cmd2 As New SqlCommand(cacherQuery2, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        While reader.Read()
                            Dim cacherId As Object = reader("cacher")
                            If IsDBNull(cacherId) OrElse cacherId Is Nothing OrElse String.IsNullOrWhiteSpace(cacherId.ToString()) Then
                                missingDataList.Add("selInvoceDetels: رقم الكاشير فارغ في الفاتورة")
                                results.AppendLine("✗ رقم الكاشير: فارغ في الفاتورة")
                            Else
                                cacherIdsFromInvoice.Add(cacherId.ToString())
                            End If
                        End While
                    End Using
                End Using

                For Each cacherId As String In cacherIdsFromInvoice
                    Dim cacherCheckQuery As String = "SELECT cacher_name, full_name, svil_id FROM cacher WHERE svil_id = @CacherId"
                    Using cmd3 As New SqlCommand(cacherCheckQuery, connection)
                        cmd3.Parameters.AddWithValue("@CacherId", cacherId)
                        Using reader As SqlDataReader = cmd3.ExecuteReader()
                            If reader.Read() Then
                                Dim cacherName As String = If(IsDBNull(reader("cacher_name")), "غير محدد", reader("cacher_name").ToString())
                                Dim fullName As String = If(IsDBNull(reader("full_name")), "غير محدد", reader("full_name").ToString())
                                results.AppendLine("✓ الكاشير رقم " & cacherId & ": " & cacherName & " - الاسم الكامل: " & fullName)
                            Else
                                missingDataList.Add("cacher: لا توجد بيانات للكاشير رقم " & cacherId & " (موجود في الفاتورة)")
                                results.AppendLine("✗ الكاشير رقم " & cacherId & ": غير موجود في جدول الكاشيرات (موجود في الفاتورة)")
                            End If
                        End Using
                    End Using
                Next
            End If
        End Using

        Dim payMethodIds As New List(Of String)()
        Dim payMethodQuery As String = "SELECT PayMethod, PayMethod1, PayMethod2, PayMethod3, PayMethod4 FROM BAY WHERE BAY_SARYAL = N'" & invoiceId & "'"
        Using cmd As New SqlCommand(payMethodQuery, connection)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    For i As Integer = 0 To 4
                        Dim payMethodId As Object = Nothing
                        If i = 0 Then
                            payMethodId = reader("PayMethod")
                        ElseIf i = 1 Then
                            payMethodId = reader("PayMethod1")
                        ElseIf i = 2 Then
                            payMethodId = reader("PayMethod2")
                        ElseIf i = 3 Then
                            payMethodId = reader("PayMethod3")
                        ElseIf i = 4 Then
                            payMethodId = reader("PayMethod4")
                        End If

                        If Not IsDBNull(payMethodId) AndAlso payMethodId IsNot Nothing Then
                            Dim payMethodIdStr As String = payMethodId.ToString()
                            If Not payMethodIds.Contains(payMethodIdStr) Then
                                payMethodIds.Add(payMethodIdStr)
                            End If
                        End If
                    Next
                End While
            End Using
        End Using

        For Each payMethodId As String In payMethodIds
            Dim payMethodCheckQuery As String = "SELECT COUNT(*) FROM PayMethod WHERE ID = @PayMethodId"
            Using cmd2 As New SqlCommand(payMethodCheckQuery, connection)
                cmd2.Parameters.AddWithValue("@PayMethodId", payMethodId)
                Dim payMethodCount As Integer = Convert.ToInt32(cmd2.ExecuteScalar())
                If payMethodCount = 0 Then
                    missingDataList.Add("PayMethod: لا توجد بيانات لطريقة الدفع رقم " & payMethodId)
                End If
            End Using
        Next

        Dim settingsQuery As String = "SELECT COUNT(*) FROM Settings"
        Using cmd As New SqlCommand(settingsQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("Settings: لا توجد بيانات في جدول الإعدادات")
            Else
                results.AppendLine("✓ Settings: موجود")
            End If
        End Using

        Dim compInformQuery As String = "SELECT COUNT(*) FROM comp_inform"
        Using cmd As New SqlCommand(compInformQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("comp_inform: لا توجد بيانات في جدول معلومات الشركة")
            Else
                results.AppendLine("✓ comp_inform: موجود")
            End If
        End Using
    End Sub

    Private Sub CheckDiamondInvoiceData(connection As SqlConnection, invoiceId As String, missingDataList As List(Of String))
        results.AppendLine("التحقق من فاتورة بيع الألماس رقم: " & invoiceId)
        results.AppendLine()

        ' التحقق من dimon_bay
        Dim dimonBayQuery As String = "SELECT COUNT(*) FROM dimon_bay WHERE BAY_SARYAL = N'" & invoiceId & "' AND Item_Actv = 1"
        Using cmd As New SqlCommand(dimonBayQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("dimon_bay: لا توجد بيانات للفاتورة رقم " & invoiceId)
                hasMissingDetails = True
            Else
                results.AppendLine("✓ dimon_bay: موجود (" & count & " سجل)")
            End If
        End Using

        ' التحقق من dimon_invce
        Dim dimonInvceQuery As String = "SELECT COUNT(*) FROM dimon_invce WHERE descont = N'" & invoiceId & "' AND Item_Actv = 1"
        Using cmd As New SqlCommand(dimonInvceQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("dimon_invce: لا توجد بيانات للفاتورة رقم " & invoiceId)
                hasMissingDetails = True
            Else
                results.AppendLine("✓ dimon_invce: موجود (" & count & " سجل)")

                ' التحقق من العملاء
                Dim castomerIds As New List(Of String)()
                Dim castomerIdQuery As String = "SELECT DISTINCT castomr_id FROM dimon_invce WHERE descont = N'" & invoiceId & "' AND Item_Actv = 1"
                Using cmd2 As New SqlCommand(castomerIdQuery, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        While reader.Read()
                            Dim castomerId As Object = reader("castomr_id")
                            If Not IsDBNull(castomerId) AndAlso castomerId IsNot Nothing Then
                                castomerIds.Add(castomerId.ToString())
                            End If
                        End While
                    End Using
                End Using

                results.AppendLine()
                results.AppendLine("--- معلومات العملاء ---")
                If castomerIds.Count = 0 Then
                    missingDataList.Add("dimon_invce: كود العميل فارغ في الفاتورة")
                    results.AppendLine("✗ كود العميل: فارغ في الفاتورة")
                Else
                    For Each castomerId As String In castomerIds
                        Dim castomerQuery As String = "SELECT CastomerNAme, CastomerNA FROM CastomerDETELS WHERE CastomerCAIVELid = @CastomerId"
                        Using cmd3 As New SqlCommand(castomerQuery, connection)
                            cmd3.Parameters.AddWithValue("@CastomerId", castomerId)
                            Using reader As SqlDataReader = cmd3.ExecuteReader()
                                If reader.Read() Then
                                    Dim customerName As String = If(IsDBNull(reader("CastomerNAme")), "غير محدد", reader("CastomerNAme").ToString())
                                    Dim customerNationalId As String = If(IsDBNull(reader("CastomerNA")), "غير محدد", reader("CastomerNA").ToString())
                                    results.AppendLine("✓ العميل رقم " & castomerId & ": " & customerName & " - الرقم المدني: " & customerNationalId)
                                Else
                                    missingDataList.Add("CastomerDETELS: لا توجد بيانات للعميل رقم " & castomerId)
                                    results.AppendLine("✗ العميل رقم " & castomerId & ": غير موجود في جدول العملاء")
                                End If
                            End Using
                        End Using
                    Next
                End If

                ' التحقق من التفاصيل (DIMON_detels)
                Dim dimoIds As New List(Of String)()
                Dim dimoIdQuery As String = "SELECT DISTINCT dimo_id FROM dimon_invce WHERE descont = N'" & invoiceId & "' AND Item_Actv = 1 AND dimo_id IS NOT NULL"
                Using cmd2 As New SqlCommand(dimoIdQuery, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        While reader.Read()
                            dimoIds.Add(reader("dimo_id").ToString())
                        End While
                    End Using
                End Using

                results.AppendLine()
                results.AppendLine("--- معلومات التفاصيل ---")
                For Each dimoId As String In dimoIds
                    Dim dimonDetelsQuery As String = "SELECT COUNT(*) FROM DIMON_detels WHERE test_119 = @DimoId"
                    Using cmd3 As New SqlCommand(dimonDetelsQuery, connection)
                        cmd3.Parameters.AddWithValue("@DimoId", dimoId)
                        Dim dimonDetelsCount As Integer = Convert.ToInt32(cmd3.ExecuteScalar())
                        If dimonDetelsCount = 0 Then
                            missingDataList.Add("DIMON_detels: لا توجد بيانات للقطعة رقم " & dimoId)
                            results.AppendLine("✗ القطعة رقم " & dimoId & ": غير موجودة في DIMON_detels")
                        Else
                            results.AppendLine("✓ القطعة رقم " & dimoId & ": موجودة في DIMON_detels")
                        End If
                    End Using
                Next

                ' التحقق من الكاشيرات
                Dim cacherIds As New List(Of String)()
                Dim cacherQuery As String = "SELECT DISTINCT test_118 FROM dimon_invce WHERE descont = N'" & invoiceId & "' AND Item_Actv = 1 AND test_118 IS NOT NULL"
                Using cmd2 As New SqlCommand(cacherQuery, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        While reader.Read()
                            cacherIds.Add(reader("test_118").ToString())
                        End While
                    End Using
                End Using

                results.AppendLine()
                results.AppendLine("--- معلومات الكاشيرات ---")
                If cacherIds.Count = 0 Then
                    missingDataList.Add("dimon_invce: رقم الكاشير فارغ في الفاتورة")
                    results.AppendLine("✗ رقم الكاشير: فارغ في الفاتورة")
                Else
                    For Each cacherId As String In cacherIds
                        Dim cacherCheckQuery As String = "SELECT cacher_name, full_name, svil_id FROM cacher WHERE svil_id = @CacherId"
                        Using cmd3 As New SqlCommand(cacherCheckQuery, connection)
                            cmd3.Parameters.AddWithValue("@CacherId", cacherId)
                            Using reader As SqlDataReader = cmd3.ExecuteReader()
                                If reader.Read() Then
                                    Dim cacherName As String = If(IsDBNull(reader("cacher_name")), "غير محدد", reader("cacher_name").ToString())
                                    Dim fullName As String = If(IsDBNull(reader("full_name")), "غير محدد", reader("full_name").ToString())
                                    results.AppendLine("✓ الكاشير رقم " & cacherId & ": " & cacherName & " - الاسم الكامل: " & fullName)
                                Else
                                    missingDataList.Add("cacher: لا توجد بيانات للكاشير رقم " & cacherId)
                                    results.AppendLine("✗ الكاشير رقم " & cacherId & ": غير موجود في جدول الكاشيرات")
                                End If
                            End Using
                        End Using
                    Next
                End If
            End If
        End Using

        ' التحقق من طرق الدفع
        Dim payMethodIds As New List(Of String)()
        Dim payMethodQuery As String = "SELECT DISTINCT PayMethod FROM dimon_bay WHERE BAY_SARYAL = N'" & invoiceId & "' AND Item_Actv = 1 AND PayMethod IS NOT NULL"
        Using cmd As New SqlCommand(payMethodQuery, connection)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    payMethodIds.Add(reader("PayMethod").ToString())
                End While
            End Using
        End Using

        results.AppendLine()
        results.AppendLine("--- طرق الدفع ---")
        For Each payMethodId As String In payMethodIds
            Dim payMethodCheckQuery As String = "SELECT COUNT(*) FROM PayMethod WHERE ID = @PayMethodId"
            Using cmd2 As New SqlCommand(payMethodCheckQuery, connection)
                cmd2.Parameters.AddWithValue("@PayMethodId", payMethodId)
                Dim payMethodCount As Integer = Convert.ToInt32(cmd2.ExecuteScalar())
                If payMethodCount = 0 Then
                    missingDataList.Add("PayMethod: لا توجد بيانات لطريقة الدفع رقم " & payMethodId)
                    results.AppendLine("✗ طريقة الدفع رقم " & payMethodId & ": غير موجودة")
                Else
                    results.AppendLine("✓ طريقة الدفع رقم " & payMethodId & ": موجودة")
                End If
            End Using
        Next

        ' التحقق من Settings
        Dim settingsQuery As String = "SELECT COUNT(*) FROM Settings"
        Using cmd As New SqlCommand(settingsQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("Settings: لا توجد بيانات في جدول الإعدادات")
            Else
                results.AppendLine("✓ Settings: موجود")
            End If
        End Using

        ' التحقق من comp_inform
        Dim compInformQuery As String = "SELECT COUNT(*) FROM comp_inform"
        Using cmd As New SqlCommand(compInformQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("comp_inform: لا توجد بيانات في جدول معلومات الشركة")
            Else
                results.AppendLine("✓ comp_inform: موجود")
            End If
        End Using
    End Sub

    Private Sub CheckDiamondBuyInvoiceData(connection As SqlConnection, invoiceId As String, missingDataList As List(Of String))
        results.AppendLine("التحقق من فاتورة شراء الألماس رقم: " & invoiceId)
        results.AppendLine()

        ' التحقق من Bay_Diamond_mony
        Dim bayDiamondMonyQuery As String = "SELECT COUNT(*) FROM Bay_Diamond_mony WHERE saryal = N'" & invoiceId & "' AND Active = 1"
        Using cmd As New SqlCommand(bayDiamondMonyQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("Bay_Diamond_mony: لا توجد بيانات للفاتورة رقم " & invoiceId)
            Else
                results.AppendLine("✓ Bay_Diamond_mony: موجود (" & count & " سجل)")
            End If
        End Using

        ' التحقق من Buy_Diamond
        Dim buyDiamondQuery As String = "SELECT COUNT(*) FROM Buy_Diamond WHERE inv_id = N'" & invoiceId & "' AND Active = 1"
        Using cmd As New SqlCommand(buyDiamondQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("Buy_Diamond: لا توجد بيانات للفاتورة رقم " & invoiceId)
            Else
                results.AppendLine("✓ Buy_Diamond: موجود (" & count & " سجل)")

                ' التحقق من العملاء
                Dim castomerIds As New List(Of String)()
                Dim castomerIdQuery As String = "SELECT DISTINCT castomer_id FROM Buy_Diamond WHERE inv_id = N'" & invoiceId & "' AND Active = 1"
                Using cmd2 As New SqlCommand(castomerIdQuery, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        While reader.Read()
                            Dim castomerId As Object = reader("castomer_id")
                            If Not IsDBNull(castomerId) AndAlso castomerId IsNot Nothing Then
                                castomerIds.Add(castomerId.ToString())
                            End If
                        End While
                    End Using
                End Using

                results.AppendLine()
                results.AppendLine("--- معلومات العملاء ---")
                If castomerIds.Count = 0 Then
                    missingDataList.Add("Buy_Diamond: كود العميل فارغ في الفاتورة")
                    results.AppendLine("✗ كود العميل: فارغ في الفاتورة")
                Else
                    For Each castomerId As String In castomerIds
                        Dim castomerQuery As String = "SELECT CastomerNAme, CastomerNA FROM CastomerDETELS WHERE CastomerCAIVELid = @CastomerId"
                        Using cmd3 As New SqlCommand(castomerQuery, connection)
                            cmd3.Parameters.AddWithValue("@CastomerId", castomerId)
                            Using reader As SqlDataReader = cmd3.ExecuteReader()
                                If reader.Read() Then
                                    Dim customerName As String = If(IsDBNull(reader("CastomerNAme")), "غير محدد", reader("CastomerNAme").ToString())
                                    Dim customerNationalId As String = If(IsDBNull(reader("CastomerNA")), "غير محدد", reader("CastomerNA").ToString())
                                    results.AppendLine("✓ العميل رقم " & castomerId & ": " & customerName & " - الرقم المدني: " & customerNationalId)
                                Else
                                    missingDataList.Add("CastomerDETELS: لا توجد بيانات للعميل رقم " & castomerId)
                                    results.AppendLine("✗ العميل رقم " & castomerId & ": غير موجود في جدول العملاء")
                                End If
                            End Using
                        End Using
                    Next
                End If

                ' التحقق من الكاشيرات (qult يحتوي على cacher_name)
                Dim cacherNames As New List(Of String)()
                Dim cacherQuery As String = "SELECT DISTINCT qult FROM Buy_Diamond WHERE inv_id = N'" & invoiceId & "' AND Active = 1 AND qult IS NOT NULL"
                Using cmd2 As New SqlCommand(cacherQuery, connection)
                    Using reader As SqlDataReader = cmd2.ExecuteReader()
                        While reader.Read()
                            cacherNames.Add(reader("qult").ToString())
                        End While
                    End Using
                End Using

                results.AppendLine()
                results.AppendLine("--- معلومات الكاشيرات ---")
                If cacherNames.Count = 0 Then
                    missingDataList.Add("Buy_Diamond: اسم الكاشير فارغ في الفاتورة")
                    results.AppendLine("✗ اسم الكاشير: فارغ في الفاتورة")
                Else
                    For Each cacherName As String In cacherNames
                        Dim cacherCheckQuery As String = "SELECT cacher_name, full_name, svil_id FROM cacher WHERE cacher_name = @CacherName"
                        Using cmd3 As New SqlCommand(cacherCheckQuery, connection)
                            cmd3.Parameters.AddWithValue("@CacherName", cacherName)
                            Using reader As SqlDataReader = cmd3.ExecuteReader()
                                If reader.Read() Then
                                    Dim fullName As String = If(IsDBNull(reader("full_name")), "غير محدد", reader("full_name").ToString())
                                    results.AppendLine("✓ الكاشير " & cacherName & " - الاسم الكامل: " & fullName)
                                Else
                                    missingDataList.Add("cacher: لا توجد بيانات للكاشير: " & cacherName)
                                    results.AppendLine("✗ الكاشير " & cacherName & ": غير موجود في جدول الكاشيرات")
                                End If
                            End Using
                        End Using
                    Next
                End If
            End If
        End Using

        ' التحقق من طرق الدفع
        Dim payMethodIds As New List(Of String)()
        Dim payMethodQuery As String = "SELECT DISTINCT PayMethod FROM Bay_Diamond_mony WHERE saryal = N'" & invoiceId & "' AND Active = 1 AND PayMethod IS NOT NULL"
        Using cmd As New SqlCommand(payMethodQuery, connection)
            Using reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    payMethodIds.Add(reader("PayMethod").ToString())
                End While
            End Using
        End Using

        results.AppendLine()
        results.AppendLine("--- طرق الدفع ---")
        For Each payMethodId As String In payMethodIds
            Dim payMethodCheckQuery As String = "SELECT COUNT(*) FROM PayMethod WHERE ID = @PayMethodId"
            Using cmd2 As New SqlCommand(payMethodCheckQuery, connection)
                cmd2.Parameters.AddWithValue("@PayMethodId", payMethodId)
                Dim payMethodCount As Integer = Convert.ToInt32(cmd2.ExecuteScalar())
                If payMethodCount = 0 Then
                    missingDataList.Add("PayMethod: لا توجد بيانات لطريقة الدفع رقم " & payMethodId)
                    results.AppendLine("✗ طريقة الدفع رقم " & payMethodId & ": غير موجودة")
                Else
                    results.AppendLine("✓ طريقة الدفع رقم " & payMethodId & ": موجودة")
                End If
            End Using
        Next

        ' التحقق من Settings
        Dim settingsQuery As String = "SELECT COUNT(*) FROM Settings"
        Using cmd As New SqlCommand(settingsQuery, connection)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count = 0 Then
                missingDataList.Add("Settings: لا توجد بيانات في جدول الإعدادات")
            Else
                results.AppendLine("✓ Settings: موجود")
            End If
        End Using
    End Sub

End Class
