using System;
using System.Collections.Generic;

namespace ShopManagement.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public int Quantity { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CustomerOrdersDetail> CustomerOrdersDetails { get; set; } = new List<CustomerOrdersDetail>();

    public virtual ICollection<SupplierOrdersDetail> SupplierOrdersDetails { get; set; } = new List<SupplierOrdersDetail>();
}
