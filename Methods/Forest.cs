using System;

namespace BasicClasses
{
    class Forest
    {
        public int age;
        private string biome;

        public string Name
        { get; set; }

        public int Trees
        { get; set; }

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal")
                {
                    biome = value;
                }
                else
                {
                    biome = "Unknown";
                }
            }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        // Define a method
        public int Grow()
        {
            Trees += 30;
            Age += 1;
            return Trees;
        }

        // Define a method
        public int Burn()
        {
            Trees -= 20;
            Age += 1;
            return Trees;
        }

    }

}
