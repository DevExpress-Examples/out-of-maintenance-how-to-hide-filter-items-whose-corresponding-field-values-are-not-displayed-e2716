<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXPivotGrid_HowToHideFilterItems/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_HowToHideFilterItems/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/DXPivotGrid_HowToHideFilterItems/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_HowToHideFilterItems/MainWindow.xaml.vb))
<!-- default file list end -->
# How to hide filter items whose corresponding field values are not displayed


<p>The following example shows how to hide filter items whose corresponding field values are not displayed.</p><p>In this example, the Row Header Area of the PivotGrid contains two fields: 'Category Name' and 'Product Name'. If an end-user hides a particular product category via the 'Category Name' field's filter drop-down, the corresponding products will be excluded from the filter drop-down of the 'Product Name' field. To hide filter items, the CustomFilterPopupItems event is handled.</p><br />


<br/>


