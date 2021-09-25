using System;

namespace Labs215Y2K
{
    class Program
    {
        public void main337sdfsdfa()
        {
            Random z = new Random();
            int[,] array = new int[3, 3];

            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    array[y, x] = z.Next(10, 100);
                    Console.Write($"{ array[y, x]} ");

                }
                Console.WriteLine();
            }

            int sum = 0;

            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    sum += array[y, x];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
            Console.ReadKey();
            Console.WriteLine(sum);
        }
    }
}
