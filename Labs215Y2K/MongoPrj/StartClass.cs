using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.MongoPrj
{
    class StartClass
    {
        public static void Start()
        {
            Console.WriteLine("Добро пожаловать в базу данных студентов!");
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - Добавить студентов в базу данных");
            Console.WriteLine("2 - Искать студента по параметру");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Examples.Start();
                    StartClass.Start();
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    StartClass.Start();
                    break;
            }
        }
    }
}
