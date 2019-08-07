using System;
using System.Collections.Generic;

namespace module_09
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"Pop by Largest Final.csv";
			CsvReader reader = new CsvReader(filePath);

			// using the array with an interface
			IList<Country> countries = reader.ReadFirstNCountries(10);

			foreach (Country country in countries)
			{
				Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
			}
		}
	}
}
