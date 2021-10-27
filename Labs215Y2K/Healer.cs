using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Healer : Unit
    {
        public int pointofhill;
        public Healer(string typeUnit1, int currenthealth1, int maxhealth1, int mindamage1, int maxdamage1,  int pointofhill1)
        {
            TypeUnit = typeUnit1;
            Currenthealth = currenthealth1;
            Maxhealth = maxhealth1;
            Mindamage = mindamage1;
            Maxdamage = maxdamage1;
            pointofhill = pointofhill1;
        }
        public void selfhill()
        {
            if (Currenthealth != Maxhealth)
            {
                int balance = Maxhealth - Currenthealth;
                int newValueOfHealth = new Random().Next( 10, balance );
                Currenthealth += newValueOfHealth ;
                Console.WriteLine($" {TypeUnit} has increased his health to {Currenthealth}");
            }
            else
            {
                Console.WriteLine($" {TypeUnit}`s health is maximum ");
            }

        }
    }
}
