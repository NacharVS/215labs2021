using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class ArrayMinMax
    {
        public static void Ex9()
        {
            int[] myArray = new int[10] { 1, 20, 134, 13, 15, 190, 24, 34, 55, 67 };
            int minValue = myArray[0];
            int maxValue = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {

                Console.WriteLine(myArray[i]);
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
                if (myArray[i] > maxValue)
                {
                    maxValue = myArray[i];
                }

            }
            Console.WriteLine($"Минимальное значение массива {minValue}");
            Console.WriteLine($"Максимальное значение массива {maxValue}");
        }
    }
}
