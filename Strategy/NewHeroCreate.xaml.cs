using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public int vr;
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
            vr = 1;
            Warrior war = new Warrior(30, 15, 10, 25, 250, 80, 50, 10, 0, 0);

            war.Strength  = 30;
            war.Dexterity = 15;
            war.Inteligence = 10;
            war.Vitality = 25;
            war.Health= 0;
            war.Mana = 0;

            StrBox.Content = war.Strength;
            DexBox.Content = war.Dexterity;
            IntBox.Content = war.Inteligence;
            VitBox.Content = war.Vitality;
            HealBox.Content = war.Strength + war.Vitality * 2;
            ManaBox.Content = war.Inteligence;

           
        }

        private void Rogue_Create(object sender, RoutedEventArgs e)
        {
            vr = 2;
            Heroes hero = new Heroes(20, 30, 15, 20, 65, 250, 70, 80,0,0);
            hero.Strength = 20;
            hero.Dexterity = 30;
            hero.Inteligence = 15;
            hero.Vitality = 20;
            hero.Health = 0;
            hero.Mana = 0;

            
            StrBox.Content = hero.Strength;
            DexBox.Content = hero.Dexterity;
            IntBox.Content = hero.Inteligence;
            VitBox.Content = hero.Vitality;
            HealBox.Content = 0.5 *hero.Strength + hero.Vitality * 1.5;
            ManaBox.Content = hero.Inteligence;



        }

        private void Wizard_Create(object sender, RoutedEventArgs e)
        {
            
        }

        private void StrPls_Click(object sender, RoutedEventArgs e)
        {
            if (vr == 1)
            {
                Warrior war = new Warrior(30, 15, 10, 25, 250, 80, 50, 10, 0, 0);
                war.Strength = 30;
                war.Dexterity = 15;
                war.Inteligence = 10;
                war.Vitality = 25;
                war.Health = 0;
                war.Mana = 0;



                war.Strength = war.Strength + 1;
                StrBox.Content = war.Strength;
                a = a +1;
                StrBox.Content = a;
            }
             else if (vr == 2)
            {

            }
            else if(vr == 3)
            {

            }
        }
int a = 0;

        /*Warrior warrior = new Warrior(int Strength, Dexterity, Inteligence, Vitality, MaxStrength, MaxDexterity, MaxInteligence, MaxVitality*/

        //ManaBox.Content = hero.Mana;
    }    
        //    public int Health { get; set; }
        //public int Vitality { get; set; }
     

    
        

        

       
}
