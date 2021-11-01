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
    /// Interaction logic for ShopDashBoard.xaml
    /// </summary>
    public partial class ShopDashBoard : Window
    {
        public ShopDashBoard()
        {
            InitializeComponent();
        }

        private void btnScanQR_Click(object sender, RoutedEventArgs e)
        {
            Shop_Scan_QR scanQR = new Shop_Scan_QR();
            scanQR.Show();
            this.Hide();
        }

        private void btnCustomerDetails_Click(object sender, RoutedEventArgs e)
        {
            CustomerDetails customerDetails = new CustomerDetails();
            customerDetails.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            LoginShop logShop = new LoginShop();
            logShop.Show();
            this.Hide();
        }
    }
}
