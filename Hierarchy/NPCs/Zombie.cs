using System;
using System.Collections.Generic;
using System.Text;
using Hierarchy.Interfaces;

namespace Hierarchy.NPCs
{
    class Zombie : NPC, IUndead
    {
        private int calltime;
        public Zombie()
        {
            calltime = 3;
            HP = 15;
            Mana = 10;
            Stamina = 5;
            Attack = 5;
            Armor = 0.3;
            Resist = 0.6;
        }


        public int CallTime { get => calltime; set => calltime = value; }

        public void Destroy()
        {
            Console.WriteLine($"{Owner.Name}'s Zombie Dead!");
        }

        public void OnTurnEnd()
        {
            CallTime--;
        }
    }
}
