namespace Section10146_Abstracao.Entities
{
    public class IndividualTaxPayer : TaxPayer
    {
        public double HealthExpense { get; set; }

        public IndividualTaxPayer(string name, double income, double helthExpense)
            : base(name, income)
        {
            HealthExpense = helthExpense;
        }

        public override double TotalTax()
        {
            double incomeTax;

            if (AnnualIncome < 20000.00)
            {
                incomeTax = 0.15 * AnnualIncome;
            }
            else
            {
                incomeTax = 0.25 * AnnualIncome;
            }

            if (HealthExpense > 0)
            {
                incomeTax -= 0.5 * HealthExpense;
            }

            return incomeTax;
        }
    }
}