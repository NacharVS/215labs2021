using System;
using System.Collections.Generic;
using System.Text;
using Labs215Y2K;

namespace Labs215Y2K
{
    class Program 
    {
        static void Main(string[] args)
        {

            //int[] priceproducts = new int[10] { 30, 8, 40, 250, 50, 70, 36, 13, 75, 150 };
            //int[] productschoose = new int[10];
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 5);
                Console.Write($"{array[i]} ");
            }
            
        }
    }
}
