using System;
using System.Diagnostics;

namespace Yacht01.exercises
{
    class DelegateExercise
    {
        public delegate int Calculate(int x, int y);
        
        public int Add(int x, int y)
        {
            Debug.WriteLine("adding {0} + {1}", x, y);
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            Debug.WriteLine("multiplying {0} * {1}", x, y);
            return x * y;
        }

        public static void Run(string[] args)
        {
            DelegateExercise exercise = new DelegateExercise();

            Calculate calc = null;
            
            calc = exercise.Add;
            Debug.WriteLine("this should print 7:");
            Debug.WriteLine(calc(3, 4));

            calc += exercise.Multiply;
            Debug.WriteLine("this should print 12:");
            Debug.WriteLine(calc(3, 4));

            calc += (x, y) => x - y;
            Debug.WriteLine("this should print -1:");
            Debug.WriteLine(calc(3, 4));

            
        }
    }
}
