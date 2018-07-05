using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise1.ControlFlow
{
    public class Loops
    {
        //Question-1

        // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        // Display the result on the console.

        public void Question1()
        {
            var count = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100", count);
        }
    }
}
