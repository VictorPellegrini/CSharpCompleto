using System;

namespace Section10142_HerancaPolimorfismo.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " | (Manufacture date: " + ManufactureDate.ToShortDateString() + ")";
        }
    }
}
