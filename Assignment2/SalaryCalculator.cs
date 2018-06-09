using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_3280_Assignment2_CWinkley
{
    class SalaryCalculator

    {
        
        public double PayCheck(double wage, double hoursworked)
        {
            var payCheck = wage * hoursworked;
            return payCheck;
        }

        public double OverTimeCheck(double wage, double hoursworked)

        {
            
            var totalHours = hoursworked;
            var otHours = totalHours - 40;
            var regHours = totalHours - otHours;

            var regWage = wage;
            var otWage = (wage * 1.5);

            var regularSalary = regHours * regWage;
            var otPay = (otHours * otWage);
            var otSalary = regularSalary + otPay;
            
            return  otSalary;


        }
    }
}
