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
using _06._09._2024_Smirnov_Andreew_wpf_sqlite.Class;

namespace _06._09._2024_Smirnov_Andreew_wpf_sqlite.Pages
{
    /// <summary>
    /// Логика взаимодействия для RedactUser.xaml
    /// </summary>
    public partial class RedactUser : Page
    {
        private User _user { get; set; }
        public RedactUser(User user)
        {
            this._user = user;
            InitializeComponent();
            txtNameUser.Text = user.Name;
            txtAgeUser.Text = Convert.ToString(user.Age);
        }

        private void btnSavechangesRedact_Click(object sender, RoutedEventArgs e)
        {
            _user.Name = txtNameUser.Text;
            _user.Age = Convert.ToInt32(txtAgeUser.Text);
            using (ApplicationContext zxc = new ApplicationContext())
            {
                zxc.Users.Update(_user);
                zxc.SaveChanges();
            }
            MessageBox.Show("Пользователь изменён");
        }

        private void btnBackRedact_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Glav());
        }
    }
}
