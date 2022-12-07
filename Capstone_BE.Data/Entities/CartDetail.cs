using System;
using System.Collections.Generic;

namespace Capstone_BE.Data.Entities;

public partial class CartDetail
{
    public Guid CartDetailId { get; set; }

    public string? Service { get; set; }

    public Guid? ProductItemId { get; set; }

    public Guid? CartId { get; set; }

    public virtual Cart? Cart { get; set; }
}
