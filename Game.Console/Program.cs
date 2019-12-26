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
using GameCore.Enum;
using GameCore.Interfaces;
using System.Text;

namespace Game.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = Encoding.UTF8;
            Room room = new Room();

            var container = new UnityContainer();

            container.RegisterType<IEventFactory, EventsFactory>(new InjectionConstructor("StoryEvents.xml"));
            var eventsFactory = container.Resolve<IEventFactory>();

            container.RegisterType<Character, Druid>(new InjectionConstructor("Chad"));
            var Player = container.Resolve<Character>();

            container.RegisterType<IGameManager, GameManager>(new InjectionConstructor(Player,room, eventsFactory));
            var GameManager = container.Resolve<IGameManager>();

            room.endRoomDelegate = delegate 
            {
                ConsoleInput.Write("Well, back to the camp!");
            };

            GameManager.GetCurrentRoom().NextStep();
        }
    }
}
