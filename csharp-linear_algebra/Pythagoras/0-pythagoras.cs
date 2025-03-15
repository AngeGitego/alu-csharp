using System;

/// <summary>
/// This class calculates the hypotenuse of a right-angled triangle using the Pythagorean theorem.
/// </summary>
class Pythagoras
{
    static void Main()
    {
        double AB = 64;
        double BC = 121;
        double AC = Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(BC, 2));
        AC = Math.Round(AC, 2); // Round to 2 decimal places

        // Save result to a text file
        System.IO.File.WriteAllText("0-pythagoras.txt", AC.ToString());

        Console.WriteLine($"The length of AC is: {AC}");
    }
}
