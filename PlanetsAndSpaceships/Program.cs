using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanets = new List<string> { "Uranus", "Neptune" };
            planetList.AddRange(lastPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            List<string> rockyPlanets = new List<string>();
            rockyPlanets.AddRange(planetList.GetRange(0, 1));
            rockyPlanets.AddRange(planetList.GetRange(1, 1));
            rockyPlanets.AddRange(planetList.GetRange(2, 1));
            rockyPlanets.AddRange(planetList.GetRange(3, 1));

            planetList.Remove("Pluto");

            Console.WriteLine("Planet List:");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("---");
            Console.WriteLine("Rocky Planets:");
            foreach (string planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }
        }
    }
}
