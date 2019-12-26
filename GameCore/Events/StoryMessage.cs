using GameCore.Abstractions;
using GameCore.Systems;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCore.Events
{
    public class StoryMessage : StoryEvent
    {
        public StoryMessage(string message) : base(message)
        {
        }

        public override void Execute()
        {
            ConsoleInput.Write(Message);
        }
    }
}
