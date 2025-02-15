using System;
using System.Collections.Generic;

namespace ShopManagement.Models;

public partial class SupplierOrdersDetail
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public int Price { get; set; }

    public int ReturnedQuantity { get; set; }

    public virtual SupplierOrder Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual ICollection<SupplierReturnsDetail> SupplierReturnsDetails { get; set; } = new List<SupplierReturnsDetail>();
}
