//Multi-Dimentional Array 
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintRowSums()
        {
            // Declare and initialize a 3x3 two-dimensional array
            int[,] array = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            // Loop through each row
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                
                // Loop through each column in the current row
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                
                // Print the sum of the current row
                Console.WriteLine(sum);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintRowSums();
        }
    }
}