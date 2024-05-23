/*Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7*/

using System;
class HelloWorld {
  static void Main() {
      int x,y,z;
      Console.Write("Enter first number: ");
      x = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter Second number: ");
      y = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter third number: ");
      z = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Result of specified numbers {0},{1},{2}, (x+y).z is {3} and {4}",x,y,z,(x+y)*z,x*y+y*z);
    }
}
