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
    /// Interaction logic for LoginUser.xaml
    /// </summary>
    public partial class LoginUser : Window
    {
        public LoginUser()
        {
            InitializeComponent();
        }

       
        private void btnNewUser_Click(object sender, RoutedEventArgs e)
        {
            Customer_Create_QR customer_Create_QR = new Customer_Create_QR();
            customer_Create_QR.Show();
            this.Hide();
        }

        FirstContext Login_repo = new FirstContext();
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            if (Login_repo.UserLogins.Where(r => r.UserName == txtUser.Text && r.Password == txtPassword.Password).Count() > 0)
            {
                UserDashBoard userDashBoard = new UserDashBoard();
                userDashBoard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error: invalid username or password");
            }

           
        }
    }
}
