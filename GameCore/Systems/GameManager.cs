using System;
using System.Collections.Generic;
using System.Text;
using Hierarchy.Characters;
using Hierarchy.Abstractions;
using Hierarchy;
using GameCore.Abstractions;

namespace GameCore.Systems
{
    public class GameManager : IGameManager
    {
        private Room CurrentRoom;

        private Character PlayerCharacter;

        #region ctor

        
        public GameManager(Character character, Room room)
        {
            CurrentRoom = room;
            PlayerCharacter = character;
        }

        #endregion

        public Character GetCharacter()
        {
            return PlayerCharacter;
        }

        public Room GetCurrentRoom()
        {
            return CurrentRoom;
        }
    }
}
