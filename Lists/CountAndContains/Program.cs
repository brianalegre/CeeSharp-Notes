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

            // Print marathons with the Count Method
            Console.WriteLine(marathons.Count);

            // Add a value to the marathon list
            marathons.Add(143.23);

            // Check if value was added
            // Print to the console
            Console.WriteLine(marathons.Contains(143.23));

            // Check marathons with Count Method again
            // Checking to see if value increased after the add
            Console.WriteLine(marathons.Count);


        }
    }
}
