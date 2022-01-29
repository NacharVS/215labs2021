using System;

namespace bdOriginal
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Если хотите ввести студента, введите 1, если нет - 0");

            for (int i = 0; i < 100; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    Extensions.SuperPerson();
                }
                else
                    Console.WriteLine("Ошибка");
                

                Console.Write("Введите фамилию:");
                Extensions.GetSurnameFromDataBase(Console.ReadLine());
                Console.Write("Введите рост:");
                Extensions.GetRostFromDataBase(int.Parse(Console.ReadLine()));
                Console.Write("Введите средний балл:");
                Extensions.GetAverageMarkFromDataBase(int.Parse(Console.ReadLine()));

                Console.Write("Введите имя студента, которого хотите перезаписать:");
                string wname = Console.ReadLine();
                Extensions.EditDocument(wname, Extensions.SuperPerson());
            }            
        }        
    }
}
