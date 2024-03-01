using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Strategy.Weap
{
    internal class Staff : WEAPON
    {
        public Staff(string name, int type, string damageType, int pdamage, int manaAP, int strength, int magicCrit, int intelligenceUp, int magicCritChance, int magicCritDamage, int agility, int critChance, int critDamage, int dexterity) : base("Staff of the Storm", 3, "A", 4, 8, 10, 15, 20, 30, 0, 0, 0)
        {
            Name = name;
            Type = type;
            PDamage = pdamage;
            ManaAP = manaAP;
            IntelligenceUp = intelligenceUp;
            MagicCritChance = magicCritChance;
            MagicCritDamage = magicCritDamage;
        }
    }
}
