using System;

class SumOfOddNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= n * 2; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
                sum += i;
            }
        }
        Console.WriteLine("Sum: " + sum);
    }
}
