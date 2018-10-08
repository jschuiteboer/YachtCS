using System.Diagnostics;
using System.Threading;

namespace Yacht01.exercises
{
    internal class ThreadExercise
    {
        public static void Run(string[] args)
        {
            Thread thread = new Thread(DoWork);
            //thread.IsBackground = true;
            thread.Start(5);

            Thread thread2 = new Thread((amount) =>
            {
                for (int i = 0; i < (int)amount; ++i)
                {
                    Debug.WriteLine("Lambda: {0}", i);
                    Thread.Sleep(1000);
                }
            });
            thread2.Start(10);
            
            for(int i = 0; i < 4; ++i)
            {
                Debug.WriteLine("Main thread: {0}", i);
                Thread.Sleep(0);
            }

            thread.Join();
            thread2.Join();
        }
        
        private static void DoWork(object amount)
        {
            for (int i = 0; i < (int) amount; ++i)
            {
                Debug.WriteLine("Function: {0}", i);
                Thread.Sleep(1000);
            }
        }
    }
}