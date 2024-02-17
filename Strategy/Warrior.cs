using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Converters;

namespace Strategy
{
    internal class Warrior : Heroes
    {
       //public override int Health 
       //     {
       //     get
        
        public  Warrior(int strength, int dexterity, int inteligence, int vitality, int maxstrength, int maxdexterity, int maxinteligence, int maxvitality, int health, int mana/*, int PhysDam, int Armor, int MagDam, int MagDef, int CrtChanse, int CrtDam*/) : base(strength, dexterity, inteligence, vitality, maxstrength, maxdexterity, maxinteligence, maxvitality, health, mana)
        {
            strength = Strength;
            dexterity = Dexterity;
            inteligence = Inteligence;
            vitality = Vitality;
            maxstrength = MaxStrength;
            maxdexterity = MaxDexterity;
            maxinteligence = MaxInteligence;
            maxvitality = MaxVitality;

            Health = Health;
            Mana = Mana;



            //PhysDam = Strength;


        }
    
    }

}
