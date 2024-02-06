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

namespace Strategy
{
    /// <summary>
    /// Логика взаимодействия для SelectCharWin.xaml
    /// </summary>
    public partial class SelectCharWin : Page
    {
        public SelectCharWin()
        {
            InitializeComponent();
        }

        private void NewHero_Click(object sender, RoutedEventArgs e)
        {
            NewHeroCreate p4 = new NewHeroCreate();
            this.NavigationService.Navigate(p4);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainMenu p1 = new MainMenu();
            this.NavigationService.Navigate(p1);
        }
    }
}
