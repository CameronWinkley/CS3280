/*
 * Cameron Winkley - Assignment2
 * CS3280 - Summer Semester 2018
 * 
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

namespace CS_3280_Assignment2_CWinkley
{
    class Program
    {
        public static void Main(string[] args)
        {
            var continueloop = true;

            do 
            {

                Employee myEmployee = new Employee();


                Console.Write("Please enter in the Employee's first name: ");
                string fName = Console.ReadLine();
                myEmployee.SetFirstName(fName);
                //Console.WriteLine(myEmployee.GetFirstName());

                Console.Write("Please enter in the Employee's last name: ");
                string lastName = Console.ReadLine();
                myEmployee.SetLastName(lastName);
                //Console.WriteLine(myEmployee.GetLastName());
                try
                {
                    Console.WriteLine("please enter in a whole integer");

                    Console.Write("Please enter in Employee's hourly rate: ");
                    var wage = double.Parse(Console.ReadLine());
                    myEmployee.SetWage(wage);
                    //Console.WriteLine(myEmployee.GetWage());

                    Console.Write("Please enter in number of hours worked: ");
                    double hoursworked = double.Parse(Console.ReadLine());
                    myEmployee.SetHoursWorked(hoursworked);
                    //Console.WriteLine(myEmployee.GetHoursWorked());
                    continueloop = false;
                }

                catch (FormatException e)
                {   
                    Console.Write($"\n{e.Message}");
                    Console.Write("please enter in a numeric value", e);
                }
                SalaryCalculator mySalary = new SalaryCalculator();
                if (myEmployee.GetHoursWorked() > 40)
                {
                    Console.WriteLine(
                        (myEmployee.GetFirstName() + " worked " + myEmployee.GetHoursWorked() + " hours "));
                    Console.WriteLine("Gross pay is $" +
                                      mySalary.OverTimeCheck(myEmployee.GetWage(), myEmployee.GetHoursWorked()));
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(myEmployee.GetFirstName() + " worked " + myEmployee.GetHoursWorked() + " hours ");
                    Console.WriteLine("Gross pay is $" +
                                      mySalary.PayCheck(myEmployee.GetWage(), myEmployee.GetHoursWorked()));
                    Console.ReadKey();
                }

                
                } while (continueloop);



        }
            

        }
        
    }

