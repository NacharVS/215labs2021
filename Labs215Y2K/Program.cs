using System;
using System.ComponentModel.DataAnnotations;
using Units;
using Action;
using Labs215Y2K.Bank;
using System.Collections.Generic;

namespace Labs215Y2K
{
    class Program
    {
         static void Main(string[] args)
         {
            List<BankAccounts> Accounts = new List<BankAccounts>();
            Accounts.Add(new BankAccounts("Ivan", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 5000, 100, new Random().Next(121, 9521)));
            Accounts.Add(new BankAccounts("Fedor", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 6000, 20, new Random().Next(122, 9522)));
            Accounts.Add(new BankAccounts("Elena", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 3000, 85, new Random().Next(123, 9523)));
            Accounts.Add(new BankAccounts("Yarik", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 100, 100000, new Random().Next(777, 778)));
            Accounts.Add(new BankAccounts("Egorik", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 100000, 1, new Random().Next(125, 9526)));



            foreach (var item in Accounts)
            {
                Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}, Возраст - {item.Age}, {item.Balance} руб., {item.Dollarbalance}$");
            }
         }
        public static void magaz(int[] numberofproduct, int yesno, string[] catalog, string[] korzina, int counter, int cycleoperation, int[] countofproduct, int[] korzinakolvo, int[] price, int[] Sum, int[] sumtwo, int[] korzinaprice)
        {
            int cou = 1;
            while (cycleoperation > 1)
            {
                Console.WriteLine("Выберите номер товара: ");
                numberofproduct[cou] = int.Parse(Console.ReadLine());
                Console.WriteLine("Выберите кол-во товара(товары на развес указывать в граммах с шагом в 100): ");
                countofproduct[cou] = int.Parse(Console.ReadLine());
                cou++;
                cycleoperation--;
                if (numberofproduct[cou] < 6)
                {
                    Sum[cou] += price[numberofproduct[cou]] * countofproduct[cou];
                    Console.WriteLine(Sum);
                }
                Console.WriteLine();

                if (numberofproduct[cou] > 5 && countofproduct[cou] % 100 == 0)
                {
                    int check = countofproduct[cou] / 100;
                    sumtwo[cou] += price[numberofproduct[cou]] * check;
                    Console.WriteLine(sumtwo);
                }
                else
                {
                    Console.WriteLine("Кол-во товаров нужно указывать строго с шагом в 100");
                }
                if (numberofproduct[cou] != 0)
                {
                    korzina[counter] = catalog[numberofproduct[cou]];
                    Console.Write($"Корзина: {korzina[counter]}");
                    counter++;

                }

            }
            Console.WriteLine();
            Console.Write($"Товар:       Кол-во:         Цена:");
            Console.WriteLine();

            for (int i = 0; i < numberofproduct.Length; i++)
            {
                korzina[counter] = catalog[numberofproduct[i]];
                Console.Write($"{  korzina[counter]}          ");
                Console.Write($"{  countofproduct[counter]}          ");
                korzinakolvo[counter] = price[numberofproduct[i]];
                Console.Write($"{  korzinakolvo[counter]}         ");

                if (numberofproduct[cou] < 6)
                {
                    korzinaprice[counter] = Sum[counter];
                }
                else
                {
                    korzinaprice[counter] = sumtwo[counter];
                }
                Console.WriteLine($"{korzinaprice[counter]}");
                counter++;
                Console.WriteLine();
            }
        }

