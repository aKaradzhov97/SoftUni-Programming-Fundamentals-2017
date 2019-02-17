using System;
using System.Linq;

class TripleSum
{
    static void Main()
    {
        var arr = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
        int switcher = 0;

        for (int a = 0; a <= arr.Length - 1; a++)
        {
            for (int b = a + 1; b <= arr.Length - 1; b++)
            {
                int sum = arr[a] + arr[b];
                if (arr.Contains(sum))
                {
                    Console.WriteLine("{0} + {1} == {2}", arr[a], arr[b], sum);
                    switcher = 1;
                }
            }
        }
        if (switcher == 0)
        {
            Console.WriteLine("No");
        }
    }
}
