using PayslipLogic;
using Xunit;

namespace PayslipTest
{
    public class CalculatorShould
    {
        [Theory]
        [InlineData(60050, 5004)]
        [InlineData(60010, 5001)]
        public void ReturnTheCorrectGrossIncomeRoundingDown(decimal annualSalary, decimal expected)
        {
            var calc = new Calculator();
            var result = calc.CalculateGrossIncome(annualSalary);

            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(60050, 922)] 
        [InlineData(120000, 2669)]  
        public void ReturnTheCorrectIncomeTaxRoundingUp(decimal annualSalary, decimal expected)
        {
            var calc = new Calculator();
            var result = calc.CalculateIncomeTax(annualSalary);

            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(5004, 922, 4082)] 
        public void ReturnTheCorrectNetIncome(decimal grossIncome, decimal incomeTax, decimal expected)
        {
            var calc = new Calculator();
            var result = calc.CalculateNetIncome(grossIncome, incomeTax);

            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(5004, 9, 450)] 
        public void ReturnTheCorrectSuperannuation(decimal grossIncome, decimal superRate, decimal expected)
        {
            var calc = new Calculator();
            var result = calc.CalculateSuper(grossIncome, superRate);

            Assert.Equal(expected, result);
        }
    }
}