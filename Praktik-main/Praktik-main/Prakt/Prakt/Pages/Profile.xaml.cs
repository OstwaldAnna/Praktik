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

namespace Prakt.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProFile.xaml
    /// </summary>
    public partial class ProFile : Page
    {
        public ProFile()
        {
            InitializeComponent();
        }

       

        private void My_articles_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Articles());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Add());
        }

        private void Shoops_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Profile());
        }

        private void Notes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Favorites());
        }
    }
}
