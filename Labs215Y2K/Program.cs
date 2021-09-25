using System;

namespace Labs215Y2K
{
    class Program
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n, m;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[m, n];
            Random r = new Random();
            for (int i = 0; i < m; i++)
            {
                int max = a[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > max)
                        max = a[i, j];

                }
                Console.WriteLine("max:{0}", max);
            }

        }
    }
    
}