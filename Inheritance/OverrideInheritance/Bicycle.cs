using System;

namespace LearnInheritance
{
    // Create Class that inherits Vehicle
    // Use : to inherit
    class Bicycle : Vehicle
    {
        // Constructor with 1 parameter
        // Calls base()
        // Set Wheels to 2
        public Bicycle(double speed) : base()
        {
            Wheels = 2;
        }

        //  Define Method
        //  Add override
        public override void SpeedUp()
        {
            if (Speed > 15)
            {
                Speed = 15;
            }
            else
            {
                Speed += 5;
            }
        }


        public override void SlowDown()
        {
            if (Speed < 0)
            {
                Speed = 0;
            }
            else
            {
                Speed -= 5;
            }

        }

    }
}