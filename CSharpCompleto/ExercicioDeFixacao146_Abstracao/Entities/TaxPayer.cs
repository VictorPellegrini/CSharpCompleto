using System.Globalization;

namespace Section10146_Abstracao.Entities
{
    public abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public TaxPayer(string name, double income)
        {
            Name = name;
            AnnualIncome = income;
        }

        public abstract double TotalTax();

        public override string ToString()
        {
            return Name + ": $" + TotalTax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}