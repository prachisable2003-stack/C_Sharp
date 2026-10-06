using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inputoutputexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int firstNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int secondnumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Addition of two numbers" + (firstNumber + secondnumber));

            Console.ReadLine();

            Console.WriteLine("Substraction of two numbers" + (firstNumber - secondnumber));

            Console.ReadLine();

            Console.WriteLine("Multiplication of two numbers" + (firstNumber * secondnumber));

            Console.ReadLine();

            Console.WriteLine("division of two numbers" + (firstNumber / secondnumber));

            Console.ReadLine();
        }
    }
}
