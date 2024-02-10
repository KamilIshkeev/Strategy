using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Wizzard : Heroes
    {
        public Wizzard() : base(15, 20, 35, 15, 45, 80, 250, 70, 150, 200)
        {
        }
    }
}
