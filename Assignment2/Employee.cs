using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_3280_Assignment2_CWinkley
{
    class Employee
    {

        private string firstName;
        private string lastName;
        private double Wage;
        private double HoursWorked;

        /*
        public Employee(string firstName, string lastName, double wage, double hworked)
        {

         var fName = firstName;
         var lName = lastName;
         var hourlyWage = wage;
         var hoursWorked = hworked;
        }
        */
        public void SetFirstName(string fname)
        {
             firstName = fname;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetLastName(string lName)
        {
           lastName = lName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetWage(double hourlyWage)
        {
            Wage = hourlyWage;
        }

        public double GetWage()
        {
            return Wage;
        }

        public void SetHoursWorked(double hours)
        {
            HoursWorked = hours;
        }

        public double GetHoursWorked()
        {
            return HoursWorked;
        }
        

    }
}
