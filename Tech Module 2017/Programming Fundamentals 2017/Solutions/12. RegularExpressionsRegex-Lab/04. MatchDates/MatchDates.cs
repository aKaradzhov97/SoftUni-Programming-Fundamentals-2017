using System;
using System.Text.RegularExpressions;

public class MatchDates
{
    public static void Main()
    {
        string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
        // Backreference \1 is set to \1 not to \2 because C# backreferences don't count named
        // capture groups for backreferences!
        string input = Console.ReadLine();
        var dates = Regex.Matches(input, pattern);

        //Reading Input from named capture groups
        foreach (Match date in dates)
        {
            var day = date.Groups["day"].Value;
            var month = date.Groups["month"].Value;
            var year = date.Groups["year"].Value;
            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
}