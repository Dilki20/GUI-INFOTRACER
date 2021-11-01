using First.Database;
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
    /// Interaction logic for CustomerDetails.xaml
    /// </summary>
    public partial class CustomerDetails : Window
    {
        public CustomerDetails()
        {
            InitializeComponent();
            retrievCustomers();
        }
        public void retrievCustomers()
        {
            FirstContext Customer_repo = new FirstContext();
            var temp_customer = Customer_repo.QRCodes.ToList();
            UserGrid.ItemsSource = temp_customer;
        }
        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            ShopDashBoard shopDash = new ShopDashBoard();
            shopDash.Show();
            this.Hide();
        }

        private void CustomerGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UserGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
