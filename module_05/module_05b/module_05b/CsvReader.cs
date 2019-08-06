﻿using System;
using System.Collections.Generic;
using System.IO;

namespace module_05b
{
    class CsvReader
    {
        private readonly string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public Dictionary<string, Country> ReadAllCountries()
        {
            Dictionary<string, Country> countries = new Dictionary<string, Country> ();

            using (StreamReader streamReader = new StreamReader(_csvFilePath))
            {
                // read header line
                streamReader.ReadLine();

                string csvLine;
                while ((csvLine = streamReader.ReadLine()) != null)
                {
                    Country country = ReadCountryFromCsvLine(csvLine);
                    countries.Add(country.Code, country);
                }
            }

            return countries;
        }

        public Country ReadCountryFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');
            string name;
            string code;
            string region;
            string popText;
            switch (parts.Length)
            {
                case 4:
                    name = parts[0];
                    code = parts[1];
                    region = parts[2];
                    popText = parts[3];
                    break;
                case 5:
                    name = parts[0] + ", " + parts[1];
                    name = name.Replace("\"", null).Trim();
                    code = parts[2];
                    region = parts[3];
                    popText = parts[4];
                    break;
                default:
                    throw new Exception($"Can not parse country from csvLine: {csvLine}");
            }

            int.TryParse(popText, out int population);
            return new Country(name, code, region, population);
        }
    }
}