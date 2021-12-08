using System;
using System.ComponentModel.DataAnnotations;
using Units;
using Action;
using Labs215Y2K.Bank;
using System.Collections.Generic;
using Labs215Y2K.NewBank;
using Labs215Y2K.EditorCharacter;

namespace Labs215Y2K
{
    class Program
    {
         static void Main(string[] args)
         {
            //NewBank(); /*-Новый банк*/

            Characters();
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

        public static void NewBank()
        {
            List<BankAccounts> Accounts = new List<BankAccounts>();

            Accounts.Add(new BankAccounts("Ivan", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 5000, 100, new Random().Next(121, 9521))); //Accounts[0]
            Accounts.Add(new BankAccounts("Fedor", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 6000, 20, new Random().Next(122, 9522))); //Accounts[1]
            Accounts.Add(new BankAccounts("Elena", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 3000, 85, new Random().Next(123, 9523))); //Accounts[2] 
            Accounts.Add(new BankAccounts("Yarik", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 100, 100000, new Random().Next(777, 778))); //Accounts[3]
            Accounts.Add(new BankAccounts("Egorik", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 100000, 1, new Random().Next(125, 9526))); //Accounts[4]


            Console.WriteLine("Вас приветствует Банк Субботний Scam, самый надёжный банк в городе");
            Console.WriteLine();
            Console.WriteLine("Здравствуйте, введите за кого вы хотите зайти (Personal or User)");
            string PersonalorUser = Console.ReadLine();
            string User = "User"; string Пользователь = "Пользователь";
            string Personal1 = "Personal"; string Персонал = "Персонал";
            if (PersonalorUser == User || PersonalorUser == Пользователь)
            {

                foreach (var item in Accounts)
                {
                    Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}, Возраст - {item.Age}, {item.Balance} руб., {item.Dollarbalance}$");
                }
                //if (Accounts[0].Age < 18)
                //{
                //    Accounts.Remove(Accounts[0]);
                //    Accounts[0].Name = ($"Заблокирован {Accounts[0].Name} Причина: Нет 18 лет");
                //}
                //if (Accounts[1].Age < 18)
                //{
                //    Accounts.Remove(Accounts[1]);
                //    Accounts[1].Name = ($"Заблокирован {Accounts[0].Name} Причина: Нет 18 лет");
                //}
                //if (Accounts[2].Age < 18)
                //{
                //    Accounts.Remove(Accounts[2]);
                //    Accounts[2].Name = ($"Заблокирован {Accounts[0].Name} Причина: Нет 18 лет");
                //}
                //if (Accounts[3].Age < 18)
                //{
                //    Accounts.Remove(Accounts[3]);
                //    Accounts[3].Name = ($"Заблокирован {Accounts[0].Name} Причина: Нет 18 лет");
                //}
                //if (Accounts[4].Age < 18)
                //{
                //    Accounts.Remove(Accounts[4]);
                //    Accounts[4].Name = ($"Заблокирован {Accounts[0].Name} Причина: Нет 18 лет");
                //}
                Console.WriteLine("Введите кол-во месяцев");
                int mountcounter = int.Parse(Console.ReadLine());
                Console.WriteLine();


                for (int i = 0; i < mountcounter; i++)
                {
                    Accounts[0].Balance += Accounts[0].Balance * BankAccounts.rate;
                    Accounts[1].Balance += Accounts[1].Balance * BankAccounts.rate;
                    Accounts[2].Balance += Accounts[2].Balance * BankAccounts.rate;
                    Accounts[3].Balance += Accounts[3].Balance * BankAccounts.rate;
                    Accounts[4].Balance += Accounts[4].Balance * BankAccounts.rate;
                }

                foreach (var item in Accounts)
                {
                    Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}, Возраст - {item.Age}, {item.Balance} руб., {item.Dollarbalance}$");
                }

                Console.WriteLine();
                Console.WriteLine("Введите id пользователя, которому хотите внести деньги (Иван)");
                int ClientIdDeposit = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (Accounts[0].Id == ClientIdDeposit)
                {
                    Console.WriteLine("Укажите сумму, которую вы хотите внести");
                    double DepositMoney = double.Parse(Console.ReadLine());
                    if (DepositMoney > 0)
                    {
                        Accounts[0].Balance = Accounts[0].Balance + DepositMoney;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не верное значение");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Пользователь не найден");
                    Console.WriteLine();
                }

                foreach (var item in Accounts)
                {
                    Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}, Возраст - {item.Age}, {item.Balance} руб., {item.Dollarbalance}$");
                }

