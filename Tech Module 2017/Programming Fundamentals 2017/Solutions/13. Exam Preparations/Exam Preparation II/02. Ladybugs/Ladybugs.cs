using System;
using System.Linq;

public class Ladybugs
{
    public static void Main()
    {
        var fieldSize = int.Parse(Console.ReadLine());

        var ladybugsIndices = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Where(x => x >= 0 && x < fieldSize)
            .ToArray();

        var ladybugs = new int[fieldSize];

        ladybugsIndices = ladybugsIndices
            .Select(x => ladybugs[x] = 1)
            .ToArray();

        var line = Console.ReadLine();

        while (!line.Equals("end"))
        {
            var ladybugData = line
                .Split();

            var ladybugIndex = int.Parse(ladybugData[0]);
            var direction = ladybugData[1];
            var flyLenght = int.Parse(ladybugData[2]);

            if (ladybugIndex < 0 || ladybugIndex >= ladybugs.Length || ladybugs[ladybugIndex] == 0)
            {
                line = Console.ReadLine();
                continue;
            }

            MoveLadyBug(ladybugs, ladybugIndex, direction, flyLenght);

            line = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", ladybugs));
    }

    private static void MoveLadyBug(int[] ladybugs, int ladybugIndex, string direction, int flyLenght)
    {
        ladybugs[ladybugIndex] = 0;

        bool foundSpotOrLeft = false;

        while (!foundSpotOrLeft)
        {
            var newPosition = direction.Equals("left")
                ? ladybugIndex -= flyLenght
                : ladybugIndex += flyLenght;

            if (newPosition < 0 || newPosition >= ladybugs.Length)
            {
                foundSpotOrLeft = true;
                continue;
            }

            if (ladybugs[newPosition] == 1)
            {
                newPosition += flyLenght;
            }

            else
            {
                ladybugs[newPosition] = 1;
                foundSpotOrLeft = true;
            } 
        }
    }
}