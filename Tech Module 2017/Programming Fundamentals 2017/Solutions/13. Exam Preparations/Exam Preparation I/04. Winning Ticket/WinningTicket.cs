using System;
using System.Linq;
using System.Text.RegularExpressions;

public class WinningTicket
{
    public static void Main()
    {
        var tickets = Console.ReadLine()
            .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        foreach (var ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
            }

            else
            {
                var length = ticket.Length;

                var leftPart = ticket.Substring(0, length / 2);
                var rightPart = ticket.Substring(length / 2);

                var pattern = @"\@{6,}|\#{6,}|\${6,}|\^{6,}"; //@"[\@\#\$\^]{6,}";

                var leftPartMatch = Regex.Match(leftPart, pattern);
                var rightPartMatch = Regex.Match(rightPart, pattern);

                if (leftPartMatch.Success && rightPartMatch.Success)
                {
                    var matchSymbol = leftPartMatch.ToString().First();
                    var matchLenght = Math.Min(leftPartMatch.Length, rightPartMatch.Length);

                    if (leftPartMatch.Length == 10 && rightPartMatch.Length == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {matchLenght}{matchSymbol} Jackpot!");
                    }

                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {matchLenght}{matchSymbol}");
                    }
                }

                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}