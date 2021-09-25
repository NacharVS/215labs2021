using System;

namespace ArrayOperationsAbd
{
    class maxelement
    {
        public static void maxOperations()
        {
            int[,] array = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int max = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array.GetLength(1) > max)
                        max = array.GetLength(1);
                {
                    Console.WriteLine("max:{0}", max);
                }
            }
        }
    }
}