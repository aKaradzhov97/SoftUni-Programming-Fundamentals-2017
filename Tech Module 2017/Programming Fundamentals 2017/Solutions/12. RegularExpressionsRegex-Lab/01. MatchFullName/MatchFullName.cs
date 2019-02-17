using System;
using System.Text.RegularExpressions;

class MatchFullName
{
    public static void Main()
    {
        string pattern = @"\b[A-Z][a-z]+[' '][A-Z][a-z]+\b";
        string input = Console.ReadLine();

        MatchCollection matchedNames = Regex.Matches(input, pattern);

        foreach (Match m in matchedNames)
        {
            Console.Write(m.Value + " ");
        }
        Console.WriteLine();
    }
}
