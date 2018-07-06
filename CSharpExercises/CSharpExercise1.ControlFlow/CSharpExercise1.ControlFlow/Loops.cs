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

        //Question-3

        // Write a program which takes a single argument from the console, computes the factorial and prints the 
        // value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        // and display it as 5! = 120.

        public void Question3()
        {
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (int i = 1; i <= number; i++)
                factorial *= i;

            //Console.WriteLine("The factorial of " + number + " is: " + factorial);
            Console.WriteLine("{0}! = {1}", number, factorial);
        }

        //Question-4

        // Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
        // If the user guesses the number, display “You won". Otherwise, display “You lost".

        public void Question4()
        {
            var number = new Random().Next(1, 10);

            Console.WriteLine("Magic number: " + number);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the magic number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("You Won");
                    return;
                }                
            }

            Console.WriteLine("You Lost");
        }
    }
}
