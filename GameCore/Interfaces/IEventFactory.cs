using GameCore.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCore.Interfaces
{
    public interface IEventFactory
    {
        IEvent Generate(EventType eventType);        
    }
}
