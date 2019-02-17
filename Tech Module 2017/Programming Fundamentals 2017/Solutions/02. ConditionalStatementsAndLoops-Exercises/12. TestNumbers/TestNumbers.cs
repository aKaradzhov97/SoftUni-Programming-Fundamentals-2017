using System;

public class TestNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int maxSumBoundary = int.Parse(Console.ReadLine());
        int sum = 0;
        var counter = 0;

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= m; j++)
            {
                if (sum >= maxSumBoundary)
                {
                    break;
                }
                else
                {
                    sum = sum + ((i * j) * 3);
                    counter++;
                }
            }
        }
        if (sum >= maxSumBoundary)
        {
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum} >= {maxSumBoundary}");
        }
        else
        {
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}