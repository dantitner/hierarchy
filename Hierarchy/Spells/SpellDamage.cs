using Hierarchy.Abstractions;
using Hierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Hierarchy.Util;

namespace Hierarchy.Spells
{
    class SpellDamage : Spell, ICast
    {
        public SpellDamage(Character character)
        {
            SpellName = "Fireball";

            Caster = character;

            ManaCost = 5;
            Cooldown = 3;
            Value = 5;
            SpellTarget = SpellTarget.Enemy;
            Range = 4;

        }
        public void Cast(Entity target)
        {
            target.HP -= Value;
            Console.WriteLine($"{Caster.Name} casted {SpellName}.");
        }

        public void OnSpellCast()
        {
            Caster.Mana -= ManaCost;
            CurrentCoolDown = Cooldown;
        }
    }
}
