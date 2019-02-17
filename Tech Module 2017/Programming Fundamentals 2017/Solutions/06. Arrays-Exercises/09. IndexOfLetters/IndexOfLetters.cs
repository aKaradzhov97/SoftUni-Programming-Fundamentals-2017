using System;

class IndexOfLetters
{
    public static void Main()
    {
        string word = Console.ReadLine();

        foreach (char letter in word)
        {
            Console.WriteLine($"{letter} -> {letter - 'a'}");
        }
    }
}