        static void Show(double a, double b)
        {
            Console.WriteLine($"Баланс изменён на {a} руб. , новый баланс = {b} руб. ");
            Console.WriteLine();
        }
        static void NameChange(string OldName, string NewName)
        {
            Console.WriteLine($"{OldName} было измененно на {NewName} ");
            Console.WriteLine();
        }
        public static void bank()
        {
            CleaningWoman Woman = new CleaningWoman("Галина", "Ивановна");
            SecurityGuard Guard = new SecurityGuard("Данил", "Тавевский");

            Console.WriteLine("Вас приветствует Банк Субботний Scam, самый надёжный банк в городе");

            Account acc1 = new Account("Ivan", 5000, 100, new Random().Next(121, 9521));
            Account acc2 = new Account("Fedor", 6000, 20, new Random().Next(122, 9522));
            Account acc3 = new Account("Elena", 3000, 85, new Random().Next(123, 9523));
            Account acc4 = new Account("Yarik", 100, 100000, new Random().Next(777, 778));
            Account acc5 = new Account("Egorik", 100000, 1, new Random().Next(125, 9526));

            IClientOperation Cl1 = acc1;
            IClientOperation Cl2 = acc2;
            IClientOperation Cl3 = acc3;
            IClientOperation Cl4 = acc4;
            IClientOperation Cl5 = acc5;

            Console.WriteLine();
            Guard.Actions();
            Console.WriteLine();

            Ipersonal Pers1 = acc1;


            int GetterCounter = 0;
            int SellerCounter = 0;
            int AccDepostCounter = 0;
            int AccWithdrawCounter = 0;
            int AccConvertCounter = 0;
            int AccPersCounter = 0;
            int[] UserIdMassive = new int[5];
            UserIdMassive[0] = Cl1.UserId;
            UserIdMassive[1] = Cl2.UserId;
            UserIdMassive[2] = Cl3.UserId;
            UserIdMassive[3] = Cl4.UserId;
            UserIdMassive[4] = Cl5.UserId;
            IClientOperation[] UserMassive2 = new IClientOperation[5];
            UserMassive2[0] = Cl1;
            UserMassive2[1] = Cl2;
            UserMassive2[2] = Cl3;
            UserMassive2[3] = Cl4;
            UserMassive2[4] = Cl5;
            Ipersonal[] UserMassive1 = new Ipersonal[1];
            UserMassive1[0] = Pers1;
            Account[] UserMassive3 = new Account[5];
            UserMassive3[0] = acc1;
            UserMassive3[1] = acc2;
            UserMassive3[2] = acc3;
            UserMassive3[3] = acc4;
            UserMassive3[4] = acc5;

            Cl1.Info(acc1);
            Cl2.Info(acc2);
            Cl3.Info(acc3);
            Cl4.Info(acc4);
            Cl5.Info(acc5);
            Console.WriteLine();
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            acc4.NameChangeEvenet += NameChange;
            acc4.Name = "Крутой чел";

            acc1.BalanceChangeEvent += Show;
            acc1.Balance = 3000;

            //Console.WriteLine($"{acc1.name} Введите Ваш год рождения: ");
            //acc1.BirthOfYear = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine($"{acc2.name} Введите Ваш год рождения: ");
            //acc2.BirthOfYear = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine($"{acc3.name} Введите Ваш год рождения: ");
            //acc3.BirthOfYear = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine($"{acc4.name} Введите Ваш год рождения: ");
            //acc4.BirthOfYear = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine($"{acc5.name} Введите Ваш год рождения: ");
            //acc5.BirthOfYear = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            acc1.BirthOfYear = new Random().Next(1940, DateTime.Now.Year);
            acc2.BirthOfYear = new Random().Next(1940, DateTime.Now.Year);
            acc3.BirthOfYear = new Random().Next(1940, DateTime.Now.Year);
            acc4.BirthOfYear = new Random().Next(1940, DateTime.Now.Year);
            acc5.BirthOfYear = new Random().Next(1940, DateTime.Now.Year);


            Console.WriteLine("Введите секретный символ, чтобы заскамить всех и уехать на Мальдивы");
            if (Console.ReadKey().Key == ConsoleKey.Delete)
            {
                Console.WriteLine();
                Pers1.Scam(acc5);
                Console.Clear();
                Cl5.Info(acc5);
                Console.WriteLine();
                Console.WriteLine("Заскамил всех и улетел");
                Console.WriteLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Оу щит, ты не угадал");
                Console.WriteLine();
            }

            Cl1.ShowInfo(acc1);
            Cl2.ShowInfo(acc2);
            Cl3.ShowInfo(acc3);
            Cl4.ShowInfo(acc4);
            Cl5.ShowInfo(acc5);
            Console.WriteLine();


            Console.WriteLine("Выберите Id пользователя которому вы хотите поменять имя");
            int AccPersId = int.Parse(Console.ReadLine());
            for (int i = 0; i < UserIdMassive.Length; i++)
            {
                if (UserIdMassive[i] == AccPersId)
                {
                    AccPersCounter = i;
                }
            }
            UserMassive1[0].NameChange(UserMassive3[AccPersCounter]);
            UserMassive1[0].RateChange();


            Console.WriteLine("Введите кол-во месяцев");
            int mountcounter = int.Parse(Console.ReadLine());
            Console.WriteLine("Профит за " + mountcounter + " меся(ц/ца/цев) с коэффицентом " + Account.rate);
            Console.WriteLine();


            Cl1.ShowProfit(acc1, mountcounter);
            Cl2.ShowProfit(acc2, mountcounter);
            Cl3.ShowProfit(acc3, mountcounter);
            Cl4.ShowProfit(acc4, mountcounter);
            Cl5.ShowProfit(acc5, mountcounter);


            Cl1.ShowInfo(acc1);
            Cl2.ShowInfo(acc2);
            Cl3.ShowInfo(acc3);
            Cl4.ShowInfo(acc4);
            Cl5.ShowInfo(acc5);

            Console.WriteLine();
            Console.WriteLine("Выберите Id пользователя которому вы хотите конвертировать деньги");
            int AccConvertId = int.Parse(Console.ReadLine());
            for (int i = 0; i < UserIdMassive.Length; i++)
            {
                if (UserIdMassive[i] == AccConvertId)
                {
                    AccConvertCounter = i;
                }
            }

            UserMassive2[AccConvertCounter].MoneyConvert(UserMassive3[AccConvertCounter]);
            UserMassive2[AccConvertCounter].ShowInfo(UserMassive3[AccConvertCounter]);

            Console.WriteLine();
            Console.WriteLine("Выберите Id пользователя которому вы хотите добавить деньги");
            int AccDeposit = int.Parse(Console.ReadLine());
            for (int i = 0; i < UserIdMassive.Length; i++)
            {
                if (UserIdMassive[i] == AccDeposit)
                {
                    AccDepostCounter = i;
                }
            }

            UserMassive2[AccDepostCounter].Deposit(UserMassive3[AccDepostCounter]);
            UserMassive2[AccDepostCounter].ShowInfo(UserMassive3[AccDepostCounter]);


            Console.WriteLine();
            Console.WriteLine("Выберите Id пользователя у которого вы хотите отнять деньги");
            int AccWithdraw = int.Parse(Console.ReadLine());
            for (int i = 0; i < UserIdMassive.Length; i++)
            {
                if (UserIdMassive[i] == AccWithdraw)
                {
                    AccWithdrawCounter = i;
                }
            }
            UserMassive2[AccWithdrawCounter].Withdraw(UserMassive3[AccWithdrawCounter]);
            UserMassive2[AccWithdrawCounter].ShowInfo(UserMassive3[AccWithdrawCounter]);

            Console.WriteLine();
            Console.WriteLine("Минутка уборки, Не ходить по помытому полу!!!!!!");
            Woman.Actions();
            System.Threading.Thread.Sleep(5000);

            Console.WriteLine();
            Console.WriteLine("Выберите Id пользователя которому вы хотите перевести");
            int AccGetterId = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите Id пользователя от которого вы хотите перевести");
            int AccGetterSeller = int.Parse(Console.ReadLine());
            for (int i = 0; i < UserIdMassive.Length; i++)
            {
                if (UserIdMassive[i] == AccGetterId)
                {
                    GetterCounter = i;
                }
                if (UserIdMassive[i] == AccGetterSeller)
                {
                    SellerCounter = i;
                }
            }
            UserMassive2[SellerCounter].Transaction(UserMassive3[SellerCounter], UserMassive3[SellerCounter], UserMassive3[GetterCounter]);
            UserMassive2[SellerCounter].ShowInfo(UserMassive3[SellerCounter]);
            UserMassive2[GetterCounter].ShowInfo(UserMassive3[GetterCounter]);

            Console.WriteLine();
            Console.WriteLine("Всё, банк закрылся");
        }
    }
}
