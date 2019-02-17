using System;

class CountSubstringOccurrences
{
    static void Main()
    {
        string text = Console.ReadLine();
        string pattern = Console.ReadLine();

        Console.WriteLine(GetOccurencesCount(text, pattern));
    }

    public static int GetOccurencesCount(string input, string pattern)
    {
        input = input.ToLower();
        pattern = pattern.ToLower();

        int count = 0;
        int index = -1;
        while (true)
        {
            index = input.IndexOf(pattern, index + 1);
            if (index == -1)
            {
                break;
            }
            else
            {
                count++;
            }
        }
        return count;
    }
}