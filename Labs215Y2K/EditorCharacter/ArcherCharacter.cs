using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.EditorCharacter
{
    class ArcherCharacter : CharacterEditor
    {
        private int _strength;
        private int _dexterity;
        private int _intelligence;
        private int _constitution;

        public int Strength
        {
            get
            {
                return _strength;
            }

            set
            {
                if (value > 55)
                {
                    value = 55;
                    _strength = 55;
                    Console.WriteLine($"Сила больше 55 быть не может");
                }
                if (value < 20)
                {
                    value = 20;
                    _strength = 20;
                    Console.WriteLine($"Сила меньше 20 быть не может");
                }
                int OldStrength = _strength;
                _strength = value;
                StrengthChangeEvent?.Invoke(OldStrength, value);
            }
        }
        public int Dexterity
        {
            get
            {
                return _dexterity;
            }

            set
            {
                int OldDexterity = _dexterity;
                _dexterity = value;
                DexterityChangeEvent?.Invoke(OldDexterity, value);
            }
        }
        public int Intelligence
        {
            get
            {
                return _intelligence;
            }

            set
            {
                int OldIntelligence = _intelligence;
                _intelligence = value;
                IntelligenceChangeEvent?.Invoke(OldIntelligence, value);
            }
        }
        public int Constitution
        {
            get
            {
                return _constitution;
            }

            set
            {
                int OldConstitution = _constitution;
                _constitution = value;
                ConstitutionChangeEvent?.Invoke(OldConstitution, value);
            }
        }


        public delegate void HealthChangeDelegate(int OldHealth, int NewHealth);
        public event HealthChangeDelegate HealtheChangeEvent;

        public delegate void CriricalChanceDelegate(int CriticalChance, string NewValue);
        public event CriricalChanceDelegate CricticalChanceEvent;

        public delegate void DexterityChangeDelegate(int OldDexterity, int NewDexterity);
        public event DexterityChangeDelegate DexterityChangeEvent;

        public delegate void IntelligenceChangeDelegate(int OldIntelligence, int NewIntelligence);
        public event IntelligenceChangeDelegate IntelligenceChangeEvent;

        public delegate void ConstitutionChangeDelegate(int OldConstitution, int NewConstitution);
        public event ConstitutionChangeDelegate ConstitutionChangeEvent;

        public delegate void StrengthChangeDelegate(int OldStrength, int NewStrength);
        public event StrengthChangeDelegate StrengthChangeEvent;
    }
}
