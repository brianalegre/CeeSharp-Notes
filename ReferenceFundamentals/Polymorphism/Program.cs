using System;

namespace LearnReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Diary();

            // Print
            Console.WriteLine(b1.Stringify());
            Console.WriteLine(b2.Stringify());

        }
    }
}
