using System;

namespace DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            // dna strand
            string startStrand = "ATGCGATGAGCTTAC";

            // find location of "tga"
            int tga = startStrand.IndexOf("TGA");
            // Print Out Value
            Console.WriteLine(tga);
            // Prints 6

            // start point and stop point variables
            int startPoint = 0;
            int length = tga + 3;

            // define final strand
            string dna = startStrand.Substring(startPoint, length);
            // Print
            Console.WriteLine(dna);
            // Prints ATGCGATGA

            // DNA mutation search
            Console.WriteLine(dna[3]);
            // Prints C

        }
    }
}

/* 

Get Parts of Strings
We can also use built-in .NET methods to grab parts of strings or specific characters in a string.

Substring
.Substring() grabs part of a string using the specified character position, continues until the end of the string, and returns a new string. .IndexOf() is usually used first to get the specific character position.

string plantName = "Cactaceae, Cactus"; 
int charPosition = plantName.IndexOf("Cactus"); // returns 11
string commonName = plantName.Substring(charPosition); // returns Cactus
.Substring() is useful if we only want to use part of a string but keep the original data intact. So in this instance, we want to keep the string plantName, but just grab the "Cactus" portion of the string. We use .IndexOf() to find where "Cactus" starts, then use .Substring() with the position information to save "Cactus" to the new variable commonName.

We can also pass .Substring() a second argument, which will determine the number of characters in the resulting substring. For example, the following code shows how we can use .Substring() with two arguments to specify the length of our substring:

string name = "Codecademy"; 
int start = 2;
int length = 6;
string substringName = name.Substring(start, length); // returns 'decade'
Bracket Notation
Bracket notation is a style of syntax that uses brackets [] and an integer value to identify a particular value in a collection. In this case, we can use it to find a specific character in a string.

string plantName = "Cactaceae, Cactus";
int charPosition = plantName.IndexOf("u"); // returns 15
char u = plantName[charPosition]; // returns u
Similar to the example above, we first use .IndexOf() to grab the character position, which in this case is 15. We then take the string value and append it with a set of brackets [] and place the charPosition value inside the brackets.

Instructions
1.
In program.cs, you are given a string defined as startStrand. Your goal is to find the ending condition for a DNA strand, "TGA", and then print out the substring of startStrand that starts from the first character and goes through "TGA". This will output a valid DNA strand.

You don’t need much understanding of biology to follow these directions, but if you’d like a more in-depth explanation/background, click the dropdown below:

More info on DNA
First, use IndexOf() to find the location of "TGA" in startStrand. Save this as a variable called tga.

Checkpoint 2 Passed

Stuck? Get a hint
2.
Create two variables called startPoint and length. startPoint should be set to 0, and length should be set to three more than the value of tga.

length should be set to three more than the value of tga for two reasons:

IndexOf() returns the starting point of tga in startStrand (where the character "T" is). To capture "GA" as well, add two.
When using .Substring() with two arguments, .Substring() captures the amount of characters indicated by the second argument. Because strings in C# are zero-indexed, you will need to add one more in order to properly capture the last character. In this example, the "A" in "TGA" falls at index 8 but is the 9th character — if we only set the length to 8, the final “A” would not be included. Therefore, instead of defining length as tga + 2, you should define it as tga + 3.
Checkpoint 3 Passed

Stuck? Get a hint
3.
Now use Substring() to retrieve the substring of startStrand that starts from startPoint and has a length of length. Save this to a variable called dna.

Print out this string using Console.WriteLine(dna).

Checkpoint 4 Passed

Stuck? Get a hint
4.
You are worried there might have been a mutation within this strand of DNA! Take a look at the fourth character to determine whether or not the strand has mutated:

If it is equal to G, there has been no mutation.
If it is equal to C or A, there has been a mutation.
Use bracket notation to grab the fourth character in dna and show the result in the console. Has there been a mutation?

*/