using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Strategy.equip
{
    internal class Robe : Equipment
    {
        public Robe(string name, string type, int strength, int healthUp, int requiredLevel, int dexterity) : base("firefighter's robe", "Common", 25, 10,5,0)
        {
            Name = name;
            Type = type;          
            Strength = strength;
            HealthUp = healthUp;
            RequiredLevel = requiredLevel;
            DexterityE = dexterity;
        }
    }
}
