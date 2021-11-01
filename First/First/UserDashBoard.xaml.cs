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
    /// Interaction logic for UserDashBoard.xaml
    /// </summary>
    public partial class UserDashBoard : Window
    {
        public UserDashBoard()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            LoginUser loginUser = new LoginUser();
            loginUser.Show();
            this.Hide();
        }

        private void btnSeeQR_Click(object sender, RoutedEventArgs e)
        {
            SelectQR selectQR = new SelectQR();
            selectQR.Show();
            this.Hide();
        }
    }
}
