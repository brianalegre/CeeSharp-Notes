When To Use Each Syntax
So far you’ve seen query syntax and two flavors of method syntax.

// Query syntax
var longLoudheroes = from h in heroes
  where h.Length > 6
  select h.ToUpper();
 
// Method syntax - separate statements
var longHeroes = heroes.Where(h => h.Length > 6);
var longLoudHeroes = longHeroes.Select(h => h.ToUpper());
 
// Method syntax - chained expressions
var longLoudHeroes2 = heroes
  .Where(h => h.Length > 6)
  .Select(h => h.ToUpper());
As you get into more advanced LINQ queries and learn new operators, you’ll get a feel for what works best in each situation. For now, we generally follow these rules:

For single operator queries, use method syntax.
For everything else, use query syntax.
Instructions
1.
Write a method-syntax query that transforms each element in heroes to this format:

Introducing...[hero's name]!
Checkpoint 2 Passed

Hint
Since this a single operator query (Select()), use method syntax.

2.
Write a query-syntax query that selects elements containing a space and returns the index of the space in each element. For example, instead of "D. Va", the result should contain 2.

Checkpoint 3 Passed

Hint
Since this is a multiple operator query (where and select), use query syntax.

When writing your query:

Use Contains() in your where clause to check whether an element contains a space.
Use IndexOf() in your select clause to find the index of the space.
3.
Print out all of the elements of both query results to check your work.

Checkpoint 4 Passed

Hint
Use two foreach loops — one for each query.