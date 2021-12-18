using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.EditorCharacter
{

    class CharacterEditor
    {
        private string _name;
        private double _mana;


        public string Name { get => _name; set => _name = value; }
       
        public double Mana
        {
            get
            {
                return _mana;
            }

            set
            {
                if (_mana == 0)
                {
                    Console.WriteLine($"Мана {Name} закончилась");
                }
                double OldMana = _mana;
                _mana = value;
                ManaChangeEvent?.Invoke(OldMana, value);
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

        public delegate void ManaChangeDelegate(double OldMana, double NewMana);
        public event ManaChangeDelegate ManaChangeEvent;
    }

}
