using System;
using System.Collections.Generic;
using System.Linq;

class CountNumbers
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
        numbers.Sort();

        var numbersToPrint = numbers.GroupBy(i => i);

        foreach (var num in numbersToPrint)
        {
            Console.WriteLine("{0} -> {1}", num.Key, num.Count());
        }
    }
}
