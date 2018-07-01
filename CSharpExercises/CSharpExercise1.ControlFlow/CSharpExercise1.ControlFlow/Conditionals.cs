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
    }
}
