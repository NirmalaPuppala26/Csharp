//Write a program to take age of the user and print you look older than the age
using System;
class HelloWorld {
  static void Main() {
      int age;
      Console.Write("Enter your age - ");
      age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("You look older than {0}",age);
    }
}
