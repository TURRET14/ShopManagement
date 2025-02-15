using System;
using System.Collections.Generic;

namespace ShopManagement.Models;

public partial class CustomerOrder
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public DateOnly Date { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<CustomerOrdersDetail> CustomerOrdersDetails { get; set; } = new List<CustomerOrdersDetail>();
}
