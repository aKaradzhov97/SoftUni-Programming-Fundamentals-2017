using System;
using System.Linq;

class LargestThreeNumbers
{
    public static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        var printNumbers = nums.OrderByDescending(x => x).Take(3);
        Console.WriteLine(string.Join(" ", printNumbers));
    }
}