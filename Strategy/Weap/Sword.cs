using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Weap
{
    internal class Sword : WEAPON
    {

        public Sword(string name, string type, string damageType, int pdamage, int manaAP, int strength, int magicCrit, int intelligenceUp, int magicCritChance, int magicCritDamage, int agility, int critChance, int critDamage, int dexterity) : base("The sword of the wind", "Common", "A", 8, 0, 10, 0, 0, 0, 40, 40, 5)
        {
            Name = name;
            Type = type;
            PDamage = pdamage;
            Strength = strength;
            CritChance = critChance;
            CritDamage = critDamage;
            Dexterity = dexterity;
        }

    }
}
