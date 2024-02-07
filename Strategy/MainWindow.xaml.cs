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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;
            MainMenu p2 = new MainMenu();
            OurFrame.NavigationService.Navigate(p2);
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            


        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService m = NavigationService.GetNavigationService(this);
            //MainMenu.Navigate(new Uri("Enter.xaml", UriKind.Relative));
            //MainMenu MaMe = new MainMenu();
            //EnterFr.NavigationService.Navigate(MaMe);
        }

        private void Frame_Navigated(object sender, NavigationEventArgs e)
        {
            
        }
    }
}
