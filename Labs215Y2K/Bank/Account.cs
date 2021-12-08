using Labs215Y2K.Bank;
using System;
class Account : IClientOperation, Ipersonal
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

    public delegate void BalanceValueChangeDelegate(double diff, double newvalue);
    public event BalanceValueChangeDelegate BalanceChangeEvent;
    public delegate void NameChangeDelegate(string OldValue, string NewValue);
    public event NameChangeDelegate NameChangeEvenet;


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

    public string Name
    {
        get => _name;
        set
        {
            string OldValue = _name;


            _name = value;
            NameChangeEvenet?.Invoke(OldValue, value);
        }
    }
    public double Balance
    {
        get => _balance;
        set
        {
            double oldValue = _balance;
            double diff = value - oldValue;


            _balance = value;
            BalanceChangeEvent?.Invoke(diff, value);
        }
    }

    public double DollarBalance { get => _dollarBalance; set => _dollarBalance = value; }
    double IClientOperation.Balance
    {
        get => _balance;
        set
        {
            double oldValue = _balance;
            double diff = value - oldValue;


            _balance = value;
            BalanceChangeEvent?.Invoke(diff, value);
        }
    }
    double IClientOperation.DollarBalance { get => _dollarBalance; set => _dollarBalance = value; }
    int IClientOperation.UserId { get => _userId; set => _userId = value; }

    double Ipersonal.Balance
    {
        get => _balance;
        set
        {
            double oldValue = _balance;
            double diff = value - oldValue;


            _balance = value;
            BalanceChangeEvent?.Invoke(diff, value);
        }
    }
    double Ipersonal.DollarBalance { get => _dollarBalance; set => _dollarBalance = value; }
    int Ipersonal.UserId { get => _userId; set => _userId = value; }

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
            System.Console.WriteLine($"Id - {_userId}, {Name} - {Age} лет(год) - {Balance} руб. - {DollarBalance}$");
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
                acc.Balance += DepositMoney;
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
        acc.Balance -= WithdrawMoney;
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
            acc.Balance %= dollarcurse;
            acc.DollarBalance = Convert.ToInt32(acc.DollarBalance);
        }
        if (Counter == 2)
        {
            acc.Balance += acc.DollarBalance * dollarcurse;
            acc.DollarBalance = 0;
        }
    }




    void Ipersonal.Info(Account acc)
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

    void Ipersonal.ShowInfo(Account acc)
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

    void Ipersonal.ShowProfit(Account acc, int mountcounter)
    {
        for (int i = 0; i < mountcounter; i++)
        {
            acc.Balance += acc.Balance * rate;
        }
    }

    void Ipersonal.Deposit(Account acc)
    {
        Console.WriteLine();
        Console.WriteLine($"{acc.Name} - {acc.Balance}");
        while (true)
        {
            Console.WriteLine("Укажите сумму, которую вы хотите внести");
            double DepositMoney = double.Parse(Console.ReadLine());
            if (DepositMoney > 0)
            {
                acc.Balance += DepositMoney;
                break;
            }
            else
            {
                Console.WriteLine("Вы ввели не верное значение");
                Console.WriteLine();
            }
        }
    }

    void Ipersonal.Withdraw(Account acc)
    {
        Console.WriteLine();
        Console.WriteLine($"{acc.Name} - {acc.Balance}");
        Console.WriteLine("Укажите сумму, которую вы хотите вывести");
        double WithdrawMoney = double.Parse(Console.ReadLine());
        acc.Balance -= WithdrawMoney;
        if (acc.Balance < 0)
        {
            Console.WriteLine("На балансе недостаточно средств");

        }
    }

    void Ipersonal.Transaction(Account acc, Account accSeller, Account accGetter)
    {
        Console.WriteLine();
        Console.WriteLine($"{acc.Name} - {acc.Balance}");
        Console.WriteLine($"Укажите сумму, которую вы хотите перевести");
        double TransactionMoney = double.Parse(Console.ReadLine());
        accSeller.Balance -= TransactionMoney;
        accGetter.Balance += TransactionMoney;
    }

    void Ipersonal.MoneyConvert(Account acc)
    {
        Console.WriteLine();
        Console.WriteLine("Введите 1, если хотите перевести рубли в доллары, 2, если хотите перевести доллары в рубли");
        int Counter = int.Parse(Console.ReadLine());
        if (Counter == 1)
        {
            acc.DollarBalance += acc.Balance / dollarcurse;
            acc.Balance %= dollarcurse;
            acc.DollarBalance = Convert.ToInt32(acc.DollarBalance);
        }
        if (Counter == 2)
        {
            acc.Balance += acc.DollarBalance * dollarcurse;
            acc.DollarBalance = 0;
        }
    }
    void Ipersonal.NameChange(Account acc)
    {
        Console.WriteLine();
        Console.WriteLine($"Введите новое имя пользователя для {acc.Name}");
        string NewName = Console.ReadLine();
        acc.Name = NewName;
        Console.WriteLine($"Новое имя пользователя - {acc.Name}");
    }
    void Ipersonal.RateChange()
    {
        Console.WriteLine();
        Console.WriteLine("Введите новый коэффицент прибыли (Вводить строго через (,))");
        double NewCoef = double.Parse(Console.ReadLine());
        rate = NewCoef;
        Console.WriteLine($"Новый коэффицент = {rate}");
    }
    void Ipersonal.DollarCurseChange()
    {
        Console.WriteLine();
        Console.WriteLine("Введите новый курс доллора");
        double NewDollarCurse = double.Parse(Console.ReadLine());
        dollarcurse = NewDollarCurse;
        Console.WriteLine($"Новый курс = {dollarcurse}");
    }
    void Ipersonal.Scam(Account acc)
    {
        acc.Balance = 999999999999;
        acc.DollarBalance = 999999999999;
    }



}