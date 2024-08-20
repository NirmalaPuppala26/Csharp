//array
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintNumbers()
        {
            // Initialize array and print each number using a foreach loop
            int[] intMyArray = {1,2,3,4,5};
            foreach(var item in intMyArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}