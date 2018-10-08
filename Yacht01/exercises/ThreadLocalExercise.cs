using System;
using System.Threading;

namespace Yacht01.exercises
{
    public static class ThreadLocalExercise
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() => {
            return Thread.CurrentThread.ManagedThreadId;
        });

        public static void Run(string[] args)
        {
            new Thread(() => {
                Console.WriteLine("Thread A: {0}", _field.Value);
            }).Start();

            new Thread(() => {
                Console.WriteLine("Thread B: {0}", _field.Value);
            }).Start();

            Console.ReadKey();
        }
    }
}
