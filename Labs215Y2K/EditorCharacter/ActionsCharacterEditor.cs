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
            //MageCharacter.ManaChangeEvent += NewMana;
            //Console.WriteLine("Сколько вы хотите провести раундов?");
            //int rounds = int.Parse(Console.ReadLine());
            //Console.WriteLine("Бой между Магом и Воином начался");
            if (MageCharacter.Health > 0)
            {
                if (MageCharacter.MagicCriticalChanse >= new Random().Next(0, 100))
                {
                    Console.WriteLine($"{MageCharacter.Name} наносит критический урон {WarriorCharacter.Name}");
                    Console.WriteLine($"Крит.Урон Мага - {MageCharacter.MagicCriticalDamage}");
                    WarriorCharacter.Health -= MageCharacter.MagicCriticalDamage;
                    MageCharacter.Mana -= 20;
                }
                else
                {
                    Console.WriteLine($"{MageCharacter.Name} наносит урон {WarriorCharacter.Name}");
                    Console.WriteLine($"Урон Мага - {MageCharacter.MagicAttack}");
                    WarriorCharacter.Health -= MageCharacter.MagicAttack; 
                    MageCharacter.Mana -= 10;
                }
            }
            if (WarriorCharacter.Health > 0)
            {
                if (WarriorCharacter.PhysicalCriticalChanse >= new Random().Next(0, 100))
                {
                    Console.WriteLine($"{WarriorCharacter.Name} наносит критический урон {MageCharacter.Name}");
                    Console.WriteLine($"Крит.Урон Воина - {WarriorCharacter.PhysicalCriticalDamage}");
                    MageCharacter.Health -= WarriorCharacter.PhysicalCriticalDamage;
                }
                else
                {
                    Console.WriteLine($"{WarriorCharacter.Name} наносит урон {MageCharacter.Name}");
                    Console.WriteLine($"Урон Воина - {WarriorCharacter.PhysicalAttack}");
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
            Console.WriteLine($"Здоровье Мага - {Math.Round(MageCharacter.Health, 0)}xp, Мана Мага - {MageCharacter.Mana}");
            Console.WriteLine($"Здоровье Воина - {Math.Round(WarriorCharacter.Health, 0)}xp");
            Console.WriteLine();
            //Console.WriteLine($"Начало нового раунда. Кол-во прошедших раундов: ");
            //Console.WriteLine($"Здоровье Воина - {WarriorCharacter.Health}xp");
            //Console.WriteLine($"Здоровье Мага - {MageCharacter.Health}xp");

        }

        public static void WarriorVSMageVSArcher (WarriorCharacter WarriorCharacter, MageCharacter MageCharacter, ArcherCharacter ArcherCharacter)
        {
            MageCharacter.HealtheChangeEvent += NewHealth;
            WarriorCharacter.HealtheChangeEvent += NewHealth;
            ArcherCharacter.HealtheChangeEvent += NewHealth;

            //MageCharacter.ManaChangeEvent += NewMana;

            int RandomFightOne = new Random().Next(1, 4);
            int RandomFightThree = new Random().Next(1, 5);
            int RandomHFightTwo = new Random().Next(1, 4);

            if (RandomFightOne == 1)
            {
                if (ArcherCharacter.PhysicalCriticalChanse >= new Random().Next(0, 100))
                {
                    Console.WriteLine($"{ArcherCharacter.Name} наносит критический урон {MageCharacter.Name}");
                    Console.WriteLine($"Крит.Урон Лучника - {ArcherCharacter.PhysicalCriticalDamage}");
                    MageCharacter.Health -= ArcherCharacter.PhysicalCriticalDamage;
                }
                else
                {
                    Console.WriteLine($"{ArcherCharacter.Name} наносит урон {MageCharacter.Name}");
                    Console.WriteLine($"Урон Лучника - {ArcherCharacter.PhysicalAttack}");
                    MageCharacter.Health -= ArcherCharacter.PhysicalAttack;
                }
            }
            else
            {
                if (ArcherCharacter.PhysicalCriticalChanse >= new Random().Next(0, 100))
                {
                    Console.WriteLine($"{ArcherCharacter.Name} наносит критический урон {WarriorCharacter.Name}");
                    Console.WriteLine($"Крит.Урон Лучника - {ArcherCharacter.PhysicalCriticalDamage}");
                    WarriorCharacter.Health -= ArcherCharacter.PhysicalCriticalDamage;
                }
                else
                {
                    Console.WriteLine($"{ArcherCharacter.Name} наносит урон {WarriorCharacter.Name}");
                    Console.WriteLine($"Урон Лучника - {ArcherCharacter.PhysicalAttack}");
                    WarriorCharacter.Health -= ArcherCharacter.PhysicalAttack;
                }
            }
            if (RandomHFightTwo == 1)
            {
                if (MageCharacter.MagicCriticalChanse >= new Random().Next(0, 100))
                {
                    Console.WriteLine($"{MageCharacter.Name} наносит критический урон {ArcherCharacter.Name}");
                    Console.WriteLine($"Крит.Урон Мага - {MageCharacter.MagicCriticalDamage}");
                    MageCharacter.Mana -= 20;
                    ArcherCharacter.Health -= MageCharacter.MagicCriticalDamage;
                }
                else
                {
                    Console.WriteLine($"{MageCharacter.Name} наносит урон {ArcherCharacter.Name}");
                    Console.WriteLine($"Урон Мага - {MageCharacter.MagicAttack}");
                    MageCharacter.Mana -= 10;
                    ArcherCharacter.Health -= MageCharacter.MagicAttack;
                }
            }
            else
            {
                if (MageCharacter.MagicCriticalChanse >= new Random().Next(0, 100))
                {
                    Console.WriteLine($"{MageCharacter.Name} наносит критический урон {WarriorCharacter.Name}");
                    Console.WriteLine($"Крит.Урон Мага - {MageCharacter.MagicCriticalDamage}");
                    WarriorCharacter.Health -= MageCharacter.MagicCriticalDamage;
                    MageCharacter.Mana -= 20;
                }
                else
                {
                    Console.WriteLine($"{MageCharacter.Name} наносит урон {WarriorCharacter.Name}");
                    Console.WriteLine($"Урон Мага - {MageCharacter.MagicAttack}");
                    WarriorCharacter.Health -= MageCharacter.MagicAttack;
                    MageCharacter.Mana -= 10;
                }
            }
            if (RandomFightThree == 1)
            {
                if (WarriorCharacter.PhysicalCriticalChanse >= new Random().Next(0, 100))
                {
                    Console.WriteLine($"{WarriorCharacter.Name} наносит критический урон {ArcherCharacter.Name}");
                    Console.WriteLine($"Крит.Урон Воина - {WarriorCharacter.PhysicalCriticalDamage}");
                    ArcherCharacter.Health -= WarriorCharacter.PhysicalCriticalDamage;
                }
                else
                {
                    Console.WriteLine($"{WarriorCharacter.Name} наносит урон {ArcherCharacter.Name}");
                    Console.WriteLine($"Урон Воина - {WarriorCharacter.PhysicalAttack}");
                    ArcherCharacter.Health -= WarriorCharacter.PhysicalAttack;
                }
            }
            else
            {
                if (WarriorCharacter.PhysicalCriticalChanse >= new Random().Next(0, 100))
                {
                    Console.WriteLine($"{WarriorCharacter.Name} наносит критический урон {ArcherCharacter.Name}");
                    Console.WriteLine($"Крит.Урон Воина - {WarriorCharacter.PhysicalCriticalDamage}");
                    ArcherCharacter.Health -= WarriorCharacter.PhysicalCriticalDamage;
                }
                else
                {
                    Console.WriteLine($"{WarriorCharacter.Name} наносит урон {ArcherCharacter.Name}");
                    Console.WriteLine($"Урон Воина - {WarriorCharacter.PhysicalAttack}");
                    ArcherCharacter.Health -= WarriorCharacter.PhysicalAttack;
                }
            }

            if (MageCharacter.Health <= 0)
            {
                MageCharacter.Health = 0;
                MageCharacter.HealtheChangeEvent -= NewHealth;
            }
            if (ArcherCharacter.Health <= 0)
            {
                ArcherCharacter.Health = 0;
                ArcherCharacter.HealtheChangeEvent -= NewHealth;
            }
            if (WarriorCharacter.Health <= 0)
            {
                WarriorCharacter.Health = 0;
                WarriorCharacter.HealtheChangeEvent -= NewHealth;
            }

            Console.WriteLine($"Здоровье Мага - {Math.Round(MageCharacter.Health,0)}xp, Мана Мага - {MageCharacter.Mana}");
            Console.WriteLine($"Здоровье Воина - {Math.Round(WarriorCharacter.Health, 0)}xp");
            Console.WriteLine($"Здоровье Лучника - {Math.Round(ArcherCharacter.Health,0)}xp");
            Console.WriteLine();
        }
        public static void Test(WarriorCharacter WarriorCharacter, ArcherCharacter ArcherCharacter, MageCharacter MageCharacter)
        {
            MageCharacter.HealtheChangeEvent += NewHealth;
            WarriorCharacter.HealtheChangeEvent += NewHealth;
            ArcherCharacter.HealtheChangeEvent += NewHealth;

            MageCharacter.ManaChangeEvent += NewMana;

            int RandomFightOne = new Random().Next(1, 4);
            int RandomFightThree = new Random().Next(1, 5);
            int RandomHFightTwo = new Random().Next(1, 4);



        }

        public static void WinWarrior(WarriorCharacter WarriorCharacter)
        {
            Console.WriteLine($"{WarriorCharacter.Name} победил в поединке!");
            Console.WriteLine($"Теперь для {WarriorCharacter.Name} доступно 50 очков улучшений. Что вы хотите ему прокачать? 1.Сила, 2.Ловкость, 3.Интеллект, 4.Телосложение");
            Console.WriteLine($"Или можете прибавить ко всем характеристикам по 12 очков (5.Всё)");
            Console.WriteLine();
            string Сила = "Сила"; string One = "1"; string Two = "2"; string Three = "3"; string Four = "4"; string Five = "5";
            string Ловкость = "Ловкость";
            string Интеллект = "Интеллект";
            string Телосложение = "Телосложение";
            string Всё = "Всё";
            string upgrade = Console.ReadLine();
            WarriorCharacter.StrengthChangeEvent += Strength;
            WarriorCharacter.DexterityChangeEvent += Dexterity;
            WarriorCharacter.IntelligenceChangeEvent += Intelligence;
            WarriorCharacter.ConstitutionChangeEvent += Constitution;

            if (upgrade == Сила || upgrade == One)
            {
                WarriorCharacter.Strength += 50;
            }
            if (upgrade == Ловкость || upgrade == Two)
            {
                WarriorCharacter.Dexterity += 50;
            }
            if (upgrade == Интеллект || upgrade == Three)
            {
                WarriorCharacter.Intelligence += 50;
            }
            if (upgrade == Телосложение || upgrade == Four)
            {
                WarriorCharacter.Constitution += 50;
            }
            if (upgrade == Всё || upgrade == Five)
            {
                WarriorCharacter.Strength += 12;
                WarriorCharacter.Dexterity += 12;
                WarriorCharacter.Intelligence += 12;
                WarriorCharacter.Constitution += 12;
            }

            //switch (upgrade)
            //{
            //    case "Сила":
            //        WarriorCharacter.Strength += 50;
            //        Console.WriteLine($"Сила {WarriorCharacter.Name} улучшена на 50 очков");
            //        //Console.WriteLine($"Изменение 'Силы' повлияло на такие характеристики, как: ");
            //        break;
            //    case "Ловкость":
            //        WarriorCharacter.Dexterity += 50;
            //        Console.WriteLine($"Ловкость {WarriorCharacter.Name} улучшена на 50 очков");
            //        break;
            //    case "Интеллект":
            //        WarriorCharacter.Intelligence += 50;
            //        Console.WriteLine($"Интеллект {WarriorCharacter.Name} улучшен на 50 очков");
            //        break;
            //    case "Телосложение":
            //        WarriorCharacter.Constitution += 50;
            //        Console.WriteLine($"Телосложение {WarriorCharacter.Name} улучшено на 50 очков");
            //        break;
            //    default:
            //        Console.WriteLine("Вы ничего не выбрали или указали неправильное значение");
            //        break;
            //}
        }

        public static void WinMage(MageCharacter MageCharacter)
        {
            Console.WriteLine($"{MageCharacter.Name} победил в поединке!");
            Console.WriteLine($"Теперь для {MageCharacter.Name} доступно 50 очков улучшений. Что вы хотите ему прокачать? 1.Сила, 2.Ловкость, 3.Интеллект, 4.Телосложение");
            Console.WriteLine($"Или можете прибавить ко всем характеристикам по 12 очков (5.Всё)");
            Console.WriteLine();
            string Сила = "Сила"; string One = "1"; string Two = "2"; string Three = "3"; string Four = "4"; string Five = "5";
            string Ловкость = "Ловкость";
            string Интеллект = "Интеллект";
            string Телосложение = "Телосложение";
            string Всё = "Всё";
            string upgrade = Console.ReadLine();
            MageCharacter.StrengthChangeEvent += Strength;
            MageCharacter.DexterityChangeEvent += Dexterity;
            MageCharacter.IntelligenceChangeEvent += Intelligence;
            MageCharacter.ConstitutionChangeEvent += Constitution;

            if (upgrade == Сила || upgrade == One)
            {
                MageCharacter.Strength += 50;
            }
            if (upgrade == Ловкость || upgrade == Two)
            {
                MageCharacter.Dexterity += 50;
            }
            if (upgrade == Интеллект || upgrade == Three)
            {
                MageCharacter.Intelligence += 50;
            }
            if (upgrade == Телосложение || upgrade == Four)
            {
                MageCharacter.Constitution += 50;
            }
            if (upgrade == Всё || upgrade == Five)
            {
                MageCharacter.Strength += 12;
                MageCharacter.Dexterity += 12;
                MageCharacter.Intelligence += 12;
                MageCharacter.Constitution += 12;
            }
            //else
            //{
            //    Console.WriteLine("Вы указали неправильное значение");
            //}

            //switch (upgrade)
            //{
            //    case "Сила":
            //        MageCharacter.Strength += 50;
            //        Console.WriteLine($"Сила {MageCharacter.Name} улучшена на 50 очков");
            //        break;
            //    case "Ловкость":
            //        MageCharacter.Dexterity += 50;
            //        Console.WriteLine($"Ловкость {MageCharacter.Name} улучшена на 50 очков");
            //        break;
            //    case "Интеллект":
            //        MageCharacter.Intelligence += 50;
            //        Console.WriteLine($"Интеллект {MageCharacter.Name} улучшен на 50 очков");
            //        break;
            //    case "Телосложение":
            //        MageCharacter.Constitution += 50;
            //        Console.WriteLine($"Телосложение {MageCharacter.Name} улучшено на 50 очков");
            //        break;
            //    default:
            //        Console.WriteLine("Вы ничего не выбрали или указали неправильное значение");
            //        break;
            //}
        }

        public static void WinArcher(ArcherCharacter ArcherCharacter)
        {
            Console.WriteLine($"{ArcherCharacter.Name} победил в поединке!");
            Console.WriteLine($"Теперь для {ArcherCharacter.Name} доступно 50 очков улучшений. Что вы хотите ему прокачать? 1.Сила, 2.Ловкость, 3.Интеллект, 4.Телосложение");
            Console.WriteLine($"Или можете прибавить ко всем характеристикам по 12 очков (5.Всё)");
            Console.WriteLine();
            string Сила = "Сила"; string One = "1"; string Two = "2"; string Three = "3"; string Four = "4"; string Five = "5";
            string Ловкость = "Ловкость";
            string Интеллект = "Интеллект";
            string Телосложение = "Телосложение";
            string Всё = "Всё";
            string upgrade = Console.ReadLine();
            ArcherCharacter.StrengthChangeEvent += Strength;
            ArcherCharacter.DexterityChangeEvent += Dexterity;
            ArcherCharacter.IntelligenceChangeEvent += Intelligence;
            ArcherCharacter.ConstitutionChangeEvent += Constitution;

            if (upgrade == Сила || upgrade == One)
            {
                ArcherCharacter.Strength += 50;
            }
            if (upgrade == Ловкость || upgrade == Two)
            {
                ArcherCharacter.Dexterity += 50;
            }
            if (upgrade == Интеллект || upgrade == Three)
            {
                ArcherCharacter.Intelligence += 50;
            }
            if (upgrade == Телосложение || upgrade == Four)
            {
                ArcherCharacter.Constitution += 50;
            }
            if (upgrade == Всё || upgrade == Five)
            {
                ArcherCharacter.Strength += 12;
                ArcherCharacter.Dexterity += 12;
                ArcherCharacter.Intelligence += 12;
                ArcherCharacter.Constitution += 12;
            }
            //else
            //{
            //    Console.WriteLine("Вы указали неправильное значение");
            //}
        }

        static void NewHealth(double OldHealth, double NewHealth)
        {
            //if(NewHealth <= 0)
            //{
            //    NewHealth = 0;
            //}
            //if (OldHealth <= 0)
            //{
            //    OldHealth = 0;
            //}
            if (NewHealth > 0)
            {
                Console.WriteLine($"Старое значение здоровья: {Math.Round(OldHealth, 0)}xp было измененно на новое значение: {Math.Round(NewHealth, 0)}xp");
                Console.WriteLine();
            }
        }

        static void NewMana (double OldMana, double NewMana)
        {
            if (NewMana < 0)
            {
                NewMana = 0;
                Console.WriteLine($"Мана закончилась");
            }
            Console.WriteLine($"Старое значение маны: {Math.Round(OldMana, 0)} было измененно на новое значение: {Math.Round(NewMana, 0)}");
            Console.WriteLine();
        }
        static void Strength(double OldStrength, double NewStrength)
        {
            Console.WriteLine($"Старое значение силы: {Math.Round(OldStrength, 0)} было измененно на новое значение: {Math.Round(NewStrength, 0)}");
            Console.WriteLine();
        }
        static void Dexterity(double OldDexterity, double NewDexterity)
        {
            Console.WriteLine($"Старое значение ловкости: {Math.Round(OldDexterity, 0)} было измененно на новое значение: {Math.Round(NewDexterity, 0)}");
            Console.WriteLine();
        }
        static void Intelligence(double OldIntelligence, double NewIntelligence)
        {
            Console.WriteLine($"Старое значение интеллекта: {Math.Round(OldIntelligence, 0)} было измененно на новое значение: {Math.Round(NewIntelligence, 0)}");
            Console.WriteLine();
        }
        static void Constitution(double OldConstitution, double NewConstitution)
        {
            Console.WriteLine($"Старое значение телосложения: {Math.Round(OldConstitution, 0)} было измененно на новое значение: {Math.Round(NewConstitution, 0)}");
            Console.WriteLine();
        }
    }
}
