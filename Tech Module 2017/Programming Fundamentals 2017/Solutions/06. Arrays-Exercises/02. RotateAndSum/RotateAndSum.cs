using System;
using System.Linq;

class RotateAndSum
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int rotations = int.Parse(Console.ReadLine());

        int[] sum = new int[numbers.Length];

        for (int j = 0; j < rotations; j++)
        {
            //Rotating last element in array to go first!
            int reminder = numbers[numbers.Length - 1];
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                numbers[i] = numbers[i - 1];
                //Sum is not always needed
                sum[i] += numbers[i];
            }
            numbers[0] = reminder;
            //End of taking last digit
            sum[0] += numbers[0];
        }
        Console.WriteLine($"{string.Join(" ", sum)}");

    }
}