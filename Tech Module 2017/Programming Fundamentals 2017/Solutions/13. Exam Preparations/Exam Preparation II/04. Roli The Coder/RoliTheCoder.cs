﻿using System;
using System.Collections.Generic;
using System.Linq;

public class RoliTheCoder
{
    public static void Main()
    {
        var events = new List<Event>();

        var line = Console.ReadLine();

        while (!line.Equals("Time for Code"))
        {
            var eventsData = line
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            var ID = eventsData[0];
            var eventName = eventsData[1].TrimStart('#');
            var participants = new List<string>();

            participants.AddRange(eventsData.Skip(2));

            if (eventsData[1].Contains('#'))
            {
                if (!events.Any(x => x.Id == ID))
                {
                    var currentEvent = new Event
                    {
                        Name = eventName,
                        Id = ID,
                        Participants = new List<string>()
                    };
                    
                    events.Add(currentEvent);
                }

                if (events.Any(x => x.Id == ID && x.Name == eventName))
                {
                    foreach (var participant in participants)
                    {
                        if (!events.First(a => a.Id == ID && a.Name == eventName)
                            .Participants.Contains(participant))
                        {
                            events.First(a => a.Id == ID && a.Name == eventName)
                                .Participants
                                .Add(participant);
                        }
                    }
                }
            }

            line = Console.ReadLine();
        }

        events = events
            .OrderByDescending(x => x.Participants.Count())
            .ThenBy(x => x.Name)
            .ToList();

        foreach (var @event in events)
        {
            Console.WriteLine($"{@event.Name} - {@event.Participants.Count()}");

            foreach (var participant in @event.Participants.OrderBy(x => x))
            {
                Console.WriteLine($"{participant}");
            }
        }
    }
}

public class Event
{
    public string Name { get; set; }

    public string Id { get; set; }

    public List<string> Participants { get; set; }
}