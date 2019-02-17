using System;

class PrintPartOfASCIITable
{
    static void Main()
    {
        int from = int.Parse(Console.ReadLine());
        int to = int.Parse(Console.ReadLine());

        for (char i = (char)from; i <= (char)to; i++)
        {

            Console.Write(i + " ");
        }
    }
}