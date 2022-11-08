Overriding Object Members
The Equals() and ToString() methods in Object are virtual, so they can be overridden.

For example, we can override ToString() in the Diary class:

class Diary
{
  /* other members omitted */
 
  public override string ToString()
  {
    return $"This Diary is currently on page {CurrentPage}."; 
  }
}
Now any Diary instance will use this version of the method:

Diary dy = new Diary(7);
Console.WriteLine(dy.ToString());
// Output: "This Diary is currently on page 7."
Instructions
1.
In Book.cs, define an override ToString() method for the Book class.

It should return a string containing the Author and Title information.

Checkpoint 2 Passed

Hint
Here’s the signature for ToString():

public override string ToString()
2.
In Program.cs, call bk.ToString() method and print the result.

It should show the author and title information that you specified in the method!