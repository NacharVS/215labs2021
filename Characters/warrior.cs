using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    class Warrior : Characteristics
    {
        private static int warriormaxstrength = 250;
        private static int warriormaxdexterity = 80;
        private static int warriormaxintelligence = 50;
        private static int warriormaxconstituion = 100;
        public Warrior(int strentgh, int dexterity, int intelligence, int constitutions, int health, int pattack, int pdefence, int criticalchanse, int criticaldamage)
        {
            Strentgh = strentgh;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Constitutions = constitutions;
            Health = health;
            Pattack = pattack;
            Pdefence = pdefence;
            PCriticalchanse = criticalchanse;
            PCriticaldamage = criticaldamage;
        }

        public static void startwarrior(List<Warrior> warrior, List <Mage> mag)
        {
            Console.WriteLine();
            Program.warriorprelisting(warrior);
            Console.WriteLine();
            Program.warriorlist(warrior);
            Console.WriteLine();
            Console.WriteLine("Вы хотите поменять характеристики воина? 1 - Да; 2 - Нет");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine();
                    Warrior.warrriorquestion(warrior, mag);
                    break;
                case 2:
                    Info.startredactor(warrior,mag);
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.startredactor(warrior, mag);
                    break;
            }
        }
        public static void warrriorquestion(List<Warrior> warrior, List<Mage> mag)
        {
            Console.WriteLine("Какие характеристики воина вы хотите поменять?");
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
                            if (stradd > (warriormaxstrength - warrior[0].Strentgh))
                            {
                                while (stradd > (warriormaxstrength - warriormaxstrength))
                                {

                                    Console.Write($"Максимальное значение которое можно добавить = {warriormaxstrength - warrior[0].Strentgh}; Введите значение заново: ");
                                    stradd = int.Parse(Console.ReadLine());
                                    if (stradd <= (warriormaxstrength - warrior[0].Strentgh))
                                    {
                                        warrior[0].Strentgh += stradd;
                                        Console.WriteLine($"Успешно добавлено {stradd}; Сила воина = {warrior[0].Strentgh}");
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else if (stradd <= (warriormaxstrength - warrior[0].Strentgh))
                            {
                                warrior[0].Strentgh += stradd;
                                Console.WriteLine($"Успешно добавлено {stradd}; Сила воина = {warrior[0].Strentgh}");
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer12 = int.Parse(Console.ReadLine());
                            switch (answer12)
                            {
                                case 1:
                                    Warrior.warrriorquestion(warrior, mag);
                                    break;
                                case 2:
                                    Program.warriorprelisting(warrior);
                                    Info.startredactor(warrior, mag);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(warrior, mag);
                                    break;

                            }
                            
                            break;
                        case 2:
                            if (warrior[0].Strentgh == 30)
                            {
                                Console.WriteLine("Уже установлено минимальное значение силы!;");
                                Info.startredactor(warrior, mag);
                            }
                            else
                            {
                                Console.Write("Введите значение силы которое хотите убавить: ");
                                int strdell = int.Parse(Console.ReadLine());
                                if (strdell > 220)
                                {
                                    while (strdell > 220)
                                    {
                                        Console.Write($"Максимальное значение, которое можно убавить = {warrior[0].Strentgh - 30}; Введите значение заново: ");
                                        strdell = int.Parse(Console.ReadLine());
                                        if (strdell <= 220)
                                        {

                                            warrior[0].Strentgh -= strdell;
                                            Console.WriteLine($"Успешно убавлено {strdell}; Сила воина = {warrior[0].Strentgh}");
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
                                    if (strdell <= 220)
                                    {

                                        warrior[0].Strentgh -= strdell;
                                        Console.WriteLine($"Успешно убавлено {strdell}; Сила воина = {warrior[0].Strentgh}");

                                    }
                                }
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer13 = int.Parse(Console.ReadLine());
                            switch (answer13)
                            {
                                case 1:
                                    Warrior.warrriorquestion(warrior, mag);
                                    break;
                                case 2:
                                    Program.warriorprelisting(warrior);
                                    Info.startredactor(warrior, mag);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(warrior, mag);
                                    break;

                            }
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
                            if (dexadd > (warriormaxdexterity - warrior[0].Dexterity))
                            {
                                while (dexadd > (warriormaxdexterity - warrior[0].Dexterity))
                                {

                                    Console.Write($"Максимальное значение которое можно добавить = {warriormaxdexterity - warrior[0].Dexterity}; Введите значение заново: ");
                                    dexadd = int.Parse(Console.ReadLine());
                                    if (dexadd <= (warriormaxdexterity - warrior[0].Dexterity))
                                    {
                                        warrior[0].Dexterity += dexadd;
                                        Console.WriteLine($"Успешно добавлено {dexadd}; Ловкость воина = {warrior[0].Dexterity}");
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else if (dexadd <= (warriormaxdexterity - warrior[0].Dexterity))
                            {
                                warrior[0].Dexterity += dexadd;
                                Console.WriteLine($"Успешно добавлено {dexadd}; Ловкость лучника = {warrior[0].Dexterity}");
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer13 = int.Parse(Console.ReadLine());
                            switch (answer13)
                            {
                                case 1:
                                    Warrior.warrriorquestion(warrior, mag);
                                    break;
                                case 2:
                                    Program.warriorprelisting(warrior);
                                    Info.startredactor(warrior, mag);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(warrior, mag);
                                    break;

                            }
                            break;
                        case 2:
                            if (warrior[0].Dexterity == 15)
                            {
                                Console.WriteLine("Уже установлено минимальное значение ловкости!;");
                                Info.startredactor(warrior, mag);
                            }
                            else
                            {
                                Console.Write("Введите значение ловкости которое хотите убавить: ");
                                int dexdell = int.Parse(Console.ReadLine());
                                if (dexdell > 65)
                                {
                                    while (dexdell > 65)
                                    {
                                        Console.Write($"Максимальное значение, которое можно убавить = {warrior[0].Dexterity - 15}; Введите значение заново: ");
                                        dexdell = int.Parse(Console.ReadLine());
                                        if (dexdell <= 65)
                                        {

                                            warrior[0].Dexterity -= dexdell;
                                            Console.WriteLine($"Успешно убавлено {dexdell}; Ловкость воина = {warrior[0].Dexterity}");
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
                                    if (dexdell <= 65)
                                    {

                                        warrior[0].Dexterity -= dexdell;
                                        Console.WriteLine($"Успешно убавлено {dexdell}; Ловкость воина = {warrior[0].Dexterity}");

                                    }
                                }
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer14 = int.Parse(Console.ReadLine());
                            switch (answer14)
                            {
                                case 1:
                                    Warrior.warrriorquestion(warrior, mag);
                                    break;
                                case 2:
                                    Program.warriorprelisting(warrior);
                                    Info.startredactor(warrior, mag);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(warrior, mag);
                                    break;

                            }
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
                            if (intadd > (warriormaxintelligence - warrior[0].Intelligence))
                            {
                                while (intadd > (warriormaxintelligence - warrior[0].Intelligence))
                                {

                                    Console.Write($"Максимальное значение которое можно добавить = {warriormaxintelligence - warrior[0].Intelligence}; Введите значение заново: ");
                                    intadd = int.Parse(Console.ReadLine());
                                    if (intadd <= (warriormaxintelligence - warrior[0].Intelligence))
                                    {
                                        warrior[0].Intelligence += intadd;
                                        Console.WriteLine($"Успешно добавлено {intadd}; Интеллект воина = {warrior[0].Intelligence}");
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else if (intadd <= (warriormaxintelligence - warrior[0].Intelligence))
                            {
                                warrior[0].Intelligence += intadd;
                                Console.WriteLine($"Успешно добавлено {intadd}; Интеллект мага = {warrior[0].Intelligence}");
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer14 = int.Parse(Console.ReadLine());
                            switch (answer14)
                            {
                                case 1:
                                    Warrior.warrriorquestion(warrior, mag);
                                    break;
                                case 2:
                                    Program.warriorprelisting(warrior);
                                    Info.startredactor(warrior, mag);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(warrior, mag);
                                    break;

                            }
                            break;
                        case 2:
                            if (warrior[0].Intelligence == 10)
                            {
                                Console.WriteLine("Уже установлено минимальное значение интеллекта!");
                                Info.startredactor(warrior, mag);
                            }
                            else
                            {
                                Console.Write("Введите значение интеллекта которое хотите убавить: ");
                                int intdell = int.Parse(Console.ReadLine());
                                if (intdell > 40)
                                {
                                    while (intdell > 40)
                                    {
                                        Console.Write($"Максимальное значение, которое можно убавить = {warrior[0].Intelligence - 10}; Введите значение заново: ");
                                        intdell = int.Parse(Console.ReadLine());
                                        if (intdell <= 40)
                                        {

                                            warrior[0].Intelligence -= intdell;
                                            Console.WriteLine($"Успешно убавлено {intdell}; Интеллект воина = {warrior[0].Intelligence}");
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
                                    if (intdell <= 40)
                                    {

                                        warrior[0].Intelligence -= intdell;
                                        Console.WriteLine($"Успешно убавлено {intdell}; Интеллект воина = {warrior[0].Intelligence}");

                                    }
                                }
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer13 = int.Parse(Console.ReadLine());
                            switch (answer13)
                            {
                                case 1:
                                    Warrior.warrriorquestion(warrior, mag);
                                    break;
                                case 2:
                                    Program.warriorprelisting(warrior);
                                    Info.startredactor(warrior, mag);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(warrior, mag);
                                    break;

                            }
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
                            if (conadd > (warriormaxconstituion - warrior[0].Constitutions))
                            {
                                while (conadd > (warriormaxconstituion - warrior[0].Constitutions))
                                {

                                    Console.Write($"Максимальное значение которое можно добавить = {warriormaxconstituion - warrior[0].Constitutions}; Введите значение заново: ");
                                    conadd = int.Parse(Console.ReadLine());
                                    if (conadd <= (warriormaxconstituion - warrior[0].Constitutions))
                                    {
                                        warrior[0].Constitutions += conadd;
                                        Console.WriteLine($"Успешно добавлено {conadd}; Телосложение воина = {warrior[0].Constitutions}");
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else if (conadd <= (warriormaxconstituion - warrior[0].Constitutions))
                            {
                                warrior[0].Constitutions += conadd;
                                Console.WriteLine($"Успешно добавлено {conadd}; Телосложение воина = {warrior[0].Constitutions}");
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer13 = int.Parse(Console.ReadLine());
                            switch (answer13)
                            {
                                case 1:
                                    Warrior.warrriorquestion(warrior, mag);
                                    break;
                                case 2:
                                    Program.warriorprelisting(warrior);
                                    Info.startredactor(warrior, mag);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(warrior, mag);
                                    break;

                            }
                            break;
                        case 2:
                            if (warrior[0].Constitutions == 25)
                            {
                                Console.WriteLine("Уже установлено минимальное значение телосложения!");
                                Info.startredactor(warrior, mag);
                            }
                            else
                            {
                                Console.Write("Введите значение телосложения которое хотите убавить: ");
                                int condell = int.Parse(Console.ReadLine());
                                if (condell > 75)
                                {
                                    while (condell > 75)
                                    {
                                        Console.Write($"Максимальное значение, которое можно убавить = {warrior[0].Constitutions - 25}; Введите значение заново: ");
                                        condell = int.Parse(Console.ReadLine());
                                        if (condell <= 75)
                                        {

                                            warrior[0].Constitutions -= condell;
                                            Console.WriteLine($"Успешно убавлено {condell}; Телосложение воина = {warrior[0].Constitutions}");
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
                                    if (condell <= 75)
                                    {

                                        warrior[0].Constitutions -= condell;
                                        Console.WriteLine($"Успешно убавлено {condell}; Телосложение воина = {warrior[0].Constitutions}");

                                    }
                                }
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer14 = int.Parse(Console.ReadLine());
                            switch (answer14)
                            {
                                case 1:
                                    Warrior.warrriorquestion(warrior, mag);
                                    break;
                                case 2:
                                    Program.warriorprelisting(warrior);
                                    Info.startredactor(warrior, mag);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(warrior, mag);
                                    break;

                            }
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.startredactor(warrior, mag);
                            break;

                    }
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.startredactor(warrior, mag);
                    break;

            }
        }
    }
}
