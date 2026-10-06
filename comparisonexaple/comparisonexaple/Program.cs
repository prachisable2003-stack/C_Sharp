using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparisonexaple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a marks:");
            int marks = Convert.ToInt16(Console.ReadLine());

           /* if(age >=18)
            {
                Console.WriteLine("You are eligible for voting");
            }
            else
            {
                Console.WriteLine("you are not eligible for voting");
            }*/

            if(marks > 25 && marks < 50)
                    {
                Console.WriteLine("You are passed");
            }
            else if(marks >51 && marks < 70)
                    {
                Console.WriteLine("You are A distinction");
            }
            else if (marks > 71 && marks < 90)
                    {
                Console.WriteLine("you are A+ distinction");
            }
            else
            {
                Console.WriteLine("Fail");
            }


        }
    }
}
