using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Surekha";
            var lastName = "Srinivasan";

            var fullName = firstName + " " + lastName;
            //Console.WriteLine(fullName);
            
            var myFullName = string.Format("My name is {0}, {1}", firstName, lastName);
            //Console.WriteLine(myFullName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);

            //Console.WriteLine(formattedNames);

            var text = @"Hi John
Look into the following paths
C:\folder1\folder2
C:\folder3\folder4";
Console.WriteLine(text);
        }
    }
}
