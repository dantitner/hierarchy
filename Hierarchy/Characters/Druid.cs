using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy.Characters
{
    class Druid : Character
    {
        public Druid(string Name)
        {
            this.Name = Name;
            HP = 15;
            Mana = 20;
            Stamina = 8;
            Attack = 3;
            Armor = 0.5;
            Resist = 0.6;
            //добавить спелл вызова духа
            //добавить спелл лечения
        }
    }
}
