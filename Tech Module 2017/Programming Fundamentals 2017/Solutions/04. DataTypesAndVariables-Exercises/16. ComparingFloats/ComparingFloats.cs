using System;

class ComparingFloats
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());

        decimal precisionChecker = 0.000001M;
        decimal numberAandNumberBDifference = Math.Abs(a - b);

        if (precisionChecker > numberAandNumberBDifference)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
