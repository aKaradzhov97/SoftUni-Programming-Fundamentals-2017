using System;

public class MagicLetter
{
    public static void Main()
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        string skipLetter = Console.ReadLine();

        for (char a = firstLetter; a <= secondLetter; a++)
        {
            for (char b = firstLetter; b <= secondLetter; b++)
            {
                for (char c = firstLetter; c <= secondLetter; c++)
                {
                    string result = $"{a}{b}{c} ";
                    if (!result.Contains(skipLetter))
                    {
                        Console.Write(result);
                    }
                }
            }
        }
    }
}