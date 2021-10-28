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
        public void SelfHeal (Healer unit)
        {
            Console.WriteLine($"{unit.Name} исцеляет себя на {unit.Countheal} hp");
            unit.Health += unit.Countheal;

        }

        public void Heal(Healer unit, Unit unit2)
        {
            Console.WriteLine($"{unit.Name} исцеляет {unit2.Name} на {unit.Countheal} hp");
            unit2.Health += unit.Countheal;

        }



    }
}
