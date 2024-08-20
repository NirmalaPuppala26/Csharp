//Simple Quiz


using System;
using static System.Formats.Asn1.AsnWriter;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello! Welcome to Fun Quiz");
        Console.WriteLine("Do you wanna start your quiz? y/n");
        string ans = Console.ReadLine();
        if (ans == "y")
        {
            int score = 0;
            string question1 = "What is the capital of India?";
            string answer1 = "New Delhi";
            Console.WriteLine(question1);
            Console.WriteLine("Type your answer here: ");
            string ans1 = Console.ReadLine();
            if (ans1.Trim().ToLower() == answer1.ToLower())
            {
                score = score + 1;
                string question2 = "What is the capital of USA?";
                string answer2 = "Washington DC";
                Console.WriteLine(question2);
                Console.WriteLine("Type your answer here: ");
                string ans2 = Console.ReadLine();

                if (ans2.Trim().ToLower() == answer2.ToLower())
                {
                    score = score + 1;
                    string question3 = "What is the animal associated with the Sahara desert?";
                    string answer3 = "Camel";
                    Console.WriteLine(question3);
                    Console.WriteLine("Type your answer here: ");
                    string ans3 = Console.ReadLine();

                    if (ans3.Trim().ToLower() == answer3.ToLower())
                    {
                        score = score + 1;
                        string question4 = "How many days are there in a week?";
                        string answer4 = "7 days";
                        Console.WriteLine(question4);
                        Console.WriteLine("Type your answer here: ");
                        string ans4 = Console.ReadLine();

                        if (ans4.Trim().ToLower() == answer4.ToLower())
                        {
                            score = score + 1;
                            string question5 = "How many hours are there in a day?";
                            string answer5 = "24 hours";
                            Console.WriteLine(question5);
                            Console.WriteLine("Type your answer here: ");
                            string ans5 = Console.ReadLine();

                            if (ans5.Trim().ToLower() == answer5.ToLower())
                            {
                                score = score + 1;
                                Console.WriteLine("Congratulations! You have successfully completed your fun quiz.");
                                Console.WriteLine("Your total score is: {0}", score);
                            }
                            else
                            {
                                Console.WriteLine("Oops! Your answer is wrong.");
                                Console.WriteLine("Your total score is: {0}", score);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Oops! Your answer is wrong.");
                            Console.WriteLine("Your total score is: {0}", score);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Oops! Your answer is wrong.");
                        Console.WriteLine("Your total score is: {0}", score);
                    }
                }
                else
                {
                    Console.WriteLine("Oops! Your answer is wrong.");
                    Console.WriteLine("Your total score is: {0}", score);
                }
            }
            else
            {
                Console.WriteLine("Oops! Your answer is wrong.");
                Console.WriteLine("Your total score is: {0}", score);
            }
        }
        else
        {
            Console.WriteLine("Quiz not started.Thank you!");
            Console.WriteLine("Your total score is: 0");
        }

        Console.ReadLine();
    }
}