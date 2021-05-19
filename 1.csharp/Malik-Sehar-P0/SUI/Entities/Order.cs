using System;
using System.Collections.Generic;

#nullable disable

namespace SUI.Entities
{
    public partial class Order
    {
        public Order()
        {
            LineItems = new HashSet<LineItem>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? StoreFrontId { get; set; }
        public byte[] DateCreated { get; set; }
        public string Total { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual StoreFront StoreFront { get; set; }
        public virtual ICollection<LineItem> LineItems { get; set; }
    }
}
