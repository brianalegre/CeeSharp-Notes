using System;

namespace DocumentationHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            // Array.Copy()
            // Create Array to hold 8 elements
            string[] summerStrutCopy = new string[8];

            // Copy summerStrut Elements to summerStrutCopy
            // First Param, Source
            // Second Param, Destination
            // Third Param, How many elements
            Array.Copy(summerStrut, summerStrutCopy, 8);

            // Print First Element
            Console.WriteLine(summerStrutCopy[0]);


            // Array.Reverse()
            // Reverses the order summerStrut
            // summerStrut has been mutated
            Array.Reverse(summerStrut);

            // Print First and Last 
            Console.WriteLine(summerStrut[0]);
            Console.WriteLine(summerStrut[7]);


            // Array.Clear()
            // First Param - Source
            // Second Param - Starting Index
            // Third Param - Number of elements to clear
            Array.Clear(ratings, 0, ratings.Length);
            Console.WriteLine(ratings[0]);


        }
    }
}


/*

Documentation Hunt
In addition to Sort(), IndexOf(), and Find(), there are several other built-in methods for arrays. You can find them (and you probably guessed it) in the Microsoft documentation.

Let’s put your documentation sleuthing to use and hunt down some built-in methods to write some code!

Instructions
1.
In the Microsoft documentation, find the method that allows you to copy your playlist to a new playlist called summerStrutCopy. Print the first value of summerStrutCopy to the playlist to see if is the same as summerStrut.

Checkpoint 2 Passed

Hint
Array.Copy() (documentation) copies a range of elements from one array to a second array. It takes three parameters: the name of the array to be copied, the new array, and the length of the array elements.

string[] players = { "Emily", "Kyle", "Todd", "Rachel", "Grayson" };
 
// This creates a new array with default values
string[] playersCopy = new string[5];
 
// This will populate the playersCopy array with { "Grayson", "Rachel", "Todd", "Kyle", "Emily" }
Array.Copy(players, playersCopy, 5);
2.
In the Microsoft documentation, find the method that reverses the order of the array elements. Use it to reverse the order of the summerStrut playlist. Check to see if it worked by printing the first and last songs to the console.

Checkpoint 3 Passed

Hint
Array.Reverse() (documentation) will switch the order of elements in an entire array. It can also reverse them in a portion of an array, if the overload is used:

string[] players = { "Emily", "Kyle", "Todd", "Rachel", "Grayson" };
 
// This will return { "Grayson", "Rachel", "Todd", "Kyle", "Emily" }
Array.Reverse(players);
3.
In the Microsoft documentation, find the method that turns every rating in the ratings array to zero. Check to see if it worked by printing out the first value to the console (it should be to 0).

Checkpoint 4 Passed

Hint
Array.Clear() (documentation) sets a range of elements in an array to the default value. It takes three parameters: the name of the array, the starting index of the range to clear, and the number of elements to clear.

To clear an entire array, set the index to 0 (if it is zero-indexed) and then pass in the length of the array for the third parameter.

string[] players = { "Emily", "Kyle", "Todd", "Rachel", "Grayson" };
 
// This will return { null, null, null, null, null }
Array.Clear(players, 0, players.Length);

*/