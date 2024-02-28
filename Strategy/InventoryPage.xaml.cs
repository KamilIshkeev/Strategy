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
    /// Логика взаимодействия для InventoryPage.xaml
    /// </summary>
    public partial class InventoryPage : Page
    {
        public InventoryPage()
        {
            InitializeComponent();

            

        }

        public void Geroin()
        {
            NewHeroCreate NHC = new NewHeroCreate();
            
            if (NHC.vr == 1 ) 
            {
                Wir.Visibility = Visibility.Visible;
                Rog.Visibility = Visibility.Hidden;
                Wiz.Visibility = Visibility.Hidden;
            }

            if (NHC.vr == 2)
            {
                Wir.Visibility = Visibility.Visible;
                Rog.Visibility = Visibility.Hidden;
                Wiz.Visibility = Visibility.Hidden;
            }

            if (NHC.vr == 3)
            {
                Wir.Visibility = Visibility.Visible;
                Rog.Visibility = Visibility.Hidden;
                Wiz.Visibility = Visibility.Hidden;
            }
        }

    
    
    
    }
}
