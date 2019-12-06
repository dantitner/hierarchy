using System;
using System.Collections.Generic;
using System.Text;
using Hierarchy.Util;
namespace Hierarchy.Interfaces
{
    interface ISpell
    {
        void Cast(Entity target);

        void OnSpellCast();
    }
}
