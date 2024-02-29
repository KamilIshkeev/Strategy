using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Heroes
    {



        public double Strength { get; set; }
        public double Dexterity { get; set; }
        public double Inteligence;
        public double Vitality;
        public int MaxStrength;
        public int MaxDexterity;
        public int MaxInteligence;
        public int MaxVitality;

        public double Health { get; set; }
        public double Mana { get; set; }

        public int PhysDam;
        public int Armor;
        public int MagDam;
        public int MagDef;
        public int CrtChanse;
        public int CrtDam;

        public Heroes(double strength, double dexterity, double inteligence, double vitality, double health, double mana/*, int PhysDam, int Armor, int MagDam, int MagDef, int CrtChanse, int CrtDam*/, double strenght)
        {

             Strength = strenght;
            
            Dexterity = dexterity;
            Inteligence = inteligence;
            Vitality = vitality;
            

            Health = health;
            Mana = mana;
        }

        //public void PlsStr()
        //{
        //    int a = Strength + 1;
        //}


        //public int Health();



            //this.Armor = Armor;
            //this.MagDam = MagDam;
            //this.MagDef = MagDef;
            //this.Health = Health;
            //this.PhysDam = PhysDam;
            //this.CrtChanse = CrtChanse;
            //this.CrtDam = CrtDam;


    public void LevelUp()
    {
            
    }
       
   


     






 }



    }
    






