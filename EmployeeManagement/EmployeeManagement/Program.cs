using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManagement employeeManagement = new EmployeeManagement();
            employeeManagement.Employeedetails();
            employeeManagement.Salary();
            Console.ReadLine();
        }
    }
}
