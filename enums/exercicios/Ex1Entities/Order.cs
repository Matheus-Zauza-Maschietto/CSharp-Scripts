using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace enums.Ex1Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus status{ get; set; }

        public override string ToString()
        {
            return $"{Id}, {Moment}, {status}";
        }
    }

    public enum OrderStatus : int
    {
        PendingPayments = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
    

}