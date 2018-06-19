using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Surekha Srinivasan ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Surekha", "Sue"));

            //if (String.IsNullOrEmpty(null))
            //    Console.WriteLine("Invalid");

            //if (String.IsNullOrEmpty(" ".Trim()))
            //    Console.WriteLine("Invalid");

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            //conversion of string to byte or int
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine("Age: " + age);

            //conversion of float to string with currency symbol with/without decimal points
            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));
        }
    }
}
