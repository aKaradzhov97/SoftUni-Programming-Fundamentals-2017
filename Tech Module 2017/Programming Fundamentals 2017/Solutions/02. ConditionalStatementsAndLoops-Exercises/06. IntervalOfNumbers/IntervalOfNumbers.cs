using System;

class IntervalOfNumbers
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int startIndex = Math.Min(x, y);
        int endIndex = Math.Max(x, y);

        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.WriteLine(i);
        }
    }
}