using System;

class IntegerToHexAndBinary
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string toHex = Convert.ToString(n, 16).ToUpper();
        string toBinary = Convert.ToString(n, 2).ToUpper();
        Console.WriteLine(toHex);
        Console.WriteLine(toBinary);
    }
}