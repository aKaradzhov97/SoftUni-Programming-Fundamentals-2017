using System;
using System.Linq;
using System.Text.RegularExpressions;

class MatchHexadecimalNumbers
{
    public static void Main()
    {
        string pattern = @"\b(?:0x)?[0-9A-F]+\b";
        string input = Console.ReadLine();

        //Cast RegexMatch to Array
        var output = Regex.Matches(input, pattern).Cast<Match>().Select(a => a.Value).ToArray();

        Console.WriteLine(string.Join(" ", output));
    }
}