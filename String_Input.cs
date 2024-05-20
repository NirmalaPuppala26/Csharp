//write a program to accept a string and display that "The string you entered is:<String you have entered> "
using System;

// Define the Exercise1 class
public class Exercise1 
{
    // Main method - entry point of the program
    public static void Main()  
    {  
        string str; // Declare a variable to store the input string

        // Prompt the user to enter a string
        Console.Write("\n\nAccept a string from the keyboard:\n");
        Console.Write("-----------------------------------\n");

        // Request user input for a string
        Console.Write("Input the string: ");
        str = Console.ReadLine(); // Read the user input

        // Display the entered string back to the user
        Console.Write("The string you entered is: {0}\n", str);
    }
}

