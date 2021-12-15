using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.EditorCharacter
{
    class ActionsCharacterEditor
    {
        public static void WarriorVSMage(WarriorCharacter WarriorCharacter, MageCharacter MageCharacter)
        {
            MageCharacter.HealtheChangeEvent += NewHealth;
            WarriorCharacter.HealtheChangeEvent += NewHealth;
            if (MageCharacter.Health > 0)
            {
                if (MageCharacter.MagicCriticalChanse >= new Random().Next(0, 100))
                {
                    Console.WriteLine($"{MageCharacter.Name} наносит критический урон {WarriorCharacter.Name}");
                    WarriorCharacter.Health -= MageCharacter.MagicCriticalDamage;
                }
                else
                {
                    Console.WriteLine($"{MageCharacter.Name} наносит урон {WarriorCharacter.Name}");
                    WarriorCharacter.Health -= MageCharacter.MagicAttack;
                }
            }
            if (WarriorCharacter.Health > 0)
            {
                if (WarriorCharacter.PhysicalCriticalChanse >= new Random().Next(0, 100))
                {
                    Console.WriteLine($"{WarriorCharacter.Name} наносит критический урон {MageCharacter.Name}");
                    MageCharacter.Health -= WarriorCharacter.PhysicalCriticalDamage;
                }
                else
                {
                    Console.WriteLine($"{WarriorCharacter.Name} наносит урон {MageCharacter.Name}");
                    MageCharacter.Health -= WarriorCharacter.PhysicalAttack;
                }
            }
            if (MageCharacter.Health < 0)
            {
                MageCharacter.Health = 0;
            }
            if (WarriorCharacter.Health < 0)
            {
                WarriorCharacter.Health = 0;
            }
        }

        public static void WinWarrior(WarriorCharacter WarriorCharacter)
        {
            Console.WriteLine($"{WarriorCharacter.Name} победил в поединке! Было сыграно раундов : !");
            Console.WriteLine($"Теперь для {WarriorCharacter.Name} доступно 50 очков улучшений. Что вы хотите ему прокачать? 1.Сила, 2.Ловкость, 3.Интеллект, 4.Телосложение");
            string upgrade = Console.ReadLine();
            WarriorCharacter.StrengthChangeEvent += Strength;
            WarriorCharacter.DexterityChangeEvent += Dexterity;
            WarriorCharacter.IntelligenceChangeEvent += Intelligence;
            WarriorCharacter.ConstitutionChangeEvent += Constitution;
            switch (upgrade)
            {
                case "Сила":
                    WarriorCharacter.Strength += 50;
                    Console.WriteLine($"Сила {WarriorCharacter.Name} улучшена на 50 очков");
                    //Console.WriteLine($"Изменение 'Силы' повлияло на такие характеристики, как: ");
                    break;
                case "Ловкость":
                    WarriorCharacter.Dexterity += 50;
                    Console.WriteLine($"Ловкость {WarriorCharacter.Name} улучшена на 50 очков");
                    break;
                case "Интеллект":
                    WarriorCharacter.Intelligence += 50;
                    Console.WriteLine($"Интеллект {WarriorCharacter.Name} улучшен на 50 очков");
                    break;
                case "Телосложение":
                    WarriorCharacter.Constitution += 50;
                    Console.WriteLine($"Телосложение {WarriorCharacter.Name} улучшено на 50 очков");
                    break;
                default:
                    Console.WriteLine("Вы ничего не выбрали или указали неправильное значение");
                    break;
            }
        }

        public static void WinMage(MageCharacter MageCharacter)
        {
            Console.WriteLine($"{MageCharacter.Name} победил в поединке! Было сыграно раундов : !");
            Console.WriteLine($"Теперь для {MageCharacter.Name} доступно 50 очков улучшений. Что вы хотите ему прокачать? 1.Сила, 2.Ловкость, 3.Интеллект, 4.Телосложение");
            string upgrade = Console.ReadLine();
            MageCharacter.StrengthChangeEvent += Strength;
            MageCharacter.DexterityChangeEvent += Dexterity;
            MageCharacter.IntelligenceChangeEvent += Intelligence;
            MageCharacter.ConstitutionChangeEvent += Constitution;
            switch (upgrade)
            {
                case "Сила":
                    MageCharacter.Strength += 50;
                    Console.WriteLine($"Сила {MageCharacter.Name} улучшена на 50 очков");
                    break;
                case "Ловкость":
                    MageCharacter.Dexterity += 50;
                    Console.WriteLine($"Ловкость {MageCharacter.Name} улучшена на 50 очков");
                    break;
                case "Интеллект":
                    MageCharacter.Intelligence += 50;
                    Console.WriteLine($"Интеллект {MageCharacter.Name} улучшен на 50 очков");
                    break;
                case "Телосложение":
                    MageCharacter.Constitution += 50;
                    Console.WriteLine($"Телосложение {MageCharacter.Name} улучшено на 50 очков");
                    break;
                default:
                    Console.WriteLine("Вы ничего не выбрали или указали неправильное значение");
                    break;
            }
        }

        static void NewHealth(double OldHealth, double NewHealth)
        {
            Console.WriteLine($"{OldHealth}xp было измененно на {NewHealth}xp");
            Console.WriteLine();
        }
        static void Strength(double OldStrength, double NewStrength)
        {
            Console.WriteLine($"{OldStrength} было измененно на {NewStrength}");
            Console.WriteLine();
        }
        static void Dexterity(double OldDexterity, double NewDexterity)
        {
            Console.WriteLine($"{OldDexterity} было измененно на {NewDexterity}");
            Console.WriteLine();
        }
        static void Intelligence(double OldIntelligence, double NewIntelligence)
        {
            Console.WriteLine($"{OldIntelligence} было измененно на {NewIntelligence}");
            Console.WriteLine();
        }
        static void Constitution(double OldConstitution, double NewConstitution)
        {
            Console.WriteLine($"{OldConstitution} было измененно на {NewConstitution}");
            Console.WriteLine();
        }
    }
}
