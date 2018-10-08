using System;
using System.Threading;

namespace Yacht01.exercises
{
    public static class ThreadStaticExercise
    {
        //[ThreadStatic]
        public static int _field;

        public static void Run(string[] args)
        {
            new Thread(() => {
                for(int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();

            new Thread(() => {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
