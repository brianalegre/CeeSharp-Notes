using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program ... Mad Labs
            Author: ... Brian Alegre
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Starting the Mad Labs");

            // Give the Mad Lib a title:
            string title = "Maddest Labs";

            Console.WriteLine(title);
            // Define user input and variables:
            // Name
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            // Adjectives
            Console.WriteLine("Give me an adjective");
            string adjective1 = Console.ReadLine();
            Console.WriteLine("Another adjective");
            string adjective2 = Console.ReadLine();
            Console.WriteLine("And... one last adjective");
            string adjective3 = Console.ReadLine();

            // Verbs
            Console.WriteLine("Give me a verb");
            string verb1 = Console.ReadLine();
            Console.WriteLine("Another verb");
            string verb2 = Console.ReadLine();
            Console.WriteLine("And... one last verb");
            string verb3 = Console.ReadLine();

            // Nouns
            Console.WriteLine("Give me a noun");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Another noun");
            string noun2 = Console.ReadLine();

            // Random Words
            Console.WriteLine("Give me an animal");
            string animal = Console.ReadLine();
            Console.WriteLine("Favorite food");
            string food = Console.ReadLine();
            Console.WriteLine("Most hated fruit");
            string fruit = Console.ReadLine();
            Console.WriteLine("Weakest superhero");
            string superhero = Console.ReadLine();
            Console.WriteLine("A Country you'd like to visit");
            string country = Console.ReadLine();
            Console.WriteLine("Favorite dessert");
            string dessert = Console.ReadLine();
            Console.WriteLine("What year were you born?");
            string year = Console.ReadLine();







            // The template for the story:

            string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb1} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);

        }
    }
}


/* 

Mad Libs
In C#, variables and string interpolation allow us to transform a piece of text by swapping out different pieces of information.

In this project, we’ll use C# to write a Mad Libs word game! Mad Libs are short stories with blanks for the player to fill in that represent different parts of speech. The end result is a really hilarious and strange story.

Here’s an example of the “Roses are Red” poem changed into a Mad Lib:

roses are red

Mad Libs require: A short story with blank spaces (asking for different types of words). Words from the player to fill in those blanks.

For this project, we have provided the story, but it will be up to you to complete the following: Prompt the user for inputs. Print the story with the inputs in the right places.

It’s important to note that for this project, you should test your app periodically — when you hit save, your app will not run! To run your app, enter dotnet run into the terminal.

dotnet

Let’s begin!

Tasks
14/14 Complete
Mark the tasks as complete by checking them off
MadLibs Set Up
1.
Begin by completing the multi-line comment that describes this program.


Stuck? Get a hint
2.
Inform the user that the program is running. You need to be constantly thinking from the users’ point of view – they are the ones who run your program. Make sure that your program is easy for others to understand!

Before the string story, print a message to let the user know that Mad Libs has started.


Stuck? Get a hint
3.
Give your story a title. Change the value of the variable title to a title that you like.


Stuck? Get a hint
4.
Take a look at the string variable named story. It is set equal to a string that contains our story.

Creating the Variables
5.
Now we’re going to start creating the variables that we will use in our story. Make sure to declare all of your variables above the variable story, otherwise you won’t be able to use them in the story!

The story that we have provided is going to need a main character. Ask the user to input a name, and store the user’s input in a variable with a string type:

Console.Write("Enter a name: ");
string name = Console.ReadLine();
Note: It’s good practice to use short, but descriptive variable names.


Stuck? Get a hint
6.
You will need to ask the user for three adjectives. An adjective is a word that describes a noun, like a color (‘blue’), or feeling (‘silly’), texture (‘soft’).

Ask the user for input three separate times. Store each adjective that the user inputs into variables with descriptive names, like you did when you asked the user for a name.


Stuck? Get a hint
7.
It’s a good practice to save and run your code every few steps to make sure there are no bugs. In the terminal, type the following command and press Enter on your keyboard: dotnet run


Stuck? Get a hint
8.
Moving on! You’ll also need to ask the user for one verb. A verb is a word that represents an action, like ‘sit’, ‘eat’, ‘sleep’

Ask the user to input a verb and store their response in a variable.

9.
The story also needs two nouns. A noun is a person (‘girl’), place (‘cabin’), or thing (‘toaster’).

Ask the user to input two nouns. Store each noun in its own variable.

10.
This is where the story can get really fun and weird. Ask the user to input one of each of the following:

An animal
A food
A fruit
A superhero
A country
A dessert
A year
Make sure to save the inputs into different variables. Run your code again to make sure you have everything in place before the next task!

Using String Interpolation
11.
At this point, we have all the words needed for the story. Great job!

The next step is to insert all of the user’s inputs into the blank spaces of the story using string interpolation.

Put a $ in front of the first quotation mark " in story and replace each underscore _ with a set of empty braces{}.


Stuck? Get a hint
12.
Write the names of each variable inside of the brackets. Here’s the order that they should appear in:

Name
First adjective
Second adjective
Animal
Food
Verb
First noun
Fruit
Third adjective
Name
Superhero
Name
Country
Name
Dessert
Name
Year
Second noun

Stuck? Get a hint
Complete and Run the Program
13.
Write a line of code that prints out the completed story to the terminal.


Stuck? Get a hint
14.
Let’s run the program!

Save the program. Then, in the terminal, type the following command and press Enter:

dotnet run

*/