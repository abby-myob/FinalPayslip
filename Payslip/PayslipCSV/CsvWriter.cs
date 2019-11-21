using System.Collections.Generic;
using System.Globalization;
using System.IO;
using PayslipLogic;

namespace PayslipConsole
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
            var columnNames = new[]
            {
                CsvConstants.ColumnName,
                CsvConstants.ColumnPayPeriod,
                CsvConstants.ColumnGrossIncome,
                CsvConstants.ColumnIncomeTax,
                CsvConstants.ColumnNetIncome,
                CsvConstants.ColumnSuper 
            }; 
            
            var payslips = new List<string[]>();

            foreach (var person in people)
            {
                var info = new[]
                {
                    person.Name + " " + person.Surname,
                    person.PaymentStartDate.ToString("dd-MMMM") + " - " + person.PaymentEndDate.ToString("dd-MMMM"), 
                    person.GrossIncome.ToString(CultureInfo.InvariantCulture),
                    person.IncomeTax.ToString(CultureInfo.InvariantCulture),
                    person.NetIncome.ToString(CultureInfo.InvariantCulture), 
                    person.SuperTotal.ToString(CultureInfo.InvariantCulture)
                };
                payslips.Add(info);
            }
            
            var csvWriter = Csv.CsvWriter.WriteToText(columnNames, payslips);
            File.WriteAllText(Path, csvWriter); 
        }
    }
}