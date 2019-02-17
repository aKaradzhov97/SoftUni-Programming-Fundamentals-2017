using System;

public class CountTheIntegers
{
    public static void Main()
    {
        long counter = 0;

        try
        {
            while (true)
            {
                long integers = long.Parse(Console.ReadLine());
                counter++;
            }
        }
        catch (Exception)
        {
            Console.WriteLine(counter);
        }
    }
}