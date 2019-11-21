using PayslipLogic;

namespace PayslipConsole
{
    internal static class Program
    {
        private static void Main()
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