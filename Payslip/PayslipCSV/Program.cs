using PayslipCSV;
using PayslipLogic;

namespace PayslipConsole
{
    static class Program
    {
        static void Main(string[] args)
        {
            var inputPath = "/Users/abby.thompson/Development/Acceleration/FinalPayslip/sample_input.csv";
            var outputPath = "/Users/abby.thompson/Development/Acceleration/FinalPayslip/output.csv";
            var payslipManager = new PayslipCsvManager(new CsvReader(inputPath), new CsvWriter(outputPath), new PayslipGenerator(new Calculator()));

            payslipManager.GetEmployees();
            payslipManager.GeneratePayslips();
            payslipManager.OutputPayslips();
        }
    }
}