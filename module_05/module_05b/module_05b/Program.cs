using System;
using System.Collections.Generic;

namespace module_05b
{
    class Program
    {
        static void Main()
        {
            string filePath = @"./Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);
            Dictionary<string, Country> countries = reader.ReadAllCountries();

            Console.WriteLine("Which country code you want to look up?");
            string userInput = Console.ReadLine();

            bool gotCountry = countries.TryGetValue(userInput, out Country country);

            Console.WriteLine((!gotCountry)
                ? $"Sorry, there is no country with code, {userInput}"
                : $"{country.Name} has population {PopulationFormatter.FormatPopulation(country.Population)}");
        }
    }
}
