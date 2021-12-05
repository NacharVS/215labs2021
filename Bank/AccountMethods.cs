using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class AccountMethods :  iClient 
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
        void iClient.AgeInput(List<iClient> accounts, int id)
        {
            for (int i = id; i < accounts.Count;i++)
            {
                if (accounts[i].Age > 0)
                {
                    continue;
                }
                else if (accounts[i].Age == 0)
                {
                    Console.Write($"Введите дату рождения {accounts[i].Name}: ");
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
                                accounts[i].DateBirth += date;
                                accounts[i].Age += DateTime.Now.Year - accounts[i].DateBirth;
                                break;
                            }
                        }
                    }
                    else if (date > 1900 || date < 2021)
                    {
                        accounts[i].DateBirth += date;
                        accounts[i].Age += DateTime.Now.Year - accounts[i].DateBirth;
                    }
                    Console.WriteLine($"Имя: {accounts[i].Name} Id: {accounts[i].Id} Дата рождения: {accounts[i].DateBirth} Возраст: {accounts[i].Age}");
                }
                break;
            }
        }
        void iClient.ShowInfo(List<iClient> accounts, int id)
        {
            for (int i = id; i < accounts.Count; i++)
            {
                Console.WriteLine($"id: {accounts[i].Id} Имя: {accounts[i].Name} Возраст: {accounts[i].Age} Баланс в рублях = {accounts[i].RubBalance} р. Баланс в долларах = {accounts[i].UsdBalance} $");
                break;
            }
        }

        void iClient.ShowProfit(List<iClient> accounts, int month, int id)
        {
            for (int i = id; i < accounts.Count; i++)
            {
                Console.WriteLine("Какой счёт вы хотите использовать под проценты? 1 - рублевой; 2 - долларовый");
                Console.Write("Введите цифру: ");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        for (int j = 0; j < month; j++)
                        {
                            accounts[i].RubBalance += accounts[i].RubBalance * rate;
                            break;
                        }
                        break;
                    case 2:
                        for (int k = 0; k < month; k++)
                        {
                            accounts[i].UsdBalance += accounts[i].UsdBalance * rate;
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Неверное число!");
                        break;
                }
                break;
            }
            
        }


        void iClient.Withdraw(List<iClient> accounts, int withd, int id,int newid)
        {
            for (int i = id; i < accounts.Count;)
            {
                Console.WriteLine();
                Console.WriteLine("Лимит на снятие денег с рублевого счёта - 30.000 р. с долларового счёта - 1.000 $");
                Console.WriteLine("С какого счёта вы хотите вывести деньги? 1 - c рублевого счёта; 2 - c долларового счёта");
                Console.Write("Введите цифру: ");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        if (accounts[i].RubBalance <= 0)
                        {
                            Console.WriteLine($"{accounts[i].Name} не имеет денег на счету для вывода");
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        }
                        else if (accounts[i].RubBalance > 0)
                        {
                            Console.WriteLine();
                            Console.Write("Введите сумму которую хотите вывести: ");
                            withd = int.Parse(Console.ReadLine());
                            if (withd > withdrawrubmaxlimit)
                            {
                                Console.WriteLine("Нельзя вывести более 30.000 руб.");
                                ClientUsing.clientstart(accounts, id, newid);
                                break;
                            }
                            else if (withd <= accounts[i].RubBalance)
                            {
                                if (withd < withdrawrubminlimit)
                                {
                                    Console.WriteLine("Нельзя вывести меньше 100 руб.");
                                    ClientUsing.clientstart(accounts, id, newid);
                                    break;
                                }
                                else if (withd < withdrawrubmaxlimit)
                                {
                                    accounts[i].RubBalance -= withd;
                                    Console.WriteLine($"{accounts[i].Name} - успешно выведено {withd} р.");
                                    accounts[i].ShowInfo(accounts, id);
                                    ClientUsing.clientstart(accounts, id, newid);
                                    break;
                                }
                            }
                            else if (withd < withdrawrubminlimit)
                            {
                                Console.WriteLine("Нельзя вывести меньше 100 руб.");
                                ClientUsing.clientstart(accounts, id, newid);
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"У {accounts[i].Name} нет столько р. на счету для вывода");
                                ClientUsing.clientstart(accounts, id, newid);
                                break;
                            }
                        }
                        break;
                    case 2:
                        if (accounts[i].UsdBalance <= 0)
                        {
                            Console.WriteLine($"{accounts[i].Name} не имеет денег на счету для вывода");
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.Write("Введите сумму которую хотите вывести: ");
                            withd = int.Parse(Console.ReadLine());
                            if (withd > withdrawusdmaxlimit)
                            {
                                Console.WriteLine("Нельзя вывести более 1.000 $");
                                ClientUsing.clientstart(accounts, id, newid);
                                break;
                            }
                            else if (withd <= accounts[i].UsdBalance)
                            {
                                if (withd < withdrawusdminlimit)
                                {
                                    Console.WriteLine("Нельзя вывести меньше 50$");
                                    ClientUsing.clientstart(accounts, id, newid);
                                    break;
                                }
                                if (withd < withdrawusdmaxlimit)
                                {
                                    accounts[i].UsdBalance -= withd;
                                    Console.WriteLine($"{accounts[i].Name} - успешно выведено {withd} $");
                                    accounts[i].ShowInfo(accounts, id);
                                    ClientUsing.clientstart(accounts, id, newid);
                                    break;
                                }
                            }
                            else if (answer < withdrawusdminlimit)
                            {
                                Console.WriteLine("Нельзя вывести меньше 50 $ .");
                                ClientUsing.clientstart(accounts, id, newid);
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"У {accounts[i].Name} нет столько $ на счету для вывода");
                                ClientUsing.clientstart(accounts, id, newid);
                                break;
                            }

                        }
                        break;
                    default:
                        Console.WriteLine("Неверный номер!");
                        ClientUsing.clientstart(accounts, id, newid);
                        break;
                }
            }
                
            
        }

        void iClient.NameChange(List<iClient> accounts, string old)
        {
            for (int i = 0; i < accounts.Count;)
            {
                i = int.Parse(Console.ReadLine());
                Console.WriteLine($"{accounts[i].Id} Текущее имя {accounts[i].Name}");
                old = accounts[i].Name;
                Console.Write("Введите новое имя: ");
                string answer = Console.ReadLine();
                accounts[i].Name = answer;
                Console.WriteLine($"Успешно! Id: {accounts[i].Id} Старое имя: {old} Текущее имя: {accounts[i].Name}");
                break;
            }
        }

        void iClient.RateChange(List<iClient> accounts)
        {
            Console.WriteLine();
            Console.WriteLine($"Текущая банковская ставка = {rate} %; ");
            Console.Write($"Введите новую ставку: ");
            double answer = double.Parse(Console.ReadLine());
            if (rate > 0)
            {
                rate = 0;
                rate += answer;
                Console.WriteLine($"Успешно! Текущая ставка = {rate} %");
            }
            else if (rate == 0)
            {
                rate += answer;
                Console.WriteLine($"Успешно! Текущая ставка = {rate} %");
            }
        }

        public void RubDepoLimitChange(List<iClient> accounts)
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

        public void UsdDepoLimitChange(List<iClient> accounts)
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

        public void RubWithLimitChange(List<iClient> accounts)
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

        public void UsdwithLimitChange(List<iClient> accounts)
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

        public void RubTransactionChange(List<iClient> accounts)
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

        public void UsdTransactionChange(List<iClient> accounts)
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

        public void Depostit(List<iClient> accounts, int depo, int id, int newid)
        {
            for (int i = id; i < accounts.Count;i++)
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
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        }
                        else if (depo <= depositrubmaxlimit)
                        {
                            if (depo > depositrubminlimit)
                            {
                                accounts[i].RubBalance += depo;
                                Console.WriteLine($"{accounts[i].Name} - начислено {depo} р. на рублевой счёт");
                                accounts[i].ShowInfo(accounts, id);
                                ClientUsing.clientstart(accounts, id, newid);
                                break;
                            }
                            else if (depo < depositrubminlimit)
                            {
                                Console.WriteLine("Нельзя внести менее 50 рублей");
                                ClientUsing.clientstart(accounts, id, newid);
                                break;
                            }
                        }
                        else if (depo > depositrubmaxlimit)
                        {
                            Console.WriteLine("Нельзя внести более 100.000 р.");
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите сумму которую хотите добавить");
                        depo = int.Parse(Console.ReadLine());
                        if (depo < 0)
                        {
                            Console.WriteLine("Нельзя внести отрицательное кол-во денег.");
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        }
                        else if (depo <= depositusdmaxlimit)
                        {
                            if (depo > depositusdminlimit)
                            {
                                accounts[i].UsdBalance += depo;
                                Console.WriteLine($"{accounts[i].Name} - начислено {depo} $");
                                accounts[i].ShowInfo(accounts, id);
                                ClientUsing.clientstart(accounts, id, newid);
                                break;
                            }
                            else if (depo < depositrubminlimit)
                            {
                                Console.WriteLine("Нельзя внести менее 10 $");
                                ClientUsing.clientstart(accounts, id, newid);
                                break;
                            }
                        }
                        else if (depo > depositusdmaxlimit)
                        {
                            Console.WriteLine("Нельзя внести более 5.000 $");
                            ClientUsing.clientstart(accounts, id, newid);
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Неверное число!");
                        ClientUsing.clientstart(accounts, id, newid);
                        break;
                }
            }
            
        }

        public void Transation(List<iClient> accounts, int id, int id2, int newid)
        {
            if (id == id2)
            {
                Console.WriteLine("Нельзя сделать перевод самому себе!");
            }
            else if (id != id2)
            {
                Console.WriteLine($"Лимит для перевода на рублевой счёт - {rubmaxtransaction} р. долларовый счёт - {usdmaxtransaction} $ ");
                Console.WriteLine("С какого счёта вы хотите совершить перевод? 1 - с рублевого счёта; 2 - с долларового счёта");
                Console.Write("Введите цифру: ");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        for (int i = id; i < accounts.Count;)
                        {
                            for (int j = id2; j < accounts.Count;)
                            {
                                if (accounts[i].RubBalance <= 0)
                                {
                                    Console.WriteLine($"У {accounts[i].Name} нет денег на счёту для транзакции!");
                                    ClientUsing.clientstart(accounts, id, newid);
                                    break;
                                }
                                else if (accounts[i].RubBalance >= 0)
                                {
                                    Console.Write("Введите сумму для транзакции: ");
                                    double transsum = double.Parse(Console.ReadLine());
                                    if (transsum > accounts[i].RubBalance)
                                    {
                                        Console.WriteLine($"{accounts[i].Name} не имеет {transsum} р. для транзакции");
                                        ClientUsing.clientstart(accounts, id, newid);
                                        break;
                                    }
                                    else
                                    {
                                        if (transsum < rubmaxtransaction)
                                        {
                                            accounts[i].RubBalance -= transsum;
                                            accounts[j].RubBalance += transsum;
                                            Console.WriteLine($"{accounts[j].Name} успешно получил {transsum} р.");
                                            ClientUsing.clientstart(accounts, id, newid);
                                            break;
                                        }
                                        else if (transsum > rubmaxtransaction)
                                        {
                                            Console.WriteLine("Превышен лимит для перевода!");
                                            ClientUsing.clientstart(accounts, id, newid);
                                            break;
                                        }
                                    }
                                }
                                break;
                            }
                            break;

                        }
                        break;
                    case 2:
                        for (int i = id; i < accounts.Count;)
                        {
                            for (int j = id2; j < accounts.Count;)
                            {
                                if (accounts[i].UsdBalance <= 0)
                                {
                                    Console.WriteLine($"У {accounts[i].Name} нет денег на счёту для транзакции!");
                                    ClientUsing.clientstart(accounts, id, newid);
                                    break;
                                }
                                else
                                {
                                    Console.Write("Введите сумму для транзакции: ");
                                    double transsum = double.Parse(Console.ReadLine());
                                    if (transsum > accounts[i].UsdBalance)
                                    {
                                        Console.WriteLine($"{accounts[i].Name} не имеет {transsum} для транзакции");
                                        ClientUsing.clientstart(accounts, id, newid);
                                        break;
                                    }
                                    else
                                    {
                                        if (transsum < usdmaxtransaction)
                                        {
                                            accounts[i].UsdBalance -= transsum;
                                            accounts[j].UsdBalance += transsum;
                                            Console.WriteLine($"{accounts[j].Name} успешно получил {transsum} $");
                                            ClientUsing.clientstart(accounts, id, newid);
                                            break;
                                        }
                                        else if (transsum > usdmaxtransaction)
                                        {
                                            Console.WriteLine("Превышен лимит для перевода!");
                                            ClientUsing.clientstart(accounts, id, newid);
                                            break;
                                        }
                                    }
                                }
                                break;
                            }
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("Неверное число!");
                        ClientUsing.clientstart(accounts, id, newid);
                        break;

                }
            }
            
        }

        public void RubConvertation(List<iClient> accounts, int id)
        {
            for (int i = id; i < accounts.Count; i++)
            {
                Console.Write("Введите сумму для конвертации в рублях: ");
                double answer = double.Parse(Console.ReadLine());
                if (answer > accounts[i].RubBalance)
                {
                    Console.WriteLine($"У {accounts[i].Name} нет столько money в рублях!");
                    break;
                }
                else
                {
                    double sum;
                    sum = answer / wellrate;
                    int sum1 = Convert.ToInt32(sum);
                    accounts[i].UsdBalance += sum1;
                    double sum2 = Convert.ToDouble(sum1);
                    double F = sum - sum2;
                    accounts[i].RubBalance += F * wellrate;
                    accounts[i].RubBalance -= answer;
                    Console.WriteLine($"{accounts[i].Name} успешно конвертировал {answer} р. в доллары!");
                    break;
                }
            }
        }

        public void UsdConvertation(List<iClient> accounts, int id)
        {
            for (int i = id; i < accounts.Count;i++)
            {
                Console.Write("Введите сумму для конвертации в долларах: ");
                double answer = double.Parse(Console.ReadLine());
                if (answer > accounts[i].UsdBalance)
                {
                    Console.WriteLine($"У {accounts[i].Name} нет столько money в долларах!");
                    break;
                }
                else
                {
                    double sum;
                    sum = answer * wellrate;
                    int sum1 = Convert.ToInt32(sum);
                    accounts[i].RubBalance += sum1;
                    double sum2 = Convert.ToDouble(sum1);
                    accounts[i].UsdBalance -= answer;
                    Console.WriteLine($"{accounts[i].Name} успешно конвертировал {answer} $ в рубли!");
                }
            }
        }

        int iClient.DateBirth
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
        int iClient.Age
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
        int iClient.Id
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
        string iClient.Name
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
        double iClient.RubBalance
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
        double iClient.UsdBalance
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
    }
    
}
