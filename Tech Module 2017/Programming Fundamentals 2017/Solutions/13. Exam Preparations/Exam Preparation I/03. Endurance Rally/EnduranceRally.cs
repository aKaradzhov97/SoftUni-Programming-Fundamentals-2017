using System;
using System.Linq;

public class EnduranceRally
{
    public static void Main()
    {
        var driversNames = Console.ReadLine()
            .Split()
            .ToArray();

        var zones = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        var checkpointIndexes = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        foreach (var driver in driversNames)
        {
            double fuel = driver.First();

            for (int i = 0; i < zones.Length; i++)
            {
                var currentIndex = i;
                var currentZone = zones[i];

                var isCheckPoint = checkpointIndexes.Contains(currentIndex)
                    ? fuel += currentZone
                    : fuel -= currentZone;

                if (fuel <= 0)
                {
                    Console.WriteLine($"{driver} - reached {currentIndex}");
                    break;
                }
            }

            if (fuel > 0)
            {
                Console.WriteLine($"{driver} - fuel left {fuel:F2}");
            }
        }
    }
}