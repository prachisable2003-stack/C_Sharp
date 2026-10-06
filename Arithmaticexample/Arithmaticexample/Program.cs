using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmaticexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("enter principle amount\n");
            int value = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("enter intrest value\n");
            int intrest = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("enter time in year \n");
            int year = Convert.ToInt16(Console.ReadLine());

            int cal = (value * intrest * year) / 100;
            Console.WriteLine("the total intrest is:" + cal);*/


            Console.WriteLine("enter your first name\n");
            string name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("enter your last name\n");
            string lname = Convert.ToString(Console.ReadLine());

            string con = name + lname;
            Console.WriteLine(con);

            string firstname = "prachi";
            string lastname = "Sable";
            Console.WriteLine("FirstName + LastName");



        }
    }
}
