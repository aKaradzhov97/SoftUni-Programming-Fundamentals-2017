using System;

class CircleArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine($"{radius * radius * Math.PI:F12}");
    }
}