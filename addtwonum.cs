using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Globalization;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double myNumber1=0.0, myNumber2=0.0;
            Console.Write("Enter a whole number: ");
            //take a single input and use it many times
            string useInput = Console.ReadLine();
            //parsing a number
            myNumber1 = double.Parse(useInput, CultureInfo.InvariantCulture);
            Console.Write("Enter a whole number: ");
            useInput = Console.ReadLine();
            myNumber2 = double.Parse(useInput, CultureInfo.InvariantCulture);
            double sum = myNumber1 + myNumber2;
            sum = Math.Round(sum);
            Console.WriteLine($"The result after adding numbers {myNumber1.ToString(CultureInfo.InvariantCulture)}, {myNumber2.ToString(CultureInfo.InvariantCulture)}: {sum.ToString(CultureInfo.InvariantCulture)}");
        }
    }
}
