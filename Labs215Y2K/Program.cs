using System;
using System.Collections.Generic;

namespace Labs215Y2K
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            Console.WriteLine("Введите слова ");
            int value = 0;
            while (value == 0)
            {
                words.Add(Console.ReadLine());
                Console.WriteLine("Хотите ввести еще слово? 1 - Да, 2 - Завершить;");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        continue;  
                    case 2:
                        value = 1;
                        break;
                    default:
                        Console.WriteLine("Неверное число!");
                        break;
                }
            }
            Console.WriteLine("");
            foreach(var item in words)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            for (int i = 0; i < words.Count;i++)
            {
                if (words[i][0] == 'А' || words[i][0] == 'а')
                {
                    Console.Write($"{words[i]} ");
                    for (int j = 0; j < words.Count;j++)
                    {
                        if (words[j][0] == 'Б' || words[j][0] == 'б')
                        {
                            Console.Write($"{words[i]} ");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
