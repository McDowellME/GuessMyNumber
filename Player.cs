using System;
using System.Collections.Generic;
using System.Text;

namespace GuessMyNumber
{
    class Player
    {
        public static void ChoosePlayer(int inputSelection)
        {
            if (inputSelection == 1)
            {
                SeeBisection();
            }
            else if (inputSelection == 2)
            {
                HumanPlays();
            }
            else //(inputSelection == 3)
            {
                ComputerPlays();
            }
        }
        public static void SeeBisection()
        {
            Console.WriteLine("Let's see how the bisection alogrithm works:");
            Console.WriteLine("Enter a number between 1 and 10. \n");
            string userInput = Console.ReadLine();
            int userInputInteger = Int32.Parse(userInput);
            Program.ImplementBisectionAlgorithm(userInputInteger);
            ArrayHelper.ArrayGenerator(1, 10);
        }
        public static void HumanPlays()
        {
            Console.WriteLine("Guess the computer's number!\n");
            RandomNumberHelper.RandomNumberGenerator();
            ArrayHelper.ArrayGenerator(1, 1000);
            Console.WriteLine("The computer has chosen a number.\n");
            Console.WriteLine("What is your guess between 1 and 1000?\n");
            string humanInput = Console.ReadLine();
            int humanInputInteger = Int32.Parse(humanInput);
            Program.HumanPlaysGuessMyNumber(humanInputInteger);
        }
        public static void ComputerPlays()
        {
            Console.WriteLine("Beep Boop.\nI am the computer.  Let me guess your number between 1 and 100.\nBeep Boop.");
            ArrayHelper.ArrayGenerator(1, 100);
            Program.ComputerPlaysGuessMyNumber(1, 100);
        }
    }
}
