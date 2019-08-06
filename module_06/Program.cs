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

            Console.WriteLine("Enter no. of countries to display:");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must type in a +ve integer. Existing");
                return;
            }

            for (int i = 0; i < countries.Count; i++)
            {
                if (i > 0 && (i % userInput == 0))
                {
                    Console.WriteLine("Hit return to continue, anything else to quit");
                    if (Console.ReadLine() != "") break;
                }

                Country country = countries[i];
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
        }
    }
}
