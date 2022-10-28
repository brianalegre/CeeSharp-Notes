Testing Interfaces
Now we have a Sedan class and Truck class that implement the IAutomobile interface. Though they have some different behaviors, they both have the properties and method defined in the interface:

double Speed
string LicensePlate
int Wheels
void Honk()
At this point we can be confident that we won’t cause any errors if we try to access these members in either the Sedan or Truck class.

Instructions
1.
Create two sedans and a truck:

a sedan with speed 60
a sedan with speed 70
a truck with speed 45 and weight 500
Checkpoint 2 Passed

Hint
Call the Sedan constructor with one argument and call the Truck constructor with two arguments.

Remember to use the new keyword like so:

Forest f = new Forest(5);
2.
Write three Console.WriteLine() statements that print the automobiles’ Speed, Wheels, and LicensePlate.

Checkpoint 3 Passed

Hint
You may want to use string interpolation, which uses the $ and {} symbols:

Console.WriteLine($"The first sedan's speed is: {s.Speed}...");
3.
Call SpeedUp() on all three automobiles.

Checkpoint 4 Passed
4.
Using Console.WriteLine(), print out the three automobile’s new speeds.