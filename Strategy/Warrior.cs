using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Warrior : Heroes
    {
        public Warrior() : base(30, 15, 10, 25, 250, 80, 50, 100)
        {
        }
    }
}
