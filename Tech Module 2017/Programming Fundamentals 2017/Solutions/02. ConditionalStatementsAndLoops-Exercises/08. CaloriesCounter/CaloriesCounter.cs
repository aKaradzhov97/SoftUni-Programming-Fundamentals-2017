using System;

public class CaloriesCounter
{
    public static void Main()
    {
        int numberOfIngredients = int.Parse(Console.ReadLine());
        string currentIngredient = Console.ReadLine().ToLower();
        int calories = 0;

        for (int i = 1; i <= numberOfIngredients; i++)
        {
            if (currentIngredient == "cheese")
            {
                calories = calories + 500;
            }
            else if (currentIngredient == "tomato sauce")
            {
                calories = calories + 150;
            }
            else if (currentIngredient == "salami")
            {
                calories = calories + 600;
            }
            else if (currentIngredient == "pepper")
            {
                calories = calories + 50;
            }
            if (i < numberOfIngredients)
            {
                currentIngredient = Console.ReadLine().ToLower();
            }
        }
        Console.WriteLine($"Total calories: {calories}");
    }
}