using System;
using System.Collections.Generic;
using System.Linq;

public class SoftUniKaraoke
{
    public static void Main()
    {
        var participants = Console.ReadLine()
            .Split(',')
            .Select(x => x.Trim())
            .ToArray();

        var songs = Console.ReadLine()
            .Split(',')
            .Select(x => x.Trim())
            .ToArray();

        var awards = new Dictionary<string, SortedSet<string>>();

        var line = Console.ReadLine();

        while (!line.Equals("dawn"))
        {
            var stagePerformanceData = line
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();

            var participant = stagePerformanceData[0];
            var song = stagePerformanceData[1];
            var award = stagePerformanceData[2];

            if (participants.Contains(participant) && songs.Contains(song))
            {
                if (!awards.ContainsKey(participant))
                {
                    awards[participant] = new SortedSet<string>();
                }

                awards[participant].Add(award);
            }

            line = Console.ReadLine();
        }

        if (awards.Count != 0)
        {
            awards = awards
                .OrderByDescending(x => x.Value.Count())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var participant in awards)
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count()} awards");

                foreach (var award in participant.Value)
                {
                    Console.WriteLine($"--{award}");
                }
            }           
        }

        else
        {
            Console.WriteLine("No awards");
        }
    }
}