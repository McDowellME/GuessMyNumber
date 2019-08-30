﻿using System;
using System.Linq; //must use this statement in order to use .Take and .Skip

namespace GuessMyNumber
    //Learned .Take and .Skip from Jorge.  Thanks Jorge!
{    
    class Program
    {
        static int[] firstArrayOfIntegers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static int min = firstArrayOfIntegers.Min(); //finds minimum number in array
        static int max = firstArrayOfIntegers.Max(); //finds maximum number in array
        static int middleOfArray = ((max - min) / 2) + min; //finds middle number of array by subtracting the min number from max number then dividing by two.  You must add them min number back to get the actual number and not the index of the middle number.
        static int meanOfArray = ((max - min) / 2) + 1; //finds the mean of the array (the index of the middle) by subtracting the min number from the max number then dividing by two then adding one.
        
        public static void implementBisectionAlgorithm(int inputNumber)
        {
            //do-while loop.  while input number does not equal middle of array, perform these checks 
            //to produce new array above or below middle number and create new middle number
            do
            {
                //if the input number is equal to the middle number, break out of the loopf
                if (inputNumber == middleOfArray)
                {
                    break;
                }
                //if the input number is greater than the middle number of my array, do this
                else if (inputNumber > middleOfArray) 
                {
                    Console.WriteLine($"Number input was greater than middle number, {middleOfArray}. The new search array is");
                    Console.Write("( ");
                    //declare a new mean inside loop to create new mean each time
                    meanOfArray = ((max - min) / 2) + 1;
                    //use .Skip will the number of items specified, in this case, by using the mean of the array, 
                    //and return a new array of remaining numbers by using .ToArray
                    firstArrayOfIntegers = firstArrayOfIntegers.Skip(meanOfArray).ToArray(); 
                    //declare new max and min and middle of array inside the loop after creating new array to create new values each time
                    max = firstArrayOfIntegers.Max();
                    min = firstArrayOfIntegers.Min();
                    middleOfArray = ((max - min) / 2) + min;

                    //prints each item in new array
                    foreach (int item in firstArrayOfIntegers)
                    {
                        Console.Write(item.ToString() + " ");
                    }
                    Console.WriteLine(")");
                    Console.WriteLine($"and the new middle number is {middleOfArray}\n");
                }
                //if the input number is less than the middle number of my array, do this
                else //numberInput < middle
                {
                    Console.WriteLine($"Number input was less than middle number, {middleOfArray}. The new search array is");
                    Console.Write("( ");
                    meanOfArray = ((max - min) / 2) + 1;
                    //use .Take will take the number of specified items in array, in this case, up to the mean item
                    firstArrayOfIntegers = firstArrayOfIntegers.Take(meanOfArray).ToArray();
                    max = firstArrayOfIntegers.Max();
                    min = firstArrayOfIntegers.Min();
                    middleOfArray = ((max - min) / 2) + min;
                    foreach (int item in firstArrayOfIntegers)
                    {
                        Console.Write(item.ToString() + " ");
                    }
                    Console.WriteLine(")");
                    Console.WriteLine($"and the new middle number is {middleOfArray}\n");
                }
            }
            // provides criteria of when to continue the loop - while input number does not equal middle of array
            while (inputNumber != middleOfArray); 

            //prints this once the user input matches the middle number created by the loop
            Console.WriteLine("Bingo!");
        }

        public static void humanPlaysGuessMyNumber(int inputNumber)
        {            
            if (inputNumber == RandomNumberHelper.computerNumber)
            {
                Console.WriteLine("Bingo!");
            }
            else if (inputNumber > RandomNumberHelper.computerNumber)
            {
                Console.WriteLine("Too high!");
                string userInput = Console.ReadLine();
                int userInputInteger = Int32.Parse(userInput);
                humanPlaysGuessMyNumber(userInputInteger);
            }
            else //if (inputNumber < RandomNumberHelper.computerNumber)
            {
                Console.WriteLine("Too low!");
                string userInput = Console.ReadLine();
                int userInputInteger = Int32.Parse(userInput);
                humanPlaysGuessMyNumber(userInputInteger);
            }            
        }

        public static void computerPlaysGuessMyNumber(int inputNumber)
        {
            //TODO:
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Guess My Number!\n\nEnter a number between 1 and 10. \n");
            string userInput = Console.ReadLine();
            int userInputInteger = Int32.Parse(userInput);
            implementBisectionAlgorithm(userInputInteger);

            Console.WriteLine("Guess the computer's number!\n");
            RandomNumberHelper.randomNumberGenerator();
            ArrayHelper.arrayGenerator(1, 1000);
            Console.WriteLine("The computer has chosen a number.\n");
            Console.WriteLine("What is your guess between 1 and 1000?\n");
            string humanInput = Console.ReadLine();
            int humanInputInteger = Int32.Parse(humanInput);
            humanPlaysGuessMyNumber(humanInputInteger);
        }
    }
}
