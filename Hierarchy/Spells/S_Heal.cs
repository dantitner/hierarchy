using System;
using System.Collections.Generic;
using System.Text;
using Hierarchy.Interfaces;
using Hierarchy.Util;
using Hierarchy.Abstractions;
namespace Hierarchy.Spells
{
    class S_Heal : Spell, ISpell
    {

        public S_Heal(Character character)
        {
            SpellName = "Heal";

            Caster = character;

            ManaCost = 4;
            Cooldown = 5;
            Value = 4;
            SpellTarget = SpellTarget.AlliesAndSelf;
            Range = 3;

        }
        public void Cast(Entity target)
        {
            target.HP += Value;
            Console.WriteLine($"{Caster.Name} casted {SpellName}.");
        }

        public void OnSpellCast()
        {
            Caster.Mana -= ManaCost;
            CurrentCoolDown = Cooldown;
        }
    }
}
