using System.IO;

namespace module_09
{
	class CsvReader
	{
		private string _csvFilePath;

		public CsvReader(string csvFilePath)
		{
			this._csvFilePath = csvFilePath;
		}

		public Country[] ReadFirstNCountries(int nCountries)
		{
			Country[] countries = new Country[nCountries];

			using (StreamReader sr = new StreamReader(_csvFilePath))
			{
				// read header line
				sr.ReadLine();

				for (int i = 0; i < nCountries; i++)
				{
					string csvLine = sr.ReadLine();
					countries[i] = ReadCountryFromCsvLine(csvLine);
				}
			}

			return countries;			
		}

		private static Country ReadCountryFromCsvLine(string csvLine)
		{
			string[] parts = csvLine.Split(',');
			string name = parts[0];
			string code = parts[1];
			string region = parts[2];
			bool popOK = int.TryParse(parts[3], out int population);
			return new Country(name, code, region, population);
		}

	}
}
