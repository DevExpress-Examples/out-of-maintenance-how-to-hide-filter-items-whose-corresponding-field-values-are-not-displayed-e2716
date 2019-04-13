using DevExpress.Xpf.PivotGrid;
using System.Collections.Generic;

namespace DXPivotGrid_HowToHideFilterItems
{
    public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow
    {
        public MainWindow() {
            InitializeComponent();
        }
        private void pivotGridControl1_CustomFilterPopupItems(object sender, PivotCustomFilterPopupItemsEventArgs e) {
            List<object> values = e.Field.GetVisibleValues();
            values.Sort();
            for (int i = e.Items.Count - 1; i >= 0; i--)
            {
                if (e.Items[i].IsChecked == true && values.BinarySearch(e.Items[i].Value) < 0)
                    e.Items.RemoveAt(i);
            }
        }

        private void ThemedWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            pivotGridControl1.BestFit();
        }
    }
}
