using System;
using System.Collections.Generic;
using System.Text;

namespace New_Game
{
    class Mana: Health
    {
        private double _maxMana;
        private double _currencyMana;

    

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
        public double MaxMana
        {
            get
            {
                //_maxMana = Intelligence * 3;
                return _maxMana;
            }

        }
    }
}
