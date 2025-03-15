using System;

class Magnitude3D
{
    static void Main()
    {
        // Vector v = (7, -3, -9)
        double[] v = { 7, -3, -9 };
        
        // Calculate the magnitude of the vector
        double magnitude = Magnitude(v);

        // Round to two decimal places
        magnitude = Math.Round(magnitude, 2);

        // Save the result to a text file
        System.IO.File.WriteAllText("2-magnitude_3D.txt", magnitude.ToString());

        // Output the result for verification (optional)
        Console.WriteLine($"The magnitude of the vector is: {magnitude}");
    }

    /// <summary>
    /// Calculates the magnitude of a 3D vector.
    /// </summary>
    /// <param name="vector">The vector as a double array</param>
    /// <returns>The magnitude of the vector</returns>
    public static double Magnitude(double[] vector)
    {
        // Check if the vector is 3D
        if (vector.Length != 3)
        {
            return -1;  // Return -1 if it's not a 3D vector
        }

        // Calculate magnitude using the formula: √(x² + y² + z²)
        return Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2));
    }
}
