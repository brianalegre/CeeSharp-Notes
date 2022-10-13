using System;

namespace OutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            string ageAsString = "102";
            string nameAsString = "Granny";
            int ageAsInt;
            bool outcome;

            outcome = Int32.TryParse(ageAsString, out ageAsInt);
            Console.WriteLine(outcome);
            Console.WriteLine(ageAsInt);

            int nameAsInt;
            bool outcome2;

            outcome2 = Int32.TryParse(nameAsString, out nameAsInt);

            Console.WriteLine(outcome2);
            Console.WriteLine(nameAsInt);

        }
    }
}


/*

Out
A method can only return one value, but sometimes you need to output two pieces of information. Calling a method that uses an out parameter is one way to return multiple values.

For example, the Int32.TryParse() method tries to parse its input as an integer. If it can properly parse the input, the method returns true and sets its out variable to the new value. If it cannot properly parse the input, the method returns false and sets the out variable to 0.

This is what the method’s signature looks like:

public static bool TryParse (string s, out int result);
The method returns a boolean and accepts a string and a variable that has been declared of type int as input.

Here’s how Int32.TryParse() and the out parameter are used:

int number;
bool success = Int32.TryParse("10602", out number); 
// number is 10602 and success is true
int number2;
bool success2 = Int32.TryParse(" !!! ", out number2);
// number2 is 0 and success2 is false
The second parameter is labeled out, which means that it must be assigned a value within the method.

For a shortcut, you can declare the int variable within the method call:

bool success = Int32.TryParse("10602", out int number);
Instructions
1.
Let’s parse another string ageAsString to an integer.

First, define:

an int named ageAsInt
a bool named outcome
Checkpoint 2 Passed

Stuck? Get a hint
2.
First, use Int32.TryParse() to convert ageAsString:

ageAsInt should be used as the out argument
outcome should capture the returned value
Checkpoint 3 Passed

Stuck? Get a hint
3.
Print outcome and ageAsInt to the console.

Checkpoint 4 Passed
4.
Repeat the process with nameAsString:

Define:

an int named nameAsInt
a bool named outcome2
Use Int32.TryParse() to convert nameAsString:

nameAsInt should be used as the out argument
outcome2 should capture the returned value
Print the returned value and the out variable to the console.

*/