using System;
using System.Collections.Generic;

namespace ShopManagement.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int PositionId { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public int? Experience { get; set; }

    public virtual Dbuser? Dbuser { get; set; }

    public virtual Position Position { get; set; } = null!;
}
