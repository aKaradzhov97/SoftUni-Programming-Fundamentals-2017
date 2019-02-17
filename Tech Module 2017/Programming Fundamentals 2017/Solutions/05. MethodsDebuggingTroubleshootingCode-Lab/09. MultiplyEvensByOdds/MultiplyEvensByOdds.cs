using System;

class MultiplyEvensByOdds
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        n = Math.Abs(n);
        int evenSum = 0;
        int oddSum = 0;
        while (n > 0)
        {
            var x = n % 10;
            n = n / 10;
            if (x % 2 == 0)
            {
                evenSum += x;
            }
            else
            {
                oddSum += x;
            }
        }

        Console.WriteLine(oddSum * evenSum);
    }
}
