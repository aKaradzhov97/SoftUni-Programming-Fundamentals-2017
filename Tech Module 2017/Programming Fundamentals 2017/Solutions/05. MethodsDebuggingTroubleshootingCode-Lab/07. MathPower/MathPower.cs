using System;

class MathPower
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        double area = RaiseToPower(number, power);
        Console.WriteLine(area);
    }

    static double RaiseToPower(double number, int power)
    {
        double result = number;
        for (int i = 1; i < power; i++)
        {
            result *= number;
        }
        return result;
    }
}
