// Kyle Sherman
// Updated 1/18/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Employee
    {
        //*****************************
        //* Variable / Backing Fields *
        //*****************************
        private string firstName;
        private string lastName;
        private decimal weeklySalary;



        //*********************************
        //* Properties/ Getters & setters *
        //*********************************
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public decimal WeeklySalary // removing the setter allows the user to get the value of weekly salary but not assign a new one
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }

        //***********
        //* Methods *
        //***********
        public string FirstAndLastName()
        {
            return firstName + " " + lastName;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + WeeklySalary;
        }

        //****************
        //* Constructors *
        //****************
        public Employee() { } // blank constructor

        public Employee(string FirstName, string LastName, decimal WeeklySalary) // constructor that accepts FirstName, LastName, and WeeklySalary
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.weeklySalary = WeeklySalary;
        }
    }
}
