References of Different Types
Before going any further, let’s remind ourselves that Dissertation implements IFlippable, which has the CurrentPage property and Flip() method. You’ll need this info in a minute.

In our previous example both references to the Dissertation object were of type Dissertation:

Dissertation diss1 = new Dissertation();
Dissertation diss2 = diss1;
Whenever we use diss1 and diss2 we can handle the Dissertation object as if it were a Dissertation type. Since Dissertation also implements the IFlippable interface, we can reference it that way too:

Dissertation diss = new Dissertation(50);
IFlippable fdiss = diss;
Now diss and fdiss refer to the same object, but fdiss is an IFlippable reference, so it can ONLY use IFlippable functionality:

diss.Flip();
fdiss.Flip();
Console.WriteLine(diss.Define());
// This causes an error!
Console.WriteLine(fdiss.Define());
This last line causes an error because Define() is not a method in the IFlippable interface. The other lines do NOT cause errors because they use members that both IFlippable and Dissertation have.

This rule also applies to base classes too, so we can refer to a Dissertation object as Book.

Dissertation diss = new Dissertation(50);
Book bdiss = diss;
Console.WriteLine(diss.Title);
Console.WriteLine(bdiss.Title);
diss.Define();
// This causes an error!
bdiss.Define();
Title is defined for Book, so no error is thrown there. Define(), however, is not defined for the Book class, so we can’t use it with Book references.

Instructions
1.
This code contains two errors! Delete or comment out the lines causing the errors.

Checkpoint 2 Passed

Hint
Each error is caused because a reference is using a member not defined in the reference’s type.

For example, bdiss is a Book type reference and CurrentPage is not a property defined in the Book class. You can check Book.cs to be sure.

bdiss.CurrentPage = 43;