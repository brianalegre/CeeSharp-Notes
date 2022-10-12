using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

            Console.WriteLine("Type YES or NO");
            string noiseChoice = Console.ReadLine();
            string upperNoiseChoice = noiseChoice.ToUpper();

            if (upperNoiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("THE END");
            }
            else if (upperNoiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
            }

            Console.WriteLine("Type OPEN or KNOCK");
            string doorChoice = Console.ReadLine();
            string upperDoorChoice = doorChoice.ToUpper();

            if (upperDoorChoice == "KNOCK")
            {
                Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \" \"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                Console.WriteLine("Type your answer: ");
                string riddleAnswer = Console.ReadLine();
                string upperRiddleAnswer = riddleAnswer.ToUpper();
                if (upperRiddleAnswer == "NOTHING")
                {
                    Console.WriteLine("The door opens and NOTHING is there.You turn off the light and run back to your room and lock the door. THE END.");
                }
                else
                {
                    Console.WriteLine("You answered incorrectly. The door doesn't open. THE END.");
                }


            }
            else if (upperDoorChoice == "OPEN")
            {
                Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                Console.WriteLine("Enter a number (1-3):");
                string keyChoice = Console.ReadLine();
                string upperKeyChoice = keyChoice.ToUpper();
                switch (upperKeyChoice)
                {
                    case "1":
                        Console.WriteLine("You choose the first key. Lucky choice!The door opens and NOTHING is there. Strange...THE END.");
                        break;
                    case "2":
                        Console.WriteLine("You choose the second key. The door doesn't open. THE END.");
                        break;
                    case "3":
                        Console.WriteLine("You choose the third key. The door doesn't open. THE END.");
                        break;
                    default:
                        Console.WriteLine("DEFAULT");
                        break;
                }

            }
        }
    }
}


/* 

Choose Your Own Adventure
In this project, you’ll use logic and conditional statements to write a classic text-based Choose Your Own Adventure Game. Depending on what choices your user makes, the program will have a different result. If you’re interested in game development, this is a great project to get your started! While we’re only working with text, the principles of user input and control flow are used to build even highly advanced games.

We’ve provided you with a template to write a game, but we highly encourage you to take what you’ve learned here and use your creativity to write an original game, either here on Codecademy or off-platform!

Tasks
19/19 Complete
Mark the tasks as complete by checking them off
Set Up the Program
1.
Take a look at the program in the text editor. We use the command Console.Write() to give instructions to the user, then Console.ReadLine() to get input from the user. We save that input to a variable named name. We can then interpolate the value of that variable in a message we print to the console using Console.WriteLine().

We’ll be using these commands frequently throughout the project, so make sure you’re comfortable with them before moving forward!


Stuck? Get a hint
2.
Let’s start our story. Print the following sentences to the console:

It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?

Stuck? Get a hint
3.
So far, we’ve explained the story and asked our user to make a decision. Let’s give our user some instructions for how to make a decision in this game.

Use Console.Write() to inform the user that they should:

Type YES or NO: 

Stuck? Get a hint
4.
Now we can use Console.ReadLine() to capture the user’s decision. Save the user’s input to a string variable named noiseChoice.


Stuck? Get a hint
5.
What if a user doesn’t type YES, but instead types yes? Modify the noiseChoice variable so that it’s value is uppercase.


Stuck? Get a hint
6.
It’s a good practice to save and run your code every few steps to make sure there are no bugs. In the terminal, type the following command and press Enter on your keyboard:

dotnet run

Stuck? Get a hint
Adding Conditional Statements
7.
We want our program to do something different based on a user’s decision. If they type YES, then we want them to continue on in the game and if they choose NO, we want the game to end.

Write an if statement that checks to see if a user writes NO. If the user picks NO, then have the program print out:

Not much of an adventure if we don't leave our room!
THE END.
Use two Console.WriteLine() statements to break up the text.


Stuck? Get a hint
8.
Write an else if statement that checks to see if a user writes YES.


Stuck? Get a hint
9.
If the condition in the else if statement is true, have it print the following text to the console:

You walk into the hallway and see a light coming from under a door down the hall.
You walk towards it. Do you open it or knock?

Stuck? Get a hint
10.
Now it’s time for our user to make another decision. Let’s tell them what they can type using Console.Write():

Type OPEN or KNOCK:
Save their response to a variable named doorChoice. Make sure to change the value of doorChoice to uppercase.


Stuck? Get a hint
11.
Let’s write another conditional statement based on the user’s choice. Write an if statement for if a user chooses KNOCK and an else if statement for if they choose OPEN.


Stuck? Get a hint
12.
In the if statement, have it print the following text to the console:

A voice behind the door speaks. It says, "Answer this riddle: "
"Poor people have it. Rich people need it. If you eat it you die. What is it?"

Stuck? Get a hint
13.
Using Console.Write(), tell the user to answer the riddle:

Type your answer: 
Save their response to a variable named riddleAnswer.

14.
The correct answer to the riddle is NOTHING. So if a user types NOTHING, the program will print the following to the screen:

The door opens and NOTHING is there.
You turn off the light and run back to your room and lock the door.
THE END.
If a user types anything else, the program will print the following to the screen:

You answered incorrectly. The door doesn't open.
THE END.

Stuck? Get a hint
Adding a Switch Statement
15.
Return to the else if statement that checks to see if doorChoice is equal to OPEN. If the condition is true, have it print the following text to the console:

The door is locked! See if one of your three keys will open it.
16.
Using Console.Write(), get the user to give a number for the key they want to use:

Enter a number (1-3):
Save their response to a string variable named keyChoice. Make sure that the value of keyChoice is always uppercase!

17.
We’re going to use the value of the variable keyChoice for our switch statement case. Write a switch statement that checks to see if a value is equal to either "1", "2", or "3".


Stuck? Get a hint
18.
For each case, print out something to the console to finish the story.

If a user chooses "1", print:

You choose the first key. Lucky choice!
The door opens and NOTHING is there. Strange...
THE END.
If a user chooses "2", print:

You choose the second key. The door doesn't open.
THE END.
If a user chooses "3", print:

You choose the third key. The door doesn't open.
THE END.

Stuck? Get a hint
Run the Program
19.
Let’s run the program! Save the program. Then, in the terminal, type the following command and press Enter:

dotnet run
Try different options. When you hit the end of the program, re-run it and make a different decision than you did before. Keep doing that until you’ve gone through all the possible endings to make sure your program looks correct, no matter what options your user chooses.

If you are feeling ambitious, here are some extensions:

Modify the story and the code to create your very own Choose Your Adventure
Include more cases to check for other user input (what if a user picks a choice you didn’t include?)
Use ternary operators

*/
