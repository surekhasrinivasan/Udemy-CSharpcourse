using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise1.ControlFlow
{
    public class Conditionals
    {
        //Question-1
        
        //Write a program and ask the user to enter a number.The number should be between 1 to 10. If the user enters
        // a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
        // applications where values entered into input boxes need to be validated.)
        
        public void Question1()
        {
            Console.WriteLine("Enter a number between 1 to 10: ");
            var userInput = Console.ReadLine();
            var number = Convert.ToInt32(userInput);
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Number Valid");
            }
            else
            {
                Console.WriteLine("Number Invalid");
            }
        }

        //Question-2

        // Write a program which takes two numbers from the console and displays the maximum of the two.

        public void Question2()
        {
            Console.WriteLine("Enter a number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 > num2)
            //    Console.WriteLine("Maximum of two numbers is: " + num1);
            //else
            //    Console.WriteLine("Maximum of two numbers is: " + num2);

            var max = (num1 > num2) ? num1 : num2;
            Console.WriteLine("Maximum of two numbers is: " + max);
        }

        //Question-3

        // Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        // is landscape or portrait.

        public void Question3()
        {
            Console.WriteLine("Enter the image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            //if (width > height)
            //    Console.WriteLine("Image orientation is landscape");
            //else
            //    Console.WriteLine("Image orientation is portrait");
            var orientation = (width > height) ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image Orientation is: " + orientation);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
    }
}
