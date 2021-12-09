using System;
using System.Collections.Generic;

namespace Characters
{
    class Program : Characteristics
    {

        static void Main(string[] args)
        {
            //поменять int на дабл в warrior.cs
            List<Mage> mag = new List<Mage>();
            List<Warrior> warrior = new List<Warrior>();
            List<Archer> archer = new List<Archer>();
            warrior.Add(new Warrior(30, 15, 10, 25, 0, 0, 0, 0, 0));
            mag.Add(new Mage(15, 20, 30, 15, 0, 0, 0, 0, 0, 0));
            archer.Add(new Archer(20, 30, 15, 20, 0, 0, 0, 0, 0));
            mag[0].Health = 2 * mag[0].Constitutions + 0.5 * mag[0].Strentgh;
            mag[0].Manna =  mag[0].Intelligence * 3;
            mag[0].Mattack = mag[0].Intelligence * 4;
            mag[0].Mdefence = mag[0].Intelligence * 2;
            mag[0].MCriticalchanse = 20 + mag[0].Intelligence * 0.3;
            mag[0].MCriticaldamage = mag[0].Mattack * (2 + mag[0].Intelligence * 0.15);

            warrior[0].Health = 2 * warrior[0].Constitutions + 0.5 * warrior[0].Strentgh;
            warrior[0].Pattack = warrior[0].Strentgh * 3 + 0.5 * warrior[0].Dexterity;
            warrior[0].Pdefence = warrior[0].Constitutions * 0.5 + warrior[0].Dexterity * 3;
            warrior[0].PCriticalchanse = 20 + warrior[0].Dexterity * 0.3;
            warrior[0].PCriticaldamage = warrior[0].Pattack * (2 + warrior[0].Dexterity * 0.05);
            Info.startredactor(archer,warrior,mag);
        }
        public static void mageprelisting(List<Mage> mag)
        {
            mag[0].Health = 2 * mag[0].Constitutions + 0.5 * mag[0].Strentgh;
            mag[0].Manna = mag[0].Intelligence * 3;
            mag[0].Mattack = mag[0].Intelligence * 4;
            mag[0].Mdefence = mag[0].Intelligence * 2;
            mag[0].MCriticalchanse = 20 + mag[0].Intelligence * 0.3;
            mag[0].MCriticaldamage = mag[0].Mattack * (2 + mag[0].Intelligence * 0.15);
            if (mag[0].Health < 76.25)
            {
                mag[0].Strentgh -= mag[0].Strentgh * 0.1;
                mag[0].Dexterity -= mag[0].Dexterity * 0.1;
                mag[0].Intelligence -= mag[0].Intelligence * 0.1;
                mag[0].Constitutions -= mag[0].Constitutions * 0.1;
                Console.WriteLine("Сила мага упала на 10%!");
                Console.WriteLine("Ловкость мага упала на 10%!");
                Console.WriteLine("Интеллект мага упал на 10%!");
                Console.WriteLine("Телосложение мага упало на 10%!");
            }
            else { }
        }
        public static void archerprelisting(List<Archer> archer)
        {
            archer[0].Health = 2 * archer[0].Constitutions + 0.5 * archer[0].Strentgh;
            archer[0].Pattack = archer[0].Strentgh * 3 + 0.5 * archer[0].Dexterity;
            archer[0].Pdefence = archer[0].Constitutions * 0.5 + archer[0].Dexterity * 3;
            archer[0].PCriticalchanse = 20 + archer[0].Dexterity * 0.3;
            archer[0].PCriticaldamage = archer[0].Pattack * (2 + archer[0].Dexterity * 0.05);
            if (archer[0].Health < 83.75)
            {
                archer[0].Strentgh -= archer[0].Strentgh * 0.1;
                archer[0].Dexterity -= archer[0].Dexterity * 0.1;
                archer[0].Intelligence -= archer[0].Intelligence * 0.1;
                archer[0].Constitutions -= archer[0].Constitutions * 0.1;
                Console.WriteLine("Сила лучника упала на 10%!");
                Console.WriteLine("Ловкость лучника упала на 10%!");
                Console.WriteLine("Интеллект лучника упал на 10%!");
                Console.WriteLine("Телосложение лучника упало на 10%!");
            }
            else
            {

            }
        }
        public static void archerlist(List<Archer> archer)
        {
            archer[0].Health = 2 * archer[0].Constitutions + 0.5 * archer[0].Strentgh;
            archer[0].Pattack = archer[0].Strentgh * 3 + 0.5 * archer[0].Dexterity;
            archer[0].Pdefence = archer[0].Constitutions * 0.5 + archer[0].Dexterity * 3;
            archer[0].PCriticalchanse = 20 + archer[0].Dexterity * 0.3;
            archer[0].PCriticaldamage = archer[0].Pattack * (2 + archer[0].Dexterity * 0.05);
            Console.WriteLine($"Характеристки лучника:");
            Console.WriteLine($"Сила = {archer[0].Strentgh}");
            Console.WriteLine($"Ловкость = {archer[0].Dexterity}");
            Console.WriteLine($"Интелект = {archer[0].Intelligence}");
            Console.WriteLine($"Телосложение = {archer[0].Constitutions}");
            Console.WriteLine($"Здоровье = {archer[0].Health}");
            Console.WriteLine($"Физ. атака = {archer[0].Pattack}");
            Console.WriteLine($"Физ. защита = {archer[0].Pdefence}");
            Console.WriteLine($"Критический шанс = {archer[0].PCriticalchanse}");
            Console.WriteLine($"Критический урон = {archer[0].PCriticaldamage}");
        }
        public static void warriorprelisting(List<Warrior> warrior)
        {
            warrior[0].Health = 2 * warrior[0].Constitutions + 0.5 * warrior[0].Strentgh;
            warrior[0].Pattack = warrior[0].Strentgh * 3 + 0.5 * warrior[0].Dexterity;
            warrior[0].Pdefence = warrior[0].Constitutions * 0.5 + warrior[0].Dexterity * 3;
            warrior[0].PCriticalchanse = 20 + warrior[0].Dexterity * 0.3;
            warrior[0].PCriticaldamage = warrior[0].Pattack * (2 + warrior[0].Dexterity * 0.05);
            if (warrior[0].Health < 162.5)
            {
                warrior[0].Strentgh -= warrior[0].Strentgh * 0.1;
                warrior[0].Dexterity -= warrior[0].Dexterity * 0.1;
                warrior[0].Intelligence -= warrior[0].Intelligence * 0.1;
                warrior[0].Constitutions -= warrior[0].Constitutions * 0.1;
                Console.WriteLine("Сила воина упала на 10%!");
                Console.WriteLine("Ловкость воина упала на 10%!");
                Console.WriteLine("Интеллект воина упал на 10%!");
                Console.WriteLine("Телосложение воина упало на 10%!");
            }
            else 
            {
                
            }
        }
        public static void listing(List<Mage> mag)
        {
            
            mag[0].Health = 2 * mag[0].Constitutions + 0.5 * mag[0].Strentgh;
            mag[0].Manna = mag[0].Intelligence * 3;
            mag[0].Mattack = mag[0].Intelligence * 4;
            mag[0].Mdefence = mag[0].Intelligence * 2;
            mag[0].MCriticalchanse = 20 + mag[0].Intelligence * 0.3;
            mag[0].MCriticaldamage = mag[0].Mattack * (2 + mag[0].Intelligence * 0.15);
            Console.WriteLine();
            Console.WriteLine($"Характеристики мага:");
            Console.WriteLine($"Сила = {mag[0].Strentgh}");
            Console.WriteLine($"Ловкость = {mag[0].Dexterity}");
            Console.WriteLine($"Интелект = {mag[0].Intelligence}");
            Console.WriteLine($"Телосложение = {mag[0].Constitutions}");
            Console.WriteLine($"Здоровье = {mag[0].Health}");
            Console.WriteLine($"Мана = {mag[0].Manna}");
            Console.WriteLine($"Маг. атака = {mag[0].Mattack}");
            Console.WriteLine($"Маг. защита = {mag[0].Mdefence}");
            Console.WriteLine($"Критический шанс = {mag[0].MCriticalchanse}");
            Console.WriteLine($"Критический урон = {mag[0].MCriticaldamage}");
        }
        public static void warriorlist(List<Warrior> warrior)
        {
            warrior[0].Health = 2 * warrior[0].Constitutions + 0.5 * warrior[0].Strentgh;
            warrior[0].Pattack = warrior[0].Strentgh * 3 + 0.5 * warrior[0].Dexterity;
            warrior[0].Pdefence = warrior[0].Constitutions * 0.5 + warrior[0].Dexterity * 3;
            warrior[0].PCriticalchanse = 20 + warrior[0].Dexterity * 0.3;
            warrior[0].PCriticaldamage = warrior[0].Pattack * (2 + warrior[0].Dexterity * 0.05);
            Console.WriteLine($"Характеристики воина:");
            Console.WriteLine($"Сила = {warrior[0].Strentgh}");
            Console.WriteLine($"Ловкость = {warrior[0].Dexterity}");
            Console.WriteLine($"Интеллект = {warrior[0].Intelligence}");
            Console.WriteLine($"Телосложение = {warrior[0].Constitutions}");
            Console.WriteLine($"Здоровье = {warrior[0].Health}");
            Console.WriteLine($"Физ. атака = {warrior[0].Pattack}");
            Console.WriteLine($"Физ. защита = {warrior[0].Pdefence}");
            Console.WriteLine($"Критический шанс = {warrior[0].PCriticalchanse}");
            Console.WriteLine($"Критический урон = {warrior[0].PCriticaldamage}");
        }
    }
}

