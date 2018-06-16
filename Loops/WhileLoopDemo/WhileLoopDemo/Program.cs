using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //for ( var i = 1; i <=10; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //var i = 0;
            //while(i <= 10)
            //{
            //    if (i%2 == 0)
            //        Console.WriteLine(i);
            // i++;
            //}
            //Typically while is used when we are not sure how many times to loop

            //while (true)
            //{
            //    Console.Write("Type you name: ");
            //    var input = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(input))
            //        break;

            //    Console.WriteLine("@Echo: " + input);
            //}

            while (true)
            {
                Console.Write("Type you name: ");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }
        }
    }
}
