// Kyle Sherman
// Updated 1/18/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args) // main method
        {

            // Make a new instance of the UserInterface class
            // just commented this to use the static one instead
            //UserInterface ui = new UserInterface();


            // new instance of employee class
            // Here is a new employee being created using the default constructor
            // that we wrote in the employee class
            // even though we aren't using it, I want you to see a single instance 
            // f one vs an array of them.
            Employee myEmployee = new Employee(); // allocates the memory in the heap for blank constructor

            // Let's make an array to hold a bunch of instances of the employee class
            Employee[] employees = new Employee[10];

            // let's add some employees to our array
            //employees[0] = new Employee("David", "barnes", 150.00m);
            //employees[1] = new Employee("Kyle", "Sherman", 1000.00m);
            //employees[2] = new Employee("3CPO", "", 10.00m);

            // make the string for the path to the csv file
            string pathToCSV = "../employees.csv";

            // instantiate the cv Processor
            CSVProcessor csvProcessor = new CSVProcessor();
            // call the importCSV method sending over the path and
            // he array to store the read in records to.
            csvProcessor.ImportCSV(pathToCSV, employees);

            int userInput = StaticUserInterface.GetUserInput();
            while (userInput != 2)
            {
                if(userInput == 1)
                {
                    // Create a string that can be concatinated to
                    string outputString = "";


                    foreach (Employee employee in employees)
                    {
                        if (employee != null)
                        {

                            // concat to the outputString
                            outputString += employee.ToString() + Environment.NewLine;
                            //Console.WriteLine(employee.ToString());
                        }
                        else
                        {
                            //Console.WriteLine("There is nothing else here");
                            break;
                        }
                    }
                    StaticUserInterface.Ouput(outputString);
                }

                userInput = StaticUserInterface.GetUserInput();
            }
            // Console.WriteLine(myEmployee.FirstAndLastName());
        }
    }
}