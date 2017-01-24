using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    static class StaticUserInterface
    {
        // No Variables
        // No Properties
        // No constructors
        // Just a collection of methods

        //***********
        //* Methods *
        //***********

        public static int GetUserInput()
        {
            // print out a message
            printMenu();

            // get the input from the user
            string input = Console.ReadLine();

            // while the input is not valid re-get the input
            while (input != "1" && input != "2")
            {

                // print error messsage
                errorMessage();

                // reprint the menu
                printMenu();

                input = Console.ReadLine();

            }

            // if the input is good, return it
            return Int32.Parse(input);
        }

        public static void Ouput(string outputString)
        {
            Console.WriteLine(outputString);
        }

        private static void printMenu()
        {
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1) Print List" + Environment.NewLine + "2) Exit");
            Console.WriteLine("Enter your input ");
        }

        private static void errorMessage()
        {
            Console.Clear();
            Console.WriteLine("Your input is invalid" + Environment.NewLine);
        }
    }
}
