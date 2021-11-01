using First.Database;
using First.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for PersonalAccount.xaml
    /// </summary>
    public partial class PersonalAccount : Window
    {
        public PersonalAccount()
        {
            InitializeComponent();
        }



        private void btnAddNewUser_Click(object sender, RoutedEventArgs e)
        {
            

            using (FirstContext context = new FirstContext())
            {

                User temp_user = new User()
                {
                    FirstName = first_name.Text,
                    LastName = last_name.Text,
                    MobileNo = Convert.ToInt32(mobile_no.Text),
                    NIC_NO = nic_no.Text,


                };
                           
                Address temp_address = new Address()
                {
                    No = no.Text,
                    Street = street.Text,
                    City1 = city1.Text,
                    City2 = city2.Text,


                };


                string img = "";
                OpenFileDialog file_select = new OpenFileDialog();
                if (file_select.ShowDialog() == true)
                {
                    img = file_select.FileName;
                }
               
                    QRCode temp_qrcode = new QRCode()

                    {

                        ImageToByte = File.ReadAllBytes(img)

                    };

                UserLogin user_Login1 = new UserLogin()
                {
                    UserName = username.Text,
                    Password = password.Text,

                };
                temp_user.QRCode = temp_qrcode;
                temp_user.Address = temp_address;
                context.UserLogins.Add(user_Login1);
                context.QRCodes.Add(temp_qrcode);
                context.Users.Add(temp_user);           
                context.Addresses.Add(temp_address);
                context.SaveChanges();

                 

            }
            MessageBox.Show("Data inserted Succsesfully");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            LoginUser loginUser = new LoginUser();
            loginUser.Show();
            this.Hide();

        }

        private void username_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}

