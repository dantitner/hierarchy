using GameCore.EventArguments;
using GameCore.Events;
using System;
using GameCore.Systems;
using Hierarchy;
using Hierarchy.Characters;
using Microsoft.Extensions.DependencyInjection;
using Unity;
using GameCore.Abstractions;
using Unity.Injection;

namespace Game.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();

            var container = new UnityContainer();

            container.RegisterType<Character, Druid>(new InjectionConstructor("Chad"));
            var Player = container.Resolve<Character>();
            container.RegisterType<IGameManager, GameManager>(new InjectionConstructor(Player,room));
            var GameManager = container.Resolve<IGameManager>();

            StoryEvent intro = new StoryEvent("You enter ancient dungeon.");
            StoryEvent chest = new StoryEvent("You found old chest.");

            chest.DoChoice = true;
            chest.Condition = "Do you want open the chest?";
            chest.ConditionPositive = delegate
            {
                ConsoleInput.Write("You found 100 gold!");
                GameManager.GetCharacter().Gold += 100;
            };
            chest.ConditionNegative = delegate
            {
                ConsoleInput.Write("You walk past it!");
            };
            StoryEvent end = new StoryEvent("You at the deadend.");

            room.AddEventToRoom(intro);
            room.AddEventToRoom(chest);
            room.AddEventToRoom(end);

            room.endRoomDelegate = delegate 
            {
                ConsoleInput.Write("Well, back to the camp!");
            };

            GameManager.GetCurrentRoom().NextStep();

        }
    }
}
