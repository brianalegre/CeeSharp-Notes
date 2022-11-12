Count and Contains
We can check on the status of our list in two ways.

We can find the number of elements in the list using the Count property:

List<string> citiesList = new List<string> { "Delhi", "Los Angeles" };
int numberCities = citiesList.Count;
// numberCities is 2
We can check if an element exists in a list using the Contains() method:

bool hasDelhi = citiesList.Contains("Delhi");
bool hasDubai = citiesList.Contains("Dubai");
// hasDelhi is true, hasDubai is false
Instructions
1.
The list marathons has been initialized for you. Print the Count to the console.

Checkpoint 2 Passed

Stuck? Get a hint
2.
In the 2000 Sydney Olympic Games, Naoko Takahashi won the marathon with a time of 143.23 minutes (the Olympic record until 2012 in London).

Use Add() to add that value to the list.

Checkpoint 3 Passed

Stuck? Get a hint
3.
Make sure that 143.23 was added to the list. Call the Contains() method and print the returned value to the console.

Checkpoint 4 Passed
4.
Print Count again. Make sure it increased to 5!