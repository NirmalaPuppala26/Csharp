/* Write a C# Sharp program that takes three letters and displays them in reverse order.
Test Data
Enter letter: b
Enter letter: a
Enter letter: t
Expected Output :
t a b*/
using System;
class HelloWorld {
  static void Main() {
      char let1,let2,let3;
      Console.Write("Enter letter: ");
      let1 = Convert.ToChar(Console.ReadLine());
      Console.Write("Enter letter: ");
      let2 =Convert.ToChar( Console.ReadLine());
      Console.Write("Enter letter: ");
      let3 = Convert.ToChar(Console.ReadLine());
      Console.WriteLine("{0},{1},{2}",let3,let2,let1);
    }
}
