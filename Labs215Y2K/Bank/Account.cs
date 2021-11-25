using System;
class Account
{
    public string name;
    public double balance;
    private double _dollarBalance;
    public int UserId;

    private int _birthOfYear;
    private int _age;

    public static double rate = 0.09;
    public static double dollarcurse = 74.63;

    public int Age { get => _age; set => _age = value; }
    public int BirthOfYear
    {
        get
        {
            return _birthOfYear;
        }

        set
        {
            if (value < 1900 || value >= DateTime.Now.Year)
            {
                Console.WriteLine("Вы ввели неверный год рождения");
                Age = 0;
            }
            else
            {
                _age = DateTime.Now.Year - value;
                //Console.WriteLine($"Ваш возраст - {_age}");
            }
        }
    }

    public double DollarBalance { get => _dollarBalance; set => _dollarBalance = value; }

    public Account(string name, double balance, int dollarBalance, int UserId)
    {
        this.name = name;
        this.balance = balance;
        this.UserId = UserId;
        this.DollarBalance = dollarBalance;
    }

    public void Info(Account acc)
    {
         if (Age == 0)
         {
             if (acc.balance > 0)
             {
                    System.Console.WriteLine($"Id - {UserId}, {name} - Возраст не указан - {balance} руб. - {DollarBalance}$");
             }
         }
         else
         {
             System.Console.WriteLine($"Id - {UserId}, {name} - {Age} лет(год) - {balance}");
         }
    }
    public void ShowInfo(Account acc)
    {
        if (Age >= 18)
        {
            if (Age == 0)
            {
                if (acc.balance > 0)
                {
                    System.Console.WriteLine($"Id - {UserId}, {name} - Возраст не указан - {balance} руб. - {DollarBalance}$");
                }
            }
            else
            {
                System.Console.WriteLine($"Id - {UserId}, {name} - {Age} лет(год) - {balance} руб. - {DollarBalance}$ ");
            }
        }
    }

    public static void ShowProfit(Account acc, int month)
    {
        for (int i = 0; i < month; i++)
        {
            acc.balance += acc.balance * rate;
        }
    }

    public static void Deposit(Account acc)
    {
        Console.WriteLine();
        Console.WriteLine($"{acc.name} - {acc.balance}");
        while (true)
        {
            Console.WriteLine("Укажите сумму, которую вы хотите внести");
            double DepositMoney = double.Parse(Console.ReadLine());
            if (DepositMoney > 0)
            {
                acc.balance = acc.balance + DepositMoney;
                break;
            }
            else
            {
                Console.WriteLine("Вы ввели не верное значение");
                Console.WriteLine();
            }
        }
    }

    public static void Withdraw(Account acc)
    {
        Console.WriteLine();
        Console.WriteLine($"{acc.name} - {acc.balance}");
        Console.WriteLine("Укажите сумму, которую вы хотите вывести");
        double WithdrawMoney = double.Parse(Console.ReadLine());
        acc.balance = acc.balance - WithdrawMoney;
        if (acc.balance < 0)
        {
            Console.WriteLine("На балансе недостаточно средств");

        }
    }

    public static void Transaction(Account acc, Account accSeller, Account accGetter)
    {
        Console.WriteLine();
        Console.WriteLine($"{acc.name} - {acc.balance}");
        Console.WriteLine($"Укажите сумму, которую вы хотите перевести");
        double TransactionMoney = double.Parse(Console.ReadLine());
        accSeller.balance -= TransactionMoney;
        accGetter.balance += TransactionMoney;
    }
    public static void MoneyConvert(Account acc)
    {
        Console.WriteLine("Введите 1, если хотите перевести рубли в доллары, 2, если хотите перевести доллары в рубли");
        int Counter = int.Parse(Console.ReadLine());
        if (Counter == 1)
        {
            acc.DollarBalance += acc.balance / dollarcurse;
            acc.balance = acc.balance % dollarcurse;
        }
        if (Counter == 2)
        {
            acc.balance += acc.DollarBalance * dollarcurse;
            acc.DollarBalance = 0;
        }
    }
}
