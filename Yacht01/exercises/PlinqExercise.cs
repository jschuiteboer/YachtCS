using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Yacht01.exercises
{
    class PlinqExercise
    {
        private static Random random = new Random();

        public static void Run(string[] args)
        {
            var numbers = Enumerable.Range(0, 100);

            try
            {
                numbers.AsParallel()
                    .AsOrdered()
                    .Where(IsEven)
                    .Where(ThrowOnTen)
                    .ForAll(Print);

                (from num in numbers.AsParallel()
                 where IsEven(num)
                 select num)
                 .ForAll(Print);
            }
            catch (AggregateException ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private static bool ThrowOnTen(int i)
        {
            if (i % 10 == 0)
            {
                throw new ArgumentException("i");
            }
            else
            {
                return true;
            }
        }

        private static void Print(int i)
        {
            Debug.WriteLine(i);
        }

        private static bool IsEven(int i)
        {
            Thread.Sleep(random.Next(1, 10));
            return i % 2 == 0;
        }
    }
}
