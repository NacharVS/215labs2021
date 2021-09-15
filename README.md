# 215labs2021
 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("привет");
            string f = Console.ReadLine(); 
            if (f== "привет") 
                Console.WriteLine("на оценки учишься школе?"); 
            else 
                Console.WriteLine("на какие оценки учишься в школе, ответь пожалуйста цифрой?"); 
            string d = Console.ReadLine(); 
            if (d == "2") 
                Console.WriteLine("ты что двоечник… ужас("); 
            else
                Console.WriteLine("не плохо, старайся…");

               Console. ReadLine(); 
            string a = Console.ReadLine(); 
            if (a == "да") 
                if (d == "3") 
                    Console.WriteLine("не плохо, старайся…"); 
            if (d == "4") 
                Console.WriteLine("хорошо, ты можешь, лучше!"); 
            if (d == "5") 
                Console.WriteLine("ничего себе, молодец!!!)");

            Console.WriteLine("А настоящий?");
            string s = Console.ReadLine();
            if (s == "да")
                Console.WriteLine("приятно познакомиться, меня зовут Давид, я самый глупый бот на свете");
            else
                Console.WriteLine("приятно познакомиться, меня зовут Давид, я самый глупый бот на свете"); 
            if (a == "нет") 
                Console.WriteLine("приятно познакмиться с себеподобным, можешь звать меня Давид, я умнее тебя");
        }
    }
