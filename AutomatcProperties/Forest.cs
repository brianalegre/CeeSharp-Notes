using System;

namespace BasicClasses
{
    class Forest
    {
        // No longer needed with automatic properties
        // public string name;

        // No longer needed with automatic properties
        // public int trees;
        public int age;
        public string biome;

        public string Name
        // Original Method
        // {
        //     get { return name; }
        //     set { name = value; }
        // }

        // Refactored to use Automatic Properties
        { get; set; }

        public int Trees
        // Original Method
        // {
        //     get { return trees; }
        //     set { trees = value; }
        // }

        // Refactored to use Automatic Properties
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
    }

}
