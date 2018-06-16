using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var name = "Surekha Srinivasan";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach for string
            //foreach(var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            //foreach for numbers
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
