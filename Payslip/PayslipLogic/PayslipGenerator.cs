using PayslipLogic.Interfaces;

namespace PayslipLogic
{
    public class PayslipGenerator
    {
        private ICalculator Calculator { get; }

        public PayslipGenerator(ICalculator calculator)
        {
            Calculator = calculator;
        }

        public Person GeneratePayslip(Person person)
        {
            person.GrossIncome = Calculator.CalculateGrossIncome(person.AnnualSalary);
            person.IncomeTax = Calculator.CalculateIncomeTax(person.AnnualSalary);
            person.NetIncome = Calculator.CalculateNetIncome(person.GrossIncome, person.IncomeTax);
            person.SuperTotal = Calculator.CalculateSuper(person.GrossIncome, person.SuperRate);

            return person;
        }
    }
}