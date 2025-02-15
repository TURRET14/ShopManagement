using System;
using System.Collections.Generic;

namespace ShopManagement.Models;

public partial class Dbuser
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string UserLogin { get; set; } = null!;

    public string? UserPassword { get; set; }

    public int? Access { get; set; }

    public virtual AccessLevel? AccessNavigation { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
