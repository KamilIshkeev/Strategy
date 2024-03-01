using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Strategy.Weap
{
    internal class Dagger : WEAPON
    {

        public Dagger(string name, int type, string damageType, int pdamage, int manaAP, int strength, int magicCrit, int intelligenceUp, int magicCritChance, int magicCritDamage, int agility, int critChance, int critDamage, int dexterity) : base("sharp dagger", 1, "A", 8, 0, 0, 0, 0, 0, 30, 35, 12)
        {
            Name = name;
            Type = type;
            PDamage = pdamage;
            CritChance = critChance;
            CritDamage = critDamage;
            Dexterity = dexterity;
        }

    }
}
