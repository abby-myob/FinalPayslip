using System.IO;

namespace PayslipCSV
{
    public class CsvReader
    {
        private string Path { get; }

        public CsvReader(string path)
        {
            Path = path;
        }
        
        public void ReadCsv()
        {
            var csvReader = File.ReadAllText(Path);

            foreach (var line in Csv.CsvReader.ReadFromText(csvReader))
            { 
                
            }
        }
    }
}