Creating and Adding
A list is a sequential data structure that can hold any type. Like arrays, you can use them to store any sequential information, like the letters of the alphabet, comments on a blogpost, the finishing times for a horse race, or items on a restaurant menu.

You create a list using the new keyword, like you would create any other class. You specify the type of element inside angle brackets: < >. In this example, the list is named citiesList and it holds instances of the type string.

List<string> citiesList = new List<string>();
You can add elements to the list using the Add() method:

citiesList.Add("Delhi");
You can access elements using indices and square brackets:

string city = citiesList[0];
You can also re-assign elements using bracket notation:

citiesList[0] = "New Delhi";
In order to use lists, you’ll need to add this to the top of your file. We’ll explain this in detail later:

using System.Collections.Generic;
Instructions
1.
Create a list to hold the top women’s marathon times in minutes. Create an empty list of type double and store it in a variable marathons.

Checkpoint 2 Passed

Stuck? Get a hint
2.
Jemima Sumgong won the 2016 marathon in Rio de Janeiro with a time of 144.07 minutes and Tiki Gelana won the 2012 marathon in London with a time of 143.12 minutes. (That’s just 2 hours 23 minutes and 7.2 seconds!)

Use two Add() statements to add those values to the list.

Checkpoint 3 Passed

Hint
Here’s an example that adds the string "toucan" to the list of birds:

birds.Add("toucan");
3.
Print the second value in the list to the console.