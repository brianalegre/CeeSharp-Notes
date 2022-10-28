using System;

namespace LearnInterfaces
{
    // Create An Interface
    interface IAutomobile
    {
        // Add Properties
        string LicensePlate { get; }
        double Speed { get; }
        int Wheels { get; }
        void Honk();
    }

}