using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {

        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            List<Employer> employers = new List<Employer>();
            employers.Add(new Employer("Хозяюшка", 666666, 555, 1905, 0, "123"));

            users.Add(new User("Артёмик228", 0, 0, 2003, 0, "321 артем ..."));
            users.Add(new User("Артёмик229", 0, 0, 2003, 1, "321 артем ..."));

            Console.WriteLine("Вы хотите войти в существующий аккаунт (1) или зарегистрировать новый (2)");
            string choice = Console.ReadLine();


            if (choice == "1")
            {
                Console.WriteLine("Вы сотрудник банка (1) или клиент (2)?");
                string choice2 = Console.ReadLine();
                if(choice2 == "2")
                WorkSpace(users);
                if (choice2 == "1")
                    ActionsForEmployer(employers, users);
                
            }
            if (choice == "2")
            {
                Registration(users);
                Console.WriteLine("Вы можете войти в свой аккаунт. Для этого нажмите '1'");
                string choice1 = Console.ReadLine();
                if (choice1 == "1")
                {
                    WorkSpace(users);
                }
            }


            
        }
        public static void ActionsForEmployer(List<Employer> employers, List <User> users)
        {
            Console.WriteLine("Введите ID своего аккаунта.");
            int idreader = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой пароль");
            string passreader = Console.ReadLine();
            if (employers.Exists(x => x.Id == idreader && x.Password == passreader))
            {
                Console.WriteLine("Вы можете:");
                Console.WriteLine("(1) - поменять ставку депозита");
                Console.WriteLine("(2) - поменять имя одного из юзеров");
                Console.WriteLine("(3) - поменять год рождения человека в БД");
                string choice100 = Console.ReadLine();
                switch (choice100)
                {
                    case "1":
                        employers[idreader].ChangeRate();
                        break;
                    case "2":
                        Console.WriteLine("Введите ID пользователя, которому хотите поменять имя");
                        int choice99 = int.Parse(Console.ReadLine());
                        employers[idreader].ChangeName(users[choice99]);
                        users[choice99].Showinfo(users[choice99]);
                        break;
                    case "3":
                        Console.WriteLine("Введите ID пользователя, которому хотите поменять год рождения");
                        int choice98 = int.Parse(Console.ReadLine());
                        employers[idreader].ChangeYear(users[choice98]);
                        users[choice98].Showinfo(users[choice98]);
                        break;

                }
            }
        }
        public static void Registration(List<User> users)
        {
            Console.WriteLine("Вы попали на окно регистрации.");
            Console.WriteLine("Введите имя пользователя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите год рождения");
            int birth = int.Parse(Console.ReadLine());
            Console.WriteLine("Придумайте пароль. ");
            string password = Console.ReadLine();
            int test = users.Count;
            users.Add(new User(name, 0, 0, birth, test, password));
            Console.WriteLine($"Ваш ID - {test} ");

        }
        public static void WorkSpace(List<User> users)
        {

            Console.WriteLine("Вы попали на окно авторизации");
            Console.WriteLine("Введите ID своего аккаунта.");
            int idreader = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой пароль");
            string passreader = Console.ReadLine();
            if (users.Exists(x => x.Id == idreader && x.Password == passreader))
            {
                Console.WriteLine($"Доброго времени суток, {users[idreader].Name}.");

                Console.WriteLine("На данный момент вы можете:");
                Console.WriteLine("(1) - Пополнить счёт.");
                Console.WriteLine("(2) - Снять деньги со счёта.");
                Console.WriteLine($"(3) - Узнать свой будущий профит за год с процентной ставкой в {User.Rate * 100}. % в месяц");
                Console.WriteLine("(4) - Узнать свой баланс.");
                Console.WriteLine("(5) - Перевести деньги с одного счета на другой");
                Console.WriteLine("Введите номер необходимой операции");
                string number = Console.ReadLine();
                    switch (number)
                    {
                        case "1":
                        users[idreader].Withdraw(users[idreader]);
                        users[idreader].Showinfo(users[idreader]);
                            break;
                        case "2":
                        users[idreader].Withdraw(users[idreader]);
                        users[idreader].Showinfo(users[idreader]);
                            break;
                        case "3":
                        users[idreader].ShowProfit(users[idreader], 12);
                            break;
                        case "4":
                        users[idreader].Showinfo(users[idreader]);
                            break;
                        case "5":
                            Console.WriteLine("Введите ID пользователя, которому хотите перевести деньги.");
                            int getterId = int.Parse(Console.ReadLine());
                            for (int i = 0; i < users.Count; i++)
                            {
                                if (users[i] == users[getterId])
                                {
                                users[idreader].Transaction(users[idreader], users[getterId]);
                                users[idreader].Showinfo(users[idreader]);
                                }
                            }
                            break;
                    }

                }

                
            }

        }
    }

