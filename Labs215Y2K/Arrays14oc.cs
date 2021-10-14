using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Arrays14oc
    {


        public static void arraygeneration(int[,] integersarray, int sum, int a, int[] integersarray2, int[,] newidarray)
        {
            for (int i = 0; i < integersarray.GetLength(0);i++)
            {
                Console.Write(a);
                for (int j = 0; j < integersarray.GetLength(0); j++)
                {
                    integersarray[i, j] = new Random().Next(0, 100);
                    sum += integersarray[i, j];
                    integersarray2[i] = sum;
                    newidarray[i, j] = integersarray[i, j];
                    Console.Write($" {integersarray[i, j]}");
                }
                Console.Write($"     Сумма элементов {a} строки = {sum}");
                Console.WriteLine("");
                a += 1;
                sum = 0;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Arrays14oc.sumstring(integersarray, sum, a, integersarray2, newidarray);
            
        }
        public static void sumstring(int[,] integersarray, int sum, int a, int[] integersarray2, int[,] newidarray)
        {
            int k;
            for (int i = 0; i <integersarray2.Length-1; i++)
            {
                for (int j = i+1; j < integersarray2.Length; j++)
                {
                    if (integersarray2[i] > integersarray2[j])
                    {
                        k = integersarray2[i];
                        integersarray2[i] = integersarray2[j];
                        integersarray2[j] = k;
                    }
                }
            }
            int l;
            for (int i = 0; i < newidarray.GetLength(0);i++)
            {
                for (int j = i+1 ; j < newidarray.GetLength(0);j++)
                {
                    
                    

                }
            }
            Console.WriteLine();
            for (int i = 0; i <newidarray.GetLength(0);i++)
            {
                for (int j = 0; j < newidarray.GetLength(0);j++)
                {
                    
                }
                Console.WriteLine($"     Сумма элементов строки  {integersarray2[i]}");
            }

 
        }
        
    }
}
