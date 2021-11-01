using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace First
{
    /// <summary>
    /// Interaction logic for Shop_Scan_QR.xaml
    /// </summary>
    public partial class Shop_Scan_QR : Window
    {
        public Shop_Scan_QR()
        {
            InitializeComponent();
        }
        private void DragGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursor(index);
            switch (index)
            {
                case 0:
                    GridContent.Children.Clear();
                    GridContent.Children.Add(new ScanQR());
                    break;

            }
        }

        private void MoveCursor(int index)
        {
            TransitionContentSlide.OnApplyTemplate();

        }


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            GridContent.Children.Clear();
            GridContent.Children.Add(new ScanQR());
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
