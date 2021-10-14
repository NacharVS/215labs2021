using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Arrays
    {
        public int [] id =  new int [10];
        public int sum = 0;


        public static void arraygeneration(int[,] integersarray,int sum, int [] id1)
        {
            Arrays arraynew = new Arrays();
            Arrays id2 = new Arrays();
            for (int i = 0; i < integersarray.GetLength(0);i++)
            {
                for (int j = 0; j < integersarray.GetLength(0); j++)
                {
                    
                    integersarray[i, j] = new Random().Next(0, 100);
                    if ( j == 0)
                    {
                        Console.WriteLine($"{id1[i]}");
                    }
                    Console.Write($"   {integersarray[i, j]} ");

                }
                Console.WriteLine("");
            }
            Console.WriteLine();
            Arrays.sumstring(sum,integersarray);
        }
        public static void sumstring(int sum, int[,] integersarray)
        {
            for (int i = 0; i < integersarray.GetLength(0); i++)
            {
                for (int j = 0; j < integersarray.GetLength(0); j++)
                {
                    sum += integersarray[i, j];
                    
                }
                Console.Write(sum);
                Console.WriteLine();
                sum = 0;
            }
        }
        public static void idstring()
        {
           
        }
    }
}
