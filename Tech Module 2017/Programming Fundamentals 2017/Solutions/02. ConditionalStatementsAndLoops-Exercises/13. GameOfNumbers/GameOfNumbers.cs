using System;

public class GameOfNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());
        int checkForMagicNum = 0;
        int counter = 0;
        int firstNum = 0;
        int secondNum = 0;

        for (int i = n; i <= m; i++)
        {
            for (int j = n; j <= m; j++)
            {
                if (i + j == magicNumber)
                {
                    checkForMagicNum = i + j;
                    firstNum = i;
                    secondNum = j;
                }
                counter++;
            }
        }
        if (checkForMagicNum != 0)
        {
            Console.WriteLine($"Number found! {firstNum} + {secondNum} = {checkForMagicNum}");
        }
        else
        {
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}