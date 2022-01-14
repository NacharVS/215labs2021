﻿using System;
using Labs215Y2K.Bank;
using Labs215Y2K.NewBank;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Labs215Y2K.UnityProjects;
using static System.Console;
using Labs215Y2K.MongoExamples;

namespace Deletor
{
    public class Program
    {
        // Переменные
        private const int MapWidth = 30; // Размер консоли
        private const int MapHeight = 20; // Высота консоли

        private const int ScreenWidth = MapWidth * 3; //Размер окна
        private const int ScreenHeight = MapHeight * 3; //Высота окна

        private const int FrameMs = 200; // Задержка

        private const ConsoleColor BorderColor = ConsoleColor.Gray; // Цвет поля

        private const ConsoleColor HeadColor = ConsoleColor.DarkBlue; // Цвет головы
        private const ConsoleColor BodyColor = ConsoleColor.Cyan; // Цвет тела
        private const ConsoleColor FoodColor = ConsoleColor.Green; // Цвет Еды

        private static readonly Random Random = new Random();



        private static async Task Main()
        {
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
            //bank(); //- банк
            //NewBank();

            //SetWindowSize(ScreenWidth, ScreenHeight);
            //SetBufferSize(ScreenWidth, ScreenHeight);

            //CursorVisible = false;

            //Console.WriteLine($"Метод main начал свою работу в потоке  - {Thread.CurrentThread.ManagedThreadId}");
            //await Menu();
            //Console.WriteLine($"Метод main законьчил свою работу в потоке  - {Thread.CurrentThread.ManagedThreadId}");
            //Console.ReadLine();
            Console.WriteLine("Начало: ");
            int processing = 0;
            int number = 1;
            while (processing != 1)
            {
                Console.WriteLine("Введите Фамилию");
                string surname = Console.ReadLine();

                Console.WriteLine("Введите Имя");
                string name = Console.ReadLine();

                Console.WriteLine("Введите Отчество");
                string patronymic = Console.ReadLine();

                Console.WriteLine("Введите Гендер");
                string gender = Console.ReadLine();

                Console.WriteLine("Введите год рождения");
                int yearOfBirth = int.Parse(Console.ReadLine());

                int age = DateTime.Now.Year - yearOfBirth;

                Console.WriteLine("Есть у вас работа? (Есть/Нет)");
                string work = Console.ReadLine();

                Console.WriteLine("Играете ли вы в видео игры? (Да/Нет)");
                string playGames = Console.ReadLine();

                Console.WriteLine("Как вы относитесь к Apex Legends? (Да/Нет)");
                string attention = Console.ReadLine();

                //if (playGames == "Да")
                //{
                //    Console.WriteLine("Как вы относитесь к Apex Legends? (Да/Нет)");
                //    string attention = Console.ReadLine();
                //}
                //else
                //{
                //    string attention = "Не играет в видео игры";
                //}

                Console.WriteLine("");

                Extensions.AddToDataBase(number, surname, name, patronymic, gender, yearOfBirth, age, work, playGames, attention);
                Console.WriteLine("Напишите (Стоп), если хотите закончить");
                Console.WriteLine("Нажмите (Enter), чтобы продолжить");
                string input = Console.ReadLine();
                input.ToUpper();
                number++;
                if (input == "Стоп")
                {
                    processing = 1;
                }
            }


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


        static void Show(double a, double b)
        {
            Console.WriteLine($"Баланс изменён на {a} руб. , новый баланс = {b} руб. ");
            Console.WriteLine();
        }
        static void NameChange(string OldName, string NewName)
        {
            Console.WriteLine($"{OldName} было измененно на {NewName} ");
            Console.WriteLine();
        }
        public static void bank()
        {
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
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            acc4.NameChangeEvenet += NameChange;
            acc4.Name = "Крутой чел";

            acc1.BalanceChangeEvent += Show;
            acc1.Balance = 3000;

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
            if (Console.ReadKey().Key == ConsoleKey.Delete)
            {
                Console.WriteLine();
                Pers1.Scam(acc5);
                Console.Clear();
                Cl5.Info(acc5);
                Console.WriteLine();
                Console.WriteLine("Заскамил всех и улетел");
                Console.WriteLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Оу щит, ты не угадал");
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

            Console.WriteLine();
            Console.WriteLine("Всё, банк закрылся");
        }
        public static void NewBank()
        {
            Console.WriteLine("Вас приветствует Банк Субботний Scam, самый надёжный банк в городе");

            List<BankAccounts> Accounts = new List<BankAccounts>();

            Accounts.Add(new BankAccounts("Ivan", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 5000, 100, new Random().Next(121, 9521))); //Accounts[0]
            Accounts.Add(new BankAccounts("Fedor", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 6000, 20, new Random().Next(122, 9522))); //Accounts[1]
            Accounts.Add(new BankAccounts("Elena", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 3000, 85, new Random().Next(123, 9523))); //Accounts[2] 
            Accounts.Add(new BankAccounts("Yarik", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 100, 100000, new Random().Next(777, 778))); //Accounts[3]
            Accounts.Add(new BankAccounts("Egorik", DateTime.Now.Year - new Random().Next(1940, DateTime.Now.Year), 100000, 1, new Random().Next(125, 9526))); //Accounts[4]

            foreach (var item in Accounts)
            {
                Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}, Возраст - {item.Age}, {item.Balance} руб., {item.Dollarbalance}$");
            }
            if (Accounts[0].Age < 18 )
            {
                Accounts.Remove(Accounts[0]);
                Accounts[0].Name = ($"Заблокирован {Accounts[0].Name} Причина: Нет 18 лет");
            }
            //if (Accounts[1].Age < 18)
            //{
            //    Accounts.Remove(Accounts[1]);
            //    Accounts[1].Name = ($"Заблокирован {Accounts[0].Name} Причина: Нет 18 лет");
            //}
            //if (Accounts[2].Age < 18)
            //{
            //    Accounts.Remove(Accounts[2]);
            //    Accounts[2].Name = ($"Заблокирован {Accounts[0].Name} Причина: Нет 18 лет");
            //}
            //if (Accounts[3].Age < 18)
            //{
            //    Accounts.Remove(Accounts[3]);
            //    Accounts[3].Name = ($"Заблокирован {Accounts[0].Name} Причина: Нет 18 лет");
            //}
            //if (Accounts[4].Age < 18)
            //{
            //    Accounts.Remove(Accounts[4]);
            //    Accounts[4].Name = ($"Заблокирован {Accounts[0].Name} Причина: Нет 18 лет");
            //}
            Console.WriteLine("Введите кол-во месяцев");
            int mountcounter = int.Parse(Console.ReadLine());
            Console.WriteLine();


            for (int i = 0; i < mountcounter; i++)
            {
                for (int a = 0; a < Accounts.Count - 1; a++)
                {
                    Accounts[a].Balance += Accounts[a].Balance * BankAccounts.rate;
                    Accounts[a].Balance += Accounts[a].Balance * BankAccounts.rate;
                    Accounts[a].Balance += Accounts[a].Balance * BankAccounts.rate;
                    Accounts[a].Balance += Accounts[a].Balance * BankAccounts.rate;
                    Accounts[a].Balance += Accounts[a].Balance * BankAccounts.rate;
                }

            }

            foreach (var item in Accounts)
            {
                Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}, Возраст - {item.Age}, {item.Balance} руб., {item.Dollarbalance}$");
            }

            Console.WriteLine();
            Console.WriteLine("Введите id пользователя, которому хотите внести деньги (Иван)");
            int ClientIdDeposit = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (Accounts[0].Id == ClientIdDeposit)
            {
                Console.WriteLine("Укажите сумму, которую вы хотите внести");
                double DepositMoney = double.Parse(Console.ReadLine());
                if (DepositMoney > 0)
                {
                    Accounts[0].Balance = Accounts[0].Balance + DepositMoney;
                }
                else
                {
                    Console.WriteLine("Вы ввели не верное значение");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Пользователь не найден");
                Console.WriteLine();
            }

            foreach (var item in Accounts)
            {
                Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}, Возраст - {item.Age}, {item.Balance} руб., {item.Dollarbalance}$");
            }

            Console.WriteLine();
            Console.WriteLine("Введите id пользователя, у которого вы хотите снять деньги (Елена)");
            int ClientIdWithdraw = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (Accounts[2].Id == ClientIdWithdraw)
            {
                if (Accounts[2].Balance > 0)
                {

                    Console.WriteLine("Укажите сумму, которую вы хотите вывести");
                    double WithdrawMoney = double.Parse(Console.ReadLine());
                    if (WithdrawMoney > 0)
                    {
                        Accounts[2].Balance = Accounts[2].Balance - WithdrawMoney;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не верное значение");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Недостаточно средств");
                }
            }
            else
            {
                Console.WriteLine("Пользователь не найден");
                Console.WriteLine();
            }

            foreach (var item in Accounts)
            {
                Console.WriteLine($"Id - {item.Id}, Имя - {item.Name}, Возраст - {item.Age}, {item.Balance} руб., {item.Dollarbalance}$");
            }


        }
        private static async Task Menu()
        {
            while (true)
            {
                Console.WriteLine("\tMenu");
                Console.WriteLine("<================================>");
                Console.WriteLine("Для старта музыки нажмите клавишу Escape");
                Console.WriteLine("Для старта игры нажмите клавишу end");
                Console.WriteLine("Для выключения игры и вызова меню нажмите клавишу home");
                Console.WriteLine("<================================>");
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.Home:
                        Console.Clear();
                        return;

                    case ConsoleKey.End:
                        {
                            await StartGame(CancellationToken.None);
                            break;
                        }

                    case ConsoleKey.Escape:
                        await PlayMusic();
                        break;
                }
            }
        }

