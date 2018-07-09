using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise2.ArraysandLists
{
    public class Lists
    {
        //Question-1

        //When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.

        // Write a program and continuously ask the user to enter different names, until the user presses Enter 
        // (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

        public void Question1()
        {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Type a name (or hit Enter to quit): ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} like your post.", names[0]);
            else
                Console.WriteLine();
        }

        //Question-2

        // Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        // Display the reversed name on the console.
        
        public void Question2()
        {
            Console.WriteLine("Enter User name: ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversedName = new string(array);
            Console.WriteLine("Reversed name is: " + reversedName);
        }

        //Question-3

        // Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
        // an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
        // and display the result on the console.

        public void Question3()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You have previously entered " + number);
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();

            Console.WriteLine("Sorted numbers: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }                
        }

        //Question-4

        // Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        // include duplicates. Display the unique numbers that the user has entered.

        public void Question4()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number (or type 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers: ");
            foreach (var number in uniques)
                Console.WriteLine(number);            
        }
    }
}
