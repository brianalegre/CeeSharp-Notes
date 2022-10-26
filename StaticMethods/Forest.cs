using System;

namespace StaticMembers
{
    class Forest
    {
        // FIELDS

        public int age;
        private string biome;
        private static int forestsCreated;

        // Private Static Field - treeFacts
        private static string treeFacts;

        // Public Static Property - TreeFacts
        public static string TreeFacts
        // Define Getter, No Setter
        {
            // Getter
            get { return treeFacts; }
        }

        // Public Static Method
        public static void PrintTreeFacts()
        {
            // Print TreeFacts To Console
            Console.WriteLine(TreeFacts);
        }


        // CONSTRUCTORS

        public Forest(string name, string biome)
        {
            this.Name = name;
            this.Biome = biome;
            Age = 0;
            ForestsCreated++;
        }

        public Forest(string name) : this(name, "Unknown")
        { }

        // PROPERTIES

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

        public static int ForestsCreated
        {
            get { return forestsCreated; }
            private set { forestsCreated = value; }
        }

        // METHODS

        public int Grow()
        {
            Trees += 30;
            Age += 1;
            return Trees;
        }

        public int Burn()
        {
            Trees -= 20;
            Age += 1;
            return Trees;
        }

    }

}
