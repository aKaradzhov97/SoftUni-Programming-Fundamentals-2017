using System;
using System.Collections.Generic;
using System.Linq;

class TextFilter
{
    static void Main()
    {
        List<string> badWords = Console.ReadLine()
            .Split(',', ' ')
            .Where(w => w.Length > 0)
            .ToList();

        string text = Console.ReadLine();

        foreach (var badWord in badWords)
        {
            string wordLength = new string('*', badWord.Length);
            text = text.Replace(badWord, wordLength);
        }
        Console.WriteLine(text);
    }
}
