using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static CheckboxThing.Grid;

namespace CheckboxThing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < myGrid.SampleDataGrid.Items.Count; i++)
            {
                var item = myGrid.SampleDataGrid.Items[i] as SampleDataItem;
                if (item != null && item.Column1 > 50)
                {
                    var row = myGrid.SampleDataGrid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow;
                    if (row != null && myGrid.sampleData[i].Column4 == true)
                    {
                        row.Background = new SolidColorBrush(Colors.LightGreen);
                    } else
                    {
                        row.Background = new SolidColorBrush(Colors.Wheat);

                    }
                }
            }
        }
    }
}
