using System;
using System.Collections.Generic;
using Labs215Y2K;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)

        {
            List<Account> accounts = new List<Account>();
            accounts.Add(new Account("Marya", 5500));
            accounts.Add(new Account("Vasilisa", 500));
            accounts.Add(new Account("Katya", 15500));
            accounts.Add(new Account("Max", 1000));
            string name = Console.ReadLine();
            accounts.Add(new Account(name, 200));
            string name1 = Console.ReadLine();
            accounts.Add(new Account(name1, 200));
            string name2 = Console.ReadLine();
            accounts.Add(new Account(name2, 200));

            foreach (var item in accounts)
            {
                Console.WriteLine($"name:{item._name} balance:{item.Balance}");
            }


            Account testacc = new Account("Gulnaz", 3000);
            Console.WriteLine(accounts.Contains(testacc));

            Employer emp1 = new Employer("Vadim", "Plushka");
            Security scr1 = new Security("Vasya", "Fominsky");
            emp1.GoToBank();
            scr1.GoToBank();

            Account acc1 = new Account("Ivan", 500, 100, 1951, 0);
            Account employer1 = new Account("Сотрудник", 1000000, 555, 1905, 10);
            Account acc2 = new Account("Fedor", 6000, 0, 2004, 1);
            Account acc3 = new Account("Elena", 3000, 0, 1987, 2);
            IOperationClient user1 = acc1;
            IOperationClient user2 = acc2;
            IOperationClient user3 = acc3;
            IEmployer employer = employer1;
            employer.ChangeRate();

            Account[] users = new Account[5];

            users[0] = acc1;
            users[1] = acc2;
            users[2] = acc3;


            Console.WriteLine("Введите ID пользователя, с которым будет производится работа");
            int userID = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цифру в соответствии с тем, что вы хотите сделать:");
            Console.WriteLine("(1) - Пополнить счёт");
            Console.WriteLine("(2) - Снять деньги со счёта");
            Console.WriteLine($"(3) - Узнать свой будущий профит за год с процентной ставкой в {Account.GetRate() * 100}% в месяц");
            Console.WriteLine("(4) - Узнать свой баланс");
            Console.WriteLine("(5) - Перевести деньги с одного счета на другой");
            Console.WriteLine("Введите номер необходимой операции");
            string number = Console.ReadLine();

            if (userID == 0)
            {
                switch (number)
                {
                    case "1":
                        user1.Deposit(acc1);
                        user1.Showinfo(acc1);
                        break;
                    case "2":
                        user1.Withdraw(acc1);
                        user1.Showinfo(acc1);
                        break;
                    case "3":
                        user1.ShowProfit(acc1, 12);
                        user1.Showinfo(acc1);
                        break;
                    case "4":
                        user1.Showinfo(acc1);
                        break;
                    case "5":
                        Console.WriteLine("Введите ID пользователя, которому хотите перевести деньги");
                        int getterId = int.Parse(Console.ReadLine());
                        for (int i = 0; i < users.Length; i++)
                        {
                            if (users[i] == users[getterId])
                            {
                                user1.Transaction(acc1, users[getterId]);
                                user1.Showinfo(acc1);
                                users[getterId].Showinfo(users[getterId]);
                            }
                        }
                        break;
                }
            }
            if (userID == 1)
            {
                switch (number)
                {
                    case "1":
                        user2.Deposit(acc2);
                        user2.Showinfo(acc2);
                        break;
                    case "2":
                        user2.Withdraw(acc2);
                        user2.Showinfo(acc2);
                        break;
                    case "3":
                        user2.ShowProfit(acc2, 12);
                        user2.Showinfo(acc2);
                        break;
                    case "4":
                        user2.Showinfo(acc2);
                        break;
                    case "5":
                        Console.WriteLine("Введите ID пользователя, которому хотите перевести деньги");
                        int getterId = int.Parse(Console.ReadLine());
                        for (int i = 0; i < users.Length; i++)
                        {
                            if (users[i] == users[getterId])
                            {
                                user2.Transaction(acc2, users[getterId]);
                                user2.Showinfo(acc2);
                                users[getterId].Showinfo(users[getterId]);
                            }
                        }
                        break;
                }
            }
            if (userID == 2)
            {
                switch (number)
                {
                    case "1":
                        user3.Deposit(acc3);
                        user3.Showinfo(acc3);
                        break;
                    case "2":
                        user3.Withdraw(acc3);
                        user3.Showinfo(acc3);
                        break;
                    case "3":
                        user3.ShowProfit(acc3, 12);
                        user3.Showinfo(acc3);
                        break;
                    case "4":
                        user3.Showinfo(acc3);
                        break;
                    case "5":
                        Console.WriteLine("Введите ID пользователя, которому хотите перевести деньги");
                        int getterId = int.Parse(Console.ReadLine());
                        for (int i = 0; i < users.Length; i++)
                        {
                            if (users[i] == users[getterId])
                            {
                                user3.Transaction(acc3, users[getterId]);
                                user3.Showinfo(acc3);
                                users[getterId].Showinfo(users[getterId]);
                            }
                        }
                        break;
                }


            }
        }
    }
}
