using System;
using System.Collections.Generic;
using System.Text;

namespace BanK_Account
{
    class AccountMethods : IEmployeOperations
    {
        private string _name;
        private double _rubbalance;
        private double _usdbalance;
        private int _id;
        private static double rate = 0.09;
        private int _datebirth;
        private int _age;
        private static double wellrate = 76;
        private static double withdrawrubmaxlimit = 30000;
        private static double withdrawrubminlimit = 100;
        private static double withdrawusdmaxlimit = 1000;
        private static double withdrawusdminlimit = 50;
        private static double depositrubminlimit = 50;
        private static double depositrubmaxlimit = 100000;
        private static double depositusdminlimit = 10;
        private static double depositusdmaxlimit = 5000;
        private static double rubmaxtransaction = 50000;
        private static double usdmaxtransaction = 2500;
        
        public int DateBirth
        {
            get
            {
                return _datebirth;
            }
            set
            {
                _datebirth = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
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

        string IEmployeOperations.Name
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
        double IEmployeOperations.Rubbalance
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
        double IEmployeOperations.Usdbalance
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
        int IEmployeOperations.Id
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
        int IEmployeOperations.Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        int IEmployeOperations.DateBirth
        {
            get
            {
                return _datebirth;
            }
            set
            {
                _datebirth = value;
            }
        }
        public void AgeInput(AccountMethods acc)
        {
            Console.Write($"Введите дату рождения {acc.Name}: ");
            int date = int.Parse(Console.ReadLine());
            if (date < 1900 || date > 2021)
            {
                while (date < 1900 || date > 2021)
                {
                    date = 0;
                    Console.Write("Дата неверна! Введите по новой: ");
                    date = int.Parse(Console.ReadLine());
                    if (date < 1900 || date > 2021)
                    {
                        continue;
                    }
                    else if (date > 1900 || date < 2021)
                    {
                        acc.DateBirth += date;
                        acc.Age += DateTime.Now.Year - acc.DateBirth;
                        break;
                    }
                }
            }
            else if (date > 1900 || date < 2021)
            {
                acc.DateBirth += date;
                acc.Age += DateTime.Now.Year - acc.DateBirth;
            }
            Console.WriteLine($"Имя: {acc.Name} Id: {acc.Id} Дата рождения: {acc.DateBirth} Возраст: {acc.Age}");
        }    
        public void ShowInfo()
        {
              Console.WriteLine($"id: {Id} Имя: {Name} Возраст: {Age} Баланс в рублях = {RubBalance} р. Баланс в долларах = {UsdBalance} $");
        }
        public void ShowId()
        {
            Console.WriteLine($"id: {Id} Имя: {Name}");
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
            Console.WriteLine("Лимит на пополнение в рублях - 100.000 р. в долларах - 5.000 $");
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
                    else if (depo <= depositrubmaxlimit)
                    {
                        if (depo > depositrubminlimit)
                        {
                            acc.RubBalance += depo;
                            Console.WriteLine($"{acc.Name} - начислено {depo} р. на рублевой счёт");
                        }
                        else if (depo < depositrubminlimit)
                        {
                            Console.WriteLine("Нельзя внести менее 50 рублей");
                            break;
                        }
                    }
                    else if (depo > depositrubmaxlimit)
                    {
                        Console.WriteLine("Нельзя внести более 100.000 р.");
                        break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите сумму которую хотите добавить");
                    depo = int.Parse(Console.ReadLine());
                    if (depo < 0)
                    {
                        Console.WriteLine("Нельзя внести отрицательное кол-во денег.");
                    }
                    else if (depo <= depositusdmaxlimit)
                    {
                        if (depo > depositusdminlimit)
                        {
                            acc.UsdBalance += depo;
                            Console.WriteLine($"{acc.Name} - начислено {depo} $");
                        }
                        else if (depo < depositrubminlimit)
                        {
                            Console.WriteLine("Нельзя внести менее 10 $");
                            break;
                        }
                    }
                    else if (depo > depositusdmaxlimit)
                    {
                        Console.WriteLine("Нельзя внести более 5.000 $");
                        break;
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
            Console.WriteLine("Лимит на снятие денег с рублевого счёта - 30.000 р. с долларового счёта - 1.000 $");
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
                    else if (acc.RubBalance > 0)
                    {
                        Console.WriteLine();
                        Console.Write("Введите сумму которую хотите вывести: ");
                        withd = int.Parse(Console.ReadLine());
                        if (withd > withdrawrubmaxlimit)
                        {
                            Console.WriteLine("Нельзя вывести более 30.000 руб.");
                            break;
                        }
                        else if (withd <= acc.RubBalance)
                        {
                            if (withd < withdrawrubminlimit)
                            {
                                Console.WriteLine("Нельзя вывести меньше 100 руб.");
                                break;
                            }
                            else if (withd < withdrawrubmaxlimit)
                            {
                                acc.RubBalance -= withd;
                                Console.WriteLine($"{acc.Name} - успешно выведено {withd} р.");
                                acc.ShowInfo();
                            }
                        }
                        else if (withd < withdrawrubminlimit)
                        {
                            Console.WriteLine("Нельзя вывести меньше 100 руб.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"У {acc.Name} нет столько р. на счету для вывода");
                            
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
                        if (withd > withdrawusdmaxlimit)
                        {
                            Console.WriteLine("Нельзя вывести более 1.000 $");
                            break;
                        }
                        else if (withd <= acc.UsdBalance)
                        {
                            if (withd < withdrawusdminlimit)
                            {
                                Console.WriteLine("Нельзя вывести меньше 50$");
                                break;
                            }
                            if (withd < withdrawusdmaxlimit)
                            {
                                acc.UsdBalance -= withd;
                                Console.WriteLine($"{acc.Name} - успешно выведено {withd} $");
                                acc.ShowInfo();
                            }
                        }
                        else if (answer < withdrawusdminlimit)
                        {
                            Console.WriteLine("Нельзя вывести меньше 50 $ .");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"У {acc.Name} нет столько $ на счету для вывода");
                            
                        }

                    }
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    break;
            } 
        }
        public void Transaction(AccountMethods accSeller, AccountMethods accGetter)
        {
            Console.WriteLine($"Лимит для перевода на рублевой счёт - {rubmaxtransaction} р. долларовый счёт - {usdmaxtransaction} $ ");
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
                            if (transsum < rubmaxtransaction)
                            {
                                accSeller.RubBalance -= transsum;
                                accGetter.RubBalance += transsum;
                                Console.WriteLine($"{accGetter.Name} успешно получил {transsum} р.");
                            }
                            else if (transsum > rubmaxtransaction)
                            {
                                Console.WriteLine("Превышен лимит для перевода!");
                            }
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
                            if (transsum < usdmaxtransaction)
                            {
                                accSeller.UsdBalance -= transsum;
                                accGetter.UsdBalance += transsum;
                                Console.WriteLine($"{accGetter.Name} успешно получил {transsum} $");
                            }
                            else if (transsum > usdmaxtransaction)
                            {
                                Console.WriteLine("Превышен лимит для перевода!");
                            }
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
        void IEmployeOperations.NameChange(AccountMethods acc)
        {
            Console.WriteLine($"{acc.Id} Текущее имя {acc.Name}");
            Console.Write("Введите новое имя: ");
            string answer = Console.ReadLine();
            acc.Name = answer;
            Console.WriteLine($"Успешно! Id: {acc.Id} Текущее имя: {acc.Name}");
        }


        void IEmployeOperations.list(IEmployeOperations acc)
        {
            Console.WriteLine($"Имя: {acc.Name} Id: {acc.Id} Дата рождения: {acc.DateBirth} Возраст: {acc.Age}");
        }

        void IEmployeOperations.AgeInput(AccountMethods acc)
        {
            if (acc.Age > 0)
            {
                Console.WriteLine();
            }
            else if (acc.Age == 0)
            {
                Console.Write($"Введите дату рождения {acc.Name}: ");
                int date = int.Parse(Console.ReadLine());
                
                if (date < 1900 || date > 2021)
                {
                    while (date < 1900 || date > 2021)
                    {
                        date = 0;
                        Console.Write("Дата неверна! Введите по новой: ");
                        date = int.Parse(Console.ReadLine());
                        if (date < 1900 || date > 2021)
                        {
                            continue;
                        }
                        else if (date > 1900 || date < 2021)
                        {
                            acc.DateBirth += date;
                            acc.Age += DateTime.Now.Year - acc.DateBirth;
                            break;
                        }
                    }
                }
                else if (date > 1900 || date < 2021)
                {
                    acc.DateBirth += date;
                    acc.Age += DateTime.Now.Year - acc.DateBirth;
                }
                Console.WriteLine($"Имя: {acc.Name} Id: {acc.Id} Дата рождения: {acc.DateBirth} Возраст: {acc.Age}");
            }
            
        }

        void IEmployeOperations.RateChange(IEmployeOperations ac)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущая банковская ставка = {rate}; ");
            Console.Write($"Введите новую ставку: ");
            double answer = double.Parse(Console.ReadLine());
            if (rate > 0)
            {
                rate = 0;
                rate += answer;
                Console.WriteLine($"Успешно! Текущая ставка = {rate}");
            }
            else if (rate == 0)
            {
                rate += answer;
                Console.WriteLine($"Успешно! Текущая ставка = {rate}");
            }
        }

        void IEmployeOperations.RubTransactionChange(IEmployeOperations ac)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущий макс лимит на транзакцию в рублях = {rubmaxtransaction} р.");
            Console.Write($"Введите новый мин. лимит: ");
            double lim = double.Parse(Console.ReadLine());
            if (rubmaxtransaction > 0)
            {
                rubmaxtransaction = 0;
                rubmaxtransaction += lim;
                Console.WriteLine($"Успешно! Текущий лимит  = {rubmaxtransaction} р.");
            }
            else if (rubmaxtransaction == 0)
            {
                rubmaxtransaction += lim;
                Console.WriteLine($"Успешно! Текущий лимит  = {rubmaxtransaction} р.");
            }
        }

        void IEmployeOperations.UsdDepoLimitChange(IEmployeOperations ac)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущие лимиты на пополнение в долларах: мин. лимит = {depositusdminlimit} $.  макс. лимит = {depositusdmaxlimit} $.");
            Console.WriteLine("Какой лимит вы хотите поменять? 1 - мин. лимит; 2 - макс. лимит");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write($"Введите новый мин. лимит: ");
                    double minlim = double.Parse(Console.ReadLine());
                    if (depositusdminlimit > 0)
                    {
                        depositusdminlimit = 0;
                        depositusdminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {depositusdminlimit} $.");
                    }
                    else if (depositusdminlimit == 0)
                    {
                        depositusdminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {depositusdminlimit} $.");
                    }
                    break;
                case 2:
                    Console.Write($"Введите новый макс. лимит: ");
                    double maxlim = double.Parse(Console.ReadLine());
                    if (depositusdmaxlimit > 0)
                    {
                        depositusdmaxlimit = 0;
                        depositusdmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий макс. лимит  = {depositusdmaxlimit} $.");
                    }
                    else if (depositusdmaxlimit == 0)
                    {
                        depositusdmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {depositusdmaxlimit} $.");
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    break;
            }
        }

        void IEmployeOperations.RubDepoLimitChange(IEmployeOperations ac)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущие лимиты на пополнение в рублях: мин. лимит = {depositrubminlimit} р.  макс. лимит = {depositrubmaxlimit} р.");
            Console.WriteLine("Какой лимит вы хотите поменять? 1 - мин. лимит; 2 - макс. лимит");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write($"Введите новый мин. лимит: ");
                    double minlim = double.Parse(Console.ReadLine());
                    if (depositrubminlimit > 0)
                    {
                        depositrubminlimit = 0;
                        depositrubminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {depositrubminlimit} р.");
                    }
                    else if (depositrubminlimit == 0)
                    {
                        depositrubminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {depositrubminlimit} р.");
                    }
                    break;
                case 2:
                    Console.Write($"Введите новый макс. лимит: ");
                    double maxlim = double.Parse(Console.ReadLine());
                    if (depositrubmaxlimit > 0)
                    {
                        depositrubmaxlimit = 0;
                        depositrubmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий макс. лимит  = {depositrubmaxlimit} р.");
                    }
                    else if (depositrubmaxlimit == 0)
                    {
                        depositrubmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {depositrubmaxlimit} р.");
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    break;
            }
        }

        void IEmployeOperations.RubWithLimitChange(IEmployeOperations ac)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущие лимиты на вывод в рублях: мин. лимит = {withdrawrubminlimit} р.  макс. лимит = {withdrawrubmaxlimit} р.");
            Console.WriteLine("Какой лимит вы хотите поменять? 1 - мин. лимит; 2 - макс. лимит");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write($"Введите новый мин. лимит: ");
                    double minlim = double.Parse(Console.ReadLine());
                    if (withdrawrubminlimit > 0)
                    {
                        withdrawrubminlimit = 0;
                        withdrawrubminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {withdrawrubminlimit} р.");
                    }
                    else if (withdrawrubminlimit == 0)
                    {
                        withdrawrubminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {withdrawrubminlimit} р.");
                    }
                    break;
                case 2:
                    Console.Write($"Введите новый макс. лимит: ");
                    double maxlim = double.Parse(Console.ReadLine());
                    if (withdrawrubmaxlimit > 0)
                    {
                        withdrawrubmaxlimit = 0;
                        withdrawrubmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий макс. лимит  = {withdrawrubmaxlimit} р.");
                    }
                    else if (withdrawrubmaxlimit == 0)
                    {
                        withdrawrubmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {withdrawrubmaxlimit} р.");
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    break;
            }
        }

