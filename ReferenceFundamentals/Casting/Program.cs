using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
			Dissertation diss = new Dissertation();
      Diary dy = new Diary();
      
      // Book bdiss = (Book)diss;
      // Book bdy = (Book)dy;

      // Changed to: 
      Book bdiss = diss;
      Book bdy = dy;
    }
  }
}
