using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classexample
{
    public class Calcuator
    {
        public void Addition(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine("The result of addition is:"+result);
        }
        public void Substraction(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            Console.WriteLine("The result of substraction is:" + result);
        }
        public void multiplication(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            Console.WriteLine("The result of multiplication is:" + result);
        }
        public void Division(int firstNumber, int secondNumber)
        {
            if(secondNumber==0)
            {
                Console.WriteLine("Enter division by zero is not allowed");
                return;
            }
            double result = (double)firstNumber / secondNumber;
            Console.WriteLine("The result of division is:" + result);
        }
       

    }
}
