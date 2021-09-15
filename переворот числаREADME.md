# 215labs2       class Program
        {
            static void Main(string[] args)
            {
                int a = int.Parse(Console.ReadLine());
                int a1 = 0;
                while (a > 0)
                {
                    a1 *= 10;
                    a1 += a % 10;
                    a /= 10;
                }
                Console.WriteLine($"{a1}");
            }
        }
    }
