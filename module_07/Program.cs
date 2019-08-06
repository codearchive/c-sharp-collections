﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace module_07
{
    class Program
    {
        static void Main()
        {
            string filePath = @"./Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            //foreach (Country country in countries.Take(10).OrderBy(x => x.Name))
            foreach (Country country in countries.Take(20).Where(x => !x.Name.Contains(',')))
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
