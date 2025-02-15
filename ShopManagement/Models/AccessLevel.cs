using System;
using System.Collections.Generic;

namespace ShopManagement.Models;

public partial class AccessLevel
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Dbuser> Dbusers { get; set; } = new List<Dbuser>();
}
