using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Labs215Y2K
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n != 1)
            {
                Console.WriteLine("Введите имя");
                string name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                string surname = Console.ReadLine();

                Console.WriteLine("Введите возраст");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите отчество");
                string pobatyushke = Console.ReadLine();

                Console.WriteLine("Введите гендер");
                string gender = Console.ReadLine();

                Console.WriteLine("Введите дату рождения");
                string databirth = Console.ReadLine();

                Console.WriteLine("Введите знак зодиак");
                string zodiak = Console.ReadLine();

                Console.WriteLine("Введите цыет кожи");
                string  sceencolor = Console.ReadLine();

                Console.WriteLine("Введите цвет волос");
                string  haircolor = Console.ReadLine();

                Console.WriteLine("Введите рост (в см)");
                int  rost = int.Parse(Console.ReadLine());

                if (rost > 200)
                {
                    Console.WriteLine("Не ври!!!");
                    return;
                }
                

                Console.WriteLine("Введите (Стоп), если хотите законьчить");
                Console.WriteLine("(Enter), чтобы продолжить");
                string input = Console.ReadLine();
                if (input == "Стоп")
                {
                    n = 1;
                }
                Extensions.AddToDataBase(name, surname, age,  pobatyushke,  gender,  databirth,  zodiak,  sceencolor,  haircolor,  rost);
            }
        }
    }
}
