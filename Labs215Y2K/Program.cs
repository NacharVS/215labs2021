using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs215Y2K
{
    class Program : Charactergame
    {
        static void Main(string[] args)
        {
            List<Mage> mag = new List<Mage>();
            List<Warrior> warrior = new List<Warrior>();
            List<Archer> archer = new List<Archer>();
            warrior.Add(new Warrior(30, 15, 10, 25, 0, 0, 0, 0, 0, 0));
            mag.Add(new Mage(15, 20, 30, 15, 0, 0, 0, 0, 0, 0, 0));
            archer.Add(new Archer(20, 30, 15, 20, 0, 0, 0, 0, 0, 0));
            double newmaxhealth = 152.5;
            Info.startredactor(archer, warrior, mag, newmaxhealth);
        }

        static void HealthChang()
        {
            Console.WriteLine("Здоровье упало на 10%");
            Console.WriteLine("Ловкость упала на 10%");
            Console.WriteLine("Интеллект упал на 10%");
            Console.WriteLine("Телосложение упало на 10%");
        }

        public static void archerprelisting(List<Archer> archer)
        {


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
            else { }
        }
        public static void archerlist(List<Archer> archer)
        {

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
            else { }
        }
        public static void listing(List<Mage> mag)
        {


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

