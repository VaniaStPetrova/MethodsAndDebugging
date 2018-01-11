using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            methodName(name);
        }

        static void methodName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}

