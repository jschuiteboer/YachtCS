using System;

namespace Yacht01.exercises
{
    class RecursionExcerice
    {
        public static void Run(string[] args)
        {
            while (true)
            {
                int number = GetInput();

                if (number < 0)
                {
                    break;
                }

                string primeMessage = number.IsPrime() ? " is a prime" : " is not a prime";

                Console.WriteLine(number + primeMessage);
            }
        }

        private static int GetInput()
        {
            while (true)
            {
                Console.WriteLine("Enter a number:");

                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    return -1;
                }

                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine(input + " is not a valid number");
                }
            }
        }
    }
}
