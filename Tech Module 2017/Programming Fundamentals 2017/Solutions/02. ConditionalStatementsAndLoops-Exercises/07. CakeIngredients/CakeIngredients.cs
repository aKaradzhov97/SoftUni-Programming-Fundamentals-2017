using System;

class CakeIngredients
{
    static void Main()
    {
        string ingredient = Console.ReadLine();
        int countOfIngredients = 0;

        while (ingredient != "Bake!")
        {
            Console.WriteLine($"Adding ingredient {ingredient}.");
            countOfIngredients++;
            ingredient = Console.ReadLine();
        }

        Console.WriteLine($"Preparing cake with {countOfIngredients} ingredients.");
    }
}