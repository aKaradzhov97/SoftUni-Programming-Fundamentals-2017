﻿using System;
using System.Numerics;

class Factorial
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine(factorial);
    }
}