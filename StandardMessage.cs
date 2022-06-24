using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMunging
{
    public class StandardMessage
    {
        public static string WelcomeMesage()
        {
            Console.WriteLine("Welcome, enter weather or football for relevant data processing: ");
            string userChoice = Console.ReadLine();
            return userChoice;
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void ExitApplication()
        {
            Console.WriteLine("Press any key to end the application: ");
            Console.ReadLine();
        }

        public static void EnterACorrectData ()
        {
            Console.WriteLine("Application closing. Enter a valid data next time... ");
            Console.WriteLine();

        }
    }
}
