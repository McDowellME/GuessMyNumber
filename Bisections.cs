using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GuessMyNumber
{
    class Bisections
    {
        static int min = ArrayHelper.myArray.Min(); //finds minimum number in array
        static int max = ArrayHelper.myArray.Max(); //finds maximum number in array
        static int middleOfArray = ((max - min) / 2) + min; //finds middle number of array by subtracting the min number from max number then dividing by two.  You must add them min number back to get the actual number and not the index of the middle number.
        static int meanOfArray = ((max - min) / 2) + 1; //finds the mean of the array (the index of the middle) by subtracting the min number from the max number then dividing by two then adding one.
        public static void lowerBisection()
        {
            //declare a new mean inside loop to create new mean each time
            meanOfArray = ((max - min) / 2) + 1;
            //use .Skip will the number of items specified, in this case, by using the mean of the array, 
            //and return a new array of remaining numbers by using .ToArray
            ArrayHelper.myArray = ArrayHelper.myArray.Skip(meanOfArray).ToArray();
            //declare new max and min and middle of array inside the loop after creating new array to create new values each time
            max = ArrayHelper.myArray.Max();
            min = ArrayHelper.myArray.Min();
            middleOfArray = ((max - min) / 2) + min;
        }

        public static void higherBisection()
        {
            meanOfArray = ((max - min) / 2) + 1;
            //use .Take will take the number of specified items in array, in this case, up to the mean item
            ArrayHelper.myArray = ArrayHelper.myArray.Take(meanOfArray).ToArray();
            max = ArrayHelper.myArray.Max();
            min = ArrayHelper.myArray.Min();
            middleOfArray = ((max - min) / 2) + min;
        }
    }
}
