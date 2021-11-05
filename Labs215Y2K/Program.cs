using System;
using System.ComponentModel.DataAnnotations;
using Units;
using Action;

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

            NewAshan Product1 = new NewAshan(1, "Гречка", 130.50,"шт.", 9);
            NewAshan Product2 = new NewAshan(2, "Макароны", 250.50, "шт.", 8);
            NewAshan Product3 = new NewAshan(3, "Молоко", 50.50, "шт.", 7);
            NewAshan Product4 = new NewAshan(4, "Хлеб", 30.50, "шт.", 4);
            NewAshan Product5 = new NewAshan(5, "Батон", 30.50, "шт.", 5);
            NewAshan Product6 = new NewAshan(6, "Конфеты", 150.50, "кг.", 11);
            NewAshan Product7 = new NewAshan(7, "Чипсы", 100.50, "кг.", 5);
            NewAshan Product8 = new NewAshan(8, "Сухари", 50.50, "кг.", 4);
            NewAshan Product9 = new NewAshan(9, "Попкорн", 150.50, "кг.", 6);
            NewAshan Product10 = new NewAshan(10, "Семечки", 200.50, "кг.", 3);

            Console.WriteLine("Хотите увидеть список продуктов? 1 - да, 2 - нет");
            int YesOrNo = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (YesOrNo == 1)
            {
                Console.Write("Номер товара \t Название товара \t Цена товара (за 1 шт. или кг) \t Кол-во товара");
                Console.WriteLine();
                Console.WriteLine($"{Product1.NumberOfProduct} \t \t {Product1.Names} \t \t {Product1.Price} \t {Product1.PieceOrWeight} \t \t \t {Product1.Quantity}");
                Console.WriteLine($"{Product2.NumberOfProduct} \t \t {Product2.Names} \t \t {Product2.Price} \t {Product2.PieceOrWeight} \t \t \t {Product2.Quantity}");
                Console.WriteLine($"{Product3.NumberOfProduct} \t \t {Product3.Names} \t \t {Product3.Price} \t {Product3.PieceOrWeight} \t \t \t {Product3.Quantity}");
                Console.WriteLine($"{Product4.NumberOfProduct} \t \t {Product4.Names} \t \t \t {Product4.Price} \t {Product4.PieceOrWeight} \t \t \t {Product4.Quantity}");
                Console.WriteLine($"{Product5.NumberOfProduct} \t \t {Product5.Names} \t \t \t {Product5.Price} \t {Product5.PieceOrWeight} \t \t \t {Product5.Quantity}");
                Console.WriteLine($"{Product6.NumberOfProduct} \t \t {Product6.Names} \t \t {Product6.Price} \t {Product6.PieceOrWeight} \t \t \t {Product6.Quantity}");
                Console.WriteLine($"{Product7.NumberOfProduct} \t \t {Product7.Names} \t \t \t {Product7.Price} \t {Product7.PieceOrWeight} \t \t \t {Product7.Quantity}");
                Console.WriteLine($"{Product8.NumberOfProduct} \t \t {Product8.Names} \t \t {Product8.Price} \t {Product8.PieceOrWeight} \t \t \t {Product8.Quantity}");
                Console.WriteLine($"{Product9.NumberOfProduct} \t \t {Product9.Names} \t \t {Product9.Price} \t {Product9.PieceOrWeight} \t \t \t {Product9.Quantity}");
                Console.WriteLine($"{Product10.NumberOfProduct} \t \t {Product10.Names} \t \t {Product10.Price} \t {Product10.PieceOrWeight} \t \t \t {Product10.Quantity}");

            }
            else
            {
                Console.WriteLine("Список не выведен");
            }

            
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


        // Новые юниты:


//        Archer Archer = new Archer();
//        Warrior Warrior = new Warrior();
//        Mage Mage = new Mage();
//        Healer Healer = new Healer();

//        Archer.Name = "Лучник"; Warrior.Name = "Воин"; Mage.Name = "Маг"; Healer.Name = "Целитель";

//            Archer.MinDamage = 15; Archer.MaxDamage = 20; Archer.Health = 40;
//            Warrior.MinDamage = 10; Warrior.MaxDamage = 18; Warrior.Health = 50;
//            Mage.MinDamage = 13; Mage.MaxDamage = 19; Mage.Health = 60;
//            Healer.Healing = 20; Healer.Health = 55;

//            Console.WriteLine("Бой между Лучником и Воином, если хотите посмотреть напишите 1");
//            Console.WriteLine("Бой между Магом и Воином, если хотите посмотреть напишите 2");
//            Console.WriteLine("Бой между Магом, Воином и Лучником, если хотите посмотреть напишите 3");

//            int choice = int.Parse(Console.ReadLine());
//        Console.WriteLine();

//            if (choice == 1)
//            {
//                Console.WriteLine($"Бой между {Archer.Name} и {Warrior.Name}");
//                while (Archer.Health != 0 && Warrior.Health != 0)
//                {
//                    Actions.WarriorVSArcher(Archer, Warrior);
//                }
//}

//            if (choice == 2)
//            {
//                Console.WriteLine($"Бой между {Mage.Name} и {Warrior.Name}");
//                while (Mage.Health != 0 && Warrior.Health != 0)
//                {
//                    Actions.MageVSWarior(Mage, Warrior);
//                }
//            }

//            if (choice == 3)
//            {
//                Console.WriteLine($"Бой между {Mage.Name}, {Warrior.Name} и {Archer.Name} (присутствует {Healer.Name})");
//                while (Mage.Health != 0 && Warrior.Health != 0 && Archer.Health != 0)
//                {
//                    Actions.ArcherVSMageVsWarrior(Mage, Warrior, Archer, Healer);
//                }
//            }

        //}
    }
}
