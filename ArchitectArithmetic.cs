using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Test Functions
      Console.WriteLine(rect(4, 5));
      Console.WriteLine(circle(4));
      Console.WriteLine(triangle(10,9));

      // Floor Plan Values
      double floorRect = rect(1500, 2500);
      double floorCicle = circle(375);
      double floorTriangle = triangle(750,500);

      // Print Floor Plan Values
      Console.Write(floorRect);
      Console.Write(floorCicle);
      Console.Write(floorTriangle);

      // Total Cost
      double totalCost = Math.Round(floorRect * 180);

      //Print Total Cost
      Console.WriteLine($"The total cost of the area is {totalCost} Mexican pesos");



    }

    // Reactangle Area
    static double rect(double length, double width)
    {
      return length * width;
    }

    // Circle Area
    static double circle(double radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }

    // Triangle Area
    static double triangle(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }
  }
}


/*

Architect Arithmetic
Architects have big ideas – but big ideas can be expensive. How expensive? Depends on the size.

In this project, you’ll use methods to build a program that calculates the material cost for any architect’s floor plan. For example, the floor plan of the Pantheon in Rome, Italy:

Pantheon blueprint

…can be (approximately) broken into circles and rectangles:

Pantheon can be broken into circle radius 21.5m and rectangle 15m by 18m

Using basic formulas, we can calculate the area of each shape and find the total:

double totalArea = Circle(21.5) + Rect(15, 18);
You’ll be defining area methods like Circle() and Rect(), but we’ll provide the formulas for you to use.

Finally, we multiply the total area by the cost of each unit of flooring material. Let’s assume that tiles cost ₤100 each:

double tileCost = 100;
double totalCost = totalArea * tileCost;
Although the floor plan isn’t exactly one circle and rectangle, this approximation is good enough for estimating costs. Let’s get started!

Tasks
10/10 Complete
Mark the tasks as complete by checking them off
Define Methods
1.
We’ll need to define a method for each basic shape. Let’s start with rectangles. Define a method with two parameters (length and width) that returns the area of the rectangle.

Here’s the formula for rectangular area:

area = length \times widtharea=length×width
For all numbers in this project, use the double data type.


Stuck? Get a hint
2.
Now circles. Define a method with one parameter (radius) that returns the area of the circle.

Use Math.PI to represent the number pi, and Math.Pow() to square the radius.

area = \pi \times radius^2area=π×radius 
2
 

Stuck? Get a hint
3.
We’ll also need triangles. Define a method with two parameters (bottom and height) that returns the area of the triangle.

area = 0.5 \times bottom \times heightarea=0.5×bottom×height

Stuck? Get a hint
4.
Test that your methods work with these test cases:

A rectangle with length 4 and width 5 has an area of 20.
A circle with radius 4 has an area of about 50.
A triangle with base 10 and height 9 has an area of 45.
Don’t forget that you need to use dotnet run to run the program!


Stuck? Get a hint
Calculate Cost
5.
Find the area of the floor plan. We’ll use an adapted version of the ancient city in Mexico: Teotihuacan, which you can see as image to the right.

On paper or in your head, break down the floor plan using circles, rectangles, and triangles.


Stuck? Get a hint
6.
Calculate the area of each part, add them together, and store the result in a variable.


Stuck? Get a hint
7.
Multiply the total area by the cost of flooring material – 180 Mexican pesos – and store the result in a variable.


Stuck? Get a hint
8.
Write the result to the console, explaining what the number means. Use string interpolation.


Stuck? Get a hint
9.
Pesos should only have two decimal places, so use a built-in method to round the value.

*/