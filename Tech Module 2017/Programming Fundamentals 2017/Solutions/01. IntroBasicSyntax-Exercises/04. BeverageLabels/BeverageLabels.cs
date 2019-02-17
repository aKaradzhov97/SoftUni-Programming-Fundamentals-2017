using System;

class BevarageLabels
{
    static void Main()
    {
        var name = Console.ReadLine();
        double volume = double.Parse(Console.ReadLine());
        double energyPer100Ml = double.Parse(Console.ReadLine());
        double sugarPer100Ml = double.Parse(Console.ReadLine());

        double result = volume / 100;
        Console.WriteLine(volume + "ml " + name + ":");
        Console.WriteLine((result * energyPer100Ml) + "kcal, " + (result * sugarPer100Ml) + "g sugars");
    }
}