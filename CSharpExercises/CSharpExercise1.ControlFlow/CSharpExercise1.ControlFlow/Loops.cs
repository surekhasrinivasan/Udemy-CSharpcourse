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

        //Question-2

        // Write a program and continuously ask the user to enter a number. The loop terminates when the user 
        // enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.

        public void Question2()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);                                
            }
            Console.WriteLine("Sum of all the entered numbers is: " + sum);
        }
    }
}
