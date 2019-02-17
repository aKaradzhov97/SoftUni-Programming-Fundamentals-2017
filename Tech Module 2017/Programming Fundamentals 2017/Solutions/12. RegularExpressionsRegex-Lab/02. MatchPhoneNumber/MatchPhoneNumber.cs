using System;
using System.Linq;
using System.Text.RegularExpressions;

class MatchPhoneNumber
{
    public static void Main()
    {
        string pattern = @"(\+359)(\-|\s)(2)\2[0-9]{3}\2[0-9]{4}";
        string input = Console.ReadLine();

        var phoneMathes = Regex.Matches(input, pattern);

        var matchedPhones = phoneMathes
            .Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();

        Console.WriteLine(string.Join(", ", matchedPhones));
    }
}