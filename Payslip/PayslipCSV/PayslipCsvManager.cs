using Csv;

namespace PayslipCSV
{
    public class PayslipCsvManager
    {
        public CsvReader CsvReader { get; }
        public CsvWriter CsvWriter { get; }

        public PayslipCsvManager(CsvReader csvReader, CsvWriter csvWriter)
        {
            CsvReader = csvReader;
            CsvWriter = csvWriter;
        }
    }
}