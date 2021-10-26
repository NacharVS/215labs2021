using System;

namespace Labs215Y2K
{
    class Unit
    {
        private string _name;
        private int _health = 50;
        private int _speed;
        private int _damage;

        public string Name
        {
            get
            {
               return _name + _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Health 
        { 
            get => _health;
            set
            {
                var oldValue = _health;

                if (oldValue - value > 0)
                    _health = oldValue - value;
                else
                {
                    _health = 0;
                    Death();
                }
            }
        }



        //public string GetName()
        //{
        //    return _name + _name;
        //}

        //public void SetName(string name)
        //{
        //    _name = name.ToUpper();
        //}

        public void Move()
        {
            System.Console.WriteLine($"{_name} moving");
        }

        private void Death()
        {
            Console.WriteLine("Dead");
        }
    }
}
