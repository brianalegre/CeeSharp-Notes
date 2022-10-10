using System;

namespace GettingInput
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old!");
        }
    }
}

// Console.ReadLine()
// Gets input from the user
// JS Equivalent: prompt()


/*

HELLO WORLD
Getting Input
We can also read input from a user. The command Console.ReadLine() captures text that a user types into the console.

Program: How old are you? User: 16 Program: You are 16 years old!
In this example, the program writes a question to the console and waits for user input. Once the user types something and presses Enter (or Return), the input is printed back out to the user.

Console.WriteLine("How old are you?");
string input = Console.ReadLine();
Console.WriteLine($"You are {input} years old!");
The word input represents a variable (variables are explored more in other lessons). For now, know that the word input represents the text the user typed in the console. It’s labeled string because, in C#, a piece of text is called a string.

input is used in the following line so that the printed message will change based on what the user types. For example, if you ran the program and responded to the question with 101, then the value of input would be "101" and You are 101 years old! would be printed to the console.

*/