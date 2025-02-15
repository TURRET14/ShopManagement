using System;
using System.Collections.Generic;

namespace ShopManagement.Models;

public partial class SupplierOrder
{
    public int Id { get; set; }

    public int SupplierId { get; set; }

    public DateOnly Date { get; set; }

    public virtual Supplier Supplier { get; set; } = null!;

    public virtual ICollection<SupplierOrdersDetail> SupplierOrdersDetails { get; set; } = new List<SupplierOrdersDetail>();
}
