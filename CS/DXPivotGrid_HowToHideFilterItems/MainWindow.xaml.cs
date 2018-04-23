using System.Collections.Generic;
using System.Windows;
using DevExpress.Xpf.PivotGrid;

namespace DXPivotGrid_HowToHideFilterItems {
    public partial class MainWindow : Window {
        DataSet1.ProductReportsDataTable productReportsDataTable = 
            new DataSet1.ProductReportsDataTable();
        DataSet1TableAdapters.ProductReportsTableAdapter productReportsDataAdapter = 
            new DataSet1TableAdapters.ProductReportsTableAdapter();
        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = productReportsDataAdapter.GetData();
        }
        private void pivotGridControl1_CustomFilterPopupItems(object sender, 
                PivotCustomFilterPopupItemsEventArgs e) {
            List<object> values = e.Field.GetVisibleValues();
            values.Sort();
            for (int i = e.Items.Count - 1; i >= 0; i--) {
                if (e.Items[i].IsChecked == true && values.BinarySearch(e.Items[i].Value) < 0)
                    e.Items.RemoveAt(i);
            }
        }
    }
}
