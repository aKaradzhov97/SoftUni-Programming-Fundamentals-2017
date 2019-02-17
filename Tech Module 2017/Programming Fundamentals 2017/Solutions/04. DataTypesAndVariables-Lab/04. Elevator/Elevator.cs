using System;

class Elevator
{
    static void Main()
    {
        int totalPeople = int.Parse(Console.ReadLine());
        int elevatorCapacity = int.Parse(Console.ReadLine());

        int courses = (int)Math.Ceiling((double)totalPeople / elevatorCapacity);
        Console.WriteLine(courses);
    }
}