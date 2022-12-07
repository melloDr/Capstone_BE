using System;
using System.Collections.Generic;

namespace Capstone_BE.Data.Entities;

public partial class Status
{
    public Guid StatusId { get; set; }

    public string? Name { get; set; }
}
