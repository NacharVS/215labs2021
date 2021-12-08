using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    class Mage : Characteristics
    {
        private static int magemaxstrentgh = 45;
        private static int magemaxdexterity = 70;
        private static int mageIntelligence = 250;
        private static int magemaxConstitutions = 65;
        public Mage(int strentgh, int dexterity, int intelligence, int constitutions, int health, int manna, int pattack, int pdefence, int mattack, int mdefence, int criticalchanse, int criticaldamage)
        {
            Strentgh = strentgh;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Constitutions = constitutions;
            Health = health;
            Manna = manna;
            Mattack = mattack;
            Mdefence = mdefence;
            MCriticalchanse = criticalchanse;
            MCriticaldamage = criticaldamage;
        }
        static Mage mag = new Mage(15, 20, 30, 15, 0, 0, 0, 0, 0, 0, 0, 0);

        public static void startmage(List<Mage> mag)
        {
            Console.WriteLine();
            Program.listing(mag);
            Console.WriteLine();
            Console.WriteLine("Вы хотите поменять характеристики мага? 1 - Да; 2 - Нет");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine();
                    Mage.magequestion(mag);
                    break;
                case 2:
                    Info.startredactor(mag);
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.startredactor(mag);
                    break;
            }
        }
        public static void magequestion(List<Mage> mag)
        {
            Console.WriteLine("Какие характеристики мага вы хотите поменять?");
            Console.WriteLine("1 - Сила; 2 - Ловкость; 3 - Интеллект; 4 - Телосложение");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write("Вы хотите убавить значение силы или прибавить? 1 - Прибавить; 2 - Убавить: ");
                    int strenth = int.Parse(Console.ReadLine());
                    switch (strenth)
                    {
                        case 1:
                            Console.Write("Введите значение силы которое хотите добавить: ");
                            int stradd = int.Parse(Console.ReadLine());
                            if (stradd > (magemaxstrentgh - mag[0].Strentgh))
                            {
                                while (stradd > (magemaxstrentgh - mag[0].Strentgh))
                                {

                                    Console.Write($"Максимальное значение которое можно добавить = {magemaxstrentgh - mag[0].Strentgh}; Введите значение заново: ");
                                    stradd = int.Parse(Console.ReadLine());
                                    if (stradd <= (magemaxstrentgh - mag[0].Strentgh))
                                    {
                                        mag[0].Strentgh += stradd;
                                        Console.WriteLine($"Успешно добавлено {stradd}; Сила мага = {mag[0].Strentgh}");
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else if (stradd <= (magemaxstrentgh - mag[0].Strentgh))
                            {
                                mag[0].Strentgh += stradd;
                                Console.WriteLine($"Успешно добавлено {stradd}; Сила мага = {mag[0].Strentgh}");
                            }
                            Info.startredactor(mag);
                            break;
                        case 2:
                            Console.Write("Введите значение силы которое хотите добавить: ");
                            int strdell = int.Parse(Console.ReadLine());
                            
                    }
                    break;
                    
                case 2:
                    Console.Write("Введите значение ловкости которое хотите добавить: ");
                    int dexadd = int.Parse(Console.ReadLine());
                    if (dexadd > (magemaxdexterity - mag[0].Dexterity))
                    {
                        while (dexadd > (magemaxdexterity - mag[0].Dexterity))
                        {
                            
                            Console.Write($"Максимальное значение которое можно добавить = {magemaxdexterity - mag[0].Dexterity}; Введите значение заново: ");
                            dexadd = int.Parse(Console.ReadLine());
                            if (dexadd <= (magemaxdexterity - mag[0].Dexterity))
                            {
                                mag[0].Dexterity += dexadd;
                                Console.WriteLine($"Успешно добавлено {dexadd}; Ловкость мага = {mag[0].Dexterity}");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (dexadd <= (magemaxdexterity - mag[0].Dexterity))
                    {
                        mag[0].Dexterity += dexadd;
                        Console.WriteLine($"Успешно добавлено {dexadd}; Ловкость мага = {mag[0].Dexterity}");
                    }
                    Info.startredactor(mag);
                    break;
                case 3:
                    Console.Write("Введите значение интеллекта которое хотите добавить: ");
                    int intadd = int.Parse(Console.ReadLine());
                    if (intadd > (mageIntelligence - mag[0].Intelligence))
                    {
                        while (intadd > (mageIntelligence - mag[0].Intelligence))
                        {

                            Console.Write($"Максимальное значение которое можно добавить = {mageIntelligence - mag[0].Intelligence}; Введите значение заново: ");
                            intadd = int.Parse(Console.ReadLine());
                            if (intadd <= (mageIntelligence - mag[0].Intelligence))
                            {
                                mag[0].Intelligence += intadd;
                                Console.WriteLine($"Успешно добавлено {intadd}; Интеллект мага = {mag[0].Intelligence}");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (intadd <= (mageIntelligence - mag[0].Intelligence))
                    {
                        mag[0].Intelligence += intadd;
                        Console.WriteLine($"Успешно добавлено {intadd}; Интеллект мага = {mag[0].Intelligence}");
                    }
                    Info.startredactor(mag);
                    break;
                case 4:
                    Console.Write("Введите значение телосложения которое хотите добавить: ");
                    int conadd = int.Parse(Console.ReadLine());
                    if (conadd > (magemaxConstitutions - mag[0].Constitutions))
                    {
                        while (conadd > (magemaxConstitutions - mag[0].Constitutions))
                        {

                            Console.Write($"Максимальное значение которое можно добавить = {magemaxConstitutions - mag[0].Constitutions}; Введите значение заново: ");
                            conadd = int.Parse(Console.ReadLine());
                            if (conadd <= (mageIntelligence - mag[0].Intelligence))
                            {
                                mag[0].Constitutions += conadd;
                                Console.WriteLine($"Успешно добавлено {conadd}; Телосложение мага = {mag[0].Constitutions}");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (conadd <= (magemaxConstitutions - mag[0].Constitutions))
                    {
                        mag[0].Constitutions += conadd;
                        Console.WriteLine($"Успешно добавлено {conadd}; Телосложение мага = {mag[0].Constitutions}");
                    }
                    Info.startredactor(mag);
                    break;

            }
        }
    }
}
