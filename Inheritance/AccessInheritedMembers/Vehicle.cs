using System;

namespace LearnInheritance
{
    class Vehicle
    {
        public string LicensePlate
        // Add protected set to allow subclasses to set the value
        { get; protected set; }

        public double Speed
        { get; protected set; }

        public int Wheels
        { get; protected set; }

        public void SpeedUp()
        {
            Speed += 5;
        }

        public void SlowDown()
        {
            Speed -= 5;
        }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

    }
}