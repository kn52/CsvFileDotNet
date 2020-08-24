using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CSVFILE.Structural;
using CsvHelper;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CSVFILE
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int count = 0;
            string path = "C:\\Users\\Kajal\\Downloads\\Compressed\\Project\\IndiaStateCensusData.csv";
            Dictionary<string,IndiaStateCensusData> list = new Dictionary<string, IndiaStateCensusData>();
			if (File.Exists(path) && Path.GetExtension(filePath) == ".csv")
			{
				using (TextReader reader = File.OpenText(path))
				{
					CsvReader csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture);
					csv.Configuration.Delimiter = ",";
					csv.Configuration.MissingFieldFound = null;
					while (csv.Read())
					{
						var r = csv.GetRecord<IndiaStateCensusData>();
						list.Add(r.state,r);
						count++;
					}
				}
			}
            IEnumerable<IndiaStateCensusData> data = list.OrderBy(key => key.Key).Select(key => key.Value);
            var vs = JsonConvert.SerializeObject(data);
            Console.WriteLine(vs);
            Console.ReadKey();
            
        }
    }
}
