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
            int[] intNums = new int[10];
            for (int i = 0; i < intNums.Length; i++)
            {
                intNums[i] = i+1;
            }

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach(int i in intNums)
            {
                if(i % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("odd numbers:\n");
            foreach (int i in odds)
            {
                Console.Write($" {i} \t");
            }
            Console.WriteLine("\n");
            Console.WriteLine("even numbers:\n");
            foreach (int i in evens)
            {
                Console.Write($" {i} \t");
            }
            Console.WriteLine("\n");
        }
    }
}
