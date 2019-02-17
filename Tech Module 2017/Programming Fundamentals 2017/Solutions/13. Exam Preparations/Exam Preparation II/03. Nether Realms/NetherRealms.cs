using System;
using System.Linq;
using System.Text.RegularExpressions;

public class NetherRealms
{
    public static void Main()
    {
        var demons = Console.ReadLine()
            .Split(',')
            .Select(x => x.Trim())
            .OrderBy(d => d)
            .ToArray();

        foreach (var demon in demons)
        {
            var demonHealth = CalculateDemonHealth(demon);
            var demonDamage = CalculateDemonDamage(demon);

            Console.WriteLine($"{demon} - {demonHealth} health, {demonDamage:F2} damage");
        }
    }

    private static double CalculateDemonDamage(string demon)
    {
        var damagePattern = @"[+-]?\d*\.?\d+";

        var damage = Regex.Matches(demon, damagePattern)
            .Cast<Match>()
            .Select(n => double.Parse(n.ToString()))
            .Sum();

        foreach (var symbol in demon.Where(c => c == '*' || c == '/'))
        {
            var symbols = symbol.Equals('*')
                ? damage *= 2
                : damage /= 2;
        }

        return damage;
    }

    private static double CalculateDemonHealth(string demon)
    {
        var healthPattern = @"[^\d\+\-\*\/\.]";

        var health = Regex.Matches(demon, healthPattern)
            .Cast<Match>()
            .Select(x => x.Value.Sum(c => c))
            .Sum();

        return health;
    }
}