using System.Collections.Generic;
using Csv;
using PayslipLogic;
using CsvReader = PayslipConsole.CsvReader;

namespace PayslipCSV
{
    public class PayslipCsvManager
    {
        public CsvReader CsvReader { get; }
        public CsvWriter CsvWriter { get; }
        public PayslipGenerator PayslipGenerator { get; }
        public List<Person> People { get; private set; }

        public PayslipCsvManager(CsvReader csvReader, CsvWriter csvWriter, PayslipGenerator payslipGenerator)
        {
            CsvReader = csvReader;
            CsvWriter = csvWriter;
            PayslipGenerator = payslipGenerator;
        }

        public void GetEmployees()
        {
            People = CsvReader.ReadCsv();
        }

        public void GeneratePayslips()
        {
            foreach (var person in People)
            {
                PayslipGenerator.GeneratePayslip(person);
            }
        }

        public void OutputPayslips()
        {
            CsvWriter.WriteCsv(People);
        }
    }
}