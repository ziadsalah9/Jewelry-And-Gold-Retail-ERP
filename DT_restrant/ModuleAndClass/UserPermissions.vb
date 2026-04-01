
Imports System.ServiceProcess
Imports PACICardLibrary
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Text
Imports System.IO
Module UserPermissions
    Public PermissionsDt As DataTable = Nothing
    
    Public Sub CheckUserPermissions(ByVal userID As String)
        ' التحقق من UserID
        If String.IsNullOrEmpty(userID) Then
            Try
                Dim logPath As String = System.IO.Path.Combine(Application.StartupPath, "log.txt")
                Dim logMsg As String = String.Format("[{0:yyyy-MM-dd HH:mm:ss.fff}] [CheckUserPermissions] !!! تحذير: UserID فارغ", DateTime.Now)
                System.IO.File.AppendAllText(logPath, logMsg & vbCrLf, System.Text.Encoding.UTF8)
            Catch
            End Try
            Return
        End If
        
        ' إعادة تحميل PermissionsDt إذا كان Nothing أو UserID مختلف
        Dim needReload As Boolean = False
        If PermissionsDt Is Nothing Then
            needReload = True
        ElseIf PermissionsDt.Rows.Count > 0 Then
            ' التحقق من أن UserID الموجود في PermissionsDt يطابق userID المطلوب
            Dim currentUserId As String = PermissionsDt.Rows(0)("User_id").ToString()
            If currentUserId <> userID Then
                needReload = True
            End If
        Else
            needReload = True
        End If
        
        If needReload Then
            Try
                Dim logPath As String = System.IO.Path.Combine(Application.StartupPath, "log.txt")
                Dim logMsg As String = String.Format("[{0:yyyy-MM-dd HH:mm:ss.fff}] [CheckUserPermissions] >>> بدء تحميل صلاحيات المستخدم: {1}", DateTime.Now, userID)
                System.IO.File.AppendAllText(logPath, logMsg & vbCrLf, System.Text.Encoding.UTF8)
            Catch
            End Try
            
            Try
                PermissionsDt = GetRecordSet("SELECT * FROM [user] WHERE [User_id] = '" & userID & "'")
                If PermissionsDt IsNot Nothing AndAlso PermissionsDt.Rows.Count > 0 Then
                    Try
                        Dim logPath As String = System.IO.Path.Combine(Application.StartupPath, "log.txt")
                        Dim logMsg As String = String.Format("[{0:yyyy-MM-dd HH:mm:ss.fff}] [CheckUserPermissions] تم تحميل {1} صف من صلاحيات المستخدم", DateTime.Now, PermissionsDt.Rows.Count)
                        System.IO.File.AppendAllText(logPath, logMsg & vbCrLf, System.Text.Encoding.UTF8)
                    Catch
                    End Try
                Else
                    Try
                        Dim logPath As String = System.IO.Path.Combine(Application.StartupPath, "log.txt")
                        Dim logMsg As String = String.Format("[{0:yyyy-MM-dd HH:mm:ss.fff}] [CheckUserPermissions] !!! تحذير: لم يتم العثور على صلاحيات للمستخدم {1}", DateTime.Now, userID)
                        System.IO.File.AppendAllText(logPath, logMsg & vbCrLf, System.Text.Encoding.UTF8)
                    Catch
                    End Try
                    Return ' لا توجد صلاحيات - الخروج
                End If
            Catch ex As Exception
                Try
                    Dim logPath As String = System.IO.Path.Combine(Application.StartupPath, "log.txt")
                    Dim logMsg As String = String.Format("[{0:yyyy-MM-dd HH:mm:ss.fff}] [CheckUserPermissions] !!! خطأ في تحميل الصلاحيات: {1}", DateTime.Now, ex.Message)
                    System.IO.File.AppendAllText(logPath, logMsg & vbCrLf, System.Text.Encoding.UTF8)
                Catch
                End Try
                Return ' خطأ في التحميل - الخروج
            End Try
        End If

        ''''اصناف الذهب
        If PermissionsDt IsNot Nothing AndAlso PermissionsDt.Rows.Count > 0 Then
            If PermissionsDt.Rows(0)("chkDelItem") = False Then
                With GoldAddItemDetails
                    .btnEdit.Enabled = False
                End With
                GoldInvoice.btnItemName.Enabled = False
            End If
        End If

        If PermissionsDt IsNot Nothing AndAlso PermissionsDt.Rows.Count > 0 Then
            If PermissionsDt.Rows(0)("chkItemSelectInvo") = False Then
                With GoldInvoice
                    .cmbItem.Enabled = False
                End With
            End If
        End If

        'chkModifyInvoce

        If PermissionsDt.Rows.Count > 0 Then
            If PermissionsDt.Rows(0)("chkModifyInvoce") = False Then
                With GoldInvoice
                    .txtMetalWeight.Enabled = False
                    .txtKarat.Enabled = False
                    .txtQty.Enabled = False
                    .txtStoneWeight1.Enabled = False
                    .txtStoneWeight2.Enabled = False
                    .txtStoneWeight3.Enabled = False
                    .grid.EditMode = False
                End With
            End If
        End If


        Try
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'استعلام عن كافة الصلاحيات من جدول المستخديمن

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If PermissionsDt IsNot Nothing AndAlso PermissionsDt.Rows.Count > 0 Then
                With frmMain
                    .btnSell.Enabled = PermissionsDt.Rows(0)("chkSell")
                    .btnBarCode.Enabled = PermissionsDt.Rows(0)("chkBarCode")
                    .mnuTransactions.Enabled = PermissionsDt.Rows(0)("chkModify")
                    .btnKarat.Enabled = PermissionsDt.Rows(0)("chkGramPrice")
                    .btnBuy.Enabled = PermissionsDt.Rows(0)("chkWholeSaleBuy")
                    .tsUserManagementUser.Enabled = PermissionsDt.Rows(0)("chkUsers")
                    .tsUserManagementCashier.Enabled = PermissionsDt.Rows(0)("chkCashier")
                    .btnBulkSell.Enabled = PermissionsDt.Rows(0)("chkWholesale")
                    .mnuReport.Enabled = PermissionsDt.Rows(0)("chkReports")
                    .btnExpense.Enabled = PermissionsDt.Rows(0)("chkExpenses")
                    .btnStock.Enabled = PermissionsDt.Rows(0)("chkStock")
                    .btnItem.Enabled = PermissionsDt.Rows(0)("chkItem")
                End With
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            If PermissionsDt IsNot Nothing AndAlso PermissionsDt.Rows.Count > 0 Then
                If PermissionsDt.Rows(0)("chkModifyInvoce") = False Then
                    With DiamondInvoice 'صلاحيات علي فاتورت بيع الالماس
                        .txtDiamondWeight.Enabled = False
                        .txtDiamondColor.Enabled = False
                        .txtClarity.Enabled = False
                        .cmbCut.Enabled = False
                        .txtItemNo.Enabled = False
                        .txtQty.Enabled = False
                        .cmbStone1.Enabled = False
                        .cmbStone2.Enabled = False
                        .cmbStone3.Enabled = False
                        .txtStoneWeight1.Enabled = False
                        .txtStoneWeight2.Enabled = False
                        .txtStoneWeight3.Enabled = False
                        .cmbStoneColor1.Enabled = False
                        .cmbStoneColor2.Enabled = False
                        .cmbStoneColor3.Enabled = False
                        .cmbStoneCut1.Enabled = False
                        .cmbStoneCut2.Enabled = False
                        .cmbStoneCut3.Enabled = False
                        .txtStoneClarity1.Enabled = False
                        .txtStoneClarity2.Enabled = False
                        .txtStoneClarity3.Enabled = False
                        .txtGoldWeight.Enabled = False
                        .txtTotalWeight.Enabled = False
                        .cmbSoldItemNames.Enabled = False
                        .cmbGoldKarat.Enabled = False
                    End With
                    If PermissionsDt.Rows(0)("chkInvPayInstallment") = False Then
                        With DiamondInvoicePay 'صلاحيات علي فاتورت بيع الالماس
                            .rbtnInstallment.Enabled = False
                        End With
                    End If

                End If
            Else
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Catch ex As Exception
        End Try
        '''''''''''صلاحيات الذهب

    End Sub

End Module
