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

        //Question-4

        // Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        // etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        // the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        // display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        // demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        // the console. If the number of demerit points is above 12, the program should display License Suspended.

        public void Question4()
        {
            Console.WriteLine("Enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("what is the speed of the car?");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
                Console.WriteLine("Speed OK");
            
        }
    }
}
