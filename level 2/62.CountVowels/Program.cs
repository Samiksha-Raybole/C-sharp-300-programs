using System;

class Program
{
    static void Main()
    {
        string str;
        int count = 0;

        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        str = str.ToLower();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
            {
                count++;
            }
        }

        Console.WriteLine("Number of vowels: " + count);
    }
}