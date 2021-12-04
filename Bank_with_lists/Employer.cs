using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Employer:Account
    {
        public Employer(string name, double balanceRUB, double balanceUSD, int yearOfBirth, int id, string password) : base(name, balanceRUB, balanceUSD, yearOfBirth, id, password)
        {
        }

        public void ChangeName(Account account)
        {
            Console.WriteLine("Введите новое имя клиента");
            account.Name = Console.ReadLine();
        }
        public void ChangeRate()
        {
            Console.WriteLine("Введите новую ставку (месячную)");
            Rate = int.Parse(Console.ReadLine());
        }
        public void ChangeYear(Account account)
        {
            Console.WriteLine("Введите новый год рождения пользователя");
            account.Age = int.Parse(Console.ReadLine());
        }
    }
}
