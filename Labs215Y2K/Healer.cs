using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Healer : Unit
    {
        public int pointofhill;
        public Healer(string typeUnit1, int currenthealth1, int maxhealth1, int mindamage1, int maxdamage1, int speed1, int attackspeed1, int pointofhill1)
        {
            typeUnit = typeUnit1;
            currenthealth = currenthealth1;
            maxhealth = maxhealth1;
            mindamage = mindamage1;
            maxdamage = maxdamage1;
            speed = speed1;
            attackspeed = attackspeed1;
            pointofhill = pointofhill1;
        }
        public void selfhill()
        {
            if (currenthealth != maxhealth)
            {
                int balance = maxhealth - currenthealth;
                int newValueOfHealth = new Random().Next( 10, balance );
                currenthealth += newValueOfHealth ;
                Console.WriteLine($" {typeUnit} has increased his health to {currenthealth}");
            }
            else
            {
                Console.WriteLine($" {typeUnit}`s health is maximum ");
            }

        }
    }
}
