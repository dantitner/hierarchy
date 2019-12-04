using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy.NPCs
{
    class Hitman : NPC
    {
        public Hitman()
        {
            HP = 10;
            Mana = 0;
            Stamina = 15;
            Attack = 7;
            Armor = 0.4;
            Resist = 0.1;
        }
    }
}
