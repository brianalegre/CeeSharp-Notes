Basic Method Syntax: Where
In method syntax, each query operator is written as a regular method call.

In the last exercise we selected every element with a length under 8. Here it is in method syntax:

string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
var shortHeroes = heroes.Where(h => h.Length < 8);
The where operator is written as the method Where(), which takes a lambda expression as an argument. Remember that lambda expressions are a quick way to write a method. In this case, the method returns true if h is less than 8 characters long.

Where() calls this lambda expression for every element in heroes. If it returns true, then the element is added to the resulting collection.

For example, the shortHeroes sequence from above would be:

[ D. Va, Lucio, Mercy, Pharah ]
Instructions
1.
Write a method-syntax query that selects all of the elements in heroes containing the character "i". Store the result in a variable named heroesWithI.

Checkpoint 2 Passed

Hint
Make sure to use method syntax. Here’s an example that finds all birds containing the letter “g”:

var gBirds = birds.Where(bird => bird.Contains("g"));
2.
Print out all of the elements in heroesWithI to check your work.

Checkpoint 3 Passed

Hint
Use a foreach loop and Console.WriteLine() to print out all of the elements in heroesWithI.