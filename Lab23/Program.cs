using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Lab 23
// Date: 03/30/2016 2:30:27 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a Constant
            const int
                    HUNDRED = 100;

            //Declare the array
            int[] examScores = new int[HUNDRED];

            //Declare some ints
            int
                i = 0,
                numInputs = 0,
                userInputs = 1;

            //Create a for loop that will store the users input in an array
            do
            {
                //Increment i by 1
                i++;

                //Prompt the user to enter a value
                Console.WriteLine("Please add a Value");

                //Store the value in the array
                examScores[i] = int.Parse(Console.ReadLine());

                //Read what the user has entered to stop the loop when they enter a 0 
                //as well as read how many inputs they provide
                if (examScores[i] != 0)
                    {
                        numInputs++;
                    }
                else
                    {
                        userInputs = 0;
                    }

            } while (userInputs == 1);

            //Display the result from the method that adds the array
            Console.WriteLine($"The product of the values you entered is {AddArray(examScores, numInputs)}");

            //End the console app with a readline
            Console.ReadLine();
        }

        /// <summary>
        /// Adding array method
        /// </summary>
        /// <param name="array"></param>
        /// <returns="arraySum"></returns>
        public static int AddArray(int[] array, int numInputs)
        {
            //Declare loop variable
            int arraySum = 1;

            //Create a for loop to multiple the elements stored in the array
            for (int i = 1; i <= numInputs; i++)
            {
                //Add the array value to the sum
                arraySum *= array[i];
            }

            //return array sum
            return arraySum;
        }
    }
}
