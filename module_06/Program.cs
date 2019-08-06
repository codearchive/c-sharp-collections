﻿using System;
using System.Collections.Generic;

namespace module_06
{
    class Program
    {
        static void Main()
        {
            string filePath = @"./Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2000000);
            int lilliputIndex = countries.FindIndex(x => x.Population < 2000000);
            countries.Insert(lilliputIndex, lilliput);

            countries.RemoveAt(lilliputIndex);

            for (int i = 0; i < countries.Count; i++)
            {
                Country country = countries[i];
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
