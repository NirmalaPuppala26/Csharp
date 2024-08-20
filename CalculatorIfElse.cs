//Simple calculator using if else 
using System;

    class Program
{
    static void Main()
    {
        Console.Write("Enter your first number: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter your second number: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("choose an operation: +,-,*,/");
        string operation = Console.ReadLine();
        if (operation == "+")
        {
            float add = a + b;
            Console.WriteLine($"adding two number: {add}");
        }
        else if (operation == "-")
        {
            if (a > b)
            {
                float sub1 = a - b;
                Console.WriteLine($"subtraction two numbers: {sub1}");

            }
            else
            {
                float sub2 = b - a;
                Console.WriteLine($"subtraction two numbers: {sub2}");
            }
        }
        else if (operation == "*")
        {
            float mul = a * b;
            Console.WriteLine($"multiplication of two numbers: {mul}");
        }
        else
        {
            if (b == 0)
            {
                Console.WriteLine($"Error: Division by zero is not allowed.");
            }
            else
            {
                float div = a / b;
                Console.WriteLine($"Division of two number: {div}");
            }
        }
        Console.WriteLine("Do you still wanna continue? y or n");
        string ans2 = Console.ReadLine();
        if (ans2 == "y")
        {
            Main();
        }
        else
        {
            Console.WriteLine("Thank you");
        }

        

    }
}