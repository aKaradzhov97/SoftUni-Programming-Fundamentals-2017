using System;
using System.Collections.Generic;

class OddOccurrences
{
    public static void Main()
    {
        string input = Console.ReadLine();
        var words = input.ToLower().Split(' ');

        var count = new Dictionary<string, int>();
        foreach (var word in words)
        {
            count[word] = 0;
        }
        foreach (var word in words)
        {
            count[word]++;
        }

        List<string> result = new List<string>();

        foreach (var item in count)
        {
            if (item.Value % 2 != 0)
            {
                result.Add(item.Key);
            }
        }
        Console.WriteLine(string.Join(", ", result));
    }
}