using System;

class StringsAndObjects
{
    static void Main()
    {
        string input = Console.ReadLine();
        string input2 = Console.ReadLine();
        object obj = input + " " + input2;
        Console.WriteLine(obj);
    }
}
