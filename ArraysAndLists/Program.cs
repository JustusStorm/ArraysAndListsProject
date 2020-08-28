using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numsList = new int[10];
            var nums = 1;
            for (var i = 0; i < numsList.Length; i++)
            {
                numsList[i] = nums;
                nums++;
            }


            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (var num in numsList)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("List of even numbers:");
            var index = 0;
            foreach (var num in evens)
            {
                Console.WriteLine($"Index {index}   =>   {num}");
                index++;
            }
            
            Console.WriteLine("\nList of odd numbers:");
            foreach (var num in odds)
            {
                Console.WriteLine($"Index {index}   =>   {num}");
                index++;
            }
            Console.ReadKey();



        }
    }
}
