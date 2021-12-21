
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Labs215Y2K
{
    class kami
    { 
        class Bank : Person
        {
            public static int chek_id { get; set; }
            private static double bank_balans = 0, percent = 0.001, cashback_percent = 0.05, cashback_partner_percent = 0.2, cashback = 0;
            private static DateTime _accountOpenDate;
            private static DateTime dataBorn;
            private static int Day_birthday, Month_birthday, Year_birthday, edit_id, id;
            private static string name, surname, phone;

            private static Dictionary<int, Bank> ClientList = new Dictionary<int, Bank>();
            private static List<double> ListBalans = new List<double>();

            public delegate void AccountHandler(string message);
            public static event AccountHandler Notify = (message) =>
            {
                Console.WriteLine($"\nНа номер {phone} было отправлено сообщение \nСообщение: {message}\n");
            };
            public Bank(string surname, string name, string phone, int Day_birthday, int Month_birthday, int Year_birthday)
            {
                SurName = surname;
                Name = name;
                Phone = phone;
                day_birthday = Day_birthday;
                month_birthday = Month_birthday;
                year_birthday = Year_birthday;
            }
            private static void FullName()
            {
                bank_balans = 0;
                Console.Write("Введите фамилию: ");
                surname = Console.ReadLine();
                Console.Write("Введите имя: ");
                name = Console.ReadLine();
                Console.WriteLine("Укажиет день рождение");
                Console.Write("День: ");
                Day_birthday = int.Parse(Console.ReadLine());
                Console.Write("Месяц: ");
                Month_birthday = int.Parse(Console.ReadLine());
                Console.Write("Год: ");
                Year_birthday = int.Parse(Console.ReadLine());
                Console.Write("Введите номер телефона: ");
                phone = Console.ReadLine();

                dataBorn = new DateTime(Year_birthday, Month_birthday, Day_birthday);
                id += 1;        
            }
            private static void ListOfClients()
            {
                foreach (var item in ClientList)
                {
                    Console.WriteLine($"ID:{item.Key} {item.Value.SurName} {item.Value.Name} \nБаланс: {ListBalans[item.Key - 1]}");
                    Console.WriteLine($"Номер телефона: {item.Value.Phone}");
                    Console.WriteLine($"Дата рождения: {item.Value.day_birthday}.{item.Value.month_birthday}.{item.Value.year_birthday}");
                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                }
            }
            private static void Set_account()
            {
                ListOfClients();
                Console.Write("Введите ID ");
                edit_id = int.Parse(Console.ReadLine());
                Console.WriteLine("Выберите параметр для редактирования ");
                Console.WriteLine("1. Фамилия\n2. Имя\n3. Номер\n4. Дата рождения\n5. Выход из редактирования");

                int proverka_reg = int.Parse(Console.ReadLine());
                while (proverka_reg < 5 && proverka_reg > 0)
                {
                    if (proverka_reg == 1)
                        EditSurName();
                    else if (proverka_reg == 2)
                        EditName();
                    else if (proverka_reg == 3)
                        EditPhone();
                    else if (proverka_reg == 4)
                        EditDataBirthday();
                    Console.WriteLine("Выберите параметр для редактирования ");
                    Console.WriteLine("1. Фамилия\n2. Имя\n3. Номер\n4. Дата рождения\n5. Выход из редактирования");
                    proverka_reg = int.Parse(Console.ReadLine());
                }
            }
            private static void EditName()
            {
                Console.Write("Введите новое имя: ");
                foreach (var item in ClientList)
                {
                    if (item.Key == edit_id)
                    {
                        item.Value.Name = Console.ReadLine();
                    }
                }
            }
            private static void EditSurName()
            {
                Console.Write("Введите новую фамилию: ");
                foreach (var item in ClientList)
                {
                    if (item.Key == edit_id)
                    {
                        item.Value.SurName = Console.ReadLine();
                    }
                }
            }
            private static void EditPhone()
            {
                Console.Write("Введите новый номер: ");
                foreach (var item in ClientList)
                {
                    if (item.Key == edit_id)
                    {
                        item.Value.Phone = Console.ReadLine();
                    }
                }
            }
            private static void EditDataBirthday()
            {
                foreach (var item in ClientList)
                {
                    if (item.Key == edit_id)
                    {
                        Console.Write("Введите день рождения: ");
                        item.Value.day_birthday = int.Parse(Console.ReadLine());
                        Console.Write("Введите месяц рождения: ");
                        item.Value.month_birthday = int.Parse(Console.ReadLine());
                        Console.Write("Введите год рождения: ");
                        item.Value.year_birthday = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine();
            }
            private static void Refill()
            {
                int a = 0;
                Console.Write("Введите сумму пополнения: ");
                int prov2 = 0;
                while (prov2 == 0)
                {
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                        prov2++;
                    }
                    catch
                    {
                        Console.WriteLine("Введите правильную сумму");

                        prov2 = 0;
                    }
                }
                if (a < 10000)
                {
                    while (a < 10000)
                    {
                        Console.WriteLine("Минимальная сумма пополнения 10 000 рублей.");
                        Console.Write("Введите сумму пополнения: ");
                        try
                        {
                            a = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Введиет правильную сумму");
                            a = int.Parse(Console.ReadLine());
                        }
                    }
                }
                while (a > 200000)
                {
                    Console.WriteLine("Максимальная сумма пополнения 200 000 рублей");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введите правильную сумму");
                        a = int.Parse(Console.ReadLine());
                    }
                    while (a < 10000)
                    {
                        Console.WriteLine("Минимальная сумма пополнения 10 000 рублей.");
                        Console.Write("Введите сумму пополнения: ");
                        try
                        {
                            a = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Введите правильную сумму");
                            a = int.Parse(Console.ReadLine());
                        }
                    }
                }
                bank_balans += a;
                Notify?.Invoke($"Пополнение баланса на сумму {a} рублей. Ваш  баланс: {bank_balans}");
                ListBalans[ClientList.Count - 1] = bank_balans;
            }
        }
    }
}
