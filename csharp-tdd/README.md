Requirements
C# Tasks
Allowed editors: Visual Studio Code
All files will be compiled on Ubuntu 14.04 LTS using dotnet
A README.md file, at the root of the folder of the project, is mandatory
All default C# files named Program.cs should be renamed to the name given in each task
Each C# task requires its own folder and .sln file. Push all task folders to your GitHub and ensure the task names on the folders are correct
You do not need to push your obj/ or bin/ folders
In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
All your public classes and their members should have XML documentation tags
All your private classes and members should be documented but without XML documentation tags
C# Tests
Allowed editors: Visual Studio Code
All tests should be inside a separate folder and named as specified in each task
All your test files will be executed using dotnet test
We strongly encourage you to work together on tests so that you don’t miss any edge cases
More Info
In past C# assignments, you have been creating individual console application projects for each task. In this assignment, you are going to create a solution file to allow you to manage multiple projects. Each task is one solution containing two projects: one class library solving the task and one test library to test the class library.

For each task in this project:

Create task directory (ex: 0-add)
Inside that directory, run dotnet new sln
Create a new directory for your task solution based on the namespace given (ex: MyMath). This directory will hold your new standard class library.
Inside that directory, run dotnet new classlib. Rename the resulting .cs file after the namespace (ex: MyMath.cs)
Enable XML documentation by adding <DocumentationFile>bin\$(Configuration)\$(TargetFramework)\$(AssemblyName).xml</DocumentationFile> to MyMath.csproj
The target framework for this standard class library should be netstandard2.0
Change directory back to the root directory of the task (ex: 0-add) and run dotnet sln add <classlibrary/classlibrary.csproj> (ex. dotnet sln add MyMath/MyMath.csproj)
Create a new directory for your tests based on the namespace given plus .Tests (ex: MyMath.Tests). This directory will hold your test library.
The target framework for this library should be netcoreapp2.1
Inside that directory, run dotnet new nunit. Rename the resulting .cs file after the namespace of classes you are testing plus .Tests (ex: MyMath.Tests.cs)
To add your class library as a dependency to the project, run dotnet add reference <../classlibrary/classlibrary.csproj> (ex: dotnet add reference ../MyMath/MyMath.csproj)
In the task’s root directory, run dotnet sln add <testlibrary/testlibrary.csproj (ex: dotnet sln add MyMath.Tests/MyMath.Tests.csproj)
If you’d like to run your class library method in a console application, create a new directory and run dotnet new console inside it. Run dotnet add reference <../classlibrary/classlibrary.csproj> and you can then call your class library methods inside the console application.
For more detail, read the Unit Testing C# with NUnit and .NET Core tutorial.

The resulting directory hierarchy for task #0 will look like this:

/0-add
    0-add.sln
    /MyMath
        MyMath.cs
        MyMath.csproj
    /MyMath.Tests
        MyMath.Tests.cs
        MyMath.Tests.csproj
For this project:
Based on the requirements of each task, you should write the documentation and tests first before you actually code anything
The intranet checks for C# projects won’t be released before their first deadline in order for you to focus more on TDD and thinking about all possible cases
We strongly encourage you to work together on tests so that you don’t miss any edge cases
Don’t trust the user, always think about all possible edge cases
Note: The videos provided as resources use Visual Studio, not Visual Studio Code. While the two programs differ, the methods and concepts behind unit testing are the same.

If NUnit is not already installed, use the command: dotnet new -i NUnit3.DotNetNew.Template

Quiz questions
Great! You've completed the quiz successfully! Keep going! (Show quiz)
Tasks
0. Add integers
mandatory
Write a method that adds 2 numbers

Namespace: MyMath
Class: Operations
Prototype: public static int Add(int a, int b)
Returns: sum of a and b
Test Library Namespace: MyMath.Tests
It is not necessary to account for integer overflow in this task
Repo:

