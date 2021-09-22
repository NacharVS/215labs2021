using System;

namespace ConsoleApp1
{
    class Program
    {
    static void Main(string[] args)
        {
            Console.WriteLine("число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("степень:");
            int b = int.Parse(Console.ReadLine());
            int c = 1; 
            for (int i = 1; i <= b; i++)
            {
                c = a * c;
            }
            Console.WriteLine(c);
        }
    }
}




