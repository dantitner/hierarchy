using GameCore.Enum;
using System;
using System.Collections.Generic;
using System.Text;

using static GameCore.Events.StoryChest;

namespace GameCore.Interfaces
{
    public interface IEventFactory
    {
        IEvent GenerateMessage(EventMessageType eventType);
        IEvent GenerateWithCondition(EventActionType eventType, AddGoldDelegate conditionPositive);
    }
}
