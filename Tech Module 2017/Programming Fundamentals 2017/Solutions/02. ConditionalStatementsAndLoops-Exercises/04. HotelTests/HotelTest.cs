using System;

public class Hotel
{
    public static void Main()
    {
        string month = Console.ReadLine();
        int nightsCount = int.Parse(Console.ReadLine());

        if (month == "May")
        {
            if (nightsCount > 7)
            {
                Console.WriteLine("Studio: {0:f2} lv.", 50 * 0.95 * nightsCount);
            }
            else
            {
                Console.WriteLine("Studio: {0:f2} lv.", 50 * nightsCount);
            }
            Console.WriteLine("Double: {0:f2} lv.", 65 * nightsCount);
            Console.WriteLine("Suite: {0:f2} lv.", 75 * nightsCount);
        }
        else if (month == "June")
        {
            Console.WriteLine("Studio: {0:f2} lv.", 60 * nightsCount);
            if (nightsCount > 14)
            {
                Console.WriteLine("Double: {0:f2} lv.", 72 * 0.9 * nightsCount);
            }
            else
            {
                Console.WriteLine("Double: {0:f2} lv.", 72 * nightsCount);
            }
            Console.WriteLine("Suite: {0:f2} lv.", 82 * nightsCount);
        }
        else if (month == "July" || month == "August" || month == "December")
        {
            Console.WriteLine("Studio: {0:f2} lv.", 68 * nightsCount);
            Console.WriteLine("Double: {0:f2} lv.", 77 * nightsCount);
            if (nightsCount > 14)
            {
                Console.WriteLine("Suite: {0:f2} lv.", 89 * 0.85 * nightsCount);
            }
            else
            {
                Console.WriteLine("Suite: {0:f2} lv.", 89 * nightsCount);
            }
        }
        else if (month == "September")
        {
            if (nightsCount > 7)
            {
                Console.WriteLine("Studio: {0:f2} lv.", 60 * (nightsCount - 1));
            }
            else
            {
                Console.WriteLine("Studio: {0:f2} lv.", 60 * nightsCount);
            }
            if (nightsCount > 14)
            {
                Console.WriteLine("Double: {0:f2} lv.", 72 * 0.9 * nightsCount);
            }
            else
            {
                Console.WriteLine("Double: {0:f2} lv.", 72 * nightsCount);
            }
            Console.WriteLine("Suite: {0:f2} lv.", 82 * nightsCount);
        }
        else if (month == "October")
        {
            if (nightsCount > 7)
            {
                Console.WriteLine("Studio: {0:f2} lv.", 50 * 0.95 * (nightsCount - 1));
            }
            else
            {
                Console.WriteLine("Studio: {0:f2} lv.", 50 * nightsCount);
            }
            Console.WriteLine("Double: {0:f2} lv.", 65 * nightsCount);
            Console.WriteLine("Suite: {0:f2} lv.", 75 * nightsCount);
        }
    }
}