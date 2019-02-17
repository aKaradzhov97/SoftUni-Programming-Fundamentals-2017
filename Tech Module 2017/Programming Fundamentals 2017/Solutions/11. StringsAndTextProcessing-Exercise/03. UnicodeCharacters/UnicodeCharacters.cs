using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine(GetUnicodeString(Console.ReadLine()));
    }

    public static string GetUnicodeString(string s)
    {
        //String to UNICODE characters method
        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
        {
            sb.Append("\\u");
            sb.Append(String.Format("{0:x4}", (int)c));
        }
        return sb.ToString();
    }

}