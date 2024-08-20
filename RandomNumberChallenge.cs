//Guess a random number challenge
using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome! To the guess the random number chanllenge");
        Console.WriteLine("Are you ready to start? y or n");
        string ans = Console.ReadLine();
        if (ans.Trim() == "y")
        {
            Console.WriteLine("Let's Start");
        }
        else
        {
            Console.WriteLine("You did not start the challenge");
        }

        Random random = new Random();

        int randomNumber = random.Next(1, 100); //random is a object, using the random object we are creating a random number, "random.next()" .next(<range>) is a syntax for giving a random number
        Console.WriteLine("Please guess the random number: ");
        int a;
        a = Convert.ToInt32(Console.ReadLine());

        if (randomNumber == a)
        {
            Console.WriteLine("You have guess it right");
        }
        else
        {
            Console.WriteLine($"Sorry! you didn't guess it right. The correct answer is {randomNumber}");
        }
        Console.WriteLine("Do you still want to continue? y or n");
        string ans1 = Console.ReadLine();
        if (ans == "y")
        {
            Main();
        }
        else
        {
            Console.WriteLine("Thank you for playing");
        }
    }
}