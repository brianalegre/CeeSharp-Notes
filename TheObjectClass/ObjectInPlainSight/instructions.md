Object in Plain Sight
At the very beginning of your C# journey, you learned about Console.WriteLine(). You used this tool with nearly every type, from int and bool to Dissertation and Diary:

bool b = true;
Diary d = new Diary();
Console.WriteLine(b);
Console.WriteLine(d);
We can use this same tool with every type because every type inherits from Object!

Under the hood, Console.WriteLine() uses ToString(), which is defined in Object. Every object needs some kind of string representation to be printed in text. These two lines are equivalent:

Console.WriteLine(b);
Console.WriteLine(b.ToString());
Instructions
1.
Let’s prove to ourselves that ToString() is used when printing to the console.

First, override the ToString() method in the Diary class. Have the method return the string "Surprise!".

Checkpoint 2 Passed

Hint
Here’s the signature for ToString():

public override string ToString()
2.
Back in Program.cs, construct a Diary object and pass it directly to Console.WriteLine().

You should see your surprise printed!

Checkpoint 3 Passed

Hint
Here’s example in which a Random instance is constructed and printed to the console:

Random rand = new Random();
Console.WriteLine(rand);