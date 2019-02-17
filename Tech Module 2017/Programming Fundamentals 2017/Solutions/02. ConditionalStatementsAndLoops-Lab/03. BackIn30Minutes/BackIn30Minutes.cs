using System;

class BackIn30Minutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine()) + 30;

        if (minutes >= 60)
        {
            hours++;
            minutes = minutes - 60;
        }
        if (hours >= 24)
        {
            hours = 0;
        }
        //Printing result...
        if (minutes < 10)
        {
            Console.WriteLine(hours + ":0" + minutes);
        }
        else if (minutes > 10)
        {
            Console.WriteLine(hours + ":" + minutes);
        }
    }
}
