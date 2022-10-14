using System;

namespace BuildingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Array
            // Add [] after the type to create an array
            string[] summerStrut;

            // Set Values To Array
            // Use curly braces to set values
            summerStrut = new string[] {
                "Juice",
                "Missing U",
                "Raspberry Beret",
                "New York Groove",
                "Make Me Feel",
                "Rebel Rebel",
                "Despacito",
                "Los Angeles"
        };

            // Declare and Initialize an Array
            int[] ratings = { 1, 2, 3, 4, 5 };

        }
    }
}

/*

Building Arrays
In C#, arrays are a collection of values that all share the same data type. You could have an array of type string that contains a list of your favorite songs, or an array of type int that stores a collection of user ids.

Similar to defining a variable for one piece of data, when we define a variable to hold an array we also have to specify the type:

// These arrays store ints, strings, and doubles, respectively
int[] x; 
string[] s; 
double[] d; 
To declare a variable that holds an array, we first write the type of data that will be stored in an array, then add the square brackets [] to signify that it is holding an array (rather than a single value), followed by the name of the array.

Like a variable, we can define and initialize an array at the same time, by specifying the values we want to store in it:

int[] plantHeights = { 3, 4, 6 };
To declare and initialize an array at the same time, after the array declaration we use the equal sign to denote we’re storing a value to the array, then write out the numbers we’re putting in the array, separated by commas , and enclosed in curly braces {}.

You may also see arrays defined and initialized using a new keyword:

int[] plantHeights = new int[] { 3, 4, 6 };
The new keyword signifies that we are instantiating a new array from the array class. We’ll cover classes and instantiation in another lesson, but for now you can just think of it as another way to create an array.

In fact, if you decide to define an array and then initialize it later (rather in one line like above) you must use the new keyword:

// Initial declaration
int[] plantHeights;
 
// This works
plantHeights = new int[] { 3, 4, 6 };   
 
// This will cause an error
// plantHeights = { 3, 4, 6 }; 
Instructions
1.
You want to build a web app where users can create their own playlists. The trick is, they can only create playlists that have eight songs on them. You realize that you can use arrays to store information about each playlist as an array.

First, declare a string array called summerStrut. This will be the playlist that we add our songs to.

Checkpoint 2 Passed

Stuck? Get a hint
2.
On a new line, initialize your array with eight song titles as values. If you can’t think of any, here are some suggestions:

Juice
Missing U
Raspberry Beret
New York Groove
Make Me Feel
Rebel Rebel
Despacito
Los Angeles
Checkpoint 3 Passed

Stuck? Get a hint
3.
Next, declare and initialize an array named ratings that contains your rating for each song (between 1 - 5).

*/