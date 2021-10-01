using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class minmax
    {
        public static void ex4()
        {
            int[] myArray = new int[5] { 10, 3, 4, 15, 123 };
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
