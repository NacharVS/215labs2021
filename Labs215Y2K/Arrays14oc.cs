using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Arrays14oc
    {
        public static void arraygeneration(int[,] integersarray,int sum, int a, int[] integersarraysum, int[,] integerstring)
        {
            for (int i = 0; i < integersarray.GetLength(0); i++)
            {
                Console.Write(a);
                for (int j = 0; j < integersarray.GetLength(0); j++)
                {

                    integersarray[i, j] = new Random().Next(0, 100);
                    sum += integersarray[i, j];
                    integersarraysum[i] = sum;
                    integerstring[i, j] = integersarray[i, j];

                    Console.Write($" {integersarray[i, j]}");

                }
                Console.Write($" Сумма элементов {a} строки = {sum}");
                Console.WriteLine("");
                a += 1;
                sum = 0;
            }
            a = 0;
            Console.WriteLine();
            Console.WriteLine();
            Arrays14oc.sumstring(integersarray,sum,a, integersarraysum, integerstring);
        }
        public static void sumstring(int[,] integersarray, int sum, int a, int[] integersarraysum, int[,] integerstring)
        {
            int k;
            for (int i = 0; i < integersarray.GetLength(0); i++)
            {
                for (int j = 0; j < integersarray.GetLength(0); j++)
                {
                    for (int n = j + 1; n < integersarray.GetLength(0); n++)
                    {
                        if (integersarray[i, j] > integersarray[i, n])
                        {
                            k = integersarray[i, j];
                            integersarray[i, j] = integersarray[i, n];
                            integersarray[i, n] = k;
                        }
                    }
                }
            }
            for (int i = 0; i < integersarray.GetLength(0); i++)
            {
                for (int j = 0; j < integersarray.GetLength(0); j++)
                {
                    Console.Write($" {integersarray[i, j]}");
                }
                Console.WriteLine();
            }
        }

        public static void idstring()
        {
           
        }
    }
}
