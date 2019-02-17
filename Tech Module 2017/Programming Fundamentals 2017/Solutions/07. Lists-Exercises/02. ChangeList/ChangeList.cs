using System;
using System.Collections.Generic;
using System.Linq;

class ChangeList
{
    static void Main()
    {
        List<int> num = Console.ReadLine().Split().Select(int.Parse).ToList();

        string line = Console.ReadLine();

        while (!(line == "Even" || line == "Odd"))
        {
            var tokens = line.Split();
            var command = tokens[0];
            if (command == "Delete")
            {
                var element = int.Parse(tokens[1]);
                num.Remove(element);
            }
            else if (command == "Insert")
            {
                var element = int.Parse(tokens[1]);
                var index = int.Parse(tokens[2]);
                num.Insert(index, element);
            }
            line = Console.ReadLine();
        }
        if (line == "Even")
        {
            foreach (var number in num)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }
        else if (line == "Odd")
        {
            foreach (var number in num)
            {
                if (number % 2 == 1)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }

    }
}