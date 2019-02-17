using System;
using System.Linq;
using System.Collections.Generic;

class Palindromes
{
    static void Main()
    {
        List<string> input = Console.ReadLine()
            .Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
            .OrderBy(x => x)
            .ToList();
        List<string> output = new List<string>();
        foreach (var word in input)
        {
            if (IsPalindrome(word) && !output.Contains(word))
            {
                output.Add(word);
            }
        }
        Console.WriteLine(string.Join(", ", output));
    }
    private static bool IsPalindrome(string s)
    {
        string reversed = new String(s.Reverse().ToArray());
        return s == reversed;
    }
}
