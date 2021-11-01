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
    /// Interaction logic for LoginShop.xaml
    /// </summary>
    public partial class LoginShop : Window
    {
        public LoginShop()
        {
            InitializeComponent();
        }

        private void btnsNewAccountShop_Click(object sender, RoutedEventArgs e)
        {
            ShopAccount log = new ShopAccount();
            log.Show();
            this.Hide();
        }

        private void btnDash2_Click(object sender, RoutedEventArgs e)
        {
            Shop_Scan_QR scanQR = new Shop_Scan_QR();
            scanQR.Show();
            this.Hide();
        }

        FirstContext Login_repo = new FirstContext();

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(Login_repo.UserLogins.Where(r=>r.UserName == txtUser.Text && r.Password == txtPassword.Password).Count() > 0)
            {
                ShopDashBoard shopDashBoard = new ShopDashBoard();
                shopDashBoard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error: invalid username or password");
            }
           
        }

        private void btnNewUser_Click(object sender, RoutedEventArgs e)
        {
            ShopAccount shopAccount = new ShopAccount();
            shopAccount.Show();
            this.Hide();
        }
    }
}
