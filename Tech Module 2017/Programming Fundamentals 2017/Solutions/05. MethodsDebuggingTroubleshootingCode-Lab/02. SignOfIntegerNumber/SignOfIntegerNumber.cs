using System;

    class SignOfIntegerNumber
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            PrintSign(num);
        }

        static void PrintSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
