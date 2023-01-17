using System;

namespace Program_2 
{
    internal class Program
    {
        static void Main()
        {
            // Declarations
            int sum = 0;
            double average;
            int[] numbers = new int[3];

            // Read user input
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter an integer: ");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i]; // Sum the numbers as they are entered
            }

            // Initialize variables for largest and smallest
            int largest = numbers[0];
            int smallest = numbers[0];

            // Loop through the numbers array
            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            average = sum / 3.0; // Calculate the average

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Smallest: " + smallest);
            Console.WriteLine("Largest: " + largest);
        }
    }
}
