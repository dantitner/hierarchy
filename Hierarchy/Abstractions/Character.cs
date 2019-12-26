using System;
using System.Collections.Generic;
using System.Text;
using Hierarchy.Interfaces;
namespace Hierarchy
{
    public abstract class Character : Entity
    {
        public string Name { get; set; }
        public List<ICast> Spells { get; set; }
        public ICollection<NPC> OwnedNPCs { get; set; }

        public Character()
        {
            OwnedNPCs = new List<NPC>();
           
        }

        public void AddGold(int gold)
        {
            Gold += gold;
        }

        public int AddRandomGold(int min,int max)
        {
            Random random = new Random();
            int randomGold = random.Next(min,max);
            AddGold(randomGold);
            return randomGold;
        }
    }
}
