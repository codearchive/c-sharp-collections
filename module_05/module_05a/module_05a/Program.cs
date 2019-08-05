using System;
using System.Collections.Generic;

namespace module_05a
{
    class Program
    {
        static void Main()
        {
            Country norway = new Country("Norway", "NOR", "Europe", 5_282_223);
            Country finland = new Country("Finland", "FIN", "Europe", 5_511_303);

            // Dictionary<string, Country> countries = new Dictionary<string, Country>();
            var countries = new Dictionary<string, Country>();
            countries.Add(norway.Code, norway);
            countries.Add(finland.Code, finland);

            foreach (var country in countries.Values)
            {
                Console.WriteLine(country.Name);
            }
        }
    }
}
