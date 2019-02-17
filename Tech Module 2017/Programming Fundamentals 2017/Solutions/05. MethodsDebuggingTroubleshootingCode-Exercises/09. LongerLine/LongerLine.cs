using System;

class LongerLine
{
    public static void Main()
    {
        double x1 = 0.0;
        double y1 = 0.0;
        double x2 = 0.0;
        double y2 = 0.0;

        double maxLineLenght = double.MinValue;
        double maXx1 = 0.0;
        double maXy1 = 0.0;
        double maXx2 = 0.0;
        double maXy2 = 0.0;

        for (int i = 0; i < 2; i++)
        {
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());

            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            double line = FindLine(x1, x2, y1, y2);
            if (line > maxLineLenght)
            {
                maxLineLenght = line;
                maXx1 = x1;
                maXx2 = x2;
                maXy1 = y1;
                maXy2 = y2;
            }
        }
        PrintResult(maXx1, maXx2, maXy1, maXy2);
    }
    static void PrintResult(double x1, double x2, double y1, double y2)
    {
        double distanceOne = Math.Sqrt(x1 * x1 + y1 * y1);
        double distanceTwo = Math.Sqrt(x2 * x2 + y2 * y2);

        if (distanceTwo < distanceOne)
        {
            Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        }
        else
        {
            Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        }
    }
    static double FindLine(double x1, double x2, double y1, double y2)
    {
        return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    }
}