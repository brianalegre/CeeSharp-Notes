using System;
using System.Collections.Generic;

namespace LearnLists
{
    class Program
    {
        static void Main()
        {
            // Create a list to hold marathon data
            List<double> marathons = new List<double>();

            // Add two values to the newly created list
            marathons.Add(144.07);
            marathons.Add(143.12);

            // Print the second value in the list
            Console.WriteLine(marathons[1]);


        }
    }
}
