﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_3._0
{
    class Unit
    {
        private string _name;
        private int _maxhealth;
        private int _health;
        private int _speed;
        private int _minDamage;
        private int _maxDamage;

        public string Name
        {
            get
            {
                return _name;
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
                if (value > 0)
                    _health = value;
                else
                {
                    _health = 0;
                    Death();
                }
            }
        }

        public int MinDamage { get => _minDamage; set => _minDamage = value; }
        public int Maxhealth { get => _maxhealth; set => _maxhealth = value; }
        public int MaxDamage { get => _maxDamage; set => _maxDamage = value; }

        internal void GetDamage(int damage)
        {
            Health = Health - damage;
        }


        internal int InflictDamage()
        {
            return new Random().Next(MinDamage, MaxDamage);
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
            Console.WriteLine($"{_name} Dead");
        }


    }
}
