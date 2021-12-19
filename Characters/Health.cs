using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    class Health : Characteristics
    {
        public delegate void MagHealthChangeee();
        public event MagHealthChangeee HealthCH { add { MagHealthChang(); } remove { } }
        public delegate void ArcherHealthChange();
        public event ArcherHealthChange HealthCh { add { ArchHealthChange(); } remove { } }
        public delegate void WarriorHealthChange();
        public event WarriorHealthChange HealthChh { add { WarriorHealthChangee(); } remove { } }
        private double _newmaxhealth;
        public double Newmaxhealth
        {
            get
            {
                return 2 * 65 + 0.5 * 45;
            }
            set
            {
                _newmaxhealth = value;
            }
        }
        static void MagHealthChang()
        {
            Console.WriteLine("Здоровье мага упало на 10%");
            Console.WriteLine("Ловкость мага упала на 10%");
            Console.WriteLine("Интеллект мага упал на 10%");
            Console.WriteLine("Телосложение мага упало на 10%");
        }
        static void ArchHealthChange()
        {
            Console.WriteLine("Здоровье лучника упало на 10%");
            Console.WriteLine("Ловкость лучника упала на 10%");
            Console.WriteLine("Интеллект лучника упал на 10%");
            Console.WriteLine("Телосложение лучника упало на 10%");
        }
        public static void WarriorHealthChangee()
        {
            Console.WriteLine("Здоровье воина упало на 10%");
            Console.WriteLine("Ловкость воина упала на 10%");
            Console.WriteLine("Интеллект воина упал на 10%");
            Console.WriteLine("Телосложение воина упало на 10%");
        }
        public void HealthCheck(List<Mage> mag)
        {
            if (mag[0].Manna < 150)
            {
                Newmaxhealth -= Newmaxhealth * 0.2;
                Console.WriteLine("Макс. здоровье упало на 20%");
            }
            else { }
            if (mag[0].Health < (Newmaxhealth / 2))
            {
                mag[0].Strentgh -= mag[0].Strentgh * 0.1;
                mag[0].Dexterity -= mag[0].Dexterity * 0.1;
                mag[0].Intelligence -= mag[0].Intelligence * 0.1;
                mag[0].Constitutions -= mag[0].Constitutions * 0.1;
                mag[0].HealthCH += MagHealthChang;
            }
            else { }
        }
        public void ArcherHealthCheck(List<Archer> archer)
        {
            if (archer[0].Health < 83.75)
            {
                archer[0].Strentgh -= archer[0].Strentgh * 0.1;
                archer[0].Dexterity -= archer[0].Dexterity * 0.1;
                archer[0].Intelligence -= archer[0].Intelligence * 0.1;
                archer[0].Constitutions -= archer[0].Constitutions * 0.1;
                archer[0].HealthCh += ArchHealthChange;
            }
            else { }
        }
        public void WarriorHealthCheck(List <Warrior> warrior)
        {
            if (warrior[0].Health < 162.5)
            {
                warrior[0].Strentgh -= warrior[0].Strentgh * 0.1;
                warrior[0].Dexterity -= warrior[0].Dexterity * 0.1;
                warrior[0].Intelligence -= warrior[0].Intelligence * 0.1;
                warrior[0].Constitutions -= warrior[0].Constitutions * 0.1;
                warrior[0].HealthChh += WarriorHealthChangee;
            }
            else { }
        }
    }
}
