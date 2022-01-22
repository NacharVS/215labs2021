﻿using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace Labs215Y2K.MongoPrj
{
    class Examples
    {
        //массивы групп
        private static int[] firstcourse = { 102, 103, 115, 120, 136 };
        private static int[] secondcourse = { 202, 203, 215, 220, 236 };
        private static int[] thirdcourse = { 302, 303, 315, 320, 336 };
        private static int[] fourcourse = { 402, 403, 415, 420, 436 };
        //добавление студентов в бд с помощью коллекций
        public static void AddToDataBaseFirstCourse(string name, string surname, string otchestvo, int age, string gender, int year, string progress, int course, int group, string specialization)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students First Course");
            collection.InsertOne(new Student(name, surname, otchestvo, age, gender, year, progress, course, group, specialization));

        }
        public static void AddToDataBaseSecondCourse(string name, string surname, string otchestvo, int age, string gender, int year, string progress, int course, int group, string specialization)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Second Course");
            collection.InsertOne(new Student(name, surname, otchestvo, age, gender, year, progress, course, group, specialization));
        }
        public static void AddToDataBaseThirdCourse(string name, string surname, string otchestvo, int age, string gender, int year, string progress, int course, int group, string specialization)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Third Course");
            collection.InsertOne(new Student(name, surname, otchestvo, age, gender, year, progress, course, group, specialization));
        }
        public static void AddToDataBaseFourCourse(string name, string surname, string otchestvo, int age, string gender, int year, string progress, int course, int group, string specialization)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Four Course");
            collection.InsertOne(new Student(name, surname, otchestvo, age, gender, year, progress, course, group, specialization));
        }

        //поиск студентов по имени

        public static void NameSearchFirstCourse(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students First Course");
            List<Student> list = collection.Find(x => x.Name == name).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (name == list[i].Name)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студента с таким именем!");
                StartClass.Start();

            }


        }
        public static void NameSearchSecondCourse(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Second Course");
            List<Student> list = collection.Find(x => x.Name == name).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (name == list[i].Name)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студента с таким именем!");
                StartClass.Start();
            }
        }
        public static void NameSearchThirdCourse(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Third Course");
            List<Student> list = collection.Find(x => x.Name == name).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (name == list[i].Name)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студента с таким именем!");
                StartClass.Start();
            }
        }
        public static void NameSearchFourCourse(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Four Course");
            List<Student> list = collection.Find(x => x.Name == name).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (name == list[i].Name)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студента с таким именем!");
                StartClass.Start();
            }
        }

        //поиск студентов по возрасту меньше

        public static void FindLessAgeFristCourse(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students First Course");
            List<Student> list = collection.Find(x => x.Age < age).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age < age)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов меньше данного возраста!");
            }
        }
        public static void FindLessAgeSecondCourse(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Second Course");
            List<Student> list = collection.Find(x => x.Age < age).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age < age)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов меньше данного возраста!");
            }
        }
        public static void FindLessAgeThirdCourse(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Third Course");
            List<Student> list = collection.Find(x => x.Age < age).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age < age)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов меньше данного возраста!");
            }
        }
        public static void FindLessAgeFourCourse(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Four Course");
            List<Student> list = collection.Find(x => x.Age < age).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age < age)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов меньше данного возраста!");
            }
        }

        //поиск студентов по возрасту больше 

        public static void FindAgeMoreFirstCourse(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students First Course");
            List<Student> list = collection.Find(x => x.Age > age).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age > age)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов больше данного возраста!");
            }
        }
        public static void FindAgeMoreSecondCourse(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Second Course");
            List<Student> list = collection.Find(x => x.Age > age).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age > age)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов больше данного возраста!");
            }
        }
        public static void FindAgeMoreThirdCourse(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Third Course");
            List<Student> list = collection.Find(x => x.Age > age).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age > age)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов больше данного возраста!");
            }
        }
        public static void FindAgeMoreFourCourse(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Four Course");
            List<Student> list = collection.Find(x => x.Age > age).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age > age)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов больше данного возраста!");
            }
        }

        //поиск студентов по заданному возрасту

        public static void FindAgeFirstCourse(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students First Course");
            List<Student> list = collection.Find(x => x.Age == age).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age == age)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов данного возраста!");
            }
        }
        public static void FindAgeSecondCourse(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Second Course");
            List<Student> list = collection.Find(x => x.Age == age).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age == age)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов данного возраста!");
            }
        }
        public static void FindAgeThirdCourse(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Third Course");
            List<Student> list = collection.Find(x => x.Age == age).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age == age)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов данного возраста!");
            }
        }
        public static void FindAgeFourCourse(int age)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Four Course");
            List<Student> list = collection.Find(x => x.Age == age).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age == age)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов данного возраста!");
            }
        }

        //поиск студентов по специальности

        public static void SpecializationFindFirstCourse(string specialization)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students First Course");
            List<Student> list = collection.Find(x => x.Specialization == specialization).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Specialization == specialization)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов данной специальности!");
            }
        }
        public static void SpecializationFindSecondCourse(string specialization)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Second Course");
            List<Student> list = collection.Find(x => x.Specialization == specialization).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Specialization == specialization)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов данной специальности!");
            }
        }
        public static void SpecializationFindThirdCourse(string specialization)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Third Course");
            List<Student> list = collection.Find(x => x.Specialization == specialization).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Specialization == specialization)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов данной специальности!");
            }
        }
        public static void SpecializationFindFourCourse(string specialization)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Four Course");
            List<Student> list = collection.Find(x => x.Specialization == specialization).ToList();
            int chet = 3;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Specialization == specialization)
                {
                    chet = 1;
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (chet == 1)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
                }
            }
            else
            {
                Console.WriteLine("Нет студентов данной специальности!");
            }
        }

        //вывод списка студентов

        public static void StudentsFirstCourse()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students First Course");
            List<Student> list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
            }
        }
        public static void StudentsSecondCourse()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Second Course");
            List<Student> list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
            }
        }
        public static void StudentsThirdCourse()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Third Course");
            List<Student> list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
            }
        }
        public static void StudentsFourCourse()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Four Course");
            List<Student> list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"Имя: {item.Name} Фамилия {item.Surname} Возраст: {item.Age}  Группа: {item.Group} Специальность: {item.Specialization}");
            }
        }




        // поиск по имени 





        public static void NameThirdCourseRebase(string searchName, Student student)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Third Course");
            collection.ReplaceOne(x => x.Name == searchName, student);
        }
        public static void SecondnameThirdCourseRebase(string searchSecondName, Student student)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students  Course");
            collection.ReplaceOne(x => x.Surname == searchSecondName, student);
        }
        public static void NameSecondCourseRebase(string searchName, Student student)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Second Course");
            collection.ReplaceOne(x => x.Name == searchName, student);
        }
        public static void SecondnameSecondCourseRebase(string searchSecondName, Student student)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Second Course");
            collection.ReplaceOne(x => x.Surname == searchSecondName, student);
        }
        public static void NameFirstCourseRebase(string searchName, Student student)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students First Course");
            collection.ReplaceOne(x => x.Name == searchName, student);
        }
        public static void SecondnameFirstCourseRebase(string searchSecondName, Student student)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students First Course");
            collection.ReplaceOne(x => x.Surname == searchSecondName, student);
        }



        public static void NameFourCourseRebase(string searchName , Student student)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Four Course");
            collection.ReplaceOne(x => x.Name == searchName, student);
        }
        public static void SecondnameFourCourseRebase(string searchSecondName, Student student)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StudentsDateBaseInfo");
            var collection = database.GetCollection<Student>("Students Four Course");
            collection.ReplaceOne(x => x.Surname == searchSecondName, student);
        }





















        //метод заполнения базы данных
        public static void firstcourselist()
        {
            for (int i = 0; i < firstcourse.Length; i++)
            {
                Console.Write($"{firstcourse[i]} ");
            }

        }
        public static void secondcourselist()
        {
            for (int i = 0; i < secondcourse.Length; i++)
            {
                Console.Write($"{secondcourse[i]} ");
            }
        }
        public static void thirdcourselist()
        {
            for (int i = 0; i < thirdcourse.Length; i++)
            {
                Console.Write($"{thirdcourse[i]} ");
            }
        }
        public static void fourcourselist()
        {
            for (int i = 0; i < fourcourse.Length; i++)
            {
                Console.Write($"{fourcourse[i]} ");
            }
        }
        public static void Start()
        {
            Console.WriteLine("Добро пожаловать!Добавьте студентов в базу данных");
            int i = 1;
            while (i != 0)
            {
                Console.Write("Введите имя студента: ");
                string name = Console.ReadLine();
                Console.Write("Введите фамилию студента: ");
                string surname = Console.ReadLine();
                Console.Write("Введите отчество студента: ");
                string otchestvo = Console.ReadLine();
                Console.Write("Введите возраст студента: ");
                int age = int.Parse(Console.ReadLine());
                if (age < 16 || age > 21)
                {
                    while (age < 16 || age > 21)
                    {
                        Console.Write("Это не возраст студента!Введите возраст по новому: ");
                        age = int.Parse(Console.ReadLine());
                        if (age < 16 || age > 21)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if (age >= 16 || age <= 21)
                {

                }
                Console.Write("Введите пол студента: 1 - М; 2 - Ж:  ");
                int question = int.Parse(Console.ReadLine());
                string gender = "";
                if (question != 1 & question != 2)
                {
                    while (question != 1 & question != 2)
                    {
                        Console.Write("Неверный пол!Введите цифру студента заново: ");
                        question = int.Parse(Console.ReadLine());
                        if (question == 1)
                        {
                            gender = "М";
                            break;
                        }
                        else if (question == 2)
                        {
                            gender = "Ж";
                            break;
                        }
                        else if (question != 1 & question != 2)
                        {
                            continue;
                        }
                    }
                }
                else if (question == 1)
                {
                    gender = "М";
                }
                else if (question == 2)
                {
                    gender = "Ж";
                }
                Console.Write("Введите год поступления студента: ");
                int year = int.Parse(Console.ReadLine());
                while (year < 2018 || year > 2022)
                {
                    Console.Write("Неверный год!Введите год поступления студента заново: ");
                    year = int.Parse(Console.ReadLine());
                    if (year <= 2018 || year >= 2022)
                    {
                        continue;
                    }
                    else if (year < 2018 || year > 2022)
                    {
                        break;
                    }
                }
                Console.Write("Введите успеваемость студента (5 - Отлично, 4 - Хорошо, 3 - Удовлетворительно, 2 - Плохо): ");
                string progress = "";
                int answerquestion = int.Parse(Console.ReadLine());
                if (answerquestion != 5 & answerquestion != 4 & answerquestion != 3 & answerquestion != 2)
                {
                    while (answerquestion != 5 & answerquestion != 4 & answerquestion != 3 & answerquestion != 2)
                    {
                        Console.Write("Неверное число!Введите заново: ");
                        answerquestion = int.Parse(Console.ReadLine());
                        if (answerquestion == 5)
                        {
                            progress = "Отлично";
                            break;
                        }
                        else if (answerquestion == 4)
                        {
                            progress = "Хорошо";
                            break;
                        }
                        else if (answerquestion == 3)
                        {
                            progress = "Удовлетворительно";
                            break;
                        }
                        else if (answerquestion == 2)
                        {
                            progress = "Плохо";
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (answerquestion == 5)
                {
                    progress = "Отлично";
                    
                }
                else if (answerquestion == 4)
                {
                    progress = "Хорошо";
                    
                }
                else if (answerquestion == 3)
                {
                    progress = "Удовлетворительно";
                    
                }
                else if (answerquestion == 2)
                {
                    progress = "Плохо";
                    
                }
                Console.Write("Введите курс, для выбора группы: ");
                int courseshow = int.Parse(Console.ReadLine());
                string specialization = "";
                if (courseshow != 1 & courseshow != 2 & courseshow != 3 & courseshow != 4)
                {
                    while (courseshow != 1 & courseshow != 2 & courseshow != 3 & courseshow != 4)
                    {
                        Console.Write("Такого курса не существует в техникуме!Введите заново: ");
                        courseshow = int.Parse(Console.ReadLine());
                        if (courseshow == 1)
                        {
                            Examples.firstcourselist();
                            Console.WriteLine();
                            Console.Write("Введите группу: ");
                            int groupchoose = int.Parse(Console.ReadLine());
                            int chet1 = 3;
                            for (int j = 0; j < firstcourse.Length; j++)
                            {
                                if (groupchoose == firstcourse[j])
                                {
                                    chet1 = 1;
                                    break;
                                }
                                else
                                {
                                    chet1 = 0;
                                }
                            }
                            if (chet1 == 0)
                            {
                                while (chet1 == 0)
                                {
                                    Console.Write("Такой группы нет!Введите заново: ");
                                    groupchoose = int.Parse(Console.ReadLine());
                                    if (groupchoose == 102)
                                    {
                                        specialization = "СССК";
                                        Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 103)
                                    {
                                        specialization = "МТС";
                                        Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 115)
                                    {
                                        specialization = "КСК";
                                        Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 120)
                                    {
                                        specialization = "П";
                                        Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 136)
                                    {
                                        specialization = "ССА";
                                        Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else if (chet1 == 1)
                            {
                                if (groupchoose == 102)
                                {
                                    specialization = "СССК";
                                    Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 103)
                                {
                                    specialization = "МТС";
                                    Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 115)
                                {
                                    specialization = "КСК";
                                    Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 120)
                                {
                                    specialization = "П";
                                    Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 136)
                                {
                                    specialization = "ССА";
                                    Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                            }
                            break;
                        }
                        else if (courseshow == 2)
                        {
                            Examples.secondcourselist();
                            Console.WriteLine();
                            Console.Write("Введите группу: ");
                            int groupchoose = int.Parse(Console.ReadLine());
                            int chet1 = 3;
                            for (int j = 0; j < secondcourse.Length; j++)
                            {
                                if (groupchoose == secondcourse[j])
                                {
                                    chet1 = 1;
                                    break;
                                }
                                else
                                {
                                    chet1 = 0;
                                }
                            }
                            if (chet1 == 0)
                            {
                                while (chet1 == 0)
                                {
                                    Console.Write("Такой группы нет!Введите заново: ");
                                    groupchoose = int.Parse(Console.ReadLine());
                                    if (groupchoose == 202)
                                    {
                                        specialization = "СССК";
                                        Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 203)
                                    {
                                        specialization = "МТС";
                                        Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 215)
                                    {
                                        specialization = "КСК";
                                        Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 220)
                                    {
                                        specialization = "П";
                                        Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 236)
                                    {
                                        specialization = "ССА";
                                        Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else if (chet1 == 1)
                            {
                                if (groupchoose == 202)
                                {
                                    specialization = "СССК";
                                    Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 203)
                                {
                                    specialization = "МТС";
                                    Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 215)
                                {
                                    specialization = "КСК";
                                    Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 220)
                                {
                                    specialization = "П";
                                    Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 236)
                                {
                                    specialization = "ССА";
                                    Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                            }
                            break;
                        }
                        else if (courseshow == 3)
                        {
                            Examples.thirdcourselist();
                            Console.WriteLine();
                            Console.Write("Введите группу: ");
                            int groupchoose = int.Parse(Console.ReadLine());
                            int chet1 = 3;
                            for (int j = 0; j < thirdcourse.Length; j++)
                            {
                                if (groupchoose == thirdcourse[j])
                                {
                                    chet1 = 1;
                                    break;
                                }
                                else
                                {
                                    chet1 = 0;
                                }
                            }
                            if (chet1 == 0)
                            {
                                while (chet1 == 0)
                                {
                                    Console.Write("Такой группы нет!Введите заново: ");
                                    groupchoose = int.Parse(Console.ReadLine());
                                    if (groupchoose == 302)
                                    {
                                        specialization = "СССК";
                                        Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 303)
                                    {
                                        specialization = "МТС";
                                        Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 315)
                                    {
                                        specialization = "КСК";
                                        Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 320)
                                    {
                                        specialization = "П";
                                        Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 336)
                                    {
                                        specialization = "ССА";
                                        Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else if (chet1 == 1)
                            {
                                if (groupchoose == 302)
                                {
                                    specialization = "СССК";
                                    Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 303)
                                {
                                    specialization = "МТС";
                                    Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 315)
                                {
                                    specialization = "КСК";
                                    Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 320)
                                {
                                    specialization = "П";
                                    Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 336)
                                {
                                    specialization = "ССА";
                                    Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                            }
                            break;
                        }
                        else if (courseshow == 4)
                        {
                            Examples.fourcourselist();
                            Console.WriteLine();
                            Console.Write("Введите группу: ");
                            int groupchoose = int.Parse(Console.ReadLine());
                            int chet1 = 3;
                            for (int j = 0; j < fourcourse.Length; j++)
                            {
                                if (groupchoose == fourcourse[j])
                                {
                                    chet1 = 1;
                                    break;
                                }
                                else
                                {
                                    chet1 = 0;
                                }
                            }
                            if (chet1 == 0)
                            {
                                while (chet1 == 0)
                                {
                                    Console.Write("Такой группы нет!Введите заново: ");
                                    groupchoose = int.Parse(Console.ReadLine());
                                    if (groupchoose == 402)
                                    {
                                        specialization = "СССК";
                                        Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 403)
                                    {
                                        specialization = "МТС";
                                        Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 415)
                                    {
                                        specialization = "КСК";
                                        Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 420)
                                    {
                                        specialization = "П";
                                        Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else if (groupchoose == 436)
                                    {
                                        specialization = "ССА";
                                        Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }

                                }
                            }
                            else if (chet1 == 1)
                            {
                                if (groupchoose == 402)
                                {
                                    specialization = "СССК";
                                    Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 403)
                                {
                                    specialization = "МТС";
                                    Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 415)
                                {
                                    specialization = "КСК";
                                    Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 420)
                                {
                                    specialization = "П";
                                    Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                    
                                }
                                else if (groupchoose == 436)
                                {
                                    specialization = "ССА";
                                    Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                   
                                }
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (courseshow == 1)
                {
                    Examples.firstcourselist();
                    Console.WriteLine();
                    Console.Write("Введите группу: ");
                    int groupchoose = int.Parse(Console.ReadLine());
                    int chet1 = 3;
                    for (int j = 0; j < firstcourse.Length; j++)
                    {
                        if (groupchoose == firstcourse[j])
                        {
                            chet1 = 1;
                            break;
                        }
                        else
                        {
                            chet1 = 0;
                        }
                    }
                    if (chet1 == 0)
                    {
                        while (chet1 == 0)
                        {
                            Console.Write("Такой группы нет!Введите заново: ");
                            groupchoose = int.Parse(Console.ReadLine());
                            if (groupchoose == 102)
                            {
                                specialization = "СССК";
                                Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 103)
                            {
                                specialization = "МТС";
                                Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 115)
                            {
                                specialization = "КСК";
                                Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 120)
                            {
                                specialization = "П";
                                Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 136)
                            {
                                specialization = "ССА";
                                Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (chet1 == 1)
                    {
                        if (groupchoose == 102)
                        {
                            specialization = "СССК";
                            Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 103)
                        {
                            specialization = "МТС";
                            Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 115)
                        {
                            specialization = "КСК";
                            Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 120)
                        {
                            specialization = "П";
                            Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 136)
                        {
                            specialization = "ССА";
                            Examples.AddToDataBaseFirstCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                    }
                }
                else if (courseshow == 2)
                {
                    Examples.secondcourselist();
                    Console.WriteLine();
                    Console.Write("Введите группу: ");
                    int groupchoose = int.Parse(Console.ReadLine());
                    int chet1 = 3;
                    for (int j = 0; j < secondcourse.Length; j++)
                    {
                        if (groupchoose == secondcourse[j])
                        {
                            chet1 = 1;
                            break;
                        }
                        else
                        {
                            chet1 = 0;
                        }
                    }
                    if (chet1 == 0)
                    {
                        while (chet1 == 0)
                        {
                            Console.Write("Такой группы нет!Введите заново: ");
                            groupchoose = int.Parse(Console.ReadLine());
                            if (groupchoose == 202)
                            {
                                specialization = "СССК";
                                Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 203)
                            {
                                specialization = "МТС";
                                Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 215)
                            {
                                specialization = "КСК";
                                Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 220)
                            {
                                specialization = "П";
                                Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 236)
                            {
                                specialization = "ССА";
                                Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (chet1 == 1)
                    {
                        if (groupchoose == 202)
                        {
                            specialization = "СССК";
                            Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 203)
                        {
                            specialization = "МТС";
                            Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 215)
                        {
                            specialization = "КСК";
                            Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 220)
                        {
                            specialization = "П";
                            Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 236)
                        {
                            specialization = "ССА";
                            Examples.AddToDataBaseSecondCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                    }
                    
                }
                else if (courseshow == 3)
                {
                    Examples.thirdcourselist();
                    Console.WriteLine();
                    Console.Write("Введите группу: ");
                    int groupchoose = int.Parse(Console.ReadLine());
                    int chet1 = 3;
                    for (int j = 0; j < thirdcourse.Length; j++)
                    {
                        if (groupchoose == thirdcourse[j])
                        {
                            chet1 = 1;
                            break;
                        }
                        else
                        {
                            chet1 = 0;
                        }
                    }
                    if (chet1 == 0)
                    {
                        while (chet1 == 0)
                        {
                            Console.Write("Такой группы нет!Введите заново: ");
                            groupchoose = int.Parse(Console.ReadLine());
                            if (groupchoose == 302)
                            {
                                specialization = "СССК";
                                Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 303)
                            {
                                specialization = "МТС";
                                Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 315)
                            {
                                specialization = "КСК";
                                Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 320)
                            {
                                specialization = "П";
                                Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 336)
                            {
                                specialization = "ССА";
                                Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else if (chet1 == 1)
                    {
                        if (groupchoose == 302)
                        {
                            specialization = "СССК";
                            Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 303)
                        {
                            specialization = "МТС";
                            Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 315)
                        {
                            specialization = "КСК";
                            Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 320)
                        {
                            specialization = "П";
                            Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 336)
                        {
                            specialization = "ССА";
                            Examples.AddToDataBaseThirdCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                    }
                    
                }
                else if (courseshow == 4)
                {
                    Examples.fourcourselist();
                    Console.WriteLine();
                    Console.Write("Введите группу: ");
                    int groupchoose = int.Parse(Console.ReadLine());
                    int chet1 = 3;
                    for (int j = 0; j < fourcourse.Length; j++)
                    {
                        if (groupchoose == fourcourse[j])
                        {
                            chet1 = 1;
                            break;
                        }
                        else
                        {
                            chet1 = 0;
                        }
                    }
                    if (chet1 == 0)
                    {
                        while (chet1 == 0)
                        {
                            Console.Write("Такой группы нет!Введите заново: ");
                            groupchoose = int.Parse(Console.ReadLine());
                            if (groupchoose == 402)
                            {
                                specialization = "СССК";
                                Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 403)
                            {
                                specialization = "МТС";
                                Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 415)
                            {
                                specialization = "КСК";
                                Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 420)
                            {
                                specialization = "П";
                                Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else if (groupchoose == 436)
                            {
                                specialization = "ССА";
                                Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                                break;
                            }
                            else
                            {
                                continue;
                            }

                        }
                    }
                    else if (chet1 == 1)
                    {
                        if (groupchoose == 402)
                        {
                            specialization = "СССК";
                            Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 403)
                        {
                            specialization = "МТС";
                            Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                           
                        }
                        else if (groupchoose == 415)
                        {
                            specialization = "КСК";
                            Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 420)
                        {
                            specialization = "П";
                            Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                        else if (groupchoose == 436)
                        {
                            specialization = "ССА";
                            Examples.AddToDataBaseFourCourse(name, surname, otchestvo, age, gender, year, progress, courseshow, groupchoose, specialization);
                            
                        }
                    }
                }
                Console.WriteLine("Хотите продолжить? 1 - Да, 2 - Нет");
                int answer = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (answer)
                {
                    case 1:
                        continue;
                    case 2:
                        i = 0;
                        break;
                    default:
                        Console.WriteLine("Неверная цифра!");
                        break;
                    
                }
            }
        }
        
    }
}
