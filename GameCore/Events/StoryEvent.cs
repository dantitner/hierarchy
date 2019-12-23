using System;
using System.Collections.Generic;
using System.Text;
using GameCore.EventArguments;
using GameCore.Interfaces;
using GameCore.Systems;

namespace GameCore.Events
{
    public class StoryEvent : IEvent
    {
        public string Message { get; set; }
        public bool DoChoice { get; set; }
        public string Condition { get; set; }

        public StoryEvent(string message)
        {
            Message = message;
        }

        public event EventHandler<MessageEventArgs> ShowMessage;

        public void OnEvent(string message)
        {
            MessageEventArgs messageEventArgs = new MessageEventArgs(message);
            ShowMessage?.Invoke(this, messageEventArgs);
        }

        public delegate void ConditionDelegate();

        public ConditionDelegate ConditionPositive { get; set; }
        public ConditionDelegate ConditionNegative { get; set; }

        public void Drop()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            ConsoleInput.Write(Message);
            if (DoChoice)
            {
                ConsoleInput.Write(Condition);
                switch (ConsoleInput.YesNoQuestion())
                {
                    case true:
                        ConditionPositive.Invoke();
                        break;
                    case false:
                        ConditionNegative.Invoke();
                        break;
                    default:
                        break;
                }

                
            }

            
        }


    }
}
