using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class Program
    {
        static void Main(string[] args)
        {
                {
                Function function = new Function();
                function.displayname();
                function.displayname("Prachi");
                function.displayname();
                function.displayname("Prachi");


                function.Cal(5,10,'+');
                function.Cal(30, 10, '-');
                function.Cal(20, 10, '*');
                function.Cal(20, 10, '/');

            }
        }
    }
}
