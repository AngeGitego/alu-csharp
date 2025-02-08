using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> aStack = new Stack<string>(new[] { "C", "HTML", "Javascript", "Python", "React", "Ruby" });

        MyStack.Info(aStack, "C#", "Javascript");

        Console.WriteLine("------------------");

        Stack<string> anotherStack = new Stack<string>(new[] { "Physical", "Data Link", "Network", "Transport", "Session", "Presentation" });

        MyStack.Info(anotherStack, "Application", "Application");

        Console.WriteLine("------------------");

        Stack<string> emptyStack = new Stack<string>();

        MyStack.Info(emptyStack, "C#", "C++");
    }
}
