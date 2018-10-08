using System.Globalization;
using Yacht01.exercises;

namespace Yacht01
{
    class App
    {
        public static void Main(string[] args)
        {
            var defaultCulture = new CultureInfo("en-EN");
            CultureInfo.DefaultThreadCurrentCulture = defaultCulture;
            CultureInfo.DefaultThreadCurrentUICulture = defaultCulture;

            CodeDomExercise.Run(args);
        }
    }
}
