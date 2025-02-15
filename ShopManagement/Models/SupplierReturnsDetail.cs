using System;
using System.Collections.Generic;

namespace ShopManagement.Models;

public partial class SupplierReturnsDetail
{
    public int Id { get; set; }

    public int SupplierOrdersDetailsId { get; set; }

    public int Quantity { get; set; }

    public virtual SupplierOrdersDetail SupplierOrdersDetails { get; set; } = null!;
}
