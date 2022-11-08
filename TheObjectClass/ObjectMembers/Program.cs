using System;

namespace TheObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            Diary d = new Diary(38);
            Random r = new Random();
            int i = 9;

            // Create Object Array
            Object[] bk = { b, d, r, i };

            // Foreach Loop of new Object Array
            foreach (Object f in bk)
            {
                // Call the GetType() method
                // Print the result
                Console.WriteLine(f.GetType());
            }

        }
    }
}