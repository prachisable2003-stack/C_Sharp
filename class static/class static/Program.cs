using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_static
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Logger.information("Start main method");
            int result = 10 + 10;
            Console.WriteLine("Result is:" + result);
            Logger.information("end main method");
            Logger.Warning("This code is static");
            double total = 10.0 - 20.5;
            Console.WriteLine("result is:" + total);
            Logger.Error("In static calss object is not created");
           

            
            Employee.EmployeeDetails();
            Employee.salary();
        



               Bankaccount.Holderdetails();
               Bankaccount.Debit();
               Bankaccount.Credit();
         
        }
    }
}
