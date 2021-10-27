using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_3._0
{
    class Archer :Unit
    {
        private int _arrows;
        private int _damagebyarrow = 0;

        private void ArcherDamage(int arrows, int damagebyarrow)
        {
            arrows -= 1;
            GetDamage(damagebyarrow);
        }

        public int Arrows
        {
            get => _arrows;
            set
            {
                    _arrows = value;
                if (_arrows<=0)
                {

                    GetDamage(InflictDamage());
                }
                else
                {
                    ArcherDamage(_arrows, _damagebyarrow);
                }
            }
        }



    }
}
