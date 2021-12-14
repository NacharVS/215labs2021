using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.EditorCharacter
{

    class CharacterEditor
    {
        private string _name;
        private int _mana;

        public string Name { get => _name; set => _name = value; }
       
        public int Mana
        {
            get
            {
                return _mana;
            }

            set
            {
                _mana = value;
            }
        }
   

    }

}
