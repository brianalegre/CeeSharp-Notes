using System;

namespace LearnInterfaces
{
    // Class That Implements The Interface
    // Use " : " After Class Name
    class Sedan : IAutomobile
    {
        // Implement Interface
        // Call the properties of IAutomobile with public
        public string LicensePlate { get; }
        public double Speed { get; }
        public int Wheels { get; }

        // Print HONK
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

    }


}