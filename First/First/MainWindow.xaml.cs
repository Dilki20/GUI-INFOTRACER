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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace First
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

       

        private void btnShop_Click(object sender, RoutedEventArgs e)
        {
            LoginShop login2 = new LoginShop();
            login2.Show();
            this.Hide();
        }

        private void btnPersonal_Click(object sender, RoutedEventArgs e)
        {
            LoginUser login1 = new LoginUser();
            login1.Show();
            this.Hide();
        }
    }
}
