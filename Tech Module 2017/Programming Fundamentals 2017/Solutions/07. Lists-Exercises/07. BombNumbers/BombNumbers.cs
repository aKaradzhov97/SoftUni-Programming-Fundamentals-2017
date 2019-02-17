using System;
using System.Collections.Generic;
using System.Linq;

class BombNumbers
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        int[] secondLineOfInput = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        var bombNumber = secondLineOfInput[0];
        var powerOfBomb = secondLineOfInput[1];

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bombNumber)
            {
                int leftIndex = Math.Max(i - powerOfBomb, 0);
                int rightIndex = Math.Min(i + powerOfBomb, numbers.Count - 1);

                numbers.RemoveRange(i, rightIndex - i);
                numbers.RemoveAt(i);
                numbers.RemoveRange(leftIndex, i - leftIndex);
                i = 0;
            }

        }
        Console.WriteLine(string.Join("", numbers.Sum()));
    }
}