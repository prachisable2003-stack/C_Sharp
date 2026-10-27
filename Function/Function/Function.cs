using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class Function
    {
        public void Cal(int firstvalue, int secondvalue, char operatorkey)
        {
            if (operatorkey == '+')
            {
                Console.WriteLine("Addition of two numbers : "+ (firstvalue + secondvalue));
            }
            else if (operatorkey == '-')
            {
                Console.WriteLine("Substraction of two numbers" + (firstvalue - secondvalue));
            }
            else if (operatorkey == '*')
            {
                Console.WriteLine("Multiplication of two numbers :" + (firstvalue * secondvalue));
            }
            else if (operatorkey == '/')
            {
                Console.WriteLine("Division of two numbers" + (firstvalue / secondvalue));
            }
        }
            public void  displayname()
            {
                Console.WriteLine("Prachi");
            }
            public void  displyname(string name)
            {
                Console.WriteLine("Enter the name" + name);
            }
            public string displyname()
             {
                return "name";
             }

        public string displayname(string name)
        {
            return name;
        }


        }
    }

