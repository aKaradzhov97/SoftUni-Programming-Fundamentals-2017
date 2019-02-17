using System;

public class FiveDifferentNumbers
{
    public static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int a = start; a <= end; a++)
        {
            for (int b = start; b <= end; b++)
            {
                for (int c = start; c <= end; c++)
                {
                    for (int d = start; d <= end; d++)
                    {
                        for (int e = start; e <= end; e++)
                        {
                            if (start <= a && a < b && b < c && c < d && d < e && e <= end)
                            {
                                Console.WriteLine($"{a} {b} {c} {d} {e}");
                                counter++;
                            }
                        }
                    }
                }
            }
        }
        //Now checking if startNum & endNum are too close to eachother;
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
}