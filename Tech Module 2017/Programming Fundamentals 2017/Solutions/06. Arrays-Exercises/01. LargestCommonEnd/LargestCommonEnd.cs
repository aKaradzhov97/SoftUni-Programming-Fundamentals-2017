using System;
using System.Linq;

class LargestCommonEnd
{
    public static void Main()
    {
        string[] firstArr = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] secondArr = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Array reversing
        int leftCount = FindMaxCommonItems(firstArr, secondArr);
        Array.Reverse(firstArr);
        secondArr = secondArr.Reverse().ToArray();
        int rightCount = FindMaxCommonItems(firstArr, secondArr);

        Console.WriteLine($"{Math.Max(leftCount, rightCount)}");
    }

    public static int FindMaxCommonItems(string[] firstArr, string[] secondArr)
    {
        int lenght = Math.Min(firstArr.Length, secondArr.Length);
        int counter = 0;

        for (int i = 0; i < lenght; i++)
        {
            if (firstArr[i] == secondArr[i])
            {
                counter++;
            }
            else
            {
                break;
            }
        }

        return counter;
    }
}
