using System;
using System.Text.RegularExpressions;

public class ExtractEmails
{
    public static void Main()
    {
        string pattern = @"([\w.-]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";
        string input = Console.ReadLine();

        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);

        foreach (Match emailMatch in matches)
        {
            string email = emailMatch.ToString();
            if (!(email.StartsWith(".") || email.StartsWith("-") || email.StartsWith("_") ||
                email.EndsWith(".") || email.EndsWith("-") || email.EndsWith("_")))
            {
                Console.WriteLine(emailMatch);
            }
        }
    }
}