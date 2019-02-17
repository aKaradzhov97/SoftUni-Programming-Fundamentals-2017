using System;

class DebitCardNumber
{
    static void Main()
    {
        int firstDigits = int.Parse(Console.ReadLine());
        int secondDigits = int.Parse(Console.ReadLine());
        int thirdDigits = int.Parse(Console.ReadLine());
        int forthDigits = int.Parse(Console.ReadLine());

        Console.WriteLine(firstDigits.ToString("D4") + " "
            + secondDigits.ToString("D4") + " "
            + thirdDigits.ToString("D4") + " "
            + forthDigits.ToString("D4"));
    }
}