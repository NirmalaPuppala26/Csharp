//Simple calculator using switch case
using System;
using static System.Formats.Asn1.AsnWriter;

class Program
{
    static void Main()
    {
            Console.Write("Enter your first number: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            float b = float.Parse(Console.ReadLine());
            float add = a + b;
            float sub = a - b;
            float product = a * b;
            float div = a / b;
            Console.WriteLine("Choose a operation add,sub,product,div: ");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "add":
                    Console.WriteLine($"Addition of two numbers:{add}");
                    break;
                case "sub":
                    Console.WriteLine($"Substraction of two numbers:{sub}");
                    break;
                case "product":
                    Console.WriteLine($"product of two numbers:{product}");
                    break;
                case "div":
                    Console.WriteLine($"Division of two numbers:{div}");
                    break;
            }

        }
    }