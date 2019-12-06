using System;
using System.Collections.Generic;
using System.Text;
using Hierarchy.Interfaces;

namespace Hierarchy.NPCs
{
    class Spirit : NPC, IUndead
    {
        private int calltime;
        public Spirit()
        {
            calltime = 5;
            HP = 8;
            Mana = 10;
            Stamina = 10;
            Attack = 6;
            Armor = 0.2;
            Resist = 0.7;
        }


        public int CallTime { get => calltime; set => calltime = value; }

        public void Destroy()
        {
            Console.WriteLine($"{Owner.Name}'s Spirit Dead!");
        }

        public void DecreaseCalltime()
        {
            CallTime--;
        }
    }
}
