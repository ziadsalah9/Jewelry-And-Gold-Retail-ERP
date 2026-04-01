Partial Class DT_restrantDataSet
    Partial Class invoce_reportDataTable

    End Class

    Partial Class Accessories_View_prinet_invoceDataTable

        Private Sub Accessories_View_prinet_invoceDataTable_Accessories_View_prinet_invoceRowChanging(ByVal sender As System.Object, ByVal e As Accessories_View_prinet_invoceRowChangeEvent) Handles Me.Accessories_View_prinet_invoceRowChanging

        End Sub

    End Class

    Partial Class ReportGoldBuyShortDataTable

    End Class

    Partial Public Class dimon_invceDataTable
    End Class

    Partial Public Class GoldSilverAvailableDataTable
        Private Sub GoldSilverAvailableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.FO_GramPriceColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class Accessories_ITEM_AvailableDataTable

        Private Sub Accessories_ITEM_AvailableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If e.Column.ColumnName = Accessories_NAMEColumn.ColumnName Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class ReportPathDataTable

    End Class

    Partial Class ReportGoldSellDetailedDataTable

        Private Sub ReportGoldSellDetailedBindingSourceDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If e.Column.ColumnName = BarCodeColumn.ColumnName Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class Print_Parcood1DataTable
        Private Sub Print_Parcood1DataTable_Print_Parcood1RowChanging(sender As Object, e As Print_Parcood1RowChangeEvent) Handles Me.Print_Parcood1RowChanging

        End Sub

    End Class
End Class

Namespace DT_restrantDataSetTableAdapters
    Partial Public Class Accessories_INVTableAdapter
    End Class

    Partial Class DIMON_detelsTableAdapter

    End Class

    Partial Public Class FO_minTableAdapter
    End Class

    Partial Public Class for_invoce_report_finelTableAdapter
    End Class
End Namespace
