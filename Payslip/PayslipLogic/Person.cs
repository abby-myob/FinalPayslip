
using System;

namespace PayslipLogic
{
    public class Person
    { 
        public string Name { get; } 
        public string Surname { get; }
        public decimal AnnualSalary { get; }
        public decimal SuperRate { get; }
        public DateTime PaymentStartDate { get; }
        public DateTime PaymentEndDate { get; }
        public decimal GrossIncome { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal NetIncome { get; set; }
        public decimal SuperTotal { get; set; }

        public Person(string name, string surname, decimal annualSalary, decimal superRate, DateTime paymentStartDate, DateTime paymentEndDate)
        {
            Surname = surname;
            AnnualSalary = annualSalary;
            SuperRate = superRate;
            PaymentStartDate = paymentStartDate;
            PaymentEndDate = paymentEndDate;
            Name = name;
        } 
    }
}