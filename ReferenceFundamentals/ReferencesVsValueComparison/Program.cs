using System;

namespace LearnReferences
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create new variable object
            Book b1 = new Book();

            // Create another viarable that holds the same reference  as b1
            Book b2 = b1;

            // Print the result of b1 == 2
            Console.WriteLine(b1 == b2);
            // Output: True
        }
    }
}
