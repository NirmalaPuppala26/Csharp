//write a program to calculate the average of three numbers
using System;
class HelloWorld {
  static void Main() {
    int num1, num2, num3, num4, avg;
    Console.Write("Enter First Number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Second Number: ");
    num2  = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Third Number: ");
    num3 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Fourth Number: ");
    num4 = Convert.ToInt32(Console.ReadLine());
    avg = (num1+num2+num3+num4)/4;
    Console.WriteLine("The average of {0}, {1}, {2}, {3} is {4}",num1,num2,num3,num4,avg);
    }
}
