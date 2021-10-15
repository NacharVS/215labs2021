using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    class Base
    {
        public string name;
        public int age;

        static void Main(string[] args)
        {
            Base stud1 = new Base();
            Base stud2 = new Base();
            Base stud3 = new Base();
            Base stud4 = new Base();
            Base stud5 = new Base();
            Base stud6 = new Base();
            Base stud7 = new Base();
            Base stud8 = new Base();
            Base stud9 = new Base();
            Base stud10 = new Base();




            stud1.name = "Иван Пушкин";
            stud2.name = "Игорь Чехов";
            stud3.name = "Вадим Распутин";
            stud4.name = "Сергей Колотушкин";
            stud5.name = "Артём Шпала";
            stud6.name = "Ян Беззубов";
            stud7.name = "Егор Суббот";
            stud8.name = "Дмитрий Песков";
            stud9.name = "Матвей Новиков";
            stud10.name = "Олег Тинькофф";

            stud1.age = 17;
            stud2.age = 19;
            stud3.age = 16;
            stud4.age = 20;
            stud5.age = 16;
            stud6.age = 17;
            stud7.age = 15;
            stud8.age = 21;
            stud9.age = 19;
            stud10.age = 18;

            Base[] student = new Base[10];
            Console.WriteLine("Имя, фамилия" + "\t" + "Возраст студента");

            if (stud1.age >= 18)
                Console.WriteLine(stud1.name + "\t" + stud1.age);

            if (stud2.age >= 18)
                Console.WriteLine(stud2.name + "\t" + stud2.age);

            if (stud3.age >= 18)
                Console.WriteLine(stud2.name + "\t" + stud3.age);

            if (stud4.age >= 18)
                Console.WriteLine(stud2.name + "\t" + stud4.age);

            if (stud5.age >= 18)
                Console.WriteLine(stud5.name + "\t" + stud5.age);

            if (stud6.age >= 18)
                Console.WriteLine(stud6.name + "\t" + stud6.age);

            if (stud7.age >= 18)
                Console.WriteLine(stud7.name + "\t" + stud7.age);

            if (stud8.age >= 18)
                Console.WriteLine(stud8.name + "\t" + stud8.age);

            if (stud9.age >= 18)
                Console.WriteLine(stud9.name + "\t" + stud9.age);

            if (stud10.age >= 18)
                Console.WriteLine(stud10.name + "\t" + stud10.age);

            Console.ReadKey();
            // kod s massivom ne rabotal

        }
    }
}
