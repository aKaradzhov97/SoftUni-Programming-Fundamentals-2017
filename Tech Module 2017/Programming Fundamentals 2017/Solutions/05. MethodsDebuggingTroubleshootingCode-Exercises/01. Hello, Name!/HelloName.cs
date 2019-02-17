using System;

class HelloName
{
    public static void Main()
    {
        string name = Console.ReadLine();
        PrintName(name);
    }

    static void PrintName(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
}