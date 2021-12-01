using System;
using System.ComponentModel.DataAnnotations;
using Units;
using Action;
using Labs215Y2K.Bank;

namespace Labs215Y2K
{
    class Program
    {
         static void Main(string[] args)
         {
            ////int[] qq = new int[10];
            //int[,] qqnya = new int[10, 5];
            ////ArrayOperations.ArrayGeneration(qq, 11, 50);
            //ArrayOperations.ArrayGeneration(qqnya, 2);
            //Magazin.Ashan.catalog();
            //StudentsSort.StudentsSort.StudentSort();

            CleaningWoman Woman = new CleaningWoman("Галина", "Ивановна");
            SecurityGuard Guard = new SecurityGuard("Данил", "Тавевский");

            Console.WriteLine("Вас приветствует Банк Субботний Scam, самый надёжный банк в городе");

            Account acc1 = new Account("Ivan", 5000, 100, new Random().Next(121, 9521));
            Account acc2 = new Account("Fedor", 6000, 20, new Random().Next(122, 9522));
            Account acc3 = new Account("Elena", 3000, 85, new Random().Next(123, 9523));
            Account acc4 = new Account("Yarik", 100, 100000, new Random().Next(777, 778));
            Account acc5 = new Account("Egorik", 100000, 1, new Random().Next(125, 9526));

            IClientOperation Cl1 = acc1;
            IClientOperation Cl2 = acc2;
            IClientOperation Cl3 = acc3;
            IClientOperation Cl4 = acc4;
            IClientOperation Cl5 = acc5;

            Console.WriteLine();
            Guard.Actions();
            Console.WriteLine();

            Ipersonal Pers1 = acc1;


            int GetterCounter = 0;
            int SellerCounter = 0;
            int AccDepostCounter = 0;
            int AccWithdrawCounter = 0;
            int AccConvertCounter = 0;
            int AccPersCounter = 0;
            int[] UserIdMassive = new int[5];
            UserIdMassive[0] = Cl1.UserId;
            UserIdMassive[1] = Cl2.UserId;
            UserIdMassive[2] = Cl3.UserId;
            UserIdMassive[3] = Cl4.UserId;
            UserIdMassive[4] = Cl5.UserId;
            IClientOperation[] UserMassive2 = new IClientOperation[5];
            UserMassive2[0] = Cl1;
            UserMassive2[1] = Cl2;
            UserMassive2[2] = Cl3;
            UserMassive2[3] = Cl4;
            UserMassive2[4] = Cl5;
            Ipersonal[] UserMassive1 = new Ipersonal[1];
            UserMassive1[0] = Pers1;
            Account[] UserMassive3 = new Account[5];
            UserMassive3[0] = acc1;
            UserMassive3[1] = acc2;
            UserMassive3[2] = acc3;
            UserMassive3[3] = acc4;
            UserMassive3[4] = acc5;

            Cl1.Info(acc1);
            Cl2.Info(acc2);
            Cl3.Info(acc3);
            Cl4.Info(acc4);
            Cl5.Info(acc5);
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            //Console.WriteLine($"{acc1.name} Введите Ваш год рождения: ");
            //acc1.BirthOfYear = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine($"{acc2.name} Введите Ваш год рождения: ");
            //acc2.BirthOfYear = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine($"{acc3.name} Введите Ваш год рождения: ");
            //acc3.BirthOfYear = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine($"{acc4.name} Введите Ваш год рождения: ");
            //acc4.BirthOfYear = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine($"{acc5.name} Введите Ваш год рождения: ");
            //acc5.BirthOfYear = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            acc1.BirthOfYear = new Random().Next(1940, DateTime.Now.Year);
            acc2.BirthOfYear = new Random().Next(1940, DateTime.Now.Year);
            acc3.BirthOfYear = new Random().Next(1940, DateTime.Now.Year);
            acc4.BirthOfYear = new Random().Next(1940, DateTime.Now.Year);
            acc5.BirthOfYear = new Random().Next(1940, DateTime.Now.Year);


            Console.WriteLine("Введите секретный символ, чтобы заскамить всех и уехать на Мальдивы");
            if (Console.ReadKey().Key == ConsoleKey.Q)
            {
                Console.WriteLine();
                Pers1.Scam(acc5);
                Console.WriteLine();
                Cl5.Info(acc5);
                Console.WriteLine();
                Console.WriteLine("Заскамил всех и улетел");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }

            Cl1.ShowInfo(acc1);
            Cl2.ShowInfo(acc2);
            Cl3.ShowInfo(acc3);
            Cl4.ShowInfo(acc4);
            Cl5.ShowInfo(acc5);
            Console.WriteLine();


            Console.WriteLine("Выберите Id пользователя которому вы хотите поменять имя");
            int AccPersId = int.Parse(Console.ReadLine());
            for (int i = 0; i < UserIdMassive.Length; i++)
            {
                if (UserIdMassive[i] == AccPersId)
                {
                    AccPersCounter = i;
                }
            }
            UserMassive1[0].NameChange(UserMassive3[AccPersCounter]);
            UserMassive1[0].RateChange();


            Console.WriteLine("Введите кол-во месяцев");
            int mountcounter = int.Parse(Console.ReadLine());
            Console.WriteLine("Профит за " + mountcounter + " меся(ц/ца/цев) с коэффицентом " + Account.rate);
            Console.WriteLine();


            Cl1.ShowProfit(acc1, mountcounter);
            Cl2.ShowProfit(acc2, mountcounter);
            Cl3.ShowProfit(acc3, mountcounter);
            Cl4.ShowProfit(acc4, mountcounter);
            Cl5.ShowProfit(acc5, mountcounter);


            Cl1.ShowInfo(acc1);
            Cl2.ShowInfo(acc2);
            Cl3.ShowInfo(acc3);
            Cl4.ShowInfo(acc4);
            Cl5.ShowInfo(acc5);

            Console.WriteLine();
            Console.WriteLine("Выберите Id пользователя которому вы хотите конвертировать деньги");
            int AccConvertId = int.Parse(Console.ReadLine());
            for (int i = 0; i < UserIdMassive.Length; i++)
            {
                if (UserIdMassive[i] == AccConvertId)
                {
                    AccConvertCounter = i;
                }
            }

            UserMassive2[AccConvertCounter].MoneyConvert(UserMassive3[AccConvertCounter]);
            UserMassive2[AccConvertCounter].ShowInfo(UserMassive3[AccConvertCounter]);

            Console.WriteLine();
            Console.WriteLine("Выберите Id пользователя которому вы хотите добавить деньги");
            int AccDeposit = int.Parse(Console.ReadLine());
            for (int i = 0; i < UserIdMassive.Length; i++)
            {
                if (UserIdMassive[i] == AccDeposit)
                {
                    AccDepostCounter = i;
                }
            }

            UserMassive2[AccDepostCounter].Deposit(UserMassive3[AccDepostCounter]);
            UserMassive2[AccDepostCounter].ShowInfo(UserMassive3[AccDepostCounter]);


            Console.WriteLine();
            Console.WriteLine("Выберите Id пользователя у которого вы хотите отнять деньги");
            int AccWithdraw = int.Parse(Console.ReadLine());
            for (int i = 0; i < UserIdMassive.Length; i++)
            {
                if (UserIdMassive[i] == AccWithdraw)
                {
                    AccWithdrawCounter = i;
                }
            }
            UserMassive2[AccWithdrawCounter].Withdraw(UserMassive3[AccWithdrawCounter]);
            UserMassive2[AccWithdrawCounter].ShowInfo(UserMassive3[AccWithdrawCounter]);

            Console.WriteLine();
            Console.WriteLine("Минутка уборки, Не ходить по помытому полу!!!!!!");
            Woman.Actions();
            System.Threading.Thread.Sleep(5000);

            Console.WriteLine();
            Console.WriteLine("Выберите Id пользователя которому вы хотите перевести");
            int AccGetterId = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите Id пользователя от которого вы хотите перевести");
            int AccGetterSeller = int.Parse(Console.ReadLine());
            for (int i = 0; i < UserIdMassive.Length; i++)
            {
                if (UserIdMassive[i] == AccGetterId)
                {
                    GetterCounter = i;
                }
                if (UserIdMassive[i] == AccGetterSeller)
                {
                    SellerCounter = i;
                }
            }
            UserMassive2[SellerCounter].Transaction(UserMassive3[SellerCounter], UserMassive3[SellerCounter], UserMassive3[GetterCounter]);
            UserMassive2[SellerCounter].ShowInfo(UserMassive3[SellerCounter]);
            UserMassive2[GetterCounter].ShowInfo(UserMassive3[GetterCounter]);

        }
        public static void magaz(int[] numberofproduct, int yesno, string[] catalog, string[] korzina, int counter, int cycleoperation, int[] countofproduct, int[] korzinakolvo, int[] price, int[] Sum, int[] sumtwo, int[] korzinaprice)
        {
            int cou = 1;
            while (cycleoperation > 1)
            {
                Console.WriteLine("Выберите номер товара: ");
                numberofproduct[cou] = int.Parse(Console.ReadLine());
                Console.WriteLine("Выберите кол-во товара(товары на развес указывать в граммах с шагом в 100): ");
                countofproduct[cou] = int.Parse(Console.ReadLine());
                cou++;
                cycleoperation--;
                if (numberofproduct[cou] < 6)
                {
                    Sum[cou] += price[numberofproduct[cou]] * countofproduct[cou];
                    Console.WriteLine(Sum);
                }
                Console.WriteLine();

                if (numberofproduct[cou] > 5 && countofproduct[cou] % 100 == 0)
                {
                    int check = countofproduct[cou] / 100;
                    sumtwo[cou] += price[numberofproduct[cou]] * check;
                    Console.WriteLine(sumtwo);
                }
                else
                {
                    Console.WriteLine("Кол-во товаров нужно указывать строго с шагом в 100");
                }
                if (numberofproduct[cou] != 0)
                {
                    korzina[counter] = catalog[numberofproduct[cou]];
                    Console.Write($"Корзина: {korzina[counter]}");
                    counter++;

                }

            }
            Console.WriteLine();
            Console.Write($"Товар:       Кол-во:         Цена:");
            Console.WriteLine();

            for (int i = 0; i < numberofproduct.Length; i++)
            {
                korzina[counter] = catalog[numberofproduct[i]];
                Console.Write($"{  korzina[counter]}          ");
                Console.Write($"{  countofproduct[counter]}          ");
                korzinakolvo[counter] = price[numberofproduct[i]];
                Console.Write($"{  korzinakolvo[counter]}         ");

                if (numberofproduct[cou] < 6)
                {
                    korzinaprice[counter] = Sum[counter];
                }
                else
                {
                    korzinaprice[counter] = sumtwo[counter];
                }
                Console.WriteLine($"{korzinaprice[counter]}");
                counter++;
                Console.WriteLine();
            }
        }

