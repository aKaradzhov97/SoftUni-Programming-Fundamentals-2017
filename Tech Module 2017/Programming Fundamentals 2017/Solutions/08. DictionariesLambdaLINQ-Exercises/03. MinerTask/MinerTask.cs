using System;
using System.Collections.Generic;

public class MinerTask
{
    public static void Main()
    {
        string input = Console.ReadLine();
        var resources = new Dictionary<string, long>();
        int index = 1;
        string resourceType = "";
        long quantityOfTheResource = 0;
        bool keyCheck = false;
        bool valueCheck = false;
        while (input != "stop")
        {
            if (index % 2 == 1)
            {
                keyCheck = true;
                resourceType = input;
            }
            else if (index % 2 == 0)
            {
                valueCheck = true;
                quantityOfTheResource = long.Parse(input);
            }

            if (keyCheck && valueCheck)
            {
                if (!resources.ContainsKey(resourceType))
                {
                    resources.Add(resourceType, quantityOfTheResource);
                }
                else
                {
                    resources[resourceType] += quantityOfTheResource;
                }
                keyCheck = false;
                valueCheck = false;
            }
            index++;
            input = Console.ReadLine();
        }
        foreach (var res in resources)
        {
            Console.WriteLine($"{res.Key} -> {res.Value}");
        }
    }
}