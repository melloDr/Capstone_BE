using System;
using System.Collections.Generic;

namespace Capstone_BE.Data.Entities;

public partial class Role
{
    public Guid RoleId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();
}
