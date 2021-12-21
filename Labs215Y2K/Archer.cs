using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs215Y2K
{
    class Archer : Character
    {
        private static int archermaxstrength = 55;
        private static int archermaxdexterity = 250;
        private static int archermaxintelligence = 70;
        private static int archermaxconstituion = 70;
        public Archer(double strentgh, double dexterity, double intelligence, double constitutions, double health, double pattack, double pdefence, double criticalchanse, double criticaldamage, double pdamage)
        {
            Strentgh = strentgh;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Constitutions = constitutions;
            health = Health;
            pattack = Pattack;
            pdefence = Pdefence;
            criticalchanse = PCriticalchanse;
            criticaldamage = PCriticaldamage;
            pdamage = Pdamage;
        }

        public static void startarcher(List<Archer> archer, List<Warrior> warrior, List<Mage> mag, double newmaxhealth)
        {
            Console.WriteLine();
            Program.archerlist(archer);
            Console.WriteLine();
            Console.WriteLine("Вы хотите поменять характеристики лучника? 1 - Да; 2 - Нет");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine();
                    Archer.archerquestion(archer, warrior, mag, newmaxhealth);
                    break;
                case 2:
                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                    break;
            }
        }
        public static void archerquestion(List<Archer> archer, List<Warrior> warrior, List<Mage> mag, double newmaxhealth)
        {
            Console.WriteLine("Какие характеристики лучника вы хотите поменять?");
            Console.WriteLine("1 - Сила; 2 - Ловкость; 3 - Интеллект; 4 - Телосложение");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write("Вы хотите убавить значение силы или прибавить? 1 - Прибавить; 2 - Убавить: ");
                    double strenth = double.Parse(Console.ReadLine());
                    switch (strenth)
                    {
                        case 1:
                            Console.Write("Введите значение силы которое хотите добавить: ");
                            double stradd = double.Parse(Console.ReadLine());
                            if (stradd > (archermaxstrength - archer[0].Strentgh))
                            {
                                while (stradd > (archermaxstrength - archer[0].Strentgh))
                                {

                                    Console.Write($"Максимальное значение которое можно добавить = {archermaxstrength - archer[0].Strentgh}; Введите значение заново: ");
                                    stradd = double.Parse(Console.ReadLine());
                                    if (stradd <= (archermaxstrength - archer[0].Strentgh))
                                    {
                                        archer[0].Strentgh += stradd;
                                        Console.WriteLine($"Успешно добавлено {stradd}; Сила лучника = {archer[0].Strentgh}");
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else if (stradd <= (archermaxstrength - archer[0].Strentgh))
                            {
                                archer[0].Strentgh += stradd;
                                Console.WriteLine($"Успешно добавлено {stradd}; Сила лучника = {archer[0].Strentgh}");
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer12 = int.Parse(Console.ReadLine());
                            switch (answer12)
                            {
                                case 1:
                                    Archer.archerquestion(archer, warrior, mag, newmaxhealth);
                                    break;
                                case 2:
                                    Program.archerprelisting(archer);
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;

                            }

                            break;
                        case 2:
                            if (archer[0].Strentgh == 20)
                            {
                                Console.WriteLine("Уже установлено минимальное значение силы!;");
                                Info.startredactor(archer, warrior, mag, newmaxhealth);
                            }
                            else
                            {
                                Console.Write("Введите значение силы которое хотите убавить: ");
                                double strdell = double.Parse(Console.ReadLine());
                                if (strdell > 35)
                                {
                                    while (strdell > 35)
                                    {
                                        Console.Write($"Максимальное значение, которое можно убавить = {archer[0].Strentgh - 20}; Введите значение заново: ");
                                        strdell = double.Parse(Console.ReadLine());
                                        if (strdell <= 35)
                                        {

                                            archer[0].Strentgh -= strdell;
                                            Console.WriteLine($"Успешно убавлено {strdell}; Сила лучника = {archer[0].Strentgh}");
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
                                    if (strdell <= 35)
                                    {

                                        archer[0].Strentgh -= strdell;
                                        Console.WriteLine($"Успешно убавлено {strdell}; Сила лучника = {archer[0].Strentgh}");

                                    }
                                }
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer13 = int.Parse(Console.ReadLine());
                            switch (answer13)
                            {
                                case 1:
                                    Archer.archerquestion(archer, warrior, mag, newmaxhealth);
                                    break;
                                case 2:
                                    Program.archerprelisting(archer);
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;

                            }
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.startredactor(archer, warrior, mag, newmaxhealth);
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
                            double dexadd = double.Parse(Console.ReadLine());
                            if (dexadd > (archermaxdexterity - archer[0].Dexterity))
                            {
                                while (dexadd > (archermaxdexterity - archer[0].Dexterity))
                                {

                                    Console.Write($"Максимальное значение которое можно добавить = {archermaxdexterity - archer[0].Dexterity}; Введите значение заново: ");
                                    dexadd = double.Parse(Console.ReadLine());
                                    if (dexadd <= (archermaxdexterity - archer[0].Dexterity))
                                    {
                                        archer[0].Dexterity += dexadd;
                                        Console.WriteLine($"Успешно добавлено {dexadd}; Ловкость лучника = {archer[0].Dexterity}");
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else if (dexadd <= (archermaxdexterity - archer[0].Dexterity))
                            {
                                archer[0].Dexterity += dexadd;
                                Console.WriteLine($"Успешно добавлено {dexadd}; Ловкость лучника = {archer[0].Dexterity}");
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer13 = int.Parse(Console.ReadLine());
                            switch (answer13)
                            {
                                case 1:
                                    Archer.archerquestion(archer, warrior, mag, newmaxhealth);
                                    break;
                                case 2:
                                    Program.archerprelisting(archer);
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;

                            }
                            break;
                        case 2:
                            if (archer[0].Dexterity == 30)
                            {
                                Console.WriteLine("Уже установлено минимальное значение ловкости!;");
                                Info.startredactor(archer, warrior, mag, newmaxhealth);
                            }
                            else
                            {
                                Console.Write("Введите значение ловкости которое хотите убавить: ");
                                double dexdell = double.Parse(Console.ReadLine());
                                if (dexdell > 220)
                                {
                                    while (dexdell > 220)
                                    {
                                        Console.Write($"Максимальное значение, которое можно убавить = {archer[0].Dexterity - 30}; Введите значение заново: ");
                                        dexdell = double.Parse(Console.ReadLine());
                                        if (dexdell <= 220)
                                        {

                                            archer[0].Dexterity -= dexdell;
                                            Console.WriteLine($"Успешно убавлено {dexdell}; Ловкость лучника = {archer[0].Dexterity}");
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
                                    if (dexdell <= 220)
                                    {

                                        archer[0].Dexterity -= dexdell;
                                        Console.WriteLine($"Успешно убавлено {dexdell}; Ловкость лучника = {archer[0].Dexterity}");

                                    }
                                }
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer14 = int.Parse(Console.ReadLine());
                            switch (answer14)
                            {
                                case 1:
                                    Archer.archerquestion(archer, warrior, mag, newmaxhealth);
                                    break;
                                case 2:
                                    Program.archerprelisting(archer);
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;

                            }
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.startredactor(archer, warrior, mag, newmaxhealth);
                            break;
                    }
                    break;
                case 3:
                    Console.Write("Вы хотите убавить значение интеллекта или прибавить? 1 - Прибавить; 2 - Убавить: ");
                    double intab = double.Parse(Console.ReadLine());
                    switch (intab)
                    {
                        case 1:
                            Console.Write("Введите значение интеллекта которое хотите добавить: ");
                            double intadd = double.Parse(Console.ReadLine());
                            if (intadd > (archermaxintelligence - archer[0].Intelligence))
                            {
                                while (intadd > (archermaxintelligence - archer[0].Intelligence))
                                {

                                    Console.Write($"Максимальное значение которое можно добавить = {archermaxintelligence - archer[0].Intelligence}; Введите значение заново: ");
                                    intadd = double.Parse(Console.ReadLine());
                                    if (intadd <= (archermaxintelligence - archer[0].Intelligence))
                                    {
                                        archer[0].Intelligence += intadd;
                                        Console.WriteLine($"Успешно добавлено {intadd}; Интеллект лучника = {archer[0].Intelligence}");
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else if (intadd <= (archermaxintelligence - archer[0].Intelligence))
                            {
                                archer[0].Intelligence += intadd;
                                Console.WriteLine($"Успешно добавлено {intadd}; Интеллект лучника = {archer[0].Intelligence}");
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer14 = int.Parse(Console.ReadLine());
                            switch (answer14)
                            {
                                case 1:
                                    Archer.archerquestion(archer, warrior, mag, newmaxhealth);
                                    break;
                                case 2:
                                    Program.archerprelisting(archer);
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;

                            }
                            break;
                        case 2:
                            if (archer[0].Intelligence == 15)
                            {
                                Console.WriteLine("Уже установлено минимальное значение интеллекта!");
                                Info.startredactor(archer, warrior, mag, newmaxhealth);
                            }
                            else
                            {
                                Console.Write("Введите значение интеллекта которое хотите убавить: ");
                                double intdell = double.Parse(Console.ReadLine());
                                if (intdell > 55)
                                {
                                    while (intdell > 55)
                                    {
                                        Console.Write($"Максимальное значение, которое можно убавить = {archer[0].Intelligence - 15}; Введите значение заново: ");
                                        intdell = double.Parse(Console.ReadLine());
                                        if (intdell <= 55)
                                        {

                                            archer[0].Intelligence -= intdell;
                                            Console.WriteLine($"Успешно убавлено {intdell}; Интеллект лучника = {archer[0].Intelligence}");
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
                                    if (intdell <= 55)
                                    {

                                        archer[0].Intelligence -= intdell;
                                        Console.WriteLine($"Успешно убавлено {intdell}; Интеллект лучника = {archer[0].Intelligence}");

                                    }
                                }
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer13 = int.Parse(Console.ReadLine());
                            switch (answer13)
                            {
                                case 1:
                                    Archer.archerquestion(archer, warrior, mag, newmaxhealth);
                                    break;
                                case 2:
                                    Program.archerprelisting(archer);
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;

                            }
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.startredactor(archer, warrior, mag, newmaxhealth);
                            break;

                    }
                    break;
                case 4:
                    Console.Write("Вы хотите убавить значение телосложения или прибавить? 1 - Прибавить; 2 - Убавить: ");
                    double con = double.Parse(Console.ReadLine());
                    switch (con)
                    {
                        case 1:
                            Console.Write("Введите значение телосложения которое хотите добавить: ");
                            double conadd = double.Parse(Console.ReadLine());
                            if (conadd > (archermaxconstituion - archer[0].Constitutions))
                            {
                                while (conadd > (archermaxconstituion - archer[0].Constitutions))
                                {

                                    Console.Write($"Максимальное значение которое можно добавить = {archermaxconstituion - archer[0].Constitutions}; Введите значение заново: ");
                                    conadd = double.Parse(Console.ReadLine());
                                    if (conadd <= (archermaxconstituion - archer[0].Constitutions))
                                    {
                                        archer[0].Constitutions += conadd;
                                        Console.WriteLine($"Успешно добавлено {conadd}; Телосложение лучника = {archer[0].Constitutions}");
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else if (conadd <= (archermaxconstituion - archer[0].Constitutions))
                            {
                                archer[0].Constitutions += conadd;
                                Console.WriteLine($"Успешно добавлено {conadd}; Телосложение лучника = {archer[0].Constitutions}");
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer13 = int.Parse(Console.ReadLine());
                            switch (answer13)
                            {
                                case 1:
                                    Archer.archerquestion(archer, warrior, mag, newmaxhealth);
                                    break;
                                case 2:
                                    Program.archerprelisting(archer);
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;

                            }
                            break;
                        case 2:
                            if (archer[0].Constitutions == 20)
                            {
                                Console.WriteLine("Уже установлено минимальное значение телосложения!");
                                Info.startredactor(archer, warrior, mag, newmaxhealth);
                            }
                            else
                            {
                                Console.Write("Введите значение телосложения которое хотите убавить: ");
                                double condell = double.Parse(Console.ReadLine());
                                if (condell > 50)
                                {
                                    while (condell > 50)
                                    {
                                        Console.Write($"Максимальное значение, которое можно убавить = {archer[0].Constitutions - 20}; Введите значение заново: ");
                                        condell = double.Parse(Console.ReadLine());
                                        if (condell <= 50)
                                        {

                                            archer[0].Constitutions -= condell;
                                            Console.WriteLine($"Успешно убавлено {condell}; Телосложение лучника = {archer[0].Constitutions}");
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

                                        archer[0].Constitutions -= condell;
                                        Console.WriteLine($"Успешно убавлено {condell}; Телосложение лучника = {archer[0].Constitutions}");

                                    }
                                }
                            }
                            Console.WriteLine("Вы хотите продолжить изменять характеристики? 1 - Да; 2 - Нет");
                            int answer14 = int.Parse(Console.ReadLine());
                            switch (answer14)
                            {
                                case 1:
                                    Archer.archerquestion(archer, warrior, mag, newmaxhealth);
                                    break;
                                case 2:
                                    Program.archerprelisting(archer);
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;
                                default:
                                    Console.WriteLine("Неверное число!");
                                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                                    break;

                            }
                            break;
                        default:
                            Console.WriteLine("Неверный номер!");
                            Info.startredactor(archer, warrior, mag, newmaxhealth);
                            break;

                    }
                    break;
                default:
                    Console.WriteLine("Неверный номер!");
                    Info.startredactor(archer, warrior, mag, newmaxhealth);
                    break;

            }

        }
    }
}
