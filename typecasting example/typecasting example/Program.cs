using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typecasting_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 23.5;
            int value = Convert.ToInt16(price);
            Console.WriteLine(value);

            string number = "1";
            int amount = int.Parse(number);

            int a = 10;
            long b = a;

            int money = 23;
            string updatemoney = Convert.ToString(money);


        }
    }
}
