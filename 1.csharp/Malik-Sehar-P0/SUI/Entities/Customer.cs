using System;
using System.Collections.Generic;

#nullable disable

namespace SUI.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNum { get; set; }
        public string CustomerAddress { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
