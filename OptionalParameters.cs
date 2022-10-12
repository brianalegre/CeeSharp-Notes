using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitPlanets();
            VisitPlanets(4);
            VisitPlanets(5);
        }

        // Set Default Parameter Value To 0 with = 0
        static void VisitPlanets(int numberOfPlanets = 0)
        {
            Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        }
    }
}


/*

Optional Parameters
To make our functions even more flexible, we can make certain parameters optional. If someone calls your method without all the parameters, the method will assign a default value to those missing parameters.

All you have to do is use the equals sign (=) when defining the method. In this example, punctuation is an optional parameter, and its default value is ".".

static void Main(string[] args)
{
  YourMethodName("I'm hungry", "!"); // prints "I'm hungry!"
  YourMethodName("I'm hungry");  // prints "I'm hungry."
}
 
static void YourMethodName(string message, string punctuation = ".")
{
  Console.WriteLine(message + punctuation);
}
 
Instructions
1.
Make the existing parameter in VisitPlanets() optional.

The default value should be 0.

Checkpoint 2 Passed

Stuck? Get a hint
2.
Call the method without the optional parameter in Main().

*/