using GameCore.Systems;
using Hierarchy;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCore.Abstractions
{
    public interface IGameManager
    {
        Room GetCurrentRoom();
        Character GetCharacter();
    }
}
