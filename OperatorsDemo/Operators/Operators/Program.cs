﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine(a + b);

            //returns integer value 
            Console.WriteLine(a / b);

            //returns float value 
            Console.WriteLine((float)a / (float)b);
        }
    }
}
