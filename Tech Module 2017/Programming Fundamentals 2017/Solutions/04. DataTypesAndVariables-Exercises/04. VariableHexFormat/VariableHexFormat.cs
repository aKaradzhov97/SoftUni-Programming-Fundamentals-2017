using System;

class VariableHexFormat
{
    static void Main()
    {
        string input = Console.ReadLine();
        int decimalValue = Convert.ToInt32(input, 16);

        Console.WriteLine(decimalValue);
    }
}
