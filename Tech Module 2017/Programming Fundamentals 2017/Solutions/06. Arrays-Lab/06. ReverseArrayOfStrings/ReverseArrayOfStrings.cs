using System;
using System.Linq;

class ReverseArrayOfStrings
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] items = input.Split(' ');

        var reversed = items.Reverse();
        Console.WriteLine(String.Join(" ", reversed));
    }
}
