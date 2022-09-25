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

            int[] numbersOneThroughTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

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

            foreach(int i in numbersOneThroughTen)
            {
                if(i%2 == 0)
                {
                    evens.Add(i);
                } else
                {
                    odds.Add(i);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            var spacer = "  ";
            foreach(int i in evens)
            {
                Console.WriteLine(spacer + i);
                spacer += "    ";
            }
            spacer = "";
            foreach(int i in odds)
            {
                Console.WriteLine(spacer + i);
                spacer += "    ";
            }

        }
    }
}
