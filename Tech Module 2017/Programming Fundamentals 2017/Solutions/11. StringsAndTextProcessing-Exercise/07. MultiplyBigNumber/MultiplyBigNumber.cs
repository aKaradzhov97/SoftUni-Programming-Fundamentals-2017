using System;
using System.Numerics;

class MultiplyBigNumber
{
    static void Main()
    {
        BigInteger num1 = BigInteger.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        var total = num1 * num2;
        Console.WriteLine("{0}", total);
    }
}