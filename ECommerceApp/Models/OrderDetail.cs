using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerceApp.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public long? Quantity { get; set; }
        public long? UnitCost { get; set; }
        public int? ProductsId { get; set; }

        //public virtual Product Products { get; set; }
    }
}
