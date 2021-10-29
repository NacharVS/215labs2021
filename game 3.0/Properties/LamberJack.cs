using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_3._0
{
    class LamberJack:Unit
    {
        private string _skill;
        public string Skill
        {
            get
            {
                return _skill;
            }

            set
            {
                _skill = value;
            }
        }
    }
}
