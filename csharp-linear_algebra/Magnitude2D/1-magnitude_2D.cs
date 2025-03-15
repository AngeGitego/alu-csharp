using System;

/// <summary>
/// This class calculates the magnitude of a 2D vector.
/// </summary>
class Magnitude2D
{
    static void Main()
    {
        double x = 3;
        double y = 9;
        double magnitude = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        magnitude = Math.Round(magnitude, 2); // Round to 2 decimal places

        // Save result to a text file
        System.IO.File.WriteAllText("1-magnitude_2D.txt", magnitude.ToString());

        Console.WriteLine($"The magnitude of vector v is: {magnitude}");
    }
}
