using System;
using System.Collections.Generic;
using System.Text;

namespace New_Game
{
    class Health_Mana
    {
        private double _currencyHealth;
        private double _maxHealth;
        private bool _isWeaken;
        private double _maxMana;
        private double _currencyMana;
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
        public double MaxMana
        {
            get
            {
                //_maxMana = Intelligence * 3;
                return _maxMana;
            }
            set { _maxMana = value; }

        }
        public double CurrencyMana
        {
            get => _currencyMana; set
            {
                if (value <= MaxMana)
                {

                    if (value >= 0)
                        _currencyMana = value;
                    if (value <= MaxMana * 0.2)
                    {
                        MaxHealth -= MaxHealth * 0.2;
                        _currencyMana = value;
                    }
                    if (value < 0)
                    {
                        _currencyMana = 0;
                        Console.WriteLine("У вас не хватает маны для совершения действия.");
                    }
                }
            }
        }

    }
        
            
}   

