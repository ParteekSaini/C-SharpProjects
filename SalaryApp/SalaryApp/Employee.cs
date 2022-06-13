using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryApp
{
    class Employee
    {
        public string EmployeeFN
        {
            get; set;
        }
        public string EmployeeLN
        {
            get; set;
        }
        public string EmployeeID
        {
            get; set;
        }
        public string EmployeeType
        {
            get; set;
        }
        public double SalaryAmount
        {
            get; set;
        }
        public double TotalHours
        {
            get; set;
        }
        public double HourRate
        {
            get; set;
        }
        public double HourlySalaryCalclator
        {
            get
                
            {
                double totalSalary=0;
                if (TotalHours <= 40)
                {
                    totalSalary = HourRate * TotalHours;
                }
                else
                {
                    totalSalary = HourRate * 40 + (HourRate * 1.5) *(TotalHours - 40);
                }
                return totalSalary;
            }
        }
        public double Taxes
        {
            get
            {
                double taxes=0;
                if (EmployeeType == "salaried")
                {
                    taxes = SalaryAmount * 18 / 100;
                }
                if (EmployeeType == "hourly")
                {
                    taxes = HourlySalaryCalclator * 18 / 100;
                }
                return taxes;
            }
        }
        public double SocialSecurityTax
        {
            get
            {
                double socialSecurityTax = 0;
                if (EmployeeType == "salaried")
                {
                    socialSecurityTax= SalaryAmount * 6 / 100;
                }
                if(EmployeeType == "hourly")
                {
                    socialSecurityTax = HourlySalaryCalclator * 6 / 100;
                }
                return socialSecurityTax;
            }
            
        }
        public double NetSalary
        {
            get
            {
                double netSalary = 0;
                if (EmployeeType == "salaried")
                {
                    netSalary = SalaryAmount - Taxes - SocialSecurityTax;
                }
                if (EmployeeType == "hourly")
                {
                    netSalary = HourlySalaryCalclator - Taxes - SocialSecurityTax;
                }
                return netSalary;
            }
        }
        public Employee(string firstName,string lastName, string iD,string type,double salaryAmount)
        {
            EmployeeFN = firstName;
            EmployeeLN = lastName;
            EmployeeID = iD;
            EmployeeType = type;
            SalaryAmount = salaryAmount;
        }
        public Employee(string firstName, string lastName, string iD, string type, double totalHour
                        , double hourRate)
        {
            EmployeeFN = firstName;
            EmployeeLN = lastName;
            EmployeeID = iD;
            EmployeeType = type;
            TotalHours = totalHour;
            HourRate = hourRate;
        }
        public override string ToString()
        {
            string outputStr;
            if (EmployeeType == "salaried")
            {
                outputStr = string.Format("\n{0,35}: {1}\n", "First Name", EmployeeFN);
                outputStr += string.Format("{0,35}: {1}\n", "Last Name", EmployeeLN);
                outputStr += string.Format("{0,35}: {1}\n", "EmployeeID", EmployeeID);
                outputStr += string.Format("{0,35}: {1}\n", "Employee Type", EmployeeType);
                outputStr += string.Format("{0,35}: {1:C}\n", "Gross Salary Amount", SalaryAmount);
                outputStr += string.Format("{0,35}: {1:C}\n", "Taxes", Taxes);
                outputStr += string.Format("{0,35}: {1:C}\n", "Social Security Tax", SocialSecurityTax);
                outputStr += string.Format("{0,35}: {1:C}\n", "Net Salary Amount after deduction", NetSalary);
            }
            else
            {
                outputStr = string.Format("{0,35}: {1}\n", "First Name", EmployeeFN);
                outputStr += string.Format("{0,35}: {1}\n", "Last Name", EmployeeLN);
                outputStr += string.Format("{0,35}: {1}\n", "EmployeeID", EmployeeID);
                outputStr += string.Format("{0,35}: {1}\n", "Employee Type", EmployeeType);
                outputStr += string.Format("{0,35}: {1:C}\n", "Gross Salary Amount", HourlySalaryCalclator);
                outputStr += string.Format("{0,35}: {1:C}\n", "Taxes", Taxes);
                outputStr += string.Format("{0,35}: {1:C}\n", "Social Security Tax", SocialSecurityTax);
                outputStr += string.Format("{0,35}: {1:C}\n", "Net Salary Amount after deduction", NetSalary);


            }
            return outputStr;
        }
    }
}
