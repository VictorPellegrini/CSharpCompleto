using Section10142_HerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Section10142_HerancaPolimorfismo
{
    public class UserStory142
    {
        public static void Main()
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> productList = new List<Product>(n);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\r\nProduct #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: $ ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (type)
                {
                    case 'c':
                        Product product = new Product(name, price);
                        productList.Add(product);
                        break;
                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        string usedName = name + " (used) ";                        
                        productList.Add(new UsedProduct(usedName, price, date));
                        break;
                    case 'i':
                        Console.Write("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        var importedProduct = new ImportedProduct(name, price, fee);
                        importedProduct.TotalPrice();
                        productList.Add(importedProduct);
                        break;
                    default:
                        Product productDefault = new Product(name, price);
                        productList.Add(productDefault);
                        break;
                }
            }

            Console.WriteLine("\r\n****** Price Tags ******");
            foreach(Product p in productList)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
