using System;

namespace TestingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            array();
        }

        static void array()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                int number;
                do
                {
                    Console.Write("Enter marks " + (i + 1) + " (max 100): ");
                    number = Convert.ToInt32(Console.ReadLine());
                } while (number > 100);
                numbers[i] = number;
            }

            Console.WriteLine("\nThe students marks contains the following numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double average = (double)sum / numbers.Length;

            Console.WriteLine("\nThe average of grades is: " + average);
        }
    }
}
