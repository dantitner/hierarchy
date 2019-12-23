using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GameCore.Systems
{
    public static class ConsoleInput
    {
        public static ConsoleKey Positive { get; set; }
        public static ConsoleKey Negative { get; set; }

        static ConsoleInput()
        {
            Positive = ConsoleKey.Y;
            Negative = ConsoleKey.N;
        }

        public static bool? YesNoQuestion()
        {
            Write("Type 'Y' for yes. Type 'N' for no.");
            ConsoleKey consoleKey = Console.ReadKey().Key;
            bool? result = null;
            switch (consoleKey)
            {
                case ConsoleKey.Y:
                    result = true;
                    break;
                case ConsoleKey.N:
                    result = false;
                    break;
                default:
                    break;
            }

            return result;

        }

        public static void Write(string message)
        {
            foreach (var item in message)
            {
                Console.Write(item);
                Thread.Sleep(100);
            }
        }
    }
}
