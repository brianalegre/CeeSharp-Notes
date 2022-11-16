LINQ with Other Collections
You’ve mostly seen LINQ used with arrays, but it can be used for lists as well! The syntax is the same:

List<string> heroesList = new List<string> { "D. Va", "Lucio", "Soldier 76" };
 
var longLoudheroes = from h in heroesList
  where h.Length > 6
  select h.ToUpper();
 
// longLoudHeroes is [ "SOLDIER 76" ]
Technically, LINQ can be used with any type that supports foreach loops, but we won’t cover all of those here.

Instructions
1.
Query heroesList to find all hero names that contain either a . or 7 (a period or the number 7).

Checkpoint 2 Passed

Hint
Since this a single operator query, use method syntax. Use Contains() and the || operator.

2.
Store the query results in a variable of type var and use a foreach loop to print out each element.