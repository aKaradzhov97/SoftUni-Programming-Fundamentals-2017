using System;

class RefactorSpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int sum = 0;
            int digits = i;
            while (digits > 0)
            {
                sum += digits % 10;
                digits = digits / 10;
            }
            bool specialNums = false;
            specialNums = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{i} -> {specialNums} ");
        }
    }
}
