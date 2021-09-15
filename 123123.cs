using System;

namespace bot2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wassup! Pls tell what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you,",name);
            Console.WriteLine($"{name}, how old are you:?");
            int num = int.Parse(Console.ReadLine());
            
      
        }
    }
}
