using Enemies;
using System;

/// <summary>
/// Entry point of the program.
/// </summary>
class Program
{
    /// <summary>
    /// Main method that creates Zombie objects and displays their type and health.
    /// </summary>
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            Console.WriteLine("newObject1 is of type {0} and has a total of {1} health", newObject1.GetType(), newObject1.health);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            newObject2 = new Enemies.Zombie(-10);
            Console.WriteLine("newObject2 is of type {0} and has a total of {1} health", newObject2.GetType(), newObject2.health);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
