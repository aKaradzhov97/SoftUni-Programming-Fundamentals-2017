using System;

public class CharityMarathon
{
    public static void Main()
    {
        var marathonDays = decimal.Parse(Console.ReadLine());
        var runnersCount = decimal.Parse(Console.ReadLine());
        var lapsAverageNumber = decimal.Parse(Console.ReadLine());
        var trackLenght = decimal.Parse(Console.ReadLine());
        var trackCapacity = decimal.Parse(Console.ReadLine());
        var moneyRaisedByKm = decimal.Parse(Console.ReadLine());

        var maximumRunners = marathonDays * trackCapacity;

        var runners = Math.Min(runnersCount, maximumRunners);

        var totalMeters = runners * lapsAverageNumber * trackLenght;
        var totalKilometers = totalMeters / 1000;

        var moneyRaised = totalKilometers * moneyRaisedByKm;

        Console.WriteLine($"Money raised: {moneyRaised:F2}");
    }
}