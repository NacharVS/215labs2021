using System;
using System.Collections.Generic;
using System.Text;

namespace New_Game
{
    class Health
    {
        private double _currencyHealth;
        private double _maxHealth;
        private bool _isWeaken;

        public bool IsWeaken { get => _isWeaken; set => _isWeaken = value; }
        public double CurrencyHealth
        {
            get => _currencyHealth; set
            {
                if (value <= MaxHealth)
                {
                    if (value > 0)
                    {
                        _currencyHealth = value;
                       
                    }
                    if (value <= 0)
                    {
                        _currencyHealth = 0;
                        Console.WriteLine($"Персонаж мёртв.");

                    }
                }
                else
                    _currencyHealth = MaxHealth;

            }
        }
            public double MaxHealth
            {
                get
                {
                    return _maxHealth;
 
                }
                set
                {
                if (_isWeaken)
                {
                    _maxHealth -= _maxHealth * 0.1;
                }
                if (value > 0)
                        _maxHealth = value;
                    else
                        Console.WriteLine("Невозможно вписать отрицательное значение для максимального HP.");

                }

            }

        
    }
        
            
}   