        //public static void UnitsCreator()
        //{
            //NewAshan Product1 = new NewAshan(1, "Гречка", 130.50,"шт.", 9);
            //NewAshan Product2 = new NewAshan(2, "Макароны", 250.50, "шт.", 8);
            //NewAshan Product3 = new NewAshan(3, "Молоко", 50.50, "шт.", 7);
            //NewAshan Product4 = new NewAshan(4, "Хлеб", 30.50, "шт.", 4);
            //NewAshan Product5 = new NewAshan(5, "Батон", 30.50, "шт.", 5);
            //NewAshan Product6 = new NewAshan(6, "Конфеты", 150.50, "кг.", 11);
            //NewAshan Product7 = new NewAshan(7, "Чипсы", 100.50, "кг.", 5);
            //NewAshan Product8 = new NewAshan(8, "Сухари", 50.50, "кг.", 4);
            //NewAshan Product9 = new NewAshan(9, "Попкорн", 150.50, "кг.", 6);
            //NewAshan Product10 = new NewAshan(10, "Семечки", 200.50, "кг.", 3);

            //Console.WriteLine("Хотите увидеть список продуктов? 1 - да, 2 - нет");
            //int YesOrNo = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //if (YesOrNo == 1)
            //{
            //    Console.Write("Номер товара \t Название товара \t Цена товара (за 1 шт. или кг) \t Кол-во товара");
            //    Console.WriteLine();
            //    Console.WriteLine($"{Product1.NumberOfProduct} \t \t {Product1.Names} \t \t {Product1.Price} \t {Product1.PieceOrWeight} \t \t \t {Product1.Quantity}");
            //    Console.WriteLine($"{Product2.NumberOfProduct} \t \t {Product2.Names} \t \t {Product2.Price} \t {Product2.PieceOrWeight} \t \t \t {Product2.Quantity}");
            //    Console.WriteLine($"{Product3.NumberOfProduct} \t \t {Product3.Names} \t \t {Product3.Price} \t {Product3.PieceOrWeight} \t \t \t {Product3.Quantity}");
            //    Console.WriteLine($"{Product4.NumberOfProduct} \t \t {Product4.Names} \t \t \t {Product4.Price} \t {Product4.PieceOrWeight} \t \t \t {Product4.Quantity}");
            //    Console.WriteLine($"{Product5.NumberOfProduct} \t \t {Product5.Names} \t \t \t {Product5.Price} \t {Product5.PieceOrWeight} \t \t \t {Product5.Quantity}");
            //    Console.WriteLine($"{Product6.NumberOfProduct} \t \t {Product6.Names} \t \t {Product6.Price} \t {Product6.PieceOrWeight} \t \t \t {Product6.Quantity}");
            //    Console.WriteLine($"{Product7.NumberOfProduct} \t \t {Product7.Names} \t \t \t {Product7.Price} \t {Product7.PieceOrWeight} \t \t \t {Product7.Quantity}");
            //    Console.WriteLine($"{Product8.NumberOfProduct} \t \t {Product8.Names} \t \t {Product8.Price} \t {Product8.PieceOrWeight} \t \t \t {Product8.Quantity}");
            //    Console.WriteLine($"{Product9.NumberOfProduct} \t \t {Product9.Names} \t \t {Product9.Price} \t {Product9.PieceOrWeight} \t \t \t {Product9.Quantity}");
            //    Console.WriteLine($"{Product10.NumberOfProduct} \t \t {Product10.Names} \t \t {Product10.Price} \t {Product10.PieceOrWeight} \t \t \t {Product10.Quantity}");

            //}
            //else
            //{
            //    Console.WriteLine("Список не выведен");
            //}

        //}
    }
}
