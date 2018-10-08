using System.Diagnostics;
using System.Threading.Tasks;

namespace Yacht01.exercises
{
    class TaskExercise
    {
        public static void Run(string[] args)
        {
            Task<int> task = Task.Run(() => {
                for (int x = 0; x < 100; ++x)
                {
                    Debug.Write('*');
                }
                Debug.Write('\n');

                return 42;
            })
            .ContinueWith((i) => {
                return i.Result * 2;
            });

            Debug.WriteLine(task.Result);
        }

        public static async Task<string> Test()
        {
            return "bier";
        }
    }
}
