using Demo_Demo.DB;
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
using Demo_Demo.DB;

namespace Demo_Demo.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServiceListPage.xaml
    /// </summary>
    public partial class ServiceListPage : Page
    {
        public static List<DB.Service> services { get; set; }
        public ServiceListPage( int a)
        {

            InitializeComponent();
            if ( a== 0)
            {
                AddBt.Visibility = Visibility.Hidden;
                RedactBt.Visibility = Visibility.Hidden;
                
            }
            services = DBConnection.demostrationdb.Service.ToList();
            ServicesLV.ItemsSource = services;

        }

        private void ServicesLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddBt_Click(object sender, object e)
        {
            NavigationService.Navigate(new RedactServicesPage() );
        }

        private void RedactBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RedactServicesPage());

        }
    }
}
