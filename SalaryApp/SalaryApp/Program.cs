using System;
using static System.Console;

namespace SalaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char userinput = 'y';
            while (userinput == 'y')
            {
            GetEmployeeDetails(out string FirstName, out string LastName,
                                          out string ID, out string Type);
            if (Type == "salaried") 
            {
                GetSalariedEmployeeDetails(out double salaryamout);
                Employee Salariedobject = new Employee(FirstName,LastName,ID,Type,salaryamout);
                WriteLine(Salariedobject.ToString());
            }
            else
            {
                GethourlyEmployeeDetails(out double hours, out double hourRate);
                Employee Salariedobject = new Employee(FirstName, LastName, ID, Type,hours,hourRate);
                WriteLine(Salariedobject.ToString());
            }
                Write("Do you want to continue with another employee(Press y for yes or n for no): ");
                while(!char.TryParse(ReadLine(),out userinput)||(userinput!='y'&&userinput!='n'))
                {
                    Write("Please re-enter your response: ");
                }
            }
            if (userinput == 'n')
            {
                Clear();
                WriteLine("Thank you for using the application...");
            }
            ReadKey();

        }
        static void GetEmployeeDetails(out string FirstName, out string LastName,
                                          out string ID,out string Type )
        {
            Write("Enter Employee First name: ");
            FirstName = ReadLine();

            Write("Enter Employee Last Name: ");
            LastName = ReadLine();

            Write("Enter Employee ID: ");
            ID = ReadLine();

            Write("Enter Employee Type(Enter hourly or salaried for respective fields): ");
            Type = ReadLine();
            while (Type != "hourly" && Type!= "salaried")
            {
                Write("Please re-enter the Employee Type(Note-Exectly enter salaried or hourly): ");
                Type = ReadLine();
            }
        }
        static void GetSalariedEmployeeDetails(out double salaryamout)
        {
            Write("Enter Salary amount: ");
            while(!double.TryParse(ReadLine(),out salaryamout) || salaryamout <= 0)
            {
                Write("Please re-enter the salary amount: ");
            }
        }
        static void GethourlyEmployeeDetails(out double hours,out double hourRate)
        {
            Write("Enter Total hours: ");
            while (!double.TryParse(ReadLine(), out hours) || hours <= 0)
            {
                Write("Please re-enter the total hours: ");
            }
            Write("Enter Hour Rate: ");
            while (!double.TryParse(ReadLine(), out hourRate) || hourRate <= 0)
            {
                Write("Please re-enter the hour rate: ");
            }
        }
    }
}
