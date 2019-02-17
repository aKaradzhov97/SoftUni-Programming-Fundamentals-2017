using System;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        if (firstArray.Length == secondArray.Length)
        {
            if (firstArray[0] > secondArray[0])
            {
                Console.WriteLine(secondArray);
                Console.WriteLine(firstArray);
            }
            else
            {
                Console.WriteLine(firstArray);
                Console.WriteLine(secondArray);
            }
        }
        else if (firstArray.Length > secondArray.Length)
        {
            Console.WriteLine(secondArray);
            Console.WriteLine(firstArray);
        }
        else
        {
            Console.WriteLine(firstArray);
            Console.WriteLine(secondArray);
        }
    }
}
