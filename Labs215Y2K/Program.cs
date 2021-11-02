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
            NewAshanUpdate[] Ashan = new NewAshanUpdate[11];
            NewAshanUpdate[] Names = new NewAshanUpdate[11];
            int CounterOfProducts = 0;
            int CounterOfCyclices = 1;
            Names[1].Names = "1. Гречка"; Names[2].Names = "2. Макароны"; Ashan[3].Names = "3. Молоко"; Ashan[4].Names = "4. Хлеб"; Ashan[5].Names = "5. Батон"; Ashan[6].Names = "6. Конфеты"; Ashan[7].Names = "7. Чипсы"; Ashan[8].Names = "8. Сухари";  Ashan[9].Names = "9. Соленый попкорн"; Ashan[10].Names = "10. Семечки Белочка";
            Ashan[1].Price = 130; Ashan[2].Price = 250; Ashan[3].Price = 50; Ashan[4].Price = 30; Ashan[5].Price = 30; Ashan[6].Price = 150; Ashan[7].Price = 100; Ashan[8].Price = 50; Ashan[9].Price = 150; Ashan[10].Price = 200;
            while (CounterOfCyclices != 2)
            {
                Console.WriteLine("Хотите приобрести товар?? 1 - Да, 2 - Нет");
                CounterOfCyclices = int.Parse(Console.ReadLine());
                if (CounterOfCyclices == 1)
                {
                    Console.WriteLine("Введите номер товара, который вам нужен");
                    Ashan[CounterOfProducts].NumberOfProduct1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите кол-во товара");
                    Ashan[CounterOfProducts].Count = int.Parse(Console.ReadLine());
                    CounterOfProducts++;
                }
                else
                {
                    break;
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
    }
}
