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

        //public int Health
        //{
        //    get => _currentHealth;
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            _currentHealth = value;
        //        }
        //        else
        //        {
        //            _currentHealth = 0;
        //            Console.WriteLine();
        //            Death();
        //        }
        //    }
        //}

        //private void Death()
        //{
        //    Console.WriteLine($"{_name} умер");
        //}
    }

}
