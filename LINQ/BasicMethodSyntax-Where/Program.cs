using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
    class Program
    {
        static void Main()
        {
            string[] heroes = { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };

            // Where Query
            var heroesWithI = heroes.Where(hero => hero.Contains("i"));
            // Print Query with foreach loop
            foreach (string h in heroesWithI)
            {
                Console.WriteLine(h);
            }
        }
    }
}
