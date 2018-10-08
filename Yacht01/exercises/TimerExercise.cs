using System;
using System.Timers;

namespace Yacht01.exercises
{
    internal class TimerExcercise
    {
        private static Timer timer;

        public static void Run(string[] args)
        {
            int seconds = 10;

            Console.WriteLine("Setting timer for {0}s", seconds);

            timer = new Timer(seconds * 1000);
       
            timer.AutoReset = false;
            timer.Elapsed += OnTimeElapsed;

            timer.Start();

            Console.ReadLine();
        }

        private static void OnTimeElapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("The timer went off at {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}