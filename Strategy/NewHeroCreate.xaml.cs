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
            //Heroes war = new Heroes(30, 15, 10, 25, 250, 80, 50, 10, 0, 0);

            Strength1 = 30;
            Dexterity1 = 15;
            Inteligence1 = 10;
            Vitality1 = 25;
            Health1 = 0;
            Mana1 = 0;

            
            StrBox.Content = Strength1;
            DexBox.Content = Dexterity1;
            IntBox.Content = Inteligence1;
            VitBox.Content = Vitality1;
            HealBox.Content = Strength1 + Vitality1 * 2;
            ManaBox.Content = Inteligence1;

           
        }

        private void Rogue_Create(object sender, RoutedEventArgs e)
        {
            vr = 2;
            //Heroes hero = new Heroes(20, 30, 15, 20, 65, 250, 70, 80,0,0);
            //hero.Strength = 20;
            //hero.Dexterity = 30;
            //hero.Inteligence = 15;
            //hero.Vitality = 20;
            //hero.Health = 0;
            //hero.Mana = 0;


            Strength2 = 20;
            Dexterity2 = 30;
            Inteligence2 = 15;
            Vitality2 = 20;
            Health2 = 0;
            Mana2 = 0;

            
            StrBox.Content = Strength2;
            DexBox.Content = Dexterity2;
            IntBox.Content = Inteligence2;
            VitBox.Content = Vitality2;
            HealBox.Content = 0.5 *Strength2 + Vitality2 * 1.5;
            ManaBox.Content = Inteligence2;
          



        }

        private void Wizard_Create(object sender, RoutedEventArgs e)
        {
            vr = 3;
            Strength3 = 30;
            Dexterity3 = 15;
            Inteligence3 = 10;
            Vitality3 = 25;
            Health3 = 0;
            Mana3 = 0;

            StrBox.Content = Strength3;
            DexBox.Content = Dexterity3;
            IntBox.Content = Inteligence3;
            VitBox.Content = Vitality3;
            HealBox.Content = 0.5 * Strength3 + Vitality3 * 1.5;
            ManaBox.Content = Inteligence3;
        }

        int Strength2 = 20;
        int Dexterity2 = 30;
        int Inteligence2 = 15;
        int Vitality2 = 20;
        int Health2 = 0;
        int Mana2 = 0;

       
        int Strength1 = 30;
        int Dexterity1 = 15;
        int Inteligence1 = 10;
        int Vitality1 = 25;
        int Health1 = 0;
        int Mana1 = 0;

        int Strength3 = 30;
        int Dexterity3 = 15;
        int Inteligence3 = 10;
        int Vitality3 = 25;
        int Health3 = 0;
        int Mana3 = 0;

       

        private void StrPls_Click(object sender, RoutedEventArgs e)
        {
            if (vr == 1)
            {

                Strength1 +=1;
                StrBox.Content = Strength1;

            }
            else if (vr == 2)
            {
                Strength2 += 1;
                StrBox.Content = Strength2;
            }
            else if(vr == 3)
            {
                Strength3 += 1;
                StrBox.Content = Strength3;
            }
            
        }

       
        



      
    }    
        
     

    
        

        

       
}
