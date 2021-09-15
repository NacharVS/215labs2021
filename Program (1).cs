using System;

namespace bot2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Привет! как тебя зовут!");
            string name = Console.ReadLine();
            Console.WriteLine($"Рад знакмоству, {name}");
            Console.WriteLine($"{name}, Сколько тебе лет?");
            int num = int.Parse(Console.ReadLine());
            if (num>18.23)
                Console.WriteLine("Тебе больше 18");
            else if (num<10)
                Console.WriteLine("Ты ещё очень маленький");
            else 
                Console.WriteLine("Ты ещё маленький");
            
            

        }
    }
}