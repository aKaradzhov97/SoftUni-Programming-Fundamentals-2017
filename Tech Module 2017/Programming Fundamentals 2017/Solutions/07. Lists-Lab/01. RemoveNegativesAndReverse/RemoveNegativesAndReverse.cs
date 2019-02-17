using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNegativesAndReverse
{
    public static void Main()
    {
        List<int> input = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        List<int> numbers = new List<int>();

        foreach (int num in input)
        {
            if (num >= 0)
            {
                numbers.Add(num);
            }
        }

        if (numbers.Count() > 0)
        {
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}