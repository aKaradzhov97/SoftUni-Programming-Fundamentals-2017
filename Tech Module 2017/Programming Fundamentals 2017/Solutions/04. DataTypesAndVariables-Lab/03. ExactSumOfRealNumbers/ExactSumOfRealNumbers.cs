using System;

class ExactSumOfRealNumbers
{
    static void Main()
    {
        int totalNumbers = int.Parse(Console.ReadLine());
        decimal a = 0m;
        decimal sum = 0m;
        for (int i = 1; i <= totalNumbers; i++)
        {
            a = decimal.Parse(Console.ReadLine());
            sum += a;
        }
        Console.WriteLine(sum);
    }
}
