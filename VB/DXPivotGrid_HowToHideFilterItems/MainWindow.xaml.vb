Imports DevExpress.Xpf.PivotGrid
Imports System.Collections.Generic

Namespace DXPivotGrid_HowToHideFilterItems
	Partial Public Class MainWindow
		Inherits DevExpress.Xpf.Core.ThemedWindow

		Public Sub New()
			InitializeComponent()
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

		Private Sub ThemedWindow_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
			pivotGridControl1.BestFit()
		End Sub
	End Class
End Namespace
