using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Character : Entity
    {
        public string Name { get; set; }
        public List<Spell> Spells { get; set; }
        public List<NPC> OwnedNPCs { get; set; }
    }
}
