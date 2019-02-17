using System;
using System.Numerics;

    class FactorialTrailingZeroes
    {
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }

        int countOfZeros = 0;

    point:

        if (factorial % 10 == 0)
        {
            factorial = factorial / 10;
            countOfZeros++;
            goto point;
            //GOTO IS USED FOR LEARNING PURPOSES ONLY!
        }
        Console.WriteLine(countOfZeros);
    }
}