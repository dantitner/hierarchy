using GameCore.Enum;
using GameCore.Events;
using GameCore.Interfaces;
using GameCore.Util;
using System;
using System.Collections.Generic;
using System.Text;
using static GameCore.Abstractions.StoryEvent;
using static GameCore.Events.StoryChest;

namespace GameCore.Systems
{
    public class EventsFactory : IEventFactory
    {
        private readonly Loader loader;
        public EventsFactory(string xmlPath)
        {
            loader = new Loader(xmlPath);
        }

        public IEvent GenerateMessage(EventMessageType eventType)
        {
            IEvent result = null;
            switch (eventType)
            {
                case EventMessageType.storyIntro:
                    result = new StoryMessage(loader.LoadIntro());
                    break;
                case EventMessageType.storyOutro:
                    result = new StoryMessage(loader.LoadOutro());
                    break;
                //case EventMessageType.storyChest:
                //    StoryChest chestEvent = new StoryChest(loader.LoadChest());
                      
                default:
                    break;
            }

            return result;
        }

        public IEvent GenerateWithCondition(EventActionType eventType, AddGoldDelegate conditionPositive)
        {
            IEvent result = null;
            switch (eventType)
            {
                case EventActionType.storyChest:
                    result = new StoryChest(loader.LoadChest(),conditionPositive);
                    break;
                case EventActionType.StoryTrap:
                    break;
                case EventActionType.fight:
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
