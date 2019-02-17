using System;

class FibonacciNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine(Fibonacci(n));
    }

    public static int Fibonacci(int inputNumber)
    {
        int firstNum = 1;
        int secondNum = 1;
        int fibonacciNum = 0;

        if (inputNumber == 0 || inputNumber == 1)
        {
            fibonacciNum = 1;
        }
        else
        {
            for (int i = 1; i < inputNumber; i++)
            {
                fibonacciNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = fibonacciNum;
            }
        }

        return fibonacciNum;
    }
}