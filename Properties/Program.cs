using System;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest();
            // Replacing f.name with f.Name (Property)
            f.Name = "Congo";
            // Replacing f.trees with f.Trees (Property)
            f.Trees = 0;
            f.age = 0;
            f.biome = "Tropical";

            // Replacing f.name with f.Name (Property)
            Console.WriteLine(f.Name);
        }
    }
}