        private static async Task PlayMusic()
        {
            Console.WriteLine($"Метод PlayMusic начал свою работу в потоке  - {Thread.CurrentThread.ManagedThreadId}");
            var cancelTokenSource = new CancellationTokenSource();
            var token = cancelTokenSource.Token;
            var task1 = PlayMusic(token);

            Console.WriteLine("Для выключения музыки нажмите клавишу delete");
            ConsoleKey Key = Console.ReadKey(true).Key;
            if (Key == ConsoleKey.Delete)
            {
                cancelTokenSource.Cancel();
                await Menu();
            }
            else
            {
                await Menu();
            }
            Console.WriteLine($"Метод PlayMusic законьчил свою работу в потоке  - {Thread.CurrentThread.ManagedThreadId}");
            Console.ReadLine();
            await task1;
        }

        private static async Task PlayMusic(CancellationToken token)
        {
            Console.WriteLine($"Метод PlayMusic1 начал свою работу в потоке  - {Thread.CurrentThread.ManagedThreadId}");
            for (var i = 0; i < 20; i++)
            {
                await Music.SuperMario(token);
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана токеном");
                }
            }
            Console.WriteLine($"Метод PlayMusic1 законьчил свою работу в потоке  - {Thread.CurrentThread.ManagedThreadId}");
        }

        private static EDirection ReadMovement(EDirection currentDirection, ConsoleKey key)
        {
            currentDirection = key switch
            {
                ConsoleKey.UpArrow when currentDirection != EDirection.Down => EDirection.Up,
                ConsoleKey.DownArrow when currentDirection != EDirection.Up => EDirection.Down,
                ConsoleKey.LeftArrow when currentDirection != EDirection.Right => EDirection.Left,
                ConsoleKey.RightArrow when currentDirection != EDirection.Left => EDirection.Right,
                _ => currentDirection
            };

            return currentDirection;
        }

        private static async Task DrawBorder()
        {
            for (int i = 0; i < MapWidth; i++)
            {
                new Pixel(i, 0, BorderColor).Draw();
                new Pixel(i, MapHeight - 1, BorderColor).Draw();
            }

            for (int i = 0; i < MapHeight; i++)
            {
                new Pixel(0, i, BorderColor).Draw();
                new Pixel(MapWidth - 1, i, BorderColor).Draw();
            }
        }

        private static async Task StartGame(CancellationToken token)
        {
            Console.WriteLine($"Метод StartGame начал свою работу в потоке  - {Thread.CurrentThread.ManagedThreadId}");
            Console.Clear();
            await DrawBorder();
            var currentMovement = EDirection.Right;
            var snake = new Sneak(10, 5, HeadColor, BodyColor);
            var score = 0;
            var food = GetFood(snake);
            food.Draw();
            var sw = new Stopwatch();
            var stopped = false;

            while (!token.IsCancellationRequested && !stopped)
            {
                sw.Restart();
                var oldMovement = currentMovement;
                while (sw.ElapsedMilliseconds <= FrameMs)
                {
                    if (KeyAvailable)
                    {
                        var key = Console.ReadKey(false).Key;

                        if (key == ConsoleKey.Home)
                        {
                            stopped = true;
                            break;
                        }
                        if (currentMovement == oldMovement)
                            currentMovement = ReadMovement(currentMovement, key);
                    }
                    else
                        await Task.Delay(1, CancellationToken.None);
                }

                if (snake.Head.X == food.X && snake.Head.Y == food.Y)
                {
                    snake.Move(currentMovement, true);
                    food = GetFood(snake);
                    food.Draw();
                    score++;
                }
                else
                    snake.Move(currentMovement);

                if (snake.Head.X == MapWidth - 1 || snake.Head.X == 0 || snake.Head.Y == MapHeight - 1 || snake.Head.Y == 0 || snake.Body.Any(b => b.X == snake.Head.X && b.Y == snake.Head.Y))
                    break;
            }
            snake.Clear();

            Console.SetCursorPosition(ScreenWidth / 3, ScreenHeight / 2);
            Console.WriteLine($"Game Over, score:{ score}");
            await Task.Delay(1000, CancellationToken.None);
            Console.Clear();
        }

        private static Pixel GetFood(Sneak sneak)
        {
            Pixel food;

            do
            {
                food = new Pixel(Random.Next(1, MapWidth - 2), Random.Next(1, MapHeight - 2), FoodColor);
            } while (sneak.Head.X == food.X && sneak.Head.Y == food.Y
            || sneak.Body.Any(b => b.X == food.X && b.Y == food.Y));

            return food;
        }



    }

}

    


    