        void IEmployeOperations.UsdwithLimitChange(IEmployeOperations ac)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущие лимиты на вывод в долларах: мин. лимит = {withdrawusdminlimit} $.  макс. лимит = {withdrawusdmaxlimit} $.");
            Console.WriteLine("Какой лимит вы хотите поменять? 1 - мин. лимит; 2 - макс. лимит");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write($"Введите новый мин. лимит: ");
                    double minlim = double.Parse(Console.ReadLine());
                    if (withdrawusdminlimit > 0)
                    {
                        withdrawusdminlimit = 0;
                        withdrawusdminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {withdrawusdminlimit} $.");
                    }
                    else if (withdrawusdminlimit == 0)
                    {
                        withdrawusdminlimit += minlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {withdrawusdminlimit} $.");
                    }
                    break;
                case 2:
                    Console.Write($"Введите новый макс. лимит: ");
                    double maxlim = double.Parse(Console.ReadLine());
                    if (withdrawusdmaxlimit > 0)
                    {
                        withdrawusdmaxlimit = 0;
                        withdrawusdmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий макс. лимит  = {withdrawusdmaxlimit} $.");
                    }
                    else if (withdrawusdmaxlimit == 0)
                    {
                        withdrawusdmaxlimit += maxlim;
                        Console.WriteLine($"Успешно! Текущий мин. лимит  = {withdrawusdmaxlimit} $.");
                    }
                    break;
                default:
                    Console.WriteLine("Неверное число!");
                    break;
            }
        }

        void IEmployeOperations.UsdTransactionChange(IEmployeOperations ac)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущий макс лимит на транзакцию в долларах = {usdmaxtransaction} $.");
            Console.Write($"Введите новый мин. лимит: ");
            double lim = double.Parse(Console.ReadLine());
            if (usdmaxtransaction > 0)
            {
                usdmaxtransaction = 0;
                usdmaxtransaction += lim;
                Console.WriteLine($"Успешно! Текущий лимит  = {usdmaxtransaction} $.");
            }
            else if (usdmaxtransaction == 0)
            {
                usdmaxtransaction += lim;
                Console.WriteLine($"Успешно! Текущий лимит  = {usdmaxtransaction} $.");
            }
        }
    }
}
