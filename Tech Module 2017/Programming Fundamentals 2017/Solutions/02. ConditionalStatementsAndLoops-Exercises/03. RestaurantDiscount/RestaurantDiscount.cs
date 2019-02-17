using System;

public class RestaurantDiscount
{
    static void Main()
    {
        int countOfPeople = int.Parse(Console.ReadLine());
        string hallName = "";
        string package = Console.ReadLine();
        int hallPrice = 0;
        double discountInPercent = 0;
        double totalPrice = 0;

        if (package == "Normal")
        {
            hallPrice = 500;
            discountInPercent = 0.95;
        }
        else if (package == "Gold")
        {
            hallPrice = 750;
            discountInPercent = 0.90;
        }
        else if (package == "Platinum")
        {
            hallPrice = 1000;
            discountInPercent = 0.85;
        }

        if (countOfPeople <= 50)
        {
            totalPrice = (2500 + hallPrice) * discountInPercent;
            hallName = "Small Hall";
        }
        else if (countOfPeople <= 100)
        {
            totalPrice = (5000 + hallPrice) * discountInPercent;
            hallName = "Terrace";
        }
        else if (countOfPeople <= 120)
        {
            totalPrice = (7500 + hallPrice) * discountInPercent;
            hallName = "Great Hall";
        }

        double pricePerPerson = totalPrice / countOfPeople;

        if (countOfPeople > 0 && countOfPeople <= 120)
        {
            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
        else
        {
            Console.WriteLine("We do not have an appropriate hall.");
        }
    }
}