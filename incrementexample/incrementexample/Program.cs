using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incrementexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pre increment and post increment
            int value = 5;
            Console.WriteLine(++value);
            Console.WriteLine(--value);


            //Turnary operators
            Console.WriteLine("Enter age");
            int age = Convert.ToInt32(Console.ReadLine());

            string count= (age>=18) ? "you are eligible to vote": " you are not eligible to vote";
            Console.WriteLine(count);
        }
    }
}
