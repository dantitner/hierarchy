using System;
using System.Collections.Generic;
using System.Text;
using Hierarchy.Util;

namespace Hierarchy.Abstractions
{
    public abstract class Spell
    {
        public Character Caster { get; set; }

        public string SpellName { get; set; }

        public int CurrentCoolDown { get; set; }

        public int ManaCost { get; set; }
        public int Cooldown { get; set; }
        public SpellTarget SpellTarget { get; set; }
        public int Range { get; set; }

        public int Value { get; set; }
    }
}
