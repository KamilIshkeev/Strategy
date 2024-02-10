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
    /// Логика взаимодействия для NewHeroCreate.xaml
    /// </summary>
    public partial class NewHeroCreate : Page
    {
        public NewHeroCreate() 
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            SelectCharWin p4 = new SelectCharWin();
            this.NavigationService.Navigate(p4);
        }

        private void Warrior_Create(object sender, RoutedEventArgs e)
        {
            //Warrior warrior = new Warrior(30, 15, 10, 25, 250, 80, 50, 100);
            Heroes hero = new Heroes(30, 15, 10, 25, 250, 80, 50, 100,150,200);
            hero.Health = hero.Vitality * 2;
            StrBox.Content = hero.MaxStrength;
            DexBox.Content = hero.Dexterity;
            IntBox.Content = hero.Inteligence;
            VitBox.Content = hero.Vitality;
            HealBox.Content = hero.Health;
            ManaBox.Content = hero.Mana;

        }
        

        private void Rogue_Create(object sender, RoutedEventArgs e)
        {
            Heroes hero = new Heroes(30, 15, 10, 25, 250, 80, 50, 100, 150, 200);

            StrBox.Content = hero.MaxStrength;
            DexBox.Content = hero.Dexterity;
            IntBox.Content = hero.Inteligence;
            VitBox.Content = hero.Vitality;
            HealBox.Content = hero.Health;
            ManaBox.Content = hero.Mana;
        }

        private void Wizard_Create(object sender, RoutedEventArgs e)
        {

        }
    }
}
