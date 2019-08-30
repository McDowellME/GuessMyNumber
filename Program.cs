using System;
using System.Linq;

namespace GuessMyNumber
    //Learned .Take and .Skip from Jorge
{    
    class Program
    {
        static int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static int min = list.Min();
        static int max = list.Max();
        static int middleOfArray = ((max - min) / 2) + min;
        static int meanOfArray = ((max - min) / 2) + 1;
        
        public static void findNumber(int inputNumber)
        {
            do
            {                
                if (inputNumber > middleOfArray)
                {
                    Console.WriteLine($"Number input was greater than middle number, {middleOfArray}. The new search array is");
                    Console.Write("( ");
                    meanOfArray = ((max - min) / 2) + 1;
                    list = list.Skip(meanOfArray).ToArray();
                    max = list.Max();
                    min = list.Min();
                    middleOfArray = ((max - min) / 2) + min;
                    foreach (int item in list)
                    {
                        Console.Write(item.ToString() + " ");
                    }
                    Console.WriteLine(")");
                    Console.WriteLine($"and the new middle number is {middleOfArray}\n");
                }
                else //numberInput < middle
                {
                    Console.WriteLine($"Number input was less than middle number, {middleOfArray}. The new search array is");
                    Console.Write("( ");
                    meanOfArray = ((max - min) / 2) + 1;
                    list = list.Take(meanOfArray).ToArray();
                    max = list.Max();
                    min = list.Min();
                    middleOfArray = ((max - min) / 2) + min;
                    foreach (int item in list)
                    {
                        Console.Write(item.ToString() + " ");
                    }
                    Console.WriteLine(")");
                    Console.WriteLine($"and the new middle number is {middleOfArray}\n");
                }
            }
            while (inputNumber != middleOfArray);

            Console.WriteLine("Bingo!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Guess My Number!\n Enter a number between 1 and 10. \n");
            string userInput = Console.ReadLine();
            int userInputInteger = Int32.Parse(userInput);
            findNumber(userInputInteger);
        }
    }
}
