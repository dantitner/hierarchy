using System;
using System.Collections.Generic;
using System.Text;
using Hierarchy.Interfaces;
namespace Hierarchy
{
    abstract class Character : Entity
    {
        public string Name { get; set; }
        public ICollection<ISpell> Spells { get; set; }
        public ICollection<NPC> OwnedNPCs { get; set; }

        public Character()
        {
            OwnedNPCs = new List<NPC>();
           
        }
    }
}
