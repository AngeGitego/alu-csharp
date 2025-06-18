using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
        // Concatenate substrings to form the desired output
        str = str.Substring(49, 15) + " " + str.Substring(79, 12).Trim() + " " + str.Substring(3, 2);
        Console.WriteLine(str);
    }
}
