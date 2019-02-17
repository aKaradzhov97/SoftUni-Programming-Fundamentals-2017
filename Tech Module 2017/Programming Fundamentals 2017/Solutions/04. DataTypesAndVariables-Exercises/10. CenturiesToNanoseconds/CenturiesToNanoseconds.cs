using System;

class CenturiesToNanoseconds
{
    static void Main()
    {
        byte centuries = byte.Parse(Console.ReadLine());
        short years = (short)(centuries * 100);
        int days = (int)(years * 365.2422);
        decimal hours = (days * 24);
        decimal minutes = (hours * 60);
        decimal seconds = minutes * 60;
        decimal milliSeconds = (seconds * 1000);
        decimal microSeconds = (milliSeconds * 1000);
        decimal nanoSeconds = (microSeconds * 1000);

        Console.WriteLine(centuries + " centuries = "
                            + years + " years = "
                            + days + " days = "
                            + hours + " hours = "
                            + minutes + " minutes = "
                            + seconds + " seconds = "
                            + milliSeconds + " milliseconds = "
                            + microSeconds + " microseconds = "
                            + nanoSeconds + " nanoseconds");
    }
}
