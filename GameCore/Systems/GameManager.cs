using System;
using System.Collections.Generic;
using System.Text;
using Hierarchy.Characters;
using Hierarchy.Abstractions;
using Hierarchy;

namespace GameCore.Systems
{
    public class GameManager
    {
        public static GameManager gm;

        public Room CurrentRoom;

        public Character PlayerCharacter;

    }
}
