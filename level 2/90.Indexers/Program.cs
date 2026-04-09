//Program to Demonstrate Indexers

using System;

class Student
{
    private string[] names = new string[5];

    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s[0] = "shri";
        s[1] = "Rohit";
        s[2] = "Suhani";

        Console.WriteLine("Student Names:");
        Console.WriteLine(s[0]);
        Console.WriteLine(s[1]);
        Console.WriteLine(s[2]);
    }
}