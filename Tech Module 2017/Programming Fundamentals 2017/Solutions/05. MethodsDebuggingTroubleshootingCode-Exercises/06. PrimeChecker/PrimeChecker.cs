using System;

class PrimeCheker
{
    public static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(num));
    }

    public static bool IsPrime(long n)
    {
        bool isPrime = true;
        if (n == 0 || n == 1)
        {
            isPrime = false;
        }
        else if (n == 2)
        {
            isPrime = true;
        }
        else if (n % 2 == 0)
        {
            isPrime = false;
        }

        int checkIfNotPrime = (int)Math.Floor(Math.Sqrt(n));
        for (int i = 3; i <= checkIfNotPrime; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
            }
        }

        return isPrime;
    }
}