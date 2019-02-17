using System;
using System.Text;
using System.Numerics;

class ConvertFromBase10ToBaseN
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Trim().Split();
        int baseN = int.Parse(input[0]);

        BigInteger baseTen = BigInteger.Parse(input[1]);
        StringBuilder result = new StringBuilder();

        while (baseTen > 0)
        {
            BigInteger reminder = baseTen % baseN;
            result.Insert(0, reminder.ToString());
            baseTen /= baseN;
        }

        Console.WriteLine(result);
    }
}