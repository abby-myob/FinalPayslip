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
                var salary = Decimal.Parse(line[2]);
                var superString = line[3].TrimEnd('%');
                var super = Decimal.Parse(superString);

                var paymentMonth = line[4];
                var month = ConvertToDateTime(paymentMonth);
                
                people.Add(new Person(line[0], line[1], salary, super, month[0], month[1]));
            }

            return people;
        }

        private DateTime[] ConvertToDateTime(string paymentMonth) 
        {
            var month = paymentMonth.Split(" – ");
            var start = month[0].Split(' ')[1];
            var startMonth = 1;
            var endDay = int.Parse(month[1].Split(' ')[0]);
            
            switch (start)
            {
                case "January":
                    startMonth = 1;
                    break;
                case "February":
                    startMonth = 2;
                    break;
                case "March":
                    startMonth = 3;
                    break;
                case "April":
                    startMonth = 4;
                    break;
                case "May":
                    startMonth = 5;
                    break;
                case "June":
                    startMonth = 6;
                    break;
                case "July":
                    startMonth = 7;
                    break;
                case "August":
                    startMonth = 8;
                    break;
                case "September":
                    startMonth = 9;
                    break;
                case "October":
                    startMonth = 10;
                    break;
                case "November":
                    startMonth = 11;
                    break;
                case "December":
                    startMonth = 12;
                    break;
            }
            
            var startDateTime = new DateTime(2020, startMonth, 1);
            var endDateTime = new DateTime(2020, startMonth, endDay);
            
            return new[]{startDateTime, endDateTime};
        }
    }
}