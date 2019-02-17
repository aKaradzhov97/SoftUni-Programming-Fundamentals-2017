using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers
{
    public static void Main()
    {
        double[] nums = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();
        var counts = new SortedDictionary<double, int>();

        foreach (var num in nums)
        {
            if (counts.ContainsKey(num))
            {
                counts[num]++;
            }
            else
            {
                counts[num] = 1;
            }

        }
        foreach (var num in counts.Keys)
        {
            Console.WriteLine($"{num} -> {counts[num]}");
        }
    }
}