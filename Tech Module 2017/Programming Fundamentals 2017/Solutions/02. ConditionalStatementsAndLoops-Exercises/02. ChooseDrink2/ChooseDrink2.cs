using System;

public class ChooseDrink2
{
    static void Main()
    {
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        double price = 0;

        if (profession == "Athlete")
        {
            price = quantity * 0.70;
            Console.WriteLine($"The {profession} has to pay {price:F2}.");
        }
        else if (profession == "Businessman" || profession == "Businesswoman")
        {
            price = quantity * 1.00;
            Console.WriteLine($"The {profession} has to pay {price:F2}.");
        }
        else if (profession == "SoftUni Student")
        {
            price = quantity * 1.70;
            Console.WriteLine($"The {profession} has to pay {price:F2}.");
        }
        else
        {
            price = quantity * 1.20;
            Console.WriteLine($"The {profession} has to pay {price:F2}.");
        }
    }
}