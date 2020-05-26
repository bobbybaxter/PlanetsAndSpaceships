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

            var probes = new Dictionary<string, List<string>>();
            probes.Add("Cassini", new List<string>() { "Venus" });
            probes.Add("Galileo", new List<string>() { "Venus" });
            probes.Add("IKAROS", new List<string>() { "Venus" });
            probes.Add("Pioneer Venus Multiprobe", new List<string>() { "Venus" });
            probes.Add("Pioneer Venus Orbiter", new List<string>() { "Venus" });
            probes.Add("Magellan", new List<string>() { "Venus" });
            probes.Add("Mariner 2", new List<string>() { "Venus" });
            probes.Add("Mariner 4", new List<string>() { "Mars" });
            probes.Add("Mariner 5", new List<string>() { "Venus" });
            probes.Add("Mariner 6", new List<string>() { "Mars" });
            probes.Add("Mariner 7", new List<string>() { "Mars" });
            probes.Add("Mariner 9", new List<string>() { "Mars" });
            probes.Add("Mariner 10", new List<string>() { "Mercury", "Venus" });
            probes.Add("Mars 2", new List<string>() { "Mars" });
            probes.Add("Mars 3", new List<string>() { "Mars" });
            probes.Add("Mars 5", new List<string>() { "Mars" });
            probes.Add("Mars 6", new List<string>() { "Mars" });
            probes.Add("Mars 7", new List<string>() { "Mars" });
            probes.Add("MESSENGER", new List<string>() { "Mercury", "Venus" });
            probes.Add("Vega 1", new List<string>() { "Venus" });
            probes.Add("Vega 2", new List<string>() { "Venus" });
            probes.Add("Venera 4", new List<string>() { "Venus" });
            probes.Add("Venera 5", new List<string>() { "Venus" });
            probes.Add("Venera 6", new List<string>() { "Venus" });
            probes.Add("Venera 7", new List<string>() { "Venus" });
            probes.Add("Venera 8", new List<string>() { "Venus" });
            probes.Add("Venera 9", new List<string>() { "Venus" });
            probes.Add("Venera 10", new List<string>() { "Venus" });
            probes.Add("Venera 11", new List<string>() { "Venus" });
            probes.Add("Venera 12", new List<string>() { "Venus" });
            probes.Add("Venera 13", new List<string>() { "Venus" });
            probes.Add("Venera 14", new List<string>() { "Venus" });
            probes.Add("Venera 15", new List<string>() { "Venus" });
            probes.Add("Venera 16", new List<string>() { "Venus" });
            probes.Add("Venus Express", new List<string>() { "Venus" });
            probes.Add("Viking 1 Orbiter", new List<string>() { "Mars" });
            probes.Add("Viking 1 Lander", new List<string>() { "Mars" });
            probes.Add("Viking 2 Orbiter", new List<string>() { "Mars" });
            probes.Add("Viking 2 Lander", new List<string>() { "Mars" });

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
