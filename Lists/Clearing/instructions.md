Clearing
If we need to remove all of the elements from a list, we could iterate through the entire list and call Remove(). The easier way is to use the Clear() method.

List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Kyiv" };
citiesList.Clear();
 
Console.WriteLine(citiesList.Count);
// Output: 0
Instructions
1.
The marathons list has a bunch of old values that we need to remove.

Use Clear() to remove all of them.