using System;

class ArrayElement
{
    static void Main()
    {
        int[] arr = new int[5];

        Console.WriteLine("Enter 5 elements:");

        for ( int i=0; i<arr.Length; i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        
        }
        Console.WriteLine("The elements in the array are:");
        for (int i=0; i<arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}