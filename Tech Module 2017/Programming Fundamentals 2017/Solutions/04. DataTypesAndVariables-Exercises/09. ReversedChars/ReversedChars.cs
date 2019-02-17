using System;

class ReversedChars
{
    static void Main()
    {
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());
        char third = char.Parse(Console.ReadLine());

        Console.WriteLine(third.ToString() + second.ToString() + first.ToString());
    }
}