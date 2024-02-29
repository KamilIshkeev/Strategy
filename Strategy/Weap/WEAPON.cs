using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Weap
{
    internal class WEAPON
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public string DamageType { get; set; }
        public int PDamage { get; set; }
        public int ManaAP { get; set; }
        public int Strength { get; set; }
        
        public int IntelligenceUp { get; set; }
        public int MagicCritChance { get; set; }
        public int MagicCritDamage { get; set; }
       
        //public string DoubleStrike { get; set; }
        public int CritChance { get; set; }
        public int CritDamage { get; set; }
        public int Dexterity { get; set; }

        public WEAPON(string name, string type, string damageType, int pdamage, int manaAP, int strength, int intelligenceUp, int magicCritChance, int magicCritDamage, int critChance, int critDamage, int dexterity)
        {
            Name = name;
            Type = type;
            DamageType = damageType;
            PDamage = pdamage;
            ManaAP = manaAP;
            Strength = strength;
            IntelligenceUp = intelligenceUp;
            MagicCritChance = magicCritChance;
            MagicCritDamage = magicCritDamage;
          
            CritChance = critChance;
            CritDamage = critDamage;
            Dexterity = dexterity;

        }
    }

}
