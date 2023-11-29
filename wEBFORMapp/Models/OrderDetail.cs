using System;
using System.Collections.Generic;

namespace wEBFORMapp.Models;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public int? TicketId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Ticket? Ticket { get; set; }
}
