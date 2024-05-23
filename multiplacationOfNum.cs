//write a program to take a input of three numbers from the user and multiply them
using System;
class HelloWorld {
  static void Main() {
      int num1, num2, num3, result;
    Console.Write("Input the first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the third number: ");
    num3 = Convert.ToInt32(Console.ReadLine());
    result = num1 * num2 *num3;
    Console.WriteLine("{0} * {1} * {2} = {3}", num1, num2, num3, result);
  }
}
