using System;
using PayslipLogic;
using Xunit;

namespace PayslipTest
{
    public class PayslipGeneratorShould
    {
        [Fact] 
        public void ReturnTheCorrectGrossIncomeRoundingDown()
        {
            var payslipGenerator = new PayslipGenerator(new Calculator());
            var payslip = new Person(
                "abby", 
                "thompson", 
                60050, 
                9, 
                new DateTime(1,1,1), 
                new DateTime(1,1,30)
                );

            var expected = new Person(
                "abby",
                "thompson",
                60050,
                9,
                new DateTime(1, 1, 1),
                new DateTime(1, 1, 30)
            ) {GrossIncome = 5004, IncomeTax = 922, NetIncome = 4082, SuperTotal = 450};

            var actual = payslipGenerator.GeneratePayslip(payslip);
            
            Assert.Equal(expected.GrossIncome, actual.GrossIncome);
            Assert.Equal(expected.IncomeTax, actual.IncomeTax);
            Assert.Equal(expected.NetIncome, actual.NetIncome);
            Assert.Equal(expected.SuperTotal, actual.SuperTotal);
        }
    }
}