using System;

class Passed
{
    static void Main()
    {
        var grade = double.Parse(Console.ReadLine());
        if (grade >= 3)
        {
            Console.WriteLine("Passed!");
        }
    }
}
