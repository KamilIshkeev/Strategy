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
using static System.Net.Mime.MediaTypeNames;

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
        int lvl= 1 ;
        int text = 0;
        

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            //text = Convert.ToInt32(LevlBox.Text);
            text = Convert.ToInt32(LevlBox.Text);

            //text = int.Parse(LevlBox.Text);

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            SelectCharWin p4 = new SelectCharWin();
            this.NavigationService.Navigate(p4);
        }

        private void Warrior_Create(object sender, RoutedEventArgs e)
        {
            vr = 1;
            Wir.Visibility = Visibility.Visible;
            Rog.Visibility = Visibility.Hidden;
            Wiz.Visibility = Visibility.Hidden;
            
            LevelBox.Content = 1;
            LevelBox.Content = lvl;
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

            Health1 = Strength1 + Vitality1 * 2;
            Mana1 = Inteligence1;
        }

        private void Rogue_Create(object sender, RoutedEventArgs e)
        {
            vr = 2;
            //Heroes hero = new Heroes(20, 30, 15, 20, 65, 250, 70, 80, 0, 0);
            //hero.Strength = 20;
            //hero.Dexterity = 30;
            //hero.Inteligence = 15;
            //hero.Vitality = 20;
            //hero.Health = 0;
            //hero.Mana = 0;
           
            LevelBox.Content = 1;
            LevelBox.Content = lvl;
            Wir.Visibility = Visibility.Hidden;
            Rog.Visibility = Visibility.Visible;
            Wiz.Visibility = Visibility.Hidden;
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


            Health2 = 0.5 * Strength2 + Vitality2 * 1.5;
            Mana2 = 1.2 * Inteligence2;
        }

        private void Wizard_Create(object sender, RoutedEventArgs e)
        {

           
            LevelBox.Content = 1;
            LevelBox.Content = lvl;
            Wir.Visibility = Visibility.Hidden;
            Rog.Visibility = Visibility.Hidden;
            Wiz.Visibility = Visibility.Visible;
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

            Health3 = 0.2 * Strength3 + Vitality3 * 1.4;
            Mana3 = 1.5 * Inteligence3;
        }

        double Strength2 = 20;
        int Dexterity2 = 30;
        int Inteligence2 = 15;
        int Vitality2 = 20;
        double Health2 = 0;
        double Mana2 = 0;

       
        double Strength1 = 30;
        int Dexterity1 = 15;
        int Inteligence1 = 10;
        int Vitality1 = 25;
        double Health1 = 0;
        double Mana1 = 0;

        double Strength3 = 30;
        int Dexterity3 = 15;
        int Inteligence3 = 10;
        int Vitality3 = 25;
        double Health3 = 0;
        double Mana3 = 0;



        int t = 10;




               

                



        private void StrPls_Click(object sender, RoutedEventArgs e)
        {
            if (vr == 1)
            { 
                if (Strength1 < 250)
                { 
                 Strength1 += 1;
                 StrBox.Content = Strength1;
                 text -= 1;
                 LevlBox.Text = Convert.ToString(text);
                    Health1 += 1;
                    HealBox.Content = Health1;

                }
                else if(Strength1 >250)
                {
                    StrBox.Content = 250;
                }
               
                
            
            }
            else if (vr == 2)
            {
                if (Strength2 < 65)
                {
                Strength2 += 1;
                StrBox.Content = Strength2;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                }
                else if (Strength2 > 65)
                {
                    StrBox.Content = 65;
                }
                
                
            }
            else if(vr == 3)
            {
                if (Strength3 < 45)
                {
                Strength3 += 1;
                StrBox.Content = Strength3;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                }
                else if (Strength3 > 45)
                {
                    StrBox.Content = 45;
                }
                
                
                
            }
            
        }

        private void DexPls_Click(object sender, RoutedEventArgs e)
        {
            if (vr == 1)
            {
                if (Dexterity1 < 80)
                {
                Dexterity1 += 1;
                DexBox.Content = Dexterity1;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                }
                else if (Dexterity1 > 80)
                {
                    DexBox.Content = 80;
                }
               

            }
            else if (vr == 2)
            {
                if (Dexterity2 < 250)
                {
                Dexterity2 += 1;
                DexBox.Content = Dexterity2;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                }
                else if (Dexterity2 > 250)
                {
                    DexBox.Content = 250;
                }
                
            }
            else if (vr == 3)
            {
                if (Dexterity3 < 80)
                {
                Dexterity3 += 1;
                DexBox.Content = Dexterity3;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                }
                else if (Dexterity3 > 80)
                {
                   DexBox.Content = 80;
                }
                
            }
        }

        private void IntPls_Click(object sender, RoutedEventArgs e)
        {
            if (vr == 1)
            {
                if (Inteligence1 < 50)
                {
                Inteligence1 += 1;
                IntBox.Content = Inteligence1;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                    Mana1 += 1;
                    ManaBox.Content = Mana1;
                }
                else if (Inteligence1 > 50)
                {
                    IntBox.Content = 50;
                    
                }
           
            }
            else if (vr == 2)
            {
                if (Inteligence2 < 70)
                {
                Inteligence2 += 1;
                IntBox.Content = Inteligence2;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                    Mana2 += 1.2;
                    ManaBox.Content = Mana2;
                }
                else if (Inteligence2 > 70)
                {
                    IntBox.Content = 70;
                }
               
            }
            else if (vr == 3)
            {
                if (Inteligence3 < 250)
                {
                Inteligence3 += 1;
                IntBox.Content = Inteligence3;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                    Mana3 += 1.5;
                    ManaBox.Content = Mana3;
                }
                else if (Inteligence3 > 250)
                {
                    IntBox.Content = 250;
                }
                
            }
        }

        private void VitPls_Click(object sender, RoutedEventArgs e)
        {
            if (vr == 1)
            {
                if (Vitality1 < 100)
                {
                Vitality1 += 1;
                VitBox.Content = Vitality1;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);

                    Health1 += 2;
                    HealBox.Content = Health1;
                }
                else if (Vitality1 > 100)
                {
                    VitBox.Content = 100;
                }
               

            }
            else if (vr == 2)
            {
                if (Vitality2 < 80)
                {
                Vitality2 += 1;
                VitBox.Content = Vitality2;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                }
                else if (Vitality2 > 80)
                {
                    VitBox.Content = 80;
                }
               
            }
            else if (vr == 3)
            {
                if (Vitality3 < 70)
                {
                Vitality3 += 1;
                VitBox.Content = Vitality3;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                }
                else if (Vitality3 > 70)
                {
                    VitBox.Content = 70;
                }
                
            }
        }

        private void HPPls_Click(object sender, RoutedEventArgs e)
        {
            if (vr == 1)
            {
                if (Health1 < 100)
                {
                Health1 += 1;
                HealBox.Content = Health1;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                }
                else if (Health1 > 100)
                {
                    HealBox.Content = 100;
                }
                

            }
            else if (vr == 2)
            {
                if (Health2 < 100)
                {
                Health2 += 1;
                HealBox.Content = Health2;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                }
                else if (Health2 > 100)
                {
                    HealBox.Content = 100;
                }
               
            }
            else if (vr == 3)
            {
                if (Health3 < 100)
                {
                Health3 += 1;
                HealBox.Content = Health3;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                }
                else if (Health3 > 100)
                {
                    HealBox.Content = 100;
                }
                
            }
        }

        private void MPPls_Click(object sender, RoutedEventArgs e)
        {
            if (vr == 1)
            {
                if (Mana1 < 200)
                {
                Mana1 += 1;
                ManaBox.Content = Mana1;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                }
                else if (Mana1 > 200)
                {
                    ManaBox.Content = 200;
                }
                
            }
            else if (vr == 2)
            {
                if (Mana2 < 200)
                {
                Mana2 += 1;
                ManaBox.Content = Mana2;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                }
                else if (Mana2 > 200)
                {
                    ManaBox.Content = 200;
                }
               
            }
            else if (vr == 3)
            {
                if (Mana3 < 300)
                {
                Mana3 += 1;
                ManaBox.Content = Mana3;
                text -= 1;
                LevlBox.Text = Convert.ToString(text);
                }
                else if (Mana3 > 300)
                {
                    ManaBox.Content = 300;
                }
             
            }
        }

        private void Str10Pls_Click(object sender, RoutedEventArgs e)
        {

            if (vr == 1)
            {
                if (Strength1 < 250)
                {
                    Strength1 += 10;
                    StrBox.Content = Strength1;
                    text -= 10;
                    LevlBox.Text = Convert.ToString(text);


                }
                else if (Strength1 > 250)
                {
                    StrBox.Content = 250;
                }



            }
            else if (vr == 2)
            {
                if (Strength2 < 65)
                {
                    Strength2 += 10;
                    StrBox.Content = Strength2;
                    text -= 10;
                    LevlBox.Text = Convert.ToString(text);
                }
                else if (Strength2 > 65)
                {
                    StrBox.Content = 65;
                }


            }
            else if (vr == 3)
            {
                if (Strength3 < 45)
                {
                    Strength3 += 10;
                    StrBox.Content = Strength3;
                    text -= 10;
                    LevlBox.Text = Convert.ToString(text);
                }
                else if (Strength3 > 45)
                {
                    StrBox.Content = 45;
                }



            }

        }

        private void Dex10Pls_Click(object sender, RoutedEventArgs e)
        {

            if (vr == 1)
            {
                if (Dexterity1 < 80)
                {
                    Dexterity1 += 10;
                    DexBox.Content = Dexterity1;
                    text -= 10;
                    LevlBox.Text = Convert.ToString(text);
                }
                else if (Dexterity1 > 80)
                {
                    DexBox.Content = 80;
                }


            }
            else if (vr == 2)
            {
                if (Dexterity2 < 250)
                {
                    Dexterity2 += 10;
                    DexBox.Content = Dexterity2;
                    text -= 10;
                    LevlBox.Text = Convert.ToString(text);
                }
                else if (Dexterity2 > 250)
                {
                    DexBox.Content = 250;
                }

            }
            else if (vr == 3)
            {
                if (Dexterity3 < 80)
                {
                    Dexterity3 += 10;
                    DexBox.Content = Dexterity3;
                    text -= 10;
                    LevlBox.Text = Convert.ToString(text);
                }
                else if (Dexterity3 > 80)
                {
                    DexBox.Content = 80;
                }

            }

        }

        private void Int10Pls_Click(object sender, RoutedEventArgs e)
        {
            if (vr == 1)
            {
                if (Inteligence1 < 50)
                {
                    Inteligence1 += 10;
                    IntBox.Content = Inteligence1;
                    text -= 10;
                    LevlBox.Text = Convert.ToString(text);
                }
                else if (Inteligence1 > 50)
                {
                    IntBox.Content = 50;
                }


            }
            else if (vr == 2)
            {
                if (Inteligence2 < 70)
                {
                    Inteligence2 += 10;
                    IntBox.Content = Inteligence2;
                    text -= 10;
                    LevlBox.Text = Convert.ToString(text);
                }
                else if (Inteligence2 > 70)
                {
                    IntBox.Content = 70;
                }

            }
            else if (vr == 3)
            {
                if (Inteligence3 < 250)
                {
                    Inteligence3 += 10;
                    IntBox.Content = Inteligence3;
                    text -= 10;
                    LevlBox.Text = Convert.ToString(text);
                }
                else if (Inteligence3 > 250)
                {
                    IntBox.Content = 250;
                }

            }
        }

        private void Vit10Pls_Click(object sender, RoutedEventArgs e)
        {

            if (vr == 1)
            {
                if (Vitality1 < 100)
                {
                    Vitality1 += 10;
                    VitBox.Content = Vitality1;
                    text -= 10;
                    LevlBox.Text = Convert.ToString(text);
                }
                else if (Vitality1 > 100)
                {
                    VitBox.Content = 100;
                }


            }
            else if (vr == 2)
            {
                if (Vitality2 < 80)
                {
                    Vitality2 += 10;
                    VitBox.Content = Vitality2;
                    text -= 10;
                    LevlBox.Text = Convert.ToString(text);
                }
                else if (Vitality2 > 80)
                {
                    VitBox.Content = 80;
                }

            }
            else if (vr == 3)
            {
                if (Vitality3 < 70)
                {
                    Vitality3 += 10;
                    VitBox.Content = Vitality3;
                    text -= 10;
                    LevlBox.Text = Convert.ToString(text);
                }
                else if (Vitality3 > 70)
                {
                    VitBox.Content = 70;
                }

            }

        }

      


    }    
        
     

    
        

        

       
}
