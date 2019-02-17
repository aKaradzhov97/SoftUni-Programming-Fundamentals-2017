using System;

class PrintingTriangle
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        //Printing first half
        for (int i = 1; i <= n; i++)
        {
            PrintNumbers(1, i);
        }
        //Printing second half:
        for (int i = n - 1; i >= 1; i--)
        {
            PrintNumbers(1, i);
        }
    }

    static void PrintNumbers(int start, int end)
    {
        //Printing each line
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
