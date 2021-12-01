using System;
using System.Collections.Generic;
using System.Text;

namespace BANK
{
    class Employer : Account, IEmployer
    {
        public Employer(string name, double balanceRUB, double balanceUSD, int yearOfBirth, int id) : base(name, balanceRUB, balanceUSD, yearOfBirth, id)
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

        public override void GoToBank()
        {
            Console.WriteLine($"{Name} goes to Bank for job");
        }
        public override void Deposit(Account account)
        { 
            Console.WriteLine("Введите ");
        }
    }
}
