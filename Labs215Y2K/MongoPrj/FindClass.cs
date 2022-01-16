using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.MongoPrj
{
    class FindClass
    {
        public static void Start()
        {
            Console.Write("Введите курс студента для поиска: ");
            int coursechoose = int.Parse(Console.ReadLine());
            if (coursechoose < 1 || coursechoose > 4)
            {
                while (coursechoose < 1 || coursechoose > 4)
                {
                    Console.Write("Неверный курс! Введите курс заново: ");
                    coursechoose = int.Parse(Console.ReadLine());
                    if (coursechoose > 1 | coursechoose < 4)
                    {
                        FindClass.CourseAsk(coursechoose);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else if (coursechoose > 1 | coursechoose < 4)
            {
                FindClass.CourseAsk(coursechoose);
            }
        }
        public static void CourseAsk(int course)
        {
            Console.WriteLine("1 - Поиск по имени");
            Console.WriteLine("2 - Поиск по возрасту");
            Console.WriteLine("3 - Поиск по специальности");
            Console.Write("Выберите параметр: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    FindClass.NameFind(course);
                    break;
                case 2:
                    FindClass.AgeFind(course);
                    break;
                case 3:
                    FindClass.SpecializationFind(course);
                    break;
                default:
                    Console.WriteLine("Неверная цифра!");
                    FindClass.CourseAsk(course);
                    break;
            }
        }
        public static void SpecializationFind(int course)
        {
            Console.Write("Введите спецаильность для поиска: ");
            string specfind = Console.ReadLine();
            if (course == 1)
            {
                Examples.SpecializationFindFirstCourse(specfind);
                StartClass.Start();
            }
            else if (course == 2)
            {
                Examples.SpecializationFindSecondCourse(specfind);
                StartClass.Start();
            }
            else if (course == 3)
            {
                Examples.SpecializationFindThirdCourse(specfind);
                StartClass.Start();
            }
            else if (course == 4)
            {
                Examples.SpecializationFindFourCourse(specfind);
                StartClass.Start();
            }
        }
        public static void NameFind(int course)
        {
            Console.Write("Введите имя студента для поиска: ");
            string namesearch = Console.ReadLine();
            if (course == 1)
            {
                Examples.NameSearchFirstCourse(namesearch);
                StartClass.Start();
            }
            else if (course == 2)
            {
                Examples.NameSearchSecondCourse(namesearch);
                StartClass.Start();
            }
            else if (course == 3)
            {
                Examples.NameSearchThirdCourse(namesearch);
                StartClass.Start();
            }
            else if (course == 4)
            {
                Examples.NameSearchFourCourse(namesearch);
                StartClass.Start();
            }
        }
        public static void AgeFind(int course)
        {
            Console.WriteLine("Как вы хотите найти студента?");
            Console.WriteLine("1 - Студентов-(а), меньше заданного возраста");
            Console.WriteLine("2 - Студентов-(а), больше заданного возраста");
            Console.WriteLine("3 - Студентов-(а) заданного возраста");
            Console.Write("Введите число: ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write("Введите возраст для поиска: ");
                    int agefind = int.Parse(Console.ReadLine());
                    if (agefind < 16 || agefind > 21)
                    {
                        while (agefind < 16 || agefind > 21)
                        {
                            Console.Write("Данный возраст не может быть у студента.Введите его заново: ");
                            agefind = int.Parse(Console.ReadLine());
                            if (agefind > 16 | agefind < 21)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (agefind >= 16 | agefind <= 21)
                    {

                    }
                    if (course == 1)
                    {
                        Examples.FindLessAgeFristCourse(agefind);
                        StartClass.Start();
                        break;
                    }
                    else if (course == 2)
                    {
                        Examples.FindLessAgeSecondCourse(agefind);
                        StartClass.Start();
                        break;
                    }
                    else if (course == 3)
                    {
                        Examples.FindLessAgeThirdCourse(agefind);
                        StartClass.Start();
                        break;
                    }
                    else if (course == 4)
                    {
                        Examples.FindLessAgeFourCourse(agefind);
                        StartClass.Start();
                        break;
                    }
                    break;
                case 2:
                    Console.Write("Введите возраст для поиска: ");
                    int agefindtwo = int.Parse(Console.ReadLine());
                    if (agefindtwo < 16 || agefindtwo > 21)
                    {
                        while (agefindtwo < 16 || agefindtwo > 21)
                        {
                            Console.Write("Данный возраст не может быть у студента.Введите его заново: ");
                            agefindtwo = int.Parse(Console.ReadLine());
                            if (agefindtwo > 16 | agefindtwo < 21)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (agefindtwo >= 16 | agefindtwo <= 21)
                    {

                    }
                    if (course == 1)
                    {
                        Examples.FindAgeMoreFirstCourse(agefindtwo);
                        StartClass.Start();
                        break;
                    }
                    else if (course == 2)
                    {
                        Examples.FindAgeMoreSecondCourse(agefindtwo);
                        StartClass.Start();
                        break;
                    }
                    else if (course == 3)
                    {
                        Examples.FindAgeMoreThirdCourse(agefindtwo);
                        StartClass.Start();
                        break;
                    }
                    else if (course == 4)
                    {
                        Examples.FindAgeMoreFourCourse(agefindtwo);
                        StartClass.Start();
                        break;
                    }
                    break;
                case 3:
                    Console.Write("Введите возраст для поиска: ");
                    int agefindthree = int.Parse(Console.ReadLine());
                    if (agefindthree < 16 || agefindthree > 21)
                    {
                        while (agefindthree < 16 || agefindthree > 21)
                        {
                            Console.Write("Данный возраст не может быть у студента.Введите его заново: ");
                            agefindthree = int.Parse(Console.ReadLine());
                            if (agefindthree > 16 | agefindthree < 21)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (agefindthree >= 16 | agefindthree <= 21)
                    {

                    }
                    if (course == 1)
                    {
                        Examples.FindAgeFirstCourse(agefindthree);
                        StartClass.Start();
                        break;
                    }
                    else if (course == 2)
                    {
                        Examples.FindAgeSecondCourse(agefindthree);
                        StartClass.Start();
                        break;
                    }
                    else if (course == 3)
                    {
                        Examples.FindAgeThirdCourse(agefindthree);
                        StartClass.Start();
                        break;
                    }
                    else if (course == 4)
                    {
                        Examples.FindAgeFourCourse(agefindthree);
                        StartClass.Start();
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("Неверная цифра!");
                    StartClass.Start();
                    break;

            }
            
        }
        
    }
}
