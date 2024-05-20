//Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
using System;
class HelloWorld {
  static void Main() {
    Console.Write("Input the First number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the Second Number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("{0} + {1} = {2}", num1, num2 ,num1+num2);
    Console.WriteLine("{0} - {1} = {2}", num1, num2, num1-num2);
    Console.WriteLine("{0} * {1} = {2}", num1, num2, num1*num2);
    Console.WriteLine("{0} / {1} = {2}", num1, num2, num1/num2);
    Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1%num2);
    Console.Read();
  }
}