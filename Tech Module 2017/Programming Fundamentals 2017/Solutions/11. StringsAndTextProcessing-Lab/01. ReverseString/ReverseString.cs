using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string str = Console.ReadLine();
        
        Console.WriteLine(ReverseStringMethod(str));
    }

    public static string ReverseStringMethod(string input)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }
        return sb.ToString();
    }
}
