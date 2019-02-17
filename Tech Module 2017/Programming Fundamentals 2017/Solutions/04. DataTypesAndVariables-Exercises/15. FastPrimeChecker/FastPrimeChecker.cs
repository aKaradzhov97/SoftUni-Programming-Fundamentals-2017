using System;

class FastPrimeChecker
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            bool boolChecker = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    boolChecker = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {boolChecker}");
        }
    }
}
