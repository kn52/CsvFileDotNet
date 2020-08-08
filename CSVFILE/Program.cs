using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;

namespace CSVFILE
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Kajal\\Downloads\\Compressed\\Project\\IndiaStateCensusData.csv";
            //string[] data = File.ReadAllLines(path);
            //foreach(string s in data)
            //{
            //    Console.WriteLine(s);
            //}
            List<IndiaStateCensusData> census = new List<IndiaStateCensusData>(); 
            using (TextReader reader = new StreamReader(path))
            {
                CsvReader csv = new CsvReader(reader);
                csv.Configuration.Delimiter = ";";
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())
                {
                    IndiaStateCensusData Record = csv.GetRecord<IndiaStateCensusData>();
                    census.Add(Record);
                }
            }
            Console.ReadKey();
        }
    }
}
