using EnumsExample.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnumsExample.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(int id, DateTime moment, OrderStatus status)
        {
            Id = id;
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public override string ToString()
        {
            return
                $"Id: {Id.ToString()}, Data: {Moment}, {Status.ToString()}";
        }
    }
}
