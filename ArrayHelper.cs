using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GuessMyNumber
{    
    class ArrayHelper
    {        
        public static int[] myArray;
        
        public static void arrayGenerator(int min, int max)
        {
            myArray = Enumerable.Range(min, max).ToArray();
        }        
    }
}
