using DesafioSecao8.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSecao8.Entities
{
    internal class Order
    {
        public Client Client { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

  
        public Order() 
        { 
            Moment = DateTime.Now;
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
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {OrderStatus}");
            sb.AppendLine($"Cliente: {Client.ToString()}");
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total price: {Total()}");

            return sb.ToString();

        }
    }
}
