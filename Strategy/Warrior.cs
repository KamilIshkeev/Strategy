using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Warrior : Heroes
    {
       //public override int Health 
       //     {
       //     get
        
        public Warrior(int Strength, int Dexterity, int Inteligence, int Vitality, int MaxStrength, int MaxDexterity, int MaxInteligence, int MaxVitality, int Health, int Mana/*, int PhysDam, int Armor, int MagDam, int MagDef, int CrtChanse, int CrtDam*/) : base(Strength, Dexterity, Inteligence, Vitality, MaxStrength, MaxDexterity, MaxInteligence, MaxVitality, Health, Mana)
        {
            Strength = 30;
            Dexterity = 15;
            Inteligence = 10;
            Vitality = 25;
            MaxStrength = 250;
            MaxDexterity = 80;
            MaxInteligence = 50;
            MaxVitality = 100;

            Health = Vitality * 2;
            Mana = Inteligence;



            //PhysDam = Strength;


        }
    
    }

}
