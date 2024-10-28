using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
//    CreateCountry()
//UpdateCountry()
//RemoveCountry()
//GetAllCountries()
//GetCountryByRegion()

//CreatePlanet()
//UpdatePlanet()
//RemovePlanet()
//GetAllPlanets()

    internal class AppDbContext
    {
        static List<Country> Countries = new List<Country>();
        static List<Planet> Planets = new List<Planet>();
        public static void CreateCountry( Country country)

        {
            Countries.Add(country);
        }
        public static void UpdateCountry()
        {

        }
        public static void RemoveCountry( Country country)
        {
            Countries.Remove(country);
            Console.WriteLine($"{country} silindi");

        }
        public static List<Country> GetAllCountries()
        {
           return Countries;
        }
        public static void GetCountryByRegion()
        {

        }
        public static void CreatePlanet( Planet planet)
        { Planets.Add(planet);

        }
        public static void UpdatePlanet()
        {

        }
       public static void RemovePlanet( Planet planet)
        {
            Planets.Remove(planet);

        }
        public static void GetAllPlanets()
        {
            Planets.ForEach(Console.WriteLine);

        }
        


    }
}