GitHub repository: alu-csharp
Directory: csharp-tdd
File: 0-add/, 0-add/0-add.sln, 0-add/MyMath, 0-add/MyMath/MyMath.csproj, 0-add/MyMath/MyMath.cs, 0-add/MyMath.Tests, 0-add/MyMath.Tests/MyMath.Tests.csproj, 0-add/MyMath.Tests/MyMath.Tests.cs
0/18 pts
1. Divide a matrix
mandatory
Write a method that divides all elements of a matrix.

Namespace: MyMath
Class: Matrix
Prototype: public static int[,] Divide(int[,] matrix, int num)
Returns: a new matrix containing divided elements
If num is 0, print Num cannot be 0 and return null. (Hint: use try / catch)
If matrix is null, return null
Repo:

GitHub repository: alu-csharp
Directory: csharp-tdd
File: 1-divide/, 1-divide/1-divide.sln, 1-divide/MyMath, 1-divide/MyMath/MyMath.csproj, 1-divide/MyMath/MyMath.cs, 1-divide/MyMath.Tests, 1-divide/MyMath.Tests/MyMath.Tests.csproj, 1-divide/MyMath.Tests/MyMath.Tests.cs
0/23 pts
2. Max integer
mandatory
Write a method that returns the max integer in a list of integers.

Namespace: MyMath
Class: Operations
Prototype: public static int Max(List<int> nums)
Returns: max integer in list
If nums is empty, return 0
Repo:

GitHub repository: alu-csharp
Directory: csharp-tdd
File: 2-max_int/, 2-max_int/2-max_int.sln, 2-max_int/MyMath, 2-max_int/MyMath/MyMath.csproj, 2-max_int/MyMath/MyMath.cs, 2-max_int/MyMath.Tests, 2-max_int/MyMath.Tests/MyMath.Tests.csproj, 2-max_int/MyMath.Tests/MyMath.Tests.cs
0/34 pts
3. Desserts, I stressed!
mandatory
Write a method that returns True if a string is a palindrome or False if it’s not.

Namespace: Text
Class: Str
Prototype: public static bool IsPalindrome(string s)
Returns: True if string is a palindrome, False if it’s not

In this task, palindromes are not case sensitive

Racecar = True
level = True
Spaces and punctuation should be ignored

A man, a plan, a canal: Panama. = True
An empty string is considered a palindrome

Repo:

GitHub repository: alu-csharp
Directory: csharp-tdd
File: 3-palindrome/, 3-palindrome/3-palindrome.sln, 3-palindrome/Text, 3-palindrome/Text/Text.csproj, 3-palindrome/Text/Text.cs, 3-palindrome/Text.Tests/, 3-palindrome/Text.Tests/Text.Tests.csproj, 3-palindrome/Text.Tests/Text.Tests.cs
0/34 pts
4. Unique character
mandatory
Write a method that returns the index of the first non-repeating character of a string.

Namespace: Text
Class: Str
Prototype: public static int UniqueChar(string s)
Returns: index of first non-repeating character or -1 if there is no non-repeating character
You can assume the string contains only lowercase letters, no spaces or special characters
Repo:

GitHub repository: alu-csharp
Directory: csharp-tdd
File: 4-unique/, 4-unique/4-unique.sln, 4-unique/Text, 4-unique/Text/Text.csproj, 4-unique/Text/Text.cs, 4-unique/Text.Tests/, 4-unique/Text.Tests/Text.Tests.csproj, 4-unique/Text.Tests/Text.Tests.cs
0/30 pts
5. camelCase
mandatory
Write a method that determines how many words are in a string. Each word begins with a capital letter except the first word.

Namespace: Text
Class: Str
Prototype: public static int CamelCase(string s)
Returns: number of words in s
Repo:

GitHub repository: alu-csharp
Directory: csharp-tdd
File: 5-camelcase/, 5-camelcase/5-camelcase.sln, 5-camelcase/Text/, 5-camelcase/Text/Text.csproj, 5-camelcase/Text/Text.cs, 5-camelcase/Text.Tests/, 5-camelcase/Text.Tests/Text.Tests.csproj, 5-camelcase/Text.Tests/Text.Tests.cs
