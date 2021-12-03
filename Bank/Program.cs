using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Account acc1 = new Account("MyName", 500, 100, 1901, 0);
            Account employer1 = new Account("Хоязин", 666666, 555, 1905, 1337);
            Account acc2 = new Account("Fedor", 6000, 0, 2004, 1);
            Account acc3 = new Account("Elena", 3000, 0, 1987, 2);
            IUserOperations user1 = acc1;
            IUserOperations user2 = acc2;
            IUserOperations user3 = acc3;
            IEmployer employer = employer1;

            acc1.BalanceUSD = 5;            
            acc1.NameChangeEvent += Show;
            acc1.BalanceChangeEvent += ShowRUB;
            user1.Showinfo(acc1);



        }
        static void Show(string oldName, string newName)
        {
            Console.WriteLine($"Имя было изменено с {oldName} на {newName}");
        }
        static void ShowRUB(double oldValue, double newValue)
        {
            Console.WriteLine($"balance changed with {oldValue}, new balance ={newValue}");
        }





        //public static void Work()
        //{
        //    Account[] array = new Account[100];

        //    Account acc1 = new Account("MyName", 500,100,  1901, 0);
        //    Account acc2 = new Account("Fedor", 6000, 0, 2004, 1);
        //    Account acc3 = new Account("Elena", 3000,0, 1987, 2);
        //    array[0] = acc1;
        //    array[1] = acc2;
        //    array[2] = acc3;

        //    Console.WriteLine("Введите ID пользователя, с которого Вы хотите начать работу.");
        //    int userID = int.Parse(Console.ReadLine());
        //    Console.WriteLine("На данный момент вы можете:");
        //    Console.WriteLine("(1) - Пополнить счёт.");
        //    Console.WriteLine("(2) - Снять деньги со счёта.");
        //    Console.WriteLine($"(3) - Узнать свой будущий профит за год с процентной ставкой в {Account.rate*100}. % в месяц");
        //    Console.WriteLine("(4) - Узнать свой баланс.");
        //    Console.WriteLine("(5) - Перевести деньги с одного счета на другой");
        //    Console.WriteLine("Введите номер необходимой операции");
        //    string number = Console.ReadLine();
        //    if (userID == 0)
        //    {
        //        switch (number)
        //        {
        //            case "1":

        //                Actions.ShowInfo(acc1);
        //                break;
        //            case "2":
        //                Actions.Withdraw(acc1);
        //                Actions.ShowInfo(acc1);
        //                break;
        //            case "3":
        //                Actions.ShowProfit(acc1, 12);
        //                break;
        //            case "4":
        //                Actions.ShowInfo(acc1);
        //                break;
        //            case "5":
        //                Console.WriteLine("Введите ID пользователя, которому хотите перевести деньги.");
        //                int getterId = int.Parse(Console.ReadLine());
        //                for (int i = 0; i< array.Length; i++)
        //                {
        //                    if (array[i]==array[getterId])
        //                    {
        //                        Actions.Transaction(acc1, array[getterId]);
        //                        Actions.ShowInfo(acc1);
        //                    }
        //                }
        //                break;
        //        }

        //    }
        //}
    }
}
