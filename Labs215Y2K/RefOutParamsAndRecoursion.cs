namespace Labs215Y2K
{
    class RefOutParamsAndRecoursion
    {
        static int RecursFactorial(int x)
        {
            if (x > 0)
            {
                return x * RecursFactorial(x - 1);
            }
            else
                return 1;
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void Sum(int a, int b, out int res)
        {

            res = a + b;
        }



    }
}
