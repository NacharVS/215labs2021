using System;

namespace BANK
{
    class Program
    {
        static void Main()
        {
            CommonUser acc1 = new CommonUser("MyName", 500, 100, 2004, 0);
            Employer employer1 = new Employer("Хоязин", 666666, 555, 1901, 1337);
            CommonUser acc2 = new CommonUser("Fedor", 6000, 0, 2004, 1);
            CommonUser acc3 = new CommonUser("Elena", 3000, 0, 1987, 2);
            IUserOperations user1 = acc1;
            IUserOperations user2 = acc2;
            IUserOperations user3 = acc3;
            IEmployer employer = employer1;
            employer.ChangeRate();
        }
            public void Work()
            {
                Account[] users = new Account[3];


                CommonUser acc1 = new CommonUser("MyName", 500, 100, 1901, 0);
                CommonUser acc2 = new CommonUser("Fedor", 6000, 0, 2004, 1);
                CommonUser acc3 = new CommonUser("Elena", 3000, 0, 1987, 2);
                IUserOperations user1 = acc1;
                IUserOperations user2 = acc2;
                IUserOperations user3 = acc3;

                users[0] = acc1;
                users[1] = acc2;
                users[2] = acc3;

                Console.WriteLine("Введите ID пользователя, с которого Вы хотите начать работу.");
                int userID = int.Parse(Console.ReadLine());
                Console.WriteLine("На данный момент вы можете:");
                Console.WriteLine("(1) - Пополнить счёт.");
                Console.WriteLine("(2) - Снять деньги со счёта.");
                Console.WriteLine($"(3) - Узнать свой будущий профит за год с процентной ставкой в {Account.Rate * 100}. % в месяц");
                Console.WriteLine("(4) - Узнать свой баланс.");
                Console.WriteLine("(5) - Перевести деньги с одного счета на другой");
                Console.WriteLine("Введите номер необходимой операции");
                string number = Console.ReadLine();

                if (userID == 0)
                {
                    switch (number)
                    {
                        case "1":
                            user1.Deposit(acc1);
                            user1.Showinfo();
                            break;
                        case "2":
                            user1.Withdraw(acc1);
                            user1.Showinfo();
                            break;
                        case "3":
                            user1.ShowProfit(12);
                            user1.Showinfo();
                            break;
                        case "4":
                            user1.Showinfo();
                            break;
                        case "5":
                            Console.WriteLine("Введите ID пользователя, которому хотите перевести деньги.");
                            int getterId = int.Parse(Console.ReadLine());
                            for (int i = 0; i < users.Length; i++)
                            {
                                if (users[i] == users[getterId])
                                {
                                    user1.Transaction(acc1, users[getterId]);
                                    user1.Showinfo();
                                    users[getterId].Showinfo();
                                }
                            }
                            break;
                    }
                }
            }
        }
    }

