//Program to Demonstrate String Formatting

using System;

class Program
{
    static void Main()
    {
        string name = "shri";
        int age = 22;
        double marks = 85.5;

        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Marks: {0:F2}", marks);

        // Using string interpolation
        Console.WriteLine($"Student {name} is {age} years old and scored {marks} marks.");
    }
}