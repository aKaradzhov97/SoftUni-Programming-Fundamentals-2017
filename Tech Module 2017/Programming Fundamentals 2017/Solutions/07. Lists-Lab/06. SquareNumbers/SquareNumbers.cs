using System;
using System.Collections.Generic;
using System.Linq;

class SquareNumbers
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
        List<int> numbersToPrint = new List<int>();
        foreach (var num in numbers)
        {
            if (Math.Sqrt(num) % 1 == 0)
            {
                numbersToPrint.Add(num);
            }
        }
        numbersToPrint.Sort();
        numbersToPrint.Reverse();
        Console.WriteLine(string.Join(" ", numbersToPrint));
    }
}
