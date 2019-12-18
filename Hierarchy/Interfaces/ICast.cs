using System;
using System.Collections.Generic;
using System.Text;
using Hierarchy.Util;
namespace Hierarchy.Interfaces
{
    public interface ICast
    {
        void Cast(Entity target);

        void OnSpellCast();
    }
}
