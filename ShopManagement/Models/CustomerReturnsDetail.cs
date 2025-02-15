using System;
using System.Collections.Generic;

namespace ShopManagement.Models;

public partial class CustomerReturnsDetail
{
    public int Id { get; set; }

    public int CustomerOrdersDetailsId { get; set; }

    public int Quantity { get; set; }

    public virtual CustomerOrdersDetail CustomerOrdersDetails { get; set; } = null!;
}
