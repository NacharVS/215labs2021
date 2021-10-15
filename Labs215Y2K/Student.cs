using System;


namespace Labs215Y2K
{
    class SummId
    {
        class SummId1
        {
            public int Summ;
            public int id;
        }
       public static void SummIdSort()
        {

            SummId1[] summId = new SummId1[10];
            int[,] matrix = new int[10, 10];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                summId[i] = new SummId1();
                summId[i].id = i;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(0, 10);
                    summId[i].Summ += matrix[i, j];
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < summId.Length - 1; i++)
            {
                int buff1;
                int buff2;
                for (int j = 0; j < summId.Length - 1; j++)
                {

                    if (summId[j].Summ > summId[j + 1].Summ)
                    {
                        buff1 = summId[j].id;
                        buff2 = summId[j].Summ;
                        summId[j].id = summId[j + 1].id;
                        summId[j].Summ = summId[j + 1].Summ;
                        summId[j + 1].id = buff1;
                        summId[j + 1].Summ = buff2;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < summId.Length; i++)
            {
                Console.WriteLine($"строка - {summId[i].id} сумма - {summId[i].Summ}");
            }
        }
    }
}
