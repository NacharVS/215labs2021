namespace Labs215Y2K.Bank
{
    class Account
    {
        public delegate void BalanceValueChangeDelegate(double diff, double newvalue);
        public event BalanceValueChangeDelegate BalanceChangeEvent;

        public string name;
        private double balance;

        public static double rate = 0.09;

        public double Balance 
        { 
            get => balance; 
            set
            {
                double oldValue = balance;
                double diff = value - oldValue;
                balance = value;
                BalanceChangeEvent?.Invoke(diff, value);
            } 
        }

        public Account(string name, double balance)
        {
            this.name = name;
            this.Balance = balance;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"{name} - {Balance}");
        }

        public static void ShowProfit(Account acc, int month)
        {
            for (int i = 0; i < month; i++)
            {
                acc.Balance += acc.Balance * rate;
            }
        }

        public void Deposit(double money)
        {

        }

        public void Withdraw(double money)
        {

        }

        public static void Transaction(Account accSeller, Account accGetter)
        {

        }

      
    }
}
