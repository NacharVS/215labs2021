using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_3._0
{
    class Destroyer:Unit
    {
        private int _damageForB;

        public int DamageForB { get => _damageForB; set => _damageForB = value; }
        public int InflictDamageB()
        {
            return DamageForB;
        }
    }
}
