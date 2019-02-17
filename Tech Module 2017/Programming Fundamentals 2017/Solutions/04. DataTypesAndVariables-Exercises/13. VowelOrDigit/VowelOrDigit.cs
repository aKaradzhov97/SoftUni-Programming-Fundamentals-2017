using System;

class VowelOrDigit
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input == "a" || input == "e" || input == "u" || input == "o" || input == "i")
        {
            Console.WriteLine("vowel");
        }
        else if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6" || input == "7" || input == "8" || input == "9" || input == "0")
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}
