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
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            SelectCharWin p3 = new SelectCharWin();
            this.NavigationService.Navigate(p3);
        }
    }
}
