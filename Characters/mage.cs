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
        public Mage(int strentgh, int dexterity, int intelligence, int constitutions, int health, int manna, int mattack, int mdefence, int criticalchanse, int criticaldamage)
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
        public static void startmage(List<Warrior> warrior, List<Mage> mag)
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
                    Mage.magequestion(warrior,mag);
                    break;
                case 2:
                    Info.startredactor(warrior, mag);
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.startredactor(warrior, mag);
                    break;
            }
        }
        public static void magequestion(List<Warrior> warrior,List<Mage> mag)
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
                            Info.startredactor(warrior,mag);
                            break;
                        case 2:
                            if (mag[0].Strentgh == 15)
                            {
                                Console.WriteLine("Уже установлено минимальное значение силы!;");
                                Info.startredactor(warrior, mag);
                            }
                            else
                            {
                                Console.Write("Введите значение силы которое хотите убавить: ");
                                int strdell = int.Parse(Console.ReadLine());
                                if (strdell > 30)
                                {
                                    while (strdell > 30)
                                    {
                                        Console.Write($"Максимальное значение, которое можно убавить = {mag[0].Strentgh - 15}; Введите значение заново: ");
                                        strdell = int.Parse(Console.ReadLine());
                                        if (strdell <= 30)
                                        {
                                            
                                            mag[0].Strentgh -= strdell;
                                            Console.WriteLine($"Успешно убавлено {strdell}; Сила мага = {mag[0].Strentgh}");
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }

                                }
                                else
                                {
                                    if (strdell <= 30)
                                    {
                                        
                                        mag[0].Strentgh -= strdell;
                                        Console.WriteLine($"Успешно убавлено {strdell}; Сила мага = {mag[0].Strentgh}");
                                        
                                    }
                                }
                            }
                            Info.startredactor(warrior, mag);
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.startredactor(warrior, mag);
                            break;
                    }
                    break;
                case 2:
                    Console.Write("Вы хотите убавить значение ловкости или прибавить? 1 - Прибавить; 2 - Убавить: ");
                    int dextr = int.Parse(Console.ReadLine());
                    switch (dextr)
                    {
                        case 1:
                            
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
                            
                            Info.startredactor(warrior, mag);
                            break;
                        case 2:
                            if (mag[0].Dexterity == 20)
                            {
                                Console.WriteLine("Уже установлено минимальное значение ловкости!;");
                                Info.startredactor(warrior, mag);
                            }
                            else
                            {
                                Console.Write("Введите значение ловкости которое хотите убавить: ");
                                int dexdell = int.Parse(Console.ReadLine());
                                if (dexdell > 50)
                                {
                                    while (dexdell > 50)
                                    {
                                        Console.Write($"Максимальное значение, которое можно убавить = {mag[0].Dexterity - 20}; Введите значение заново: ");
                                        dexdell = int.Parse(Console.ReadLine());
                                        if (dexdell <= 50)
                                        {

                                            mag[0].Dexterity -= dexdell;
                                            Console.WriteLine($"Успешно убавлено {dexdell}; Ловкость мага = {mag[0].Dexterity}");
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }

                                }
                                else
                                {
                                    if (dexdell <= 50)
                                    {

                                        mag[0].Dexterity -= dexdell;
                                        Console.WriteLine($"Успешно убавлено {dexdell}; Ловкость мага = {mag[0].Dexterity}");

                                    }
                                }
                            }
                            Info.startredactor(warrior, mag);
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.startredactor(warrior, mag);
                            break;
                    }
                    break;
                case 3:
                    Console.Write("Вы хотите убавить значение интеллекта или прибавить? 1 - Прибавить; 2 - Убавить: ");
                    int intab = int.Parse(Console.ReadLine());
                    switch (intab)
                    {
                        case 1:
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
                            Info.startredactor(warrior, mag);
                            break;
                        case 2:
                            if (mag[0].Intelligence == 30)
                            {
                                Console.WriteLine("Уже установлено минимальное значение интеллекта!");
                                Info.startredactor(warrior, mag);
                            }
                            else
                            {
                                Console.Write("Введите значение интеллекта которое хотите убавить: ");
                                int intdell = int.Parse(Console.ReadLine());
                                if (intdell > 220)
                                {
                                    while (intdell > 220)
                                    {
                                        Console.Write($"Максимальное значение, которое можно убавить = {mag[0].Intelligence - 30}; Введите значение заново: ");
                                        intdell = int.Parse(Console.ReadLine());
                                        if (intdell <= 220)
                                        {

                                            mag[0].Intelligence -= intdell;
                                            Console.WriteLine($"Успешно убавлено {intdell}; Интеллект мага = {mag[0].Intelligence}");
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }

                                }
                                else
                                {
                                    if (intdell <= 220)
                                    {

                                        mag[0].Intelligence -= intdell;
                                        Console.WriteLine($"Успешно убавлено {intdell}; Интеллект мага = {mag[0].Intelligence}");

                                    }
                                }
                            }
                            Info.startredactor(warrior, mag);
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.startredactor(warrior, mag);
                            break;
                        
                    }
                    break;
                case 4:
                    Console.Write("Вы хотите убавить значение телосложения или прибавить? 1 - Прибавить; 2 - Убавить: ");
                    int con = int.Parse(Console.ReadLine());
                    switch (con)
                    {
                        case 1:
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
                            Info.startredactor(warrior, mag);
                            break;
                        case 2:
                            if (mag[0].Constitutions == 15)
                            {
                                Console.WriteLine("Уже установлено минимальное значение телосложения!");
                                Info.startredactor(warrior, mag);
                            }
                            else
                            {
                                Console.Write("Введите значение телосложения которое хотите убавить: ");
                                int condell = int.Parse(Console.ReadLine());
                                if (condell > 50)
                                {
                                    while (condell > 50)
                                    {
                                        Console.Write($"Максимальное значение, которое можно убавить = {mag[0].Constitutions - 15}; Введите значение заново: ");
                                        condell = int.Parse(Console.ReadLine());
                                        if (condell <= 50)
                                        {

                                            mag[0].Constitutions -= condell;
                                            Console.WriteLine($"Успешно убавлено {condell}; Телосложение мага = {mag[0].Constitutions}");
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }

                                }
                                else
                                {
                                    if (condell <= 50)
                                    {

                                        mag[0].Constitutions -= condell;
                                        Console.WriteLine($"Успешно убавлено {condell}; Телосложение мага = {mag[0].Constitutions}");

                                    }
                                }
                            }
                            Info.startredactor(warrior, mag);
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.startredactor(warrior, mag);
                            break;

                    }
                    break;
                    

            }
        }
    }
}
