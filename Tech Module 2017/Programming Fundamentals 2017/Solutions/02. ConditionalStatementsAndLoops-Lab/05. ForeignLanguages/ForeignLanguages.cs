﻿using System;

class ForeignLanguages
{
    static void Main()
    {
        string country = Console.ReadLine();

        if (country == "USA" || country == "England")
        {
            Console.WriteLine("English");
        }
        else if (country == "Spain" || country == "Mexico" || country == "Argentina")
        {
            Console.WriteLine("Spanish");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
