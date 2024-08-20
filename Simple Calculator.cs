//Simple Calculator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string answer, answer2;
            Console.WriteLine("Hello! , welcome to the calculator ");

            Console.Write("Please enter your first number: ");
            num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);

            Console.Write("PLease enter your second number: ");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2);

            Console.Write("What type of operation would you like to do?");
            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication, d for division");
            answer = Console.ReadLine();

            if(answer == "a")
            {
                Console.WriteLine("The result is:{0} ", num1 + num2);
            }
            else if (answer == "s")
            {
                Console.WriteLine("The reult is:{0}", num1 - num2);

            }
            else if(answer == "m")
                {
                Console.WriteLine("The result is: {0}",num1 * num2);
            }
            else
            {
                Console.WriteLine("The result is: {0}", num1 / num2);
            }

            Console.Write("Would you like to do another calculation?");
            Console.WriteLine("Please enter y for Yes, n for no");
            answer2= Console.ReadLine();

            if (answer2 =="y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Thank you for using the calculator program");
            }
            Console.ReadKey();

        }
    }
}