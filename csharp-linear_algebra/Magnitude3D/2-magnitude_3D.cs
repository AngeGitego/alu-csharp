using System;

/// <summary>
/// This class calculates the magnitude of a 3D vector.
/// </summary>
class Magnitude3D
{
    static void Main()
    {
        double x = 7;
        double y = -3;
        double z = -9;
        double magnitude = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        magnitude = Math.Round(magnitude, 2); // Round to 2 decimal places

        // Save result to a text file
        System.IO.File.WriteAllText("2-magnitude_3D.txt", magnitude.ToString());

        Console.WriteLine($"The magnitude of vector v is: {magnitude}");
    }
}
