using System.Collections.Generic;
using System.IO;

namespace module_04
{
    class CsvReader
    {
        private readonly string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public List<Country> ReadAllCountries()
        {
            List<Country> countries = new List<Country>();

            using (StreamReader streamReader = new StreamReader(_csvFilePath))
            {
                // read header line
                streamReader.ReadLine();

                string csvLine;
                while ((csvLine = streamReader.ReadLine()) != null)
                {
                    countries.Add(ReadCountryFromCsvLine(csvLine));
                }
            }

            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');

            string name = parts[0];
            string code = parts[1];
            string region = parts[2];
            int population = int.Parse(parts[3]);

            return new Country(name, code, region, population);
        }
    }
}
