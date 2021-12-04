﻿using System;
using System.Collections.Generic;
using System.Text;
using Bank;

namespace Bank
{
    class Info : AccountMethods , IEmploye
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
        
        public static void startbank(List<Info> accounts, List<IEmploye> accounts1)
        {
            string old = "";
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
                    EmployerUsing.EmployeStart(accounts, accounts1);
                    break;
                case 2:
                    ClientUsing.clientstart(accounts, accounts1);
                    break;
            }
        }
        
    }
}
