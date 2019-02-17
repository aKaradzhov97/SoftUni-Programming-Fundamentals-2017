using System;

class EnglishNameOLastDigit
{
    public static void Main()
    {
        EnglishNameOfLastDigitPrint();
    }

    static void EnglishNameOfLastDigitPrint()
    {
        decimal input = decimal.Parse(Console.ReadLine());
        input = Math.Abs(input);
        decimal lastDigit = input % 10;

        if (lastDigit == 0)
        {
            Console.WriteLine("zero");
        }
        else if (lastDigit == 1)
        {
            Console.WriteLine("one");
        }
        else if (lastDigit == 2)
        {
            Console.WriteLine("two");
        }
        else if (lastDigit == 3)
        {
            Console.WriteLine("three");
        }
        else if (lastDigit == 4)
        {
            Console.WriteLine("four");
        }
        else if (lastDigit == 5)
        {
            Console.WriteLine("five");
        }
        else if (lastDigit == 6)
        {
            Console.WriteLine("six");
        }
        else if (lastDigit == 7)
        {
            Console.WriteLine("seven");
        }
        else if (lastDigit == 8)
        {
            Console.WriteLine("eight");
        }
        else if (lastDigit == 9)
        {
            Console.WriteLine("nine");
        }
    }
}