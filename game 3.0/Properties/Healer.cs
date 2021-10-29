using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_3._0
{
    class Healer: Unit
    {
        private int _countheal;

        public int Countheal { get => _countheal; set => _countheal = value; }
        public static void SelfHeal (Healer unit)
        {
            if (unit.Health <= 0)
                Console.WriteLine($"{unit.Name} уже мёртв. Его нельзя воскресить. Хилер потратил свой ход впустую.");
            else
            {

                Console.WriteLine($"{unit.Name} исцеляет себя на {unit.Countheal} hp");
                unit.Health += unit.Countheal;
                if (unit.Health > unit.Maxhealth)
                    unit.Health = unit.Maxhealth;
                Console.WriteLine($"У {unit.Name} стало {unit.Health} hp. ");
            }
        }

        public static void Heal(Healer unit, Unit unit2)
        {
            if (unit.Health <= 0)
                Console.WriteLine($"{unit.Name} уже мёртв. Его нельзя воскресить. Хилер потратил свой ход впустую.");
            else
            {
                Console.WriteLine($"{unit.Name} исцеляет {unit2.Name} на {unit.Countheal} hp");
                unit2.Health += unit.Countheal;

                if (unit2.Health > unit2.Maxhealth)
                    unit2.Health = unit2.Maxhealth;
                Console.WriteLine($"У {unit2.Name} стало {unit2.Health} hp. ");
            }
        }



    }
}
