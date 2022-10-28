using System;

namespace LearnInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create new members in the class
      Sedan a = new Sedan(60);
      Sedan b = new Sedan(70);
      Truck c = new Truck(45, 500);

      // Print Values of Speed Wheels, LicensePlate
      // Of each new member
      // Sedan a
      Console.WriteLine($"{a.Speed}");
      Console.WriteLine($"{a.Wheels}");
      Console.WriteLine($"{a.LicensePlate}");

      // Sedan b
      Console.WriteLine($"{b.Speed}");
      Console.WriteLine($"{b.Wheels}");
      Console.WriteLine($"{b.LicensePlate}");

      // Truck c
      Console.WriteLine($"{c.Speed}");
      Console.WriteLine($"{c.Wheels}");
      Console.WriteLine($"{c.LicensePlate}");

      // Call Speed() on all three members
      a.SpeedUp();
      b.SpeedUp();
      c.SpeedUp();

      // Get the speed again on all three members
      Console.WriteLine($"{a.Speed}");
      Console.WriteLine($"{b.Speed}");
      Console.WriteLine($"{c.Speed}");


    }
  }
}