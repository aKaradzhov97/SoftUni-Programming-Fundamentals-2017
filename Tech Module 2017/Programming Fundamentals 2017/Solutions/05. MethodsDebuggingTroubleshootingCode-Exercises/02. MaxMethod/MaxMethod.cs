using System;

class MaxMethod
{
    public static void Main()
    {
        GetMax();
    }

    static void GetMax()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int biggerNum = Math.Max(a, b);
        int maxNum = Math.Max(biggerNum, c);
        Console.WriteLine(maxNum);
    }
}