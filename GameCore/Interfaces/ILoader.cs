using System;
using System.Collections.Generic;
using System.Text;

namespace GameCore.Interfaces
{
    public interface ILoader
    {
        string LoadIntro();
        string LoadOutro();
        string LoadChest();
    }
}
