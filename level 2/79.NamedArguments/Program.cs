//Program to demonstrate Named Arguments

using System;

class Program
{
    static void Student(string name, int age, string course)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Course: " + course);
    }

    static void Main()
    {
        Student(age: 20, course: "Csd", name:"shri");
    }
}