using System;
using System.Collections.Generic;
using System.IO;
using PayslipLogic;

namespace PayslipConsole
{
    public class CsvReader
    {
        private string Path { get; }

        public CsvReader(string path)
        {
            Path = path;
        }
        
        public List<Person> ReadCsv()
        {
            var csvReader = File.ReadAllText(Path);
            var people = new List<Person>();

            foreach (var line in Csv.CsvReader.ReadFromText(csvReader))
            {
                var salary = Int32.Parse(line[2]);
                var super = Int32.Parse(line[3]);

                var paymentMonth = line[4];
                var month = paymentMonth.Split("-");
                var start = Convert.ToDateTime(month[0]);
                var end = Convert.ToDateTime(month[1]);
                
                people.Add(new Person(line[0], line[1], salary, super, start, end));
            }

            return people;
        }
    }
}