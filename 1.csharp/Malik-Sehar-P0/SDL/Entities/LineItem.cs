using System;
using System.Collections.Generic;

#nullable disable

namespace SDL.Entities
{
    public partial class LineItem
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
