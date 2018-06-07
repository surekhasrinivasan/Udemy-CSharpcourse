using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit type conversion
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            //int i = 1000;
            //explicitly type conversion integer to byte
            //byte b = (byte)i;
            //Console.WriteLine(b);

            //Incompatible types
            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);
        }
    }
}
