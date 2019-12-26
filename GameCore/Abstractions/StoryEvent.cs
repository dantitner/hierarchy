using System;
using GameCore.EventArguments;
using GameCore.Interfaces;
using GameCore.Systems;
using GameCore.Util;

namespace GameCore.Abstractions
{
    public abstract class StoryEvent : IEvent
    {
        public string Message { get; set; }
        //public bool DoChoice { get; set; }
        //public bool RollDice { get; set; }
        //public string Condition { get; set; }


        public StoryEvent(string message)
        {
            Message = message;
        }

        public delegate void ConditionDelegate();

        //public ConditionDelegate ConditionPositive { get; set; }
        //public ConditionDelegate ConditionNegative { get; set; }

        public abstract void Execute();
        //{
        //    ConsoleInput.Write(Message);
        //    if (DoChoice)
        //    {
        //        ConsoleInput.Write(Condition);
        //        if (!RollDice)
        //        {
        //            switch (ConsoleInput.YesNoQuestion())
        //            {
        //                case true:
        //                    ConditionPositive.Invoke();
        //                    break;
        //                case false:
        //                    ConditionNegative.Invoke();
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //        else
        //        {
        //            if (Dice.RollDice())
        //                ConditionPositive.Invoke();
        //            else
        //                ConditionNegative.Invoke();
        //        }   
        //    }   
        //}
    }
}
