using System;


namespace Sumid
{
    class Student
    {
        public static void Students(int[,]array,int maxValue)
        {
            SumId sumid = new SumId();
            int[] sum = new int [10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumid.ID = i + 1;
                Console.Write($"{sumid.ID} =) ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(maxValue);
                    Console.Write($"{array[i, j]} ");
                    sum[i] += array[i, j];

                }
                sumid.Sum = sum[i];
                Console.Write(sumid.Sum);
                Console.WriteLine();
            }
            SumId [] suma = new SumId[10];
            SumId[] ID = new SumId[10];
            int temp;
            for (int i = 0; i < sum.Length; i++)
            {
                for (int j = i+1; j < sum.Length; j++)
                {
                    if (sum[i]>sum[j])
                    {
                        temp = sum[i];
                        sum[i] = sum[j];
                        sum[j] = temp;
                        
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write($"{sum[i]} ");
            }
            Console.WriteLine();
        }
    }
    class SumId
    {
        public int Sum;
        public int ID;
    }

}
