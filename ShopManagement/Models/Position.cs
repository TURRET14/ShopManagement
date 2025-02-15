﻿using System;
using System.Collections.Generic;

namespace ShopManagement.Models;

public partial class Position
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
