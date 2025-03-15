using System;
using System.IO;

/// <summary>
/// Provides mathematical operations on vectors.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Adds two 2D vectors and returns the result.
    /// </summary>
    /// <param name="v">First vector (x1, y1).</param>
    /// <param name="u">Second vector (x2, y2).</param>
    /// <returns>The sum of the vectors.</returns>
    public static double[] AddVectors(double[] v, double[] u)
    {
        // Check if both vectors are 2D
        if (v.Length != 2 || u.Length != 2)
        {
            return new double[] { -1 }; // Return error case
        }

        // Compute the sum
        double[] result = { v[0] + u[0], v[1] + u[1] };
        return result;
    }

    /// <summary>
    /// Main method for testing the function.
    /// </summary>
    static void Main()
    {
        double[] v = { 8, -11 };
        double[] u = { -4, 9 };
        double[] sum = AddVectors(v, u);

        // Format the output as required
        string output = $"({sum[0]}, {sum[1]})";

        // Print result
        Console.WriteLine($"Sum of vectors: {output}");

        // Save the result in a text file
        File.WriteAllText("4-vector_addition_2D.txt", output);
    }
}
