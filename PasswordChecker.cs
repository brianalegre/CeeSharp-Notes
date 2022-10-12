using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Define Standards
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "~!@#$%^&*()_+=";

            // Ask The User To Enter A PW
            Console.WriteLine("Please Enter A Password");
            string userPassword = Console.ReadLine();

            // PW Score
            double score = 0;
            if (userPassword.Length >= minLength)
            {
                score++;
                // Print 
                Console.WriteLine("Added A Point, minLength");
            }

            if (Tools.Contains(userPassword, uppercase))
            {
                score++;
                // Print 
                Console.WriteLine("Added A Point, uppercase");
            }
            if (Tools.Contains(userPassword, lowercase))
            {
                score++;
                // Print 
                Console.WriteLine("Added A Point, lowercase");
            }
            if (Tools.Contains(userPassword, digits))
            {
                score++;
                // Print 
                Console.WriteLine("Added A Point, digits");
            }
            if (Tools.Contains(userPassword, specialChars))
            {
                score++;
                // Print 
                Console.WriteLine("Added A Point, specialChars");
            }
            // Print Password Score With Switch Case
            string message = "";
            switch (score)
            {
                case 5:
                    message = "Password is extremely strong";
                    break;
                case 4:
                    message = "Password is extremely strong";
                    break;
                case 3:
                    message = "Password is strong";
                    break;
                case 2:
                    message = "Password is medium";
                    break;
                case 1:
                    message = "Password is weak";
                    break;
                default:
                    message = "The password doesn't meet any of the standards";
                    break;
            }
            Console.WriteLine(message);



        }
    }
}


/* 

Password Checker
A computer can run thousands of operations per minute. If someone wanted to steal your information, they use each operation to make a guess at your password. With one high-performance computer and the right software, a 6 letter single-case password can be broken in one day.

Apart from quitting the internet entirely, what can we do to protect ourselves? We can increase our password’s strength: make it longer and more complex.

In this project you’ll make a program that measures the strength of any given password based on the following criteria. A strong password:

is at least 8 characters long
has lowercase letters
has uppercase letters
has numerical digits
has symbols, like #, ?, !
The program will ask the user to input a password, and using conditional logic and control flow, it will rate the password.

If you plan to do this project on your own computer, outside of Codecademy, make sure to copy the Tools.cs file in addition to Program.cs.

Tasks
11/11 Complete
Mark the tasks as complete by checking them off
Setup
1.
Let’s start by defining all of the standards for a password.

minLength — a number with the minimum length
uppercase — a string with all uppercase letters
lowercase — a string with all lowercase letters
digits — a string with all 10 digits
specialChars — a string made of special characters

Stuck? Get a hint
2.
Now we’ll capture input from the user. Ask the user to enter a password and capture their input in a variable.


Stuck? Get a hint
Test
3.
We’ll score the user’s password: one point for each standard satisfied. Define a variable score to hold their score and set it to 0.


Stuck? Get a hint
4.
If the password is greater than or equal to the minimum length, add a point to the score. Use an if statement.


Stuck? Get a hint
5.
If the password contains uppercase letters, add a point.

We’ve provided a custom tool that checks for certain characters in a string, called Tools.Contains().

Call it like this:

Tools.Contains(target, list);
target would be the password and list would be a string of characters you’d like to check for. If it finds a match, it returns true. If it does not, it returns false.

For example:

Tools.Contains("password", "abc"); // true
Tools.Contains("password", "123"); // false

Stuck? Get a hint
6.
If the password contains lowercase letters, add a point.


Stuck? Get a hint
7.
If the password contains digits, add a point.


Stuck? Get a hint
8.
If the password contains special characters, add a point.


Stuck? Get a hint
9.
Before we move on, make sure everything is working so far.

After the if statements, print the score to the console
Save your work
In the console, enter dotnet run and press Enter
Try the examples in the hint!

Stuck? Get a hint
Tell the User
10.
Now that we’ve determined the password’s score, we need to let the user know how they did.

Use a switch statement to log different messages for different scores:

For scores of 4 and 5, the password is extremely strong
For scores of 3, the password is strong
For scores of 2, the password is medium
For scores of 1, the password is weak
If none of those match, the password doesn’t meet any of the standards

Stuck? Get a hint
11.
Test your program with a few passwords! Here are some examples to use:

word scores a 1. Weak.
woRD scores a 2. Medium.
1woRD scores a 3. Strong.
2woRDsss scores a 4. Extremely strong!
2woRDsss! scores a 5. Extremely strong again!
" " scores a 0. It’s a bunch of spaces…It doesn’t meet any of the standards.
If you want an extra challenge, try adding these requirements:

If the password is password or 1234, give it a score of 0.
If you’re familiar with regular expressions, use them instead of Tools.Contains().

*/