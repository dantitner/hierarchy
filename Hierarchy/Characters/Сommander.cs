using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy.Characters
{
    class Сommander : Character
    {
        public Сommander(string Name)
        {
            this.Name = Name;
            HP = 25;
            Mana = 10;
            Stamina = 15;
            Attack = 6;
            Armor = 0.3;
            Resist = 0.2;
            //добавить спелл вызова хитмана
        }

    }
}
