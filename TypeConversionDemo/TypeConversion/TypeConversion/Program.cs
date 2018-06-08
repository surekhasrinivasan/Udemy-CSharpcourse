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

            //Incompatible types string to integer so we use Convert
            //var number = "1234";
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);

            //coverting string to byte 
            //try
            //{
                //var number = "1234";
                //byte b = Convert.ToByte(number);
                //Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
                //Console.WriteLine("The number could not be converted to a byte");
            //}

            //coverting string to boolean 
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The str could not be converted to a boolean");
            }

        }
    }
}
