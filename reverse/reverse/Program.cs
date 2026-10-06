using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            Console.WriteLine("The value of number is:" + number);

            string name = "prachi";
            Console.WriteLine("\nUpper case : " + name.ToUpper());
            Console.WriteLine("\nLower case : " + name.ToLower());
            Console.WriteLine("\ntrim : " + name.Trim());
            Console.WriteLine("\ntrim start :" + name.TrimStart());
            Console.WriteLine("\ntrim end :" + name.TrimEnd());
            Console.WriteLine("\ntotal char is : " + name.length);

            char[] arr = name.ToCharArray();
            int start = 0;
            int end = arr.length - 1;
            while (start < end)
            {
                char temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            string reverse = new string(arr);

            Console.WriteLine("The reverse" + reverse());
        }
    }
}
