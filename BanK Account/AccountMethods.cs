using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    class AccountMethods
    {
        private  string _name;
        private  double _rubbalance;
        private double _usdbalance;
        private int _id;
        private static double rate = 0.09;
        private int[] dateofbirth = new int[3];
        private int[] finalage = new int[3];
        private static double wellrate = 76;
        
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public double RubBalance
        {
            get
            {
                return _rubbalance;
            }
            set
            {
                _rubbalance = value;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public double UsdBalance
        {
            get
            {
                return _usdbalance;
            }
            set
            {
                _usdbalance = value;
            }
        }
        public void AgeInput()
        {
            Console.Write($"Введите год рождения {Name} : ");
            int date = int.Parse(Console.ReadLine());
            if (date < 1900 || date > 2021)
            {
                Console.WriteLine();
                while (date < 1900 || date > 2021)
                {
                    date = 0;
                    Console.Write("Неверный год рождения! Введите заново: ");
                    date = int.Parse(Console.ReadLine());
                    if (date > 1900 && date < 2021)
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            dateofbirth[i] += date;
                            break;
                        }
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 1; i++)
                {
                    dateofbirth[i] += date;
                }
            }
            
        }
        public void ShowInfo()
        {
            for (int i = 0; i < 1; i++)
            {
                finalage[i] = DateTime.Now.Year - dateofbirth[i];
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine($"id: {Id} Имя: {Name} Возраст: {finalage[i]} Баланс в рублях = {RubBalance} р. Баланс в долларах = {UsdBalance} $");
            }
        }

        public void ShowProfit(AccountMethods acc, int month)
        {
            Console.WriteLine("Какой счёт вы хотите использовать под проценты? 1 - рублевой; 2 - долларовый");
            Console.Write("Введите цифру: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    for (int i = 0; i < month; i++)
                    {
                        acc.RubBalance += acc.RubBalance * rate;
                    }
                    break;
                case 2:
                    for (int i = 0; i < month; i++)
                    {
                        acc.UsdBalance += acc.UsdBalance * rate;
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    Info.start();
                    break;
            }
        }

        public void Deposit(AccountMethods acc, int depo)
        {
            Console.WriteLine();
            Console.WriteLine("Куда вы хотите ввести деньги? 1 - на рублевой счёт; 2 - на долларовый счёт");
            Console.Write("Введите число: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Введите сумму которую хотите добавить");
                    depo = int.Parse(Console.ReadLine());
                    if (depo < 0)
                    {
                        Console.WriteLine("Нельзя внести отрицательное кол-во денег.");
                    }
                    else
                    {
                        acc.RubBalance += depo;
                        Console.WriteLine($"{acc.Name} - начислено {depo} р. на рублевой счёт");
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите сумму которую хотите добавить");
                    depo = int.Parse(Console.ReadLine());
                    if (depo < 0)
                    {
                        Console.WriteLine("Нельзя внести отрицательное кол-во денег.");
                    }
                    else
                    {
                        acc.UsdBalance += depo;
                        Console.WriteLine($"{acc.Name} - начислено {depo} $");
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    Info.start();
                    break;
            }
            
        }

        public void Withdraw(AccountMethods acc, int withd)
        {
            Console.WriteLine();
            Console.WriteLine("С какого счёта вы хотите вывести деньги? 1 - c рублевого счёта; 2 - c долларового счёта");
            Console.Write("Введите цифру: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    if (acc.RubBalance <= 0)
                    {
                        Console.WriteLine($"{acc.Name} не имеет денег на счету для вывода");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Введите сумму которую хотите вывести: ");
                        withd = int.Parse(Console.ReadLine());
                        if (withd <= acc.RubBalance)
                        {
                            acc.RubBalance -= withd;
                            Console.WriteLine($"{acc.Name} - успешно выведено {withd} р.");
                            acc.ShowInfo();
                            Info.start();
                        }
                        else
                        {
                            Console.WriteLine($"У {acc.Name} нет столько р. на счету для вывода");
                            Info.start();
                        }

                    }
                    break;
                case 2:
                    if (acc.UsdBalance <= 0)
                    {
                        Console.WriteLine($"{acc.Name} не имеет денег на счету для вывода");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write("Введите сумму которую хотите вывести: ");
                        withd = int.Parse(Console.ReadLine());
                        if (withd <= acc.UsdBalance)
                        {
                            acc.UsdBalance -= withd;
                            Console.WriteLine($"{acc.Name} - успешно выведено {withd} $");
                            acc.ShowInfo();
                            Info.start();
                        }
                        else
                        {
                            Console.WriteLine($"У {acc.Name} нет столько $ на счету для вывода");
                            Info.start();
                        }

                    }
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.start();
                    break;
            }
            
        }

        public static void Transaction(AccountMethods accSeller, AccountMethods accGetter)
        {
            Console.WriteLine("С какого счёта вы хотите совершить перевод? 1 - с рублевого счёта; 2 - с долларового счёта");
            Console.Write("Введите цифру: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    if (accSeller.RubBalance <= 0)
                    {
                        Console.WriteLine($"У {accSeller.Name} нет денег на счёту для транзакции!");
                    }
                    else
                    {
                        Console.Write("Введите сумму для транзакции: ");
                        double transsum = double.Parse(Console.ReadLine());
                        if (transsum > accSeller.RubBalance)
                        {
                            Console.WriteLine($"{accSeller.Name} не имеет {transsum} р. для транзакции");
                        }
                        else
                        {
                            accSeller.RubBalance -= transsum;
                            accGetter.RubBalance += transsum;
                            Console.WriteLine($"{accGetter.Name} успешно получил {transsum} р.");
                        }
                    }
                    break;
                case 2:
                    if (accSeller.UsdBalance <= 0)
                    {
                        Console.WriteLine($"У {accSeller.Name} нет денег на счёту для транзакции!");
                    }
                    else
                    {
                        Console.Write("Введите сумму для транзакции: ");
                        double transsum = double.Parse(Console.ReadLine());
                        if (transsum > accSeller.UsdBalance)
                        {
                            Console.WriteLine($"{accSeller.Name} не имеет {transsum} для транзакции");
                        }
                        else
                        {
                            accSeller.UsdBalance -= transsum;
                            accGetter.UsdBalance += transsum;
                            Console.WriteLine($"{accGetter.Name} успешно получил {transsum} $");
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    Info.start();
                    break;

            }
            
        }
        public void RubConvertation(AccountMethods acc)
        {
            Console.Write("Введите сумму для конвертации в рублях: ");
            double answer = double.Parse(Console.ReadLine());
            if (answer > acc.RubBalance)
            {
                Console.WriteLine($"У {acc.Name} нет столько money в рублях!");
                Info.start();
            }
            else
            {
                double sum;
                sum = answer / wellrate;
                int sum1 = Convert.ToInt32(sum);
                acc.UsdBalance += sum1;
                double sum2 = Convert.ToDouble(sum1);
                double F = sum - sum2;
                acc.RubBalance += F * wellrate;
                acc.RubBalance -= answer;
                Console.WriteLine($"{acc.Name} успешно конвертировал {answer} р. в доллары!");
            }
            
        }
        public void UsdConvertation(AccountMethods acc)
        {
            Console.Write("Введите сумму для конвертации в долларах: ");
            double answer = double.Parse(Console.ReadLine());
            if (answer > acc.UsdBalance)
            {
                Console.WriteLine($"У {acc.Name} нет столько money в долларах!");
                Info.start();
            }
            else
            {
                double sum;
                sum = answer * wellrate;
                int sum1 = Convert.ToInt32(sum);
                acc.RubBalance += sum1;
                double sum2 = Convert.ToDouble(sum1);
                acc.UsdBalance -= answer;
                Console.WriteLine($"{acc.Name} успешно конвертировал {answer} $ в рубли!");
            }
        }
    }
}
