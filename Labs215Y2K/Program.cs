using System;

namespace Labs215Y2K
{
    class Program
    {





        public static void Main()
        {
            //Account acc = new Account("Данил", 10000000, 1);




            Account acc1 = new Account("Ivan", 5000, new Random().Next(1234, 9876));
            Account acc2 = new Account("Fedor", 6000, new Random().Next(1234, 9876));
            Account acc3 = new Account("Elena", 3000, new Random().Next(1234, 9876));
            Console.WriteLine("Введите новое имя ");
            acc1.NameChangeEvent += Show;
            string Vvod = Console.ReadLine();
            acc1.Name = Vvod;
            Console.WriteLine("Введите новое ID (ID Должно состоять из четырех цифр)");
            acc1.IDChangeEvent += ShoWID;
            int VvodId = int.Parse(Console.ReadLine());
            acc1.Id = VvodId;



            acc1.ShowInfo(acc1);
            acc2.ShowInfo(acc2);
            acc3.ShowInfo(acc3);
            Console.WriteLine();
            Account.rate = 0.06;
            Console.WriteLine();
            Console.WriteLine("Введите количество месяцев");
            int mouth = int.Parse(Console.ReadLine());
            Console.WriteLine($"Через {mouth} меся(ц/ца/цев) Ваш баланс с коэффицентом {Account.rate} будет составлять:");
            acc1.ShowProfit(acc1, mouth);
            acc2.ShowProfit(acc2, mouth);
            acc3.ShowProfit(acc3, mouth);
            acc1.ShowInfo(acc1);
            acc2.ShowInfo(acc2);
            acc3.ShowInfo(acc3);
            acc3.Withdraw(acc3);
            acc3.ShowInfo(acc3);
            acc1.Deposit(acc1);
            acc1.ShowInfo(acc1);
            acc2.Transaction(acc1, acc2);
            acc2.ShowInfo(acc2);


        }

        public static void Show(string a, string b)
        {

            Console.WriteLine($"Новое имя {a}, старое {b}");
        }
        public static void ShoWID(int a, int b)
        {

            Console.WriteLine($"Новое id {a},и старое id {b}");
        }


    } 
}
