using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    class Health : Characteristics
    {
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
        public delegate void HealthChange();
        public event HealthChange HealthCh;
        static void HealthChang()
        {
            Console.WriteLine("Здоровье упало на 10%");
            Console.WriteLine("Ловкость упала на 10%");
            Console.WriteLine("Интеллект упал на 10%");
            Console.WriteLine("Телосложение упало на 10%");
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
                mag[0].HealthCh += HealthChang;
            }
            else { }
        }
    }
}
