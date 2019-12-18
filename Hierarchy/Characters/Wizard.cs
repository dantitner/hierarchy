using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy.Characters
{
    public class Wizard : Character
    {
        public Wizard(string Name)
        {
            this.Name = Name;
            HP = 20;
            Mana = 15;
            Stamina = 10;
            Attack = 8;
            Armor = 0.0;
            Resist = 0.5;
            
        }
    }
}
