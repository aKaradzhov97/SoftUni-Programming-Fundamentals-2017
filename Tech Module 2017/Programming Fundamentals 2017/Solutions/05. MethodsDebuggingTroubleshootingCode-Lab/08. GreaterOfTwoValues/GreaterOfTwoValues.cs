using System;

class GreaterOfTwoValues
{
    static string TypeOfInput = Console.ReadLine();

    public static void Main()
    {

        if (TypeOfInput == "int")
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            var answer = GetMax(first, second);
            Console.WriteLine(answer);
        }
        else if (TypeOfInput == "char")
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            var answer = GetMax(first, second);
            Console.WriteLine(answer);
        }
        else if (TypeOfInput == "string")
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            var answer = GetMax(first, second);
            Console.WriteLine(answer);
        }
    }

    //If input is integer
    static int GetMax(int first, int second)
    {
        var result = 0;
        TypeOfInput = "int";
        if (first >= second)
        {
            result = first;
        }
        else
        {
            result = second;
        }
        return result;
    }
    //Now if input is type char
    static char GetMax(char first, char second)
    {
        TypeOfInput = "char";
        char result = (char)0;
        if (first >= second)
        {
            result = first;
        }
        else
        {
            result = second;
        }
        return result;
    }
    //Last check - if input is string
    static string GetMax(string first, string second)
    {
        TypeOfInput = "string";
        string result = "0";
        if (first.CompareTo(second) >= 0)
        {
            result = first;
        }
        else
        {
            result = second;
        }
        return result;
    }
}
