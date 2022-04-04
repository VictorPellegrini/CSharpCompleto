using ExercicioDeFixacao132_EnumeracaoComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioDeFixacao132_EnumeracaoComposicao.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();        

        public Order(DateTime moment, OrderStatus status, Client client, List<OrderItem> items)
        {
            Moment = moment;
            Status = status;
            Client = client;
            Items = items;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach (OrderItem item in Items)
            {
                total += item.Price;
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            
            sb.Append("Client: ");
            sb.AppendLine(Client.ToString());
            
            sb.AppendLine("\r\nOrder items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            
            sb.Append("\r\nTotal price: $");
            sb.Append(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}