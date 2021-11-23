using System;
class Account
{
    public string name;
    public double balance;
    public int UserId;

    public static double rate = 0.09;

    public Account(string name, double balance,int UserId)
    {
        this.name = name;
        this.balance = balance;
        this.UserId = UserId;
    }

    public void ShowInfo(Account acc)
    {
        if (acc.balance > 0)
        {
            System.Console.WriteLine($"Id - {UserId}, {name} - {balance}");
        }
    }

    public static void ShowProfit(Account acc, int month)
    {
        for (int i = 0; i < month; i++)
        {
            acc.balance += acc.balance * rate;
        }
    }

    public void Deposit(Account acc)
    {
        Console.WriteLine();
        Console.WriteLine($"{acc.name} - {acc.balance}");
        Console.WriteLine("Укажите сумму, которую вы хотите внести");
        double DepositMoney = double.Parse(Console.ReadLine());
        acc.balance = acc.balance + DepositMoney;
    }

    public void Withdraw(Account acc)
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
}
