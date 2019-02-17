using System;
using System.Collections.Generic;
using System.Linq;

class SumReversedNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        List<int> reversedNumbers = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            string eachElement = numbers[i];
            char[] elements = eachElement.ToCharArray();
            char[] reversed = elements.Reverse().ToArray();
            reversedNumbers.Add(int.Parse(string.Join("", reversed)));
        }

        Console.WriteLine(reversedNumbers.Sum());
    }
}