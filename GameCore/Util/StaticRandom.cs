using System;
using System.Collections.Generic;
using System.Text;

namespace GameCore.Util
{
    public static class StaticRandom
    {
        private static readonly Random r;

        static StaticRandom()
        {
            r = new Random();
        }

        public static int Next(int a,int b)
        {
            return r.Next(a,b);
        }

    }
}
