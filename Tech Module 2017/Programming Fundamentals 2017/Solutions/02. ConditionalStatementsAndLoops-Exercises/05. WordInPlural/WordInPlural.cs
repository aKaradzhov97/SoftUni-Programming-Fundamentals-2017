using System;

public class WordInPlural
{
    public static void Main()
    {
        string inputWord = Console.ReadLine();

        if (inputWord.EndsWith("y"))
        {
            inputWord = inputWord.Remove(inputWord.Length - 1);
            inputWord = inputWord.Insert(inputWord.Length, "ies");
        }
        else if (inputWord.EndsWith("o") || inputWord.EndsWith("ch") || inputWord.EndsWith("s") || inputWord.EndsWith("sh") || inputWord.EndsWith("x") || inputWord.EndsWith("z"))
        {
            inputWord = inputWord.Insert(inputWord.Length, "es");
        }
        else
        {
            inputWord = inputWord.Insert(inputWord.Length, "s");
        }
        Console.WriteLine(inputWord);
    }
}