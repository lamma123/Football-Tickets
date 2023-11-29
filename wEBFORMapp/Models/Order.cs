using System;
using System.Collections.Generic;

namespace wEBFORMapp.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public string? Username { get; set; }

    public DateTime? Orderdate { get; set; }

    public string? Code { get; set; }

    public virtual OrderDetail? OrderDetail { get; set; }

    public virtual Account? UsernameNavigation { get; set; }
}
