using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            string name;
            char grade;
            grade = 'A';
            Console.WriteLine(grade);

            bool status;
            status = true;
            Console.WriteLine(status);
            DateTime date;
            date = DateTime.Now;
            Console.WriteLine(date);

            //float data type
            float price;
            price = 10.7f;
            Console.WriteLine(price);

            //Decimal data type

            decimal amount;
            amount = 100.0m;
            Console.WriteLine(amount);

        }
    }
}
