using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bazar01.Models
{
    public class Order
    {
        public int Id { get; set; }
        

        public int BuyerId { get; set; }

        public int TransactionId { get; set; }

        public int ShippingId { get; set; }

        public bool IsOrderCompleted { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<ProductOrder> ProductOrder { get; set; }
    }
}
