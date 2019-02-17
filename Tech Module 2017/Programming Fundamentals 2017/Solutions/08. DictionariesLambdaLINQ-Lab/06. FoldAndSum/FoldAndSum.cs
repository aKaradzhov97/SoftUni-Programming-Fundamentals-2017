using System;
using System.Linq;

class FoldAndSum
{
    public static void Main()
    {
        int[] array = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int k = array.Length / 4;

        int[] leftRow = array.Take(k).Reverse().ToArray();
        int[] rightRow = array.Reverse().Take(k).ToArray();

        int[] firstRow = leftRow.Concat(rightRow).ToArray();
        int[] secondRow = array.Skip(k).Take(k * 2).ToArray();

        //How to sum two arrays like:
        // 1 2 3 4 
        //+
        // 1 2 3 4
        //=========
        // 2 4 6 8
        var sumArray = firstRow.Select((x, index) => x + secondRow[index]);
        Console.WriteLine(string.Join(" ", sumArray));
    }
}