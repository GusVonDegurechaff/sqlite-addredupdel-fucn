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
    /// Логика взаимодействия для Glav.xaml
    /// </summary>
    public partial class Glav : Page
    {
        public List<User> users = new List<User>();
        public Glav()
        {
            using(ApplicationContext zxc = new ApplicationContext())
            {
                users = zxc.Users.ToList();
            }
            InitializeComponent();
            dtgUsers.ItemsSource = users;
        }

        private void btnRedactUsers_Click(object sender, RoutedEventArgs e)
        {
            var userForRedact = dtgUsers.SelectedItem as User;
            NavigationService.Navigate(new RedactUser(userForRedact));
        }

        private void btnCreateUsers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateUsers());
        }

        private void btnDeleteUsers_Click(object sender, RoutedEventArgs e)
        {
            List<User> usersForRemoving = dtgUsers.SelectedItems.Cast<User>().ToList();
            if(usersForRemoving.Count > 0 )
            {
                foreach( User user in usersForRemoving )
                {
                    using(ApplicationContext zxc = new ApplicationContext())
                    {
                        zxc.Users.Remove(user);
                        zxc.SaveChanges();
                    }
                }
                using (ApplicationContext zxc = new ApplicationContext())
                {
                    dtgUsers.ItemsSource = zxc.Users.ToList();
                }
                MessageBox.Show($"Выбранные пользователи({usersForRemoving.Count}) удалены");
            }
            else 
            {
                MessageBox.Show("Вы не выбрали ни одного пользователя");
            }
        }
    }
}
