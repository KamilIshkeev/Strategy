using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Equipment
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public int Strength { get; set; }

        public int HealthUp { get; set; }
        public int RequiredLevel { get; set; }
        public int DexterityE { get; set; }

        public Equipment(string name, string type, int strength, int healthUp, int requiredLevel, int dexterityE)
        {
            Name = name;
            Type = type;
            Strength = strength;
            HealthUp = healthUp;
            RequiredLevel = requiredLevel;
            DexterityE = dexterityE;



        }

        //int a ;
        //public void TypeTo()
        //{

        //    if (Type == 1) { }
        //    if (Type == 2) 
        //    {
        //        DexterityE = DexterityE + 1;

        //    }

        //    if (Type == 3)
        //    {
        //        DexterityE = DexterityE + 2;

        //    }

        //}



    }
}
