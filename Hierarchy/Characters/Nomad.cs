using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy.Characters
{
    class Nomad : Character
    {
        public Nomad(string Name)
        {
            this.Name = Name;
            HP = 20;
            Mana = 5;
            Stamina = 20;
            Attack = 8;
            Armor = 0.6;
            Resist = 0.1;
            //добавить спелл вызова собаки

        }
    }
}
