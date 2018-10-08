using System;
using System.Diagnostics;
using System.Threading;

namespace Yacht01.exercises
{
    class PerformanceCounterExercise
    {
        public static void Run(string[] args)
        {
            using(PerformanceCounter performanceCounter = new PerformanceCounter("Memory", "Available Bytes"))
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

                while(!Console.KeyAvailable)
                {
                    String output = string.Format("Available memory: {0} bytes", performanceCounter.RawValue);
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write(output);
                }
            }
        }
    }
}
