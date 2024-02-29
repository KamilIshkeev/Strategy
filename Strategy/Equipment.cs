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
        public int ArmorClass { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int HealthIncrease { get; set; }
        public int RequiredLevel { get; set; }

        public Equipment(string name, string type, int armorClass, int strength, int agility, int healthIncrease, int requiredLevel)
        {
            Name = name;
            Type = type;
            ArmorClass = armorClass;
            Strength = strength;
            Agility = agility;
            HealthIncrease = healthIncrease;
            RequiredLevel = requiredLevel;
        }
    }
}
