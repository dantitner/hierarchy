using GameCore.Abstractions;
using GameCore.Systems;
using GameCore.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCore.Events
{
    public class StoryChest : StoryEvent
    {
        public string Condition { get; set; }

        public delegate void AddGoldDelegate(int gold);

        public ConditionDelegate ConditionPositive { get; set; }
        public ConditionDelegate ConditionNegative { get; set; }

        public StoryChest(string message, AddGoldDelegate conditionPositive) : base(message)
        {
            Condition = "Открыть?";
            int goldAmount = StaticRandom.Next(20, 100);
            ConditionPositive = delegate
            {
                ConsoleInput.Write($"Внутри ты нашел {goldAmount} золота.");
                conditionPositive.Invoke(goldAmount);
            };
            ConditionNegative = delegate
            {
                ConsoleInput.Write($"Ты не решаешься посмотреть и проходишь мимо.");
            };
        }

        public override void Execute()
        {
            ConsoleInput.Write(Message);
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
