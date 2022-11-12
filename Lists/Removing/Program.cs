using System;
using System.Collections.Generic;

namespace LearnLists
{
    class Program
    {
        static void Main()
        {
            List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };

            // Print the second element in marathons list
            Console.WriteLine(marathons[1]);

            // Remove 143.12 from the marathons list
            // Store the result in a bool
            bool removed = marathons.Remove(143.12);

            // Print the second element again in marathons list
            // Also print the value of the bool created earlier
            // This is to verify remove worked
            Console.WriteLine(marathons[1]);
            Console.WriteLine(removed);



        }
    }
}
