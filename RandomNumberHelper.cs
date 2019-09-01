using System;
using System.Collections.Generic;
using System.Text;

namespace GuessMyNumber
{
    class RandomNumberHelper
    {
        public static int RandomNumberGenerator()
        {
            Random random = new Random();
            return random.Next(1, 1000);
        }

        public static int computerNumber = RandomNumberGenerator();

        public static int BisectionNumberGenerator(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
