
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_static
{
    public static class Logger
    {
        public static void information(string message)
        {
            Console.WriteLine($"INFO: {message}");
        }
        public static void Warning(string message)
        {
            Console.WriteLine($"Warning: {message}");
        }
        public static void Error(string message)
        {
            Console.WriteLine($"Error: {message}");
        }
    }
}
