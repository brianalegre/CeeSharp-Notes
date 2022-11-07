using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Book bk = null;
      Console.WriteLine(bk);
      bool result = (bk == null);
      Console.WriteLine(result);
    }
  }
}
