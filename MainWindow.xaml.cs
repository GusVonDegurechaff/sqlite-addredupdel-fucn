using _06._09._2024_Smirnov_Andreew_wpf_sqlite.Class;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _06._09._2024_Smirnov_Andreew_wpf_sqlite.Pages;

namespace _06._09._2024_Smirnov_Andreew_wpf_sqlite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrmMain.Navigate(new Glav());
        }

        private void btnCreateUsers_Click(object sender, RoutedEventArgs e)
        {
            {
                
            }
        }

        private void btnDeleteUsers_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}