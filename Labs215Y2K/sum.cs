using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class sum
    {
        public static void Ex3()
        {
            {
                int sum = 0;
                int sum2 = 0;
                int[] myArray = new int[1];
                Random rand = new Random();
                for (int x = 0; x < myArray.Length; x++)
                {
                    myArray[x] = rand.Next(100);
                    Console.WriteLine(myArray[x]);
                }
                int[] myArray2 = new int[1];
                Random rand2 = new Random();
                for (int x = 0; x < myArray2.Length; x++)
                {
                    myArray2[x] = rand2.Next(100);
                    Console.WriteLine(myArray2[x]);
                }
                for (int i = 0; i < myArray.Length; i++)
                {
                    sum = sum + myArray[i];


                }
                for (int i = 0; i < myArray2.Length; i++)
                {
                    sum2 = sum2 + myArray2[i];


                }
                sum = sum + sum2;
                Console.WriteLine();
                Console.WriteLine(sum);
            }
        }
    }
}
