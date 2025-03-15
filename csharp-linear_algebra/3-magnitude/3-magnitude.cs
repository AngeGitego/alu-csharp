using System;

/// <summary>
/// Provides mathematical operations on vectors.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates and returns the magnitude of a 2D or 3D vector.
    /// </summary>
    /// <param name="vector">An array representing the vector.</param>
    /// <returns>The magnitude rounded to two decimal places, or -1 if invalid.</returns>
    public static double Magnitude(double[] vector)
    {
        // Check if the vector is valid (only 2D or 3D allowed)
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }

        // Compute the magnitude
        double sumOfSquares = 0;
        foreach (double component in vector)
        {
            sumOfSquares += Math.Pow(component, 2);
        }

        double magnitude = Math.Sqrt(sumOfSquares);
        return Math.Round(magnitude, 2); // Round to nearest hundredth
    }

    /// <summary>
    /// Main method for testing the function.
    /// </summary>
    static void Main()
    {
        double[] vector2D = {3, 4};   // Should return 5.00
        double[] vector3D = {1, 2, 2}; // Should return 3.00
        double[] invalidVector = {1, 2, 3, 4}; // Should return -1

        Console.WriteLine($"Magnitude of (3,4): {Magnitude(vector2D)}");
        Console.WriteLine($"Magnitude of (1,2,2): {Magnitude(vector3D)}");
        Console.WriteLine($"Magnitude of (1,2,3,4): {Magnitude(invalidVector)}");
    }
}
