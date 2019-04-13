Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.PivotGrid

Namespace DXPivotGrid_HowToHideFilterItems
	Partial Public Class MainWindow
		Inherits Window

		Private productReportsDataTable As New DataSet1.ProductReportsDataTable()
		Private productReportsDataAdapter As New DataSet1TableAdapters.ProductReportsTableAdapter()
		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = productReportsDataAdapter.GetData()
		End Sub
		Private Sub pivotGridControl1_CustomFilterPopupItems(ByVal sender As Object, ByVal e As PivotCustomFilterPopupItemsEventArgs)
			Dim values As List(Of Object) = e.Field.GetVisibleValues()
			values.Sort()
			For i As Integer = e.Items.Count - 1 To 0 Step -1
				If e.Items(i).IsChecked = True AndAlso values.BinarySearch(e.Items(i).Value) < 0 Then
					e.Items.RemoveAt(i)
				End If
			Next i
		End Sub
	End Class
End Namespace