                Console.WriteLine();
                Console.WriteLine("Введите id пользователя, у которого вы хотите снять деньги (Елена)");
                int ClientIdWithdraw = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (Accounts[2].Id == ClientIdWithdraw)
                {
                    if (Accounts[2].Balance > 0)
                    {

                        Console.WriteLine("Укажите сумму, которую вы хотите вывести");
                        double WithdrawMoney = double.Parse(Console.ReadLine());
                        if (WithdrawMoney > 0)
                        {
                            Accounts[2].Balance = Accounts[2].Balance - WithdrawMoney;
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели не верное значение");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                }
                else
                {
                    Console.WriteLine("Пользователь не найден");
                    Console.WriteLine();
                }

                foreach (var item in Accounts)
                {
                    Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}, Возраст - {item.Age}, {item.Balance} руб., {item.Dollarbalance}$");
                }

                Console.WriteLine();
                Console.WriteLine("Введите id пользователя, которому вы хотите начислить деньги (Ярик)");
                int ClientIdTransactionDeposit = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите id пользователя, перечислит деньги (Егор)");
                int ClientIdTransactionWithdraw = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (Accounts[3].Id == ClientIdTransactionDeposit && Accounts[4].Id == ClientIdTransactionWithdraw)
                {
                    if (Accounts[3].Balance >= 0 && Accounts[4].Balance > 0)
                    {
                        Console.WriteLine($"Укажите сумму, которую вы хотите перечислить {Accounts[3].Name}");
                        double TransactionwMoney = double.Parse(Console.ReadLine());
                        if (TransactionwMoney > 0)
                        {
                            Accounts[3].Balance = Accounts[3].Balance + TransactionwMoney;
                            Accounts[4].Balance = Accounts[4].Balance - TransactionwMoney;
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели не верное значение");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств");
                    }
                }
                else
                {
                    Console.WriteLine("Пользователь не найден");
                    Console.WriteLine();
                }

                foreach (var item in Accounts)
                {
                    Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}, Возраст - {item.Age}, {item.Balance} руб., {item.Dollarbalance}$");
                }

                Console.WriteLine();
                Console.WriteLine("Введите секретный символ, чтобы заскамить всех и уехать на Мальдивы");
                if (Console.ReadKey().Key == ConsoleKey.Delete)
                {
                    Console.WriteLine();
                    Accounts[4].Balance = 99999999;
                    Accounts[4].Dollarbalance = 99999999;
                    Console.Clear();
                    Console.WriteLine($"{Accounts[4].Name} заскамил всех и улетел");
                    Console.WriteLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Оу щит, ты не угадал, за это я отниму у тебя все деньги");
                    Console.WriteLine();
                    Accounts[4].Balance = 0;
                    Accounts[4].Dollarbalance = 0;
                }

                foreach (var item in Accounts)
                {
                    Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}, Возраст - {item.Age}, {item.Balance} руб., {item.Dollarbalance}$");
                }
            }
            if (PersonalorUser == Personal1 || PersonalorUser == Персонал)
            {
                List<Personal> AccountsPersonal = new List<Personal>();

                AccountsPersonal.Add(new Personal("Кирилл", "Романов", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 5000, 100, new Random().Next(121, 9521))); //Personal[0]
                AccountsPersonal.Add(new Personal("Валерия", "Капустина", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 6000, 20, new Random().Next(122, 9522))); //Personal[1]
                AccountsPersonal.Add(new Personal("Георгий", "Панов", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 3000, 85, new Random().Next(123, 9523))); //Personal[2] 
                AccountsPersonal.Add(new Personal("Олег", "Родин", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 100, 100000, new Random().Next(123, 9523))); //Personal[3]
                AccountsPersonal.Add(new Personal("Илья", "Зыков", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 100000, 1, new Random().Next(125, 9526))); //Personal[4]

                foreach (var item in AccountsPersonal)
                {
                    Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}, Фамилия - {item.Surname}, Возраст - {item.Age}, {item.Balance} руб., {item.Dollarbalance}$");
                }

