using System;
using System.Collections.Generic;

#nullable disable

namespace SDL.Entities
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual StoreFront Store { get; set; }
    }
}
