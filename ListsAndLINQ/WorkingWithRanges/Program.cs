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

            // Use GetRange to get the first 3 elements in marathons list
            // Store the results in a new list
            List<double> topMarathons = marathons.GetRange(0, 3);

            // Loop thru top marathons list and print each value
            // Use the foreach loop
            foreach (var item in topMarathons)
            {
                Console.WriteLine(item);
            }

        }
    }
}
