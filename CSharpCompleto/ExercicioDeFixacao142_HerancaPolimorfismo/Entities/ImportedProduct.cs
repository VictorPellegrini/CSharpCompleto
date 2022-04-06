using System.Globalization;

namespace ExercicioDeFixacao142_HerancaPolimorfismo.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double fee)
            : base(name, price)
        {
            Name = name;
            Price = price;
            CustomsFee = fee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " | (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        public void TotalPrice()
        {
            Price += CustomsFee;
        }
    }
}
