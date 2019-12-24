using System;
using System.Collections.Generic;
using System.Text;

namespace GameCore.Util
{
    public static class Dice
    {
        public static bool RollDice()
        {
            int diceThrow = 0;
            for (int i = 0; i < 4; i++)
            {
                diceThrow += StaticRandom.Next(-1,1);
            }
            if (diceThrow <= 0)
                return false;
            else
                return true;
        }
    }
}
