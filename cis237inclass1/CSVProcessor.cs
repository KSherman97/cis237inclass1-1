using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237inclass1
{
    class CSVProcessor
    {
        public bool ImportCSV(string pathToSCVFile, Employee[] employees)
        {
            StreamReader streamReader = null;
            try
            {
                // declare a string for the line
                string line;

                // insantiate the steream reader
                streamReader = new StreamReader(pathToSCVFile);

                int counter = 0;
                while ((line = streamReader.ReadLine()) != null)
                {
                    // Process the line
                    ProcessLine(line, employees, counter++);
                }
                return true;
            }
            catch (Exception e)
            {
                // ouput the exception and the stacktrace for the exception
                Console.WriteLine("Error: " + e.ToString());
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(e.StackTrace);

                // return false because it didn't work
                return false;
            }
            finally
            {
                // check to see if the streamreader has been used or not, if so then close the file buffer
                if(streamReader != null)
                    streamReader.Close();
            }
        }

        public void ProcessLine(string line, Employee[] employees, int index)
        {
            // declare aray of parts that will contain the results of splitting 
            // the read in string
            string[] parts = line.Split(',');

            // assign each part to a variable
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);

            // add a new employee into the array that was passed in
            employees[index] = new Employee(firstName, lastName, salary);
        }
    }
}
