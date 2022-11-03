using System;

namespace LearnReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Object with current page set to 5
            Diary dy1 = new Diary(5);

            // Create another Object set to value of first object
            Diary dy2 = dy1;

            // Call Flip
            dy2.Flip();

            // Print CurrentPage of dy1 and dy1
            Console.WriteLine($"{dy1.CurrentPage} and {dy2.CurrentPage}");

        }
    }
}
