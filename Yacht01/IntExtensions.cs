using System;

namespace Yacht01
{
    public static class IntExtensions
    {
        public static bool IsPrime(this int number)
        {
            return IsPrime(number, number);
        }

        private static bool IsPrime(this int number, int i)
        {
            if(number < 0)
            {
                throw new ArgumentException("Number can not be negative");
            }

            i = i - 1;

            if (i <= 1)
            {
                return true;
            }
            else if (number % i == 0)
            {
                return false;
            }
            else
            {
                return IsPrime(number, i);
            }
        }
    }
}
