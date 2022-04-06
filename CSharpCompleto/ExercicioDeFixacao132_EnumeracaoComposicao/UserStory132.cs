using Section09132_EnumeracaoComposicao.Entities;
using Section09132_EnumeracaoComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Section09132_EnumeracaoComposicao
{
    public class UserStory132
    {
        static void Main()
        {
            Console.WriteLine("****** Enter client data ******");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birthdate (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            var client = new Client(name, email, birthdate);

            Console.WriteLine("\n****** Enter order data ******");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items in this order? ");
            int numberItems = int.Parse(Console.ReadLine());

            var listItems = new List<OrderItem>();
            var order = new Order(DateTime.Now, status, client, listItems);

            for (int i = 0; i < numberItems; i++)
            {
                Console.WriteLine($"\nEnter #{i + 1} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                var product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                var item = new OrderItem(productQuantity, product);
                order.AddItem(item);
            }

            Console.WriteLine("\n****** Order sumary ******");
            Console.WriteLine(order);

            Console.ReadLine();
        }
    }
}