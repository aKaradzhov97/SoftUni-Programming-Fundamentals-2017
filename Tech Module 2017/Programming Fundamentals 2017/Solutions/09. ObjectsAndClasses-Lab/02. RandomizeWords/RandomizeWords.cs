using System;
using System.Linq;

class RandomizeWords
{
    public static void Main()
    {
        string[] text = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        Random rnd = new Random();

        for (int i = 0; i < text.Length; i++)
        {
            int index = rnd.Next(0, text.Length);
            string rem = text[index];
            int newIndex = rnd.Next(0, text.Length);
            text[index] = text[newIndex];
            text[newIndex] = rem;
        }

        for (int i = 0; i < text.Length; i++)
        {
            Console.WriteLine(text[i]);
        }
    }
}