using System;

class GeometryCalculator
{
    public static void Main()
    {
        string typeOfFigure = Console.ReadLine();

        if (typeOfFigure == "triangle")
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            PrintTriangleArea(a, h);
        }
        else if (typeOfFigure == "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            PrintRectangleArea(a, b);
        }
        else if (typeOfFigure == "square")
        {
            double a = double.Parse(Console.ReadLine());
            PrintSquareArea(a);
        }
        else if (typeOfFigure == "circle")
        {
            double r = double.Parse(Console.ReadLine());
            PrintCircleArea(r);
        }
    }

    public static double PrintTriangleArea(double a, double h)
    {
        double area = a * h / 2;
        Console.WriteLine(area.ToString("F"));
        return 0;
    }

    public static double PrintRectangleArea(double a, double b)
    {
        double area = a * b;
        Console.WriteLine(area.ToString("F"));
        return 0;
    }

    public static double PrintSquareArea(double a)
    {
        double area = a * a;
        Console.WriteLine(area.ToString("F"));
        return 0;
    }

    public static double PrintCircleArea(double r)
    {
        double area = Math.PI * r * r;
        Console.WriteLine(area.ToString("F"));
        return 0;
    }
}