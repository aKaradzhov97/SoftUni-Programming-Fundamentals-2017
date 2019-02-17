using System;
using System.Collections.Generic;

class SplitByWordCasing
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[]
        { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' },
        StringSplitOptions.RemoveEmptyEntries);

        List<string> upperCaseWords = new List<string>();
        List<string> lowerCaseWords = new List<string>();
        List<string> mixCaseWords = new List<string>();

        foreach (var word in words)
        {
            int countLower = 0;
            int countUpper = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]))
                {
                    countUpper++;
                }
                else if (char.IsLower(word[i]))
                {
                    countLower++;
                }
            }

            if (countUpper == word.Length)
            {
                upperCaseWords.Add(word);
            }
            else if (countLower == word.Length)
            {
                lowerCaseWords.Add(word);
            }
            else
            {
                mixCaseWords.Add(word);
            }
        }
        Console.WriteLine("Lower-case: {0}", String.Join(", ", lowerCaseWords));
        Console.WriteLine("Mixed-case: {0}", String.Join(", ", mixCaseWords));
        Console.WriteLine("Upper-case: {0}", String.Join(", ", upperCaseWords));
    }
}