using System;

class NumberReversedOrder
{
    public static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine(ReverseNumbers(number));
    }

    public static string ReverseNumbers(string number)
    {
        string result = "";

        for (int i = number.Length - 1; i >= 0; i--)
        {
            result += number[i];
        }

        return result;
    }
}