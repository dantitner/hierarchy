using GameCore.Enum;
using GameCore.Events;
using GameCore.Interfaces;
using GameCore.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCore.Systems
{
    public class EventsFactory : IEventFactory
    {
        private readonly string _xmlPath;

        public EventsFactory(string xmlPath)
        {
            _xmlPath = xmlPath;
        }

        public IEvent Generate(EventType eventType)
        {
            Loader loader = new Loader(_xmlPath);
            IEvent result = null;
            switch (eventType)
            {
                case EventType.storyIntro:
                    result = new StoryEvent(loader.LoadIntro());
                    break;
                case EventType.storyOutro:
                    result = new StoryEvent(loader.LoadOutro());
                    break;
                case EventType.storyChest:
                    StoryEvent chestEvent = new StoryEvent(loader.LoadChest());
                    chestEvent.Condition = "Открыть?";
                    chestEvent.DoChoice = true;
                    int goldAmount = StaticRandom.Next(20,100);
                    chestEvent.ConditionPositive = delegate 
                    {
                        ConsoleInput.Write($"Внутри ты нашел {goldAmount} золота.");
                        //обратиться  к гейм менеджеру и добавить золото игроку
                    };
                    chestEvent.ConditionNegative = delegate
                    {
                        ConsoleInput.Write($"Ты не решаешься посмотреть и проходишь мимо.");

                    };
                    result = chestEvent;
                    break;
                case EventType.StoryTrap:
                    break;
                case EventType.fight:
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