                int mountcounter2 = new Random().Next(1, 6);
                for (int i = 0; i < mountcounter2; i++)
                {
                    AccountsPersonal[0].Balance += AccountsPersonal[0].Balance * Personal.rate;
                    AccountsPersonal[1].Balance += AccountsPersonal[1].Balance * Personal.rate;
                    AccountsPersonal[2].Balance += AccountsPersonal[2].Balance * Personal.rate;
                    AccountsPersonal[3].Balance += AccountsPersonal[3].Balance * Personal.rate;
                    AccountsPersonal[4].Balance += AccountsPersonal[4].Balance * Personal.rate;
                }

                Console.WriteLine();
                Console.WriteLine("Введите id пользователя, у которого хотите поменять имя");
                Console.WriteLine();
                Console.WriteLine("Показать имена и id пользователь?");
                string YesOrNo = Console.ReadLine();
                string Yes = "Yes"; string Да = "Да";
                if (YesOrNo == Yes || YesOrNo == Да)
                {
                    foreach (var item in Accounts)
                    {
                        Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Ок, имена пользователей скрыты");
                }

                Console.WriteLine();
                Console.WriteLine("Напишите id пользователя, у которого хотите поменять имя");
                int IdAccountUser = int.Parse(Console.ReadLine());
                if (IdAccountUser == Accounts[0].Id)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{Accounts[0].Name} - старое имя");
                    Console.WriteLine();
                    Console.WriteLine("Напишите новое имя");
                    string NewName = Console.ReadLine();
                    Accounts[0].Name = NewName;

                    foreach (var item in Accounts)
                    {
                        Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}");
                    }
                }

            }
            else
            {
                Console.WriteLine("Вы ввели неправильное значение");
            }
        }

        public static void Characters()
        {
            int rounds = 0;
            List<CharacterEditor> Characters = new List<CharacterEditor>();
            Characters.Add(new CharacterEditor("Warrior",30, 15, 10, 25, 0, 0, 0, 0, 0, 0, 0, 0,0,0));
            Characters.Add(new CharacterEditor("Mage",15, 20, 30, 15, 0, 0, 0, 0, 0, 0, 0, 0,0, 0));
            Characters.Add(new CharacterEditor("Archer",20, 30, 15, 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0));

            for (int i = 0; i < Characters.Count; i++)
            {
                Characters[i].Health = 2 * Characters[i].Constitution + (5 / 10 * Characters[i].Strength); //_health = 2 * Constitution + (5/10 * Strength);
                Characters[i].Mana = Characters[i].Intelligence * 3; //_mana = Intelligence * 3;
                Characters[i].PhysicalAttack = Characters[i].Strength * 3 + (5 / 10 * Characters[i].Dexterity); //P.attack = str * 3 + 0.5 * dex;
                Characters[i].MagicAttack = Characters[i].Intelligence * 4; //M.attack = int *4;
                Characters[i].PhysicalDefence = Characters[i].Constitution * 5 / 10 + Characters[i].Dexterity * 3;
                Characters[i].MagicDefence = Characters[i].Intelligence * 2;
                Characters[i].PhysicalCriticalChanse = 20 + Characters[i].Dexterity * 3 / 10;
                Characters[i].MagicCriticalChanse = 20 + Characters[i].Intelligence * 1 / 10;
                Characters[i].PhysicalCriticalDamage = Characters[i].PhysicalAttack * (2 + Characters[i].Dexterity * 5/100);
                Characters[i].MagicCriticalDamage = Characters[i].MagicAttack * (2 + Characters[i].Intelligence * 15/1000);
            }

            //Characters[0].Health = 2 * Characters[0].Constitution + (5 / 10 * Characters[0].Strength); //_health = 2 * Constitution + (5/10 * Strength);
            //Characters[1].Health = 2 * Characters[1].Constitution + (5 / 10 * Characters[1].Strength);
            //Characters[2].Health = 2 * Characters[2].Constitution + (5 / 10 * Characters[2].Strength);

            //Characters[0].Mana = Characters[0].Intelligence * 3; //_mana = Intelligence * 3;
            //Characters[1].Mana = Characters[1].Intelligence * 3;
            //Characters[2].Mana = Characters[2].Intelligence * 3;

            //Characters[0].PhysicalAttack = Characters[0].Strength * 3 + (5 / 10 * Characters[0].Dexterity); //P.attack = str * 3 + 0.5 * dex;
            //Characters[1].PhysicalAttack = Characters[1].Strength * 3 + (5 / 10 * Characters[1].Dexterity);
            //Characters[2].PhysicalAttack = Characters[2].Strength * 3 + (5 / 10 * Characters[2].Dexterity);

            //Characters[0].MagicAttack = Characters[0].Intelligence * 4; //M.attack = int *4;
            //Characters[1].MagicAttack = Characters[1].Intelligence * 4;
            //Characters[2].MagicAttack = Characters[2].Intelligence * 4;

            //Characters[0].PhysicalDefence = Characters[0].Constitution * 5 / 10 + Characters[0].Dexterity * 3;
            //Characters[1].PhysicalDefence = Characters[1].Constitution * 5 / 10 + Characters[1].Dexterity * 3;
            //Characters[2].PhysicalDefence = Characters[2].Constitution * 5 / 10 + Characters[2].Dexterity * 3;

            //Characters[0].MagicDefence = Characters[0].Intelligence * 2;
            //Characters[1].MagicDefence = Characters[1].Intelligence * 2;
            //Characters[2].MagicDefence = Characters[2].Intelligence * 2;


            foreach (var item in Characters)
            {
                Console.WriteLine($"Имя - {item.Name}, Здоровье - {item.Health}, Физ.Атака - {item.PhysicalAttack}, Маг.Атака - {item.MagicAttack}, Сила - {item.Strength}, Мана - {item.Mana}, Ловкость - {item.Dexterity}, Физ.Защита - {item.PhysicalDefence}, Маг.Защита - {item.MagicDefence} PШанс - {item.PhysicalCriticalChanse}  PCD - {item.PhysicalCriticalDamage} M Шанс - {item.MagicCriticalChanse}  MCC - {item.MagicCriticalDamage}");
            }
            Console.WriteLine();

            Characters[1].HealtheChangeEvent += NewHealth;
            Characters[0].HealtheChangeEvent += NewHealth;
            while (Characters[0].Health > 0 || Characters[1].Health > 0)
            {
                if (Characters[1].MagicCriticalChanse >= new Random().Next(0, 100))
                {
                    Console.WriteLine($"{Characters[1].Name} наносит критический урон {Characters[0].Name}");
                    Characters[0].Health -= (Characters[1].MagicAttack + Characters[1].MagicCriticalDamage) - Characters[0].MagicDefence;
                }
                else
                {
                    Console.WriteLine($"{Characters[1].Name} наносит урон {Characters[0].Name}");
                    Characters[0].Health -= (Characters[1].MagicAttack - Characters[0].MagicDefence);
                }
                if (Characters[0].PhysicalCriticalChanse >= new Random().Next(0, 100))
                {
                    Console.WriteLine($"{Characters[0].Name} наносит критический урон {Characters[1].Name}");
                    Characters[1].Health -= (Characters[0].PhysicalAttack + Characters[0].PhysicalCriticalDamage) - Characters[1].PhysicalDefence;
                }
                else
                {
                    Console.WriteLine($"{Characters[0].Name} наносит урон {Characters[1].Name}");
                    Characters[1].Health -= (Characters[0].PhysicalAttack - Characters[1].PhysicalDefence);
                }
                rounds++;
            }
            if (Characters[0].Health > Characters[1].Health) Console.WriteLine($"{Characters[0].Name} победил в поединке! Было сыграно раундов : {rounds}!");
            else if (Characters[0].Health < Characters[1].Health) Console.WriteLine($"{Characters[1].Name} победил в поединке! Было сыграно раундов : {rounds}!");
            else Console.WriteLine($"Ничья! Было сыграно раундов : {rounds}!");


            Console.WriteLine();
        }
        static void NewHealth(int OldHealth, int NewHealth)
        {
            Console.WriteLine($"{OldHealth} было измененно на {NewHealth} ");
            Console.WriteLine();
        }
    }
}
