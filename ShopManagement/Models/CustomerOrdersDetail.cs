using System;
using System.Collections.Generic;

namespace ShopManagement.Models;

public partial class CustomerOrdersDetail
{
    public int Id { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public int Price { get; set; }

    public int ReturnedQuantity { get; set; }

    public virtual ICollection<CustomerReturnsDetail> CustomerReturnsDetails { get; set; } = new List<CustomerReturnsDetail>();

    public virtual CustomerOrder Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
