using GameCore.EventArguments;
using GameCore.Events;
using System;
using GameCore.Systems;
using Hierarchy;
using Hierarchy.Characters;

namespace Game.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager GameManager = new GameManager();
            GameManager.gm = GameManager;

            Character Player = new Druid("Druid");
            GameManager.PlayerCharacter = Player;

            Room room = new Room();
            GameManager.gm.CurrentRoom = room;

            StoryEvent intro = new StoryEvent("You enter ancient dungeon.");
            StoryEvent chest = new StoryEvent("You found old chest.");
            chest.DoChoice = true;
            chest.Condition = "Do you want open the chest?";
            chest.ConditionPositive = delegate
            {
                System.Console.WriteLine("You found 100 gold!");
                GameManager.PlayerCharacter.Gold += 100;
            };
            chest.ConditionNegative = delegate
            {
                System.Console.WriteLine("You walk past it!");
            };
            StoryEvent end = new StoryEvent("You at the deadend.");

            room.AddEventToRoom(intro);
            room.AddEventToRoom(chest);
            room.AddEventToRoom(end);

            room.endRoomDelegate = delegate 
            {
                System.Console.WriteLine("Well, back to the camp!");
            };

            GameManager.CurrentRoom.NextStep();

        }
    }
}
