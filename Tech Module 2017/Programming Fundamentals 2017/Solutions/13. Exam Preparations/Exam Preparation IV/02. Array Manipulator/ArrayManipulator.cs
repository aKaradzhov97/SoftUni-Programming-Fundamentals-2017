using System;
using System.Linq;
using System.Text;

public class ArrayManipulator
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        var line = Console.ReadLine();

        while (!line.Equals("end"))
        {
            var command = line
                .Split();

            switch (command[0])
            {
                case "exchange":
                    var index = int.Parse(command[1]);
                    numbers = ExchangeElements(numbers, index);
                    break;

                case "max":
                case "min":
                    var maxOrMin = command[0];
                    var evenOrOdd = command[1];
                    Console.WriteLine(MaxOrMinEvenOrOddElement(numbers, maxOrMin, evenOrOdd));
                    break;

                case "first":
                case "last":
                    var firstOrLast = command[0];
                    var count = int.Parse(command[1]);
                    evenOrOdd = command[2];
                    Console.WriteLine(FirstOrLastEvenOrOddElements(numbers, firstOrLast, count, evenOrOdd));
                    break;
            }

            line = Console.ReadLine();
        }

        Console.WriteLine($"[{string.Join(", ", numbers)}]");
    }

    private static string FirstOrLastEvenOrOddElements(int[] numbers, string firstOrLast, int count, string evenOrOdd)
    {
        if (count > numbers.Length)
        {
            return "Invalid count";
        }

        var filteredNumbers = evenOrOdd.Equals("even")
            ? numbers.Where(x => x % 2 == 0).ToArray()
            : numbers.Where(x => x % 2 == 1).ToArray();

        return firstOrLast == "first"
            ? $"[{string.Join(", ", filteredNumbers.Take(count))}]"
            : $"[{string.Join(", ", filteredNumbers.Reverse().Take(count).Reverse())}]";
    }

    private static string MaxOrMinEvenOrOddElement(int[] numbers, string maxOrMin, string evenOrOdd)
    {
        var filteredNumbers = evenOrOdd.Equals("even")
            ? numbers.Where(x => x % 2 == 0).ToArray()
            : numbers.Where(x => x % 2 == 1).ToArray();

        if (!filteredNumbers.Any())
        {
            return "No matches";
        }

        return maxOrMin == "min"
            ? Array.LastIndexOf(numbers, filteredNumbers.Min()).ToString()
            : Array.LastIndexOf(numbers, filteredNumbers.Max()).ToString();
    }

    private static int[] ExchangeElements(int[] numbers, int index)
    {
        if (index < 0 || index > numbers.Length)
        {
            Console.WriteLine("Invalid index");
        }

        return numbers
            .Skip(index + 1)
            .Concat(numbers.Take(index + 1))
            .ToArray();
    }
}