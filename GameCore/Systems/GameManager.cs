using System;
using System.Collections.Generic;
using System.Text;
using Hierarchy.Characters;
using Hierarchy.Abstractions;
using Hierarchy;
using GameCore.Abstractions;
using GameCore.Enum;

namespace GameCore.Systems
{
    public class GameManager : IGameManager
    {
        private Room CurrentRoom;

        private Character PlayerCharacter;

        private EventsFactory EventsFactory;

        #region ctor

        
        public GameManager(Character character, Room room, EventsFactory eventsFactory)
        {
            EventsFactory = eventsFactory;
            CurrentRoom = room;
            PlayerCharacter = character;
            GenerateEvents();
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

        public void GenerateEvents()
        {
            CurrentRoom.AddEventToRoom(EventsFactory.GenerateMessage(EventMessageType.storyIntro));
            CurrentRoom.AddEventToRoom(EventsFactory.GenerateWithCondition(EventActionType.storyChest,new Events.StoryChest.AddGoldDelegate(GetCharacter().AddGold)));
            CurrentRoom.AddEventToRoom(EventsFactory.GenerateMessage(EventMessageType.storyOutro));
        }
    }
}
