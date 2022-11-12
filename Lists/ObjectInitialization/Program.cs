using System;
using System.Collections.Generic;

namespace LearnLists
{
    class Program
    {
        static void Main()
        {

            // Refactor to use Object Initializtion
            // List<double> marathons = new List<double>();
            // marathons.Add(144.07);
            // marathons.Add(143.12);
            // marathons.Add(146.73);
            // marathons.Add(146.33);

            // Object Initialization
            // Remove the ()
            List<double> marathons = new List<double>
      { 144.07, 143.12, 146.73, 146.73 };

            // Do not delete the code below
            double time = marathons[1];

            Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");

        }
    }
}
