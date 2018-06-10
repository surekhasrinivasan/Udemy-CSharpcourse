using System;
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
            //Arthmetic Operators 
            //var a = 10;
            //var b = 3;

            //Console.WriteLine(a + b);

            //returns integer value 
            //Console.WriteLine(a / b);

            //returns float value 
            //Console.WriteLine((float)a / (float)b);

            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine(a + b * c);
            Console.WriteLine((a + b) * c);

            //Comparion operators 
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            //two negatives is equal to one positive
            Console.WriteLine(!(a != b));

            //Logical Operators 
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b && c == a);
            Console.WriteLine(c > b || c == a);
            Console.WriteLine(!(c > b || c == a));
        }
    }
}
