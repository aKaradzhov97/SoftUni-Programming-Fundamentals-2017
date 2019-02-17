using System;

public class OddNumber
{
    public static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int n = Math.Abs(input);

        while (n % 2 == 0)
        {
            Console.WriteLine("Please write an odd number.");
            input = int.Parse(Console.ReadLine());
            n = Math.Abs(input);
        }
        Console.WriteLine("The number is: " + n);
    }
}