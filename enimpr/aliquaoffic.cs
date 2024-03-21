using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Declare an array of numbers
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Use LINQ to calculate the average
        double average = numbers.Average();

        // Print the result
        Console.WriteLine("The average is " + average);
    }
}
