using First.Database;
using First.Model;
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
    /// Interaction logic for ShopAccount.xaml
    /// </summary>
    public partial class ShopAccount : Window
    {
        public ShopAccount()
        {
            InitializeComponent();
        }

        private void btnAddNewUser_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Data inserted Succsesfully");

            using (FirstContext context = new FirstContext())
            {

               
                Shop temp_shop = new Shop()
                {
                    ShopName = shop_name.Text,
                    ShopCategory = shop_category.Text,
                    ContactNo = Convert.ToInt32(contact_no.Text),
                    Email = email.Text,

                };

                Address temp_address = new Address()
                {
                    No = no.Text,
                    Street = street.Text,
                    City1 = city1.Text,
                    City2 = city2.Text,
                };
                UserLogin user_Login = new UserLogin()
                {
                    UserName = usernameShop.Text,
                    Password = passwordShop.Text,

                };

                temp_shop.Address = temp_address;
                context.UserLogins.Add(user_Login);
                context.Shops.Add(temp_shop);
                context.Addresses.Add(temp_address);
                context.SaveChanges();


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            LoginShop loginShop = new LoginShop();
            loginShop.Show();
            this.Hide();
        }
    }
}

