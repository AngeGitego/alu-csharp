using System;
using System.Reflection;

/// <summary>
/// Contains methods to inspect object properties and methods.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of an object.
    /// </summary>
    public static void Print(object myObj)
    {
        Type objType = myObj.GetType();
        
        Console.WriteLine($"{objType.Name} Properties:");
        PropertyInfo[] properties = objType.GetProperties();
        if (properties.Length == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            foreach (PropertyInfo prop in properties)
            {
                Console.WriteLine(prop.Name);
            }
        }

        Console.WriteLine($"{objType.Name} Methods:");
        MethodInfo[] methods = objType.GetMethods();
        if (methods.Length == 0)
        {
            Console.WriteLine("None");
        }
        else
        {
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}

/// <summary>
/// Example class for testing.
/// </summary>
public class Dog
{
    public string Name { get; set; }

    public void Bark()
    {
        Console.WriteLine("Woof!");
    }
}
