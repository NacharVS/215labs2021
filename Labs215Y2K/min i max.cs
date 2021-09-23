using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
                array[i] = new Random().Next(10, 100);
            Console.Write($" {array[i]}");
            int min, max;
            min = array[0];
            max = array[0];
            for (int i = 1; i < array.Length; i++)
                
            {
                if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}
