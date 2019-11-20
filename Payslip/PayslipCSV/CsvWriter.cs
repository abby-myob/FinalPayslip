using System.Collections.Generic;
using System.IO;
using PayslipLogic;

namespace PayslipCSV
{
    public class CsvWriter
    {
        private string Path { get; }

        public CsvWriter(string path)
        {
            Path = path;
        }

        public void WriteCsv(List<Person> people)
        {
            
            foreach (var person in people)
            {
                
            }
            
//            var csvWriter = File.WriteAllLines(Path); 
        }
    }
}