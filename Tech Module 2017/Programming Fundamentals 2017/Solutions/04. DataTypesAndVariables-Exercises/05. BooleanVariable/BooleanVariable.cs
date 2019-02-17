using System;

class BooleanVariable
{
    static void Main()
    {
        bool input = bool.Parse(Console.ReadLine());

        if (input)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
