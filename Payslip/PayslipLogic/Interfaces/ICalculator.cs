namespace PayslipLogic.Interfaces
{
    public interface ICalculator
    {
        decimal CalculateGrossIncome(decimal annualSalary);
        decimal CalculateNetIncome(decimal grossIncome, decimal incomeTax);
        decimal CalculateIncomeTax(decimal annualSalary);
        decimal CalculateSuper(decimal grossIncome, decimal superRate);
    }
}