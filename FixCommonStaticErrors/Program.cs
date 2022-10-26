using System;

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Congo", "Tropical");
      
      // Changed from: Forest.Grow()
      f.Grow();
      
      // Changed from: f.TreeFacts
      Console.WriteLine(Forest.TreeFacts);
    }
  }
}
