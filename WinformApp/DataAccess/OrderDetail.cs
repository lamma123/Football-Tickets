using System;
using System.Collections.Generic;

namespace WinformApp.DataAccess;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public int? TicketId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public virtual Order Order { get; set; } = null!;
}
