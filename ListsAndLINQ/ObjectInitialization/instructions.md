Object Initialization
Our first way to create lists and add items took multiple lines:

List<string> citiesList = new List<string>();
citiesList.Add("Delhi");
citiesList.Add("Los Angeles");
We can do it all in one line using object initialization:

List<string> citiesList2 = new List<string> { "Delhi", "Los Angeles" };
We won’t cover everything about object initialization in this lesson, but you do need to recognize and use it.

Basic construction uses parentheses ( ) and no values.
Object initialization uses curly braces { } and the actual values go in-between.
If we need to add elements to that second list later, we can still use Add():

citiesList2.Add("Kyiv");
Instructions
1.
The current code creates an empty list and uses Add() to add elements.

Delete those lines and make the same list with an object initialization.

Checkpoint 2 Passed

Hint
Here’s an example that uses object initialization to create a birds list. Notice the use of curly braces { } in place of parentheses ( ):

List<string> birds = new List<string> { "toucan", "eagle" };
In case you lose the values in marathons, here they are again:

144.07, 143.12, 146.73, 146.33