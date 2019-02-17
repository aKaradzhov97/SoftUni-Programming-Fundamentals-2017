using System;
using System.Linq;

class ShortWordsSorted
{
    public static void Main()
    {
        string[] words = Console.ReadLine()
            .Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].ToLower();
        }
        var printWords = words.Where(x => x.Length < 5).OrderBy(x => x).Distinct();

        Console.WriteLine(string.Join(", ", printWords));
    }
}