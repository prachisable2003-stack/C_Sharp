using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcuator calculator = new Calcuator();

            Console.WriteLine("Enter the fist number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            calculator.Addition(firstNumber, secondNumber);

            calculator.Substraction(firstNumber,secondNumber);

            calculator.multiplication(firstNumber, secondNumber);

            calculator.Division(firstNumber, secondNumber);

            Console.ReadLine();
        }
    }
}
