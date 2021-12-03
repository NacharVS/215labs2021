using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Info : AccountMethods 
    {
        public Info(string name, double rubbalance, double usdbalance, int id, int datebirth, int age)
        {
            Name = name;
            RubBalance = rubbalance;
            UsdBalance = usdbalance;
            Id = id;
            DateBirth = datebirth;
            Age = age;
        }
        public static void aboba()
        {
            Program.boba();
        }
        public static void startbank()
        {
            Console.WriteLine("Добро пожаловать в банк!");
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - Войти за сотрудника банка");
            Console.WriteLine("2 - Войти за клиента банка;");
            Console.WriteLine("3 - Зарегестрироваться в банке");
            Console.WriteLine("4 - Завершить сеанс");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:

            }
        }
    }
}
