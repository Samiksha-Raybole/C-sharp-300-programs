//Program to Demonstrate StringBuilder

using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");

        sb.Append(" World");
        sb.Append("!");

        Console.WriteLine("String after using StringBuilder: " + sb.ToString());
    }
}