using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy.NPCs
{
    class Dog : NPC
    {
        public Dog()
        {
            HP = 6;
            Mana = 6;
            Stamina = 15;
            Attack = 3;
            Armor = 0.5;
            Resist = 0.00;
        }
    }
}
