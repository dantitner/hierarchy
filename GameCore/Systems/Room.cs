using System;
using System.Collections.Generic;
using System.Text;
using GameCore.Interfaces;

namespace GameCore.Systems
{
    public class Room
    {
        public delegate void EndRoomDelegate();
        public EndRoomDelegate endRoomDelegate;


        Queue<IEvent> RoomEvents;

        public Room()
        {
            RoomEvents = new Queue<IEvent>();
        }

        public void NextStep()
        {
            if (RoomEvents.Count > 0)
            {
                
                RoomEvents.Peek().Execute();
                RoomEvents.Dequeue();
                NextStep();
            }
            else
                endRoomDelegate.Invoke();
        }

        public void AddEventToRoom(IEvent newEvent)
        {
            RoomEvents.Enqueue(newEvent);
        }
    }
}
