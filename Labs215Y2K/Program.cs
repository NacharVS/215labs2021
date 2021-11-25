using System;
using System.Linq;
using Units;
using Action;
using Labs215Y2K;

namespace Deletor
{
    public class MainClass
    {
        public static void Main()
        {
            int[,] array = new int[10, 10];
            int[] arraytwo = new int[10];
            int maxValue = 10;
            int sum = 0;




            //MaxMin.Maxmin.ex1(); // - максимальный элемент массива
            //Multplus.MultPlus.ex2();  // - Сумма и умножение массива
            //MaxElement.MaxElem.ex3(); // - Максимальный элемент в каждой строке
            //SumMatrix.SumMatrix.ex4(); // - Сумма каждой строки матрицы
            // SwapArray.Swap.ex5(); // - Меняет местами строки массива
            //TwoIdentElementDeletor.Deletor.ex7(); // - находит одинаковые числа в массиве
            // MatrixMult.Matrix.ex6(); // - Произведение двух матриц
            //Fill.Matrix.ex10(array);
            //Labs215Y2K.SummId.SummIdSort();
            //StudentsListsOperation();

            Console.WriteLine("Вас приветствует Банк Субботний Scam, самый надёжный банк в городе");
            Account acc1 = new Account("Ivan", 5000, 100 ,new Random().Next(121,9521));
            Account acc2 = new Account("Fedor", 6000, 20 ,new Random().Next(122, 9522));
            Account acc3 = new Account("Elena", 3000, 85 ,new Random().Next(123, 9523));
            Account acc4 = new Account("Yarik", 100, 1000 ,new Random().Next(124, 9525));
            Account acc5 = new Account("Egorik", 1000, 1 ,new Random().Next(125, 9526));

            int GetterCounter = 0;
            int SellerCounter = 0;
            int AccDepostCounter = 0;
            int AccWithdrawCounter = 0;
            int AccConvertCounter = 0;
            int[] UserIdMassive = new int[5];
            UserIdMassive[0] = acc1.UserId;
            UserIdMassive[1] = acc2.UserId;
            UserIdMassive[2] = acc3.UserId;
            UserIdMassive[3] = acc4.UserId;
            UserIdMassive[4] = acc5.UserId;
            Account[] UserMassive2 = new Account[5];
            UserMassive2[0] = acc1;
            UserMassive2[1] = acc2;
            UserMassive2[2] = acc3;
            UserMassive2[3] = acc4;
            UserMassive2[4] = acc5;

            acc1.Info(acc1);
            acc2.Info(acc2);
            acc3.Info(acc3);
            acc4.Info(acc4);
            acc5.Info(acc5);
            Console.WriteLine();
            System.Threading.Thread.Sleep(3000); 
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

            acc1.ShowInfo(acc1);
            acc2.ShowInfo(acc2); 
            acc3.ShowInfo(acc3); 
            acc4.ShowInfo(acc4); 
            acc5.ShowInfo(acc5); 
            Console.WriteLine(); 

            Console.WriteLine("Введите кол-во месяцев");
            int mountcounter = int.Parse(Console.ReadLine());
            Console.WriteLine("Профит за " +mountcounter+ " меся(ц/ца/цев) с коэффицентом " + Account.rate);
            Console.WriteLine();
            Account.ShowProfit(acc1, mountcounter);
            Account.ShowProfit(acc2, mountcounter);
            Account.ShowProfit(acc3, mountcounter);
            Account.ShowProfit(acc4, mountcounter);
            Account.ShowProfit(acc5, mountcounter);


            acc1.ShowInfo(acc1);
            acc2.ShowInfo(acc2);
            acc3.ShowInfo(acc3);
            acc4.ShowInfo(acc4);
            acc5.ShowInfo(acc5);

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

            Account.MoneyConvert(UserMassive2[AccConvertCounter]);
            UserMassive2[AccConvertCounter].ShowInfo(UserMassive2[AccConvertCounter]);

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

            Account.Deposit(UserMassive2[AccDepostCounter]);
            UserMassive2[AccDepostCounter].ShowInfo(UserMassive2[AccDepostCounter]);

          

            Console.WriteLine("Выберите Id пользователя у которого вы хотите отнять деньги");
            int AccWithdraw = int.Parse(Console.ReadLine());
            for (int i = 0; i < UserIdMassive.Length; i++)
            {
                if (UserIdMassive[i] == AccWithdraw)
                {
                    AccWithdrawCounter = i;
                }
            }
            Account.Withdraw(UserMassive2[AccWithdrawCounter]);
            UserMassive2[AccWithdrawCounter].ShowInfo(UserMassive2[AccWithdrawCounter]);

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
            Account.Transaction(UserMassive2[SellerCounter], UserMassive2[SellerCounter], UserMassive2[GetterCounter]);
            UserMassive2[SellerCounter].ShowInfo(UserMassive2[SellerCounter]);
            UserMassive2[GetterCounter].ShowInfo(UserMassive2[GetterCounter]);
            
        }
        public static void magaz(int[] numberofproduct, int yesno, string[] catalog, string[] korzina, int counter, int cycleoperation, int[] countofproduct, int[] korzinakolvo, int[] price, int[] Sum, int[] sumtwo, int[] korzinaprice)
        {
            int cou = 1;
            int pricecounter = 0;
            while (cycleoperation > 1)
            {
                Console.WriteLine("Выберите номер товара: ");
                numberofproduct[cou] = int.Parse(Console.ReadLine());
                Console.WriteLine("Выберите кол-во товара(товары на развес указывать в граммах с шагом в 100): ");
                countofproduct[cou] = int.Parse(Console.ReadLine());
                if (numberofproduct[pricecounter] < 6)
                {
                    Sum[pricecounter] += price[numberofproduct[pricecounter]] * countofproduct[pricecounter];
                    korzinaprice[pricecounter] = Sum[pricecounter];
                }
                Console.WriteLine();
                if (numberofproduct[pricecounter] > 5 && countofproduct[pricecounter] % 100 == 0)
                {
                    int check = countofproduct[pricecounter] / 100;
                    sumtwo[pricecounter] += price[numberofproduct[pricecounter]] * check;
                    korzinaprice[pricecounter] = sumtwo[pricecounter];
                }
                else
                {
                    Console.WriteLine("Кол-во товаров нужно указывать строго с шагом в 100");
                }
                //if (numberofproduct[cou] != 0)
                //{
                //    korzina[counter] = catalog[numberofproduct[cou]];
                //    Console.Write($"Корзина: {korzina[counter]}");
                //    counter++;

                //}
                cou++;
                pricecounter++;
                cycleoperation--;
            }
            Console.WriteLine();
            Console.Write($"Товар:       Кол-во:         Цена за 1шт:");
            Console.WriteLine();
            for (int i = 0; i < numberofproduct.Length; i++)
            {
                korzina[counter] = catalog[numberofproduct[i]];
                Console.Write($"{  korzina[counter]}          ");
                Console.Write($"{  countofproduct[counter]}          ");
                korzinakolvo[counter] = price[numberofproduct[i]];
                Console.Write($"{  korzinakolvo[counter]}         ");
                Console.Write($"{  korzinaprice[counter]}         ");
                counter++;
                Console.WriteLine();
            }
        }
        public static void ArrayOfMatrixSum(int[,] array, int maxValue, int sum)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(maxValue);
                    Console.Write($"{array[i, j]} ");
                    sum += array[i, j];

                }
                Console.Write($" summ - {sum}");
                Console.WriteLine();
                sum = 0;
            }
        }
        public static void StudentsListsOperation()
        {
            while (true)
            {
                Console.WriteLine("Для того чтобы вызвать список студентов введите 1");
                Console.WriteLine("Для того чтобы вызвать список студентов с оценками введите 2");
                Console.WriteLine("Для того чтобы вызвать список студентов проживающих в общежитие введите 3");
                while (true)
                {
                    try
                    {
                        int vvod = int.Parse(Console.ReadLine());
                        if (vvod == 1)
                        {
                            Labs215Y2K.StudentsSort.StudentSort();
                        }
                        if (vvod == 2)
                        {
                            Labs215Y2K.MarkStudentsSort.MarksSort();
                        }
                        if (vvod == 3)
                        {
                            Labs215Y2K.StudentsList.MarksSort();
                        }
                        if (vvod > 3)
                        {
                            Console.WriteLine("Вы использовали не правильный номер");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ввод не корректных данных");
                        break;
                    }
                }

                Console.WriteLine();
            }
        }
        //public static void UnitsCreator()
        //{
        //    Units.Builder Builder = new Units.Builder("Builder", 50, 10, 5, 30, 10);
        //    Console.WriteLine($"{Builder.name} {Builder.health} {Builder.damage} { Builder.armor} { Builder.speed} { Builder.atackspeed}");

        //    Units.Lumberjack Lumberjack = new Units.Lumberjack("Builder", 50, 10, 5, 30, 10);
        //    Console.WriteLine($"{Lumberjack.name} {Lumberjack.health} {Lumberjack.damage} { Lumberjack.armor} { Lumberjack.speed} { Lumberjack.atackspeed}");

        //    Units.Miners Miner = new Units.Miners("Builder", 50, 10, 5, 30, 10);
        //    Console.WriteLine($"{Builder.name} {.health} {.damage} { .armor} { .speed} { .atackspeed}");

        //    Units.Wariors Warior = new Units.Wariors("Builder", 50, 10, 5, 30, 10);
        //    Console.WriteLine($"{Builder.name} {.health} {.damage} { .armor} { .speed} { .atackspeed}");

        //    Units.Mages Mage = new Units.Mages("Builder", 50, 10, 5, 30, 10);
        //    Console.WriteLine($"{Builder.name} {.health} {.damage} { .armor} { .speed} { .atackspeed}");

        //    Units.Archers Archer = new Units.Archers("Builder", 50, 10, 5, 30, 10);
        //    Console.WriteLine($"{Builder.name} {.health} {.damage} { .armor} { .speed} { .atackspeed}");
        //}

        //UnitsCreator();

        //Console.WriteLine();
        //Labs215Y2K.ArrayOperations.ArrayGeneration(arraytwo,5,500);
        //Magazin.Ashan.catalog();
        //BuilderPeacful Builder = new BuilderPeacful("Builder", 50, 1, 10, 15, 30, 10);
        //WoodmanPeacful Woodman = new WoodmanPeacful("Woodman", 60, 1, 10, 15, 40, 15);
        //MinerPeacful Miner = new MinerPeacful("Miner", 65, 1, 10, 15, 45, 20);
        //Healer Healer = new Healer("Healer", 100, 100, 5, 15, 10, 25, 10, 50,30,2,50);
        //Warrior Warrior = new Warrior("Warrior", 100, 100, 30, 50, 50, 20, 45);
        //MageWarrior Mage = new MageWarrior("Mage", 120, 120, 10, 20, 70, 100, 45, 50, 30, 30);
        //ArcherWarrior Archer = new ArcherWarrior("Archer", 80, 80, 15, 25, 60, 80, 30, 100, 40, 40, 2);

        //Console.WriteLine("Хотите ли вы видеть характеристики персонажей? 1 - да, 0 - нет");
        //int pers = int.Parse(Console.ReadLine());
        //Console.WriteLine();

        //if (pers == 1)
        //{
        //    Console.WriteLine($"Имя - {Builder.name} \t Здоровье - {Builder.MaxHealth} \t Минимальный урон - {Builder.MinDamage} \t Максимальный урон - {Builder.MaxDamage}  Броня - {Builder.armor}  Скорость - {Builder.speed}  Скорость атаки - {Builder.workspeed}");

        //    Console.WriteLine($"Имя - {Woodman.name} \t Здоровье - {Woodman.MaxHealth} \t Минимальный урон - {Woodman.MinDamage} \t Максимальный урон - {Woodman.MaxDamage}  Броня - {Woodman.armor}  Скорость - { Woodman.speed}  Скорость атаки - {Woodman.workspeed}");

        //    Console.WriteLine($"Имя - {Miner.name} \t Здоровье - {Miner.MaxHealth} \t Минимальный урон - {Miner.MinDamage} \t Максимальный урон - {Miner.MaxDamage}  Броня - {Miner.armor}  Скорость - {Miner.speed}  Скорость атаки - {Miner.workspeed}");

        //    Console.WriteLine($"Имя - {Warrior.name} \t Здоровье - {Warrior.MaxHealth}  Минимальный урон - {Warrior.MinDamage} \t Максимальный урон - {Warrior.MaxDamage}  Броня - {Warrior.armor}  Скорость - {Warrior.speed}  Скорость атаки - {Warrior.atackspeed}");

        //    Console.WriteLine($"Имя - {Mage.name} \t Здоровье - {Mage.MaxHealth}  Минимальный урон - {Mage.MinDamage} \t Максимальный урон - {Mage.MaxDamage}  Броня - {Mage.armor}  Скорость - {Mage.speed}  Скорость атаки - {Mage.atackspeed}");

        //    Console.WriteLine($"Имя - {Healer.name} \t Здоровье - {Healer.MaxHealth}  Минимальный урон - {Healer.MinDamage} \t Максимальный урон - {Healer.MaxDamage}  Броня - {Healer.armor}  Скорость - {Healer.speed}  Восстанавливает xp - {Healer.Healing} ");

        //    Console.WriteLine($"Имя - {Archer.name} \t Здоровье - {Archer.MaxHealth} \t Минимальный урон - {Archer.MinDamage} \t Максимальный урон - {Archer.MaxDamage}  Броня - {Archer.armor}  Скорость - {Archer.speed}  Скорость атаки - {Archer.atackspeed}");
        //}
        //Console.WriteLine();

        //BuilderPeacful.Moving(Builder.name); WoodmanPeacful.Moving(Woodman.name); MinerPeacful.Moving(Miner.name);
        //Console.WriteLine();
        //Console.WriteLine();

        //ArcherWarrior.ArcherDamage(Archer.name, Archer.MinRangeDamage, Archer.MaxRangeDamage, Archer.MinDamage, Archer.MaxDamage , Warrior.name,Warrior.MaxHealth ,Archer.CurrentHealth, Warrior.armor, Archer.CurrentArrows,Warrior.CurrentHealth);

        //Healer.MageVSArcherAndHealer(Mage.name, Mage.MaxHealth, Mage.CurrentHealth, Mage.MinDamage, Mage.MaxDamage, Archer.name, Archer.MinRangeDamage, Archer.MaxRangeDamage, Archer.CurrentHealth, Archer.CurrentArrows,Healer.Healing);

        //MageWarrior.MageVSArcher(Mage.name, Mage.MaxHealth, Mage.CurrentHealth, Mage.MinDamage, Mage.MaxDamage, Archer.name, Archer.MinRangeDamage, Archer.MaxRangeDamage, Archer.CurrentHealth, Archer.CurrentArrows);


        //Archer Archer = new Archer();
        //Warrior Warrior = new Warrior();
        //Mage Mage = new Mage();
        //Healer Healer = new Healer();

        //Archer.Name = "Лучник"; Warrior.Name = "Воин"; Mage.Name = "Маг"; Healer.Name = "Целитель";

        //Archer.MinDamage = 15; Archer.MaxDamage = 20; Archer.Health = 40;
        //Warrior.MinDamage = 10; Warrior.MaxDamage = 18; Warrior.Health = 50;
        //Mage.MinDamage = 13; Mage.MaxDamage = 19; Mage.Health = 60;
        //Healer.Healing = 20; Healer.Health = 55;

        //Console.WriteLine("Бой между Лучником и Воином, если хотите посмотреть напишите 1");
        //Console.WriteLine("Бой между Магом и Воином, если хотите посмотреть напишите 2");
        //Console.WriteLine("Бой между Магом, Воином и Лучником, если хотите посмотреть напишите 3");

        //int choice = int.Parse(Console.ReadLine());
        //Console.WriteLine();

        //if (choice == 1)
        //{
        //    Console.WriteLine($"Бой между {Archer.Name} и {Warrior.Name}");
        //    while (Archer.Health != 0 && Warrior.Health != 0)
        //    {
        //        Actions.WarriorVSArcher(Archer, Warrior);
        //    }
        //}

        //if (choice == 2)
        //{
        //    Console.WriteLine($"Бой между {Mage.Name} и {Warrior.Name}");
        //    while (Mage.Health != 0 && Warrior.Health != 0)
        //    {
        //        Actions.MageVSWarior(Mage, Warrior);
        //    }
        //}

        //if (choice == 3)
        //{
        //    Console.WriteLine($"Бой между {Mage.Name}, {Warrior.Name} и {Archer.Name} (присутствует {Healer.Name})");
        //    while (Mage.Health != 0 && Warrior.Health != 0 && Archer.Health != 0)
        //    {
        //        Actions.ArcherVSMageVsWarrior(Mage, Warrior, Archer, Healer);
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Student[] students = new Student[3];
        //    Student student1 = new Student();
        //    student1.name = "Valeriy";
        //    student1.group = 222;
        //    student1.age = 16;
        //    Student student2 = new Student();
        //    student2.name = "Ivan";
        //    student2.group = 223;
        //    student2.age = 17;
        //    Student student3 = new Student();
        //    student3.name = "Sergey";
        //    student3.group = 221;
        //    student3.age = 18;

        //    students[0] = student1;
        //    students[1] = student2;
        //    students[2] = student3;

        //    foreach (var item in students)
        //    {
        //        if (item.age >= 18)
        //            Console.WriteLine(item.name);
        //    }




        //}
//        int ArrayRange = 0;
//        NewAshanUpdate[] Ashan = new NewAshanUpdate[100];
//        NewAshanUpdate[] Korzina = new NewAshanUpdate[100];
//        int CounterOfProducts = 0;
//        int CounterOfFilling = 0;
//        int CounterOfCyclices = 1;
//        string[] catalog = new string[] { "1. Гречка", "2. Макароны", "3. Молоко", "4. Хлеб", "5. Батон", "6. Конфеты", "7. Чипсы", "8. Сухари", "9. Попкорн", "10. Семечки" };
//        int[] price = new int[] { 130, 250, 50, 30, 30, 150, 100, 50, 150, 200 };
//        Ashan[CounterOfFilling] = new NewAshanUpdate();
//            for (CounterOfFilling = 0; CounterOfFilling<catalog.Length; CounterOfFilling++)
//            {
//                Ashan[CounterOfFilling] = new NewAshanUpdate();
//        Ashan[CounterOfFilling].Names = catalog[CounterOfFilling];
//                Ashan[CounterOfFilling].Price = price[CounterOfFilling];
//                Console.Write($"{Ashan[CounterOfFilling].Names} ");
//                Console.WriteLine($"\t{Ashan[CounterOfFilling].Price}");
//            }
//    //Ashan[CounterOfFilling].Price
//    Console.WriteLine();
//            while (CounterOfCyclices != 2)
//            {
//                Korzina[CounterOfProducts] = new NewAshanUpdate();
//    Ashan[CounterOfProducts] = new NewAshanUpdate();
//    Console.WriteLine("Хотите приобрести товар? 1 - Да, 2 - Нет");
//                CounterOfCyclices = int.Parse(Console.ReadLine());
//                if (CounterOfCyclices == 1)
//                {
//                    ArrayRange+=1;
//                    Console.WriteLine("Введите номер товара, который вам нужен");
//                    int KorzinaNumber = int.Parse(Console.ReadLine()) - 1;
//    Korzina[CounterOfProducts].NumberOfProduct = Ashan[KorzinaNumber].Names;
//                    Console.WriteLine("Введите кол-во товара");
//                    Korzina[CounterOfProducts].Count = int.Parse(Console.ReadLine());
//                    if (KorzinaNumber-1 < 6)
//                    {
//                        Korzina[CounterOfProducts].Price += Ashan[CounterOfProducts].Price* Ashan[CounterOfProducts].Count;
//                    }
//Console.WriteLine();
//if (KorzinaNumber > 5 && Ashan[CounterOfProducts].Count % 100 == 0)
//{
//    int check = Ashan[CounterOfProducts].Count / 100;
//    Korzina[CounterOfProducts].Price += Ashan[CounterOfProducts].Price * check;
//}
//                    //        else
//                    //{
//                    //    Console.WriteLine("Кол-во товаров нужно указывать строго с шагом в 100");
//                    //}
//                }
//                else
//{
//    break;
//}
//CounterOfProducts++;
//            }
//            for (int i = 0; i < ArrayRange; i++)
//{
//    Console.Write($"{Korzina[i].NumberOfProduct}");
//    Console.Write($"\t{Korzina[i].Count} ");
//    Console.WriteLine($"\t{Korzina[0].Price}");
//}
    }
}
