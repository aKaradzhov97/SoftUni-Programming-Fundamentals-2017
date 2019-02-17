using System;

class DrawFilledSquare
{
    static int n = int.Parse(Console.ReadLine());

    public static void Main()
    {
        //Header
        PrintHeaderAndFooter(n);
        //Body
        for (int i = 1; i <= n - 2; i++)
        {
            MiddleRows(n);
        }
        //Footer
        PrintHeaderAndFooter(n);

    }

    static void PrintHeaderAndFooter(int n)
    {
        for (int i = 1; i <= n * 2; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }

    static void MiddleRows(int n)
    {
        Console.Write("-");
        for (int i = 1; i < n; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine("-");
    }
}
