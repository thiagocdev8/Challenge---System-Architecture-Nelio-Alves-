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
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus orderStatus)
        {
            Moment = moment;
            OrderStatus = orderStatus;
        }

        public Order()
        {
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
    }
}
