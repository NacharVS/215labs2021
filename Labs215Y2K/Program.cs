using System;
using System.ComponentModel.DataAnnotations;

namespace Labs215Y2K
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            Student student1 = new Student();
            student1.name = "Valeriy";
            student1.group = 222;
            student1.age = 16;
            Student student2 = new Student();
            student2.name = "Ivan";
            student2.group = 223;
            student2.age = 17;
            Student student3 = new Student();
            student3.name = "Sergey";
            student3.group = 221;
            student3.age = 18;

            students[0] = student1;
            students[1] = student2;
            students[2] = student3;

            foreach (var item in students)
            {
                if(item.age >= 18)
                    Console.WriteLine(item.name);
            }
            


        }       
    }
}
