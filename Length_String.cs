//write a program to find the length of the string
using System;

// Define the Exercise1 class
class Exercise1 
{
    // Main method - entry point of the program
    static void Main()  
    {  
        Console.WriteLine("\n Enter a String: ");
        string userLength=Console.ReadLine();
        int length = userLength.Length;
        Console.WriteLine("The length of the string: {0}",length);
    }
}

