using System;

namespace AlternateExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] spaceRocks = { "meteoroid", "meteor", "meteorite" };

            // Original
            // bool makesContact = Array.Exists(spaceRocks, HitGround);

            // Refactored
            bool makesContact = Array.Exists(spaceRocks, (string s) => s == "meteorite");

            if (makesContact)
            {
                Console.WriteLine("At least one space rock has reached the Earth's surface!");
            }
        }

        static bool HitGround(string s)
        {
            return s == "meteorite";
        }
    }
}


/*

Lambda Expressions
The next shortcut, lambda expressions, are great for situations when you need to pass a method as an argument.

In the past exercise, we used IsEven() to check that an even value exists in the array numbers:

int[] numbers = {1, 3, 5, 6, 7, 8};
 
public static bool IsEven(int num)
{
  return num % 2 == 0;
}
 
bool hasEvenNumber = Array.Exists(numbers, IsEven);
When using the original definition (with curly braces and return), it takes multiple lines to define the IsEven() method and other developers will need to jump around our code to find the definition. With a lambda expression, we can define IsEven() directly in the method call. We don’t even need to give it a name:

bool hasEvenNumber = Array.Exists(numbers, (int num) => num % 2 == 0 );
This might look similar to an expression-bodied definition. It sort of is! What makes a lambda expression unique is that it is an anonymous method: it has no name.

Generally lambda expressions with one expression (like the above example) take this form. They use the fat arrow, no curly braces, and no semicolon (;):

(input-parameters) => expression
Lambda expressions with more than one expression use curly braces and semicolon:

(input-parameters) => { statement; }
Here’s an example of the second structure, which checks if any element in numbers is a multiple of 12 and greater than 20:

bool hasBigDozen = Array.Exists(numbers, (int num) => {
  bool isDozenMultiple = num % 12 == 0;
  bool greaterThan20 = num > 20;
  return isDozenMultiple && greaterThan20;
});
Since this lambda expression includes multiple expressions (3 in this case), then we must use curly braces and semicolons.

Instructions
1.
Find the line where Array.Exists() is used.

Replace HitGround with a lambda expression that achieves the same result. It should return true if its input equals "meteorite".

Checkpoint 2 Passed

Hint
You can find the original HitGround() definition at the bottom of the file.

Here’s an example lambda expression:

bool hasEvenNumber = Array.Exists(numbers, (int num) => num % 2 == 0 );

*/