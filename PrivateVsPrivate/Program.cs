using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      f.Name = "Congo";
      f.Trees = 0;
      f.age = 0;
      // Changed from f.biome to f.Biome
      f.Biome = "Desert";
      
      Console.WriteLine(f.Name);
      // Changed from f.biome to f.Biome
      Console.WriteLine(f.Biome);
    }
  }
}
