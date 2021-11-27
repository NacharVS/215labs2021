using Labs215Y2K.Bank;
using System;
class Account : IClientOperation
{
    private string _name;
    private double _balance;
    private double _dollarBalance;
    public int _userId;

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

    public string Name { get => _name; set => _name = value; }
    public double Balance { get => _balance; set => _balance = value; }
    public double DollarBalance { get => _dollarBalance; set => _dollarBalance = value; }
    double IClientOperation.Balance { get => _balance; set => _balance = value; }
    double IClientOperation.DollarBalance { get => _dollarBalance; set => _dollarBalance = value; }
    int IClientOperation.UserId { get => _userId; set => _userId = value; }

    public Account(string Name, double Balance, int dollarBalance, int UserId)
    {
        this._name = Name;
        this._balance = Balance;
        this._userId = UserId;
        this._dollarBalance = dollarBalance;
    }

    void IClientOperation.Info(Account acc)
    {
        if (Age == 0)
        {
            if (acc.Balance > 0)
            {
                System.Console.WriteLine($"Id - {_userId}, {Name} - Возраст не указан - {Balance} руб. - {DollarBalance}$");
            }
        }
        else
        {
            System.Console.WriteLine($"Id - {_userId}, {Name} - {Age} лет(год) - {Balance}");
        }
    }

    void IClientOperation.ShowInfo(Account acc)
    {
        if (Age >= 18)
        {
            if (Age == 0)
            {
                if (acc.Balance > 0)
                {
                    System.Console.WriteLine($"Id - {_userId}, {Name} - Возраст не указан - {Balance} руб. - {DollarBalance}$");
                }
            }
            else
            {
                System.Console.WriteLine($"Id - {_userId}, {Name} - {Age} лет(год) - {Balance} руб. - {DollarBalance}$ ");
            }
        }
    }

    void IClientOperation.ShowProfit(Account acc, int mountcounter)
    {
        for (int i = 0; i < mountcounter; i++)
        {
            acc.Balance += acc.Balance * rate;
        }
    }

    void IClientOperation.Deposit(Account acc)
    {
        Console.WriteLine();
        Console.WriteLine($"{acc.Name} - {acc.Balance}");
        while (true)
        {
            Console.WriteLine("Укажите сумму, которую вы хотите внести");
            double DepositMoney = double.Parse(Console.ReadLine());
            if (DepositMoney > 0)
            {
                acc.Balance = acc.Balance + DepositMoney;
                break;
            }
            else
            {
                Console.WriteLine("Вы ввели не верное значение");
                Console.WriteLine();
            }
        }
    }

    void IClientOperation.Withdraw(Account acc)
    {
        Console.WriteLine();
        Console.WriteLine($"{acc.Name} - {acc.Balance}");
        Console.WriteLine("Укажите сумму, которую вы хотите вывести");
        double WithdrawMoney = double.Parse(Console.ReadLine());
        acc.Balance = acc.Balance - WithdrawMoney;
        if (acc.Balance < 0)
        {
            Console.WriteLine("На балансе недостаточно средств");

        }
    }

    void IClientOperation.Transaction(Account acc, Account accSeller, Account accGetter)
    {
        Console.WriteLine();
        Console.WriteLine($"{acc.Name} - {acc.Balance}");
        Console.WriteLine($"Укажите сумму, которую вы хотите перевести");
        double TransactionMoney = double.Parse(Console.ReadLine());
        accSeller.Balance -= TransactionMoney;
        accGetter.Balance += TransactionMoney;
    }

    void IClientOperation.MoneyConvert(Account acc)
    {
        Console.WriteLine();
        Console.WriteLine("Введите 1, если хотите перевести рубли в доллары, 2, если хотите перевести доллары в рубли");
        int Counter = int.Parse(Console.ReadLine());
        if (Counter == 1)
        {
            acc.DollarBalance += acc.Balance / dollarcurse;
            acc.Balance = acc.Balance % dollarcurse;
            acc.DollarBalance = Convert.ToInt32(acc.DollarBalance);
        }
        if (Counter == 2)
        {
            acc.Balance += acc.DollarBalance * dollarcurse;
            acc.DollarBalance = 0;
        }
    }
}

    