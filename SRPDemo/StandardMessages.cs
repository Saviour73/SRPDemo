using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class StandardMessages
    {
        public static void WelcomeMessages()
        {
            Console.WriteLine("welcome to my application");
        }

        public static void EndApplication()
        {
            Console.Write("Press enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldNmae)
        {
            Console.WriteLine($"You did not give us a valid { fieldNmae}!");
        }
    }

}
