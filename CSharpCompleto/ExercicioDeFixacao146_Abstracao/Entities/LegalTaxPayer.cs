namespace Section10146_Abstracao.Entities
{
    public class LegalTaxPayer : TaxPayer
    {
        public int Employees { get; set; }

        public LegalTaxPayer(string name, double income, int employees)
            : base(name, income)
        {
            Name = name;
            AnnualIncome = income;
            Employees = employees;
        }

        public override double TotalTax()
        {
            double incomeTax;

            if (Employees > 10)
            {
                incomeTax = 0.14 * AnnualIncome;
            }
            else
            {
                incomeTax = 0.16 * AnnualIncome;
            }

            return incomeTax;
        }
    }
}