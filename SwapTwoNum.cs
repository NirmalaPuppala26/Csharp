//
using System;
class HelloWorld {
  static void Main() {
      Console.Write("Input first number: ");
    string a=Console.ReadLine();
    Console.Write("Input the secnd number: ");
    string b=Console.ReadLine();
    string temp;
    temp=a;
    a=b;
    b=temp;
    Console.WriteLine("After swapping: ");
    Console.WriteLine("First Number: "+ a);
    Console.WriteLine("Second Number: "+b);
    Console.Read();
  }
}