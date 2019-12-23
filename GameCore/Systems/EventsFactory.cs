using GameCore.Events;
using GameCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCore.Systems
{
    class EventsFactory : IFactory
    {
        public T Generate<T>()
        {
            T bruh = default;
            if (bruh is StoryEvent)
            {
                return bruh;
            }
            else
                return bruh;

        }
    }
}
