using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Entity
    {
        public int HP { get; set; }
        public int Mana { get; set; }
        public int Stamina { get; set; }
        public int Attack { get; set; }

        public double Armor { get; set; }
        public double Resist { get; set; }
    }
}
