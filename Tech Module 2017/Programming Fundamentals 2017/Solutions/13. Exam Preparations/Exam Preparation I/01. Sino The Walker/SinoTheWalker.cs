using System;
using System.Globalization;

public class SinoTheWalker
{
    public static void Main()
    {
        var startTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

        var steps = double.Parse(Console.ReadLine()) % 86400;
        var timeInSeconds = double.Parse(Console.ReadLine()) % 86400;

        var totalSeconds = steps * timeInSeconds;

        var timeArrival = startTime
            .AddSeconds(totalSeconds)
            .TimeOfDay
            .ToString();

        Console.WriteLine($"Time Arrival: {timeArrival}");
    }
}