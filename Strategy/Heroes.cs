using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Heroes   
    {
        public int Strength;
        public int Dexterity;
        public int Inteligence;
        public int Vitality;
        public int MaxStrength;
        public int MaxDexterity;
        public int MaxInteligence;
        public int MaxVitality;

        public int Health;
        public int Mana;

        public int PhysDam;
        public int Armor;
        public int MagDam;
        public int MagDef;
        public int CrtChanse;
        public int CrtDam;

        public Heroes (int Strength, int Dexterity, int Inteligence, int Vitality, int MaxStrength, int MaxDexterity, int MaxInteligence, int MaxVitality/*, int Health, int Mana, int PhysDam, int Armor, int MagDam, int MagDef, int CrtChanse, int CrtDam*/) 
        { 
        
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Inteligence = Inteligence;
            this.Vitality = Vitality;
            this.MaxStrength = MaxStrength;
            this.MaxDexterity = MaxDexterity;
            this.MaxInteligence = MaxInteligence;
            this.MaxVitality = MaxVitality;
            //this.Armor = Armor;  
            //this.MagDam = MagDam;
            //this.MagDef = MagDef;
            //this.Health = Health;
            //this.PhysDam = PhysDam;
            //this.Armor = Armor;
            //this.CrtChanse = CrtChanse;
            //this.CrtDam = CrtDam;


            
        }




        public virtual void lvl_Up()
        {

        }









    }
    





}
