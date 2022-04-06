using System.Globalization;

namespace Section09132_EnumeracaoComposicao.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }        

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = SubTotal();
        }

        public double SubTotal()
        {
            Price = Quantity * Product.Price;
            return Price;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Product.Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + Quantity + ", Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}