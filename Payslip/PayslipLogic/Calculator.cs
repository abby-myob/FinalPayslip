using System;
using PayslipLogic.Interfaces;

namespace PayslipLogic
{
    public class Calculator : ICalculator
    {
        public decimal CalculateGrossIncome(decimal annualSalary)
        { 
            return Math.Round(annualSalary/12);
        }

        public decimal CalculateNetIncome(decimal grossIncome, decimal incomeTax)
        {
            return grossIncome - incomeTax;
        }

        public decimal CalculateIncomeTax(decimal annualSalary)
        {
            decimal incomeTax = 0;
            if (annualSalary <= Constants.B1Upper)
            {
                return incomeTax;
            }  
            
            if (annualSalary <= Constants.B2Upper)
            {
                incomeTax = IncomeTaxMath(0,  annualSalary,  Constants.B1Upper, Constants.B2Cents);

            } else if (annualSalary <= Constants.B3Upper)
            {
                incomeTax = IncomeTaxMath(Constants.B3Base,  annualSalary,  Constants.B2Upper, Constants.B3Cents);

            } else if (annualSalary <= Constants.B4Upper)
            {
                incomeTax = IncomeTaxMath(Constants.B4Base,  annualSalary,  Constants.B3Upper, Constants.B4Cents);

            } else if (annualSalary >= Constants.B5Lower)
            {
                incomeTax = IncomeTaxMath(Constants.B5Base,  annualSalary,  Constants.B4Upper, Constants.B5Cents);
            }

            return Math.Round(incomeTax);
        }

        private decimal IncomeTaxMath(decimal baseTax, decimal annualSalary, decimal bracket, decimal cents)
        {
            return (baseTax + (annualSalary - bracket) * cents) / 12;
        }

        public decimal CalculateSuper(decimal grossIncome, decimal superRate)
        {
            return Math.Round(grossIncome * (superRate / 100));
        }
    }
}