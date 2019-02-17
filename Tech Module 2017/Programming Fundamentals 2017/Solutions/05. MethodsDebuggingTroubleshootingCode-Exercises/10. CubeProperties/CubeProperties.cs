using System;

class CubeProperties
{
    public static void Main()
    {
        double sideOfCube = double.Parse(Console.ReadLine());
        string parameterToCalculate = Console.ReadLine();

        if (parameterToCalculate == "face")
        {
            PrintFace(sideOfCube);
        }
        else if (parameterToCalculate == "space")
        {
            PrintSpace(sideOfCube);
        }
        else if (parameterToCalculate == "volume")
        {
            PrintVolume(sideOfCube);
        }
        else if (parameterToCalculate == "area")
        {
            PrintArea(sideOfCube);
        }
    }

    public static double PrintFace(double sideOfCube)
    {
        double face = Math.Sqrt(2 * sideOfCube * sideOfCube);
        Console.WriteLine(face.ToString("F"));
        return 0;
    }

    public static double PrintSpace(double sideOfCube)
    {
        double space = Math.Sqrt(3 * sideOfCube * sideOfCube);
        Console.WriteLine(space.ToString("F"));
        return 0;
    }

    public static double PrintVolume(double sideOfCube)
    {
        double volume = sideOfCube * sideOfCube * sideOfCube;
        Console.WriteLine(volume.ToString("F"));
        return 0;
    }

    public static double PrintArea(double sideOfCube)
    {
        double area = 6 * sideOfCube * sideOfCube;
        Console.WriteLine(area.ToString("F"));
        return 0;
    }
}