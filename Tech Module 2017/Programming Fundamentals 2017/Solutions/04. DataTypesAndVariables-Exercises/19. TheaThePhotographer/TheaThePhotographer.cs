using System;

class TheaThePhotographer
{
    static void Main()
    {
        decimal pictures = decimal.Parse(Console.ReadLine());
        decimal filterTime = decimal.Parse(Console.ReadLine());
        decimal percentGoodPics = decimal.Parse(Console.ReadLine());
        decimal uploadTime = decimal.Parse(Console.ReadLine());

        decimal filteredPics = Math.Ceiling(percentGoodPics / 100 * pictures);
        decimal picturesFilterTime = pictures * filterTime;
        decimal filteredPicsUploadTime = filteredPics * uploadTime;
        double totalTimeInSeconds = (double)(filteredPicsUploadTime + picturesFilterTime);

        Console.WriteLine(TimeSpan.FromSeconds(totalTimeInSeconds).ToString(@"d\:hh\:mm\:ss"));
    }
}
