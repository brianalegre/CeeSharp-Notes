using System;

namespace LearnInheritance
{
    // Add Superclass before interface IAutomobile
    class Sedan : Vehicle, IAutomobile
    {

        // Comment out everthing below, as its is now defined in the Superclass
        // public string LicensePlate
        // { get; }

        // public double Speed
        // { get; private set; }

        // public int Wheels
        // { get; }

        // public Sedan(double speed)
        // {
        //   Speed = speed;
        //   LicensePlate = Tools.GenerateLicensePlate();
        //   Wheels = 4;
        // }

        // public void Honk()
        // {
        //   Console.WriteLine("HONK!");
        // }

        // public void SpeedUp()
        // {
        //   Speed += 5;
        // }

        // public void SlowDown()
        // {
        //   Speed -= 5;
        // }

    }
}