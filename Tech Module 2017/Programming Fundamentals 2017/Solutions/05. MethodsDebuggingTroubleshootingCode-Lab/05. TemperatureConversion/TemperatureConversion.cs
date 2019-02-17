using System;

class TemperatureConversion
{
    public static void Main()
    {
        double fahrenheit = double.Parse(Console.ReadLine());
        double celsius = FahrenheitToCelsius(fahrenheit);
        Console.WriteLine(celsius.ToString("F"));
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
